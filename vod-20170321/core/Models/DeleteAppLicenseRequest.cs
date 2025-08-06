// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAppLicenseRequest : TeaModel {
        [NameInMap("AppItemId")]
        [Validation(Required=false)]
        public string AppItemId { get; set; }

        [NameInMap("LicenseItemIds")]
        [Validation(Required=false)]
        public string LicenseItemIds { get; set; }

    }

}
