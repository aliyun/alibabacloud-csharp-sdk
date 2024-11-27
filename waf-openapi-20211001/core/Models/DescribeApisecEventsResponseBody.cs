// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The security events.</para>
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
            /// <para>The API.</para>
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
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the business purpose of the API.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SendMail</para>
            /// </summary>
            [NameInMap("ApiTag")]
            [Validation(Required=false)]
            public string ApiTag { get; set; }

            /// <summary>
            /// <para>The client that is attacked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chrome</para>
            /// </summary>
            [NameInMap("AttackClient")]
            [Validation(Required=false)]
            public string AttackClient { get; set; }

            /// <summary>
            /// <para>The information about the number of attacks. The value of this parameter is a JSON string that contains multiple parameters. Key indicates the timestamp in seconds, and Value indicates the number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;1717498320\&quot;:500,\&quot;1717498380\&quot;:529,\&quot;1717498440\&quot;:20,\&quot;1717498260\&quot;:518,\&quot;1717498200\&quot;:481,\&quot;1717498140\&quot;:52}</para>
            /// </summary>
            [NameInMap("AttackCntInfo")]
            [Validation(Required=false)]
            public string AttackCntInfo { get; set; }

            /// <summary>
            /// <para>The source IP address of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>104.234.140.33</para>
            /// </summary>
            [NameInMap("AttackIp")]
            [Validation(Required=false)]
            public string AttackIp { get; set; }

            /// <summary>
            /// <para>The information about the attack source IP address. The value of this parameter is a JSON string that contains multiple parameters. The value includes the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: the IP address</description></item>
            /// <item><description><b>country_id</b>: the country ID</description></item>
            /// <item><description><b>region_id</b>: the region ID</description></item>
            /// <item><description><b>cnt</b>: the number of attacks</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;ip\&quot;:\&quot;72.<em>.</em>.119\&quot;,\&quot;country_id\&quot;:\&quot;US\&quot;,\&quot;region_id\&quot;:\&quot;\&quot;,\&quot;cnt\&quot;:\&quot;2100\&quot;}]</para>
            /// </summary>
            [NameInMap("AttackIpInfo")]
            [Validation(Required=false)]
            public string AttackIpInfo { get; set; }

            /// <summary>
            /// <para>The end of the time range to query. This value is a UNIX timestamp in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683703260</para>
            /// </summary>
            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public long? EndTs { get; set; }

            /// <summary>
            /// <para>The ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c82cb276847e9c96f9597d9f4b0cdcff</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The details of the event. The value of this parameter is a JSON string that contains multiple parameters. The value includes the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><b>ip_info</b>: the information about the attack source IP address. This parameter corresponds to the <b>AttackIpInfo</b> response parameter.</description></item>
            /// <item><description><b>rule_id</b>: the ID of the rule corresponding to the event.</description></item>
            /// <item><description><b>rule_tag</b>: the information about the rule corresponding to the event.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>The severity level of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>The type of the event.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported event types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ObtainSensitiveUnauthorized</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

            /// <summary>
            /// <para>Indicates whether the API is followed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The API is followed.</description></item>
            /// <item><description><b>0</b>: The API is not followed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public int? Follow { get; set; }

            /// <summary>
            /// <para>The domain name or IP address of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.aliyun.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Notified</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The source of the event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>custom</b></description></item>
            /// <item><description><b>default</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The country to which the attack source IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("RemoteCountry")]
            [Validation(Required=false)]
            public string RemoteCountry { get; set; }

            /// <summary>
            /// <para>The region to which the attack source IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110000</para>
            /// </summary>
            [NameInMap("RemoteRegion")]
            [Validation(Required=false)]
            public string RemoteRegion { get; set; }

            /// <summary>
            /// <para>The sample API request. The value of this parameter is a JSON string that contains multiple parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("RequestData")]
            [Validation(Required=false)]
            public string RequestData { get; set; }

            /// <summary>
            /// <para>The sample API response. The value of this parameter is a JSON string that contains multiple parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public string ResponseData { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query. This value is a UNIX timestamp in UTC. Unit: seconds.</para>
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
            /// <item><description><b>toBeConfirmed</b></description></item>
            /// <item><description><b>confirmed</b></description></item>
            /// <item><description><b>ignored</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ignore</para>
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
