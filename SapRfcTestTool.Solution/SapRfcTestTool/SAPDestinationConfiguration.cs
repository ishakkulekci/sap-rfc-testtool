using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;

namespace SapRfcTestTool
{
    public class SAPDestinationConfiguration : IDestinationConfiguration
    {

        public bool ChangeEventsSupported()
        {
            //throw new NotImplementedException();
            return false;
        }

        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;

        public RfcConfigParameters GetParameters(string destinationName)
        {
            //throw new NotImplementedException();

            // ishak.kulekci 06.06.2013
            // destinationname boş olmaması gerekiyor, yoksa "ERROR no symbolic destination specified" şeklinde hata veriyor

            SAPConnectionInfo sapConnectionInfo = ConfigHelper.ParseSAPConnectionInfo();

            RfcConfigParameters rfcConfigParameters = new RfcConfigParameters();
            rfcConfigParameters[RfcConfigParameters.AppServerHost] = sapConnectionInfo.ASHOST;
            rfcConfigParameters[RfcConfigParameters.SystemNumber] = sapConnectionInfo.SYSNR;
            rfcConfigParameters[RfcConfigParameters.Client] = sapConnectionInfo.CLIENT;
            rfcConfigParameters[RfcConfigParameters.User] = sapConnectionInfo.USER;
            rfcConfigParameters[RfcConfigParameters.Password] = sapConnectionInfo.PASSWD;
            rfcConfigParameters[RfcConfigParameters.Language] = sapConnectionInfo.LANG;
            rfcConfigParameters[RfcConfigParameters.PoolSize] = sapConnectionInfo.POOL_SIZE;
            //rfcConfigParameters[RfcConfigParameters.MaxPoolSize]
            rfcConfigParameters[RfcConfigParameters.PeakConnectionsLimit] = sapConnectionInfo.MAX_POOL_SIZE;
            // ishak.kulekci 06.06.2013
            // Name değeri üstte belirtilen destinationName ile aynı olmalı yoksa "Inconsistency in destination name: does not match ..." şeklinde hata veriyor
            rfcConfigParameters[RfcConfigParameters.Name] = destinationName; //sapConnectionInfo.NAME;


            return rfcConfigParameters;
        }
    }
}
