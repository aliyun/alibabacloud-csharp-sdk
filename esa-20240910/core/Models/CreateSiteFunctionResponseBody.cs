// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteFunctionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public CreateSiteFunctionResponseBodyConfigs Configs { get; set; }
        public class CreateSiteFunctionResponseBodyConfigs : TeaModel {
            [NameInMap("CacheReserve")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsCacheReserve> CacheReserve { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsCacheReserve : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>352816096987136</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
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
            public List<CreateSiteFunctionResponseBodyConfigsCacheRules> CacheRules { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsCacheRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8880</para>
                /// </summary>
                [NameInMap("AdditionalCacheablePorts")]
                [Validation(Required=false)]
                public string AdditionalCacheablePorts { get; set; }

                /// <summary>
                /// <para>The browser cache configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>no_cache: does not cache resources.</description></item>
                /// <item><description>follow_origin: follows the origin\&quot;s cache rule.</description></item>
                /// <item><description>override_origin: uses a custom cache rule instead of the origin\&quot;s.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>follow_origin</para>
                /// </summary>
                [NameInMap("BrowserCacheMode")]
                [Validation(Required=false)]
                public string BrowserCacheMode { get; set; }

                /// <summary>
                /// <para>The browser cache TTL. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("BrowserCacheTtl")]
                [Validation(Required=false)]
                public string BrowserCacheTtl { get; set; }

                /// <summary>
                /// <para>The configuration of bypass cache. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cache_all: Responses of all requests are cached.</description></item>
                /// <item><description>default_cache (default): Resources are cached only based on supported file extensions.</description></item>
                /// <item><description>bypass_all: All requests bypass the cache component.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>default_cache</para>
                /// </summary>
                [NameInMap("BypassCache")]
                [Validation(Required=false)]
                public string BypassCache { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("CacheDeceptionArmor")]
                [Validation(Required=false)]
                public string CacheDeceptionArmor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bypass_cache_reserve</para>
                /// </summary>
                [NameInMap("CacheReserveEligibility")]
                [Validation(Required=false)]
                public string CacheReserveEligibility { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cookiename</para>
                /// </summary>
                [NameInMap("CheckPresenceCookie")]
                [Validation(Required=false)]
                public string CheckPresenceCookie { get; set; }

                /// <summary>
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
                /// <para>The edge cache configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>follow_origin: follows the origin\&quot;s cache rule. If the origin does not have a cache rule, the default cache rule is used.</description></item>
                /// <item><description>no-cache: does not cache resources.</description></item>
                /// <item><description>override_origin: uses a custom cache rule instead of the origin\&quot;s.</description></item>
                /// <item><description>follow_origin_bypass: follows the origin\&quot;s cache rule. If the origin does not have a cache rule, no resources are cached.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>follow_origin</para>
                /// </summary>
                [NameInMap("EdgeCacheMode")]
                [Validation(Required=false)]
                public string EdgeCacheMode { get; set; }

                /// <summary>
                /// <para>The edge cache TTL. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("EdgeCacheTtl")]
                [Validation(Required=false)]
                public string EdgeCacheTtl { get; set; }

                /// <summary>
                /// <para>The status code TTL. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("EdgeStatusCodeCacheTtl")]
                [Validation(Required=false)]
                public string EdgeStatusCodeCacheTtl { get; set; }

                /// <summary>
                /// <para>The cookie names and values included in the cache key. Multiple combinations are separated by spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cookie_exapmle</para>
                /// </summary>
                [NameInMap("IncludeCookie")]
                [Validation(Required=false)]
                public string IncludeCookie { get; set; }

                /// <summary>
                /// <para>The header names and values included in the cache key. Multiple combinations are separated by spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("IncludeHeader")]
                [Validation(Required=false)]
                public string IncludeHeader { get; set; }

                /// <summary>
                /// <para>The parameters to be retained or ignored in the query string. Multiple values are separated by spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("QueryString")]
                [Validation(Required=false)]
                public string QueryString { get; set; }

                /// <summary>
                /// <para>The method to process the query string when cache keys are generated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ignore_all: ignores the entire query string.</description></item>
                /// <item><description>exclude_query_string: ignores specified parameters in the query string.</description></item>
                /// <item><description>reserve_all (default): retains the entire query string.</description></item>
                /// <item><description>include_query_string: retains specified parameters in the query string.</description></item>
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
                /// <para>[{&quot;MatchType&quot;:&quot;http.request.method&quot;,&quot;MatchOperator&quot;:&quot;eq&quot;,&quot;MatchValue&quot;:&quot;GET&quot;,&quot;Negate&quot;:false}]</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("ServeStale")]
                [Validation(Required=false)]
                public string ServeStale { get; set; }

                /// <summary>
                /// <para>Indicates whether query string sorting is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("SortQueryStringForCache")]
                [Validation(Required=false)]
                public string SortQueryStringForCache { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("UserDeviceType")]
                [Validation(Required=false)]
                public string UserDeviceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("UserGeo")]
                [Validation(Required=false)]
                public string UserGeo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("UserLanguage")]
                [Validation(Required=false)]
                public string UserLanguage { get; set; }

            }

            /// <summary>
            /// <para>The cache tags.</para>
            /// </summary>
            [NameInMap("CacheTags")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsCacheTags> CacheTags { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsCacheTags : TeaModel {
                /// <summary>
                /// <para>Specifies whether the matching is not case-sensitive. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>The name of the custom cache tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            [NameInMap("CnameFlattening")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsCnameFlattening> CnameFlattening { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsCnameFlattening : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>352816096987136</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>flatten_all</para>
                /// </summary>
                [NameInMap("FlattenMode")]
                [Validation(Required=false)]
                public string FlattenMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The configuration of a compression rule.</para>
            /// </summary>
            [NameInMap("CompressionRules")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsCompressionRules> CompressionRules { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsCompressionRules : TeaModel {
                /// <summary>
                /// <para>Indicates whether Brotli compression is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>Indicates whether Gzip compression is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>[{&quot;MatchType&quot;:&quot;http.request.method&quot;,&quot;MatchOperator&quot;:&quot;eq&quot;,&quot;MatchValue&quot;:&quot;GET&quot;,&quot;Negate&quot;:false}]</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            [NameInMap("CrossBorderOptimization")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsCrossBorderOptimization> CrossBorderOptimization { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsCrossBorderOptimization : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>395227502417920</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

            }

            /// <summary>
            /// <para>The configuration of development mode.</para>
            /// </summary>
            [NameInMap("DevelopmentMode")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsDevelopmentMode> DevelopmentMode { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsDevelopmentMode : TeaModel {
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
                /// <para>Indicates whether the development mode is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The configuration of a request header modification rule.</para>
            /// </summary>
            [NameInMap("HttpRequestHeaderModificationRules")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsHttpRequestHeaderModificationRules> HttpRequestHeaderModificationRules { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsHttpRequestHeaderModificationRules : TeaModel {
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
                /// <para>Modifies a request header. You can add, delete, or modify a request header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;operation&quot;:&quot;add&quot;,&quot;name&quot;:&quot;header_example_add&quot;,&quot;value&quot;:&quot;value_exapme_add&quot;},{&quot;operation&quot;:&quot;del&quot;,&quot;name&quot;:&quot;header_example_delete&quot;,&quot;value&quot;:&quot;value_exapme_delete&quot;},{&quot;operation&quot;:&quot;modify&quot;,&quot;name&quot;:&quot;header_example_update&quot;,&quot;value&quot;:&quot;value_exapme_example&quot;}]</para>
                /// </summary>
                [NameInMap("RequestHeaderModification")]
                [Validation(Required=false)]
                public List<CreateSiteFunctionResponseBodyConfigsHttpRequestHeaderModificationRulesRequestHeaderModification> RequestHeaderModification { get; set; }
                public class CreateSiteFunctionResponseBodyConfigsHttpRequestHeaderModificationRulesRequestHeaderModification : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>headername</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    /// <summary>
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
                /// <para>[{&quot;MatchType&quot;:&quot;http.request.method&quot;,&quot;MatchOperator&quot;:&quot;eq&quot;,&quot;MatchValue&quot;:&quot;GET&quot;,&quot;Negate&quot;:false}]</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The configuration of a response header modification rule.</para>
            /// </summary>
            [NameInMap("HttpResponseHeaderModificationRules")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsHttpResponseHeaderModificationRules> HttpResponseHeaderModificationRules { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsHttpResponseHeaderModificationRules : TeaModel {
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
                /// <para>Modifies a response header. You can add, delete, or modify a request header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;operation&quot;:&quot;add&quot;,&quot;name&quot;:&quot;header_example_add&quot;,&quot;value&quot;:&quot;value_exapme_add&quot;},{&quot;operation&quot;:&quot;del&quot;,&quot;name&quot;:&quot;header_example_delete&quot;,&quot;value&quot;:&quot;value_exapme_delete&quot;},{&quot;operation&quot;:&quot;modify&quot;,&quot;name&quot;:&quot;header_example_update&quot;,&quot;value&quot;:&quot;value_exapme_example&quot;}]</para>
                /// </summary>
                [NameInMap("ResponseHeaderModification")]
                [Validation(Required=false)]
                public List<CreateSiteFunctionResponseBodyConfigsHttpResponseHeaderModificationRulesResponseHeaderModification> ResponseHeaderModification { get; set; }
                public class CreateSiteFunctionResponseBodyConfigsHttpResponseHeaderModificationRulesResponseHeaderModification : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>headername</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    /// <summary>
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
                /// <para>[{&quot;MatchType&quot;:&quot;http.request.method&quot;,&quot;MatchOperator&quot;:&quot;eq&quot;,&quot;MatchValue&quot;:&quot;GET&quot;,&quot;Negate&quot;:false}]</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            [NameInMap("HttpsApplicationConfiguration")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsHttpsApplicationConfiguration> HttpsApplicationConfiguration { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsHttpsApplicationConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AltSvc")]
                [Validation(Required=false)]
                public string AltSvc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AltSvcClear")]
                [Validation(Required=false)]
                public string AltSvcClear { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("AltSvcMa")]
                [Validation(Required=false)]
                public string AltSvcMa { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AltSvcPersist")]
                [Validation(Required=false)]
                public string AltSvcPersist { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>352816096987136</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Hsts")]
                [Validation(Required=false)]
                public string Hsts { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HstsIncludeSubdomains")]
                [Validation(Required=false)]
                public string HstsIncludeSubdomains { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("HstsMaxAge")]
                [Validation(Required=false)]
                public string HstsMaxAge { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HstsPreload")]
                [Validation(Required=false)]
                public string HstsPreload { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HttpsForce")]
                [Validation(Required=false)]
                public string HttpsForce { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>301</para>
                /// </summary>
                [NameInMap("HttpsForceCode")]
                [Validation(Required=false)]
                public string HttpsForceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("RuleEnable")]
                [Validation(Required=false)]
                public string RuleEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            [NameInMap("HttpsBasicConfiguration")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsHttpsBasicConfiguration> HttpsBasicConfiguration { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsHttpsBasicConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256</para>
                /// </summary>
                [NameInMap("Ciphersuite")]
                [Validation(Required=false)]
                public string Ciphersuite { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("CiphersuiteGroup")]
                [Validation(Required=false)]
                public string CiphersuiteGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>352816096987136</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Http2")]
                [Validation(Required=false)]
                public string Http2 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Http3")]
                [Validation(Required=false)]
                public string Http3 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Https")]
                [Validation(Required=false)]
                public string Https { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("OcspStapling")]
                [Validation(Required=false)]
                public string OcspStapling { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("RuleEnable")]
                [Validation(Required=false)]
                public string RuleEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Tls10")]
                [Validation(Required=false)]
                public string Tls10 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Tls11")]
                [Validation(Required=false)]
                public string Tls11 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Tls12")]
                [Validation(Required=false)]
                public string Tls12 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Tls13")]
                [Validation(Required=false)]
                public string Tls13 { get; set; }

            }

            /// <summary>
            /// <para>The configuration of image transformations.</para>
            /// </summary>
            [NameInMap("ImageTransform")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsImageTransform> ImageTransform { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsImageTransform : TeaModel {
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
                /// <para>Indicates whether the image transformations feature is enabled. Valid values:</para>
                /// <para>on</para>
                /// <para>off (default)</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The order in which the rule is executed.</para>
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
            public List<CreateSiteFunctionResponseBodyConfigsIpv6> Ipv6 { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsIpv6 : TeaModel {
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
                /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
                /// <para>on (default)</para>
                /// <para>off</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The configuration of managed transforms.</para>
            /// </summary>
            [NameInMap("ManagedTransforms")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsManagedTransforms> ManagedTransforms { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsManagedTransforms : TeaModel {
                /// <summary>
                /// <para>Indicates whether the header that indicates the geographical location of a client is included in an origin request. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AddClientGeolocationHeaders")]
                [Validation(Required=false)]
                public string AddClientGeolocationHeaders { get; set; }

                /// <summary>
                /// <para>Indicates whether the &quot;ali-real-client-ip&quot; header that contains the client\&quot;s real IP address is included in an origin request. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            [NameInMap("NetworkOptimization")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsNetworkOptimization> NetworkOptimization { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsNetworkOptimization : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>390286182395904</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Grpc")]
                [Validation(Required=false)]
                public string Grpc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Http2Origin")]
                [Validation(Required=false)]
                public string Http2Origin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("RuleEnable")]
                [Validation(Required=false)]
                public string RuleEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rule_example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("SmartRouting")]
                [Validation(Required=false)]
                public string SmartRouting { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("UploadMaxFilesize")]
                [Validation(Required=false)]
                public string UploadMaxFilesize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Websocket")]
                [Validation(Required=false)]
                public string Websocket { get; set; }

            }

            /// <summary>
            /// <para>The configuration of an origin rule.</para>
            /// </summary>
            [NameInMap("OriginRules")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsOriginRules> OriginRules { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsOriginRules : TeaModel {
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
                /// <para>The hostname that overrides the resolved hostname of an incoming request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.example.com</para>
                /// </summary>
                [NameInMap("DnsRecord")]
                [Validation(Required=false)]
                public string DnsRecord { get; set; }

                /// <summary>
                /// <para>The Host header in origin requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>origin.example.com</para>
                /// </summary>
                [NameInMap("OriginHost")]
                [Validation(Required=false)]
                public string OriginHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("OriginHttpPort")]
                [Validation(Required=false)]
                public string OriginHttpPort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4433</para>
                /// </summary>
                [NameInMap("OriginHttpsPort")]
                [Validation(Required=false)]
                public string OriginHttpsPort { get; set; }

                /// <summary>
                /// <para>The protocol used for origin requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>http: HTTP.</description></item>
                /// <item><description>https: HTTPS.</description></item>
                /// <item><description>follow: follows the protocol used by the client.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("OriginScheme")]
                [Validation(Required=false)]
                public string OriginScheme { get; set; }

                /// <summary>
                /// <para>The SNI in origin requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>origin.example.com</para>
                /// </summary>
                [NameInMap("OriginSni")]
                [Validation(Required=false)]
                public string OriginSni { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Range")]
                [Validation(Required=false)]
                public string Range { get; set; }

                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;MatchType&quot;:&quot;http.request.method&quot;,&quot;MatchOperator&quot;:&quot;eq&quot;,&quot;MatchValue&quot;:&quot;GET&quot;,&quot;Negate&quot;:false}]</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The configuration of a redirect rule.</para>
            /// </summary>
            [NameInMap("RedirectRules")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsRedirectRules> RedirectRules { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsRedirectRules : TeaModel {
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
                /// <para>Indicates whether the feature of retaining the query string is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>[{&quot;MatchType&quot;:&quot;http.request.method&quot;,&quot;MatchOperator&quot;:&quot;eq&quot;,&quot;MatchValue&quot;:&quot;GET&quot;,&quot;Negate&quot;:false}]</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>The response code that you want to use to indicate URL redirection. Valid values:</para>
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
                /// <para>The destination URL to which requests are redirected.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.exapmle.com/index.html">http://www.exapmle.com/index.html</a></para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>The redirect type. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>static</description></item>
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
            /// <para>The configuration of a URL rewrite rule.</para>
            /// </summary>
            [NameInMap("RewriteUrlRules")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsRewriteUrlRules> RewriteUrlRules { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsRewriteUrlRules : TeaModel {
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
                /// <para>The desired query string to which you want to rewrite the query string in the original request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>?example=123</para>
                /// </summary>
                [NameInMap("QueryString")]
                [Validation(Required=false)]
                public string QueryString { get; set; }

                /// <summary>
                /// <para>The query string rewrite method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>static</description></item>
                /// <item><description>dynamic</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("RewriteQueryStringType")]
                [Validation(Required=false)]
                public string RewriteQueryStringType { get; set; }

                /// <summary>
                /// <para>The path rewrite method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>static</description></item>
                /// <item><description>dynamic</description></item>
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
                /// <para>[{&quot;MatchType&quot;:&quot;http.request.method&quot;,&quot;MatchOperator&quot;:&quot;eq&quot;,&quot;MatchValue&quot;:&quot;GET&quot;,&quot;Negate&quot;:false}]</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

                /// <summary>
                /// <para>The desired URI to which you want to rewrite the path in the original request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/image.example.com/index.html</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The configuration of SEO crawler bypassing.</para>
            /// </summary>
            [NameInMap("SeoBypass")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsSeoBypass> SeoBypass { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsSeoBypass : TeaModel {
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
                /// <para>Indicates whether SEO crawler bypassing is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            [NameInMap("SiteNameExclusive")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsSiteNameExclusive> SiteNameExclusive { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsSiteNameExclusive : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>352816096987136</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            /// <summary>
            /// <para>The configuration of temporarily pausing ESA proxy on the website. If you pause ESA proxy, all requests to the domains in your DNS records go directly to your origin server.</para>
            /// </summary>
            [NameInMap("SitePause")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsSitePause> SitePause { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsSitePause : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>344147756398592</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>Indicates whether ESA is paused on the website. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Paused")]
                [Validation(Required=false)]
                public string Paused { get; set; }

                /// <summary>
                /// <para>The order in which the rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

            [NameInMap("TieredCache")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionResponseBodyConfigsTieredCache> TieredCache { get; set; }
            public class CreateSiteFunctionResponseBodyConfigsTieredCache : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>edge_smart</para>
                /// </summary>
                [NameInMap("CacheArchitectureMode")]
                [Validation(Required=false)]
                public string CacheArchitectureMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>352816096987136</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public string Sequence { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
