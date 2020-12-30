// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class ListCcCustomedRuleResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public ListCcCustomedRuleResponseBodyRuleList RuleList { get; set; }
        public class ListCcCustomedRuleResponseBodyRuleList : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<ListCcCustomedRuleResponseBodyRuleListRule> Rule { get; set; }
            public class ListCcCustomedRuleResponseBodyRuleListRule : TeaModel {
                public int? BlockingTime { get; set; }
                public string BlockingType { get; set; }
                public int? Interval { get; set; }
                public int? VisitCount { get; set; }
                public string Name { get; set; }
                public string Uri { get; set; }
                public string MatchingRule { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
