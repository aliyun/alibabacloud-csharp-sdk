// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateCacheRuleRequest : TeaModel {
        /// <summary>
        /// <para>Enable caching on specified ports. Value range: 8880, 2052, 2082, 2086, 2095, 2053, 2083, 2087, 2096</para>
        /// 
        /// <b>Example:</b>
        /// <para>8880</para>
        /// </summary>
        [NameInMap("AdditionalCacheablePorts")]
        [Validation(Required=false)]
        public string AdditionalCacheablePorts { get; set; }

        /// <summary>
        /// <para>Browser cache mode. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>no_cache: Do not cache.</description></item>
        /// <item><description>follow_origin: Follow the origin server\&quot;s cache policy.</description></item>
        /// <item><description>override_origin: Override the origin server\&quot;s cache policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>follow_origin</para>
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
        /// <para>Set the bypass cache mode. Possible values:</para>
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
        /// <para>Cache deception defense. Used to defend against web cache deception attacks; only the verified cache content will be cached. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CacheDeceptionArmor")]
        [Validation(Required=false)]
        public string CacheDeceptionArmor { get; set; }

        /// <summary>
        /// <para>Cache retention eligibility. Used to control whether user requests bypass the cache retention node when returning to the origin. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>bypass_cache_reserve: Requests bypass cache retention.</description></item>
        /// <item><description>eligible_for_cache_reserve: Eligible for cache retention.</description></item>
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
        /// <para>Edge cache mode. Possible values:</para>
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
        /// <para>Status code cache expiration time, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("EdgeStatusCodeCacheTtl")]
        [Validation(Required=false)]
        public string EdgeStatusCodeCacheTtl { get; set; }

        /// <summary>
        /// <para>When generating the cache key, add the specified cookie names and their values. Multiple values are supported, separated by spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cookie_exapmle</para>
        /// </summary>
        [NameInMap("IncludeCookie")]
        [Validation(Required=false)]
        public string IncludeCookie { get; set; }

        /// <summary>
        /// <para>When generating the cache key, add the specified header names and their values. Multiple values are supported, separated by spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("IncludeHeader")]
        [Validation(Required=false)]
        public string IncludeHeader { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("PostBodyCacheKey")]
        [Validation(Required=false)]
        public string PostBodyCacheKey { get; set; }

        [NameInMap("PostBodySizeLimit")]
        [Validation(Required=false)]
        public string PostBodySizeLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PostCache")]
        [Validation(Required=false)]
        public string PostCache { get; set; }

        /// <summary>
        /// <para>Query strings to be reserved or excluded. Multiple values are supported, separated by spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("QueryString")]
        [Validation(Required=false)]
        public string QueryString { get; set; }

        /// <summary>
        /// <para>The processing mode for query strings when generating the cache key. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>ignore_all: Ignore all.</description></item>
        /// <item><description>exclude_query_string: Exclude specified query strings.</description></item>
        /// <item><description>reserve_all: Default, reserve all.</description></item>
        /// <item><description>include_query_string: Include specified query strings.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>reserve_all</para>
        /// </summary>
        [NameInMap("QueryStringMode")]
        [Validation(Required=false)]
        public string QueryStringMode { get; set; }

        /// <summary>
        /// <para>Rule content, using conditional expressions to match user requests. This parameter is not required when adding a global configuration. There are two usage scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Match all incoming requests: Set the value to true</description></item>
        /// <item><description>Match specific requests: Set the value to a custom expression, for example: (http.host eq \&quot;video.example.com\&quot;)</description></item>
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
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
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

        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>Serve stale cache. When enabled, the node can still use the expired cached files to respond to user requests even if the origin server is unavailable. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("ServeStale")]
        [Validation(Required=false)]
        public string ServeStale { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340035003106221</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Version number of the site configuration. For sites with version management enabled, you can use this parameter to specify the version for the configuration to take effect. The default is version 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>Query string sorting, disabled by default. Possible values:</para>
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
        /// <para>When generating the cache key, include the client device type. Possible values:</para>
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
        /// <para>Include the client\&quot;s geographical location when generating the cache key. Value range:</para>
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
        /// <para>Include the client\&quot;s language type when generating the cache key. Value range:</para>
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

}
