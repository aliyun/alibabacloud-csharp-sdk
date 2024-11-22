// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteFunctionRequest : TeaModel {
        [NameInMap("CacheReserve")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestCacheReserve> CacheReserve { get; set; }
        public class UpdateSiteFunctionRequestCacheReserve : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("CacheRules")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestCacheRules> CacheRules { get; set; }
        public class UpdateSiteFunctionRequestCacheRules : TeaModel {
            [NameInMap("AdditionalCacheablePorts")]
            [Validation(Required=false)]
            public string AdditionalCacheablePorts { get; set; }

            [NameInMap("BrowserCacheMode")]
            [Validation(Required=false)]
            public string BrowserCacheMode { get; set; }

            [NameInMap("BrowserCacheTtl")]
            [Validation(Required=false)]
            public string BrowserCacheTtl { get; set; }

            [NameInMap("BypassCache")]
            [Validation(Required=false)]
            public string BypassCache { get; set; }

            [NameInMap("CacheDeceptionArmor")]
            [Validation(Required=false)]
            public string CacheDeceptionArmor { get; set; }

            [NameInMap("CacheReserveEligibility")]
            [Validation(Required=false)]
            public string CacheReserveEligibility { get; set; }

            [NameInMap("CheckPresenceCookie")]
            [Validation(Required=false)]
            public string CheckPresenceCookie { get; set; }

            [NameInMap("CheckPresenceHeader")]
            [Validation(Required=false)]
            public string CheckPresenceHeader { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("EdgeCacheMode")]
            [Validation(Required=false)]
            public string EdgeCacheMode { get; set; }

            [NameInMap("EdgeCacheTtl")]
            [Validation(Required=false)]
            public string EdgeCacheTtl { get; set; }

            [NameInMap("EdgeStatusCodeCacheTtl")]
            [Validation(Required=false)]
            public string EdgeStatusCodeCacheTtl { get; set; }

            [NameInMap("IncludeCookie")]
            [Validation(Required=false)]
            public string IncludeCookie { get; set; }

            [NameInMap("IncludeHeader")]
            [Validation(Required=false)]
            public string IncludeHeader { get; set; }

            [NameInMap("QueryString")]
            [Validation(Required=false)]
            public string QueryString { get; set; }

            [NameInMap("QueryStringMode")]
            [Validation(Required=false)]
            public string QueryStringMode { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("ServeStale")]
            [Validation(Required=false)]
            public string ServeStale { get; set; }

            [NameInMap("SortQueryStringForCache")]
            [Validation(Required=false)]
            public string SortQueryStringForCache { get; set; }

            [NameInMap("UserDeviceType")]
            [Validation(Required=false)]
            public string UserDeviceType { get; set; }

            [NameInMap("UserGeo")]
            [Validation(Required=false)]
            public string UserGeo { get; set; }

            [NameInMap("UserLanguage")]
            [Validation(Required=false)]
            public string UserLanguage { get; set; }

        }

        [NameInMap("CacheTags")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestCacheTags> CacheTags { get; set; }
        public class UpdateSiteFunctionRequestCacheTags : TeaModel {
            [NameInMap("CaseInsensitive")]
            [Validation(Required=false)]
            public string CaseInsensitive { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        [NameInMap("CnameFlattening")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestCnameFlattening> CnameFlattening { get; set; }
        public class UpdateSiteFunctionRequestCnameFlattening : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("FlattenMode")]
            [Validation(Required=false)]
            public string FlattenMode { get; set; }

        }

        [NameInMap("CompressionRules")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestCompressionRules> CompressionRules { get; set; }
        public class UpdateSiteFunctionRequestCompressionRules : TeaModel {
            [NameInMap("Brotli")]
            [Validation(Required=false)]
            public string Brotli { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Gzip")]
            [Validation(Required=false)]
            public string Gzip { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("CrossBorderOptimization")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestCrossBorderOptimization> CrossBorderOptimization { get; set; }
        public class UpdateSiteFunctionRequestCrossBorderOptimization : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

        }

        [NameInMap("DevelopmentMode")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestDevelopmentMode> DevelopmentMode { get; set; }
        public class UpdateSiteFunctionRequestDevelopmentMode : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

        }

        [NameInMap("HttpRequestHeaderModificationRules")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestHttpRequestHeaderModificationRules> HttpRequestHeaderModificationRules { get; set; }
        public class UpdateSiteFunctionRequestHttpRequestHeaderModificationRules : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("RequestHeaderModification")]
            [Validation(Required=false)]
            public List<UpdateSiteFunctionRequestHttpRequestHeaderModificationRulesRequestHeaderModification> RequestHeaderModification { get; set; }
            public class UpdateSiteFunctionRequestHttpRequestHeaderModificationRulesRequestHeaderModification : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("HttpResponseHeaderModificationRules")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestHttpResponseHeaderModificationRules> HttpResponseHeaderModificationRules { get; set; }
        public class UpdateSiteFunctionRequestHttpResponseHeaderModificationRules : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("ResponseHeaderModification")]
            [Validation(Required=false)]
            public List<UpdateSiteFunctionRequestHttpResponseHeaderModificationRulesResponseHeaderModification> ResponseHeaderModification { get; set; }
            public class UpdateSiteFunctionRequestHttpResponseHeaderModificationRulesResponseHeaderModification : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("HttpsApplicationConfiguration")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestHttpsApplicationConfiguration> HttpsApplicationConfiguration { get; set; }
        public class UpdateSiteFunctionRequestHttpsApplicationConfiguration : TeaModel {
            [NameInMap("AltSvc")]
            [Validation(Required=false)]
            public string AltSvc { get; set; }

            [NameInMap("AltSvcClear")]
            [Validation(Required=false)]
            public string AltSvcClear { get; set; }

            [NameInMap("AltSvcMa")]
            [Validation(Required=false)]
            public string AltSvcMa { get; set; }

            [NameInMap("AltSvcPersist")]
            [Validation(Required=false)]
            public string AltSvcPersist { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Hsts")]
            [Validation(Required=false)]
            public string Hsts { get; set; }

            [NameInMap("HstsIncludeSubdomains")]
            [Validation(Required=false)]
            public string HstsIncludeSubdomains { get; set; }

            [NameInMap("HstsMaxAge")]
            [Validation(Required=false)]
            public string HstsMaxAge { get; set; }

            [NameInMap("HstsPreload")]
            [Validation(Required=false)]
            public string HstsPreload { get; set; }

            [NameInMap("HttpsForce")]
            [Validation(Required=false)]
            public string HttpsForce { get; set; }

            [NameInMap("HttpsForceCode")]
            [Validation(Required=false)]
            public string HttpsForceCode { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("HttpsBasicConfiguration")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestHttpsBasicConfiguration> HttpsBasicConfiguration { get; set; }
        public class UpdateSiteFunctionRequestHttpsBasicConfiguration : TeaModel {
            [NameInMap("Ciphersuite")]
            [Validation(Required=false)]
            public string Ciphersuite { get; set; }

            [NameInMap("CiphersuiteGroup")]
            [Validation(Required=false)]
            public string CiphersuiteGroup { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Http2")]
            [Validation(Required=false)]
            public string Http2 { get; set; }

            [NameInMap("Http3")]
            [Validation(Required=false)]
            public string Http3 { get; set; }

            [NameInMap("Https")]
            [Validation(Required=false)]
            public string Https { get; set; }

            [NameInMap("OcspStapling")]
            [Validation(Required=false)]
            public string OcspStapling { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Tls10")]
            [Validation(Required=false)]
            public string Tls10 { get; set; }

            [NameInMap("Tls11")]
            [Validation(Required=false)]
            public string Tls11 { get; set; }

            [NameInMap("Tls12")]
            [Validation(Required=false)]
            public string Tls12 { get; set; }

            [NameInMap("Tls13")]
            [Validation(Required=false)]
            public string Tls13 { get; set; }

        }

        [NameInMap("ImageTransform")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestImageTransform> ImageTransform { get; set; }
        public class UpdateSiteFunctionRequestImageTransform : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

        }

        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestIpv6> Ipv6 { get; set; }
        public class UpdateSiteFunctionRequestIpv6 : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

        }

        [NameInMap("ManagedTransforms")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestManagedTransforms> ManagedTransforms { get; set; }
        public class UpdateSiteFunctionRequestManagedTransforms : TeaModel {
            [NameInMap("AddClientGeolocationHeaders")]
            [Validation(Required=false)]
            public string AddClientGeolocationHeaders { get; set; }

            [NameInMap("AddRealClientIpHeader")]
            [Validation(Required=false)]
            public string AddRealClientIpHeader { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

        }

        [NameInMap("NetworkOptimization")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestNetworkOptimization> NetworkOptimization { get; set; }
        public class UpdateSiteFunctionRequestNetworkOptimization : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Grpc")]
            [Validation(Required=false)]
            public string Grpc { get; set; }

            [NameInMap("Http2Origin")]
            [Validation(Required=false)]
            public string Http2Origin { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("SmartRouting")]
            [Validation(Required=false)]
            public string SmartRouting { get; set; }

            [NameInMap("UploadMaxFilesize")]
            [Validation(Required=false)]
            public string UploadMaxFilesize { get; set; }

            [NameInMap("Websocket")]
            [Validation(Required=false)]
            public string Websocket { get; set; }

        }

        [NameInMap("OriginRules")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestOriginRules> OriginRules { get; set; }
        public class UpdateSiteFunctionRequestOriginRules : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("DnsRecord")]
            [Validation(Required=false)]
            public string DnsRecord { get; set; }

            [NameInMap("OriginHost")]
            [Validation(Required=false)]
            public string OriginHost { get; set; }

            [NameInMap("OriginHttpPort")]
            [Validation(Required=false)]
            public string OriginHttpPort { get; set; }

            [NameInMap("OriginHttpsPort")]
            [Validation(Required=false)]
            public string OriginHttpsPort { get; set; }

            [NameInMap("OriginScheme")]
            [Validation(Required=false)]
            public string OriginScheme { get; set; }

            [NameInMap("OriginSni")]
            [Validation(Required=false)]
            public string OriginSni { get; set; }

            [NameInMap("Range")]
            [Validation(Required=false)]
            public string Range { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("RedirectRules")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestRedirectRules> RedirectRules { get; set; }
        public class UpdateSiteFunctionRequestRedirectRules : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("ReserveQueryString")]
            [Validation(Required=false)]
            public string ReserveQueryString { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            [NameInMap("TargetUrl")]
            [Validation(Required=false)]
            public string TargetUrl { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RewriteUrlRules")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestRewriteUrlRules> RewriteUrlRules { get; set; }
        public class UpdateSiteFunctionRequestRewriteUrlRules : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("QueryString")]
            [Validation(Required=false)]
            public string QueryString { get; set; }

            [NameInMap("RewriteQueryStringType")]
            [Validation(Required=false)]
            public string RewriteQueryStringType { get; set; }

            [NameInMap("RewriteUriType")]
            [Validation(Required=false)]
            public string RewriteUriType { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("SeoBypass")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestSeoBypass> SeoBypass { get; set; }
        public class UpdateSiteFunctionRequestSeoBypass : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateSiteFunction</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        [NameInMap("SiteNameExclusive")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestSiteNameExclusive> SiteNameExclusive { get; set; }
        public class UpdateSiteFunctionRequestSiteNameExclusive : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

        }

        [NameInMap("SitePause")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestSitePause> SitePause { get; set; }
        public class UpdateSiteFunctionRequestSitePause : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("Paused")]
            [Validation(Required=false)]
            public string Paused { get; set; }

        }

        [NameInMap("TieredCache")]
        [Validation(Required=false)]
        public List<UpdateSiteFunctionRequestTieredCache> TieredCache { get; set; }
        public class UpdateSiteFunctionRequestTieredCache : TeaModel {
            [NameInMap("CacheArchitectureMode")]
            [Validation(Required=false)]
            public string CacheArchitectureMode { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

        }

    }

}
