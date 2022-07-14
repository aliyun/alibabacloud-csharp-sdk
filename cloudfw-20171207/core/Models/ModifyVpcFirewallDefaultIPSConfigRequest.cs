// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallDefaultIPSConfigRequest : TeaModel {
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public string BasicRules { get; set; }

        [NameInMap("EnableAllPatch")]
        [Validation(Required=false)]
        public string EnableAllPatch { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
