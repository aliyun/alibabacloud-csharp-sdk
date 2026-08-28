// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemoveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the original image. The image must be in JPG, JPEG, PNG, BMP, or WEBP format, with a resolution between 256 × 256 and 3000 × 3000 pixels, and a file size no larger than 10 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/bao/uploaded/i2/xxx.jpg">https://img.alicdn.com/bao/uploaded/i2/xxx.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The specific removal area. This parameter must be used with the editor. The input format is RLE.
        /// If provided, this takes priority and the remove_non_product_area_elements and remove_product_area_elements parameters are ignored. This parameter is not required, but at least one of the following parameters must be specified: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, or UserImage.
        /// When multiple parameters are specified, the priority order is: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;474556 160 475356 160 476156 160 476956 160 477756 160 478556 160 479356 160 480156 160 480956 160 481756 160 482556 160 483356 160 484156 160 484956 160 485756 160 486556 160 487356 160 488156 160 488956 160 489756 160 490556 160 491356 160 492156 160&quot;</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The elements to remove from the non-subject area of the image (1=transparent text blocks, 2=specific names, 3=text, 4=visual clutter). Multiple element types can be selected. This parameter is not required, but at least one of the following parameters must be specified: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, or UserImage.
        /// When multiple parameters are specified, the priority order is: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements.
        /// Refer to the product description for details on each type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("NonObjectRemoveElements")]
        [Validation(Required=false)]
        public string NonObjectRemoveElementsShrink { get; set; }

        /// <summary>
        /// <para>The elements to remove from the image subject (1=transparent text blocks, 2=specific names, 3=text, 4=visual clutter). Multiple element types can be selected. This parameter is not required, but at least one of the following parameters must be specified: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, or UserImage.
        /// When multiple parameters are specified, the priority order is: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements.
        /// Refer to the product description for details on each type.
        /// Image subject: The core product area in the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("ObjectRemoveElements")]
        [Validation(Required=false)]
        public string ObjectRemoveElementsShrink { get; set; }

        /// <summary>
        /// <para>The specific removal area. This parameter must be used with the editor. The input format is four-point coordinates [xx,yy,zz,dd]. This parameter is not required, but at least one of the following parameters must be specified: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, or UserImage.
        /// When multiple parameters are specified, the priority order is: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10,10,100,100]</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        /// <summary>
        /// <para>The user-specified image element links to remove. Multiple image links are supported. The input format is [&quot;<a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg%22,%22https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg%22%5D">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg&quot;,&quot;https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg&quot;]</a>. This parameter is not required, but at least one of the following parameters must be specified: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, or UserImage.
        /// When multiple parameters are specified, the priority order is: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://img.alicdn.com/bao/uploaded/i2/xxx.jpg%22%5D">https://img.alicdn.com/bao/uploaded/i2/xxx.jpg&quot;]</a></para>
        /// </summary>
        [NameInMap("UserImage")]
        [Validation(Required=false)]
        public string UserImageShrink { get; set; }

        /// <summary>
        /// <para>The user-specified text to remove. Multiple text inputs are supported. The input format is [&quot;xx&quot;,&quot;yy&quot;]. This parameter is not required, but at least one of the following parameters must be specified: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, or UserImage.
        /// When multiple parameters are specified, the priority order is: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;xx&quot;,&quot;yy&quot;]</para>
        /// </summary>
        [NameInMap("UserText")]
        [Validation(Required=false)]
        public string UserTextShrink { get; set; }

    }

}
