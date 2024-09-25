// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>To create a VPN gateway, we recommend that you enable automatic payment. If you disable automatic payment, you must manually pay the bill to create the VPN gateway.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the VPN gateway. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description>If you want to create a public VPN gateway, valid values are <b>10</b>, <b>100</b>, <b>200</b>, <b>500</b>, and <b>1000</b>.</description></item>
        /// <item><description>If you want to create a private VPN gateway, valid values are <b>200</b> and <b>1000</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The maximum bandwidth supported by VPN gateways in some regions is 500 Mbit/s. For more information, see <a href="https://help.aliyun.com/document_detail/65290.html">VPN gateway limits</a>.</para>
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
        /// <para>You can use the client to generate a value, and you must make sure that each request has a unique token value. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the value of <b>RequestId</b> as the value of <b>ClientToken</b>. The value of <b>RequestId</b> for each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The second vSwitch with which you want to associate the VPN gateway.</para>
        /// <list type="bullet">
        /// <item><description>If you call this operation in a region that supports the IPsec-VPN connections in dual-tunnel mode, this parameter is required.</description></item>
        /// <item><description>You need to specify two vSwitches in different zones in the virtual private cloud (VPC) that is associated with the VPN gateway to implement disaster recovery across zones.</description></item>
        /// <item><description>For a region that supports only one zone, disaster recovery across zones is not supported. We recommend that you specify two vSwitches in the zone to implement high availability. You can specify the same vSwitch.</description></item>
        /// </list>
        /// <para>For more information about the regions and zones that support the IPsec-VPN connections in dual-tunnel mode, see <a href="https://help.aliyun.com/document_detail/2358946.html">IPsec-VPN connections support the dual-tunnel mode</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-p0wiz7obm0tbimu4r****</para>
        /// </summary>
        [NameInMap("DisasterRecoveryVSwitchId")]
        [Validation(Required=false)]
        public string DisasterRecoveryVSwitchId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPsec-VPN for the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIpsec")]
        [Validation(Required=false)]
        public bool? EnableIpsec { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSL-VPN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSsl")]
        [Validation(Required=false)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// <para>The billing method of the VPN gateway. Set the value to <b>POSTPAY</b>, which specifies the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value for the Alibaba Cloud China site: PREPAY. Example value for the Alibaba Cloud International site: POSTPAY.</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the VPN gateway. The default value is the ID of the VPN gateway.</para>
        /// <para>The name must be 2 to 100 characters in length and cannot start with <c>http://</c> or <c>https://</c>. It must start with a letter and can contain letters, digits, underscores (_), hyphens (-), and periods (.). Other special characters are not supported.</para>
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
        /// <item><description><b>public</b> (default)</description></item>
        /// <item><description><b>private</b></description></item>
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
        /// <para>The subscription duration. Unit: month. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID of the VPN gateway. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <item><description><para>If you do not specify a resource group ID, the VPN gateway belongs to the default resource group.</para>
        /// </description></item>
        /// <item><description><para>After the VPN gateway is created, the following resources also belong to the resource group and you cannot change the resource group: SSL servers, SSL client certificates, IPsec servers, and IPsec-VPN connections.</para>
        /// <para>If you move the VPN gateway to a new resource group, the preceding resources are also moved to the new resource group.</para>
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
        /// <para>The maximum number of clients that can be connected at the same time. Valid values: <b>5</b> (default), <b>10</b>, <b>20</b>, <b>50</b>, <b>100</b>, <b>200</b>, <b>500</b>, and <b>1000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SslConnections")]
        [Validation(Required=false)]
        public int? SslConnections { get; set; }

        /// <summary>
        /// <para>The vSwitch with which you want to associate the VPN gateway.</para>
        /// <list type="bullet">
        /// <item><description>If you call this operation in a region that supports the IPsec-VPN connections in dual-tunnel mode, this parameter is required. You must specify a vSwitch and specify <b>DisasterRecoveryVSwitchId</b>.</description></item>
        /// <item><description>If you call this operation in a region that supports the IPsec-VPN connections in single-tunnel mode and do not specify a vSwitch, the system automatically specifies a vSwitch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1j5miw2bae9s2vt****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where you want to create the VPN gateway.</para>
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
        /// <para>Set the value to <b>Normal</b> (default), which specifies a standard NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
