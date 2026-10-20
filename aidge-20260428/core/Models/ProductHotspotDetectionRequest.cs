// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ProductHotspotDetectionRequest : TeaModel {
        /// <summary>
        /// <para>The HTTPS URLs of reference images that define the SKU whitelist. A maximum of 20 images are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReferenceImageUrls")]
        [Validation(Required=false)]
        public List<string> ReferenceImageUrls { get; set; }

        /// <summary>
        /// <para>The unique business ID for this single-scene call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hotspot-request-001</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        /// <summary>
        /// <para>The HTTPS OSS or CDN URL of the target image to be annotated with bounding boxes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/scene.jpg">https://example.com/scene.jpg</a></para>
        /// </summary>
        [NameInMap("TargetImageUrl")]
        [Validation(Required=false)]
        public string TargetImageUrl { get; set; }

    }

}
