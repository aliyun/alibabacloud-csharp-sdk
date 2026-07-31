// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of security events.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecEventsResponseBodyData> Data { get; set; }
        public class DescribeApisecEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AllCnt")]
            [Validation(Required=false)]
            public long? AllCnt { get; set; }

            /// <summary>
            /// <para>The API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/apisec/v1/register.php</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the API associated with the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2ecc1cf67b91853bc55545052ccf06a8</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The business purpose of the API.</para>
            /// <remarks>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to obtain the supported business purposes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SendMail</para>
            /// </summary>
            [NameInMap("ApiTag")]
            [Validation(Required=false)]
            public string ApiTag { get; set; }

            /// <summary>
            /// <para>The attack client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chrome</para>
            /// </summary>
            [NameInMap("AttackClient")]
            [Validation(Required=false)]
            public string AttackClient { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The attack count information, which is a string converted from a JSON object. The key is a timestamp in seconds, and the value is the number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;1717498320&quot;: 500,
            ///     &quot;1717498380&quot;: 529,
            ///     &quot;1717498440&quot;: 20
            /// }</para>
            /// </summary>
            [NameInMap("AttackCntInfo")]
            [Validation(Required=false)]
            [Obsolete]
            public string AttackCntInfo { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The attack IP address.</para>
            /// <remarks>
            /// <para>Notice: This parameter is deprecated. Use the AttackIps parameter instead.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>104.234.140.**</para>
            /// </summary>
            [NameInMap("AttackIp")]
            [Validation(Required=false)]
            [Obsolete]
            public string AttackIp { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The attack IP information, which is a string converted from a JSON object constructed with the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: the IP address.</description></item>
            /// <item><description><b>country_id</b>: the country to which the IP address belongs.</description></item>
            /// <item><description><b>region_id</b>: the region to which the IP address belongs.</description></item>
            /// <item><description><b>cnt</b>: the number of attacks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;ip&quot;: &quot;72.<em>.</em>.119&quot;,
            ///         &quot;country_id&quot;: &quot;US&quot;,
            ///         &quot;region_id&quot;: &quot;&quot;,
            ///         &quot;cnt&quot;: &quot;2100&quot;
            ///     }
            /// ]</para>
            /// </summary>
            [NameInMap("AttackIpInfo")]
            [Validation(Required=false)]
            [Obsolete]
            public string AttackIpInfo { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The list of attack IP addresses.</para>
            /// </summary>
            [NameInMap("AttackIps")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> AttackIps { get; set; }

            /// <summary>
            /// <para>The Attacker list associated with the event.</para>
            /// </summary>
            [NameInMap("AttackerList")]
            [Validation(Required=false)]
            public List<string> AttackerList { get; set; }

            /// <summary>
            /// <para>The end time of the query, in UNIX timestamp (UTC) format. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683703260</para>
            /// </summary>
            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public long? EndTs { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c82cb276847e9c96f9597d9f4b0cdcff</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The event details, which is a string converted from a JSON object constructed with the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><b>ip_info</b>: the attack IP information. Refer to the response parameter <b>AttackIpInfo</b> of this operation.</description></item>
            /// <item><description><b>rule_id</b>: the rule ID associated with the event.</description></item>
            /// <item><description><b>rule_tag</b>: the rule information associated with the event.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;ip_info&quot;: [
            ///         {
            ///             &quot;ip&quot;: &quot;112.224.143.<b>&quot;,
            ///             &quot;country_id&quot;: &quot;CN&quot;,
            ///             &quot;region_id&quot;: &quot;-&quot;,
            ///             &quot;cnt&quot;: &quot;4&quot;
            ///         }
            ///     ],
            ///     &quot;rule_id&quot;: &quot;837</b>&quot;,
            ///     &quot;rule_tag&quot;: &quot;interface returns a large amount of sensitive information&quot;
            /// }</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            [Obsolete]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>The event level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b>: High-risk.</description></item>
            /// <item><description><b>medium</b>: Medium-risk.</description></item>
            /// <item><description><b>low</b>: Low-risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// <remarks>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to obtain the supported event types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ObtainSensitiveUnauthorized</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

            /// <summary>
            /// <para>Indicates whether the event is followed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Followed.</description></item>
            /// <item><description><b>0</b>: Not followed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public int? Follow { get; set; }

            /// <summary>
            /// <para>The domain name or IP address to which the API operation belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.***.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Notify</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The source of the event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>custom</b>: Custom.</description></item>
            /// <item><description><b>default</b>: Built-in.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The country to which the attack IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("RemoteCountry")]
            [Validation(Required=false)]
            public string RemoteCountry { get; set; }

            /// <summary>
            /// <para>The region to which the attack IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110000</para>
            /// </summary>
            [NameInMap("RemoteRegion")]
            [Validation(Required=false)]
            public string RemoteRegion { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>A sample API request data, which is a string converted from a JSON object constructed with a series of parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("RequestData")]
            [Validation(Required=false)]
            [Obsolete]
            public string RequestData { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>A sample API response data, which is a string converted from a JSON object constructed with a series of parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResponseData { get; set; }

            /// <summary>
            /// <para>The start time of the query, in UNIX timestamp (UTC) format. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683648000</para>
            /// </summary>
            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public long? StartTs { get; set; }

            /// <summary>
            /// <para>The event status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>toBeConfirmed</b>: To be confirmed.</description></item>
            /// <item><description><b>confirmed</b>: Confirmed.</description></item>
            /// <item><description><b>actioned</b>: Handled.</description></item>
            /// <item><description><b>ignored</b>: Ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>toBeConfirmed</para>
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12F4CC8F-7E9F-5E4D-BF7C-BD1EDDE0C282</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
