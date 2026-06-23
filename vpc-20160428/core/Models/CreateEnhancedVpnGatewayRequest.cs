// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateEnhancedVpnGatewayRequest : TeaModel {
        /// <summary>
        /// <para>A client token used to ensure request idempotence.</para>
        /// <para>You can generate this token from your client. Make sure that the token is unique for each request. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. Each request may have a different <b>RequestId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the second vSwitch to associate with the enhanced VPN gateway for high availability.</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description><para>For zone-level disaster recovery, the two vSwitches must be in different availability zones within the same VPC.</para>
        /// </description></item>
        /// <item><description><para>In regions with only one availability zone, zone-level disaster recovery is not supported. To ensure high availability, specify two different vSwitches from that zone. You can also specify the same vSwitch for both the <b>VSwitchId</b> and <b>DisasterRecoveryVSwitchId</b> parameters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0wiz7obm0tbimu4r****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>The type of the enhanced VPN gateway. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>Enhanced.SiteToSite</b>: an enhanced site-to-site VPN gateway that supports only the IPsec feature.</description></item>
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
        /// <para>The name of the enhanced VPN gateway. If you do not specify this parameter, the gateway ID is used as the name.</para>
        /// <para>The name must be 2 to 100 characters long, start with a letter, and not start with http\:// or https\://. It can contain only letters, digits, underscores (_), hyphens (-), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYVPN</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type of the VPN gateway. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b> (default): a public VPN gateway.</description></item>
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
        /// <para>The ID of the region where you want to create the enhanced VPN gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to get the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which you want to assign the enhanced VPN gateway.</para>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource group IDs.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the enhanced VPN gateway is added to the Default Resource Group.</para>
        /// </description></item>
        /// <item><description><para>Associated IPsec connections are automatically added to the same resource group as the enhanced VPN gateway. You cannot directly change the resource group of an IPsec connection. If you change the resource group of the gateway, the resource group of its associated IPsec connections is also updated.</para>
        /// </description></item>
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
        /// <para>The ID of the vSwitch to associate with the enhanced VPN gateway.</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1j5miw2bae9s2vt****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where you want to create the enhanced VPN gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1ub1yt9cvakoelj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The type of the enhanced VPN gateway. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b> (default): standard type.</description></item>
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
