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
        /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Default value range: <b>1</b> to <b>1000</b>. Default value: <b>1</b>.</ph></para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>, which indicates that the billable method of the Internet Shared Bandwidth instance is pay-by-bandwidth, the default value range of <b>Bandwidth</b> is <b>2</b> to <b>20000</b>.</description></item>
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayBy95</b>, which indicates that the billable method of the Internet Shared Bandwidth instance is pay-by-enhanced-95th-percentile, the default value range of <b>Bandwidth</b> is <b>200</b> to <b>20000</b>.</description></item>
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByDominantTraffic</b>, which indicates that the billable method of the Internet Shared Bandwidth instance is pay-by-dominant-traffic, the default value range of <b>Bandwidth</b> is <b>1</b> to <b>2000</b>.</description></item>
        /// </list>
        /// <para> Default value: <b>1000</b>.
        /// .</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
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
        /// <para>The description must be 0 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description><b>BGP</b> (default): BGP (multi-ISP) lines. All regions support BGP (multi-ISP) lines.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (multi-ISP) premium lines. Currently, only the Hong Kong (China), Singapore, Japan (Tokyo), Philippines (Manila), Malaysia (Kuala Lumpur), Indonesia (Jakarta), and Thailand (Bangkok) regions support BGP (multi-ISP) premium Internet Shared Bandwidth instances.</description></item>
        /// </list>
        /// <para>If you are a single-ISP bandwidth whitelist user, you can also select the following types:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
        /// </list>
        /// <para>If you are a Finance Cloud user in the China (Hangzhou) region, this parameter is required. Set the value to <b>BGP_FinanceCloud</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The billable method of the Internet Shared Bandwidth instance. Valid values:
        /// &lt;props=&quot;intl&quot;&gt;<b>PayByTraffic</b> (pay-by-data-transfer).</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b> (default): pay-by-bandwidth.</description></item>
        /// <item><description><b>PayBy95</b>: pay-by-enhanced-95th-percentile.</description></item>
        /// <item><description><b>PayByDominantTraffic</b>: pay-by-dominant-traffic.
        /// .</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>中国站示例值：PayByBandwidth，国际站示例值：PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The name of the Internet Shared Bandwidth instance.</para>
        /// <para>The name must be 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The minimum bandwidth commitment percentage of the Internet Shared Bandwidth instance. Set the value to <b>20</b>.</para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>This parameter is required when <b>InternetChargeType</b> is set to <b>PayBy95</b>.</ph></para>
        /// <remarks>
        /// <para>This parameter is supported only on the China site.</para>
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
        /// <para>The resource group ID.</para>
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
        /// <item><description><para>If you do not set this parameter, Anti-DDoS Origin Basic is used by default.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to <b>AntiDDoS_Enhanced</b>, Anti-DDoS Origin Enhanced is used.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;<ph>You can set this parameter when <b>InternetChargeType</b> is set to <b>PayBy95</b>.</ph></para>
        /// <para>You can specify up to 10 security protection levels.</para>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AntiDDoS_Enhanced</para>
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// <para>The list of tags for the Internet Shared Bandwidth instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCommonBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateCommonBandwidthPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
