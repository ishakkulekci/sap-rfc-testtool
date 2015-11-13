namespace SapRfcTestTool
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSAPConnectionParameters = new System.Windows.Forms.TabPage();
            this.tabRFCExecute = new System.Windows.Forms.TabPage();
            this.lblASHOST = new System.Windows.Forms.Label();
            this.lblSYSNR = new System.Windows.Forms.Label();
            this.lblCLIENT = new System.Windows.Forms.Label();
            this.lblUSER = new System.Windows.Forms.Label();
            this.lblPASSWD = new System.Windows.Forms.Label();
            this.lblLANG = new System.Windows.Forms.Label();
            this.txtASHOST = new System.Windows.Forms.TextBox();
            this.txtSYSNR = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUSER = new System.Windows.Forms.TextBox();
            this.txtPASSWD = new System.Windows.Forms.TextBox();
            this.txtLANG = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPOOL_SIZE = new System.Windows.Forms.Label();
            this.lblMAX_POOL_SIZE = new System.Windows.Forms.Label();
            this.txtPOOL_SIZE = new System.Windows.Forms.TextBox();
            this.txtMAX_POOL_SIZE = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabSAPConnectionParameters.SuspendLayout();
            this.tabRFCExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSAPConnectionParameters);
            this.tabControl1.Controls.Add(this.tabRFCExecute);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSAPConnectionParameters
            // 
            this.tabSAPConnectionParameters.Controls.Add(this.txtMAX_POOL_SIZE);
            this.tabSAPConnectionParameters.Controls.Add(this.txtPOOL_SIZE);
            this.tabSAPConnectionParameters.Controls.Add(this.lblMAX_POOL_SIZE);
            this.tabSAPConnectionParameters.Controls.Add(this.lblPOOL_SIZE);
            this.tabSAPConnectionParameters.Controls.Add(this.txtLANG);
            this.tabSAPConnectionParameters.Controls.Add(this.txtPASSWD);
            this.tabSAPConnectionParameters.Controls.Add(this.txtUSER);
            this.tabSAPConnectionParameters.Controls.Add(this.textBox1);
            this.tabSAPConnectionParameters.Controls.Add(this.txtSYSNR);
            this.tabSAPConnectionParameters.Controls.Add(this.txtASHOST);
            this.tabSAPConnectionParameters.Controls.Add(this.lblLANG);
            this.tabSAPConnectionParameters.Controls.Add(this.lblPASSWD);
            this.tabSAPConnectionParameters.Controls.Add(this.lblUSER);
            this.tabSAPConnectionParameters.Controls.Add(this.lblCLIENT);
            this.tabSAPConnectionParameters.Controls.Add(this.lblSYSNR);
            this.tabSAPConnectionParameters.Controls.Add(this.lblASHOST);
            this.tabSAPConnectionParameters.Location = new System.Drawing.Point(4, 22);
            this.tabSAPConnectionParameters.Name = "tabSAPConnectionParameters";
            this.tabSAPConnectionParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tabSAPConnectionParameters.Size = new System.Drawing.Size(682, 347);
            this.tabSAPConnectionParameters.TabIndex = 0;
            this.tabSAPConnectionParameters.Text = "SAP Bağlantı Parametreleri";
            this.tabSAPConnectionParameters.UseVisualStyleBackColor = true;
            // 
            // tabRFCExecute
            // 
            this.tabRFCExecute.Controls.Add(this.dataGridView1);
            this.tabRFCExecute.Location = new System.Drawing.Point(4, 22);
            this.tabRFCExecute.Name = "tabRFCExecute";
            this.tabRFCExecute.Padding = new System.Windows.Forms.Padding(3);
            this.tabRFCExecute.Size = new System.Drawing.Size(682, 347);
            this.tabRFCExecute.TabIndex = 1;
            this.tabRFCExecute.Text = "RFC Çalıştırma";
            this.tabRFCExecute.UseVisualStyleBackColor = true;
            // 
            // lblASHOST
            // 
            this.lblASHOST.AutoSize = true;
            this.lblASHOST.Location = new System.Drawing.Point(6, 14);
            this.lblASHOST.Name = "lblASHOST";
            this.lblASHOST.Size = new System.Drawing.Size(174, 13);
            this.lblASHOST.TabIndex = 0;
            this.lblASHOST.Text = "ASHOST (Application Server Host):";
            // 
            // lblSYSNR
            // 
            this.lblSYSNR.AutoSize = true;
            this.lblSYSNR.Location = new System.Drawing.Point(26, 41);
            this.lblSYSNR.Name = "lblSYSNR";
            this.lblSYSNR.Size = new System.Drawing.Size(154, 13);
            this.lblSYSNR.TabIndex = 1;
            this.lblSYSNR.Text = "SYSNR (SAP System Number):";
            // 
            // lblCLIENT
            // 
            this.lblCLIENT.AutoSize = true;
            this.lblCLIENT.Location = new System.Drawing.Point(24, 70);
            this.lblCLIENT.Name = "lblCLIENT";
            this.lblCLIENT.Size = new System.Drawing.Size(156, 13);
            this.lblCLIENT.TabIndex = 2;
            this.lblCLIENT.Text = "CLIENT (SAP System Client Id):";
            // 
            // lblUSER
            // 
            this.lblUSER.AutoSize = true;
            this.lblUSER.Location = new System.Drawing.Point(373, 14);
            this.lblUSER.Name = "lblUSER";
            this.lblUSER.Size = new System.Drawing.Size(97, 13);
            this.lblUSER.TabIndex = 3;
            this.lblUSER.Text = "USER (Username):";
            // 
            // lblPASSWD
            // 
            this.lblPASSWD.AutoSize = true;
            this.lblPASSWD.Location = new System.Drawing.Point(333, 41);
            this.lblPASSWD.Name = "lblPASSWD";
            this.lblPASSWD.Size = new System.Drawing.Size(137, 13);
            this.lblPASSWD.TabIndex = 4;
            this.lblPASSWD.Text = "PASSWD (User Password):";
            // 
            // lblLANG
            // 
            this.lblLANG.AutoSize = true;
            this.lblLANG.Location = new System.Drawing.Point(374, 70);
            this.lblLANG.Name = "lblLANG";
            this.lblLANG.Size = new System.Drawing.Size(96, 13);
            this.lblLANG.TabIndex = 5;
            this.lblLANG.Text = "LANG (Language):";
            // 
            // txtASHOST
            // 
            this.txtASHOST.Location = new System.Drawing.Point(186, 11);
            this.txtASHOST.Name = "txtASHOST";
            this.txtASHOST.Size = new System.Drawing.Size(100, 20);
            this.txtASHOST.TabIndex = 6;
            // 
            // txtSYSNR
            // 
            this.txtSYSNR.Location = new System.Drawing.Point(186, 38);
            this.txtSYSNR.Name = "txtSYSNR";
            this.txtSYSNR.Size = new System.Drawing.Size(100, 20);
            this.txtSYSNR.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // txtUSER
            // 
            this.txtUSER.Location = new System.Drawing.Point(476, 11);
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(100, 20);
            this.txtUSER.TabIndex = 9;
            // 
            // txtPASSWD
            // 
            this.txtPASSWD.Location = new System.Drawing.Point(476, 38);
            this.txtPASSWD.Name = "txtPASSWD";
            this.txtPASSWD.Size = new System.Drawing.Size(100, 20);
            this.txtPASSWD.TabIndex = 10;
            // 
            // txtLANG
            // 
            this.txtLANG.Location = new System.Drawing.Point(476, 67);
            this.txtLANG.Name = "txtLANG";
            this.txtLANG.Size = new System.Drawing.Size(100, 20);
            this.txtLANG.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 222);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblPOOL_SIZE
            // 
            this.lblPOOL_SIZE.AutoSize = true;
            this.lblPOOL_SIZE.Location = new System.Drawing.Point(111, 112);
            this.lblPOOL_SIZE.Name = "lblPOOL_SIZE";
            this.lblPOOL_SIZE.Size = new System.Drawing.Size(69, 13);
            this.lblPOOL_SIZE.TabIndex = 12;
            this.lblPOOL_SIZE.Text = "POOL_SIZE:";
            // 
            // lblMAX_POOL_SIZE
            // 
            this.lblMAX_POOL_SIZE.AutoSize = true;
            this.lblMAX_POOL_SIZE.Location = new System.Drawing.Point(82, 140);
            this.lblMAX_POOL_SIZE.Name = "lblMAX_POOL_SIZE";
            this.lblMAX_POOL_SIZE.Size = new System.Drawing.Size(98, 13);
            this.lblMAX_POOL_SIZE.TabIndex = 13;
            this.lblMAX_POOL_SIZE.Text = "MAX_POOL_SIZE:";
            // 
            // txtPOOL_SIZE
            // 
            this.txtPOOL_SIZE.Location = new System.Drawing.Point(186, 109);
            this.txtPOOL_SIZE.Name = "txtPOOL_SIZE";
            this.txtPOOL_SIZE.Size = new System.Drawing.Size(100, 20);
            this.txtPOOL_SIZE.TabIndex = 14;
            // 
            // txtMAX_POOL_SIZE
            // 
            this.txtMAX_POOL_SIZE.Location = new System.Drawing.Point(186, 137);
            this.txtMAX_POOL_SIZE.Name = "txtMAX_POOL_SIZE";
            this.txtMAX_POOL_SIZE.Size = new System.Drawing.Size(100, 20);
            this.txtMAX_POOL_SIZE.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 397);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "SAP RFC Test Tool  - 2015.11.09.1700";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSAPConnectionParameters.ResumeLayout(false);
            this.tabSAPConnectionParameters.PerformLayout();
            this.tabRFCExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSAPConnectionParameters;
        private System.Windows.Forms.TabPage tabRFCExecute;
        private System.Windows.Forms.Label lblASHOST;
        private System.Windows.Forms.Label lblSYSNR;
        private System.Windows.Forms.Label lblLANG;
        private System.Windows.Forms.Label lblPASSWD;
        private System.Windows.Forms.Label lblUSER;
        private System.Windows.Forms.Label lblCLIENT;
        private System.Windows.Forms.TextBox txtASHOST;
        private System.Windows.Forms.TextBox txtSYSNR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtUSER;
        private System.Windows.Forms.TextBox txtPASSWD;
        private System.Windows.Forms.TextBox txtLANG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMAX_POOL_SIZE;
        private System.Windows.Forms.Label lblPOOL_SIZE;
        private System.Windows.Forms.TextBox txtPOOL_SIZE;
        private System.Windows.Forms.TextBox txtMAX_POOL_SIZE;
    }
}

