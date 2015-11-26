using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAP.Middleware.Connector;

namespace SapRfcTestTool
{
    public partial class FormMain : Form
    {

        // sap bağlantı parametreleri tutar
        public static SAPConnectionInfo sapConnectionInfo;

        public FormMain()
        {
            InitializeComponent();

            sapConnectionInfo = new SAPConnectionInfo();

        }

        
        //public static string prmASHOST { get; set; }
        //public static string prmSYSNR { get; set; }
        //public static string prmCLIENT { get; set; }
        //public static string prmUSER { get; set; }
        //public static string prmPASSWD { get; set; }
        //public static string prmLANG { get; set; }
        //public static string prmPOOL_SIZE { get; set; }
        //public static string prmMAX_POOL_SIZE { get; set; }

        


        private void FormMain_Load(object sender, EventArgs e)
        {

            lblTestConnectionResult.Text=String.Empty;

            // önceden girilen sap bağlantı bilgileri dosyadan alınıp, bağlantı bilgileri ekranında doldurulur
            // bağlantı bilgileri static değişkene doldurulur
            sapConnectionInfo = FileHelper.GetSAPConnectionInfo();
            LoadUIFromSAPConnectionStaticParameters();

            txtRFCName.Text = FileHelper.GetRFCName();

        }

        private void btnRFCTest_Click(object sender, EventArgs e)
        {

            try
            {

                FileHelper.SaveRFCName(txtRFCName.Text);

                string rfcName = txtRFCName.Text;

                SAPDestinationConfiguration sapDestinationConfiguration = new SAPDestinationConfiguration();

                IRfcFunction rfcFunction = null;
                try
                {
                    // ishak.kulekci 24.06.2013
                    //  Destination configuration already initialized hatasını engelleme, bunun için önce TryGetDestination kullanılır
                    RfcDestination rfcDestination = RfcDestinationManager.TryGetDestination("SAPSYSTEM");
                    if (rfcDestination == null)
                    {
                        try
                        {
                            RfcDestinationManager.RegisterDestinationConfiguration(sapDestinationConfiguration);
                        }
                        catch (Exception ex)
                        {

                        }
                        rfcDestination = RfcDestinationManager.GetDestination("SAPSYSTEM");
                    }

                    //RfcDestination rfcDestination = RfcDestinationManager.GetDestination("SAPSYSTEM");
                    //rfcFunction = rfcDestination.Repository.CreateFunction("Z_RFC_YK_BEKPRIM_TO_INTERNET");
                    ////rfcFunction.SetValue("KUNNR", "100092"); // aygaz
                    //rfcFunction.SetValue("KUNNR", musteriNumarasi);
                    ////rfcFunction.SetValue("DATAB", "20130601");
                    //rfcFunction.SetValue("DATAB", baslangicTarihi.Value.ToString("yyyyMMdd", CultureInfo.GetCultureInfo("tr-tr")));
                    ////rfcFunction.SetValue("DATBI", "20130605");
                    //rfcFunction.SetValue("DATBI", bitisTarihi.Value.ToString("yyyyMMdd", CultureInfo.GetCultureInfo("tr-tr")));
                    //rfcFunction.Invoke(rfcDestination);

                    rfcFunction = rfcDestination.Repository.CreateFunction(rfcName);
                    //rfcFunction.Metadata

                    //RfcParameterMetadata describing an importing/exporting/tables parameter of a function module

                    List<RfcParameterMetadata_ForUI> listRfcParameterMetadataWhichDirectionImport = new List<RfcParameterMetadata_ForUI>();
                    //List<RfcParameterMetadata_ForUI> listRfcParameterMetadataWhichDirectionTables = new List<RfcParameterMetadata_ForUI>();
                    //List<DataTable> listDataTableToImport = new List<DataTable>();
                    List<RFCTableWhichHasDataTableAndFieldInfo> listRFCTable = new List<RFCTableWhichHasDataTableAndFieldInfo>();
                    int parameterCount = rfcFunction.Metadata.ParameterCount;
                    for (int i = 0; i < parameterCount; i++)
                    {
                        RfcParameterMetadata rfcParameterMetadata = rfcFunction.Metadata[i];
                        //rfcParameterMetadata.DefaultValue
                        //rfcParameterMetadata.Direction 
                        //RfcDirection.CHANGING
                        //RfcDirection.EXPORT
                        //RfcDirection.IMPORT
                        //RfcDirection.TABLES
                        //rfcParameterMetadata.Optional
                        //rfcParameterMetadata.Name
                        if (rfcParameterMetadata.Direction == RfcDirection.IMPORT)
                        {
                            listRfcParameterMetadataWhichDirectionImport.Add(Convert_To_RfcParameterMetadata_ForUI(rfcParameterMetadata));
                        }
                        else if (rfcParameterMetadata.Direction == RfcDirection.TABLES)
                        {
                            RfcTableMetadata rfcTableMetadata = rfcParameterMetadata.ValueMetadataAsTableMetadata;
                            int fieldCount = rfcTableMetadata.LineType.FieldCount;
                            // field adeti kadar Datatable nesnesi oluşturup kolon eklemesi yapılacak
                            DataTable dt = new DataTable(rfcTableMetadata.Name);
                            List<RfcFieldMetadata_ForUI> listRfcFieldMetadata = new List<RfcFieldMetadata_ForUI>();
                            for (int j = 0; j < fieldCount; j++)
                            {
                                RfcFieldMetadata rfcFieldMetadata = rfcTableMetadata[j];
                                DataColumn dc = new DataColumn(rfcFieldMetadata.Name);
                                dt.Columns.Add(dc);
                                listRfcFieldMetadata.Add(Convert_To_RfcFieldMetadata_ForUI(rfcFieldMetadata));
                            }
                            //listDataTableToImport.Add(dt);
                            //listRfcParameterMetadataWhichDirectionTables.Add(Convert_To_RfcParameterMetadata_ForUI(rfcParameterMetadata));

                            RFCTableWhichHasDataTableAndFieldInfo rfcTable = new RFCTableWhichHasDataTableAndFieldInfo();
                            rfcTable.TableParameterMetadata = Convert_To_RfcParameterMetadata_ForUI(rfcParameterMetadata);
                            rfcTable.DataTableForItems = dt;
                            rfcTable.ListForFieldMetadata = listRfcFieldMetadata;
                            listRFCTable.Add(rfcTable);

                        }

                    }

                    gvImportParams.AutoGenerateColumns = false;
                    gvImportParams.DataSource = listRfcParameterMetadataWhichDirectionImport;

                    // tablolar elde edilip, tabcontrol içine tabpage olarak eklenir
                    //  her tabpage içinde datagridview eklenir, kolon değerlerini alma sağlanır
                    foreach (RFCTableWhichHasDataTableAndFieldInfo itemTable in listRFCTable)
                    {
                        TabPage page = new TabPage();
                        page.Text = itemTable.TableParameterMetadata.Name;
                        page.Name = "tp" + itemTable.TableParameterMetadata.Name;
                        page.Width = 550;
                        page.Height = 300;

                        DataGridView gv = new DataGridView();
                        gv.Name = "gv" + itemTable.TableParameterMetadata.Name;
                        // grid kaynağı bağlanmalı
                        gv.DataSource = itemTable.DataTableForItems;
                        gv.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        gv.Location = new Point(5, 35);
                        gv.Margin = new Padding(3);
                        gv.Width = 540;
                        gv.Height = 200;

                        page.Controls.Add(gv);

                        tcTablesToImport.TabPages.Add(page);
                    }



                }
                catch (Exception exception)
                {
                    throw exception;

                }
                finally
                {
                    try
                    {
                        RfcDestinationManager.UnregisterDestinationConfiguration(sapDestinationConfiguration);
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public RfcParameterMetadata_ForUI Convert_To_RfcParameterMetadata_ForUI(RfcParameterMetadata metadata)
        {
            RfcParameterMetadata_ForUI item = new RfcParameterMetadata_ForUI();
            item.Direction = metadata.Direction;
            item.DataType = metadata.DataType;
            item.Decimals = metadata.Decimals;
            item.DefaultValue = metadata.DefaultValue;
            item.Documentation = metadata.Documentation;
            item.Name = metadata.Name;
            item.NucLength = metadata.NucLength;
            item.Optional = metadata.Optional;
            item.UcLength = metadata.UcLength;
            
            return item;
        }

        public RfcFieldMetadata_ForUI Convert_To_RfcFieldMetadata_ForUI(RfcFieldMetadata metadata)
        {
            RfcFieldMetadata_ForUI item = new RfcFieldMetadata_ForUI();
            item.DataType = metadata.DataType;
            item.Decimals = metadata.Decimals;
            item.Documentation = metadata.Documentation;
            item.Name = metadata.Name;
            item.NucLength = metadata.NucLength;
            item.UcLength = metadata.UcLength;

            return item;
        }


        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            // kaydedilen bilgiler geçici olarak dosyaya kaydedilecek, uygulama tekrar açılınca bu bilgiler yüklü gelecek

            // bağlantı bilgileri hafızaya alınır
            SetSAPConnectionStaticParameters();

            // girilen bağlantı bilgileri kaydediliyor
            FileHelper.SaveSAPConnectionInfo(sapConnectionInfo);




            RFCHelper helper = new RFCHelper();
            bool result = helper.TestConnection();
            if (result)
            {
                //MessageBox.Show("Bağlantılı başarılı.","Bağlantı Sonucu",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblTestConnectionResult.Text = "Bağlantı başarılı.";
                lblTestConnectionResult.ForeColor = Color.Green;
            }
            else
            {
                //MessageBox.Show("Bağlantılı başarısız.", "Bağlantı Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTestConnectionResult.Text = "Bağlantı başarısız.";
                lblTestConnectionResult.ForeColor = Color.Red;
            }
        }

        public void SetSAPConnectionStaticParameters()
        {
            sapConnectionInfo.ASHOST = txtASHOST.Text;
            sapConnectionInfo.SYSNR = txtSYSNR.Text;
            sapConnectionInfo.CLIENT = txtCLIENT.Text;

            sapConnectionInfo.USER = txtUSER.Text;
            sapConnectionInfo.PASSWD = txtPASSWD.Text;
            sapConnectionInfo.LANG = txtLANG.Text;

            sapConnectionInfo.POOL_SIZE = txtPOOL_SIZE.Text;
            sapConnectionInfo.MAX_POOL_SIZE = txtMAX_POOL_SIZE.Text;

        }

        public void LoadUIFromSAPConnectionStaticParameters()
        {
            txtASHOST.Text = sapConnectionInfo.ASHOST;
            txtSYSNR.Text = sapConnectionInfo.SYSNR;
            txtCLIENT.Text = sapConnectionInfo.CLIENT;

            txtUSER.Text = sapConnectionInfo.USER;
            txtPASSWD.Text = sapConnectionInfo.PASSWD;
            txtLANG.Text = sapConnectionInfo.LANG;

            txtPOOL_SIZE.Text = sapConnectionInfo.POOL_SIZE;
            txtMAX_POOL_SIZE.Text = sapConnectionInfo.MAX_POOL_SIZE;

        }


        private void tabSAPConnectionParameters_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRFCExecute_Click(object sender, EventArgs e)
        {

            try
            {

                string rfcName = txtRFCName.Text;

                SAPDestinationConfiguration sapDestinationConfiguration = new SAPDestinationConfiguration();

                IRfcFunction rfcFunction = null;
                try
                {
                    // ishak.kulekci 24.06.2013
                    //  Destination configuration already initialized hatasını engelleme, bunun için önce TryGetDestination kullanılır
                    RfcDestination rfcDestination = RfcDestinationManager.TryGetDestination("SAPSYSTEM");
                    if (rfcDestination == null)
                    {
                        try
                        {
                            RfcDestinationManager.RegisterDestinationConfiguration(sapDestinationConfiguration);
                        }
                        catch (Exception ex)
                        {

                        }
                        rfcDestination = RfcDestinationManager.GetDestination("SAPSYSTEM");
                    }

                    //RfcDestination rfcDestination = RfcDestinationManager.GetDestination("SAPSYSTEM");
                    //rfcFunction = rfcDestination.Repository.CreateFunction("Z_RFC_YK_BEKPRIM_TO_INTERNET");
                    ////rfcFunction.SetValue("KUNNR", "100092"); // aygaz
                    //rfcFunction.SetValue("KUNNR", musteriNumarasi);
                    ////rfcFunction.SetValue("DATAB", "20130601");
                    //rfcFunction.SetValue("DATAB", baslangicTarihi.Value.ToString("yyyyMMdd", CultureInfo.GetCultureInfo("tr-tr")));
                    ////rfcFunction.SetValue("DATBI", "20130605");
                    //rfcFunction.SetValue("DATBI", bitisTarihi.Value.ToString("yyyyMMdd", CultureInfo.GetCultureInfo("tr-tr")));
                    //rfcFunction.Invoke(rfcDestination);

                    rfcFunction = rfcDestination.Repository.CreateFunction(rfcName);
                    //rfcFunction.Metadata

                    // ishak.kulekci 26.11.2015 09.00 import parametreleri set edilir, rfc invoke edilir
                    // rfc sonucunda gelen export ve table parametreleri elde edilir ve gösterilir
                    foreach (DataGridViewRow row in gvImportParams.Rows)
                    {
                        string prmName = row.Cells["cName"].Value == null ? "" : row.Cells["cName"].Value.ToString(); // cName -> Name verisi
                        string prmNewValue = row.Cells["cNewValue"].Value == null ? "" : row.Cells["cNewValue"].Value.ToString(); // cNewValue -> NewValue verisi
                        rfcFunction.SetValue(prmName, prmNewValue);
                    }

                    // rfc invoke edilir
                    rfcFunction.Invoke(rfcDestination);

                    //RfcParameterMetadata describing an importing/exporting/tables parameter of a function module

                    List<RfcParameterMetadata_ForUI> listRfcParameterMetadataWhichDirectionExport = new List<RfcParameterMetadata_ForUI>();

                    List<RFCTableWhichHasDataTableAndFieldInfo> listRFCTable = new List<RFCTableWhichHasDataTableAndFieldInfo>();
                    int parameterCount = rfcFunction.Metadata.ParameterCount;
                    for (int i = 0; i < parameterCount; i++)
                    {
                        RfcParameterMetadata rfcParameterMetadata = rfcFunction.Metadata[i];
                        //rfcParameterMetadata.DefaultValue
                        //rfcParameterMetadata.Direction 
                        //RfcDirection.CHANGING
                        //RfcDirection.EXPORT
                        //RfcDirection.IMPORT
                        //RfcDirection.TABLES
                        //rfcParameterMetadata.Optional
                        //rfcParameterMetadata.Name
                        if (rfcParameterMetadata.Direction == RfcDirection.EXPORT)
                        {
                            listRfcParameterMetadataWhichDirectionExport.Add(Convert_To_RfcParameterMetadata_ForUI(rfcParameterMetadata));

                        }
                        else if (rfcParameterMetadata.Direction == RfcDirection.TABLES)
                        {
                            RfcTableMetadata rfcTableMetadata = rfcParameterMetadata.ValueMetadataAsTableMetadata;
                            int fieldCount = rfcTableMetadata.LineType.FieldCount;
                            // field adeti kadar Datatable nesnesi oluşturup kolon eklemesi yapılacak
                            DataTable dt = new DataTable(rfcTableMetadata.Name);
                            List<RfcFieldMetadata_ForUI> listRfcFieldMetadata = new List<RfcFieldMetadata_ForUI>();
                            for (int j = 0; j < fieldCount; j++)
                            {
                                RfcFieldMetadata rfcFieldMetadata = rfcTableMetadata[j];
                                DataColumn dc = new DataColumn(rfcFieldMetadata.Name);
                                dt.Columns.Add(dc);
                                listRfcFieldMetadata.Add(Convert_To_RfcFieldMetadata_ForUI(rfcFieldMetadata));
                            }

                            RFCTableWhichHasDataTableAndFieldInfo rfcTable = new RFCTableWhichHasDataTableAndFieldInfo();
                            rfcTable.TableParameterMetadata = Convert_To_RfcParameterMetadata_ForUI(rfcParameterMetadata);
                            rfcTable.DataTableForItems = RFCHelper.RfcTableToDataTable(rfcFunction.GetTable(rfcParameterMetadata.Name), rfcParameterMetadata.Name); //dt;
                            rfcTable.ListForFieldMetadata = listRfcFieldMetadata;
                            listRFCTable.Add(rfcTable);

                        }

                    }

                    gvExportParams.AutoGenerateColumns = false;
                    gvExportParams.DataSource = listRfcParameterMetadataWhichDirectionExport;

                    // tablolar elde edilip, tabcontrol içine tabpage olarak eklenir
                    //  her tabpage içinde datagridview eklenir, kolon değerlerini alma sağlanır
                    foreach (RFCTableWhichHasDataTableAndFieldInfo itemTable in listRFCTable)
                    {
                        TabPage page = new TabPage();
                        page.Text = itemTable.TableParameterMetadata.Name;
                        page.Name = "tp" + itemTable.TableParameterMetadata.Name;
                        page.Width = 550;
                        page.Height = 300;

                        DataGridView gv = new DataGridView();
                        gv.Name = "gv" + itemTable.TableParameterMetadata.Name;
                        // grid kaynağı bağlanmalı
                        gv.DataSource = itemTable.DataTableForItems;
                        gv.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        gv.Location = new Point(5, 35);
                        gv.Margin = new Padding(3);
                        gv.Width = 540;
                        gv.Height = 200;
                        gv.AllowUserToAddRows = false;
                        gv.AllowUserToDeleteRows = false;
                        gv.ReadOnly = true;
                        //gv.Visible = false;

                        Label lblRowCount = new Label();
                        lblRowCount.Name = "lblRowCount" + itemTable.TableParameterMetadata.Name;
                        lblRowCount.Text = "Veri Adeti: " + itemTable.DataTableForItems.Rows.Count.ToString();
                        lblRowCount.Location = new Point(gv.Location.X, gv.Location.Y + gv.Height - 20);

                        page.Controls.Add(gv);
                        page.Controls.Add(lblRowCount);

                        tcTablesToExport.TabPages.Add(page);
                    }



                }
                catch (Exception exception)
                {
                    throw exception;
                }
                finally
                {
                    try
                    {
                        RfcDestinationManager.UnregisterDestinationConfiguration(sapDestinationConfiguration);
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    } // end of class


    public class RfcParameterMetadata_ForUI
    {
        public string Name { get; set; }
        public bool Optional { get; set; }
        public RfcDirection Direction { get; set; }
        public string DefaultValue { get; set; }
        public string Documentation { get; set; }
        public RfcDataType DataType { get; set; }
        public int NucLength { get; set; }
        public int UcLength { get; set; }
        public int Decimals { get; set; }

        public string NewValue { get; set; }

    }

    public class RfcFieldMetadata_ForUI
    {
        public string Name { get; set; }
        public string Documentation { get; set; }
        public RfcDataType DataType { get; set; }
        public int NucLength { get; set; }
        public int UcLength { get; set; }
        public int Decimals { get; set; }

        //public string NewValue { get; set; }
    }

    public class RFCTableWhichHasDataTableAndFieldInfo
    {
        public DataTable DataTableForItems { get; set; }
        public List<RfcFieldMetadata_ForUI> ListForFieldMetadata { get; set; }
        public RfcParameterMetadata_ForUI TableParameterMetadata { get; set; }
    }



}
