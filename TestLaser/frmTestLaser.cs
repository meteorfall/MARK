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
    public partial class frmTestLaser : Form
    {
        public const int USER = 0x0400;
        public const int WM_TOUCH_MSG = USER + 1095;

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
            DoMark();
        }

        public frmTestLaser()
        {
            InitializeComponent();
        }

        private void btnSelectModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "HS File(*.HS)|*.HS";
            openFileDialog1.Title = "Improt Hans file";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            OpenModelFile(openFileDialog1.FileName,openFileDialog1.SafeFileName);
        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            InitMachine(txtPath.Text);
        }
        private void btnMark_Click(object sender, EventArgs e)
        {
            SetPrnText(txtTagName.Text, txtContent.Text);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseModelFile();
            FreeMachine();
        }


        private void btnOpenDect_Click(object sender, EventArgs e)
        {
            OpenDect();
        }

        private void btnCloseDect_Click(object sender, EventArgs e)
        {
            CloseDect();
        }


        private void InitMachine(string pathName)
        {
            //string strCurPath = System.Environment.CurrentDirectory;     //获取当前路径
            int nRet = CSharpInterface.HS_InitialMachine(pathName);
            if (nRet == 0)
            {
                CSharpInterface.g_strPathName = pathName;
                double px = 0, py = 0;
                CSharpInterface.HS_GetMarkRange(ref px, ref py);
                UpdateStatusLabel("初始化成功,打标范围:" + px.ToString() + "*" + py.ToString() + "mm");
                //MessageBox.Show("初始化成功,打标范围:" + px.ToString() + "*" + py.ToString() + "mm");
            }
            else
            {
                UpdateStatusLabel("初始化失败:" + ShowLastError());
                //MessageBox.Show("初始化失败:"+ShowLastError());
            }
        }

        private string _safeFile;
        private void OpenModelFile(string fullPathFile,string safeFile)
        {
            int nRet = CSharpInterface.HS_LoadMarkFile(fullPathFile);
            if (0 == nRet)
            {
                label1.Text = "open module file [" + safeFile + "] succeed!";
                _safeFile = safeFile;
            }
            else
            {
                UpdateStatusLabel("打开模板失败:" + ShowLastError());
            }
        }
        private void CloseModelFile()
        {
            int nRet = CSharpInterface.HS_CloseMarkFile(_safeFile, false);
            if (nRet == 0)
            {
                UpdateStatusLabel("Close Model File Success!");
            }
            else
            {
                UpdateStatusLabel("关闭模板失败:" + ShowLastError());
            }
            
        }
        private void FreeMachine()
        {
            CSharpInterface.HS_CloseMachine();
        }

        private void SetPrnText(string tagName,string content)
        {
            int nRet = CSharpInterface.HS_ChangeTextByName(tagName, content);
            if (0 == nRet)
            {
                UpdateStatusLabel("SetPrnText Success!");
            }
            else
            {
                UpdateStatusLabel("SetPrnText Fail:" + ShowLastError());
            }
        }
        private void OpenDect()
        {
            int nRet = CSharpInterface.HS_CheckTouch(this.Handle, true);
            if (nRet != 0)
            {
                ShowLastError();
            }
            else
            {
                this.lbStatus.Text = "Open";
            }
        }
        private void CloseDect()
        {
            int nRet = CSharpInterface.HS_CheckTouch(this.Handle, false);
            if (nRet != 0)
            {
                ShowLastError();
            }
            else
            {
                this.lbStatus.Text = "Close";
            }
        }
        private void DoMark()
        {

            int nRet = CSharpInterface.HS_Mark(0, false, true, 0, true);
            if (0 == nRet)
            {
                UpdateStatusLabel("打标成功");
            }
            else
            {
                UpdateStatusLabel("Mark Fail:" + ShowLastError());
            }
        }

        private delegate void UptLabelDelegate(string uptText);
        private void UpdateStatusLabel(string uptText)
        {
            if (lbNote.InvokeRequired)
            {
                UptLabelDelegate d = new UptLabelDelegate(UpdateStatusLabel);
                this.Invoke(d, new object[] { uptText });
            }
            else
            {
                lbNote.Text = uptText;
            }
        }


        //显示错误信息
        private string ShowLastError()
        {
            int nErr = 0;
            StringBuilder szBuff = new StringBuilder(200);
            CSharpInterface.HS_GetLastError(ref nErr, szBuff, 200);
            return szBuff.ToString();
        }

    }
}
