// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2RoutePolicyRequest : TeaModel {
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public List<CreateTrFirewallV2RoutePolicyRequestDestCandidateList> DestCandidateList { get; set; }
        public class CreateTrFirewallV2RoutePolicyRequestDestCandidateList : TeaModel {
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

        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        [NameInMap("SrcCandidateList")]
        [Validation(Required=false)]
        public List<CreateTrFirewallV2RoutePolicyRequestSrcCandidateList> SrcCandidateList { get; set; }
        public class CreateTrFirewallV2RoutePolicyRequestSrcCandidateList : TeaModel {
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

        }

    }

}
