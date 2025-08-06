// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAppLicenseResponseBody : TeaModel {
        [NameInMap("FailedLicenseItemIdList")]
        [Validation(Required=false)]
        public List<string> FailedLicenseItemIdList { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
