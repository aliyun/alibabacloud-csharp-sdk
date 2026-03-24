// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecApiResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of API assets.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecApiResourcesResponseBodyData> Data { get; set; }
        public class DescribeApisecApiResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of threats associated with the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AbnormalNum")]
            [Validation(Required=false)]
            public long? AbnormalNum { get; set; }

            /// <summary>
            /// <para>The number of account security events associated with the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AccountEventNum")]
            [Validation(Required=false)]
            public long? AccountEventNum { get; set; }

            /// <summary>
            /// <para>The total number of requests in the last 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683388800</para>
            /// </summary>
            [NameInMap("AllCnt")]
            [Validation(Required=false)]
            public long? AllCnt { get; set; }

            /// <summary>
            /// <para>The API endpoint path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/etl/finddatabyvid</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>197b52abcd81d6a8bd4***e477</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The detailed information about the API. The value is a JSON string that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>param_num</b>: the number of API parameters.</para>
            /// </description></item>
            /// <item><description><para><b>request_method</b>: the request method.</para>
            /// </description></item>
            /// <item><description><para><b>protocol</b>: the request protocol.</para>
            /// </description></item>
            /// <item><description><para><b>api_url</b>: the request URL.</para>
            /// </description></item>
            /// <item><description><para><b>poc_payload</b>: the request.</para>
            /// </description></item>
            /// <item><description><para><b>request</b>: the request sample.</para>
            /// </description></item>
            /// <item><description><para><b>response</b>: the response sample.</para>
            /// </description></item>
            /// <item><description><para><b>param</b>: the request parameters.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only when you specify the <b>ApiId</b> request parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ApiInfo")]
            [Validation(Required=false)]
            public string ApiInfo { get; set; }

            /// <summary>
            /// <para>The HTTP request method of the API. Valid values: <b>GET</b>, <b>POST</b>, <b>HEAD</b>, <b>PUT</b>, <b>DELETE</b>, <b>CONNECT</b>, <b>PATCH</b>, and <b>OPTIONS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("ApiMethod")]
            [Validation(Required=false)]
            public string ApiMethod { get; set; }

            /// <summary>
            /// <para>The sensitive data classification of the API. The value is a JSON string that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>request_sensitive_list</b>: the list of sensitive data types in the request.</para>
            /// </description></item>
            /// <item><description><para><b>response_sensitive_list</b>: the list of sensitive data types in the response.</para>
            /// </description></item>
            /// <item><description><para><b>sensitive_list</b>: the list of sensitive data types.</para>
            /// </description></item>
            /// <item><description><para><b>sensitive_level</b>: the sensitivity level.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;sensitive_list&quot;: [&quot;1003&quot;,&quot;1005&quot;],
            ///     &quot;sensitive_level&quot;: &quot;L2&quot;,
            ///     &quot;request_sensitive_list&quot;: [&quot;1003&quot;],
            ///     &quot;response_sensitive_list&quot;: [&quot;1005&quot;]
            /// }</para>
            /// </summary>
            [NameInMap("ApiSensitive")]
            [Validation(Required=false)]
            public string ApiSensitive { get; set; }

            /// <summary>
            /// <para>The types of sensitive data detected in the API request. The value is a JSON array of sensitive data type IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1002&quot;,&quot;1005&quot;]</para>
            /// </summary>
            [NameInMap("ApiSensitiveRequest")]
            [Validation(Required=false)]
            public string ApiSensitiveRequest { get; set; }

            /// <summary>
            /// <para>The types of sensitive data detected in the API response. The value is a JSON array of sensitive data type IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1002&quot;,&quot;1005&quot;]</para>
            /// </summary>
            [NameInMap("ApiSensitiveResponse")]
            [Validation(Required=false)]
            public string ApiSensitiveResponse { get; set; }

            /// <summary>
            /// <para>The lifecycle status of the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NewbornInterface</b>: newly discovered.</para>
            /// </description></item>
            /// <item><description><para><b>OfflineInterface</b>: inactive.</para>
            /// </description></item>
            /// <item><description><para><b>normal</b>: active.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NewbornInterface</para>
            /// </summary>
            [NameInMap("ApiStatus")]
            [Validation(Required=false)]
            public string ApiStatus { get; set; }

            /// <summary>
            /// <para>The business purpose of the API.</para>
            /// <remarks>
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to obtain the supported business purposes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SendMail</para>
            /// </summary>
            [NameInMap("ApiTag")]
            [Validation(Required=false)]
            public string ApiTag { get; set; }

            /// <summary>
            /// <para>The type of service that the API serves. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PublicAPI</b>: public-facing service.</para>
            /// </description></item>
            /// <item><description><para><b>ThirdpartAPI</b>: third-party service.</para>
            /// </description></item>
            /// <item><description><para><b>InternalAPI</b>: internal service.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PublicAPI</para>
            /// </summary>
            [NameInMap("ApiType")]
            [Validation(Required=false)]
            public string ApiType { get; set; }

            /// <summary>
            /// <para>Indicates whether the API requires authentication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The API requires authentication.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The API does not require authentication.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthFlag")]
            [Validation(Required=false)]
            public string AuthFlag { get; set; }

            /// <summary>
            /// <para>The number of bot requests in the last 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BotCnt")]
            [Validation(Required=false)]
            public long? BotCnt { get; set; }

            /// <summary>
            /// <para>The number of cross-border requests in the last 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CrossBorderCnt")]
            [Validation(Required=false)]
            public long? CrossBorderCnt { get; set; }

            /// <summary>
            /// <para>The number of security events associated with the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EventNum")]
            [Validation(Required=false)]
            public long? EventNum { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The list of API samples.</para>
            /// </summary>
            [NameInMap("Examples")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> Examples { get; set; }

            /// <summary>
            /// <para>The time when the API was first discovered. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683388800</para>
            /// </summary>
            [NameInMap("FarthestTs")]
            [Validation(Required=false)]
            public long? FarthestTs { get; set; }

            /// <summary>
            /// <para>Indicates whether the API is followed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: The API is followed.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: The API is not followed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public int? Follow { get; set; }

            /// <summary>
            /// <para>The time of the most recent access to the API. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683388800</para>
            /// </summary>
            [NameInMap("LastestTs")]
            [Validation(Required=false)]
            public long? LastestTs { get; set; }

            /// <summary>
            /// <para>The domain name or IP address that the API resides on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.aliyun.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The remarks of the API asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>loginApi</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The list of protected objects associated with the API.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EFCFE18-78F8-5079-B312-07***48B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
