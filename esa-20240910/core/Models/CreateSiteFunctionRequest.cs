// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteFunctionRequest : TeaModel {
        [NameInMap("CacheReserve")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestCacheReserve> CacheReserve { get; set; }
        public class CreateSiteFunctionRequestCacheReserve : TeaModel {
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
        public List<CreateSiteFunctionRequestCacheRules> CacheRules { get; set; }
        public class CreateSiteFunctionRequestCacheRules : TeaModel {
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
            /// <para>The cookie names and values included in the cache key. Separate multiple combinations with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cookie_exapmle</para>
            /// </summary>
            [NameInMap("IncludeCookie")]
            [Validation(Required=false)]
            public string IncludeCookie { get; set; }

            /// <summary>
            /// <para>The header names and values included in the cache key. Separate multiple combinations with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("IncludeHeader")]
            [Validation(Required=false)]
            public string IncludeHeader { get; set; }

            /// <summary>
            /// <para>The parameters to be retained or ignored in the query string. Separate multiple values with spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("QueryString")]
            [Validation(Required=false)]
            public string QueryString { get; set; }

            /// <summary>
            /// <para>Specifies how to process the query string when cache keys are generated. Valid values:</para>
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
            /// <para>Specifies whether to enable the rule. Valid values:</para>
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
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ServeStale")]
            [Validation(Required=false)]
            public string ServeStale { get; set; }

            /// <summary>
            /// <para>Specifies whether to sort query strings. Valid values:</para>
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
        public List<CreateSiteFunctionRequestCacheTags> CacheTags { get; set; }
        public class CreateSiteFunctionRequestCacheTags : TeaModel {
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
            /// <para>The name of the custom cache tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// <para>The configuration of CNAME flattening.</para>
        /// </summary>
        [NameInMap("CnameFlattening")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestCnameFlattening> CnameFlattening { get; set; }
        public class CreateSiteFunctionRequestCnameFlattening : TeaModel {
            /// <summary>
            /// <para>The CNAME flattening mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>flatten_all: flattens all CNAMEs.</description></item>
            /// <item><description>flatten_all (default): flattens only the root domain.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("FlattenMode")]
            [Validation(Required=false)]
            public string FlattenMode { get; set; }

        }

        /// <summary>
        /// <para>The configuration of a compression rule.</para>
        /// </summary>
        [NameInMap("CompressionRules")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestCompressionRules> CompressionRules { get; set; }
        public class CreateSiteFunctionRequestCompressionRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable Brotli compression. Valid values:</para>
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
            /// <para>Specifies whether to enable Gzip compression. Valid values:</para>
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
            /// <para>Specifies whether to enable the rule. Valid values:</para>
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

        }

        [NameInMap("CrossBorderOptimization")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestCrossBorderOptimization> CrossBorderOptimization { get; set; }
        public class CreateSiteFunctionRequestCrossBorderOptimization : TeaModel {
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
        public List<CreateSiteFunctionRequestDevelopmentMode> DevelopmentMode { get; set; }
        public class CreateSiteFunctionRequestDevelopmentMode : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the development mode. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The configuration of a request header modification rule.</para>
        /// </summary>
        [NameInMap("HttpRequestHeaderModificationRules")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestHttpRequestHeaderModificationRules> HttpRequestHeaderModificationRules { get; set; }
        public class CreateSiteFunctionRequestHttpRequestHeaderModificationRules : TeaModel {
            /// <summary>
            /// <para>Modifies a request header. You can add, delete, or modify a response header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;operation&quot;:&quot;add&quot;,&quot;name&quot;:&quot;header_example_add&quot;,&quot;value&quot;:&quot;value_exapme_add&quot;},{&quot;operation&quot;:&quot;del&quot;,&quot;name&quot;:&quot;header_example_delete&quot;,&quot;value&quot;:&quot;value_exapme_delete&quot;},{&quot;operation&quot;:&quot;modify&quot;,&quot;name&quot;:&quot;header_example_update&quot;,&quot;value&quot;:&quot;value_exapme_example&quot;}]</para>
            /// </summary>
            [NameInMap("RequestHeaderModification")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionRequestHttpRequestHeaderModificationRulesRequestHeaderModification> RequestHeaderModification { get; set; }
            public class CreateSiteFunctionRequestHttpRequestHeaderModificationRulesRequestHeaderModification : TeaModel {
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
            /// <para>Specifies whether to enable the rule. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The configuration of a response header modification rule.</para>
        /// </summary>
        [NameInMap("HttpResponseHeaderModificationRules")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestHttpResponseHeaderModificationRules> HttpResponseHeaderModificationRules { get; set; }
        public class CreateSiteFunctionRequestHttpResponseHeaderModificationRules : TeaModel {
            /// <summary>
            /// <para>Modifies a response header. You can add, delete, or modify a request header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;operation&quot;:&quot;add&quot;,&quot;name&quot;:&quot;header_example_add&quot;,&quot;value&quot;:&quot;value_exapme_add&quot;},{&quot;operation&quot;:&quot;del&quot;,&quot;name&quot;:&quot;header_example_delete&quot;,&quot;value&quot;:&quot;value_exapme_delete&quot;},{&quot;operation&quot;:&quot;modify&quot;,&quot;name&quot;:&quot;header_example_update&quot;,&quot;value&quot;:&quot;value_exapme_example&quot;}]</para>
            /// </summary>
            [NameInMap("ResponseHeaderModification")]
            [Validation(Required=false)]
            public List<CreateSiteFunctionRequestHttpResponseHeaderModificationRulesResponseHeaderModification> ResponseHeaderModification { get; set; }
            public class CreateSiteFunctionRequestHttpResponseHeaderModificationRulesResponseHeaderModification : TeaModel {
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
            /// <para>Specifies whether to enable the rule. Valid values:</para>
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

        }

        [NameInMap("HttpsApplicationConfiguration")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestHttpsApplicationConfiguration> HttpsApplicationConfiguration { get; set; }
        public class CreateSiteFunctionRequestHttpsApplicationConfiguration : TeaModel {
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

        }

        [NameInMap("HttpsBasicConfiguration")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestHttpsBasicConfiguration> HttpsBasicConfiguration { get; set; }
        public class CreateSiteFunctionRequestHttpsBasicConfiguration : TeaModel {
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
        public List<CreateSiteFunctionRequestImageTransform> ImageTransform { get; set; }
        public class CreateSiteFunctionRequestImageTransform : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable image transformations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

        }

        /// <summary>
        /// <para>The IPv6 configuration.</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestIpv6> Ipv6 { get; set; }
        public class CreateSiteFunctionRequestIpv6 : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on (default)</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

        }

        /// <summary>
        /// <para>The configuration of managed transforms.</para>
        /// </summary>
        [NameInMap("ManagedTransforms")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestManagedTransforms> ManagedTransforms { get; set; }
        public class CreateSiteFunctionRequestManagedTransforms : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include the header that indicates the geographical location of a client in an origin request. Valid values:</para>
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
            /// <para>Specifies whether to include the &quot;ali-real-client-ip&quot; header that contains the client\&quot;s real IP address in an origin request. Valid values:</para>
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

        }

        [NameInMap("NetworkOptimization")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestNetworkOptimization> NetworkOptimization { get; set; }
        public class CreateSiteFunctionRequestNetworkOptimization : TeaModel {
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
            /// <para>on</para>
            /// </summary>
            [NameInMap("SmartRouting")]
            [Validation(Required=false)]
            public string SmartRouting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
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
        /// <para>The configuration of origin protection.</para>
        /// </summary>
        [NameInMap("OriginProtection")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestOriginProtection> OriginProtection { get; set; }
        public class CreateSiteFunctionRequestOriginProtection : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable origin protection. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The configuration of an origin rule.</para>
        /// </summary>
        [NameInMap("OriginRules")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestOriginRules> OriginRules { get; set; }
        public class CreateSiteFunctionRequestOriginRules : TeaModel {
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
            /// <para>Specifies whether to enable the rule. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The configuration of a redirect rule.</para>
        /// </summary>
        [NameInMap("RedirectRules")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestRedirectRules> RedirectRules { get; set; }
        public class CreateSiteFunctionRequestRedirectRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retain the query string. Valid values:</para>
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
            /// <para>Specifies whether to enable the rule. Valid values:</para>
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
            /// <para>The response code that you want to use to indicate URL redirection. Valid value:</para>
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
        public List<CreateSiteFunctionRequestRewriteUrlRules> RewriteUrlRules { get; set; }
        public class CreateSiteFunctionRequestRewriteUrlRules : TeaModel {
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
            /// <para>Specifies whether to enable the rule. Valid values:</para>
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
        public List<CreateSiteFunctionRequestSeoBypass> SeoBypass { get; set; }
        public class CreateSiteFunctionRequestSeoBypass : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable SEO crawler bypassing. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateSiteFunction</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The configuration of site hold. After this feature is enabled, other accounts cannot add your website domain or its subdomains to ESA.</para>
        /// </summary>
        [NameInMap("SiteNameExclusive")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestSiteNameExclusive> SiteNameExclusive { get; set; }
        public class CreateSiteFunctionRequestSiteNameExclusive : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable site hold. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The configuration of temporarily pausing ESA proxy on the website. If you pause ESA proxy, all requests to the domains in your DNS records go directly to your origin server.</para>
        /// </summary>
        [NameInMap("SitePause")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestSitePause> SitePause { get; set; }
        public class CreateSiteFunctionRequestSitePause : TeaModel {
            /// <summary>
            /// <para>Specifies whether ESA is paused on the website. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Paused")]
            [Validation(Required=false)]
            public string Paused { get; set; }

        }

        /// <summary>
        /// <para>The version number of the website. You can use this parameter to specify a version of your website to apply the new feature settings. By default, version 0 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        [NameInMap("TieredCache")]
        [Validation(Required=false)]
        public List<CreateSiteFunctionRequestTieredCache> TieredCache { get; set; }
        public class CreateSiteFunctionRequestTieredCache : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>edge_smart</para>
            /// </summary>
            [NameInMap("CacheArchitectureMode")]
            [Validation(Required=false)]
            public string CacheArchitectureMode { get; set; }

        }

    }

}
