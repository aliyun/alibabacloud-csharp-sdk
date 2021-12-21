// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTrafficMarkingPolicyRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("MarkingDscp")]
        [Validation(Required=false)]
        public int? MarkingDscp { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TrafficMarkingPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyDescription { get; set; }

        [NameInMap("TrafficMarkingPolicyName")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyName { get; set; }

        [NameInMap("TrafficMatchRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class CreateTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
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

        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
