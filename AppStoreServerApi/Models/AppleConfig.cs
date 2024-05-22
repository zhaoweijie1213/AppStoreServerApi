using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    public class AppleConfig
    {
        /// <summary>
        /// bundleId bundle ID of your app
        /// </summary>
        public string ApplicationId { get; set; } = string.Empty;

        /// <summary>
        /// issuerId your issuer ID, retrieved from App Store Connect
        /// </summary>
        public string IssuerId { get; set; } = string.Empty;

        /// <summary>
        /// keyId the id of the key, retrieved from App Store Connect
        /// </summary>
        public string KeyId { get; set; } = string.Empty;

        /// <summary>
        /// Sandbox/Production
        /// </summary>
        public string AppleEnvironment { get; set; } = Models.AppleEnvironment.Sandbox;

        /// <summary>
        /// key the key downloaded from App Store Connect in PEM-encoded PKCS8 format.
        /// </summary>
        public string PrivateKey { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string AppstoreAudience { get; set; } = "appstoreconnect-v1";
    }
}
