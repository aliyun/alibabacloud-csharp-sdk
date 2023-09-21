// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSwitchRegionDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSwitchRegionDetailResponseBodyData Data { get; set; }
        public class GetSwitchRegionDetailResponseBodyData : TeaModel {
            [NameInMap("GmtIsAgreeModified")]
            [Validation(Required=false)]
            public long? GmtIsAgreeModified { get; set; }

            [NameInMap("GmtNoticed")]
            [Validation(Required=false)]
            public long? GmtNoticed { get; set; }

            [NameInMap("IsAgree")]
            [Validation(Required=false)]
            public string IsAgree { get; set; }

            [NameInMap("IsNoticed")]
            [Validation(Required=false)]
            public string IsNoticed { get; set; }

            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public List<GetSwitchRegionDetailResponseBodyDataRegionStatus> RegionStatus { get; set; }
            public class GetSwitchRegionDetailResponseBodyDataRegionStatus : TeaModel {
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public int? EcsCount { get; set; }

                [NameInMap("GmtPlanSwitchTime")]
                [Validation(Required=false)]
                public long? GmtPlanSwitchTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
