// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallConfigureRequest : TeaModel {
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LocalVpcCidrTableList")]
        [Validation(Required=false)]
        public string LocalVpcCidrTableList { get; set; }

        [NameInMap("LocalVpcId")]
        [Validation(Required=false)]
        public string LocalVpcId { get; set; }

        [NameInMap("LocalVpcRegion")]
        [Validation(Required=false)]
        public string LocalVpcRegion { get; set; }

        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        [NameInMap("PeerVpcCidrTableList")]
        [Validation(Required=false)]
        public string PeerVpcCidrTableList { get; set; }

        [NameInMap("PeerVpcId")]
        [Validation(Required=false)]
        public string PeerVpcId { get; set; }

        [NameInMap("PeerVpcRegion")]
        [Validation(Required=false)]
        public string PeerVpcRegion { get; set; }

        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
