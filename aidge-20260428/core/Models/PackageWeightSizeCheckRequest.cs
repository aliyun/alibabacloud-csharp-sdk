// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class PackageWeightSizeCheckRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the annotated image with manual bounding box markings, which is the original image overlaid with blue or red rectangular bounding box lines. The URL must be publicly accessible. The image must not exceed 4000 × 4000 pixels or 10 MB in size. Supported formats: png, jpeg, and jpg.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/annotated_image.png">https://example.com/annotated_image.png</a></para>
        /// </summary>
        [NameInMap("AnnotatedImageUrl")]
        [Validation(Required=false)]
        public string AnnotatedImageUrl { get; set; }

        /// <summary>
        /// <para>The URL of the raw image, which is the unannotated photo of the parcel on the scanning platform. The URL must be publicly accessible. The image must not exceed 4000 × 4000 pixels or 10 MB in size. Supported formats: png, jpeg, and jpg.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/raw_image.png">https://example.com/raw_image.png</a></para>
        /// </summary>
        [NameInMap("RawImageUrl")]
        [Validation(Required=false)]
        public string RawImageUrl { get; set; }

    }

}
