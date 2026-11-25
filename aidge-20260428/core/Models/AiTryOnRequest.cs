// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AiTryOnRequest : TeaModel {
        /// <summary>
        /// <para>The list of product image URLs. This parameter is required for single-item and multi-item outfit scenarios.   </para>
        /// <list type="bullet">
        /// <item><description>Single-item try-on: Pass images of the same product from different angles. The standard edition supports up to two product images, but requires that all images contain one and only one main product. We recommend that you use product images with a white background.   </description></item>
        /// <item><description>Multi-item outfit: Pass images of all products to be worn. The standard edition supports up to two product images (each image can contain multiple products). A single outfit can include up to six clothing items and accessories.<br>Note: For the clothing replacement, face replacement, and posture replacement modes, specify only one mode per call. Do not upload parameters for multiple modes at the same time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S3470dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S3470dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ClothImageUrl")]
        [Validation(Required=false)]
        public string ClothImageUrl { get; set; }

        /// <summary>
        /// <para>Specifies the types of products to try on. You can specify multiple types at a time. If you do not specify this parameter, the system automatically identifies all supported categories in the product image.<br>Valid values: tops, outwear, bottoms, dresses, tops and bottoms, socks, shoes, hats, earrings, necklaces, braceles, scarves, bags, and glasses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tops</para>
        /// </summary>
        [NameInMap("ClothType")]
        [Validation(Required=false)]
        public string ClothType { get; set; }

        /// <summary>
        /// <para>The try-on mode, which determines the maximum number of product images and outfit items. Currently, only <c>lite</c> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lite</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The URL of the model scene image. You can specify only one image.   </para>
        /// <list type="bullet">
        /// <item><description>The image must support public network access over HTTP or HTTPS.   </description></item>
        /// <item><description>Supported formats: JPG, JPEG, PNG, BMP, and WEBP.   </description></item>
        /// <item><description>The width and height must be between 256 and 2049 pixels.   </description></item>
        /// <item><description>The size of a single file cannot exceed 10 MB.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/model.jpg%5C">https://example.com/model.jpg\</a></para>
        /// </summary>
        [NameInMap("ModelImageUrl")]
        [Validation(Required=false)]
        public string ModelImageUrl { get; set; }

        /// <summary>
        /// <para>The URL of the model template image. You can specify only one image. This image provides reference identity information such as gender, skin color, age, and body type.<br>This parameter is required for the model skin replacement scenario. Do not specify this parameter for the clothing replacement or posture replacement scenarios. For the clothing replacement, face replacement, and posture replacement modes, specify only one mode per call. Do not upload parameters for multiple modes at the same time.<br>We recommend that you use the official model templates. Experience URL: <a href="https://ecoa.console.aliyun.com/translate?category=assetOptimize&apiType=VirtualTryOn">E-commerce Operation Assistant Aidge console</a></para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxx">https://xxxx</a></para>
        /// </summary>
        [NameInMap("ModelTemplateUrl")]
        [Validation(Required=false)]
        public string ModelTemplateUrl { get; set; }

        /// <summary>
        /// <para>The URL of the posture template image. You can specify only one image. This image provides a reference for the person&quot;s posture.
        /// This parameter is required for the posture fission scenario.
        /// If this parameter is specified, the image is generated based on the template posture.
        /// If this parameter is not specified, the posture in the scene image is used if a model scene image is provided. Otherwise, the posture in the model source image is preserved.
        /// Note: For the clothing replacement, face replacement, and posture replacement modes, specify only one mode per call. Do not upload parameters for multiple modes at the same time.
        /// We recommend that you use the official posture templates. Experience URL: <a href="https://ecoa.console.aliyun.com/translate?category=assetOptimize&apiType=VirtualTryOn">E-commerce Operation Assistant Aidge console</a></para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxx">https://xxxx</a></para>
        /// </summary>
        [NameInMap("PoseTemplateUrl")]
        [Validation(Required=false)]
        public string PoseTemplateUrl { get; set; }

        /// <summary>
        /// <para>The aspect ratio of the output image. By default, the aspect ratio is the same as that of the original image specified by ModelImageUrl. Valid values: 1:1, 2:3, 3:4, and 9:16.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1:1</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public string Ratio { get; set; }

        /// <summary>
        /// <para>The resolution of the output image.</para>
        /// <list type="bullet">
        /// <item><description>Synchronous API: supports 1K.</description></item>
        /// <item><description>Asynchronous API: supports 1K and 2K. The asynchronous API only supports single-item outfit scenarios.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1K</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only in try-on scenarios and specifies the number of products to try on. Default value: <c>singletryon</c>.<br>Valid values:   </para>
        /// <list type="bullet">
        /// <item><description><c>singletryon</c>: single-item try-on.   </description></item>
        /// <item><description><c>multitryon</c>: multi-item outfit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>singletryon</para>
        /// </summary>
        [NameInMap("TryonType")]
        [Validation(Required=false)]
        public string TryonType { get; set; }

    }

}
