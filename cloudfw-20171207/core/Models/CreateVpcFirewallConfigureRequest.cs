// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallConfigureRequest : TeaModel {
        /// <summary>
        /// The status of the VPC firewall after you create the firewall. Valid values:
        /// 
        /// *   **open**: After you create the VPC firewall, the VPC firewall is automatically enabled. This is the default value.
        /// *   **close**: After you create the VPC firewall, the VPC firewall is disabled. To enable the firewall, you can call the [ModifyVpcFirewallSwitchStatus](https://help.aliyun.com/document_detail/342935.html) operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The CIDR blocks of the local VPC. The value is a JSON string that contains the following parameters:
        /// 
        /// *   **RouteTableId**: the ID of the route table for the local VPC.
        /// *   **RouteEntryList**: The value is a JSON string that contains the DestinationCidr and NextHopInstanceId parameters. The DestinationCidr parameter indicates the destination CIDR block of the local VPC. The NextHopInstanceId parameter indicates the instance ID of the next hop for the local VPC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocalVpcCidrTableList")]
        [Validation(Required=false)]
        public string LocalVpcCidrTableList { get; set; }

        /// <summary>
        /// The ID of the local VPC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocalVpcId")]
        [Validation(Required=false)]
        public string LocalVpcId { get; set; }

        /// <summary>
        /// The region ID of the local VPC.
        /// 
        /// >  For more information about the regions in which Cloud Firewall is available, see [Supported regions](https://help.aliyun.com/document_detail/195657.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocalVpcRegion")]
        [Validation(Required=false)]
        public string LocalVpcRegion { get; set; }

        /// <summary>
        /// The UID of the member that is managed by your Alibaba Cloud account.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// The CIDR blocks of the peer VPC. The value is a JSON string that contains the following parameters:
        /// 
        /// *   **RouteTableId**: the ID of the route table for the peer VPC.
        /// *   **RouteEntryList**: The value is a JSON string that contains the DestinationCidr and NextHopInstanceId parameters. The DestinationCidr parameter indicates the destination CIDR block of the peer VPC. The NextHopInstanceId parameter indicates the instance ID of the next hop for the peer VPC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PeerVpcCidrTableList")]
        [Validation(Required=false)]
        public string PeerVpcCidrTableList { get; set; }

        /// <summary>
        /// The ID of the peer VPC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PeerVpcId")]
        [Validation(Required=false)]
        public string PeerVpcId { get; set; }

        /// <summary>
        /// The region ID of the peer VPC.
        /// 
        /// >  For more information about Cloud Firewall supported regions, see [Supported regions](https://help.aliyun.com/document_detail/195657.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PeerVpcRegion")]
        [Validation(Required=false)]
        public string PeerVpcRegion { get; set; }

        /// <summary>
        /// The instance name of the VPC firewall.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
