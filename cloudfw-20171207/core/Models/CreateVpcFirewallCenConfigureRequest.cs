// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallCenConfigureRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the CEN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-x5jayxou71ad73****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The status of the virtual private cloud (VPC) firewall after you create a VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b> (default): The VPC firewall is automatically enabled after it is created.</description></item>
        /// <item><description><b>close</b>: The VPC firewall is not automatically enabled after it is created. You can invoke the <a href="https://help.aliyun.com/document_detail/345780.html">ModifyVpcFirewallCenSwitchStatus</a> operation to enable the VPC firewall.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// <para>The CIDR block of the vSwitch used by the firewall. Specify a CIDR block with a subnet mask of no more than 29 bits that does not conflict with your network planning. This CIDR block is allocated to the vSwitch that is created during the process to create a VPC firewall within the firewall security VPC (Cloud_Firewall_VSWITCH) for traffic redirection. The vSwitch CIDR block must be a subnet of the firewall VPC CIDR block.</para>
        /// <para>If you leave this parameter empty, the default CIDR block 10.219.219.216/29 is automatically allocated.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when a VPC firewall is created for the first time in the local region of the CEN instance.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FirewallVSwitchCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVSwitchCidrBlock { get; set; }

        /// <summary>
        /// <para>The CIDR block of the VPC used by the firewall. Specify a CIDR block with a subnet mask of no more than 28 bits. This CIDR block is allocated to the VPC that is created during the process to create a VPC firewall (Cloud_Firewall_VPC) for traffic redirection.</para>
        /// <para>If you leave this parameter empty, the default CIDR block 10.0.0.0/8 is automatically allocated.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when a VPC firewall is created for the first time in the local region of the CEN instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("FirewallVpcCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVpcCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone to which the firewall belongs. The firewall performs an automatic switchover to the secondary zone to continue running only when the primary zone becomes unavailable.</para>
        /// <para>If you leave this parameter empty, a default secondary zone is automatically allocated for the firewall.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when a VPC firewall is created for the first time in the local region of the CEN instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("FirewallVpcStandbyZoneId")]
        [Validation(Required=false)]
        public string FirewallVpcStandbyZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the primary active zone to which the firewall belongs. If your business is latency-sensitive, you can set the firewall zone to the same zone as the vSwitch of the business VPC to reduce latency.</para>
        /// <para>If you leave this parameter empty, a default zone is automatically allocated for the firewall.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when a VPC firewall is created for the first time in the local region of the CEN instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("FirewallVpcZoneId")]
        [Validation(Required=false)]
        public string FirewallVpcZoneId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The UID of the member account of the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC for which you want to create a VPC firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp10zlifxh6j0232w****</para>
        /// </summary>
        [NameInMap("NetworkInstanceId")]
        [Validation(Required=false)]
        public string NetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the Cloud Firewall interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-qzeaol304m***</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The instance name of the virtual private cloud (VPC) firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall-test</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC for which you want to create a VPC firewall.</para>
        /// <remarks>
        /// <para>For more information about the regions supported by Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VpcRegion")]
        [Validation(Required=false)]
        public string VpcRegion { get; set; }

    }

}
