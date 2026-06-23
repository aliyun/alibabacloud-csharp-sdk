// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration list in the response body.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListCacheRulesResponseBodyConfigs> Configs { get; set; }
        public class ListCacheRulesResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description>Enables caching on specified ports.</description></item>
            /// <item><description>Valid values: 8880, 2052, 2082, 2086, 2095, 2053, 2083, 2087, and 2096.</description></item>
            /// <item><description>Multiple ports are separated by commas (,).</description></item>
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
            /// <item><description>no_cache: does not cache.</description></item>
            /// <item><description>follow_origin: follows the origin cache policy.</description></item>
            /// <item><description>override_origin: overrides the origin cache policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no_cache</para>
            /// </summary>
            [NameInMap("BrowserCacheMode")]
            [Validation(Required=false)]
            public string BrowserCacheMode { get; set; }

            /// <summary>
            /// <para>The browser cache expiration time, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("BrowserCacheTtl")]
            [Validation(Required=false)]
            public string BrowserCacheTtl { get; set; }

            /// <summary>
            /// <para>The bypass cache mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cache_all: caches all requests.</description></item>
            /// <item><description>bypass_all: bypasses cache for all requests.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cache_all</para>
            /// </summary>
            [NameInMap("BypassCache")]
            [Validation(Required=false)]
            public string BypassCache { get; set; }

            /// <summary>
            /// <para>The cache deception armor. Protects against web cache deception attacks by caching only content that passes validation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CacheDeceptionArmor")]
            [Validation(Required=false)]
            public string CacheDeceptionArmor { get; set; }

            /// <summary>
            /// <para>The cache reserve eligibility. Controls whether user requests bypass the cache reserve node during back-to-origin. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>bypass_cache_reserve: requests bypass cache reserve.</description></item>
            /// <item><description>eligible_for_cache_reserve: requests are eligible for cache reserve.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bypass_cache_reserve</para>
            /// </summary>
            [NameInMap("CacheReserveEligibility")]
            [Validation(Required=false)]
            public string CacheReserveEligibility { get; set; }

            /// <summary>
            /// <para>When generating cache keys, checks whether the specified cookies exist. If a cookie exists, its name (case-insensitive) is added to the cache key. Multiple cookie names are separated by spaces. Cookie names support the following character types:</para>
            /// <list type="bullet">
            /// <item><description>Symbols: ! # $ % &amp; \&quot; * + - . ^ _ ` | ~</description></item>
            /// <item><description>Digits: 0-9</description></item>
            /// <item><description>Letters: lowercase a-z.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cookiename1 cookiename2</para>
            /// </summary>
            [NameInMap("CheckPresenceCookie")]
            [Validation(Required=false)]
            public string CheckPresenceCookie { get; set; }

            /// <summary>
            /// <para>When generating cache keys, checks whether the specified headers exist. If a header exists, its name (case-insensitive) is added to the cache key. Multiple header names are separated by spaces. Header names support the following character types:</para>
            /// <list type="bullet">
            /// <item><description>Symbols: ! # $ % &amp; \&quot; * + - . ^ _ ` | ~</description></item>
            /// <item><description>Digits: 0-9</description></item>
            /// <item><description>Letters: lowercase a-z.</description></item>
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
            /// <para>The configuration type. You can use this parameter to query global or rule configurations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>global: global configuration.</description></item>
            /// <item><description>rule: rule configuration.</description></item>
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
            /// <item><description>follow_origin: follows the origin cache policy if present. Otherwise, uses the default cache policy.</description></item>
            /// <item><description>no_cache: does not cache.</description></item>
            /// <item><description>override_origin: overrides the origin cache policy.</description></item>
            /// <item><description>follow_origin_bypass: follows the origin cache policy if present. Otherwise, does not cache.</description></item>
            /// <item><description>follow_origin_override: follows the origin cache policy if present. Otherwise, uses a custom cache TTL.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>follow_origin</para>
            /// </summary>
            [NameInMap("EdgeCacheMode")]
            [Validation(Required=false)]
            public string EdgeCacheMode { get; set; }

            /// <summary>
            /// <para>The edge cache expiration time, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("EdgeCacheTtl")]
            [Validation(Required=false)]
            public string EdgeCacheTtl { get; set; }

            /// <summary>
            /// <para>The status code cache expiration time, in seconds.</para>
            /// <list type="bullet">
            /// <item><description>You can set the cache expiration time for specific status codes. For example, 404=10 indicates that the 404 status code is cached for 10 seconds.</description></item>
            /// <item><description>You can set the cache expiration time for 4xx or 5xx series status codes. For example, 4xx=10 indicates that all 4xx status codes are cached for 10 seconds.</description></item>
            /// <item><description>You can set the cache expiration time for multiple status codes. Separate multiple status codes with commas (,).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5xx=0,404=10</para>
            /// </summary>
            [NameInMap("EdgeStatusCodeCacheTtl")]
            [Validation(Required=false)]
            public string EdgeStatusCodeCacheTtl { get; set; }

            /// <summary>
            /// <para>The specified cookie names (case-insensitive) and their values to include when generating cache keys. Multiple values are separated by spaces. Cookie names support the following character types:</para>
            /// <list type="bullet">
            /// <item><description>Symbols: ! # $ % &amp; \&quot; * + - . ^ _ ` | ~</description></item>
            /// <item><description>Digits: 0-9</description></item>
            /// <item><description>Letters: lowercase a-z.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cookiename1 cookiename2</para>
            /// </summary>
            [NameInMap("IncludeCookie")]
            [Validation(Required=false)]
            public string IncludeCookie { get; set; }

            /// <summary>
            /// <para>The specified header names (case-insensitive) and their values to include when generating cache keys. Multiple values are separated by spaces. Header names support the following character types:</para>
            /// <list type="bullet">
            /// <item><description>Symbols: ! # $ % &amp; \&quot; * + - . ^ _ ` | ~</description></item>
            /// <item><description>Digits: 0-9</description></item>
            /// <item><description>Letters: lowercase a-z.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>headername1 headername2</para>
            /// </summary>
            [NameInMap("IncludeHeader")]
            [Validation(Required=false)]
            public string IncludeHeader { get; set; }

            /// <summary>
            /// <para>The cache key handling mode for POST caching. The following two modes are supported:</para>
            /// <list type="bullet">
            /// <item><description>md5: calculates the MD5 hash of the body content and adds the MD5 value to the cache key.</description></item>
            /// <item><description>ignore: ignores the body content in the cache key.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("PostBodyCacheKey")]
            [Validation(Required=false)]
            public string PostBodyCacheKey { get; set; }

            /// <summary>
            /// <para>The body size limit for POST caching. The value is a number in KB. Valid values: 1 to 8. If this parameter is left empty, the default value of 8 KB takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostBodySizeLimit")]
            [Validation(Required=false)]
            public string PostBodySizeLimit { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable POST caching.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PostCache")]
            [Validation(Required=false)]
            public string PostCache { get; set; }

            /// <summary>
            /// <para>The query strings to retain or remove when generating cache keys. Multiple values are separated by spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("QueryString")]
            [Validation(Required=false)]
            public string QueryString { get; set; }

            /// <summary>
            /// <para>The query string handling mode when generating cache keys. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ignore_all: ignores all query strings.</description></item>
            /// <item><description>exclude_query_string: removes specified query strings.</description></item>
            /// <item><description>reserve_all: retains all query strings. This is the default value.</description></item>
            /// <item><description>include_query_string: retains specified query strings.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ignore_all</para>
            /// </summary>
            [NameInMap("QueryStringMode")]
            [Validation(Required=false)]
            public string QueryStringMode { get; set; }

            /// <summary>
            /// <para>The rule content, which uses conditional expressions to match user requests. You do not need to set this parameter when you add a global configuration. Two scenarios are supported:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: set the value to true.</description></item>
            /// <item><description>Match specified requests: set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The rule switch. You do not need to set this parameter when you add a global configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>The rule name. You do not need to set this parameter when you add a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule execution order. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Specifies whether to serve stale cache. When enabled, edge nodes can respond to user requests with cached expired files when the origin server is unavailable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ServeStale")]
            [Validation(Required=false)]
            public string ServeStale { get; set; }

            /// <summary>
            /// <para>The version number of the site configuration. For sites with configuration version management enabled, you can use this parameter to specify the site version for which the configuration takes effect. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to sort query strings. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SortQueryStringForCache")]
            [Validation(Required=false)]
            public string SortQueryStringForCache { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the type of the client when generating cache keys. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("UserDeviceType")]
            [Validation(Required=false)]
            public string UserDeviceType { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the client geographic location when generating cache keys. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("UserGeo")]
            [Validation(Required=false)]
            public string UserGeo { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the client language type when generating cache keys. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
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
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The total number of records.</para>
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
