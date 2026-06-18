// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListCacheRulesResponseBodyConfigs> Configs { get; set; }
        public class ListCacheRulesResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>Enables caching on the specified ports.</para>
            /// </description></item>
            /// <item><description><para>Valid values: <c>8880</c>, <c>2052</c>, <c>2082</c>, <c>2086</c>, <c>2095</c>, <c>2053</c>, <c>2083</c>, <c>2087</c>, and <c>2096</c>.</para>
            /// </description></item>
            /// <item><description><para>You can specify multiple ports, separated by commas (<c>,</c>).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8880,2052,2086</para>
            /// </summary>
            [NameInMap("AdditionalCacheablePorts")]
            [Validation(Required=false)]
            public string AdditionalCacheablePorts { get; set; }

            /// <summary>
            /// <para>The browser cache mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>no_cache</c>: Disables browser caching.</para>
            /// </description></item>
            /// <item><description><para><c>follow_origin</c>: Follows the origin server\&quot;s cache policy.</para>
            /// </description></item>
            /// <item><description><para><c>override_origin</c>: Overrides the origin server\&quot;s cache policy.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no_cache</para>
            /// </summary>
            [NameInMap("BrowserCacheMode")]
            [Validation(Required=false)]
            public string BrowserCacheMode { get; set; }

            /// <summary>
            /// <para>The browser cache TTL, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("BrowserCacheTtl")]
            [Validation(Required=false)]
            public string BrowserCacheTtl { get; set; }

            /// <summary>
            /// <para>Specifies the bypass cache mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cache_all</c>: Caches all requests.</para>
            /// </description></item>
            /// <item><description><para><c>bypass_all</c>: Bypasses all requests.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cache_all</para>
            /// </summary>
            [NameInMap("BypassCache")]
            [Validation(Required=false)]
            public string BypassCache { get; set; }

            /// <summary>
            /// <para>The cache deception protection. This feature defends against web cache deception attacks by caching only validated content. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CacheDeceptionArmor")]
            [Validation(Required=false)]
            public string CacheDeceptionArmor { get; set; }

            /// <summary>
            /// <para>The cache reserve eligibility. This setting controls whether a user request bypasses the cache reserve node when it is forwarded to the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>bypass_cache_reserve</c>: The request bypasses the cache reserve.</para>
            /// </description></item>
            /// <item><description><para><c>eligible_for_cache_reserve</c>: The request is eligible for the cache reserve.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bypass_cache_reserve</para>
            /// </summary>
            [NameInMap("CacheReserveEligibility")]
            [Validation(Required=false)]
            public string CacheReserveEligibility { get; set; }

            /// <summary>
            /// <para>Checks for the presence of specified cookies when generating the cache key. If a cookie exists, its name (case-insensitive) is included in the cache key. Separate multiple cookie names with spaces. Cookie names can contain the following characters:</para>
            /// <list type="bullet">
            /// <item><description><para>Symbols: <c>! # $ % &amp; \\&quot; * + - . ^ _ ` | ~</c></para>
            /// </description></item>
            /// <item><description><para>Digits: <c>0-9</c></para>
            /// </description></item>
            /// <item><description><para>Letters: lowercase English letters <c>a-z</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cookiename1 cookiename2</para>
            /// </summary>
            [NameInMap("CheckPresenceCookie")]
            [Validation(Required=false)]
            public string CheckPresenceCookie { get; set; }

            /// <summary>
            /// <para>Checks for the presence of specified headers when generating the cache key. If a header exists, its name (case-insensitive) is included in the cache key. Separate multiple header names with spaces. Header names can contain the following characters:</para>
            /// <list type="bullet">
            /// <item><description><para>Symbols: <c>! # $ % &amp; \\&quot; * + - . ^ _ ` | ~</c></para>
            /// </description></item>
            /// <item><description><para>Digits: <c>0-9</c></para>
            /// </description></item>
            /// <item><description><para>Letters: lowercase English letters <c>a-z</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>headername1 headername2</para>
            /// </summary>
            [NameInMap("CheckPresenceHeader")]
            [Validation(Required=false)]
            public string CheckPresenceHeader { get; set; }

            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>395386449776640</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>The configuration type, which indicates whether the configuration is global or rule-specific. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>global</c></para>
            /// </description></item>
            /// <item><description><para><c>rule</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The edge cache mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>follow_origin</c>: Follows the origin server\&quot;s cache policy. If no policy exists, the default policy is used.</para>
            /// </description></item>
            /// <item><description><para><c>no_cache</c>: Disables caching on edge nodes.</para>
            /// </description></item>
            /// <item><description><para><c>override_origin</c>: Overrides the origin server\&quot;s cache policy.</para>
            /// </description></item>
            /// <item><description><para><c>follow_origin_bypass</c>: Follows the origin server\&quot;s cache policy. If no policy exists, requests bypass the cache.</para>
            /// </description></item>
            /// <item><description><para><c>follow_origin_override</c>: Follows the cache policy of the origin server. If no policy exists, a custom cache TTL is used.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>follow_origin</para>
            /// </summary>
            [NameInMap("EdgeCacheMode")]
            [Validation(Required=false)]
            public string EdgeCacheMode { get; set; }

            /// <summary>
            /// <para>The edge cache TTL, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("EdgeCacheTtl")]
            [Validation(Required=false)]
            public string EdgeCacheTtl { get; set; }

            /// <summary>
            /// <para>The status code cache TTL, in seconds.</para>
            /// <list type="bullet">
            /// <item><description><para>You can set the cache TTL for a specific status code. For example, <c>404=10</c> caches responses with a 404 status code for 10 seconds.</para>
            /// </description></item>
            /// <item><description><para>You can set the cache TTL for a series of status codes, such as 4xx and 5xx. For example, <c>4xx=10</c> caches all responses with a 4xx status code for 10 seconds.</para>
            /// </description></item>
            /// <item><description><para>Separate multiple settings with commas (<c>,</c>).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5xx=0,404=10</para>
            /// </summary>
            [NameInMap("EdgeStatusCodeCacheTtl")]
            [Validation(Required=false)]
            public string EdgeStatusCodeCacheTtl { get; set; }

            /// <summary>
            /// <para>The cookie names whose values are included in the cache key. Names are case-insensitive. Separate multiple names with spaces. Cookie names can contain the following characters:</para>
            /// <list type="bullet">
            /// <item><description><para>Symbols: <c>! # $ % &amp; \\&quot; * + - . ^ _ ` | ~</c></para>
            /// </description></item>
            /// <item><description><para>Digits: <c>0-9</c></para>
            /// </description></item>
            /// <item><description><para>Letters: lowercase English letters <c>a-z</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cookiename1 cookiename2</para>
            /// </summary>
            [NameInMap("IncludeCookie")]
            [Validation(Required=false)]
            public string IncludeCookie { get; set; }

            /// <summary>
            /// <para>The header names whose values are included in the cache key. Names are case-insensitive. Separate multiple names with spaces. Header names can contain the following characters:</para>
            /// <list type="bullet">
            /// <item><description><para>Symbols: <c>! # $ % &amp; \\&quot; * + - . ^ _ ` | ~</c></para>
            /// </description></item>
            /// <item><description><para>Digits: <c>0-9</c></para>
            /// </description></item>
            /// <item><description><para>Letters: lowercase English letters <c>a-z</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>headername1 headername2</para>
            /// </summary>
            [NameInMap("IncludeHeader")]
            [Validation(Required=false)]
            public string IncludeHeader { get; set; }

            /// <summary>
            /// <para>The handling mode for the request body when generating the cache key for a POST request.</para>
            /// <list type="bullet">
            /// <item><description><para><c>md5</c>: Calculates the MD5 hash of the body content and includes the hash in the cache key.</para>
            /// </description></item>
            /// <item><description><para><c>ignore</c>: Ignores the body content in the cache key.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("PostBodyCacheKey")]
            [Validation(Required=false)]
            public string PostBodyCacheKey { get; set; }

            /// <summary>
            /// <para>The maximum size of a POST request body that can be cached, in KB. The value must be an integer from 1 to 8. The default is 8 KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostBodySizeLimit")]
            [Validation(Required=false)]
            public string PostBodySizeLimit { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable caching for POST requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PostCache")]
            [Validation(Required=false)]
            public string PostCache { get; set; }

            /// <summary>
            /// <para>The query strings to include in or exclude from the cache key. Separate multiple values with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("QueryString")]
            [Validation(Required=false)]
            public string QueryString { get; set; }

            /// <summary>
            /// <para>Specifies how to handle query strings when generating a cache key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ignore_all</c>: Ignores all query strings.</para>
            /// </description></item>
            /// <item><description><para><c>exclude_query_string</c>: Excludes specified query strings.</para>
            /// </description></item>
            /// <item><description><para><c>reserve_all</c>: Retains all query strings. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><c>include_query_string</c>: Includes specified query strings.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ignore_all</para>
            /// </summary>
            [NameInMap("QueryStringMode")]
            [Validation(Required=false)]
            public string QueryStringMode { get; set; }

            /// <summary>
            /// <para>The rule content, which uses a conditional expression to match user requests. This parameter is not required for a global configuration.</para>
            /// <list type="bullet">
            /// <item><description><para>To match all incoming requests, set this to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>To match specific requests, set this to a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The rule status. This parameter is not required for a global configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>The rule name. This parameter is not required for a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule execution sequence. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Specifies whether to serve stale content. If enabled, edge nodes serve expired cached files when the origin server is unavailable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ServeStale")]
            [Validation(Required=false)]
            public string ServeStale { get; set; }

            /// <summary>
            /// <para>The site version. If version management is enabled for the site, this specifies the version to which the configuration applies. The default is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable query string sorting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SortQueryStringForCache")]
            [Validation(Required=false)]
            public string SortQueryStringForCache { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the client device type in the cache key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("UserDeviceType")]
            [Validation(Required=false)]
            public string UserDeviceType { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the client\&quot;s geographical location in the cache key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("UserGeo")]
            [Validation(Required=false)]
            public string UserGeo { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the client language in the cache key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("UserLanguage")]
            [Validation(Required=false)]
            public string UserLanguage { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
