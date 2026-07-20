// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSiteFunctionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration information.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public ListSiteFunctionsResponseBodyConfigs Configs { get; set; }
        public class ListSiteFunctionsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The cache reserve configuration.</para>
            /// </summary>
            [NameInMap("CacheReserve")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsCacheReserve> CacheReserve { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsCacheReserve : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>392382988376064</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable cache reserve. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The cache reserve instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr_hk_123456789</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The cache rules.</para>
            /// </summary>
            [NameInMap("CacheRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsCacheRules> CacheRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsCacheRules : TeaModel {
                /// <summary>
                /// <para>The ports on which caching is enabled. Valid values: 8880, 2052, 2082, 2086, 2095, 2053, 2083, 2087, and 2096.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8880</para>
                /// </summary>
                [NameInMap("AdditionalCacheablePorts")]
                [Validation(Required=false)]
                public string AdditionalCacheablePorts { get; set; }

                /// <summary>
                /// <para>The browser cache mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>no_cache: no caching.</description></item>
                /// <item><description>follow_origin: follows the origin server cache policy.</description></item>
                /// <item><description>override_origin: overrides the origin server cache policy.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>follow_origin</para>
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
                /// <item><description>cache_all: all requests are cached.</description></item>
                /// <item><description>bypass_all: all requests bypass the cache.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cache_all</para>
                /// </summary>
                [NameInMap("BypassCache")]
                [Validation(Required=false)]
                public string BypassCache { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable cache deception armor. This feature protects against web cache deception attacks by caching only content that passes validation. Valid values:</para>
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
                /// <para>The cache reserve eligibility. Controls whether requests bypass the cache reserve node during back-to-origin. Valid values:</para>
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
                /// <para>Checks whether a cookie exists when generating cache keys. If the cookie exists, the cookie name (case-insensitive) is added to the cache key. Multiple cookie names are supported and separated by spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cookiename</para>
                /// </summary>
                [NameInMap("CheckPresenceCookie")]
                [Validation(Required=false)]
                public string CheckPresenceCookie { get; set; }

                /// <summary>
                /// <para>Checks whether a header exists when generating cache keys. If the header exists, the header name (case-insensitive) is added to the cache key. Multiple header names are supported and separated by spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>headername</para>
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
                /// <para>The edge cache mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>follow_origin: follows the origin server cache policy (if present). Otherwise, uses the default cache policy.</description></item>
                /// <item><description>no_cache: no caching.</description></item>
                /// <item><description>override_origin: overrides the origin server cache policy.</description></item>
                /// <item><description>follow_origin_bypass: follows the origin server cache policy (if present). Otherwise, does not cache.</description></item>
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
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("EdgeStatusCodeCacheTtl")]
                [Validation(Required=false)]
                public string EdgeStatusCodeCacheTtl { get; set; }

                /// <summary>
                /// <para>The cookie names and their values to include when generating cache keys. Multiple values are supported and separated by spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cookie_exapmle</para>
                /// </summary>
                [NameInMap("IncludeCookie")]
                [Validation(Required=false)]
                public string IncludeCookie { get; set; }

                /// <summary>
                /// <para>The header names and their values to include when generating cache keys. Multiple values are supported and separated by spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("IncludeHeader")]
                [Validation(Required=false)]
                public string IncludeHeader { get; set; }

                /// <summary>
                /// <para>The cache key processing mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ignore</para>
                /// </summary>
                [NameInMap("PostBodyCacheKey")]
                [Validation(Required=false)]
                public string PostBodyCacheKey { get; set; }

                /// <summary>
                /// <para>The body size limit, in KB. Supports body sizes from 1 to 8 KB. If left empty, the default value of 8 KB is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PostBodySizeLimit")]
                [Validation(Required=false)]
                public string PostBodySizeLimit { get; set; }

                /// <summary>
                /// <para>The POST cache switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("PostCache")]
                [Validation(Required=false)]
                public string PostCache { get; set; }

                /// <summary>
                /// <para>The query strings to retain or remove. Multiple values are supported and separated by spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("QueryString")]
                [Validation(Required=false)]
                public string QueryString { get; set; }

                /// <summary>
                /// <para>The query string processing mode when generating cache keys. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ignore_all: ignores all query strings.</description></item>
                /// <item><description>exclude_query_string: removes specified query strings.</description></item>
                /// <item><description>reserve_all: retains all query strings. This is the default value.</description></item>
                /// <item><description>include_query_string: retains specified query strings.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>reserve_all</para>
                /// </summary>
                [NameInMap("QueryStringMode")]
                [Validation(Required=false)]
                public string QueryStringMode { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>Specifies whether to serve stale cache. When enabled, the edge node can respond to user requests with cached expired content when the origin server is unavailable. Valid values:</para>
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
            /// <para>The cache tags. When using the purge-by-cache-tag feature, specifies the CacheTag name carried in the origin server response.</para>
            /// </summary>
            [NameInMap("CacheTags")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsCacheTags> CacheTags { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsCacheTags : TeaModel {
                /// <summary>
                /// <para>Specifies whether to ignore case. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("CaseInsensitive")]
                [Validation(Required=false)]
                public string CaseInsensitive { get; set; }

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
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>The custom CacheTag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The CNAME flattening configuration.</para>
            /// </summary>
            [NameInMap("CnameFlattening")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsCnameFlattening> CnameFlattening { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsCnameFlattening : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>245523334529026</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>The flattening mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>flatten_all: flattens all records.</description></item>
                /// <item><description>flatten_at_root: flattens only the root domain. This is the default value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>flatten_all</para>
                /// </summary>
                [NameInMap("FlattenMode")]
                [Validation(Required=false)]
                public string FlattenMode { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The compression rules.</para>
            /// </summary>
            [NameInMap("CompressionRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsCompressionRules> CompressionRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsCompressionRules : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable Brotli compression. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Brotli")]
                [Validation(Required=false)]
                public string Brotli { get; set; }

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
                /// <para>Specifies whether to enable Gzip compression. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Gzip")]
                [Validation(Required=false)]
                public string Gzip { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable Zstd compression. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Zstd")]
                [Validation(Required=false)]
                public string Zstd { get; set; }

            }

            /// <summary>
            /// <para>The Chinese mainland network optimization configuration.</para>
            /// </summary>
            [NameInMap("CrossBorderOptimization")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsCrossBorderOptimization> CrossBorderOptimization { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsCrossBorderOptimization : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>245523334529026</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable Chinese mainland network access optimization. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The custom response code rules.</para>
            /// </summary>
            [NameInMap("CustomResponseCode")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsCustomResponseCode> CustomResponseCode { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsCustomResponseCode : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>457325144242176</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>The response page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageId")]
                [Validation(Required=false)]
                public string PageId { get; set; }

                /// <summary>
                /// <para>The response code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ReturnCode")]
                [Validation(Required=false)]
                public string ReturnCode { get; set; }

                /// <summary>
                /// <para>The rule content. Uses conditional expressions to match user requests. This parameter is not required when adding a global configuration. Two scenarios are supported:</para>
                /// <list type="bullet">
                /// <item><description>Match all incoming requests: set the value to true.</description></item>
                /// <item><description>Match specified requests: set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq &quot;video.example.com&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. This parameter is not required when adding a global configuration. Valid values:</para>
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
                /// <para>The rule name. This parameter is not required when adding a global configuration.</para>
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
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The development mode configuration.</para>
            /// </summary>
            [NameInMap("DevelopmentMode")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsDevelopmentMode> DevelopmentMode { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsDevelopmentMode : TeaModel {
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
                /// <para>The feature switch. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The error page redirect rules.</para>
            /// </summary>
            [NameInMap("ErrorPagesRedirects")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsErrorPagesRedirects> ErrorPagesRedirects { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsErrorPagesRedirects : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>473117342636032</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>The error page redirect configuration.</para>
                /// </summary>
                [NameInMap("ErrorPagesRedirect")]
                [Validation(Required=false)]
                public List<ListSiteFunctionsResponseBodyConfigsErrorPagesRedirectsErrorPagesRedirect> ErrorPagesRedirect { get; set; }
                public class ListSiteFunctionsResponseBodyConfigsErrorPagesRedirectsErrorPagesRedirect : TeaModel {
                    /// <summary>
                    /// <para>The response status code used by the edge node when responding with the redirect address to the client. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>400</description></item>
                    /// <item><description>403</description></item>
                    /// <item><description>404</description></item>
                    /// <item><description>405</description></item>
                    /// <item><description>414</description></item>
                    /// <item><description>416</description></item>
                    /// <item><description>500</description></item>
                    /// <item><description>501</description></item>
                    /// <item><description>502</description></item>
                    /// <item><description>503</description></item>
                    /// <item><description>504</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("StatusCode")]
                    [Validation(Required=false)]
                    public string StatusCode { get; set; }

                    /// <summary>
                    /// <para>The target URL after redirection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://example.com/test">http://example.com/test</a></para>
                    /// </summary>
                    [NameInMap("TargetURL")]
                    [Validation(Required=false)]
                    public string TargetURL { get; set; }

                }

                /// <summary>
                /// <para>The rule content. Uses conditional expressions to match user requests. This parameter is not required when adding a global configuration. Two scenarios are supported:</para>
                /// <list type="bullet">
                /// <item><description>Match all incoming requests: set the value to true.</description></item>
                /// <item><description>Match specified requests: set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq &quot;video.example.com&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. This parameter is not required when adding a global configuration. Valid values:</para>
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
                /// <para>The rule name. This parameter is not required when adding a global configuration.</para>
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
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The inbound request header modification rules.</para>
            /// </summary>
            [NameInMap("HttpIncomingRequestHeaderModificationRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsHttpIncomingRequestHeaderModificationRules> HttpIncomingRequestHeaderModificationRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsHttpIncomingRequestHeaderModificationRules : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>430893999331328</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>The request header modifications. Supports add, delete, and modify operations.</para>
                /// </summary>
                [NameInMap("RequestHeaderModification")]
                [Validation(Required=false)]
                public List<ListSiteFunctionsResponseBodyConfigsHttpIncomingRequestHeaderModificationRulesRequestHeaderModification> RequestHeaderModification { get; set; }
                public class ListSiteFunctionsResponseBodyConfigsHttpIncomingRequestHeaderModificationRulesRequestHeaderModification : TeaModel {
                    /// <summary>
                    /// <para>The request header name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>headername</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The operation type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>add: adds a header.</description></item>
                    /// <item><description>del: deletes a header.</description></item>
                    /// <item><description>modify: modifies a header.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    /// <summary>
                    /// <para>The request header value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>headervalue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http.host eq &quot;videoo.example.com&quot;</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The inbound response header modification rules.</para>
            /// </summary>
            [NameInMap("HttpIncomingResponseHeaderModificationRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsHttpIncomingResponseHeaderModificationRules> HttpIncomingResponseHeaderModificationRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsHttpIncomingResponseHeaderModificationRules : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>430893999331328</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>The response header modifications. Supports add, delete, and modify operations.</para>
                /// </summary>
                [NameInMap("ResponseHeaderModification")]
                [Validation(Required=false)]
                public List<ListSiteFunctionsResponseBodyConfigsHttpIncomingResponseHeaderModificationRulesResponseHeaderModification> ResponseHeaderModification { get; set; }
                public class ListSiteFunctionsResponseBodyConfigsHttpIncomingResponseHeaderModificationRulesResponseHeaderModification : TeaModel {
                    /// <summary>
                    /// <para>The response header name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>headername</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The operation type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>add: adds a header.</description></item>
                    /// <item><description>del: deletes a header.</description></item>
                    /// <item><description>modify: modifies a header.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    /// <summary>
                    /// <para>The response header value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>headervalue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq &quot;video.example.com&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The request header modification rules.</para>
            /// </summary>
            [NameInMap("HttpRequestHeaderModificationRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsHttpRequestHeaderModificationRules> HttpRequestHeaderModificationRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsHttpRequestHeaderModificationRules : TeaModel {
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
                /// <para>The request header modifications. Supports add, delete, and modify operations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;operation&quot;:&quot;add&quot;,&quot;name&quot;:&quot;header_example_add&quot;,&quot;value&quot;:&quot;value_exapme_add&quot;},{&quot;operation&quot;:&quot;del&quot;,&quot;name&quot;:&quot;header_example_delete&quot;,&quot;value&quot;:&quot;value_exapme_delete&quot;},{&quot;operation&quot;:&quot;modify&quot;,&quot;name&quot;:&quot;header_example_update&quot;,&quot;value&quot;:&quot;value_exapme_example&quot;}]</para>
                /// </summary>
                [NameInMap("RequestHeaderModification")]
                [Validation(Required=false)]
                public List<ListSiteFunctionsResponseBodyConfigsHttpRequestHeaderModificationRulesRequestHeaderModification> RequestHeaderModification { get; set; }
                public class ListSiteFunctionsResponseBodyConfigsHttpRequestHeaderModificationRulesRequestHeaderModification : TeaModel {
                    /// <summary>
                    /// <para>The request header name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>headername</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The operation type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>add: adds a header.</description></item>
                    /// <item><description>del: deletes a header.</description></item>
                    /// <item><description>modify: modifies a header.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    /// <summary>
                    /// <para>The request header value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>headervalue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The response header modification rules.</para>
            /// </summary>
            [NameInMap("HttpResponseHeaderModificationRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsHttpResponseHeaderModificationRules> HttpResponseHeaderModificationRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsHttpResponseHeaderModificationRules : TeaModel {
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
                /// <para>The response header modifications. Supports add, delete, and modify operations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;operation&quot;:&quot;add&quot;,&quot;name&quot;:&quot;header_example_add&quot;,&quot;value&quot;:&quot;value_exapme_add&quot;},{&quot;operation&quot;:&quot;del&quot;,&quot;name&quot;:&quot;header_example_delete&quot;,&quot;value&quot;:&quot;value_exapme_delete&quot;},{&quot;operation&quot;:&quot;modify&quot;,&quot;name&quot;:&quot;header_example_update&quot;,&quot;value&quot;:&quot;value_exapme_example&quot;}]</para>
                /// </summary>
                [NameInMap("ResponseHeaderModification")]
                [Validation(Required=false)]
                public List<ListSiteFunctionsResponseBodyConfigsHttpResponseHeaderModificationRulesResponseHeaderModification> ResponseHeaderModification { get; set; }
                public class ListSiteFunctionsResponseBodyConfigsHttpResponseHeaderModificationRulesResponseHeaderModification : TeaModel {
                    /// <summary>
                    /// <para>The response header name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>headername</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The operation type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>add: adds a header.</description></item>
                    /// <item><description>del: deletes a header.</description></item>
                    /// <item><description>modify: modifies a header.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    /// <summary>
                    /// <para>The response header value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>headervalue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The HTTPS application configuration.</para>
            /// </summary>
            [NameInMap("HttpsApplicationConfiguration")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsHttpsApplicationConfiguration> HttpsApplicationConfiguration { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsHttpsApplicationConfiguration : TeaModel {
                /// <summary>
                /// <para>The Alt-Svc feature switch. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AltSvc")]
                [Validation(Required=false)]
                public string AltSvc { get; set; }

                /// <summary>
                /// <para>Specifies whether the Alt-Svc header includes the clear parameter. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AltSvcClear")]
                [Validation(Required=false)]
                public string AltSvcClear { get; set; }

                /// <summary>
                /// <para>The Alt-Svc validity period, in seconds. Default value: 86400.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("AltSvcMa")]
                [Validation(Required=false)]
                public string AltSvcMa { get; set; }

                /// <summary>
                /// <para>Specifies whether the Alt-Svc header includes the persist parameter. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AltSvcPersist")]
                [Validation(Required=false)]
                public string AltSvcPersist { get; set; }

                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>391240445274112</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable HSTS. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Hsts")]
                [Validation(Required=false)]
                public string Hsts { get; set; }

                /// <summary>
                /// <para>Specifies whether to include subdomains in HSTS. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HstsIncludeSubdomains")]
                [Validation(Required=false)]
                public string HstsIncludeSubdomains { get; set; }

                /// <summary>
                /// <para>The HSTS expiration time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("HstsMaxAge")]
                [Validation(Required=false)]
                public string HstsMaxAge { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable HSTS preload. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HstsPreload")]
                [Validation(Required=false)]
                public string HstsPreload { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable forced HTTPS. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>on: enabled.</para>
                /// </description></item>
                /// <item><description><para>off: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HttpsForce")]
                [Validation(Required=false)]
                public string HttpsForce { get; set; }

                /// <summary>
                /// <para>The status code used for forced HTTPS redirect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>301</description></item>
                /// <item><description>302</description></item>
                /// <item><description>307</description></item>
                /// <item><description>308</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>301</para>
                /// </summary>
                [NameInMap("HttpsForceCode")]
                [Validation(Required=false)]
                public string HttpsForceCode { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The HTTPS basic configuration.</para>
            /// </summary>
            [NameInMap("HttpsBasicConfiguration")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsHttpsBasicConfiguration> HttpsBasicConfiguration { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsHttpsBasicConfiguration : TeaModel {
                /// <summary>
                /// <para>The custom cipher suites. Specifies the specific encryption algorithms selected when CiphersuiteGroup is set to custom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256</para>
                /// </summary>
                [NameInMap("Ciphersuite")]
                [Validation(Required=false)]
                public string Ciphersuite { get; set; }

                /// <summary>
                /// <para>The cipher suite group. All cipher suites are enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>all: all cipher suites.</description></item>
                /// <item><description>strict: strong cipher suites.</description></item>
                /// <item><description>custom: custom cipher suites.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("CiphersuiteGroup")]
                [Validation(Required=false)]
                public string CiphersuiteGroup { get; set; }

                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>391380266602496</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable HTTP/2. Enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Http2")]
                [Validation(Required=false)]
                public string Http2 { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable HTTP/3. Enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Http3")]
                [Validation(Required=false)]
                public string Http3 { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable HTTPS. Enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>on: enabled.</para>
                /// </description></item>
                /// <item><description><para>off: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Https")]
                [Validation(Required=false)]
                public string Https { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable OCSP stapling. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("OcspStapling")]
                [Validation(Required=false)]
                public string OcspStapling { get; set; }

                /// <summary>
                /// <para>The matching rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable TLS 1.0. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Tls10")]
                [Validation(Required=false)]
                public string Tls10 { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable TLS 1.1. Enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Tls11")]
                [Validation(Required=false)]
                public string Tls11 { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable TLS 1.2. Enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Tls12")]
                [Validation(Required=false)]
                public string Tls12 { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable TLS 1.3. Enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Tls13")]
                [Validation(Required=false)]
                public string Tls13 { get; set; }

            }

            /// <summary>
            /// <para>The image transformation configuration.</para>
            /// </summary>
            [NameInMap("ImageTransform")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsImageTransform> ImageTransform { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsImageTransform : TeaModel {
                /// <summary>
                /// <para>The adaptive AVIF setting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AutoAvif")]
                [Validation(Required=false)]
                public string AutoAvif { get; set; }

                /// <summary>
                /// <para>The adaptive WebP setting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AutoWebp")]
                [Validation(Required=false)]
                public string AutoWebp { get; set; }

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
                /// <para>Specifies whether to enable image transformation. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq &quot;video.example.com&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The IPv6 configuration.</para>
            /// </summary>
            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsIpv6> Ipv6 { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsIpv6 : TeaModel {
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
                /// <para>Specifies whether to enable IPv6. Enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The managed transforms.</para>
            /// </summary>
            [NameInMap("ManagedTransforms")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsManagedTransforms> ManagedTransforms { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsManagedTransforms : TeaModel {
                /// <summary>
                /// <para>Specifies whether to add visitor geolocation headers. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AddClientGeolocationHeaders")]
                [Validation(Required=false)]
                public string AddClientGeolocationHeaders { get; set; }

                /// <summary>
                /// <para>Specifies whether to add the &quot;ali-real-client-ip&quot; header that contains the real client IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AddRealClientIpHeader")]
                [Validation(Required=false)]
                public string AddRealClientIpHeader { get; set; }

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
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The network optimization configuration.</para>
            /// </summary>
            [NameInMap("NetworkOptimization")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsNetworkOptimization> NetworkOptimization { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsNetworkOptimization : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>395901755670528</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable gRPC. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Grpc")]
                [Validation(Required=false)]
                public string Grpc { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable HTTP/2 back-to-origin. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Http2Origin")]
                [Validation(Required=false)]
                public string Http2Origin { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable smart routing. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("SmartRouting")]
                [Validation(Required=false)]
                public string SmartRouting { get; set; }

                /// <summary>
                /// <para>The maximum upload file size, in MB. Valid values: 100 to 500.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("UploadMaxFilesize")]
                [Validation(Required=false)]
                public string UploadMaxFilesize { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable WebSocket. Enabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Websocket")]
                [Validation(Required=false)]
                public string Websocket { get; set; }

            }

            /// <summary>
            /// <para>The back-to-origin rules.</para>
            /// </summary>
            [NameInMap("OriginRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsOriginRules> OriginRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsOriginRules : TeaModel {
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
                /// <para>The overridden DNS resolution record for back-to-origin requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.example.com</para>
                /// </summary>
                [NameInMap("DnsRecord")]
                [Validation(Required=false)]
                public string DnsRecord { get; set; }

                /// <summary>
                /// <para>The HOST header carried in the back-to-origin request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>origin.example.com</para>
                /// </summary>
                [NameInMap("OriginHost")]
                [Validation(Required=false)]
                public string OriginHost { get; set; }

                /// <summary>
                /// <para>The origin server port used when fetching content over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("OriginHttpPort")]
                [Validation(Required=false)]
                public string OriginHttpPort { get; set; }

                /// <summary>
                /// <para>The origin server port used when fetching content over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4433</para>
                /// </summary>
                [NameInMap("OriginHttpsPort")]
                [Validation(Required=false)]
                public string OriginHttpsPort { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable mTLS for back-to-origin. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("OriginMtls")]
                [Validation(Required=false)]
                public string OriginMtls { get; set; }

                /// <summary>
                /// <para>The origin read timeout, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("OriginReadTimeout")]
                [Validation(Required=false)]
                public string OriginReadTimeout { get; set; }

                /// <summary>
                /// <para>The protocol used for back-to-origin requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>http: uses HTTP for back-to-origin.</description></item>
                /// <item><description>https: uses HTTPS for back-to-origin.</description></item>
                /// <item><description>follow: follows the client protocol for back-to-origin.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("OriginScheme")]
                [Validation(Required=false)]
                public string OriginScheme { get; set; }

                /// <summary>
                /// <para>The SNI carried in the back-to-origin request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>origin.example.com</para>
                /// </summary>
                [NameInMap("OriginSni")]
                [Validation(Required=false)]
                public string OriginSni { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable origin server certificate verification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("OriginVerify")]
                [Validation(Required=false)]
                public string OriginVerify { get; set; }

                /// <summary>
                /// <para>Specifies whether to use range-based origin fetch for file downloads. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// <item><description>force: forced.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Range")]
                [Validation(Required=false)]
                public string Range { get; set; }

                /// <summary>
                /// <para>The range chunk size. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>512KB</description></item>
                /// <item><description>1MB</description></item>
                /// <item><description>2MB</description></item>
                /// <item><description>4MB</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>512KB</para>
                /// </summary>
                [NameInMap("RangeChunkSize")]
                [Validation(Required=false)]
                public string RangeChunkSize { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The redirect rules.</para>
            /// </summary>
            [NameInMap("RedirectRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsRedirectRules> RedirectRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsRedirectRules : TeaModel {
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
                /// <para>Specifies whether to preserve the query string. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("ReserveQueryString")]
                [Validation(Required=false)]
                public string ReserveQueryString { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>The response status code used by the edge node when responding with the redirect address to the client. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>301</description></item>
                /// <item><description>302</description></item>
                /// <item><description>303</description></item>
                /// <item><description>307</description></item>
                /// <item><description>308</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>301</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>The target URL after redirection.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.exapmle.com/index.html">http://www.exapmle.com/index.html</a></para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>The redirect type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>static: static mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The URL rewrite rules.</para>
            /// </summary>
            [NameInMap("RewriteUrlRules")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsRewriteUrlRules> RewriteUrlRules { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsRewriteUrlRules : TeaModel {
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
                /// <para>The query string after rewriting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example=123</para>
                /// </summary>
                [NameInMap("QueryString")]
                [Validation(Required=false)]
                public string QueryString { get; set; }

                /// <summary>
                /// <para>The query string rewrite type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>static: static mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("RewriteQueryStringType")]
                [Validation(Required=false)]
                public string RewriteQueryStringType { get; set; }

                /// <summary>
                /// <para>The path rewrite type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>static: static mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("RewriteUriType")]
                [Validation(Required=false)]
                public string RewriteUriType { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>The target URI after rewriting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/image.example.com/index.html</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The search engine crawler bypass configuration.</para>
            /// </summary>
            [NameInMap("SeoBypass")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsSeoBypass> SeoBypass { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsSeoBypass : TeaModel {
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
                /// <para>The feature switch. Disabled by default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The site name exclusive configuration. When enabled, other accounts cannot create sites or subsites with the same name as the current site.</para>
            /// </summary>
            [NameInMap("SiteNameExclusive")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsSiteNameExclusive> SiteNameExclusive { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsSiteNameExclusive : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>380858020294656</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>The feature switch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The site acceleration pause configuration. Temporarily pauses the proxy acceleration feature for the entire site. When enabled, all DNS records directly return record values to clients.</para>
            /// </summary>
            [NameInMap("SitePause")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsSitePause> SitePause { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsSitePause : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>302426190190592</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>Temporarily pauses the proxy acceleration feature for the entire site. When enabled, all DNS records directly return record values to clients. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: site acceleration is paused.</description></item>
                /// <item><description>false: site acceleration is active.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Paused")]
                [Validation(Required=false)]
                public string Paused { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The tiered cache configuration.</para>
            /// </summary>
            [NameInMap("TieredCache")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsTieredCache> TieredCache { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsTieredCache : TeaModel {
                /// <summary>
                /// <para>The tiered cache architecture mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>edge: edge cache layer.</description></item>
                /// <item><description>edge_smart: edge cache layer + smart cache layer.</description></item>
                /// <item><description>edge_regional: edge cache layer + regional cache layer.</description></item>
                /// <item><description>edge_regional_smart: edge cache layer + regional cache layer + smart cache layer.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>edge_smart</para>
                /// </summary>
                [NameInMap("CacheArchitectureMode")]
                [Validation(Required=false)]
                public string CacheArchitectureMode { get; set; }

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
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The video processing configuration.</para>
            /// </summary>
            [NameInMap("VideoProcessing")]
            [Validation(Required=false)]
            public List<ListSiteFunctionsResponseBodyConfigsVideoProcessing> VideoProcessing { get; set; }
            public class ListSiteFunctionsResponseBodyConfigsVideoProcessing : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>455153377667072</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>The custom FLV end parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f_end</para>
                /// </summary>
                [NameInMap("FlvSeekEnd")]
                [Validation(Required=false)]
                public string FlvSeekEnd { get; set; }

                /// <summary>
                /// <para>The custom FLV start parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f_start</para>
                /// </summary>
                [NameInMap("FlvSeekStart")]
                [Validation(Required=false)]
                public string FlvSeekStart { get; set; }

                /// <summary>
                /// <para>The FLV seeking mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>by_byte: seeks by byte.</description></item>
                /// <item><description>by_time: seeks by time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>by_time</para>
                /// </summary>
                [NameInMap("FlvVideoSeekMode")]
                [Validation(Required=false)]
                public string FlvVideoSeekMode { get; set; }

                /// <summary>
                /// <para>The custom MP4 end parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m_end</para>
                /// </summary>
                [NameInMap("Mp4SeekEnd")]
                [Validation(Required=false)]
                public string Mp4SeekEnd { get; set; }

                /// <summary>
                /// <para>The custom MP4 start parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m_start</para>
                /// </summary>
                [NameInMap("Mp4SeekStart")]
                [Validation(Required=false)]
                public string Mp4SeekStart { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(http.host eq &quot;video.example.com&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The rule switch. Valid values:</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>The video seeking switch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>on: enabled.</para>
                /// </description></item>
                /// <item><description><para>off: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("VideoSeekEnable")]
                [Validation(Required=false)]
                public string VideoSeekEnable { get; set; }

            }

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
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
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
