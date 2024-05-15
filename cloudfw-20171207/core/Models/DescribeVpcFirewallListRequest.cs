// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallListRequest : TeaModel {
        /// <summary>
        /// The sub-type of the connection. Valid values:
        /// 
        /// *   **vpc2vpc**: Express Connect connection
        /// *   **vpcpeer**: peer connection
        /// </summary>
        [NameInMap("ConnectSubType")]
        [Validation(Required=false)]
        public string ConnectSubType { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The status of the VPC firewall. Valid values:
        /// 
        /// *   **opened**: The VPC firewall is enabled.
        /// *   **closed**: The VPC firewall is disabled.
        /// *   **notconfigured**: The VPC firewall is not configured.
        /// *   **configured**: The VPC firewall is configured.
        /// 
        /// > If you do not specify this parameter, VPC firewalls in all states are queried.
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UID of the member that is managed by your Alibaba Cloud account.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: **10**. Maximum value: **50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The UID of the Alibaba Cloud account to which the peer VPC belongs.
        /// </summary>
        [NameInMap("PeerUid")]
        [Validation(Required=false)]
        public string PeerUid { get; set; }

        /// <summary>
        /// The region ID of the VPC.
        /// 
        /// > For more information about the regions, see [Supported regions](https://help.aliyun.com/document_detail/195657.html).
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// The instance ID of the VPC firewall.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        /// <summary>
        /// The instance name of the VPC firewall.
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
