using System;

namespace TestLaser
{
    partial class prnForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCurCtn = new System.Windows.Forms.TextBox();
            this.tbCurPdt = new System.Windows.Forms.TextBox();
            this.tbCurNo = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbChangePdt = new System.Windows.Forms.Label();
            this.lbChangeCtn = new System.Windows.Forms.Label();
            this.lbFinish = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(468, 56);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "手动打印";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFinish);
            this.panel1.Controls.Add(this.lbChangeCtn);
            this.panel1.Controls.Add(this.lbChangePdt);
            this.panel1.Controls.Add(this.tbCurCtn);
            this.panel1.Controls.Add(this.tbCurPdt);
            this.panel1.Controls.Add(this.tbCurNo);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 488);
            this.panel1.TabIndex = 2;
            // 
            // tbCurCtn
            // 
            this.tbCurCtn.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCurCtn.Location = new System.Drawing.Point(122, 330);
            this.tbCurCtn.Name = "tbCurCtn";
            this.tbCurCtn.Size = new System.Drawing.Size(155, 51);
            this.tbCurCtn.TabIndex = 5;
            // 
            // tbCurPdt
            // 
            this.tbCurPdt.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCurPdt.Location = new System.Drawing.Point(122, 242);
            this.tbCurPdt.Name = "tbCurPdt";
            this.tbCurPdt.Size = new System.Drawing.Size(211, 51);
            this.tbCurPdt.TabIndex = 5;
            // 
            // tbCurNo
            // 
            this.tbCurNo.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCurNo.Location = new System.Drawing.Point(174, 126);
            this.tbCurNo.Name = "tbCurNo";
            this.tbCurNo.Size = new System.Drawing.Size(316, 51);
            this.tbCurNo.TabIndex = 5;
            this.tbCurNo.Text = "X1616163330";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txtNote.Location = new System.Drawing.Point(12, 6);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(577, 38);
            this.txtNote.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(248, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "回退上一条";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "箱号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "产品:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "待打印:";
            // 
            // lbChangePdt
            // 
            this.lbChangePdt.AutoSize = true;
            this.lbChangePdt.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChangePdt.ForeColor = System.Drawing.Color.Red;
            this.lbChangePdt.Location = new System.Drawing.Point(352, 249);
            this.lbChangePdt.Name = "lbChangePdt";
            this.lbChangePdt.Size = new System.Drawing.Size(237, 31);
            this.lbChangePdt.TabIndex = 6;
            this.lbChangePdt.Text = "请注意,已经更换产品";
            this.lbChangePdt.Visible = false;
            // 
            // lbChangeCtn
            // 
            this.lbChangeCtn.AutoSize = true;
            this.lbChangeCtn.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChangeCtn.ForeColor = System.Drawing.Color.Red;
            this.lbChangeCtn.Location = new System.Drawing.Point(301, 341);
            this.lbChangeCtn.Name = "lbChangeCtn";
            this.lbChangeCtn.Size = new System.Drawing.Size(189, 31);
            this.lbChangeCtn.TabIndex = 6;
            this.lbChangeCtn.Text = "请注意,已经换箱";
            this.lbChangeCtn.Visible = false;
            // 
            // lbFinish
            // 
            this.lbFinish.AutoSize = true;
            this.lbFinish.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFinish.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbFinish.Location = new System.Drawing.Point(59, 407);
            this.lbFinish.Name = "lbFinish";
            this.lbFinish.Size = new System.Drawing.Size(281, 50);
            this.lbFinish.TabIndex = 6;
            this.lbFinish.Text = "清单已打印完成";
            this.lbFinish.Visible = false;
            // 
            // prnForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(616, 488);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "prnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "打印";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.prnForm_FormClosing);
            this.Load += new System.EventHandler(this.prnForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox tbCurCtn;
        private System.Windows.Forms.TextBox tbCurPdt;
        private System.Windows.Forms.TextBox tbCurNo;
        private System.Windows.Forms.Label lbChangeCtn;
        private System.Windows.Forms.Label lbChangePdt;
        private System.Windows.Forms.Label lbFinish;
    }
}