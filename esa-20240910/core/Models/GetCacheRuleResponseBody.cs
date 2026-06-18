// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCacheRuleResponseBody : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Additional ports on which caching is enabled.</para>
        /// </description></item>
        /// <item><description><para>Valid values: <c>8880</c>, <c>2052</c>, <c>2082</c>, <c>2086</c>, <c>2095</c>, <c>2053</c>, <c>2083</c>, <c>2087</c>, <c>2096</c>.</para>
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
        /// <item><description><para><c>no_cache</c>: Does not cache content.</para>
        /// </description></item>
        /// <item><description><para><c>follow_origin</c>: Follows the origin cache policy.</para>
        /// </description></item>
        /// <item><description><para><c>override_origin</c>: Overrides the origin cache policy.</para>
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
        /// <para>Specifies whether to cache requests or bypass the cache. Valid values:</para>
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
        /// <para>Specifies whether to enable Cache Deception Armor. This feature helps mitigate web cache deception attacks by ensuring that only validated content is cached. Valid values:</para>
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
        /// <para>The eligibility for cache reserve. This controls whether a request bypasses the cache reserve node during an origin fetch. Valid values:</para>
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
        /// <para>Specifies cookies whose presence is checked when generating a cache key. If a specified cookie exists in the request, its name (case-insensitive) is added to the cache key. Separate multiple cookie names with spaces. Cookie names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Letters: lowercase English letters a-z</para>
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
        /// <para>Specifies headers whose presence is checked when generating a cache key. If a specified header exists in the request, its name (case-insensitive) is added to the cache key. Separate multiple header names with spaces. Header names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Letters: lowercase English letters a-z</para>
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
        /// <para>352816096987136</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Indicates whether the response contains a global or a rule configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>global</c>: A global configuration.</para>
        /// </description></item>
        /// <item><description><para><c>rule</c>: A rule configuration.</para>
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
        /// <item><description><para><c>follow_origin</c>: Uses the origin server\&quot;s cache policy. If none is provided, the default policy applies.</para>
        /// </description></item>
        /// <item><description><para><c>no_cache</c>: Does not cache content.</para>
        /// </description></item>
        /// <item><description><para><c>override_origin</c>: Overrides the origin cache policy.</para>
        /// </description></item>
        /// <item><description><para><c>follow_origin_bypass</c>: Uses the origin server\&quot;s cache policy. If none is provided, content is not cached.</para>
        /// </description></item>
        /// <item><description><para><c>follow_origin_override</c>: Uses the origin server\&quot;s cache policy. If none is provided, a custom cache TTL applies.</para>
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
        /// <item><description><para>Set the cache TTL for a specific status code. For example, <c>404=10</c> specifies that responses with a 404 status code are cached for 10 seconds.</para>
        /// </description></item>
        /// <item><description><para>Set the cache TTL for status code classes, such as 4xx and 5xx. For example, <c>4xx=10</c> specifies that all responses with a 4xx status code are cached for 10 seconds.</para>
        /// </description></item>
        /// <item><description><para>Separate multiple entries with commas.</para>
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
        /// <para>Specifies the cookies to include in the cache key. Both the cookie names (case-insensitive) and their values are added to the key. Separate multiple cookie names with spaces. Cookie names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Letters: lowercase English letters a-z</para>
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
        /// <para>Specifies the headers to include in the cache key. Both the header names (case-insensitive) and their values are added to the key. Separate multiple header names with spaces. Header names can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description><para>Symbols: ! # $ % &amp; \&quot; \* + - . ^ _ | \~</para>
        /// </description></item>
        /// <item><description><para>Digits: 0-9</para>
        /// </description></item>
        /// <item><description><para>Letters: lowercase English letters a-z</para>
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
        /// <para>The mode for handling the body content when generating a cache key for POST requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>md5</c>: Calculates the MD5 hash of the body content and adds the hash to the cache key.</para>
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
        /// <para>The size limit (in KB) of the body content for POST caching. The value is an integer from 1 to 8. A null or empty value defaults to 8 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostBodySizeLimit")]
        [Validation(Required=false)]
        public string PostBodySizeLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the POST cache feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PostCache")]
        [Validation(Required=false)]
        public string PostCache { get; set; }

        /// <summary>
        /// <para>Specifies the query strings to include in or exclude from the cache key. Separate multiple query strings with spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("QueryString")]
        [Validation(Required=false)]
        public string QueryString { get; set; }

        /// <summary>
        /// <para>The mode for handling query strings when generating a cache key. Valid values:</para>
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
        /// <para>reserve_all</para>
        /// </summary>
        [NameInMap("QueryStringMode")]
        [Validation(Required=false)]
        public string QueryStringMode { get; set; }

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
        /// <para>The rule content, which is a conditional expression used to match user requests. This parameter applies only to rule configurations.</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, use <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, use a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>Specifies whether the rule is enabled. This parameter applies only to rule configurations. Valid values:</para>
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
        /// <para>The name of the rule. This parameter applies only to rule configurations.</para>
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
        /// <para>Specifies whether to serve stale content. If enabled, edge nodes serve stale (expired) content from the cache when the origin server is unavailable. Valid values:</para>
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
        /// <para>The version number of the site configuration. For sites with version management enabled, this indicates the configuration version. The default is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort query strings before generating the cache key. Valid values:</para>
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
        /// <para>Specifies whether to include the client\&quot;s device type in the cache key. Valid values:</para>
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
        /// <para>Specifies whether to include the client\&quot;s geographic location in the cache key. Valid values:</para>
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
        /// <para>Specifies whether to include the client\&quot;s language in the cache key. Valid values:</para>
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

}
