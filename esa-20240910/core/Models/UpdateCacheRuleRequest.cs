// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCacheRuleRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Enables caching on the specified ports.</para>
        /// </description></item>
        /// <item><description><para>Valid values: <c>8880</c>, <c>2052</c>, <c>2082</c>, <c>2086</c>, <c>2095</c>, <c>2053</c>, <c>2083</c>, <c>2087</c>, <c>2096</c></para>
        /// </description></item>
        /// <item><description><para>Separate multiple ports with commas.</para>
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
        /// <item><description><para><c>no_cache</c>: Does not cache content in the browser.</para>
        /// </description></item>
        /// <item><description><para><c>follow_origin</c>: Follows the caching policy of the origin server.</para>
        /// </description></item>
        /// <item><description><para><c>override_origin</c>: Overrides the caching policy of the origin server.</para>
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
        /// <para>The browser cache TTL (Time to Live), in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("BrowserCacheTtl")]
        [Validation(Required=false)]
        public string BrowserCacheTtl { get; set; }

        /// <summary>
        /// <para>The cache bypass mode. Valid values:</para>
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
        /// <para>Defends against Web Cache Deception attacks by caching only validated content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the feature.</para>
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
        /// <para>Controls whether requests bypass the cache reserve node during an origin-pull. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>bypass_cache_reserve</c>: The request bypasses the cache reserve.</para>
        /// </description></item>
        /// <item><description><para><c>eligible_for_cache_reserve</c>: The request is eligible for cache reserve.</para>
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
        /// <para>The cookies to check for. If a specified cookie is present in the request, its name (case-insensitive) is added to the cache key. Separate multiple cookies with spaces. Cookie names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Lowercase letters: a-z</para>
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
        /// <para>The headers to check for. If a specified header is present in the request, its name (case-insensitive) is added to the cache key. Separate multiple headers with spaces. Header names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Lowercase letters: a-z</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The cache mode for the edge node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>follow_origin</c>: Follows the origin server\&quot;s caching policy. If the origin server has no policy, the default policy is used.</para>
        /// </description></item>
        /// <item><description><para><c>no_cache</c>: Does not cache content.</para>
        /// </description></item>
        /// <item><description><para><c>override_origin</c>: Overrides the caching policy of the origin server.</para>
        /// </description></item>
        /// <item><description><para><c>follow_origin_bypass</c>: Follows the caching policy of the origin server, if one exists. Otherwise, content is not cached.</para>
        /// </description></item>
        /// <item><description><para><c>follow_origin_override</c>: Follows the caching policy of the origin server, if one exists. Otherwise, a custom cache TTL is used.</para>
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
        /// <para>The edge node cache TTL (Time to Live), in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("EdgeCacheTtl")]
        [Validation(Required=false)]
        public string EdgeCacheTtl { get; set; }

        /// <summary>
        /// <para>The cache TTL for specific status codes, in seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>You can set the cache TTL for a specific status code. For example, <c>404=10</c> caches responses with a 404 status code for 10 seconds.</para>
        /// </description></item>
        /// <item><description><para>You can set the cache TTL for <c>4xx</c> and <c>5xx</c> status code ranges. For example, <c>4xx=10</c> caches all responses with a <c>4xx</c> status code for 10 seconds.</para>
        /// </description></item>
        /// <item><description><para>Separate multiple status code settings with commas.</para>
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
        /// <para>The cookies to include in the cache key. Both the cookie names (case-insensitive) and their values are used. Separate multiple cookies with spaces. Cookie names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Lowercase letters: a-z</para>
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
        /// <para>The headers to include in the cache key. Both the header names (case-insensitive) and their values are used. Separate multiple headers with spaces. Header names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Lowercase letters: a-z</para>
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
        /// <para>Controls how the request body is used to generate the cache key for POST requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>md5</c>: Calculates the MD5 hash of the request body and includes the hash in the cache key.</para>
        /// </description></item>
        /// <item><description><para><c>ignore</c>: Ignores the request body when generating the cache key.</para>
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
        /// <para>The maximum size of a request body for POST caching, in KB. The value must be an integer from 1 to 8. If you leave this parameter empty, the default value of 8 KB is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostBodySizeLimit")]
        [Validation(Required=false)]
        public string PostBodySizeLimit { get; set; }

        /// <summary>
        /// <para>Controls whether to cache responses to POST requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PostCache")]
        [Validation(Required=false)]
        public string PostCache { get; set; }

        /// <summary>
        /// <para>The query string parameters to include in or exclude from the cache key. Separate multiple parameters with spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example1 example2</para>
        /// </summary>
        [NameInMap("QueryString")]
        [Validation(Required=false)]
        public string QueryString { get; set; }

        /// <summary>
        /// <para>Controls how query strings are used to generate a cache key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ignore_all</c>: Ignores all query strings.</para>
        /// </description></item>
        /// <item><description><para><c>exclude_query_string</c>: Removes specified query strings.</para>
        /// </description></item>
        /// <item><description><para><c>reserve_all</c>: Retains all query strings. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>include_query_string</c>: Retains only specified query strings.</para>
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
        /// <para>A conditional expression that matches user requests. This parameter is optional for a global configuration. Two scenarios are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression, for example, <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>Controls whether the rule is enabled. This parameter is optional for a global configuration. Valid values:</para>
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
        /// <para>The name of the rule. This parameter is optional for a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The execution priority of the rule. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>Controls whether to serve stale content. If enabled, an edge node can serve expired content from its cache if the origin server is unavailable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables this feature.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables this feature.</para>
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
        /// <para>The ID of the site. To get this ID, call the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Controls whether to sort query string parameters when generating a cache key. Valid values:</para>
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
        /// <para>Controls whether to include the client device type in the cache key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables this feature.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables this feature.</para>
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
        /// <para>Controls whether to include the client\&quot;s geographic location in the cache key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables this feature.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables this feature.</para>
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
        /// <para>Controls whether to include the client\&quot;s language in the cache key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables this feature.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables this feature.</para>
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
