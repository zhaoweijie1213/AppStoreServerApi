using AppStoreServerApi.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi
{
    public class AppStoreDefaultClient : AppleAppstoreClient, IAppleAppstoreClient
    {
        public AppStoreDefaultClient(IOptionsMonitor<AppleConfig> appleConfig)
            : base(privateKey: appleConfig.CurrentValue.PrivateKey,
                  keyId: appleConfig.CurrentValue.KeyId,
                  issuerId: appleConfig.CurrentValue.IssuerId,
                  applicationId: appleConfig.CurrentValue.ApplicationId,
                  appstoreAudience: appleConfig.CurrentValue.AppstoreAudience,
                  environment: appleConfig.CurrentValue.AppleEnvironment)
        {

        }
    }
}
