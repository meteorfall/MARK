namespace TestLaser
{
    partial class frmTestLaser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectModel = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenDect = new System.Windows.Forms.Button();
            this.btnCloseDect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectModel
            // 
            this.btnSelectModel.Location = new System.Drawing.Point(63, 12);
            this.btnSelectModel.Name = "btnSelectModel";
            this.btnSelectModel.Size = new System.Drawing.Size(114, 37);
            this.btnSelectModel.TabIndex = 0;
            this.btnSelectModel.Text = "选择模板";
            this.btnSelectModel.UseVisualStyleBackColor = true;
            this.btnSelectModel.Click += new System.EventHandler(this.btnSelectModel_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(91, 169);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(201, 25);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "X03051600002";
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(314, 161);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(130, 37);
            this.btnMark.TabIndex = 2;
            this.btnMark.Text = "设置文本";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(533, 57);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(140, 33);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(533, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(357, 112);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(128, 25);
            this.txtTagName.TabIndex = 6;
            this.txtTagName.Text = "PrnText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "标签别名";
            // 
            // btnOpenDect
            // 
            this.btnOpenDect.Location = new System.Drawing.Point(131, 259);
            this.btnOpenDect.Name = "btnOpenDect";
            this.btnOpenDect.Size = new System.Drawing.Size(141, 35);
            this.btnOpenDect.TabIndex = 8;
            this.btnOpenDect.Text = "打开脚踏探测";
            this.btnOpenDect.UseVisualStyleBackColor = true;
            this.btnOpenDect.Click += new System.EventHandler(this.btnOpenDect_Click);
            // 
            // btnCloseDect
            // 
            this.btnCloseDect.Location = new System.Drawing.Point(327, 259);
            this.btnCloseDect.Name = "btnCloseDect";
            this.btnCloseDect.Size = new System.Drawing.Size(141, 35);
            this.btnCloseDect.TabIndex = 8;
            this.btnCloseDect.Text = "关闭脚踏探测";
            this.btnCloseDect.UseVisualStyleBackColor = true;
            this.btnCloseDect.Click += new System.EventHandler(this.btnCloseDect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dect Status:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(304, 229);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(47, 15);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Close";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNote.Location = new System.Drawing.Point(227, 318);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(88, 24);
            this.lbNote.TabIndex = 10;
            this.lbNote.Text = "label4";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(42, 63);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(463, 25);
            this.txtPath.TabIndex = 11;
            // 
            // frmTestLaser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseDect);
            this.Controls.Add(this.btnOpenDect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTagName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSelectModel);
            this.Name = "frmTestLaser";
            this.Text = "frmTestLaser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectModel;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenDect;
        private System.Windows.Forms.Button btnCloseDect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txtPath;
    }
}