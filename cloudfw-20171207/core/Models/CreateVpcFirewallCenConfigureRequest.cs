// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallCenConfigureRequest : TeaModel {
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        [NameInMap("NetworkInstanceId")]
        [Validation(Required=false)]
        public string NetworkInstanceId { get; set; }

        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        [NameInMap("VpcRegion")]
        [Validation(Required=false)]
        public string VpcRegion { get; set; }

    }

}
