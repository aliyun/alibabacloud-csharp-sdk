// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallCenConfigureRequest : TeaModel {
        /// <summary>
        /// <para>The Cloud Enterprise Network (CEN) instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-x5jayxou71ad73****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The switch status of the VPC border firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b> (default): Protection is automatically enabled after the VPC border firewall is created.</description></item>
        /// <item><description><b>close</b>: Protection is not automatically enabled after the VPC border firewall is created. You can call the <a href="https://help.aliyun.com/document_detail/345780.html">ModifyVpcFirewallCenSwitchStatus</a> operation to enable protection.</description></item>
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
        /// <para>The vSwitch CIDR block used by the firewall. You must configure a CIDR block with a subnet mask no larger than 29 bits that does not conflict with the network plan to allocate a vSwitch CIDR block for the firewall creation process. This is used to automatically create a vSwitch (Cloud_Firewall_VSWITCH) within the firewall security VPC for traffic redirection. The vSwitch CIDR block must be a subnet of the firewall VPC CIDR block.</para>
        /// <para>If this parameter is not specified, the CIDR block 10.219.219.216/29 is automatically allocated by default.</para>
        /// <remarks>
        /// <para>This parameter is only valid when a VPC firewall is created for the first time in this CEN region.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FirewallVSwitchCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVSwitchCidrBlock { get; set; }

        /// <summary>
        /// <para>The VPC CIDR block used by the firewall. You must configure a CIDR block with a subnet mask no larger than 28 bits to allocate a VPC CIDR block for the firewall creation process. This is used to automatically create a firewall security VPC (Cloud_Firewall_VPC) for traffic redirection.</para>
        /// <para>If this parameter is not specified, the CIDR block 10.0.0.0/8 is automatically allocated by default.</para>
        /// <remarks>
        /// <para>This parameter is only valid when a VPC firewall is created for the first time in this CEN region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("FirewallVpcCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVpcCidrBlock { get; set; }

        /// <summary>
        /// <para>The standby availability zone ID of the firewall. The firewall automatically switches to the standby availability zone and continues to run only when the primary availability zone service is unavailable.</para>
        /// <para>If this parameter is not specified, the firewall standby availability zone is automatically allocated by default.</para>
        /// <remarks>
        /// <para>This parameter is only valid when a VPC firewall is created for the first time in this CEN region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("FirewallVpcStandbyZoneId")]
        [Validation(Required=false)]
        public string FirewallVpcStandbyZoneId { get; set; }

        /// <summary>
        /// <para>The primary availability zone ID of the firewall.
        /// If your business is latency-sensitive, you can customize the firewall availability zone to be the same as your business VPC vSwitch availability zone to reduce latency.</para>
        /// <para>If this parameter is not specified, the firewall availability zone is automatically allocated by default.</para>
        /// <remarks>
        /// <para>This parameter is only valid when a VPC firewall is created for the first time in this CEN region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("FirewallVpcZoneId")]
        [Validation(Required=false)]
        public string FirewallVpcZoneId { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Valid values:</para>
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
        /// <para>The member account UID of the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The VPC instance ID for which the VPC border firewall is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp10zlifxh6j0232w****</para>
        /// </summary>
        [NameInMap("NetworkInstanceId")]
        [Validation(Required=false)]
        public string NetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID to which the Cloud Firewall interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-qzeaol304m***</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The instance name of the VPC border firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall-test</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC for which the VPC border firewall is created.</para>
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
