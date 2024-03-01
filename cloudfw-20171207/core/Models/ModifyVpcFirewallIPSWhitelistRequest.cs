// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallIPSWhitelistRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ListType")]
        [Validation(Required=false)]
        public long? ListType { get; set; }

        [NameInMap("ListValue")]
        [Validation(Required=false)]
        public string ListValue { get; set; }

        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        [NameInMap("WhiteType")]
        [Validation(Required=false)]
        public long? WhiteType { get; set; }

    }

}
