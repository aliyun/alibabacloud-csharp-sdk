// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class EcomVideoRecreationRequest : TeaModel {
        /// <summary>
        /// <para>The input parameters for video multiplication.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public EcomVideoRecreationRequestInput Input { get; set; }
        public class EcomVideoRecreationRequestInput : TeaModel {
            /// <summary>
            /// <para>The description or supplementary constraints for the target person in person replacement mode. The value must be 1 to 500 characters in length. This parameter is required if PersonReferenceImageUrls is not provided.<br>Example: The target person is an adult male. Retain the original clothing and actions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The target character is an adult male, with the original costume and movements preserved.</para>
            /// </summary>
            [NameInMap("ChangeDescription")]
            [Validation(Required=false)]
            public string ChangeDescription { get; set; }

            /// <summary>
            /// <para>The replacement mode. Valid values: <c>product_replacement</c> (default) and <c>person_replacement</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product_replacement</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The URLs of reference images for the target person in person replacement mode. You can specify 1 to 5 images, which must be of the same person. Arrange the images in the following order: facial close-up, front view, 45-degree view, side view, and back view.<br>Example: [&quot;<a href="https://example.com/person.jpg%22%5D">https://example.com/person.jpg&quot;]</a></para>
            /// </summary>
            [NameInMap("PersonReferenceImageUrls")]
            [Validation(Required=false)]
            public List<string> PersonReferenceImageUrls { get; set; }

            /// <summary>
            /// <para>The URLs of target product images. This parameter is required for product replacement mode. You can upload 1 to 8 images for the same SKU. Use images with a clear subject, no occlusion, and a clean background.<br>Example: [&quot;<a href="https://example.com/product.png%22%5D">https://example.com/product.png&quot;]</a></para>
            /// </summary>
            [NameInMap("ProductImageUrls")]
            [Validation(Required=false)]
            public List<string> ProductImageUrls { get; set; }

            /// <summary>
            /// <para>The target product information. Specify this parameter to improve voiceover accuracy.</para>
            /// </summary>
            [NameInMap("ProductInfo")]
            [Validation(Required=false)]
            public EcomVideoRecreationRequestInputProductInfo ProductInfo { get; set; }
            public class EcomVideoRecreationRequestInputProductInfo : TeaModel {
                /// <summary>
                /// <para>The product category.<br>Example: Womenswear/Sun-protective clothing</para>
                /// 
                /// <b>Example:</b>
                /// <para>Women\&quot;s clothing/sun protection clothing</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The actual product information (SKU, brand, color, material, size, specifications, logo, and usage), used to constrain voiceover facts.<br>Example: Light yellow, cooling fabric, sun protection to the back of the hand, UPF50+</para>
                /// 
                /// <b>Example:</b>
                /// <para>Light moon yellow, cool-touch fabric, sun protection extending to the back of the hand, UPF50+</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The name of the target product. This parameter is required for product replacement mode. Maximum length: 200 characters.<br>Example: Light yellow cooling sun-protective jacket</para>
                /// 
                /// <b>Example:</b>
                /// <para>Light moon yellow cool-touch sun protection clothing</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The HTTP(S) URL of the reference video. The video duration must be 2 to 360 seconds. The URL must remain accessible during task execution. A validity period of at least 24 hours is recommended.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/source.mp4">https://example.com/source.mp4</a></para>
            /// </summary>
            [NameInMap("SourceVideoUrl")]
            [Validation(Required=false)]
            public string SourceVideoUrl { get; set; }

        }

        /// <summary>
        /// <para>The output specifications for the final video.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public EcomVideoRecreationRequestOutput Output { get; set; }
        public class EcomVideoRecreationRequestOutput : TeaModel {
            /// <summary>
            /// <para>The target duration in seconds. Set to <c>&quot;auto&quot;</c> (default) to let the system decide. For product replacement, specify an integer from 5 to 60. For person replacement, only <c>&quot;auto&quot;</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The output resolution. Default value: <c>720p</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720p、1080p</para>
            /// </summary>
            [NameInMap("Quality")]
            [Validation(Required=false)]
            public string Quality { get; set; }

            /// <summary>
            /// <para>The output aspect ratio. Default value: <c>auto</c> (automatically matches the original video).</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto、9:16、3:4、1:1、4:3、16:9</para>
            /// </summary>
            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

        }

    }

}
