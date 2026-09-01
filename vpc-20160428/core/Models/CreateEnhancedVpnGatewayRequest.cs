// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateEnhancedVpnGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The second vSwitch associated with the enhanced VPN VPC-connected instance.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required.</description></item>
        /// <item><description>You must specify two vSwitches in different zones under the VPC associated with the enhanced VPN VPC-connected instance to implement zone-level disaster recovery for IPsec-VPN connections.</description></item>
        /// <item><description>For regions that support only one zone, zone-level disaster recovery is not supported. Specify two different vSwitches in the same zone to achieve high availability for IPsec-VPN connections. You can also specify the same vSwitch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0wiz7obm0tbimu4r****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>The type of the enhanced VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enhanced.SiteToSite</b>: enhanced site-to-cloud VPN that covers only IPsec functionality.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced.SiteToSite</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The name of the enhanced VPN gateway. The default value is the ID of the enhanced VPN gateway.</para>
        /// <para>The name must be 2 to 100 characters in length. It cannot start with http:// or https://. It must start with an uppercase or lowercase letter and can contain uppercase and lowercase letters, digits, underscores (_), hyphens (-), and periods (.). Other special characters are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYVPN</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type of the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b> (default): public VPN gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the enhanced VPN gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the enhanced VPN gateway belongs.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource group IDs.</description></item>
        /// <item><description>If you do not specify a resource group ID, the enhanced VPN gateway belongs to the default resource group after it is created.</description></item>
        /// <item><description>After the enhanced VPN gateway is created, if you create IPsec-VPN connections under the enhanced VPN gateway (IPsec-VPN connections bound to the enhanced VPN gateway), these resources belong to the same resource group as the enhanced VPN gateway and cannot be modified independently. If you change the resource group of the enhanced VPN gateway, the resource group of the preceding resources is also changed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The vSwitch associated with the enhanced VPN gateway instance.</para>
        /// <list type="bullet">
        /// <item><description>You must specify a vSwitch and also specify the <b>DisasterRecoveryVSwitchId</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1j5miw2bae9s2vt****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the enhanced VPN gateway belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1ub1yt9cvakoelj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The type of the enhanced VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b> (default): standard.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
