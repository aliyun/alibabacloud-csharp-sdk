// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterRuleSummaryResponseBody : TeaModel {
        [NameInMap("ClusterRuleSummary")]
        [Validation(Required=false)]
        public GetClusterRuleSummaryResponseBodyClusterRuleSummary ClusterRuleSummary { get; set; }
        public class GetClusterRuleSummaryResponseBodyClusterRuleSummary : TeaModel {
            [NameInMap("CloseRuleCount")]
            [Validation(Required=false)]
            public int? CloseRuleCount { get; set; }

            [NameInMap("InterceptionCount7Day")]
            [Validation(Required=false)]
            public long? InterceptionCount7Day { get; set; }

            [NameInMap("InterceptionSwitch")]
            [Validation(Required=false)]
            public int? InterceptionSwitch { get; set; }

            [NameInMap("InterceptionType")]
            [Validation(Required=false)]
            public int? InterceptionType { get; set; }

            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public int? OpenRuleCount { get; set; }

            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            [NameInMap("SuggestRuleCount")]
            [Validation(Required=false)]
            public int? SuggestRuleCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
