// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallV2RoutePolicyListResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// The routing policies.
        /// </summary>
        [NameInMap("TrFirewallRoutePolicies")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePolicies> TrFirewallRoutePolicies { get; set; }
        public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePolicies : TeaModel {
            /// <summary>
            /// The secondary traffic redirection instances.
            /// </summary>
            [NameInMap("DestCandidateList")]
            [Validation(Required=false)]
            public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesDestCandidateList> DestCandidateList { get; set; }
            public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesDestCandidateList : TeaModel {
                /// <summary>
                /// The ID of the secondary traffic redirection instance.
                /// </summary>
                [NameInMap("CandidateId")]
                [Validation(Required=false)]
                public string CandidateId { get; set; }

                /// <summary>
                /// The type of the secondary traffic redirection instance.
                /// </summary>
                [NameInMap("CandidateType")]
                [Validation(Required=false)]
                public string CandidateType { get; set; }

            }

            /// <summary>
            /// The description of the routing policy.
            /// </summary>
            [NameInMap("PolicyDescription")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// The name of the routing policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The status of the routing policy. Valid values:
            /// 
            /// *   creating: The policy is being created.
            /// *   deleting: The policy is being deleted.
            /// *   opening: The policy is being enabled.
            /// *   opened: The policy is enabled.
            /// *   closing: The policy is being disabled.
            /// *   closed: The policy is disabled.
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// The type of the traffic redirection scenario of the VPC firewall. Valid values:
            /// 
            /// *   **fullmesh**: interconnected instances
            /// *   **one_to_one**: instance to instance
            /// *   **end_to_end**: instance to instances
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// The primary traffic redirection instances.
            /// </summary>
            [NameInMap("SrcCandidateList")]
            [Validation(Required=false)]
            public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesSrcCandidateList> SrcCandidateList { get; set; }
            public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesSrcCandidateList : TeaModel {
                /// <summary>
                /// The ID of the primary traffic redirection instance.
                /// </summary>
                [NameInMap("CandidateId")]
                [Validation(Required=false)]
                public string CandidateId { get; set; }

                /// <summary>
                /// The type of the primary traffic redirection instance.
                /// </summary>
                [NameInMap("CandidateType")]
                [Validation(Required=false)]
                public string CandidateType { get; set; }

            }

            /// <summary>
            /// The ID of the routing policy.
            /// </summary>
            [NameInMap("TrFirewallRoutePolicyId")]
            [Validation(Required=false)]
            public string TrFirewallRoutePolicyId { get; set; }

        }

    }

}
