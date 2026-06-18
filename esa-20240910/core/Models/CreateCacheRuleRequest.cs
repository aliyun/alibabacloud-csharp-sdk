// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateCacheRuleRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Specifies additional ports on which caching is enabled.</para>
        /// </description></item>
        /// <item><description><para>Valid values: 8880, 2052, 2082, 2086, 2095, 2053, 2083, 2087, and 2096.</para>
        /// </description></item>
        /// <item><description><para>You can specify multiple ports, separated by commas (,).</para>
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
        /// <item><description><para><c>follow_origin</c>: Follows the origin server cache policy.</para>
        /// </description></item>
        /// <item><description><para><c>override_origin</c>: Overrides the origin server cache policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>follow_origin</para>
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
        /// <para>The bypass cache mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cache_all</c>: Caches all requests.</para>
        /// </description></item>
        /// <item><description><para><c>bypass_all</c>: Bypasses the cache for all requests.</para>
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
        /// <para>Specifies whether to enable cache deception defense. This feature helps defend against web cache deception attacks. When this feature is enabled, only content that passes validation is cached. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the defense.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the defense.</para>
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
        /// <para>Specifies whether requests bypass cache reservation nodes during an origin fetch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>bypass_cache_reserve</c>: The request bypasses cache reservation.</para>
        /// </description></item>
        /// <item><description><para><c>eligible_for_cache_reserve</c>: The request is eligible for cache reservation.</para>
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
        /// <para>Specifies the cookies to check for presence when generating a cache key. If a specified cookie is present in the request, its name (case-insensitive) is included in the cache key. To specify multiple cookies, separate their names with spaces. The cookie names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Letters: a-z (lowercase)</para>
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
        /// <para>Specifies the headers to check for presence when generating a cache key. If a specified header is present in the request, its name (case-insensitive) is included in the cache key. To specify multiple headers, separate their names with spaces. The header names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Letters: a-z (lowercase)</para>
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
        /// <para>The edge cache mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>follow_origin</c>: Follows the origin server cache policy if one exists; otherwise, uses the default cache policy.</para>
        /// </description></item>
        /// <item><description><para><c>no_cache</c>: Disables caching on the edge node.</para>
        /// </description></item>
        /// <item><description><para><c>override_origin</c>: Overrides the origin server cache policy.</para>
        /// </description></item>
        /// <item><description><para><c>follow_origin_bypass</c>: Follows the origin server cache policy if one exists; otherwise, the content is not cached.</para>
        /// </description></item>
        /// <item><description><para><c>follow_origin_override</c>: Follows the origin server cache policy if one exists; otherwise, uses a custom edge cache TTL.</para>
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
        /// <item><description><para>You can set the cache TTL for a series of status codes, such as 4xx or 5xx. For example, <c>4xx=10</c> caches all responses that have a status code in the 4xx series for 10 seconds.</para>
        /// </description></item>
        /// <item><description><para>You can specify multiple status code TTLs, separated by commas (,).</para>
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
        /// <para>The cookies to include in the cache key. Both the cookie names (case-insensitive) and their values are included. Separate multiple cookie names with spaces. The cookie names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Letters: a-z (lowercase)</para>
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
        /// <para>The headers to include in the cache key. Both the header names (case-insensitive) and their values are included. Separate multiple header names with spaces. The header names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Letters: a-z (lowercase)</para>
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
        /// <para>Specifies how to process the request body when generating a cache key for POST requests. The following modes are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>md5</c>: Calculates the MD5 hash of the request body and adds the hash value to the cache key.</para>
        /// </description></item>
        /// <item><description><para><c>ignore</c>: Ignores the request body when the cache key is generated.</para>
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
        /// <para>The size limit for the request body when using POST request caching, in KB. Supported values range from 1 to 8. If unspecified, the default is 8 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostBodySizeLimit")]
        [Validation(Required=false)]
        public string PostBodySizeLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable POST request caching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PostCache")]
        [Validation(Required=false)]
        public string PostCache { get; set; }

        /// <summary>
        /// <para>The query strings to include in or exclude from the cache key. Separate multiple query strings with spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("QueryString")]
        [Validation(Required=false)]
        public string QueryString { get; set; }

        /// <summary>
        /// <para>The mode for processing query strings when generating a cache key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ignore_all</c>: Ignores all query strings.</para>
        /// </description></item>
        /// <item><description><para><c>exclude_query_string</c>: Excludes specified query strings.</para>
        /// </description></item>
        /// <item><description><para><c>reserve_all</c>: Includes all query strings (the default).</para>
        /// </description></item>
        /// <item><description><para><c>include_query_string</c>: Includes only specified query strings.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>reserve_all</para>
        /// </summary>
        [NameInMap("QueryStringMode")]
        [Validation(Required=false)]
        public string QueryStringMode { get; set; }

        /// <summary>
        /// <para>The content of the rule, which is a conditional expression used to match user requests. This parameter is not required for a global configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>To match all requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>Specifies whether to enable the rule. This parameter is not required for a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the rule.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the rule.</para>
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
        /// <para>The execution order of the rule. A smaller number indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>Specifies whether to serve stale content. If enabled, an edge node can serve stale (expired) content when the origin server is unavailable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables serving stale content.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables serving stale content.</para>
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
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to get this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340035003106221</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The site configuration version. For sites with version management enabled, this parameter specifies the site version to which the configuration applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort query strings. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables sorting.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables sorting.</para>
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
        /// <item><description><para><c>on</c>: Includes the client device type.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not include the client device type.</para>
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
        /// <para>Specifies whether to include the client\&quot;s geographic location in the cache key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Includes the geographic location.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not include the geographic location.</para>
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
        /// <para>Specifies whether to include the client\&quot;s language in the cache key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Includes the language.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not include the language.</para>
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

}
