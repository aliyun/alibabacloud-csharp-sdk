// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The promotion code. This parameter is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public long? ActivityId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): The automatic payment is disabled. If you select this option, you must go to the Order Center to complete the payment after an order is generated.</description></item>
        /// <item><description><b>true</b>: The automatic payment is enabled. Payments are automatically complete after an order is generated.</description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, this parameter is required. If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, this parameter is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the EIP. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when <b>InstanceChargeType</b> is set to <b>PostPaid</b> and <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>: <b>1</b> to <b>500</b>.****</description></item>
        /// <item><description>Valid values when <b>InstanceChargeType</b> is set to <b>PostPaid</b> and <b>InternetChargeType</b> is set to <b>PayByTraffic</b>: <b>1</b> to <b>200</b>.****</description></item>
        /// <item><description>Valid values when <b>InstanceChargeType</b> is set to <b>PrePaid</b>: <b>1</b> to <b>1000</b>.****</description></item>
        /// </list>
        /// <para>Default value: <b>5</b>. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate a token, but you must make sure that the token is unique among different requests. The <b>client token</b> can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the value of <b>RequestId</b> as the <b>client token</b>. The value of <b>RequestId</b> is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the EIP.</para>
        /// <para>The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <remarks>
        /// <para> You cannot specify this parameter if you create a subscription EIP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The line type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (Multi-ISP) All regions support BGP (Multi-ISP) EIPs.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro Only the following regions support BGP (Multi-ISP) Pro lines: China (Hong Kong), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok).</description></item>
        /// </list>
        /// <para>For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see the &quot;Line types&quot; section of <a href="https://help.aliyun.com/document_detail/32321.html">What is EIP?</a></para>
        /// <list type="bullet">
        /// <item><description><para>If you are allowed to use single-ISP bandwidth, you can also choose one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b></description></item>
        /// <item><description><b>ChinaUnicom</b></description></item>
        /// <item><description><b>ChinaMobile</b></description></item>
        /// <item><description><b>ChinaTelecom_L2</b></description></item>
        /// <item><description><b>ChinaUnicom_L2</b></description></item>
        /// <item><description><b>ChinaMobile_L2</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to <b>BGP_FinanceCloud</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The billing method of the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b> (default): pay-as-you-go</description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, set <b>InternetChargeType</b> to <b>PayByBandwidth</b>. If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, set <b>InternetChargeType</b> to <b>PayByBandwidth</b> or <b>PayByTraffic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The EIP ID.</para>
        /// <para>Specify <b>IpAddress</b> or <b>InstanceId</b>. If you leave both parameters empty, the system randomly allocates an EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-25877c70gddh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The metering method of the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b> (default): pay-by-bandwidth</description></item>
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer</description></item>
        /// </list>
        /// <para>When <b>InstanceChargeType</b> is set to <b>PrePaid</b>, set <b>InternetChargeType</b> to <b>PayByBandwidth</b>.</para>
        /// <para>When <b>InstanceChargeType</b> is set to <b>PostPaid</b>, set <b>InternetChargeType</b> to <b>PayByBandwidth</b> or <b>PayByTraffic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP address of the EIP that you want to request.</para>
        /// <para>Specify <b>IpAddress</b> or <b>InstanceId</b>. If you leave both parameters empty, the system randomly allocates an EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The EIP name.</para>
        /// <para>The name must be 1 to 128 characters in length and start with a letter, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para> You cannot specify this parameter if you create a subscription EIP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EIP1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type. Default value: <b>public</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("Netmode")]
        [Validation(Required=false)]
        public string Netmode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription duration of the EIP.</para>
        /// <para>Valid values when <b>PricingCycle</b> is set to <b>Month</b>: <b>1</b> to <b>9</b>.****</para>
        /// <para>Valid values when <b>PricingCycle</b> is set to <b>Year</b>: <b>1</b> to <b>5</b>.****</para>
        /// <para>This parameter must be specified when <b>InstanceChargeType</b> is set to <b>PrePaid</b>. This parameter is optional when <b>InstanceChargeType</b> is set to <b>PostPaid</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b> (default)</description></item>
        /// <item><description><b>Year</b></description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, this parameter is required. If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, this parameter is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the IP address pool.</para>
        /// <para>The EIP is allocated from the IP address pool.</para>
        /// <para>By default, the IP address pool feature is unavailable. To use the IP address pool, apply for the privilege in the Quota Center console. For more information, see the &quot;Request a quota increase in the Quota Center console&quot; section in <a href="https://help.aliyun.com/document_detail/108213.html">Manage EIP quotas</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pippool-2vc0kxcedhquybdsz****</para>
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the EIP belongs.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazffggds****</para>
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
        /// <para>The editions of Anti-DDoS.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, Anti-DDoS Origin Basic is used.</description></item>
        /// <item><description>If you set the parameter to <b>AntiDDoS_Enhanced</b>, Anti-DDoS Pro/Premium is used.</description></item>
        /// </list>
        /// <para>You can specify up to 10 editions of Anti-DDoS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AntiDDoS_Enhanced</para>
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AllocateEipAddressRequestTag> Tag { get; set; }
        public class AllocateEipAddressRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone of the EIP.</para>
        /// <para>When the service type of the IP address pool specified by <b>PublicIpAddressPoolId</b> is CloudBox, the default value is the zone of the IP address pool.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/429433.html">ListPublicIpAddressPools</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
