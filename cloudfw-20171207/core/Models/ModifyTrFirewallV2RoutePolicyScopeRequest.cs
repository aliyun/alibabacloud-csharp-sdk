// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyTrFirewallV2RoutePolicyScopeRequest : TeaModel {
        /// <summary>
        /// The secondary traffic redirection instances.
        /// </summary>
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public List<ModifyTrFirewallV2RoutePolicyScopeRequestDestCandidateList> DestCandidateList { get; set; }
        public class ModifyTrFirewallV2RoutePolicyScopeRequestDestCandidateList : TeaModel {
            /// <summary>
            /// The ID of the traffic redirection instance.
            /// </summary>
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            /// <summary>
            /// The type of the traffic redirection instance.
            /// </summary>
            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

        }

        /// <summary>
        /// The instance ID of the virtual private cloud (VPC) firewall.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *  **zh** (default): Chinese
        /// *  **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether to restore the traffic redirection configurations. Valid values:
        /// 
        /// *   true: roll back
        /// *   false: withdraw
        /// </summary>
        [NameInMap("ShouldRecover")]
        [Validation(Required=false)]
        public string ShouldRecover { get; set; }

        /// <summary>
        /// The primary traffic redirection instances.
        /// </summary>
        [NameInMap("SrcCandidateList")]
        [Validation(Required=false)]
        public List<ModifyTrFirewallV2RoutePolicyScopeRequestSrcCandidateList> SrcCandidateList { get; set; }
        public class ModifyTrFirewallV2RoutePolicyScopeRequestSrcCandidateList : TeaModel {
            /// <summary>
            /// The ID of the traffic redirection instance.
            /// </summary>
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            /// <summary>
            /// The type of the traffic redirection instance.
            /// </summary>
            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

        }

        /// <summary>
        /// The ID of the routing policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
