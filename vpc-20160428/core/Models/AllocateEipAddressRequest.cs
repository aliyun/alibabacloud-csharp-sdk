// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The special activity ID. You do not need to configure this parameter.</para>
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
        /// <item><description><para><b>false</b> (default): Automatic payment is disabled. After an order is generated, go to the Order Center to complete the payment.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Automatic payment is enabled. The order is automatically paid.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>. This parameter is optional if <b>InstanceChargeType</b> is set to <b>PostPaid</b>.</para>
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
        /// <item><description><para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b> and <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>, valid values for <b>Bandwidth</b> are <b>1</b> to <b>500</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b> and <b>InternetChargeType</b> is set to <b>PayByTraffic</b>, valid values for <b>Bandwidth</b> are <b>1</b> to <b>200</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, valid values for <b>Bandwidth</b> are <b>1</b> to <b>1000</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>5</b> Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. <b>ClientToken</b> can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the EIP instance.</para>
        /// <para>The description must be 0 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <remarks>
        /// <para>This parameter is not supported when you create a subscription EIP instance.</para>
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
        /// <item><description><b>BGP</b> (default): BGP (multi-ISP) line. All regions support BGP (multi-ISP) EIPs.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (multi-ISP) Pro line. Only Hong Kong (China), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions support BGP (multi-ISP) Pro EIPs.</description></item>
        /// </list>
        /// <para>For more information about BGP (multi-ISP) and BGP (multi-ISP) Pro, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you are a whitelist user of single-ISP bandwidth, you can also select the following types:<list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you are a China (Hangzhou) Finance Cloud user, this parameter is required and must be set to <b>BGP_FinanceCloud</b>.</description></item>
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
        /// <item><description><para><b>PrePaid</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>PostPaid</b> (default): pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, <b>InternetChargeType</b> must be set to <b>PayByBandwidth</b>. If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, <b>InternetChargeType</b> can be set to <b>PayByBandwidth</b> or <b>PayByTraffic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance ID of the EIP that you want to apply for.</para>
        /// <para>You need to specify only one of <b>IpAddress</b> and <b>InstanceId</b>. If neither is specified, the system randomly allocates an EIP.</para>
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
        /// <item><description><para><b>PayByBandwidth</b> (default): pay-by-bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>PayByTraffic</b>: pay-by-data-transfer.</para>
        /// </description></item>
        /// </list>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PrePaid</b>, <b>InternetChargeType</b> must be set to <b>PayByBandwidth</b>.</para>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PostPaid</b>, <b>InternetChargeType</b> can be set to <b>PayByBandwidth</b> or <b>PayByTraffic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP address of the EIP that you want to apply for.</para>
        /// <para>You need to specify only one of <b>IpAddress</b> and <b>InstanceId</b>. If neither is specified, the system randomly allocates an EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The name of the EIP instance.</para>
        /// <para>The name must be 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <remarks>
        /// <para>This parameter is not supported when you create a subscription EIP instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EIP1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type. The value is set to <b>public</b> (default), which indicates the public network.</para>
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
        /// <para>If <b>PricingCycle</b> is set to <b>Month</b>, valid values for <b>Period</b> are <b>1</b> to <b>9</b>.</para>
        /// <para>If <b>PricingCycle</b> is set to <b>Year</b>, valid values for <b>Period</b> are <b>1</b> to <b>5</b>.</para>
        /// <para>This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>. This parameter is not required if <b>InstanceChargeType</b> is set to <b>PostPaid</b>.</para>
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
        /// <item><description><b>Month</b> (default): billed on a monthly basis.</description></item>
        /// <item><description><b>Year</b>: billed on a yearly basis.</description></item>
        /// </list>
        /// <para>This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>. This parameter is optional if <b>InstanceChargeType</b> is set to <b>PostPaid</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the IP address pool.</para>
        /// <para>The EIP is allocated from the specified IP address pool.</para>
        /// <para>The IP address pool feature is not available by default. To use this feature, apply for the IP address pool privilege quota in Quota Center. For more information, see <a href="https://help.aliyun.com/document_detail/108213.html">Increase a quota in Quota Center</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pippool-2vc0kxcedhquybdsz****</para>
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// <para>The region ID of the EIP.</para>
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
        /// <para>The resource group ID.</para>
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
        /// <para>The security protection level.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is left empty, the default value is Anti-DDoS Basic.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set to <b>AntiDDoS_Enhanced</b>, Anti-DDoS (Enhanced) is used.</para>
        /// </description></item>
        /// </list>
        /// <para>You can specify at most one security protection level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AntiDDoS_Enhanced</para>
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AllocateEipAddressRequestTag> Tag { get; set; }
        public class AllocateEipAddressRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Specify the value in the Tag.N.Value format. Valid values of N: 1 to 20. The tag value cannot be an empty string. The tag value can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone of the EIP.</para>
        /// <para>If the IP address pool specified by <b>PublicIpAddressPoolId</b> is of the CloudBox type, this parameter defaults to the zone of the IP address pool.</para>
        /// <para>For information about how to view the business type of an IP address pool, see <a href="https://help.aliyun.com/document_detail/429098.html">ListPublicIpAddressPools</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1-lzdvn-cb</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
