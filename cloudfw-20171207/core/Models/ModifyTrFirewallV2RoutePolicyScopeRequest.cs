// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyTrFirewallV2RoutePolicyScopeRequest : TeaModel {
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public List<ModifyTrFirewallV2RoutePolicyScopeRequestDestCandidateList> DestCandidateList { get; set; }
        public class ModifyTrFirewallV2RoutePolicyScopeRequestDestCandidateList : TeaModel {
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

        }

        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ShouldRecover")]
        [Validation(Required=false)]
        public string ShouldRecover { get; set; }

        [NameInMap("SrcCandidateList")]
        [Validation(Required=false)]
        public List<ModifyTrFirewallV2RoutePolicyScopeRequestSrcCandidateList> SrcCandidateList { get; set; }
        public class ModifyTrFirewallV2RoutePolicyScopeRequestSrcCandidateList : TeaModel {
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

        }

        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
