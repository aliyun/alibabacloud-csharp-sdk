// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLicenseResponseBody : TeaModel {
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AssetLimit")]
        [Validation(Required=false)]
        public int? AssetLimit { get; set; }

        [NameInMap("AssetLimitUsed")]
        [Validation(Required=false)]
        public int? AssetLimitUsed { get; set; }

    }

}
