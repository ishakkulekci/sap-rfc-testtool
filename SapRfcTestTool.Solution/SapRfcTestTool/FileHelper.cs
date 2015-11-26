using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SapRfcTestTool
{
    public class FileHelper
    {

        public static void SaveSAPConnectionInfo(SAPConnectionInfo sapConnectionInfo)
        {

            // bağlantı bilgileri json'a serilize edilerek kaydedilir

            string info = JsonConvert.SerializeObject(sapConnectionInfo);


            string fileName = ConfigurationManager.AppSettings["SAPConnectionInfoSavingFileNameAndPath"];

            // ishak.kulekci 25.12.2014 17.00
            // server 2008'de task manager ile log path ve dosyasına erişim hatası almamak için
            // when running as a scheduled task the working directory of your application can be different, such as running under system means the working directory is C:\Windows\System32
            // Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),"NLog.txt");
            fileName =
                Path.Combine(
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                    fileName);

            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                sw.Write(info);
                sw.Flush();
                sw.Close();
            }

        }


        public static SAPConnectionInfo GetSAPConnectionInfo()
        {

            // bağlantı bilgileri json'a deserilize edilerek nesne oluşturulur
            SAPConnectionInfo result = new SAPConnectionInfo();
            

            string info = "";


            string fileName = ConfigurationManager.AppSettings["SAPConnectionInfoSavingFileNameAndPath"];

            // ishak.kulekci 25.12.2014 17.00
            // server 2008'de task manager ile log path ve dosyasına erişim hatası almamak için
            // when running as a scheduled task the working directory of your application can be different, such as running under system means the working directory is C:\Windows\System32
            // Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),"NLog.txt");
            fileName =
                Path.Combine(
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                    fileName);

            using (StreamReader sw = new StreamReader(fileName))
            {
                info = sw.ReadToEnd();
                sw.Close();
            }

            result = JsonConvert.DeserializeObject<SAPConnectionInfo>(info);

            return result;

        }


        public static void SaveRFCName(string rfcName)
        {

            // bağlantı bilgileri json'a serilize edilerek kaydedilir

            string info = JsonConvert.SerializeObject(rfcName);


            string fileName = ConfigurationManager.AppSettings["RFCNameSavingFileNameAndPath"];

            // ishak.kulekci 25.12.2014 17.00
            // server 2008'de task manager ile log path ve dosyasına erişim hatası almamak için
            // when running as a scheduled task the working directory of your application can be different, such as running under system means the working directory is C:\Windows\System32
            // Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),"NLog.txt");
            fileName =
                Path.Combine(
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                    fileName);

            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                sw.Write(info);
                sw.Flush();
                sw.Close();
            }

        }


        public static string GetRFCName()
        {

            // bağlantı bilgileri json'a deserilize edilerek nesne oluşturulur
            string result = String.Empty;


            string info = "";


            string fileName = ConfigurationManager.AppSettings["RFCNameSavingFileNameAndPath"];

            // ishak.kulekci 25.12.2014 17.00
            // server 2008'de task manager ile log path ve dosyasına erişim hatası almamak için
            // when running as a scheduled task the working directory of your application can be different, such as running under system means the working directory is C:\Windows\System32
            // Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),"NLog.txt");
            fileName =
                Path.Combine(
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                    fileName);

            using (StreamReader sw = new StreamReader(fileName))
            {
                info = sw.ReadToEnd();
                sw.Close();
            }

            result = JsonConvert.DeserializeObject<string>(info);

            return result;

        }



    } // end of class
}
