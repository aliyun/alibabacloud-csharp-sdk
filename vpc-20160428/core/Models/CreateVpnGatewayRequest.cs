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
        /// <para>To ensure the successful creation of the VPN gateway instance, enable automatic payment. If automatic payment is disabled, you must manually pay the bill to create the VPN gateway instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The bandwidth limit of the VPN gateway. Unit: Mbit/s.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- If you want to create an Internet-public VPN gateway, valid values are <b>5</b>, <b>10</b>, <b>20</b>, <b>50</b>, <b>100</b>, <b>200</b>, <b>500</b>, and <b>1000</b>.
        /// &lt;props=&quot;china&quot;&gt;- If you want to create an internal-public VPN gateway, valid values are <b>200</b> and <b>1000</b>.
        /// &lt;props=&quot;intl&quot;&gt;- If you want to create an Internet-public VPN gateway, valid values are <b>10</b>, <b>100</b>, <b>200</b>, <b>500</b>, and <b>1000</b>.
        /// &lt;props=&quot;intl&quot;&gt;- If you want to create an internal-public VPN gateway, valid values are <b>200</b> and <b>1000</b>.</para>
        /// <remarks>
        /// <para>In some regions, the maximum bandwidth limit supported by a VPN gateway is 500 Mbit/s. For more information, see <a href="https://help.aliyun.com/document_detail/65290.html">Limits on VPN gateways</a>.</para>
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
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies the second vSwitch instance to associate with the VPN gateway instance.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the current region supports creating IPsec-VPN connections in the dual-tunnel pattern.</description></item>
        /// <item><description>You must specify two vSwitch instances distributed in different zones under the VPC to which the VPN gateway instance is associated, to implement zone-level disaster recovery for the IPsec-VPN connection.</description></item>
        /// <item><description>For regions that support only one zone, zone-level disaster recovery is not supported. We recommend that you specify two different vSwitch instances in the zone to implement high availability for the IPsec-VPN connection. You can specify the same vSwitch instance.</description></item>
        /// </list>
        /// <para>For more information about the regions and zones that support dual-tunnel IPsec-VPN connections, see <a href="https://help.aliyun.com/document_detail/2358946.html">Upgrade an IPsec-VPN connection to the dual-tunnel mode</a>.</para>
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
        /// <item><description><para><b>false</b>: does not enable the IPsec-VPN feature.</para>
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
        /// <item><description><para><b>false</b> (default): does not enable the SSL-VPN feature.</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;The billing method of the VPN gateway. Valid value: <b>PREPAY</b> (subscription).
        /// &lt;props=&quot;intl&quot;&gt;The billing method of the VPN gateway. Valid value: <b>POSTPAY</b> (pay-as-you-go billing method).
        /// &lt;props=&quot;partner&quot;&gt;The billing method of the VPN gateway. Valid value: <b>POSTPAY</b> (pay-as-you-go billing method).</para>
        /// <para>&lt;props=&quot;china&quot;&gt;This parameter is required when you create a VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value for the China site: PREPAY. Example value for the international site: POSTPAY</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the VPN gateway. Default value: the ID of the VPN gateway.</para>
        /// <para>The name must be 2 to 100 characters in length, and cannot start with http:// or https://. It must start with a letter and can contain letters, digits, underscores (_), hyphens (-), and periods (.). Other special characters are not supported.</para>
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
        /// <item><description><b>public</b> (default): Internet-public VPN gateway.</description></item>
        /// <item><description><b>private</b>: internal-public VPN gateway.</description></item>
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
        /// <para>This parameter is required when the <b>InstanceChargeType</b> parameter is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region where the VPN gateway resides. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <item><description><para>If you do not specify this parameter, the VPN gateway belongs to the default resource group after it is created.</para>
        /// </description></item>
        /// <item><description><para>After the VPN gateway is created, if you create an SSL server, an SSL client certificate, an IPsec server, or an IPsec-VPN connection (referring to the scenario where the IPsec-VPN connection is associated with the VPN gateway) under the VPN gateway, these resources automatically belong to the resource group of the VPN gateway and their resource groups cannot be modified.</para>
        /// <para>If you change the resource group of the VPN gateway, the resource groups of the preceding resources are also changed.</para>
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
        /// <para>The maximum number of concurrent SSL-VPN connections. Valid values: <b>5</b> (default), <b>10</b>, <b>20</b>, <b>50</b>, <b>100</b>, <b>200</b>, <b>500</b>, and <b>1000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SslConnections")]
        [Validation(Required=false)]
        public int? SslConnections { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the VPN gateway is connected. </para>
        /// <list type="bullet">
        /// <item><description>In regions that support dual-tunnel IPsec-VPN connections, this parameter is required. You must specify a vSwitch and also specify the <b>DisasterRecoveryVSwitchId</b> parameter.</description></item>
        /// <item><description>In regions that support single-tunnel IPsec-VPN connections, if you do not specify a vSwitch, the system automatically selects a vSwitch in the VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1j5miw2bae9s2vt****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC-connected instance to which the VPN gateway belongs.</para>
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
        /// <item><description><b>Normal</b> (default): standard VPN gateway.
        /// &lt;props=&quot;china&quot;&gt;- <b>NationalStandard</b>: Chinese national standard VPN gateway.</description></item>
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
