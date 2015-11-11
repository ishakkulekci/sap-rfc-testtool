using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;

namespace SapRfcTestTool
{
    public class SampleMusteriService
    {

        public void KomisyonBedeliniGetir(string musteriNumarasi, DateTime? baslangicTarihi, DateTime? bitisTarihi
            , out DataTable dtITAB, out DataTable dtZRETURN)
        {

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
                rfcFunction = rfcDestination.Repository.CreateFunction("Z_RFC_YK_BEKPRIM_TO_INTERNET");
                //rfcFunction.SetValue("KUNNR", "100092"); // aygaz
                rfcFunction.SetValue("KUNNR", musteriNumarasi);
                //rfcFunction.SetValue("DATAB", "20130601");
                rfcFunction.SetValue("DATAB", baslangicTarihi.Value.ToString("yyyyMMdd", CultureInfo.GetCultureInfo("tr-tr")));
                //rfcFunction.SetValue("DATBI", "20130605");
                rfcFunction.SetValue("DATBI", bitisTarihi.Value.ToString("yyyyMMdd", CultureInfo.GetCultureInfo("tr-tr")));
                rfcFunction.Invoke(rfcDestination);

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

            dtITAB = RFCHelper.RfcTableToDataTable(rfcFunction.GetTable("ITAB"), "ITAB");
            dtZRETURN = RFCHelper.RfcTableToDataTable(rfcFunction.GetTable("ZRETURN"), "ZRETURN");


        }

    }

}
