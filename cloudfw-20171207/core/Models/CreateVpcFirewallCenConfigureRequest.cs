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
        /// <para>Specifies whether to enable the VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: After you create the VPC firewall, the VPC firewall is automatically enabled. This is the default value.</description></item>
        /// <item><description><b>close</b>: After you create the VPC firewall, the VPC firewall is disabled. You can call the <a href="https://help.aliyun.com/document_detail/345780.html">ModifyVpcFirewallCenSwitchStatus</a> operation to manually enable the VPC firewall.</description></item>
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
        /// <para>The CIDR block of the vSwitch that is automatically created for the VPC firewall. You must specify a CIDR block for the Cloud_Firewall_VSWITCH VPC that is automatically created for the VPC firewall for traffic redirection. The CIDR block does not conflict with your network plan. The subnet mask of the CIDR block must be less than or equal to 29 bits in length. The CIDR block of the vSwitch must be within the network segment of the VPC.</para>
        /// <para>If you do not specify a value, the CIDR block 10.219.219.216/29 is automatically allocated.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when you create a VPC firewall for the first time in the current CEN instance and region.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FirewallVSwitchCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVSwitchCidrBlock { get; set; }

        /// <summary>
        /// <para>The CIDR block of the VPC that is automatically created for the VPC firewall. You must specify a CIDR block for the Cloud_Firewall_VPC VPC that is automatically created for the VPC firewall for traffic redirection. The subnet mask of the CIDR block must be less than or equal to 28 bits in length.</para>
        /// <para>If you do not specify a value, the CIDR block 10.0.0.0/8 is automatically allocated.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when you create a VPC firewall for the first time in the current CEN instance and region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("FirewallVpcCidrBlock")]
        [Validation(Required=false)]
        public string FirewallVpcCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the vSwitch belongs. If your service is latency-sensitive, you can specify the same zone for the vSwitch of the firewall and the vSwitch of your business VPC to minimize latency.</para>
        /// <para>If you do not specify a value, a zone is automatically assigned for the vSwitch.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when you create a VPC firewall for the first time in the current CEN instance and region. For more information about zones that are supported by each region, see <a href="https://help.aliyun.com/document_detail/36064.html">Query zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("FirewallVpcZoneId")]
        [Validation(Required=false)]
        public string FirewallVpcZoneId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The UID of the member that is managed by your Alibaba Cloud account.</para>
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
        /// <para>The ID of the vSwitch that is used to associate with the elastic network interface (ENI) required by the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-qzeaol304m***</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The instance name of the VPC firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test instance</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the VPC belongs.</para>
        /// <remarks>
        /// <para>For more information about the regions, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
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
