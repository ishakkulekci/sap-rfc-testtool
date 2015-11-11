using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SapRfcTestTool
{
    public class ConfigHelper
    {

        public static string GetSAPConnectionInfo()
        {
            string result = string.Empty;

            result = ConfigurationManager.AppSettings["SAPConnectionInfo"];

            return result;
        }

        public static SAPConnectionInfo ParseSAPConnectionInfo()
        {
            string appSettingSAPConnectionInfo = GetSAPConnectionInfo();
            string[] subStringsOfAppSettingSAPConnectionInfo = appSettingSAPConnectionInfo.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            SAPConnectionInfo sapConnectionInfo = new SAPConnectionInfo();
            foreach (var s in subStringsOfAppSettingSAPConnectionInfo)
            {
                if (s.StartsWith("ASHOST="))
                    sapConnectionInfo.ASHOST = GetRightOfEqualOperator(s);
                else if (s.StartsWith("SYSNR="))
                    sapConnectionInfo.SYSNR = GetRightOfEqualOperator(s);
                else if (s.StartsWith("CLIENT="))
                    sapConnectionInfo.CLIENT = GetRightOfEqualOperator(s);
                else if (s.StartsWith("USER="))
                    sapConnectionInfo.USER = GetRightOfEqualOperator(s);
                else if (s.StartsWith("PASSWD="))
                    sapConnectionInfo.PASSWD = GetRightOfEqualOperator(s);
                else if (s.StartsWith("LANG="))
                    sapConnectionInfo.LANG = GetRightOfEqualOperator(s);
                else if (s.StartsWith("POOL_SIZE="))
                    sapConnectionInfo.POOL_SIZE = GetRightOfEqualOperator(s);
                else if (s.StartsWith("MAX_POOL_SIZE="))
                    sapConnectionInfo.MAX_POOL_SIZE = GetRightOfEqualOperator(s);
                else if (s.StartsWith("NAME="))
                    sapConnectionInfo.NAME = GetRightOfEqualOperator(s);

            }


            return sapConnectionInfo;
        }

        public static string GetRightOfEqualOperator(string stringWithEqualOperator)
        {
            string result = string.Empty;
            result = stringWithEqualOperator.Substring(stringWithEqualOperator.IndexOf("=") + 1);
            return result;
        }


    }
}
