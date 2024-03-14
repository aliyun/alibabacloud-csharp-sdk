// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallIPSWhitelistRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response.
        /// 
        /// Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UID of the member in Cloud Firewall.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// The instance ID of the VPC firewall.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
