// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTrafficMarkingPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. 
        /// 
        /// - If **NextToken** was not returned in the previous query, it indicates that no additional results exist.
        /// - If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the traffic marking policy.
        /// </summary>
        [NameInMap("TrafficMarkingPolicies")]
        [Validation(Required=false)]
        public List<ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPolicies> TrafficMarkingPolicies { get; set; }
        public class ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPolicies : TeaModel {
            /// <summary>
            /// The differentiated services code point (DSCP) value of the traffic marking policy.
            /// </summary>
            [NameInMap("MarkingDscp")]
            [Validation(Required=false)]
            public int? MarkingDscp { get; set; }

            /// <summary>
            /// The priority of the traffic marking policy.
            /// 
            /// A smaller value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The description of the traffic marking policy.
            /// </summary>
            [NameInMap("TrafficMarkingPolicyDescription")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyDescription { get; set; }

            /// <summary>
            /// The ID of the traffic marking policy.
            /// </summary>
            [NameInMap("TrafficMarkingPolicyId")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyId { get; set; }

            /// <summary>
            /// The name of the traffic marking policy.
            /// </summary>
            [NameInMap("TrafficMarkingPolicyName")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyName { get; set; }

            /// <summary>
            /// The status of the traffic marking policy. Valid values:
            /// 
            /// *   **Creating**: The policy is being created.
            /// *   **Active**: The policy is available.
            /// *   **Modifying**: The policy is being modified.
            /// *   **Deleting**: The policy is being deleted.
            /// *   **Deleted**: The policy is deleted.
            /// </summary>
            [NameInMap("TrafficMarkingPolicyStatus")]
            [Validation(Required=false)]
            public string TrafficMarkingPolicyStatus { get; set; }

            /// <summary>
            /// The information about the traffic classification rule.
            /// </summary>
            [NameInMap("TrafficMatchRules")]
            [Validation(Required=false)]
            public List<ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPoliciesTrafficMatchRules> TrafficMatchRules { get; set; }
            public class ListTrafficMarkingPoliciesResponseBodyTrafficMarkingPoliciesTrafficMatchRules : TeaModel {
                /// <summary>
                /// The destination CIDR block used to match data packets.
                /// </summary>
                [NameInMap("DstCidr")]
                [Validation(Required=false)]
                public string DstCidr { get; set; }

                /// <summary>
                /// The destination port range used to match data packets.
                /// 
                /// Two destination port numbers are returned.
                /// 
                /// *   If the destination ports are the same, for example, port 80, the traffic classification rule matches data packets that are sent to port 80.
                /// 
                ///     If the destination ports are both -1, the traffic classification rule matches all data packets.
                /// 
                /// *   If the destination ports are different, for example, port 1 and port 200, the traffic classification rule matches data packets whose destination port ranges from port 1 to port 200.
                /// </summary>
                [NameInMap("DstPortRange")]
                [Validation(Required=false)]
                public List<int?> DstPortRange { get; set; }

                /// <summary>
                /// The DSCP value used to match data packets.
                /// </summary>
                [NameInMap("MatchDscp")]
                [Validation(Required=false)]
                public int? MatchDscp { get; set; }

                /// <summary>
                /// The protocol used to match data packets.
                /// 
                /// >  Traffic marking policies support multiple protocols. For more information, see the documentation of CEN.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The source CIDR block used to match data packets.
                /// </summary>
                [NameInMap("SrcCidr")]
                [Validation(Required=false)]
                public string SrcCidr { get; set; }

                /// <summary>
                /// The source port range used to match data packets.
                /// 
                /// Two source port numbers are returned.
                /// 
                /// *   If the source ports are the same, for example, port 80, the traffic classification rule matches data packets that are sent from port 80.
                /// 
                ///     If the source ports are both -1, the traffic classification rule matches all data packets.
                /// 
                /// *   If the source ports are different, for example, port 1 and port 200, the traffic classification rule matches data packets whose source port ranges from port 1 to port 200.
                /// </summary>
                [NameInMap("SrcPortRange")]
                [Validation(Required=false)]
                public List<int?> SrcPortRange { get; set; }

                /// <summary>
                /// The description of the traffic classification rule.
                /// </summary>
                [NameInMap("TrafficMatchRuleDescription")]
                [Validation(Required=false)]
                public string TrafficMatchRuleDescription { get; set; }

                /// <summary>
                /// The ID of the traffic classification rule.
                /// </summary>
                [NameInMap("TrafficMatchRuleId")]
                [Validation(Required=false)]
                public string TrafficMatchRuleId { get; set; }

                /// <summary>
                /// The name of the traffic classification rule.
                /// </summary>
                [NameInMap("TrafficMatchRuleName")]
                [Validation(Required=false)]
                public string TrafficMatchRuleName { get; set; }

                /// <summary>
                /// The status of the traffic classification rule. Valid values:
                /// 
                /// *   **Creating**: The rule is being created.
                /// *   **Active**: The rule is available.
                /// *   **Deleting**: The rule is being deleted.
                /// *   **Deleted**: The rule is deleted.
                /// </summary>
                [NameInMap("TrafficMatchRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMatchRuleStatus { get; set; }

            }

            /// <summary>
            /// The ID of the transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
