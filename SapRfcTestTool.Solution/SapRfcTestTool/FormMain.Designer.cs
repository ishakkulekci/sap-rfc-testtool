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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabSAPConnectionParameters = new System.Windows.Forms.TabPage();
            this.lblTestConnectionResult = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtMAX_POOL_SIZE = new System.Windows.Forms.TextBox();
            this.txtPOOL_SIZE = new System.Windows.Forms.TextBox();
            this.lblMAX_POOL_SIZE = new System.Windows.Forms.Label();
            this.lblPOOL_SIZE = new System.Windows.Forms.Label();
            this.txtLANG = new System.Windows.Forms.TextBox();
            this.txtPASSWD = new System.Windows.Forms.TextBox();
            this.txtUSER = new System.Windows.Forms.TextBox();
            this.txtCLIENT = new System.Windows.Forms.TextBox();
            this.txtSYSNR = new System.Windows.Forms.TextBox();
            this.txtASHOST = new System.Windows.Forms.TextBox();
            this.lblLANG = new System.Windows.Forms.Label();
            this.lblPASSWD = new System.Windows.Forms.Label();
            this.lblUSER = new System.Windows.Forms.Label();
            this.lblCLIENT = new System.Windows.Forms.Label();
            this.lblSYSNR = new System.Windows.Forms.Label();
            this.lblASHOST = new System.Windows.Forms.Label();
            this.tabRFCExecute = new System.Windows.Forms.TabPage();
            this.tcTablesToExport = new System.Windows.Forms.TabControl();
            this.gvExportParams = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRFCExecute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tcTablesToImport = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRFCGetParameter = new System.Windows.Forms.Button();
            this.txtRFCName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvImportParams = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOptional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDocumentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNucLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUcLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDecimals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMain.SuspendLayout();
            this.tabSAPConnectionParameters.SuspendLayout();
            this.tabRFCExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExportParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImportParams)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabSAPConnectionParameters);
            this.tcMain.Controls.Add(this.tabRFCExecute);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(706, 1213);
            this.tcMain.TabIndex = 0;
            // 
            // tabSAPConnectionParameters
            // 
            this.tabSAPConnectionParameters.Controls.Add(this.lblTestConnectionResult);
            this.tabSAPConnectionParameters.Controls.Add(this.btnTestConnection);
            this.tabSAPConnectionParameters.Controls.Add(this.txtMAX_POOL_SIZE);
            this.tabSAPConnectionParameters.Controls.Add(this.txtPOOL_SIZE);
            this.tabSAPConnectionParameters.Controls.Add(this.lblMAX_POOL_SIZE);
            this.tabSAPConnectionParameters.Controls.Add(this.lblPOOL_SIZE);
            this.tabSAPConnectionParameters.Controls.Add(this.txtLANG);
            this.tabSAPConnectionParameters.Controls.Add(this.txtPASSWD);
            this.tabSAPConnectionParameters.Controls.Add(this.txtUSER);
            this.tabSAPConnectionParameters.Controls.Add(this.txtCLIENT);
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
            this.tabSAPConnectionParameters.Size = new System.Drawing.Size(698, 1187);
            this.tabSAPConnectionParameters.TabIndex = 0;
            this.tabSAPConnectionParameters.Text = "SAP Bağlantı Parametreleri";
            this.tabSAPConnectionParameters.UseVisualStyleBackColor = true;
            this.tabSAPConnectionParameters.Click += new System.EventHandler(this.tabSAPConnectionParameters_Click);
            // 
            // lblTestConnectionResult
            // 
            this.lblTestConnectionResult.AutoSize = true;
            this.lblTestConnectionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTestConnectionResult.Location = new System.Drawing.Point(6, 238);
            this.lblTestConnectionResult.Name = "lblTestConnectionResult";
            this.lblTestConnectionResult.Size = new System.Drawing.Size(145, 13);
            this.lblTestConnectionResult.TabIndex = 17;
            this.lblTestConnectionResult.Text = "lblTestConnectionResult";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(9, 191);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(277, 23);
            this.btnTestConnection.TabIndex = 16;
            this.btnTestConnection.Text = "Bağlantı Bilgilerini Hafızaya Al ve Bağlantı Testi Yap";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtMAX_POOL_SIZE
            // 
            this.txtMAX_POOL_SIZE.Location = new System.Drawing.Point(186, 137);
            this.txtMAX_POOL_SIZE.Name = "txtMAX_POOL_SIZE";
            this.txtMAX_POOL_SIZE.Size = new System.Drawing.Size(100, 20);
            this.txtMAX_POOL_SIZE.TabIndex = 15;
            // 
            // txtPOOL_SIZE
            // 
            this.txtPOOL_SIZE.Location = new System.Drawing.Point(186, 109);
            this.txtPOOL_SIZE.Name = "txtPOOL_SIZE";
            this.txtPOOL_SIZE.Size = new System.Drawing.Size(100, 20);
            this.txtPOOL_SIZE.TabIndex = 14;
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
            // lblPOOL_SIZE
            // 
            this.lblPOOL_SIZE.AutoSize = true;
            this.lblPOOL_SIZE.Location = new System.Drawing.Point(111, 112);
            this.lblPOOL_SIZE.Name = "lblPOOL_SIZE";
            this.lblPOOL_SIZE.Size = new System.Drawing.Size(69, 13);
            this.lblPOOL_SIZE.TabIndex = 12;
            this.lblPOOL_SIZE.Text = "POOL_SIZE:";
            // 
            // txtLANG
            // 
            this.txtLANG.Location = new System.Drawing.Point(476, 67);
            this.txtLANG.Name = "txtLANG";
            this.txtLANG.Size = new System.Drawing.Size(100, 20);
            this.txtLANG.TabIndex = 11;
            // 
            // txtPASSWD
            // 
            this.txtPASSWD.Location = new System.Drawing.Point(476, 38);
            this.txtPASSWD.Name = "txtPASSWD";
            this.txtPASSWD.Size = new System.Drawing.Size(100, 20);
            this.txtPASSWD.TabIndex = 10;
            // 
            // txtUSER
            // 
            this.txtUSER.Location = new System.Drawing.Point(476, 11);
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(100, 20);
            this.txtUSER.TabIndex = 9;
            // 
            // txtCLIENT
            // 
            this.txtCLIENT.Location = new System.Drawing.Point(186, 67);
            this.txtCLIENT.Name = "txtCLIENT";
            this.txtCLIENT.Size = new System.Drawing.Size(100, 20);
            this.txtCLIENT.TabIndex = 8;
            // 
            // txtSYSNR
            // 
            this.txtSYSNR.Location = new System.Drawing.Point(186, 38);
            this.txtSYSNR.Name = "txtSYSNR";
            this.txtSYSNR.Size = new System.Drawing.Size(100, 20);
            this.txtSYSNR.TabIndex = 7;
            // 
            // txtASHOST
            // 
            this.txtASHOST.Location = new System.Drawing.Point(186, 11);
            this.txtASHOST.Name = "txtASHOST";
            this.txtASHOST.Size = new System.Drawing.Size(100, 20);
            this.txtASHOST.TabIndex = 6;
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
            // lblPASSWD
            // 
            this.lblPASSWD.AutoSize = true;
            this.lblPASSWD.Location = new System.Drawing.Point(333, 41);
            this.lblPASSWD.Name = "lblPASSWD";
            this.lblPASSWD.Size = new System.Drawing.Size(137, 13);
            this.lblPASSWD.TabIndex = 4;
            this.lblPASSWD.Text = "PASSWD (User Password):";
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
            // lblCLIENT
            // 
            this.lblCLIENT.AutoSize = true;
            this.lblCLIENT.Location = new System.Drawing.Point(24, 70);
            this.lblCLIENT.Name = "lblCLIENT";
            this.lblCLIENT.Size = new System.Drawing.Size(156, 13);
            this.lblCLIENT.TabIndex = 2;
            this.lblCLIENT.Text = "CLIENT (SAP System Client Id):";
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
            // lblASHOST
            // 
            this.lblASHOST.AutoSize = true;
            this.lblASHOST.Location = new System.Drawing.Point(6, 14);
            this.lblASHOST.Name = "lblASHOST";
            this.lblASHOST.Size = new System.Drawing.Size(174, 13);
            this.lblASHOST.TabIndex = 0;
            this.lblASHOST.Text = "ASHOST (Application Server Host):";
            // 
            // tabRFCExecute
            // 
            this.tabRFCExecute.Controls.Add(this.tcTablesToExport);
            this.tabRFCExecute.Controls.Add(this.gvExportParams);
            this.tabRFCExecute.Controls.Add(this.label5);
            this.tabRFCExecute.Controls.Add(this.btnRFCExecute);
            this.tabRFCExecute.Controls.Add(this.label4);
            this.tabRFCExecute.Controls.Add(this.tcTablesToImport);
            this.tabRFCExecute.Controls.Add(this.label3);
            this.tabRFCExecute.Controls.Add(this.label2);
            this.tabRFCExecute.Controls.Add(this.btnRFCGetParameter);
            this.tabRFCExecute.Controls.Add(this.txtRFCName);
            this.tabRFCExecute.Controls.Add(this.label1);
            this.tabRFCExecute.Controls.Add(this.gvImportParams);
            this.tabRFCExecute.Location = new System.Drawing.Point(4, 22);
            this.tabRFCExecute.Name = "tabRFCExecute";
            this.tabRFCExecute.Padding = new System.Windows.Forms.Padding(3);
            this.tabRFCExecute.Size = new System.Drawing.Size(715, 1187);
            this.tabRFCExecute.TabIndex = 1;
            this.tabRFCExecute.Text = "RFC Çalıştırma";
            this.tabRFCExecute.UseVisualStyleBackColor = true;
            // 
            // tcTablesToExport
            // 
            this.tcTablesToExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTablesToExport.Location = new System.Drawing.Point(9, 868);
            this.tcTablesToExport.Name = "tcTablesToExport";
            this.tcTablesToExport.SelectedIndex = 0;
            this.tcTablesToExport.Size = new System.Drawing.Size(717, 265);
            this.tcTablesToExport.TabIndex = 13;
            // 
            // gvExportParams
            // 
            this.gvExportParams.AllowUserToAddRows = false;
            this.gvExportParams.AllowUserToDeleteRows = false;
            this.gvExportParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvExportParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExportParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.gvExportParams.Location = new System.Drawing.Point(9, 645);
            this.gvExportParams.Name = "gvExportParams";
            this.gvExportParams.Size = new System.Drawing.Size(717, 184);
            this.gvExportParams.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NewValue";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "New Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Optional";
            this.dataGridViewTextBoxColumn3.HeaderText = "Optional";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataType";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DefaultValue";
            this.dataGridViewTextBoxColumn5.HeaderText = "DefaultValue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Direction";
            this.dataGridViewTextBoxColumn6.HeaderText = "Direction";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Documentation";
            this.dataGridViewTextBoxColumn7.HeaderText = "Documentation";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NucLength";
            this.dataGridViewTextBoxColumn8.HeaderText = "NucLength";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UcLength";
            this.dataGridViewTextBoxColumn9.HeaderText = "UcLength";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Decimals";
            this.dataGridViewTextBoxColumn10.HeaderText = "Decimals";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Export Parameters:";
            // 
            // btnRFCExecute
            // 
            this.btnRFCExecute.Location = new System.Drawing.Point(9, 580);
            this.btnRFCExecute.Name = "btnRFCExecute";
            this.btnRFCExecute.Size = new System.Drawing.Size(103, 23);
            this.btnRFCExecute.TabIndex = 10;
            this.btnRFCExecute.Text = "RFC\'yi Çalıştır";
            this.btnRFCExecute.UseVisualStyleBackColor = true;
            this.btnRFCExecute.Click += new System.EventHandler(this.btnRFCExecute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 847);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tables:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tcTablesToImport
            // 
            this.tcTablesToImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTablesToImport.Location = new System.Drawing.Point(9, 300);
            this.tcTablesToImport.Name = "tcTablesToImport";
            this.tcTablesToImport.SelectedIndex = 0;
            this.tcTablesToImport.Size = new System.Drawing.Size(717, 265);
            this.tcTablesToImport.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tables:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Import Parameters:";
            // 
            // btnRFCGetParameter
            // 
            this.btnRFCGetParameter.Location = new System.Drawing.Point(487, 18);
            this.btnRFCGetParameter.Name = "btnRFCGetParameter";
            this.btnRFCGetParameter.Size = new System.Drawing.Size(136, 23);
            this.btnRFCGetParameter.TabIndex = 5;
            this.btnRFCGetParameter.Text = "Parametreleri Getir";
            this.btnRFCGetParameter.UseVisualStyleBackColor = true;
            this.btnRFCGetParameter.Click += new System.EventHandler(this.btnRFCTest_Click);
            // 
            // txtRFCName
            // 
            this.txtRFCName.Location = new System.Drawing.Point(61, 21);
            this.txtRFCName.Name = "txtRFCName";
            this.txtRFCName.Size = new System.Drawing.Size(420, 20);
            this.txtRFCName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFC Adı:";
            // 
            // gvImportParams
            // 
            this.gvImportParams.AllowUserToAddRows = false;
            this.gvImportParams.AllowUserToDeleteRows = false;
            this.gvImportParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvImportParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvImportParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cNewValue,
            this.cOptional,
            this.cDataType,
            this.cDefaultValue,
            this.cDirection,
            this.cDocumentation,
            this.cNucLength,
            this.cUcLength,
            this.cDecimals});
            this.gvImportParams.Location = new System.Drawing.Point(9, 73);
            this.gvImportParams.Name = "gvImportParams";
            this.gvImportParams.Size = new System.Drawing.Size(717, 184);
            this.gvImportParams.TabIndex = 2;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Name";
            this.cName.Frozen = true;
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cNewValue
            // 
            this.cNewValue.DataPropertyName = "NewValue";
            this.cNewValue.Frozen = true;
            this.cNewValue.HeaderText = "New Value";
            this.cNewValue.Name = "cNewValue";
            // 
            // cOptional
            // 
            this.cOptional.DataPropertyName = "Optional";
            this.cOptional.HeaderText = "Optional";
            this.cOptional.Name = "cOptional";
            this.cOptional.ReadOnly = true;
            // 
            // cDataType
            // 
            this.cDataType.DataPropertyName = "DataType";
            this.cDataType.HeaderText = "DataType";
            this.cDataType.Name = "cDataType";
            this.cDataType.ReadOnly = true;
            // 
            // cDefaultValue
            // 
            this.cDefaultValue.DataPropertyName = "DefaultValue";
            this.cDefaultValue.HeaderText = "DefaultValue";
            this.cDefaultValue.Name = "cDefaultValue";
            this.cDefaultValue.ReadOnly = true;
            // 
            // cDirection
            // 
            this.cDirection.DataPropertyName = "Direction";
            this.cDirection.HeaderText = "Direction";
            this.cDirection.Name = "cDirection";
            this.cDirection.ReadOnly = true;
            // 
            // cDocumentation
            // 
            this.cDocumentation.DataPropertyName = "Documentation";
            this.cDocumentation.HeaderText = "Documentation";
            this.cDocumentation.Name = "cDocumentation";
            this.cDocumentation.ReadOnly = true;
            // 
            // cNucLength
            // 
            this.cNucLength.DataPropertyName = "NucLength";
            this.cNucLength.HeaderText = "NucLength";
            this.cNucLength.Name = "cNucLength";
            this.cNucLength.ReadOnly = true;
            // 
            // cUcLength
            // 
            this.cUcLength.DataPropertyName = "UcLength";
            this.cUcLength.HeaderText = "UcLength";
            this.cUcLength.Name = "cUcLength";
            this.cUcLength.ReadOnly = true;
            // 
            // cDecimals
            // 
            this.cDecimals.DataPropertyName = "Decimals";
            this.cDecimals.HeaderText = "Decimals";
            this.cDecimals.Name = "cDecimals";
            this.cDecimals.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(781, 436);
            this.Controls.Add(this.tcMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAP RFC Test Tool  - 2015.11.09.1700";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tabSAPConnectionParameters.ResumeLayout(false);
            this.tabSAPConnectionParameters.PerformLayout();
            this.tabRFCExecute.ResumeLayout(false);
            this.tabRFCExecute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExportParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImportParams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
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
        private System.Windows.Forms.TextBox txtCLIENT;
        private System.Windows.Forms.TextBox txtUSER;
        private System.Windows.Forms.TextBox txtPASSWD;
        private System.Windows.Forms.TextBox txtLANG;
        private System.Windows.Forms.DataGridView gvImportParams;
        private System.Windows.Forms.Label lblMAX_POOL_SIZE;
        private System.Windows.Forms.Label lblPOOL_SIZE;
        private System.Windows.Forms.TextBox txtPOOL_SIZE;
        private System.Windows.Forms.TextBox txtMAX_POOL_SIZE;
        private System.Windows.Forms.TextBox txtRFCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRFCGetParameter;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNewValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOptional;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDefaultValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDocumentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNucLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUcLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDecimals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcTablesToImport;
        private System.Windows.Forms.Label lblTestConnectionResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRFCExecute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvExportParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabControl tcTablesToExport;
    }
}

