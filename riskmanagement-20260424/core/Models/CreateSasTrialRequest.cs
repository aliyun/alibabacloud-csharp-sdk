// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class CreateSasTrialRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public CreateSasTrialRequestSdkRequest SdkRequest { get; set; }
        public class CreateSasTrialRequestSdkRequest : TeaModel {
            [NameInMap("FromEcs")]
            [Validation(Required=false)]
            public bool? FromEcs { get; set; }

            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            [NameInMap("RequestForm")]
            [Validation(Required=false)]
            public CreateSasTrialRequestSdkRequestRequestForm RequestForm { get; set; }
            public class CreateSasTrialRequestSdkRequestRequestForm : TeaModel {
                [NameInMap("TryReason")]
                [Validation(Required=false)]
                public string TryReason { get; set; }

            }

            [NameInMap("TryType")]
            [Validation(Required=false)]
            public int? TryType { get; set; }

            [NameInMap("TryVersion")]
            [Validation(Required=false)]
            public int? TryVersion { get; set; }

        }

    }

}
