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
            /// <para>The number of risks associated with the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AbnormalNum")]
            [Validation(Required=false)]
            public long? AbnormalNum { get; set; }

            /// <summary>
            /// <para>The number of account security events associated with the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AccountEventNum")]
            [Validation(Required=false)]
            public long? AccountEventNum { get; set; }

            /// <summary>
            /// <para>The total access volume in the last 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683388800</para>
            /// </summary>
            [NameInMap("AllCnt")]
            [Validation(Required=false)]
            public long? AllCnt { get; set; }

            /// <summary>
            /// <para>The API operation.</para>
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
            /// <para>The API information, which is a string converted from a JSON object constructed with a series of parameters. The parameters include:</para>
            /// <list type="bullet">
            /// <item><description><b>param_num</b>: the number of API parameters.</description></item>
            /// <item><description><b>request_method</b>: the request method.</description></item>
            /// <item><description><b>protocol</b>: the request protocol.</description></item>
            /// <item><description><b>api_url</b>: the request URL.</description></item>
            /// <item><description><b>poc_payload</b>: the request.</description></item>
            /// <item><description><b>request</b>: the request sample.</description></item>
            /// <item><description><b>response</b>: the response sample.</description></item>
            /// <item><description><b>param</b>: the request parameters.<remarks>
            /// <para>This field is returned only when the <b>ApiId</b> parameter is specified.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("ApiInfo")]
            [Validation(Required=false)]
            public string ApiInfo { get; set; }

            /// <summary>
            /// <para>The request method of the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GET</b>: GET request.</description></item>
            /// <item><description><b>POST</b>: POST request.</description></item>
            /// <item><description><b>HEAD</b>: HEAD request.</description></item>
            /// <item><description><b>PUT</b>: PUT request.</description></item>
            /// <item><description><b>DELETE</b>: DELETE request.</description></item>
            /// <item><description><b>CONNECT</b>: CONNECT request.</description></item>
            /// <item><description><b>PATCH</b>: PATCH request.</description></item>
            /// <item><description><b>OPTIONS</b>: OPTIONS request.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("ApiMethod")]
            [Validation(Required=false)]
            public string ApiMethod { get; set; }

            /// <summary>
            /// <para>The sensitive information involved in the API, which is a string converted from a JSON object constructed with a series of parameters. The parameters include:</para>
            /// <list type="bullet">
            /// <item><description><b>request_sensitive_list</b>: the list of sensitive data types in the request.</description></item>
            /// <item><description><b>response_sensitive_list</b>: the list of sensitive data types in the response.</description></item>
            /// <item><description><b>sensitive_list</b>: the list of sensitive data types.</description></item>
            /// <item><description><b>sensitive_level</b>: the sensitivity level.</description></item>
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
            /// <para>The sensitive data in the API request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1002&quot;,&quot;1005&quot;]</para>
            /// </summary>
            [NameInMap("ApiSensitiveRequest")]
            [Validation(Required=false)]
            public string ApiSensitiveRequest { get; set; }

            /// <summary>
            /// <para>The sensitive data in the API response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1002&quot;,&quot;1005&quot;]</para>
            /// </summary>
            [NameInMap("ApiSensitiveResponse")]
            [Validation(Required=false)]
            public string ApiSensitiveResponse { get; set; }

            /// <summary>
            /// <para>The status of the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NewbornInterface</b>: newly added.</description></item>
            /// <item><description><b>OfflineInterface</b>: inactive.</description></item>
            /// <item><description><b>normal</b>: normal.</description></item>
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
            /// <para>The service object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PublicAPI</b>: public service.</description></item>
            /// <item><description><b>ThirdpartAPI</b>: third-party collaboration.</description></item>
            /// <item><description><b>InternalAPI</b>: internal office.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PublicAPI</para>
            /// </summary>
            [NameInMap("ApiType")]
            [Validation(Required=false)]
            public string ApiType { get; set; }

            /// <summary>
            /// <para>Specifies whether the API has an authentication field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: has authentication.</description></item>
            /// <item><description><b>1</b>: does not have authentication.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthFlag")]
            [Validation(Required=false)]
            public string AuthFlag { get; set; }

            /// <summary>
            /// <para>The bot access volume in the last 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BotCnt")]
            [Validation(Required=false)]
            public long? BotCnt { get; set; }

            /// <summary>
            /// <para>The cross-border access volume in the last 30 days.</para>
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
            /// <para>The time when the API asset was first discovered, in UNIX timestamp (UTC) format. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683388800</para>
            /// </summary>
            [NameInMap("FarthestTs")]
            [Validation(Required=false)]
            public long? FarthestTs { get; set; }

            /// <summary>
            /// <para>Specifies whether the API is followed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: followed.</description></item>
            /// <item><description><b>0</b>: not followed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Follow")]
            [Validation(Required=false)]
            public int? Follow { get; set; }

            /// <summary>
            /// <para>The most recent access time of the API asset, in UNIX timestamp (UTC) format. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683388800</para>
            /// </summary>
            [NameInMap("LastestTs")]
            [Validation(Required=false)]
            public long? LastestTs { get; set; }

            /// <summary>
            /// <para>The domain name or IP address to which the API operation belongs.</para>
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
            /// <para>loginApi</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The list of protected objects corresponding to the asset.</para>
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
