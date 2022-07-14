// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDefaultIPSConfigResponseBody : TeaModel {
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public int? BasicRules { get; set; }

        [NameInMap("EnableAllPatch")]
        [Validation(Required=false)]
        public int? EnableAllPatch { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public int? RunMode { get; set; }

    }

}
