﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;

namespace SapRfcTestTool
{

    public class RFCHelper
    {


        /// <summary>
        /// Converts SAP table to .NET DataTable table
        /// </summary>
        /// <param name="sapTable">The SAP table to convert.</param>
        /// <returns></returns>
        public static DataTable RfcTableToDataTable(IRfcTable sapTable, string name)
        {
            DataTable adoTable = new DataTable(name);
            //... Create ADO.Net table.
            for (int liElement = 0; liElement < sapTable.ElementCount; liElement++)
            {
                RfcElementMetadata metadata = sapTable.GetElementMetadata(liElement);
                adoTable.Columns.Add(metadata.Name, GetDataType(metadata.DataType));
            }

            //Transfer rows from SAP Table ADO.Net table.
            foreach (IRfcStructure row in sapTable)
            {
                DataRow ldr = adoTable.NewRow();
                for (int liElement = 0; liElement < sapTable.ElementCount; liElement++)
                {
                    RfcElementMetadata metadata = sapTable.GetElementMetadata(liElement);

                    switch (metadata.DataType)
                    {
                        case RfcDataType.DATE:
                            ldr[metadata.Name] = row.GetString(metadata.Name).Substring(0, 4) + row.GetString(metadata.Name).Substring(5, 2) + row.GetString(metadata.Name).Substring(8, 2);
                            break;
                        case RfcDataType.BCD:
                            ldr[metadata.Name] = row.GetDecimal(metadata.Name);
                            break;
                        case RfcDataType.CHAR:
                            ldr[metadata.Name] = row.GetString(metadata.Name);
                            break;
                        case RfcDataType.STRING:
                            ldr[metadata.Name] = row.GetString(metadata.Name);
                            break;
                        case RfcDataType.INT2:
                            ldr[metadata.Name] = row.GetInt(metadata.Name);
                            break;
                        case RfcDataType.INT4:
                            ldr[metadata.Name] = row.GetInt(metadata.Name);
                            break;
                        case RfcDataType.FLOAT:
                            ldr[metadata.Name] = row.GetDouble(metadata.Name);
                            break;
                        default:
                            ldr[metadata.Name] = row.GetString(metadata.Name);
                            break;
                    }
                }
                adoTable.Rows.Add(ldr);
            }
            return adoTable;
        }

        public static Type GetDataType(RfcDataType rfcDataType)
        {
            switch (rfcDataType)
            {
                case RfcDataType.DATE:
                    return typeof(string);
                case RfcDataType.CHAR:
                    return typeof(string);
                case RfcDataType.STRING:
                    return typeof(string);
                case RfcDataType.BCD:
                    return typeof(decimal);
                case RfcDataType.INT2:
                    return typeof(int);
                case RfcDataType.INT4:
                    return typeof(int);
                case RfcDataType.FLOAT:
                    return typeof(double);
                default:
                    return typeof(string);
            }
        }


        //public DataTable GetDataTableFromRFCTable(IRfcTable lrfcTable)
        //{
        //    //sapnco_util
        //    DataTable loTable = new DataTable();

        //    //... Create ADO.Net table.
        //    for (int liElement = 0; liElement < lrfcTable.ElementCount; liElement++)
        //    {
        //        RfcElementMetadata metadata = lrfcTable.GetElementMetadata(liElement);
        //        loTable.Columns.Add(metadata.Name);
        //    }

        //    //... Transfer rows from lrfcTable to ADO.Net table.
        //    foreach (IRfcStructure row in lrfcTable)
        //    {
        //        DataRow ldr = loTable.NewRow();
        //        for (int liElement = 0; liElement < lrfcTable.ElementCount; liElement++)
        //        {
        //            RfcElementMetadata metadata = lrfcTable.GetElementMetadata(liElement);
        //            ldr[metadata.Name] = row.GetString(metadata.Name);
        //        }
        //        loTable.Rows.Add(ldr);
        //    }

        //    return loTable;
        //}


        public DataTable RfcStructureToDataTable(IRfcStructure myrefcTable)
        {
            DataTable rowTable = new DataTable();
            for (int i = 0; i <= myrefcTable.ElementCount - 1; i++)
            {
                rowTable.Columns.Add(myrefcTable.GetElementMetadata(i).Name);
            }
            DataRow row = rowTable.NewRow();
            for (int j = 0; j <= myrefcTable.ElementCount - 1; j++)
            {
                row[j] = myrefcTable.GetValue(j);
            }
            rowTable.Rows.Add(row);
            return rowTable;
        }


        public bool TestConnection()
        {
            bool result = false;


            SAPDestinationConfiguration sapDestinationConfiguration = new SAPDestinationConfiguration();

            
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

                if (rfcDestination != null)
                {
                    rfcDestination.Ping();
                    result = true;
                }
                

            }
            catch (Exception exception)
            {
                //throw exception;
                result = false;
                //throw new Exception("Connection failure error. Message:"+exception.Message);
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

            return result;
        }


    } // end of class

}
