// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipAddressProRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: Disables automatic payment. You must go to the Order Center to pay for the order.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Enables automatic payment. The payment is completed automatically.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required only when <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The peak bandwidth of the EIP. Unit: Mbps.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>InstanceChargeType</b> is <b>PostPaid</b> (pay-as-you-go) and <b>InternetChargeType</b> is <b>PayByBandwidth</b>, <b>Bandwidth</b> can be from <b>1</b> to <b>500</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>InstanceChargeType</b> is <b>PostPaid</b> (pay-as-you-go) and <b>InternetChargeType</b> is <b>PayByTraffic</b>, <b>Bandwidth</b> can be from <b>1</b> to <b>200</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>InstanceChargeType</b> is <b>PrePaid</b> (subscription), <b>Bandwidth</b> can be from <b>1</b> to <b>1000</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>A token used to ensure the idempotence of the request.</para>
        /// <para>You must ensure that this token is unique across requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> differs for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe6****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The line type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BGP</b> (default): BGP (Multi-ISP) line. All regions support EIPs that use BGP (Multi-ISP) lines.</para>
        /// </description></item>
        /// <item><description><para><b>BGP_PRO</b>: BGP (Multi-ISP) Pro line. This line type is available only in the China (Hong Kong), Singapore, Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro lines, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>If your account is on the allowlist for single-ISP bandwidth, you can also select one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ChinaTelecom</b></para>
        /// </description></item>
        /// <item><description><para><b>ChinaUnicom</b></para>
        /// </description></item>
        /// <item><description><para><b>ChinaMobile</b></para>
        /// </description></item>
        /// <item><description><para><b>ChinaTelecom_L2</b></para>
        /// </description></item>
        /// <item><description><para><b>ChinaUnicom_L2</b></para>
        /// </description></item>
        /// <item><description><para><b>ChinaMobile_L2</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For China (Hangzhou) Finance Cloud users, this parameter is required and must be set to <b>BGP_FinanceCloud</b>.</para>
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
        /// <item><description><para><b>PrePaid</b>: subscription</para>
        /// </description></item>
        /// <item><description><para><b>PostPaid</b> (default): pay-as-you-go</para>
        /// </description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, <b>InternetChargeType</b> must be set to <b>PayByBandwidth</b>.</para>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, you can set <b>InternetChargeType</b> to <b>PayByBandwidth</b> or <b>PayByTraffic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the EIP to be allocated.</para>
        /// <para>You can specify either <b>IpAddress</b> or <b>InstanceId</b>. If you do not specify either parameter, the system randomly allocates an EIP.</para>
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
        /// <item><description><para><b>PayByBandwidth</b> (default): pay-by-bandwidth</para>
        /// </description></item>
        /// <item><description><para><b>PayByTraffic</b>: pay-by-traffic</para>
        /// </description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, <b>InternetChargeType</b> must be set to <b>PayByBandwidth</b>.</para>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, you can set <b>InternetChargeType</b> to <b>PayByBandwidth</b> or <b>PayByTraffic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP address of the EIP to be allocated.</para>
        /// <para>You can specify either <b>IpAddress</b> or <b>InstanceId</b>. If you do not specify either parameter, the system randomly allocates an EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The network type. The only valid value is <b>public</b> (default), which indicates the public network.</para>
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
        /// <para>The subscription period.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>PricingCycle</b> is <b>Month</b>, <b>Period</b> can be from <b>1</b> to <b>9</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>PricingCycle</b> is <b>Year</b>, <b>Period</b> can be from <b>1</b> to <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required when <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
        /// <para>If <c>InstanceChargeType</c> is set to <c>PostPaid</c>, this parameter is not required.</para>
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
        /// <item><description><para><b>Month</b> (default): Billed monthly.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: Billed annually.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required only when <b>InstanceChargeType</b> is set to <b>PrePaid</b> (subscription).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the IP address pool from which to allocate the EIP.</para>
        /// <para>This feature is disabled by default. To use this feature, apply for the required permissions in Quota Center. For more information, see <a href="https://help.aliyun.com/document_detail/108213.html">Increase quotas by using Quota Center</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pippool-2vc0kxcedhquybdsz****</para>
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the EIP is to be allocated.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group for the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-resourcegroup****</para>
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
        /// <para>The security protection level.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, DDoS Protection (Basic) is enabled by default.</para>
        /// </description></item>
        /// <item><description><para>Set the value to <b>AntiDDoS_Enhanced</b> to enable DDoS Protection (Enhanced).</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// <para>The tags to add to the EIP.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AllocateEipAddressProRequestTag> Tag { get; set; }
        public class AllocateEipAddressProRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
