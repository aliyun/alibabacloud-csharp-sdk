// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageUpscaleRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the original image. It must be a publicly accessible image URL and cannot be a private network address such as localhost. The width and height of the input image must be greater than 100 pixels and less than 3000 pixels. The width and height of the upscaled image must not exceed 3000 pixels.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.jpg">http://example.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The upscale factor of the image. Valid values: 2 and 4. Default value: 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UpscaleFactor")]
        [Validation(Required=false)]
        public int? UpscaleFactor { get; set; }

    }

}
