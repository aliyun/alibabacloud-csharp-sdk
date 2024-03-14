// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallIPSWhitelistResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the IPS whitelist of the VPC firewall.
        /// </summary>
        [NameInMap("Whitelists")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallIPSWhitelistResponseBodyWhitelists> Whitelists { get; set; }
        public class DescribeVpcFirewallIPSWhitelistResponseBodyWhitelists : TeaModel {
            /// <summary>
            /// The type of the list. Valid values:
            /// 
            /// *   **1**: user-defined
            /// *   **2**: address book
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            /// <summary>
            /// The entries in the list.
            /// </summary>
            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            /// <summary>
            /// The instance ID of the VPC firewall.
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            /// <summary>
            /// An array of entries in the list.
            /// </summary>
            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            /// <summary>
            /// The type of the whitelist. Valid values:
            /// 
            /// *   **1**: destination
            /// *   **2**: source
            /// </summary>
            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

    }

}
