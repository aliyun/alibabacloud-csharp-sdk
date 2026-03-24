// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecSuggestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of protection suggestions for the API asset.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecSuggestionsResponseBodyData> Data { get; set; }
        public class DescribeApisecSuggestionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The request path of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/apisec/v1/saveinfo</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The domain name or IP address associated with the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.aliyun.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The ID of the protection suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15060a1f8fed40130b7c4a7bf8d8733b</para>
            /// </summary>
            [NameInMap("SuggestId")]
            [Validation(Required=false)]
            public string SuggestId { get; set; }

            /// <summary>
            /// <para>The protection suggestion rule, in JSON format. The JSON string contains the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><para><b>event_tags</b>: the event type.</para>
            /// </description></item>
            /// <item><description><para><b>black_iplist</b>: the IP address blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>ip_baseline</b>: the IP address list.</para>
            /// </description></item>
            /// <item><description><para><b>freq_baseline</b>: the frequency limit information.</para>
            /// </description></item>
            /// <item><description><para><b>client_id_baseline</b>: the client information.</para>
            /// </description></item>
            /// <item><description><para><b>country_baseline</b>: the country information.</para>
            /// </description></item>
            /// <item><description><para><b>province_baseline</b>: the region information.</para>
            /// </description></item>
            /// <item><description><para><b>sensitive_type</b>: the sensitive information type.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;rule&quot;: &quot;ClientRule&quot;,
            ///     &quot;client_id_baseline&quot;: [&quot;Edge&quot;]
            /// }</para>
            /// </summary>
            [NameInMap("SuggestRule")]
            [Validation(Required=false)]
            public string SuggestRule { get; set; }

            /// <summary>
            /// <para>The type of the protection suggestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BotRule</b>: a bot rule.</para>
            /// </description></item>
            /// <item><description><para><b>BlackIPRule</b>: an IP address blacklist rule.</para>
            /// </description></item>
            /// <item><description><para><b>WhiteIPRule</b>: an IP address whitelist rule.</para>
            /// </description></item>
            /// <item><description><para><b>RateLimitRule</b>: a rate limiting rule.</para>
            /// </description></item>
            /// <item><description><para><b>ClientRule</b>: a client rule.</para>
            /// </description></item>
            /// <item><description><para><b>GeoRule</b>: a region rule.</para>
            /// </description></item>
            /// <item><description><para><b>SensitiveRule</b>: a sensitive information rule.</para>
            /// </description></item>
            /// <item><description><para><b>UnauthRule</b>: an authentication rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WhiteIPRule</para>
            /// </summary>
            [NameInMap("SuggestType")]
            [Validation(Required=false)]
            public string SuggestType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
