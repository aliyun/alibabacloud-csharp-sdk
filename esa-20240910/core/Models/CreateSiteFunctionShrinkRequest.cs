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

        [NameInMap("CacheRules")]
        [Validation(Required=false)]
        public string CacheRulesShrink { get; set; }

        [NameInMap("CacheTags")]
        [Validation(Required=false)]
        public string CacheTagsShrink { get; set; }

        [NameInMap("CnameFlattening")]
        [Validation(Required=false)]
        public string CnameFlatteningShrink { get; set; }

        [NameInMap("CompressionRules")]
        [Validation(Required=false)]
        public string CompressionRulesShrink { get; set; }

        [NameInMap("CrossBorderOptimization")]
        [Validation(Required=false)]
        public string CrossBorderOptimizationShrink { get; set; }

        [NameInMap("DevelopmentMode")]
        [Validation(Required=false)]
        public string DevelopmentModeShrink { get; set; }

        [NameInMap("HttpRequestHeaderModificationRules")]
        [Validation(Required=false)]
        public string HttpRequestHeaderModificationRulesShrink { get; set; }

        [NameInMap("HttpResponseHeaderModificationRules")]
        [Validation(Required=false)]
        public string HttpResponseHeaderModificationRulesShrink { get; set; }

        [NameInMap("HttpsApplicationConfiguration")]
        [Validation(Required=false)]
        public string HttpsApplicationConfigurationShrink { get; set; }

        [NameInMap("HttpsBasicConfiguration")]
        [Validation(Required=false)]
        public string HttpsBasicConfigurationShrink { get; set; }

        [NameInMap("ImageTransform")]
        [Validation(Required=false)]
        public string ImageTransformShrink { get; set; }

        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public string Ipv6Shrink { get; set; }

        [NameInMap("ManagedTransforms")]
        [Validation(Required=false)]
        public string ManagedTransformsShrink { get; set; }

        [NameInMap("NetworkOptimization")]
        [Validation(Required=false)]
        public string NetworkOptimizationShrink { get; set; }

        [NameInMap("OriginProtection")]
        [Validation(Required=false)]
        public string OriginProtectionShrink { get; set; }

        [NameInMap("OriginRules")]
        [Validation(Required=false)]
        public string OriginRulesShrink { get; set; }

        [NameInMap("RedirectRules")]
        [Validation(Required=false)]
        public string RedirectRulesShrink { get; set; }

        [NameInMap("RewriteUrlRules")]
        [Validation(Required=false)]
        public string RewriteUrlRulesShrink { get; set; }

        [NameInMap("SeoBypass")]
        [Validation(Required=false)]
        public string SeoBypassShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateSiteFunction</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        [NameInMap("SiteNameExclusive")]
        [Validation(Required=false)]
        public string SiteNameExclusiveShrink { get; set; }

        [NameInMap("SitePause")]
        [Validation(Required=false)]
        public string SitePauseShrink { get; set; }

        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        [NameInMap("TieredCache")]
        [Validation(Required=false)]
        public string TieredCacheShrink { get; set; }

    }

}
