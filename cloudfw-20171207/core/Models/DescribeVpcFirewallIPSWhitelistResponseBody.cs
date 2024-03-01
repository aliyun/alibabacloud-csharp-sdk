// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallIPSWhitelistResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Whitelists")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallIPSWhitelistResponseBodyWhitelists> Whitelists { get; set; }
        public class DescribeVpcFirewallIPSWhitelistResponseBodyWhitelists : TeaModel {
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

    }

}
