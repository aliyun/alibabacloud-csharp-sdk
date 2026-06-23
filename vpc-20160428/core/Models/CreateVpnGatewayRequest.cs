// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically pay the bill for the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: automatically pays the bill for the VPN gateway.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): does not automatically pay the bill for the VPN gateway.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To successfully create a VPN gateway instance, enable automatic payment. If you disable automatic payment, you must manually pay the bill to create the VPN gateway instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The bandwidth specification of the VPN gateway. Unit: Mbit/s.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- If you want to create a public VPN gateway, valid values are <b>5</b>, <b>10</b>, <b>20</b>, <b>50</b>, <b>100</b>, <b>200</b>, <b>500</b>, and <b>1000</b>.
        /// &lt;props=&quot;china&quot;&gt;- If you want to create a private VPN gateway, valid values are <b>200</b> and <b>1000</b>.
        /// &lt;props=&quot;intl&quot;&gt;- If you want to create a public VPN gateway, valid values are <b>10</b>, <b>100</b>, <b>200</b>, <b>500</b>, and <b>1000</b>.
        /// &lt;props=&quot;intl&quot;&gt;- If you want to create a private VPN gateway, valid values are <b>200</b> and <b>1000</b>.</para>
        /// <remarks>
        /// <para>The maximum bandwidth specification supported by VPN gateways in some regions is 500 Mbit/s. For more information, see <a href="https://help.aliyun.com/document_detail/65290.html">VPN gateway limits</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The second vSwitch associated with the VPN VPC-connected instance.</para>
        /// <list type="bullet">
        /// <item><description>If the current region supports dual-tunnel IPsec-VPN connections, this parameter is required.</description></item>
        /// <item><description>You must specify two vSwitches in different zones within the VPC associated with the VPN VPC-connected instance to implement zone-level disaster recovery for IPsec-VPN connections.</description></item>
        /// <item><description>For regions that support only one zone, zone-level disaster recovery is not supported. Specify two different vSwitches in the same zone to achieve high availability for IPsec-VPN connections. You can also specify the same vSwitch.</description></item>
        /// </list>
        /// <para>For information about the regions and zones that support dual-tunnel IPsec-VPN connections, see <a href="https://help.aliyun.com/document_detail/2358946.html">Upgrade an IPsec-VPN connection to dual-tunnel mode</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0wiz7obm0tbimu4r****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the IPsec-VPN feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): enables the IPsec-VPN feature.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables the IPsec-VPN feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIpsec")]
        [Validation(Required=false)]
        public bool? EnableIpsec { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SSL-VPN feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the SSL-VPN feature.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables the SSL-VPN feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSsl")]
        [Validation(Required=false)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The billing method of the VPN gateway. Set the value to <b>PREPAY</b>, which specifies the subscription billing method.
        /// &lt;props=&quot;intl&quot;&gt;The billing method of the VPN gateway. Set the value to <b>POSTPAY</b>, which specifies the pay-as-you-go billing method.
        /// &lt;props=&quot;partner&quot;&gt;The billing method of the VPN gateway. Set the value to <b>POSTPAY</b>, which specifies the pay-as-you-go billing method.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;This parameter is required when you create a VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国站示例值：PREPAY，国际站示例值：POSTPAY</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the VPN gateway. The default value is the ID of the VPN gateway.</para>
        /// <para>The name must be 2 to 100 characters in length. It cannot start with <c>http://</c> or <c>https://</c>. It must start with an uppercase or lowercase letter and can contain uppercase and lowercase letters, digits, underscores (_), hyphens (-), and periods (.). Other special characters are not supported.</para>
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
        /// <item><description><b>private</b>: private VPN gateway.</description></item>
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
        /// <para>The subscription duration. Unit: months. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is required if <b>InstanceChargeType</b> is set to <b>PREPAY</b>..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID of the VPN gateway. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the VPN gateway belongs.</para>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource group IDs.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify a resource group ID, the VPN gateway belongs to the default resource group after it is created.</para>
        /// </description></item>
        /// <item><description><para>After the VPN gateway is created, if you create SSL servers, SSL client certificates, IPsec servers, or IPsec-VPN connections (when the IPsec-VPN connection is associated with the VPN gateway) under the VPN gateway, these resources belong to the same resource group as the VPN gateway. The resource group of these resources cannot be modified.</para>
        /// <para>If you change the resource group of the VPN gateway, the resource group of the preceding resources is also changed.</para>
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
        /// <para>The maximum number of clients that can be simultaneously connected. Valid values: <b>5</b> (default), <b>10</b>, <b>20</b>, <b>50</b>, <b>100</b>, <b>200</b>, <b>500</b>, and <b>1000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SslConnections")]
        [Validation(Required=false)]
        public int? SslConnections { get; set; }

        /// <summary>
        /// <para>The vSwitch associated with the VPN gateway instance. </para>
        /// <list type="bullet">
        /// <item><description>In regions that support dual-tunnel IPsec-VPN connections, this parameter is required. You must specify a vSwitch and also specify the <b>DisasterRecoveryVSwitchId</b> parameter.</description></item>
        /// <item><description>In regions that support only single-tunnel IPsec-VPN connections, if you do not specify a vSwitch, the system automatically selects a vSwitch from the VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1j5miw2bae9s2vt****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC-connected instance to which the VPN gateway belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1ub1yt9cvakoelj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The type of the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b> (default): standard.
        /// &lt;props=&quot;china&quot;&gt;- <b>NationalStandard</b>: Chinese SM-based..</description></item>
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
