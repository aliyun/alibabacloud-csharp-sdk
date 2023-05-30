// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallV2RoutePolicyListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrFirewallRoutePolicies")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePolicies> TrFirewallRoutePolicies { get; set; }
        public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePolicies : TeaModel {
            [NameInMap("DestCandidateList")]
            [Validation(Required=false)]
            public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesDestCandidateList> DestCandidateList { get; set; }
            public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesDestCandidateList : TeaModel {
                [NameInMap("CandidateId")]
                [Validation(Required=false)]
                public string CandidateId { get; set; }

                [NameInMap("CandidateType")]
                [Validation(Required=false)]
                public string CandidateType { get; set; }

            }

            [NameInMap("PolicyDescription")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            [NameInMap("SrcCandidateList")]
            [Validation(Required=false)]
            public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesSrcCandidateList> SrcCandidateList { get; set; }
            public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesSrcCandidateList : TeaModel {
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

}
