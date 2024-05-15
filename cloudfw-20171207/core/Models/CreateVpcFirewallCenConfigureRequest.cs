// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallCenConfigureRequest : TeaModel {
        /// <summary>
        /// The ID of the CEN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// Specifies whether to enable the VPC firewall. Valid values:
        /// 
        /// *   **open**: After you create the VPC firewall, the VPC firewall is automatically enabled. This is the default value.
        /// *   **close**: After you create the VPC firewall, the VPC firewall is disabled. You can call the [ModifyVpcFirewallCenSwitchStatus](https://help.aliyun.com/document_detail/345780.html) operation to manually enable the VPC firewall.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// The CIDR block of the vSwitch that is automatically created for the VPC firewall. You must specify a CIDR block for the Cloud_Firewall_VSWITCH VPC that is automatically created for the VPC firewall for traffic redirection. The CIDR block does not conflict with your network plan. The subnet mask of the CIDR block must be less than or equal to 29 bits in length. The CIDR block of the vSwitch must be within the network segment of the VPC.
        /// 
        /// If you do not specify a value, the CIDR block 10.219.219.216/29 is automatically allocated.
        /// 
        /// >  This parameter takes effect only when you create a VPC firewall for the first time in the current CEN instance and region.
        /// </summary>
        [NameInMap("FirewallVSwitchCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVSwitchCidrBlock { get; set; }

        /// <summary>
        /// The CIDR block of the VPC that is automatically created for the VPC firewall. You must specify a CIDR block for the Cloud_Firewall_VPC VPC that is automatically created for the VPC firewall for traffic redirection. The subnet mask of the CIDR block must be less than or equal to 28 bits in length.
        /// 
        /// If you do not specify a value, the CIDR block 10.0.0.0/8 is automatically allocated.
        /// 
        /// >  This parameter takes effect only when you create a VPC firewall for the first time in the current CEN instance and region.
        /// </summary>
        [NameInMap("FirewallVpcCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVpcCidrBlock { get; set; }

        /// <summary>
        /// The ID of the zone to which the vSwitch belongs. If your service is latency-sensitive, you can specify the same zone for the vSwitch of the firewall and the vSwitch of your business VPC to minimize latency.
        /// 
        /// If you do not specify a value, a zone is automatically assigned for the vSwitch.
        /// 
        /// >  This parameter takes effect only when you create a VPC firewall for the first time in the current CEN instance and region. For more information about zones that are supported by each region, see [Query zones](https://help.aliyun.com/document_detail/36064.html).
        /// </summary>
        [NameInMap("FirewallVpcZoneId")]
        [Validation(Required=false)]
        public string FirewallVpcZoneId { get; set; }

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
        /// The ID of the VPC for which you want to create the VPC firewall.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkInstanceId")]
        [Validation(Required=false)]
        public string NetworkInstanceId { get; set; }

        /// <summary>
        /// The ID of the vSwitch that is used to associate with the elastic network interface (ENI) required by the VPC firewall.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The instance name of the VPC firewall.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// The ID of the region to which the VPC belongs.
        /// 
        /// > For more information about the regions, see [Supported regions](https://help.aliyun.com/document_detail/195657.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcRegion")]
        [Validation(Required=false)]
        public string VpcRegion { get; set; }

    }

}
