// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateCommonBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s. </para>
        /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>1</b> to <b>1000</b>. Default value: <b>1</b>.</ph></para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>, which indicates that the billing method of the Internet Shared Bandwidth instance is pay-by-bandwidth, the valid values of <b>Bandwidth</b> are <b>2</b> to <b>20000</b>.</description></item>
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayBy95</b>, which indicates that the billing method of the Internet Shared Bandwidth instance is pay-by-enhanced-95th-percentile, the valid values of <b>Bandwidth</b> are <b>200</b> to <b>20000</b>.</description></item>
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByDominantTraffic</b>, which indicates that the billing method of the Internet Shared Bandwidth instance is pay-by-dominant-traffic, the valid values of <b>Bandwidth</b> are <b>1</b> to <b>2000</b>.</description></item>
        /// </list>
        /// <para>Default value: <b>1000</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the Internet Shared Bandwidth instance.</para>
        /// <para>The description must be 0 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The line type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (multi-ISP) line. BGP (multi-ISP) lines are supported in all regions.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (multi-ISP) Pro line. BGP (multi-ISP) Pro Internet Shared Bandwidth is supported only in the Hong Kong (China), Singapore, Japan (Tokyo), Philippines (Manila), Malaysia (Kuala Lumpur), Indonesia (Jakarta), and Thailand (Bangkok) regions.</description></item>
        /// </list>
        /// <para>If your account is added to the whitelist for single-ISP bandwidth, you can also select the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
        /// </list>
        /// <para>If you use Alibaba Finance Cloud in the China (Hangzhou) region, this parameter is required. Set the value to <b>BGP_FinanceCloud</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The billing method of the Internet Shared Bandwidth instance. Valid values:
        /// &lt;props=&quot;intl&quot;&gt;<b>PayByTraffic</b> (pay-by-data-transfer).</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b> (default): pay-by-bandwidth.</description></item>
        /// <item><description><b>PayBy95</b>: pay-by-enhanced-95th-percentile.</description></item>
        /// <item><description><b>PayByDominantTraffic</b>: pay-by-dominant-traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>For China site: PayByBandwidth, for International site: PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The name of the Internet Shared Bandwidth instance.</para>
        /// <para>The name must be 0 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The minimum bandwidth percentage of the Internet Shared Bandwidth instance. Set the value to <b>20</b>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;<ph>This parameter is required when <b>InternetChargeType</b> is set to <b>PayBy95</b>.</ph></para>
        /// <remarks>
        /// <para>This parameter is supported only on the Alibaba Cloud China site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// <para>The region ID of the Internet Shared Bandwidth instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>rg-acfmxazdjdhd****</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;<ph>You can configure this parameter when <b>InternetChargeType</b> is set to <b>PayBy95</b>.</ph></para>
        /// <para>You can add up to 10 security protection levels.</para>
        /// <remarks>
        /// <para><b>[Deprecated]</b> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AntiDDoS_Enhanced</para>
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// <para>The list of tags of the Internet Shared Bandwidth instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCommonBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateCommonBandwidthPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. If you specify this parameter, you cannot specify an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, you can specify an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone of the Internet Shared Bandwidth instance.
        /// This parameter is required when you create an Internet Shared Bandwidth instance for a CloudBox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1-lzdvn-cb</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
