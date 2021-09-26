// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetRiskLevelDistributionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeList")]
        [Validation(Required=false)]
        public List<GetRiskLevelDistributionResponseBodyTimeList> TimeList { get; set; }
        public class GetRiskLevelDistributionResponseBodyTimeList : TeaModel {
            [NameInMap("MiddleRiskCount")]
            [Validation(Required=false)]
            public long? MiddleRiskCount { get; set; }

            [NameInMap("HighRiskCount")]
            [Validation(Required=false)]
            public long? HighRiskCount { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("BeginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("LowRiskCount")]
            [Validation(Required=false)]
            public long? LowRiskCount { get; set; }

        }

    }

}
