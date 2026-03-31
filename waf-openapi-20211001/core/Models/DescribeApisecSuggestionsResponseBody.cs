// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecSuggestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The protection suggestions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecSuggestionsResponseBodyData> Data { get; set; }
        public class DescribeApisecSuggestionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/apisec/v1/saveinfo</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

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
            /// <para>The rule ID of the protection suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15060a1f8fed40130b7c4a7bf8d8733b</para>
            /// </summary>
            [NameInMap("SuggestId")]
            [Validation(Required=false)]
            public string SuggestId { get; set; }

            /// <summary>
            /// <para>The rule content of the protection suggestion. The value is a string that consists of multiple parameters in the JSON format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>event_tags</b>: event type</description></item>
            /// <item><description><b>black_iplist</b>: IP address blacklist</description></item>
            /// <item><description><b>ip_baseline</b>: IP address</description></item>
            /// <item><description><b>freq_baseline</b>: throttling frequency</description></item>
            /// <item><description><b>client_id_baseline</b>: client information</description></item>
            /// <item><description><b>country_baseline</b>: country information</description></item>
            /// <item><description><b>province_baseline</b>: province information</description></item>
            /// <item><description><b>sensitive_type</b>: sensitive information</description></item>
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
            /// <para>The rule type of the protection suggestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BotRule</b>: bot management rules</description></item>
            /// <item><description><b>BlackIPRule</b>: IP address blacklist rules</description></item>
            /// <item><description><b>WhiteIPRule</b>: IP address whitelist rules</description></item>
            /// <item><description><b>RateLimitRule</b>: throttling rules</description></item>
            /// <item><description><b>ClientRule</b>: client rules</description></item>
            /// <item><description><b>GeoRule</b>: region-related rules</description></item>
            /// <item><description><b>SensitiveRule</b>: sensitive information rules</description></item>
            /// <item><description><b>UnauthRule</b>: authentication rules</description></item>
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
