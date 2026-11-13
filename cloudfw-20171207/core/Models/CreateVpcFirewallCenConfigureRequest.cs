// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallCenConfigureRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the CEN.</para>
        /// <remarks>
        /// <para>Prerequisite: The CEN instance must be created by invoking the CreateCen operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-x5jayxou71ad73****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The settings for the switch status of the virtual private cloud (VPC) firewalls at the border. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b> (default): Automatically enables protection after you create a VPC and the virtual private cloud (VPC) firewalls at the border are created.</description></item>
        /// <item><description><b>close</b>: Does not automatically enable protection after the virtual private cloud (VPC) firewalls at the border are created. You can invoke the <a href="https://help.aliyun.com/document_detail/345780.html">ModifyVpcFirewallCenSwitchStatus</a> operation to enable protection.</description></item>
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
        /// <para>The vSwitch CIDR block used by the firewall. You must configure a CIDR block with a subnet mask of no more than 29 bits that does not conflict with your network planning to allocate to the vSwitch CIDR block required for the procedure of creating the firewall, in order to perform automatic creation of the vSwitch (Cloud_Firewall_VSWITCH) in the firewall secure VPC for traffic diversion and processing. The vSwitch CIDR block must be a subnet of the firewall VPC CIDR block.</para>
        /// <para>If you do not specify this parameter, the default is to automatically allocate the 10.219.219.216/29 CIDR block.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you create a VPC firewall in the local region of the CEN for the first time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.219.219.216/29</para>
        /// </summary>
        [NameInMap("FirewallVSwitchCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVSwitchCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the firewall vSwitch belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("FirewallVSwitchZoneId")]
        [Validation(Required=false)]
        public string FirewallVSwitchZoneId { get; set; }

        /// <summary>
        /// <para>The VPC CIDR block used by the firewall. You must configure a CIDR block with a subnet mask of no more than 28 bits to allocate to the VPC CIDR block required for the procedure of creating the firewall, in order to perform automatic creation of the firewall secure VPC (Cloud_Firewall_VPC) for traffic diversion and processing.</para>
        /// <para>If you do not specify this parameter, the default is to automatically allocate the 10.0.0.0/8 CIDR block.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you create a VPC firewall in the local region of the CEN for the first time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("FirewallVpcCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVpcCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone to which the firewall belongs. Only when the primary zone service is not active, the firewall will perform automatic switchover to the secondary zone to continue running.</para>
        /// <para>If you do not specify this parameter, the default is to automatically allocate the secondary zone for the firewall.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you create a VPC firewall in the local region of the CEN for the first time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.219.219.216/29</para>
        /// </summary>
        [NameInMap("FirewallVpcStandbyZoneId")]
        [Validation(Required=false)]
        public string FirewallVpcStandbyZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone to which the firewall belongs.
        /// If your business is sensitive to latency, you can set the zone of the firewall to be the same as the zone of the vSwitch in your business VPC to reduce latency.</para>
        /// <para>If you do not specify this parameter, the system automatically assigns a zone for the firewall.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you create a VPC firewall in the local region of the CEN for the first time.</para>
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
        /// <para>The UID of the member accounts of the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC-connected instance for which you want to create virtual private cloud (VPC) firewalls at the border.</para>
        /// <remarks>
        /// <para>Prerequisite: The VPC must be added to the CEN specified by the CenId parameter by invoking the AttachCenChildInstance operation.</para>
        /// </remarks>
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
        /// <para>The instance name of the virtual private cloud (VPC) firewalls at the border.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall-test</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC for which you want to create virtual private cloud (VPC) firewalls at the border.</para>
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
