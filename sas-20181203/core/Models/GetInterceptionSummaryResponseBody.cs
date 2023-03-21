// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionSummaryResponseBody : TeaModel {
        [NameInMap("InterceptionSummary")]
        [Validation(Required=false)]
        public GetInterceptionSummaryResponseBodyInterceptionSummary InterceptionSummary { get; set; }
        public class GetInterceptionSummaryResponseBodyInterceptionSummary : TeaModel {
            [NameInMap("CloseClusterCount")]
            [Validation(Required=false)]
            public int? CloseClusterCount { get; set; }

            [NameInMap("CloseRuleCount")]
            [Validation(Required=false)]
            public int? CloseRuleCount { get; set; }

            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            [NameInMap("InterceptionCountInDays")]
            [Validation(Required=false)]
            public int? InterceptionCountInDays { get; set; }

            [NameInMap("OpenClusterCount")]
            [Validation(Required=false)]
            public int? OpenClusterCount { get; set; }

            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public int? OpenRuleCount { get; set; }

            [NameInMap("RiskCount180Day")]
            [Validation(Required=false)]
            public long? RiskCount180Day { get; set; }

            [NameInMap("RiskCount30Day")]
            [Validation(Required=false)]
            public long? RiskCount30Day { get; set; }

            [NameInMap("RiskCountToday")]
            [Validation(Required=false)]
            public long? RiskCountToday { get; set; }

            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
