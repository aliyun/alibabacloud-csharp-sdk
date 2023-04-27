// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTrafficMarkingPoliciesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TrafficMarkingPolicies")]
        [Validation(Required=false)]
        public List<ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPolicies> TrafficMarkingPolicies { get; set; }
        public class ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPolicies : TeaModel {
            [NameInMap("MarkingDscp")]
            [Validation(Required=false)]
            public int? MarkingDscp { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("TrafficMarkingPolicyDescription")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyDescription { get; set; }

            [NameInMap("TrafficMarkingPolicyId")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyId { get; set; }

            [NameInMap("TrafficMarkingPolicyName")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyName { get; set; }

            [NameInMap("TrafficMarkingPolicyStatus")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyStatus { get; set; }

            [NameInMap("TrafficMatchRules")]
            [Validation(Required=false)]
            public List<ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPoliciesTrafficMatchRules> TrafficMatchRules { get; set; }
            public class ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPoliciesTrafficMatchRules : TeaModel {
                [NameInMap("DstCidr")]
                [Validation(Required=false)]
                public string DstCidr { get; set; }

                [NameInMap("DstPortRange")]
                [Validation(Required=false)]
                public List<int?> DstPortRange { get; set; }

                [NameInMap("MatchDscp")]
                [Validation(Required=false)]
                public int? MatchDscp { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("SrcCidr")]
                [Validation(Required=false)]
                public string SrcCidr { get; set; }

                [NameInMap("SrcPortRange")]
                [Validation(Required=false)]
                public List<int?> SrcPortRange { get; set; }

                [NameInMap("TrafficMatchRuleDescription")]
                [Validation(Required=false)]
                public string TrafficMatchRuleDescription { get; set; }

                [NameInMap("TrafficMatchRuleId")]
                [Validation(Required=false)]
                public string TrafficMatchRuleId { get; set; }

                [NameInMap("TrafficMatchRuleName")]
                [Validation(Required=false)]
                public string TrafficMatchRuleName { get; set; }

                [NameInMap("TrafficMatchRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMatchRuleStatus { get; set; }

            }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
