// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallIPSWhitelistRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

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
        /// The entry in the list.
        /// </summary>
        [NameInMap("ListValue")]
        [Validation(Required=false)]
        public string ListValue { get; set; }

        /// <summary>
        /// The UID of the member that is managed by your Alibaba Cloud account.
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
