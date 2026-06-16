// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class PackageWeightSizeCheckRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the annotated image, i.e., the image with blue/red rectangular bounding box lines overlaid on the original image by an operator. The URL must be publicly accessible. The image dimensions must not exceed 4000×4000 pixels, the file size must not exceed 10 MB, and the supported formats are PNG, JPEG, and JPG.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/annotated_image.png">https://example.com/annotated_image.png</a></para>
        /// </summary>
        [NameInMap("AnnotatedImageUrl")]
        [Validation(Required=false)]
        public string AnnotatedImageUrl { get; set; }

        /// <summary>
        /// <para>The URL of the raw image, i.e., the unannotated photo of the parcel on the scanning platform. The URL must be publicly accessible. The image dimensions must not exceed 4000×4000 pixels, the file size must not exceed 10 MB, and the supported formats are PNG, JPEG, and JPG.</para>
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
