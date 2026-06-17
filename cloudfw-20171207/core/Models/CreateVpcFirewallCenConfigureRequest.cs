// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallCenConfigureRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-x5jayxou71ad73****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The status of the VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>open</b> (default): The VPC firewall is enabled after it is created.</para>
        /// </description></item>
        /// <item><description><para><b>close</b>: The VPC firewall is disabled after it is created. Call the <a href="https://help.aliyun.com/document_detail/345780.html">ModifyVpcFirewallCenSwitchStatus</a> operation to enable the firewall.</para>
        /// </description></item>
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
        /// <para>The CIDR block of the vSwitch that is used by the firewall. Specify a CIDR block with a subnet mask of 29 bits or less that does not conflict with your network plan. This CIDR block is allocated to the vSwitch that is automatically created in the firewall VPC (Cloud_Firewall_VSWITCH) for traffic redirection. The vSwitch CIDR block must be a subnet of the firewall VPC CIDR block. If you do not specify this parameter, the system automatically allocates the 10.219.219.216/29 CIDR block.</para>
        /// <para>If you leave this parameter empty, the CIDR block 10.219.219.216/29 is automatically allocated.</para>
        /// <remarks>
        /// <para>This parameter is valid only when you create a VPC firewall for the first time in the current region of the CEN.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FirewallVSwitchCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVSwitchCidrBlock { get; set; }

        /// <summary>
        /// <para>The CIDR block of the VPC that is used by the firewall. Specify a CIDR block with a subnet mask of 28 bits or less. This CIDR block is allocated to the VPC that is automatically created for the firewall for traffic redirection. If you do not specify this parameter, the system automatically allocates the 10.0.0.0/8 CIDR block.</para>
        /// <para>If you leave this property empty, the CIDR block 10.0.0.0/8 is automatically allocated.</para>
        /// <remarks>
        /// <para>This parameter is valid only when you create a VPC firewall for the first time in the current region of the CEN.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("FirewallVpcCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVpcCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone for the firewall. If the service in the primary zone becomes unavailable, the firewall automatically switches to the secondary zone. If you do not specify this parameter, the system automatically assigns a secondary zone for the firewall.</para>
        /// <para>If you do not specify a value, a zone is automatically allocated to the VPC firewall.</para>
        /// <remarks>
        /// <para>This parameter is valid only when you create a VPC firewall for the first time in the current region of the CEN.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("FirewallVpcStandbyZoneId")]
        [Validation(Required=false)]
        public string FirewallVpcStandbyZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone for the firewall. If your business is sensitive to latency, specify the same zone for the firewall and the vSwitch of your business VPC to reduce latency. If you do not specify this parameter, the system automatically assigns a zone for the firewall.</para>
        /// <para>If you do not specify a value, a zone is automatically allocated to the VPC firewall.</para>
        /// <remarks>
        /// <para>This parameter is valid only when you create a VPC firewall for the first time in the current region of the CEN.</para>
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
        /// <para>The UID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The ID of the VPC for which you want to create the VPC firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp10zlifxh6j0232w****</para>
        /// </summary>
        [NameInMap("NetworkInstanceId")]
        [Validation(Required=false)]
        public string NetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that is used by the Cloud Firewall interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-qzeaol304m***</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The name of the VPC firewall instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall-test</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC for which you want to create the VPC firewall.</para>
        /// <remarks>
        /// <para>For more information about the regions that Cloud Firewall supports, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
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
