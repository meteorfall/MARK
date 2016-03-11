using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestLaser
{
    public partial class prnForm : Form
    {
        public const int USER = 0x0400;
        public const int WM_TOUCH_MSG = USER + 1095;
        private bool errStatus = false;
        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_TOUCH_MSG:
                    DoSomethingWhenTouch();
                    break;
                default:
                    break;
            }
            base.DefWndProc(ref m);
        }
        private void DoSomethingWhenTouch()
        {
            DoMarkWithWaitingProgress();
        }

        private BackgroundWorker worker;
        private DataTable _mydt;
        private string _mfile;
        
        public prnForm(DataTable dt,string modelFile )
        {
            InitializeComponent();
            _mydt = dt;
            _mfile = modelFile;
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateDataRow(tbCurNo.Text);
            GetCurrentPrnInfo();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            DoMark();
            //System.Threading.Thread.Sleep(300);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            DoMarkWithWaitingProgress();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RollBackOne();
        }
        private void prnForm_Load(object sender, EventArgs e)
        {
            GetCurrentPrnInfo();
            if (OpenDect()==false)
            {
                errStatus = true;
            }
            UpdateUIByStatus();
        }
        private void prnForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseDect();
            
            CSharpInterface.HS_CloseMachine();
        }

        private void UpdateUIByStatus()
        {
            btnStart.Enabled = !errStatus;
            btnBack.Enabled = !errStatus;
        }


        #region 激光操作相关方法
        private bool OpenDect()
        {
            int nRet = CSharpInterface.HS_CheckTouch(this.Handle, true);
            if (nRet != 0)
            {
                UptLabel(CSharpInterface.ShowLastError());
                return false;
            }
            else
            {
                return true;
            }
        }
        private void CloseDect()
        {
            int nRet = CSharpInterface.HS_CheckTouch(this.Handle, false);
            if (nRet != 0)
            {
                MessageBox.Show("ERROR ON CLOSE TOUCH DECT:" + CSharpInterface.ShowLastError());
            }
            
        }
        private void CloseModelFile()
        {
            int nRet = CSharpInterface.HS_CloseMarkFile(_mfile, false);
            if (nRet != 0)
            {
                MessageBox.Show("关闭模板失败:" + CSharpInterface.ShowLastError());
            }
    
        }
        private void DoMark()
        {
            //先对文本赋值
            if(tbCurNo.Text=="")
            {
                return;
            }
            SetPrnText("PrnText", tbCurNo.Text);
            //打印
            int nRet = CSharpInterface.HS_Mark(0, false, true, 0, true);
            if (0 == nRet)
            {
            }
            else
            {
                UptLabel("Mark Fail:" + CSharpInterface.ShowLastError());
            }
        }
        private void SetPrnText(string tagName, string content)
        {
            int nRet = CSharpInterface.HS_ChangeTextByName(tagName, content);
            if (0 == nRet)
            {
            }
            else
            {
                UptLabel("SetPrnText Fail:" +CSharpInterface. ShowLastError());
            }
        }
        #endregion


        private void DoMarkWithWaitingProgress()
        {
            worker.RunWorkerAsync();
            WaitForm wf = new WaitForm(this.worker);
            wf.ShowDialog();
        }

        private int recordIndex;

        /// <summary>
        /// 回滚到上一条记录,准备重打之用
        /// </summary>
        private void RollBackOne()
        {
            string curNo = tbCurNo.Text;
            if(recordIndex==-1)//如果已经打印完,则回滚到清单的最后一条记录
            {
                DataRow lastRow = _mydt.Rows[_mydt.Rows.Count - 1];
                
                lastRow["PrnStatus"] = "打印中";
                lastRow["LastPrnNo"]= GetPreNo(lastRow);
                GetCurrentPrnInfo();
                return;
            }
            DataRow row = _mydt.Rows[recordIndex];
            if(row["PrnStatus"].ToString().Trim()=="未打印")
            {
                DataRow preRow = _mydt.Rows[recordIndex - 1];
                
                preRow["PrnStatus"] = "打印中";
                preRow["LastPrnNo"] = GetPreNo(preRow);
            }
            else if(row["PrnStatus"].ToString().Trim()=="打印中")  //打印中
            {
                row["LastPrnNo"] = GetPreNo(row);
                if(row["LastPrnNo"].ToString().Trim()=="")
                {
                    row["PrnStatus"] = "未打印";
                }
            }
            else
            {
                throw new Exception("回滚上一条操作时,当前打印记录状态异常:" + row["PrnStatus"].ToString());
            }
            GetCurrentPrnInfo();
        }
        
        /// <summary>
        /// 依据记录行得到上一条流水号的上一条流水号
        /// </summary>
        /// <param name="recNo"></param>
        /// <returns></returns>
        private string GetPreNo(DataRow row)
        {
            string ret = "";
            string recNo = row["LastPrnNo"].ToString().Trim();
            if(recNo==row["S1"].ToString().Trim())
            {
                ret = "";
            }
            else if(row["S2"].ToString().Trim()==recNo)
            {
                ret = row["E1"].ToString();
            }
            else
            {
                ret = UtilTool.GetPreSeqNo(recNo,5);
            }
            return ret;
        }

        /// <summary>
        /// 设置当前待打印的记录信息
        /// </summary>
        private void GetCurrentPrnInfo()
        {
            DataRow row;
            tbCurNo.Text= CurPrintNo();
            if(recordIndex==-1)//清单结束
            {
                lbFinish.Visible = true;
                btnStart.Enabled = false;
                tbCurPdt.Text = "";
                tbCurCtn.Text ="";
                //关闭脚踏探测
                CloseDect();
            }
            else
            {
                lbFinish.Visible = false;
                btnStart.Enabled = true;
                row = _mydt.Rows[recordIndex];
                lbChangePdt.Visible = (tbCurPdt.Text != row["Pname"].ToString());
                lbChangeCtn.Visible = (tbCurCtn.Text != row["CTNNO"].ToString());
                tbCurPdt.Text = row["Pname"].ToString();
                tbCurCtn.Text = row["CTNNO"].ToString();
            }
            

            
        }
        /// <summary>
        /// 得到当前打印记录信息
        /// </summary>
        /// <returns></returns>
        private string CurPrintNo()
        {
            string curText = "";
            string lastNo;
            recordIndex = -1;
            for (int i = 0; i < _mydt.Rows.Count; i++)
            {
                DataRow row = _mydt.Rows[i];
                lastNo = row["LastPrnNo"].ToString();
                if (row["PrnStatus"].ToString() == "未打印" || row["PrnStatus"].ToString() == "打印中")
                {
                    if (lastNo == "")
                    {
                        curText = row["S1"].ToString();
                    }
                    else
                    {
                        if (string.Compare(lastNo, row["E1"].ToString()) < 0)
                        {
                            curText = UtilTool.GetNextSeqNo(lastNo, 5);
                        }
                        else if (string.Compare(lastNo, row["E1"].ToString()) == 0)
                        {
                            curText = row["S2"].ToString();
                        }
                        else if (string.Compare(lastNo, row["E2"].ToString()) < 0)
                        {
                            curText = UtilTool.GetNextSeqNo(lastNo, 5);
                        }
                    }
                    recordIndex = i;
                    break;
                }
            }
            return curText;
        }
        private void UpdateDataRow(string curNo)
        {
            DataRow row = _mydt.Rows[recordIndex];
            if(row["E2"].ToString().Trim()==curNo.Trim() || (row["E1"].ToString().Trim() == curNo.Trim() && row["S2"].ToString().Trim() == ""))
            {
                row["PrnStatus"] = "打印完";
                row["LastPrnNo"] = curNo;
                recordIndex = recordIndex + 1;
            }
            else
            {
                row["PrnStatus"] = "打印中";
                row["LastPrnNo"] = curNo;
            }
        }



        private delegate void UptLabelDelegate(string uptText);
        private void UptLabel(string uptText)
        {
            if (txtNote.InvokeRequired)
            {
                UptLabelDelegate d = new UptLabelDelegate(UptLabel);
                this.Invoke(d, new object[] { uptText });
            }
            else
            {
                txtNote.Text = uptText;
            }
        }
    }
}
