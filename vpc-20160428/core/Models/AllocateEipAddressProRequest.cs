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
        /// <item><description><para><b>false</b>: Automatic payment is disabled. After an order is generated, you must go to the User Center to complete the payment.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Automatic payment is enabled, and the order is automatically paid.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>. If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, you can leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the EIP to be allocated. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b> and <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>, valid values for <b>Bandwidth</b> are <b>1</b> to <b>500</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b> and <b>InternetChargeType</b> is set to <b>PayByTraffic</b>, valid values for <b>Bandwidth</b> are <b>1</b> to <b>200</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, valid values for <b>Bandwidth</b> are <b>1</b> to <b>1000</b>.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
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
        /// <item><description><b>BGP</b> (default): BGP (multi-ISP) line. BGP (multi-ISP) EIPs are supported in all regions.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (multi-ISP) Pro line. BGP (multi-ISP) Pro EIPs are supported only in the Hong Kong (China), Singapore, Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions.</description></item>
        /// </list>
        /// <para>For more information about BGP (multi-ISP) and BGP (multi-ISP) Pro lines, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you are a single-ISP bandwidth whitelist user, you can also select the following types:<list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you are an Alibaba Finance Cloud user in the China (Hangzhou) region, this parameter is required. Set the value to <b>BGP_FinanceCloud</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The billing method of the EIP to be allocated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PrePaid</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>PostPaid</b> (default): pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, <b>InternetChargeType</b> must be set to <b>PayByBandwidth</b>.</para>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, <b>InternetChargeType</b> can be set to <b>PayByBandwidth</b> or <b>PayByTraffic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance ID of the EIP to be allocated.</para>
        /// <para>You must specify either <b>IpAddress</b> or <b>InstanceId</b>. If neither is specified, the system randomly allocates an EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-25877c70gddh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The metering method of the EIP to be allocated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PayByBandwidth</b> (default): pay-by-bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>PayByTraffic</b>: pay-by-data-transfer.</para>
        /// </description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, <b>InternetChargeType</b> must be set to <b>PayByBandwidth</b>.</para>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, <b>InternetChargeType</b> can be set to <b>PayByBandwidth</b> or <b>PayByTraffic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP address of the EIP to be allocated.</para>
        /// <para>You must specify either <b>IpAddress</b> or <b>InstanceId</b>. If neither is specified, the system randomly allocates an EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The network type. Set the value to <b>public</b> (default), which indicates the Internet.</para>
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
        /// <para>The subscription duration.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>PricingCycle</b> is set to <b>Month</b>, valid values for <b>Period</b> are <b>1</b> to <b>9</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>PricingCycle</b> is set to <b>Year</b>, valid values for <b>Period</b> are <b>1</b> to <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
        /// <para>Leave this parameter empty if <b>InstanceChargeType</b> is set to <b>PostPaid</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b> (default): billed by month.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: billed by year.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>. If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, you can leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the IP address pool.</para>
        /// <para>The EIP is allocated from this IP address pool.</para>
        /// <para>By default, the IP address pool feature is not available. To use this feature, contact your account manager.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pippool-2vc0kxcedhquybdsz****</para>
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// <para>The region ID of the EIP to be allocated.</para>
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
        /// <para>The ID of the resource group to which the EIP to be allocated belongs.</para>
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
        /// <item><description><para>If this parameter is left empty, Anti-DDoS Basic is used by default.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set to <b>AntiDDoS_Enhanced</b>, Anti-DDoS (Enhanced) is used.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AllocateEipAddressProRequestTag> Tag { get; set; }
        public class AllocateEipAddressProRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. If you specify this parameter, you cannot enter an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, you can enter an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It must start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
