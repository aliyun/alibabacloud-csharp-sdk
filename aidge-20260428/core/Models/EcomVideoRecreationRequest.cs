// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class EcomVideoRecreationRequest : Darabonba.Model {
        /// <summary>
        /// <para>The input parameters for video variation generation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public EcomVideoRecreationRequestInput Input { get; set; }
        public class EcomVideoRecreationRequestInput : Darabonba.Model {
            /// <summary>
            /// <para>The description or supplementary constraints for the target person in person replacement. The length is 1 to 500 characters. This parameter is required when PersonReferenceImageUrls is not provided.<br>Example value: The target person is an adult male, retaining the original clothing and actions.</para>
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
            /// <para>The URLs of the reference images for the target person in person replacement. You can provide 1 to 5 images, which must be of the same person. We recommend that you arrange the images in the order of facial close-up, front, 45-degree angle, side, and back.<br>Example value: [&quot;<a href="https://example.com/person.jpg%22%5D">https://example.com/person.jpg&quot;]</a></para>
            /// </summary>
            [NameInMap("PersonReferenceImageUrls")]
            [Validation(Required=false)]
            public List<string> PersonReferenceImageUrls { get; set; }

            /// <summary>
            /// <para>The URLs of the target product images. This parameter is required for product replacement. You can upload 1 to 8 images for the same SKU. We recommend that the main subject is clear, unobstructed, and has a clean background.<br>Example value: [&quot;<a href="https://example.com/product.png%22%5D">https://example.com/product.png&quot;]</a></para>
            /// </summary>
            [NameInMap("ProductImageUrls")]
            [Validation(Required=false)]
            public List<string> ProductImageUrls { get; set; }

            /// <summary>
            /// <para>The target product information. We recommend that you specify this parameter to improve the accuracy of the voiceover.</para>
            /// </summary>
            [NameInMap("ProductInfo")]
            [Validation(Required=false)]
            public EcomVideoRecreationRequestInputProductInfo ProductInfo { get; set; }
            public class EcomVideoRecreationRequestInputProductInfo : Darabonba.Model {
                /// <summary>
                /// <para>The product category.<br>Example value: Women\&quot;s clothing/Sun protection clothing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Women\&quot;s clothing/sun protection clothing</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The actual product information, such as SKU, brand, color, material, size, specifications, logo, and usage instructions. This information is used to constrain the facts in the voiceover.<br>Example value: Pale moon yellow, cool-touch fabric, sun protection down to the back of the hand, UPF50+</para>
                /// 
                /// <b>Example:</b>
                /// <para>Light moon yellow, cool-touch fabric, sun protection extending to the back of the hand, UPF50+</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The name of the target product. This parameter is required for product replacement. The maximum length is 200 characters.<br>Example value: Pale moon yellow cool-touch sun protection clothing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Light moon yellow cool-touch sun protection clothing</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The generation mode. Default value: <c>reference</c>. Valid values: <c>reference</c> (directly references the original video) and <c>rebuild</c> (breaks down the original video before regenerating it).</para>
            /// 
            /// <b>Example:</b>
            /// <para>reference</para>
            /// </summary>
            [NameInMap("RecreateMode")]
            [Validation(Required=false)]
            public string RecreateMode { get; set; }

            /// <summary>
            /// <para>The HTTP(S) URL of the reference video. The duration ranges from 2 to 360 seconds. The URL must remain accessible during task execution. We recommend that the validity period is no less than 24 hours.</para>
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
        /// <para>The output specifications for the generated video.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public EcomVideoRecreationRequestOutput Output { get; set; }
        public class EcomVideoRecreationRequestOutput : Darabonba.Model {
            /// <summary>
            /// <para>The target duration in seconds. In <c>reference</c> mode, the input value is ignored and forced to -1, which follows the duration of the original video. In <c>rebuild</c> mode, you can pass an integer from 5 to 60, or pass -1 to indicate an automatic duration.</para>
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

