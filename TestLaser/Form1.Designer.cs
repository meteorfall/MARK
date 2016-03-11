namespace TestLaser
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblImportFile = new System.Windows.Forms.Label();
            this.btnMarkFile = new System.Windows.Forms.Button();
            this.lblImportMark = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.colCtnNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrintNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSaveExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.Location = new System.Drawing.Point(12, 9);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(121, 52);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "选打印清单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(920, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblImportFile
            // 
            this.lblImportFile.AutoSize = true;
            this.lblImportFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblImportFile.Location = new System.Drawing.Point(139, 21);
            this.lblImportFile.Name = "lblImportFile";
            this.lblImportFile.Size = new System.Drawing.Size(112, 27);
            this.lblImportFile.TabIndex = 2;
            this.lblImportFile.Text = "未选择文件";
            // 
            // btnMarkFile
            // 
            this.btnMarkFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMarkFile.Location = new System.Drawing.Point(379, 6);
            this.btnMarkFile.Name = "btnMarkFile";
            this.btnMarkFile.Size = new System.Drawing.Size(141, 55);
            this.btnMarkFile.TabIndex = 3;
            this.btnMarkFile.Text = "选模板文件";
            this.btnMarkFile.UseVisualStyleBackColor = true;
            this.btnMarkFile.Click += new System.EventHandler(this.btnMarkFile_Click);
            // 
            // lblImportMark
            // 
            this.lblImportMark.AutoSize = true;
            this.lblImportMark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblImportMark.Location = new System.Drawing.Point(526, 21);
            this.lblImportMark.Name = "lblImportMark";
            this.lblImportMark.Size = new System.Drawing.Size(112, 27);
            this.lblImportMark.TabIndex = 4;
            this.lblImportMark.Text = "未选择文件";
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCtnNO,
            this.colPName,
            this.colS1,
            this.ColE1,
            this.colS2,
            this.colE2,
            this.colStatus,
            this.colPrintNo});
            this.dgList.Location = new System.Drawing.Point(28, 85);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowTemplate.Height = 30;
            this.dgList.Size = new System.Drawing.Size(1113, 548);
            this.dgList.TabIndex = 5;
            // 
            // colCtnNO
            // 
            this.colCtnNO.DataPropertyName = "CTNNO";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colCtnNO.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCtnNO.HeaderText = "箱号";
            this.colCtnNO.Name = "colCtnNO";
            this.colCtnNO.ReadOnly = true;
            this.colCtnNO.Width = 60;
            // 
            // colPName
            // 
            this.colPName.DataPropertyName = "Pname";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colPName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPName.HeaderText = "产品号";
            this.colPName.Name = "colPName";
            this.colPName.ReadOnly = true;
            // 
            // colS1
            // 
            this.colS1.DataPropertyName = "S1";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colS1.DefaultCellStyle = dataGridViewCellStyle3;
            this.colS1.HeaderText = "起始号1";
            this.colS1.Name = "colS1";
            this.colS1.ReadOnly = true;
            this.colS1.Width = 150;
            // 
            // ColE1
            // 
            this.ColE1.DataPropertyName = "E1";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColE1.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColE1.HeaderText = "终止号1";
            this.ColE1.Name = "ColE1";
            this.ColE1.ReadOnly = true;
            this.ColE1.Width = 150;
            // 
            // colS2
            // 
            this.colS2.DataPropertyName = "S2";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colS2.DefaultCellStyle = dataGridViewCellStyle5;
            this.colS2.HeaderText = "起始号2";
            this.colS2.Name = "colS2";
            this.colS2.ReadOnly = true;
            this.colS2.Width = 150;
            // 
            // colE2
            // 
            this.colE2.DataPropertyName = "E2";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colE2.DefaultCellStyle = dataGridViewCellStyle6;
            this.colE2.HeaderText = "终止号2";
            this.colE2.Name = "colE2";
            this.colE2.ReadOnly = true;
            this.colE2.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "PrnStatus";
            this.colStatus.HeaderText = "状态";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 60;
            // 
            // colPrintNo
            // 
            this.colPrintNo.DataPropertyName = "LastPrnNo";
            this.colPrintNo.HeaderText = "最后打印号";
            this.colPrintNo.Name = "colPrintNo";
            this.colPrintNo.ReadOnly = true;
            this.colPrintNo.Width = 150;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(524, 55);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(389, 25);
            this.txtPath.TabIndex = 6;
            this.txtPath.Text = "D:\\HANS LASER\\Han\'s Laser Marking SoftwareV6_0_4";
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveExcel.Location = new System.Drawing.Point(1039, 6);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(113, 52);
            this.btnSaveExcel.TabIndex = 7;
            this.btnSaveExcel.Text = "保存退出";
            this.btnSaveExcel.UseVisualStyleBackColor = true;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.btnSaveExcel);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.lblImportMark);
            this.Controls.Add(this.btnMarkFile);
            this.Controls.Add(this.lblImportFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainDo";
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblImportFile;
        private System.Windows.Forms.Button btnMarkFile;
        private System.Windows.Forms.Label lblImportMark;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCtnNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrintNo;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSaveExcel;
    }
}

