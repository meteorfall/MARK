using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TestLaser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt;
        private bool isListPrepared = false;
        private bool isModelPrepared = false;
        private string _safeFile;
        private string _xlsFile;
        private void BindDataView()
        {
            if(dt!=null)
            {
                if(dt.Rows.Count>0)
                {
                    for (int i=0;i<dt.Rows.Count;i++)
                    {
                        if(dt.Rows[i]["PrnStatus"].ToString().Trim()=="")
                        {
                            dt.Rows[i]["PrnStatus"] = "未打印";
                        }
                    }
                }
                dgList.DataSource = dt;
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " Excel文件|*.xls;*.xlsx ";
            if(openFileDialog1.ShowDialog()!=DialogResult.Cancel)
            {
                lblImportFile.Text =openFileDialog1.SafeFileName ;
                _xlsFile = openFileDialog1.FileName;
                OleDbConnection conn = ExcelHelper.CreateConnection(openFileDialog1.FileName, ExcelHelper.ExcelVerion.Excel2003);
                string strSql = "SELECT CTNNO,Pname,S1,E1,S2,E2,PrnStatus,LastPrnNo FROM [Data$]";
                dt = ExcelHelper.ExecuteDataTable(conn, strSql);
                BindDataView();
                isListPrepared = true;
            }
            
        }


        private void btnMarkFile_Click(object sender, EventArgs e)
        {
            InitMachine(txtPath.Text);
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "HS File(*.HS)|*.HS";
            openFileDialog1.Title = "Improt Hans file";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            OpenModelFile(openFileDialog1.FileName, openFileDialog1.SafeFileName);
   
        }




        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!isListPrepared)
            {
                MessageBox.Show("清单未导入");
                return;
            }
            if (!isModelPrepared)
            {
                MessageBox.Show("模板文件未导入");
                return;
            }

            StartPrint();
            BindDataView();

        }
        private void StartPrint()
        {
            prnForm pf = new prnForm(dt, _safeFile);
            pf.ShowDialog();
        }


        private void OpenModelFile(string fullPathFile, string safeFile)
        {
            int nRet = CSharpInterface.HS_LoadMarkFile(fullPathFile);
            if (0 == nRet)
            {
                lblImportMark.Text = " [" + safeFile + "] succeed!";
                _safeFile = safeFile;
                isModelPrepared = true;
            }
            else
            {
                MessageBox.Show("打开模板文件失败:" + CSharpInterface.ShowLastError());
            }
        }

        private bool InitMachine(string pathName)
        {
            bool ret = false;
            int nRet = CSharpInterface.HS_InitialMachine(pathName);
            if (nRet == 0)
            {
                CSharpInterface.g_strPathName = pathName;
                double px = 0, py = 0;
                CSharpInterface.HS_GetMarkRange(ref px, ref py);
                ret = true;
            }
            else
            {
                ret = false;
                MessageBox.Show("初始化失败:" + CSharpInterface.ShowLastError());
            }
            return ret;
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            if(_xlsFile!="")
            {
                ExcelHelper.UpdateExcelByDatatable(ExcelHelper.CreateConnection(_xlsFile, ExcelHelper.ExcelVerion.Excel2003),
                "DATA$", dt, "S1", new string[] { "PrnStatus", "LastPrnNo" });
            }
            this.Close();
        }
    }
}
