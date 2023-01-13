// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTrafficMarkingPolicyAttributeRequest : TeaModel {
        [NameInMap("AddTrafficMatchRules")]
        [Validation(Required=false)]
        public List<UpdateTrafficMarkingPolicyAttributeRequestAddTrafficMatchRules> AddTrafficMatchRules { get; set; }
        public class UpdateTrafficMarkingPolicyAttributeRequestAddTrafficMatchRules : TeaModel {
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

            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeleteTrafficMatchRules")]
        [Validation(Required=false)]
        public List<UpdateTrafficMarkingPolicyAttributeRequestDeleteTrafficMatchRules> DeleteTrafficMatchRules { get; set; }
        public class UpdateTrafficMarkingPolicyAttributeRequestDeleteTrafficMatchRules : TeaModel {
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

            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: checks the request but does not modify the name and description of the traffic marking policy. The system checks whether the required parameters are set, whether the formats of the values are valid, and the service limits. If the request fails the check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false** (default): checks the request. If the request passes the check, the name and description of the traffic marking policy are modified.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The new description of the traffic marking policy.
        /// 
        /// The description must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The description must start with a letter.
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
        /// The new name of the traffic marking policy.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("TrafficMarkingPolicyName")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyName { get; set; }

    }

}
