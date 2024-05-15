// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenListRequest : TeaModel {
        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
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
        /// *   **configured**: The VPC firewall is configured but is not enabled.
        /// 
        /// > If you do not specify this parameter, VPC firewalls in all states are queried.
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UID of the member that is managed by your Alibaba Cloud account. The member is also an Alibaba Cloud account.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// The ID of the network instance.
        /// </summary>
        [NameInMap("NetworkInstanceId")]
        [Validation(Required=false)]
        public string NetworkInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 10. Maximum value: 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The region ID of the VPC.
        /// 
        /// > For more information about the regions, see [Supported regions](https://help.aliyun.com/document_detail/195657.html).
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// The routing mode of the VPC firewall. Valid values:
        /// 
        /// *   **auto**: automatic mode
        /// *   **manual**: manual mode
        /// 
        /// > If you do not specify this parameter, VPC firewalls in all routing modes are queried.
        /// </summary>
        [NameInMap("RouteMode")]
        [Validation(Required=false)]
        public string RouteMode { get; set; }

        /// <summary>
        /// The type of the transit router. Valid values:
        /// 
        /// *   **Basic**: Basic Edition transit router
        /// *   **Enterprise**: Enterprise Edition transit router
        /// </summary>
        [NameInMap("TransitRouterType")]
        [Validation(Required=false)]
        public string TransitRouterType { get; set; }

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

    }

}
