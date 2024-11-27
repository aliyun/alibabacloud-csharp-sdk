// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecApiResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The API assets.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecApiResourcesResponseBodyData> Data { get; set; }
        public class DescribeApisecApiResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of API-related risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AbnormalNum")]
            [Validation(Required=false)]
            public long? AbnormalNum { get; set; }

            /// <summary>
            /// <para>The total number of calls to this API in the previous 30 days.</para>
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
            /// <para>/v1/etl/finddatabyvid</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>867ade***24ee6e205b8da82b8f84</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The API-related information. The value of this parameter is a JSON string that contains multiple parameters. The value includes the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><b>param_num</b>: the number of API parameters</description></item>
            /// <item><description><b>request_method</b>: the request method</description></item>
            /// <item><description><b>protocol</b>: the request protocol</description></item>
            /// <item><description><b>api_url</b>: the request URL</description></item>
            /// <item><description><b>poc_payload</b>: the request</description></item>
            /// <item><description><b>request</b>: the sample request</description></item>
            /// <item><description><b>response</b>: the sample response</description></item>
            /// <item><description><b>param</b>: the request parameters</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ApiInfo")]
            [Validation(Required=false)]
            public string ApiInfo { get; set; }

            /// <summary>
            /// <para>The request method of the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GET</b></description></item>
            /// <item><description><b>POST</b></description></item>
            /// <item><description><b>HEAD</b></description></item>
            /// <item><description><b>PUT</b></description></item>
            /// <item><description><b>DELETE</b></description></item>
            /// <item><description><b>CONNECT</b></description></item>
            /// <item><description><b>PATCH</b></description></item>
            /// <item><description><b>OPTIONS</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("ApiMethod")]
            [Validation(Required=false)]
            public string ApiMethod { get; set; }

            /// <summary>
            /// <para>The API-related sensitive information. The value of this parameter is a JSON string that contains multiple parameters. The value includes the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><b>request_sensitive_list</b>: the sensitive data type in the request</description></item>
            /// <item><description><b>response_sensitive_list</b>: the sensitive data type in the response</description></item>
            /// <item><description><b>sensitive_list</b>: sensitive data types</description></item>
            /// <item><description><b>sensitive_level</b>: sensitivity level</description></item>
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
            /// <para>The sensitive data type in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1002&quot;,&quot;1005&quot;]</para>
            /// </summary>
            [NameInMap("ApiSensitiveRequest")]
            [Validation(Required=false)]
            public string ApiSensitiveRequest { get; set; }

            /// <summary>
            /// <para>The sensitive data type in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1002&quot;,&quot;1005&quot;]</para>
            /// </summary>
            [NameInMap("ApiSensitiveResponse")]
            [Validation(Required=false)]
            public string ApiSensitiveResponse { get; set; }

            /// <summary>
            /// <para>The API status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NewbornInterface</b>: The API is newly added.</description></item>
            /// <item><description><b>OfflineInterface</b>: The API is inactive.</description></item>
            /// <item><description><b>normal</b>: The API is normal.</description></item>
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
            /// <para>The service object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PublicAPI</b>: public services</description></item>
            /// <item><description><b>ThirdpartAPI</b>: cooperation with third-party partners</description></item>
            /// <item><description><b>InternalAPI</b>: internal office</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PublicAPI</para>
            /// </summary>
            [NameInMap("ApiType")]
            [Validation(Required=false)]
            public string ApiType { get; set; }

            /// <summary>
            /// <para>Indicates whether authentication is required. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Authentication is required.</description></item>
            /// <item><description><b>1</b>: Authentication is not required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthFlag")]
            [Validation(Required=false)]
            public string AuthFlag { get; set; }

            /// <summary>
            /// <para>The number of bot-initiated requests in the previous 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BotCnt")]
            [Validation(Required=false)]
            public long? BotCnt { get; set; }

            /// <summary>
            /// <para>The number of the cross-border requests in the previous 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CrossBorderCnt")]
            [Validation(Required=false)]
            public long? CrossBorderCnt { get; set; }

            /// <summary>
            /// <para>The number of API-related security events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EventNum")]
            [Validation(Required=false)]
            public long? EventNum { get; set; }

            /// <summary>
            /// <para>The sample APIs.</para>
            /// </summary>
            [NameInMap("Examples")]
            [Validation(Required=false)]
            public List<string> Examples { get; set; }

            /// <summary>
            /// <para>The time when the API asset was first detected. This value is a UNIX timestamp in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683388800</para>
            /// </summary>
            [NameInMap("FarthestTs")]
            [Validation(Required=false)]
            public long? FarthestTs { get; set; }

            /// <summary>
            /// <para>Specifies whether to follow the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: follows the API.</description></item>
            /// <item><description><b>0</b>: does not follow the API.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public int? Follow { get; set; }

            /// <summary>
            /// <para>The most recent access time of the API. This value is a UNIX timestamp in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683388800</para>
            /// </summary>
            [NameInMap("LastestTs")]
            [Validation(Required=false)]
            public long? LastestTs { get; set; }

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
            /// <para>Password changed</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
