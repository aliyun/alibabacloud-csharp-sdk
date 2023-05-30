// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2Request : TeaModel {
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("FirewallDescription")]
        [Validation(Required=false)]
        public string FirewallDescription { get; set; }

        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

        [NameInMap("FirewallSubnetCidr")]
        [Validation(Required=false)]
        public string FirewallSubnetCidr { get; set; }

        [NameInMap("FirewallVpcCidr")]
        [Validation(Required=false)]
        public string FirewallVpcCidr { get; set; }

        [NameInMap("FirewallVpcId")]
        [Validation(Required=false)]
        public string FirewallVpcId { get; set; }

        [NameInMap("FirewallVswitchId")]
        [Validation(Required=false)]
        public string FirewallVswitchId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        [NameInMap("RouteMode")]
        [Validation(Required=false)]
        public string RouteMode { get; set; }

        [NameInMap("TrAttachmentMasterCidr")]
        [Validation(Required=false)]
        public string TrAttachmentMasterCidr { get; set; }

        [NameInMap("TrAttachmentSlaveCidr")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveCidr { get; set; }

        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
