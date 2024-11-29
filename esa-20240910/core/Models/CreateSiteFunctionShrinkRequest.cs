// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteFunctionShrinkRequest : TeaModel {
        [NameInMap("CacheReserve")]
        [Validation(Required=false)]
        public string CacheReserveShrink { get; set; }

        /// <summary>
        /// <para>The cache rules.</para>
        /// </summary>
        [NameInMap("CacheRules")]
        [Validation(Required=false)]
        public string CacheRulesShrink { get; set; }

        /// <summary>
        /// <para>The cache tags.</para>
        /// </summary>
        [NameInMap("CacheTags")]
        [Validation(Required=false)]
        public string CacheTagsShrink { get; set; }

        /// <summary>
        /// <para>The configuration of CNAME flattening.</para>
        /// </summary>
        [NameInMap("CnameFlattening")]
        [Validation(Required=false)]
        public string CnameFlatteningShrink { get; set; }

        /// <summary>
        /// <para>The configuration of a compression rule.</para>
        /// </summary>
        [NameInMap("CompressionRules")]
        [Validation(Required=false)]
        public string CompressionRulesShrink { get; set; }

        [NameInMap("CrossBorderOptimization")]
        [Validation(Required=false)]
        public string CrossBorderOptimizationShrink { get; set; }

        /// <summary>
        /// <para>The configuration of development mode.</para>
        /// </summary>
        [NameInMap("DevelopmentMode")]
        [Validation(Required=false)]
        public string DevelopmentModeShrink { get; set; }

        /// <summary>
        /// <para>The configuration of a request header modification rule.</para>
        /// </summary>
        [NameInMap("HttpRequestHeaderModificationRules")]
        [Validation(Required=false)]
        public string HttpRequestHeaderModificationRulesShrink { get; set; }

        /// <summary>
        /// <para>The configuration of a response header modification rule.</para>
        /// </summary>
        [NameInMap("HttpResponseHeaderModificationRules")]
        [Validation(Required=false)]
        public string HttpResponseHeaderModificationRulesShrink { get; set; }

        [NameInMap("HttpsApplicationConfiguration")]
        [Validation(Required=false)]
        public string HttpsApplicationConfigurationShrink { get; set; }

        [NameInMap("HttpsBasicConfiguration")]
        [Validation(Required=false)]
        public string HttpsBasicConfigurationShrink { get; set; }

        /// <summary>
        /// <para>The configuration of image transformations.</para>
        /// </summary>
        [NameInMap("ImageTransform")]
        [Validation(Required=false)]
        public string ImageTransformShrink { get; set; }

        /// <summary>
        /// <para>The IPv6 configuration.</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public string Ipv6Shrink { get; set; }

        /// <summary>
        /// <para>The configuration of managed transforms.</para>
        /// </summary>
        [NameInMap("ManagedTransforms")]
        [Validation(Required=false)]
        public string ManagedTransformsShrink { get; set; }

        [NameInMap("NetworkOptimization")]
        [Validation(Required=false)]
        public string NetworkOptimizationShrink { get; set; }

        /// <summary>
        /// <para>The configuration of origin protection.</para>
        /// </summary>
        [NameInMap("OriginProtection")]
        [Validation(Required=false)]
        public string OriginProtectionShrink { get; set; }

        /// <summary>
        /// <para>The configuration of an origin rule.</para>
        /// </summary>
        [NameInMap("OriginRules")]
        [Validation(Required=false)]
        public string OriginRulesShrink { get; set; }

        /// <summary>
        /// <para>The configuration of a redirect rule.</para>
        /// </summary>
        [NameInMap("RedirectRules")]
        [Validation(Required=false)]
        public string RedirectRulesShrink { get; set; }

        /// <summary>
        /// <para>The configuration of a URL rewrite rule.</para>
        /// </summary>
        [NameInMap("RewriteUrlRules")]
        [Validation(Required=false)]
        public string RewriteUrlRulesShrink { get; set; }

        /// <summary>
        /// <para>The configuration of SEO crawler bypassing.</para>
        /// </summary>
        [NameInMap("SeoBypass")]
        [Validation(Required=false)]
        public string SeoBypassShrink { get; set; }

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
        public string SiteNameExclusiveShrink { get; set; }

        /// <summary>
        /// <para>The configuration of temporarily pausing ESA proxy on the website. If you pause ESA proxy, all requests to the domains in your DNS records go directly to your origin server.</para>
        /// </summary>
        [NameInMap("SitePause")]
        [Validation(Required=false)]
        public string SitePauseShrink { get; set; }

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
        public string TieredCacheShrink { get; set; }

    }

}
