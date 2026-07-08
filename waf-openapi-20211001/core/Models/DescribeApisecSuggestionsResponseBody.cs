// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecSuggestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of protection suggestions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecSuggestionsResponseBodyData> Data { get; set; }
        public class DescribeApisecSuggestionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/apisec/v1/saveinfo</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

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
            /// <para>The ID of the protection suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15060a1f8fed40130b7c4a7bf8d8733b</para>
            /// </summary>
            [NameInMap("SuggestId")]
            [Validation(Required=false)]
            public string SuggestId { get; set; }

            /// <summary>
            /// <para>The content of the protection suggestion rule, which is a string converted from a JSON object constructed with a series of parameters. The parameters include:</para>
            /// <list type="bullet">
            /// <item><description><b>event_tags</b>: the event type.</description></item>
            /// <item><description><b>black_iplist</b>: the IP blacklist.</description></item>
            /// <item><description><b>ip_baseline</b>: the IP list.</description></item>
            /// <item><description><b>freq_baseline</b>: the throttling frequency information.</description></item>
            /// <item><description><b>client_id_baseline</b>: the client information.</description></item>
            /// <item><description><b>country_baseline</b>: the country information.</description></item>
            /// <item><description><b>province_baseline</b>: the region information.</description></item>
            /// <item><description><b>sensitive_type</b>: the sensitive information type.</description></item>
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
            /// <para>The type of the protection suggestion. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>BotRule</b>: bot rule.</description></item>
            /// <item><description><b>BlackIPRule</b>: IP blacklist rule.</description></item>
            /// <item><description><b>WhiteIPRule</b>: IP whitelist rule.</description></item>
            /// <item><description><b>RateLimitRule</b>: throttling rule.</description></item>
            /// <item><description><b>ClientRule</b>: client rule.</description></item>
            /// <item><description><b>GeoRule</b>: geo-blocking rule.</description></item>
            /// <item><description><b>SensitiveRule</b>: sensitive information rule.</description></item>
            /// <item><description><b>UnauthRule</b>: authentication rule.</description></item>
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
