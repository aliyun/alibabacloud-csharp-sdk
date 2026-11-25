// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class GeneralImageGenerationRequest : TeaModel {
        /// <summary>
        /// <para>The task type. Select the generation method.<br>text_to_image: Generate images using only text descriptions.<br>image_to_image: Generate or edit images based on existing images.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text_to_image</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The generation mode. The lite mode is faster and more cost-effective. The plus mode produces finer visual effects and supports more reference images.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lite</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The number of images generated per call. Valid values: 1 to 4. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("N")]
        [Validation(Required=false)]
        public int? N { get; set; }

        /// <summary>
        /// <para>The specific operation for image generation or editing. Only one operation can be selected. Valid values:<br>[general] scenario</para>
        /// <list type="bullet">
        /// <item><description><para>general_generate (General generation)</para>
        /// </description></item>
        /// <item><description><para>outpaint (AI outpainting)</para>
        /// </description></item>
        /// </list>
        /// <para>[product_ecommerce] scenario</para>
        /// <list type="bullet">
        /// <item><description><para>scene_generate (Scene image generation)</para>
        /// </description></item>
        /// <item><description><para>product_replace (Product replacement)</para>
        /// </description></item>
        /// </list>
        /// <para>[cloth_ecommerce] scenario</para>
        /// <list type="bullet">
        /// <item><description>model_generate (Model image generation)</description></item>
        /// </list>
        /// <para>[product_ecommerce] scenario &amp; [cloth_ecommerce] scenario</para>
        /// <list type="bullet">
        /// <item><description><para>detail_generate (Detail image generation)</para>
        /// </description></item>
        /// <item><description><para>selling_point_generate (Selling point image generation)</para>
        /// </description></item>
        /// <item><description><para>scene_variation (Scene variation)</para>
        /// </description></item>
        /// <item><description><para>subject_extract (Subject extraction)</para>
        /// </description></item>
        /// <item><description><para>recolor (Recolor)</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>generate_generate</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The content of the image you want to generate. Enter only one prompt, up to 5,000 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A white ceramic cup placed in a simple studio background</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Specifies whether automatic optimization is enabled for the entered prompt. When the optimization is enabled, it completes image details to make the generated effect closer to the description. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PromptExtend")]
        [Validation(Required=false)]
        public bool? PromptExtend { get; set; }

        /// <summary>
        /// <para>The aspect ratio of the image. Valid values: 1:1, 2:3, 3:2, 4:3, 3:4, 16:9, and 9:16. Default value: 1:1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1:1</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public string Ratio { get; set; }

        /// <summary>
        /// <para>The URLs of the reference images. Enter publicly accessible links.
        /// Used only for image-to-image generation. Not supported for text-to-image generation.
        /// The number of images that can be uploaded varies by mode: up to 3 images in lite mode, and up to 9 images in plus mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://example.com/referece.jpg%22%5D">https://example.com/referece.jpg&quot;]</a></para>
        /// </summary>
        [NameInMap("ReferenceUrl")]
        [Validation(Required=false)]
        public List<string> ReferenceUrl { get; set; }

        /// <summary>
        /// <para>The resolution of the output image. Valid values: 1K and 2K. Default value: 1K.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1K</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The scenario. Valid values: general (general scenario), product_ecommerce (general product scenario), and cloth_ecommerce (apparel and accessories scenario). Only one scenario can be selected.</para>
        /// <list type="bullet">
        /// <item><description><para>If the task type is text_to_image, only general is supported.</para>
        /// </description></item>
        /// <item><description><para>If the task type is image_to_image, general, product_ecommerce, and cloth_ecommerce are supported.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>general</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>Specifies whether to add a watermark to the generated image. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public bool? Watermark { get; set; }

    }

}
