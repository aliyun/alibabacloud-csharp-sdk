// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class EcomVideoRecreationRequest : TeaModel {
        /// <summary>
        /// <para>The input parameters for video variation generation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public EcomVideoRecreationRequestInput Input { get; set; }
        public class EcomVideoRecreationRequestInput : TeaModel {
            /// <summary>
            /// <para>The description or supplementary constraints for the target character during character replacement. The length is 1 to 500 characters. This parameter is required if PersonReferenceImageUrls is not provided. Example: The target character is an adult male, retaining the original clothing and actions.</para>
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
            /// <para>The URLs of the reference images for the target character during character replacement. You can provide 1 to 5 images, which must be of the same character. Arrange them in the order of facial close-up, front, 45-degree angle, side, and back. Example: <c>[&quot;https://example.com/person.jpg&quot;]</c>.</para>
            /// </summary>
            [NameInMap("PersonReferenceImageUrls")]
            [Validation(Required=false)]
            public List<string> PersonReferenceImageUrls { get; set; }

            /// <summary>
            /// <para>Required for product replacement. The URLs of the target product images. You can upload 1 to 8 images for the same SKU. Provide images with clear main subjects, no occlusions, and clean backgrounds. Example: <c>[&quot;https://example.com/product.png&quot;]</c>.</para>
            /// </summary>
            [NameInMap("ProductImageUrls")]
            [Validation(Required=false)]
            public List<string> ProductImageUrls { get; set; }

            /// <summary>
            /// <para>The target product information. Providing this parameter is recommended to improve voiceover accuracy.</para>
            /// </summary>
            [NameInMap("ProductInfo")]
            [Validation(Required=false)]
            public EcomVideoRecreationRequestInputProductInfo ProductInfo { get; set; }
            public class EcomVideoRecreationRequestInputProductInfo : TeaModel {
                /// <summary>
                /// <para>The product category. Example: Women&quot;s clothing/Sun-protective clothing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Women&quot;s clothing/sun protection clothing</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The actual product information, such as SKU, brand, color, material, size, specifications, logo, and usage instructions. This is used to constrain voiceover facts. Example: Pale yellow, cooling fabric, sun protection down to the back of the hand, UPF50+.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Light moon yellow, cool-touch fabric, sun protection extending to the back of the hand, UPF50+</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>Required for product replacement. The name of the target product to be replaced. Maximum length: 200 characters. Example: Pale yellow cooling sun-protective clothing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Light moon yellow cool-touch sun protection clothing</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The generation method. Default value: <c>reference</c>. Valid values: <c>reference</c> (directly references the original video) and <c>rebuild</c> (breaks down the original video before regenerating).</para>
            /// 
            /// <b>Example:</b>
            /// <para>reference</para>
            /// </summary>
            [NameInMap("RecreateMode")]
            [Validation(Required=false)]
            public string RecreateMode { get; set; }

            /// <summary>
            /// <para>The HTTP(S) URL of the reference video. The duration ranges from 2 to 360 seconds. The URL must remain accessible during task execution. A validity period of at least 24 hours is recommended.</para>
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
            /// <para>The target duration in seconds. In <c>reference</c> mode, the input value is ignored and forced to -1, following the original video duration. In <c>rebuild</c> mode, you can pass an integer from 5 to 60, or -1 for automatic duration.</para>
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
