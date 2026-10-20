// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemoveAsyncRequest : Darabonba.Model {
        /// <summary>
        /// <para>The URL of the original image. The image must be in JPG, JPEG, PNG, BMP, or WEBP format. The resolution must be between 256 × 256 and 3000 × 3000 pixels, and the file size must not exceed 10 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;<a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a>&quot;</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The specific area to erase. This parameter must be used in conjunction with the editor, and the input format is RLE. If this parameter is specified, it takes precedence and the remove_non_product_area_elements and remove_product_area_elements parameters are ignored. This parameter is not required, but you must specify at least one of the following parameters: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, and UserImage. If multiple parameters are specified, the priority is as follows: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;474556 160 475356 160 476156 160 476956 160 477756 160 478556 160 479356 160 480156 160 480956 160 481756 160 482556 160 483356 160 484156 160 484956 160 485756 160 486556 160 487356 160 488156 160 488956 160 489756 160 490556 160 491356 160 492156 160&quot;</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The list of element types to remove from the non-subject area of the image.</para>
        /// </summary>
        [NameInMap("NonObjectRemoveElements")]
        [Validation(Required=false)]
        public List<int?> NonObjectRemoveElements { get; set; }

        /// <summary>
        /// <para>The types of elements to remove from the image subject. Valid values: 1 (transparent text blocks), 2 (specific names), 3 (text), and 4 (watermarks). You can select multiple element types. This parameter is not required, but you must specify at least one of the following parameters: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, and UserImage. If multiple parameters are specified, the priority is as follows: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements. For more information about each type, see the product documentation. Image subject: the core product area in the image.</para>
        /// </summary>
        [NameInMap("ObjectRemoveElements")]
        [Validation(Required=false)]
        public List<int?> ObjectRemoveElements { get; set; }

        /// <summary>
        /// <para>The specific area to erase. This parameter must be used in conjunction with the editor, and the input format is four-point coordinates [xx,yy,zz,dd]. This parameter is not required, but you must specify at least one of the following parameters: ObjectRemoveElements, NonObjectRemoveElements, Mask, Position, UserText, and UserImage. If multiple parameters are specified, the priority is as follows: UserImage &gt; UserText &gt; Position &gt; Mask &gt; ObjectRemoveElements = NonObjectRemoveElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10,20,100,200]</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        /// <summary>
        /// <para>The list of URLs for user-specified image elements to erase.</para>
        /// </summary>
        [NameInMap("UserImage")]
        [Validation(Required=false)]
        public List<string> UserImage { get; set; }

        /// <summary>
        /// <para>The list of user-specified texts to erase.</para>
        /// </summary>
        [NameInMap("UserText")]
        [Validation(Required=false)]
        public List<string> UserText { get; set; }

    }

}

