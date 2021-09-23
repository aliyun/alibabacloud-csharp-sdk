// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceUpgradeInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceUpgradeInfo")]
        [Validation(Required=false)]
        public GetInstanceUpgradeInfoResponseBodyInstanceUpgradeInfo InstanceUpgradeInfo { get; set; }
        public class GetInstanceUpgradeInfoResponseBodyInstanceUpgradeInfo : TeaModel {
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }
            [NameInMap("Operable")]
            [Validation(Required=false)]
            public bool? Operable { get; set; }
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }
            [NameInMap("LatestStartTime")]
            [Validation(Required=false)]
            public long? LatestStartTime { get; set; }
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("PeriodInterval")]
            [Validation(Required=false)]
            public int? PeriodInterval { get; set; }
            [NameInMap("UpgradeStartTime")]
            [Validation(Required=false)]
            public long? UpgradeStartTime { get; set; }
            [NameInMap("UpgradeEndTime")]
            [Validation(Required=false)]
            public long? UpgradeEndTime { get; set; }
            [NameInMap("CandidatePeriodList")]
            [Validation(Required=false)]
            public List<GetInstanceUpgradeInfoResponseBodyInstanceUpgradeInfoCandidatePeriodList> CandidatePeriodList { get; set; }
            public class GetInstanceUpgradeInfoResponseBodyInstanceUpgradeInfoCandidatePeriodList : TeaModel {
                public long? CandidateStartTime { get; set; }
                public long? CandidateEndTime { get; set; }
            }
            [NameInMap("InvalidPeriodList")]
            [Validation(Required=false)]
            public List<GetInstanceUpgradeInfoResponseBodyInstanceUpgradeInfoInvalidPeriodList> InvalidPeriodList { get; set; }
            public class GetInstanceUpgradeInfoResponseBodyInstanceUpgradeInfoInvalidPeriodList : TeaModel {
                public long? InvalidEndTime { get; set; }
                public long? InvalidStartTime { get; set; }
            }
        };

    }

}
