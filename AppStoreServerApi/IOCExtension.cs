using AppStoreServerApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi
{
    public static class IOCExtension
    {
        /// <summary>
        /// 添加AppStoreClient
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static WebApplicationBuilder AddAppStoreClient(this WebApplicationBuilder builder, Action<AppleConfig> action)
        {
            //Configure
            builder.Services.Configure(action);
            builder.Services.AddTransient<IAppleAppstoreClient, AppStoreDefaultClient>();
            return builder;
        }
    }
}
