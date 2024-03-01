// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyTrFirewallV2RoutePolicyScopeShrinkRequest : TeaModel {
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public string DestCandidateListShrink { get; set; }

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
        public string SrcCandidateListShrink { get; set; }

        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
