// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class QueryAppQuotaResponseBody : TeaModel {
        [NameInMap("ActiveLicenseCount")]
        [Validation(Required=false)]
        public int? ActiveLicenseCount { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("LicenseCount")]
        [Validation(Required=false)]
        public int? LicenseCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsagePercent")]
        [Validation(Required=false)]
        public double? UsagePercent { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
