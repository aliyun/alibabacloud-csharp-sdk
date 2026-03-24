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
            /// <para>The total number of attacks in the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AllCnt")]
            [Validation(Required=false)]
            public long? AllCnt { get; set; }

            /// <summary>
            /// <para>The path of the API that is associated with the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/apisec/v1/register.php</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the API that is associated with the security event.</para>
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
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported business purposes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SendMail</para>
            /// </summary>
            [NameInMap("ApiTag")]
            [Validation(Required=false)]
            public string ApiTag { get; set; }

            /// <summary>
            /// <para>The type of client that initiated the attack, such as a browser or automation tool.</para>
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
            /// <para>The attack count over time. The value is a JSON string in which each key is a UNIX timestamp in seconds and each value is the number of attacks at that time.</para>
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
            /// <para>The IP address of the attacker. &gt;Notice: This parameter is deprecated. Use the AttackIps parameter instead.</para>
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
            /// <para>The information about the attacker IP address. The value is a JSON string that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: the IP address.</para>
            /// </description></item>
            /// <item><description><para><b>country_id</b>: the country.</para>
            /// </description></item>
            /// <item><description><para><b>region_id</b>: the region.</para>
            /// </description></item>
            /// <item><description><para><b>cnt</b>: the number of attacks.</para>
            /// </description></item>
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
            /// <para>The list of attacker IP addresses.</para>
            /// </summary>
            [NameInMap("AttackIps")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> AttackIps { get; set; }

            /// <summary>
            /// <para>The list of attackers that are associated with the security event.</para>
            /// </summary>
            [NameInMap("AttackerList")]
            [Validation(Required=false)]
            public List<string> AttackerList { get; set; }

            /// <summary>
            /// <para>The end time of the event. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683703260</para>
            /// </summary>
            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public long? EndTs { get; set; }

            /// <summary>
            /// <para>The ID of the security event.</para>
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
            /// <para>The details of the security event. The value is a JSON string that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip_info</b>: the information about the attacker IP address. For more information, see the <b>AttackIpInfo</b> response parameter.</para>
            /// </description></item>
            /// <item><description><para><b>rule_id</b>: the ID of the rule that corresponds to the event.</para>
            /// </description></item>
            /// <item><description><para><b>rule_tag</b>: the information about the rule that corresponds to the event.</para>
            /// </description></item>
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
            /// <para>The severity level of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>high</b>: high severity.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: medium severity.</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: low severity.</para>
            /// </description></item>
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
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported event types.</para>
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
            /// <item><description><para><b>1</b>: The event is followed.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: The event is not followed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public int? Follow { get; set; }

            /// <summary>
            /// <para>The domain name or IP address that is protected by WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.***.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The remarks that are added to the security event.</para>
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
            /// <item><description><para><b>custom</b>: a user-defined event type.</para>
            /// </description></item>
            /// <item><description><para><b>default</b>: a built-in event type.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The country where the attacker IP address is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("RemoteCountry")]
            [Validation(Required=false)]
            public string RemoteCountry { get; set; }

            /// <summary>
            /// <para>The region where the attacker IP address is located.</para>
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
            /// <para>A sample of the API request data. The value is a JSON string.</para>
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
            /// <para>A sample of the API response data. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResponseData { get; set; }

            /// <summary>
            /// <para>The start time of the event. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683648000</para>
            /// </summary>
            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public long? StartTs { get; set; }

            /// <summary>
            /// <para>The handling status of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>toBeConfirmed</b>: pending confirmation.</para>
            /// </description></item>
            /// <item><description><para><b>confirmed</b>: confirmed but not yet handled.</para>
            /// </description></item>
            /// <item><description><para><b>actioned</b>: handled.</para>
            /// </description></item>
            /// <item><description><para><b>ignored</b>: ignored.</para>
            /// </description></item>
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
