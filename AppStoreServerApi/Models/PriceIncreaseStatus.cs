﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/priceincreasestatus
    public enum PriceIncreaseStatus
    {
        NoResponse = 0,
        Consented = 1
    }
}
