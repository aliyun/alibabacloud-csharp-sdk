// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallConfigureRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LocalVpcCidrTableList")]
        [Validation(Required=false)]
        public string LocalVpcCidrTableList { get; set; }

        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        [NameInMap("PeerVpcCidrTableList")]
        [Validation(Required=false)]
        public string PeerVpcCidrTableList { get; set; }

        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
