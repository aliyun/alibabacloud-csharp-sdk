// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2RoutePolicyRequest : TeaModel {
        /// <summary>
        /// The secondary traffic redirection instances.
        /// </summary>
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public List<CreateTrFirewallV2RoutePolicyRequestDestCandidateList> DestCandidateList { get; set; }
        public class CreateTrFirewallV2RoutePolicyRequestDestCandidateList : TeaModel {
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
        /// The instance ID of the VPC firewall.
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The description of the traffic redirection instance.
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// The name of the traffic redirection instance.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

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
        public List<CreateTrFirewallV2RoutePolicyRequestSrcCandidateList> SrcCandidateList { get; set; }
        public class CreateTrFirewallV2RoutePolicyRequestSrcCandidateList : TeaModel {
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

    }

}
