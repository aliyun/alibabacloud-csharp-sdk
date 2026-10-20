// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VirtualTryOnRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the garment image. Only one image is supported. The URL must be a publicly accessible <c>http</c>/<c>https</c> address. The image must be in JPG, JPEG, PNG, BMP, or WEBP format, with a resolution between 256 × 256 and 2049 × 2049 pixels, and a file size of no more than 10 MB.<br></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ClothImageUrl")]
        [Validation(Required=false)]
        public string ClothImageUrl { get; set; }

        /// <summary>
        /// <para>The garment type. Valid values: tops, bottoms, dresses, tops_and_bottoms, shoes, and hats. If this parameter is not specified, the system automatically identifies the garment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tops</para>
        /// </summary>
        [NameInMap("ClothType")]
        [Validation(Required=false)]
        public string ClothType { get; set; }

        /// <summary>
        /// <para>The URL of the model image. Only one image is supported. The URL must be a publicly accessible <c>http</c>/<c>https</c> address. The image must be in JPG, JPEG, PNG, BMP, or WEBP format, with a resolution between 256 × 256 and 2049 × 2049 pixels, and a file size of no more than 10 MB.<br></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ModelImageUrl")]
        [Validation(Required=false)]
        public string ModelImageUrl { get; set; }

        /// <summary>
        /// <para>Required. The image resolution. Valid values: 1K and 2K.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1K</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

    }

}
