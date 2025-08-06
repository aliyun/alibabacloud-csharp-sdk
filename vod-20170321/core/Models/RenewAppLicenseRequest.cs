// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RenewAppLicenseRequest : TeaModel {
        [NameInMap("LicenseItemIds")]
        [Validation(Required=false)]
        public string LicenseItemIds { get; set; }

        [NameInMap("OrderIds")]
        [Validation(Required=false)]
        public string OrderIds { get; set; }

        [NameInMap("PurchaseMethod")]
        [Validation(Required=false)]
        public string PurchaseMethod { get; set; }

    }

}
