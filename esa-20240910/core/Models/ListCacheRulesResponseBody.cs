// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response body configuration.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListCacheRulesResponseBodyConfigs> Configs { get; set; }
        public class ListCacheRulesResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>Enable caching on specified ports. Value range: 8880, 2052, 2082, 2086, 2095, 2053, 2083, 2087, 2096.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2082</para>
            /// </summary>
            [NameInMap("AdditionalCacheablePorts")]
            [Validation(Required=false)]
            public string AdditionalCacheablePorts { get; set; }

            /// <summary>
            /// <para>Browser cache mode. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>no_cache: Do not cache.</description></item>
            /// <item><description>follow_origin: Follow origin cache policy.</description></item>
            /// <item><description>override_origin: Override origin cache policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no_cache</para>
            /// </summary>
            [NameInMap("BrowserCacheMode")]
            [Validation(Required=false)]
            public string BrowserCacheMode { get; set; }

            /// <summary>
            /// <para>Browser cache expiration time, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("BrowserCacheTtl")]
            [Validation(Required=false)]
            public string BrowserCacheTtl { get; set; }

            /// <summary>
            /// <para>Set bypass cache mode. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>cache_all: Cache all requests.</description></item>
            /// <item><description>bypass_all: Bypass cache for all requests.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cache_all</para>
            /// </summary>
            [NameInMap("BypassCache")]
            [Validation(Required=false)]
            public string BypassCache { get; set; }

            /// <summary>
            /// <para>Cache deception defense. Used to defend against web cache deception attacks; only verified cache content will be cached. Value range:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CacheDeceptionArmor")]
            [Validation(Required=false)]
            public string CacheDeceptionArmor { get; set; }

            /// <summary>
            /// <para>Cache reserve eligibility. This is used to control whether user requests bypass the cache reserve node when returning to the origin. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>bypass_cache_reserve: Requests bypass the cache reserve.</description></item>
            /// <item><description>eligible_for_cache_reserve: Eligible for cache reserve.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bypass_cache_reserve</para>
            /// </summary>
            [NameInMap("CacheReserveEligibility")]
            [Validation(Required=false)]
            public string CacheReserveEligibility { get; set; }

            /// <summary>
            /// <para>When generating the cache key, check if the cookie exists. If it does, add the cookie name (case-insensitive) to the cache key. Multiple cookie names are supported, separated by spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cookiename</para>
            /// </summary>
            [NameInMap("CheckPresenceCookie")]
            [Validation(Required=false)]
            public string CheckPresenceCookie { get; set; }

            /// <summary>
            /// <para>When generating the cache key, check if the header exists. If it does, add the header name (case-insensitive) to the cache key. Multiple header names are supported, separated by spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headername</para>
            /// </summary>
            [NameInMap("CheckPresenceHeader")]
            [Validation(Required=false)]
            public string CheckPresenceHeader { get; set; }

            /// <summary>
            /// <para>Configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>395386449776640</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>Configuration type, which can be used to query global or rule-based configurations. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>global: Query global configuration.</description></item>
            /// <item><description>rule: Query rule-based configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>Edge cache mode. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>follow_origin: Follow the origin server\&quot;s cache policy (if it exists), otherwise use the default cache policy.</description></item>
            /// <item><description>no_cache: Do not cache.</description></item>
            /// <item><description>override_origin: Override the origin server\&quot;s cache policy.</description></item>
            /// <item><description>follow_origin_bypass: Follow the origin server\&quot;s cache policy (if it exists), otherwise do not cache.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>follow_origin</para>
            /// </summary>
            [NameInMap("EdgeCacheMode")]
            [Validation(Required=false)]
            public string EdgeCacheMode { get; set; }

            /// <summary>
            /// <para>Edge cache expiration time, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("EdgeCacheTtl")]
            [Validation(Required=false)]
            public string EdgeCacheTtl { get; set; }

            /// <summary>
            /// <para>Edge cache expiration time, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("EdgeStatusCodeCacheTtl")]
            [Validation(Required=false)]
            public string EdgeStatusCodeCacheTtl { get; set; }

            /// <summary>
            /// <para>Include the specified cookie names and their values when generating the cache key. Multiple values are supported, separated by spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cookie_exapmle</para>
            /// </summary>
            [NameInMap("IncludeCookie")]
            [Validation(Required=false)]
            public string IncludeCookie { get; set; }

            /// <summary>
            /// <para>Include the specified header names and their values when generating the cache key. Multiple values are supported, separated by spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("IncludeHeader")]
            [Validation(Required=false)]
            public string IncludeHeader { get; set; }

            /// <summary>
            /// <para>The query strings to be reserved or excluded. Multiple values are supported, separated by spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("QueryString")]
            [Validation(Required=false)]
            public string QueryString { get; set; }

            /// <summary>
            /// <para>The processing mode for query strings when generating the cache key. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>ignore_all: Ignore all query strings.</description></item>
            /// <item><description>exclude_query_string: Exclude specified query strings.</description></item>
            /// <item><description>reserve_all: Default, reserve all query strings.</description></item>
            /// <item><description>include_query_string: Include specified query strings.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ignore_all</para>
            /// </summary>
            [NameInMap("QueryStringMode")]
            [Validation(Required=false)]
            public string QueryStringMode { get; set; }

            /// <summary>
            /// <para>Rule content, using conditional expressions to match user requests. This parameter is not required when adding a global configuration. There are two usage scenarios:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: Set the value to true</description></item>
            /// <item><description>Match specific requests: Set the value to a custom expression, e.g., (http.host eq \&quot;video.example.com\&quot;)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Rule switch. This parameter is not required when adding a global configuration. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>Rule name. This parameter is not required when adding a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Rule execution order. The smaller the value, the higher the priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Serve stale cache. When enabled, the node can still respond to user requests with expired cached files even when the origin server is unavailable. Value range:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ServeStale")]
            [Validation(Required=false)]
            public string ServeStale { get; set; }

            /// <summary>
            /// <para>Site configuration version number. For sites with version management enabled, this parameter can specify the site version for which the configuration takes effect, defaulting to version 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <para>Query string sorting. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SortQueryStringForCache")]
            [Validation(Required=false)]
            public string SortQueryStringForCache { get; set; }

            /// <summary>
            /// <para>Include the client device type when generating the cache key. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("UserDeviceType")]
            [Validation(Required=false)]
            public string UserDeviceType { get; set; }

            /// <summary>
            /// <para>Include the client\&quot;s geographic location when generating the cache key. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("UserGeo")]
            [Validation(Required=false)]
            public string UserGeo { get; set; }

            /// <summary>
            /// <para>Include the client\&quot;s language type when generating the cache key. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
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
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
