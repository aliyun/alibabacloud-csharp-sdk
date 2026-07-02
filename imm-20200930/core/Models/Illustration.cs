// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Illustration : TeaModel {
        /// <summary>
        /// <para>The index of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ImageIndex")]
        [Validation(Required=false)]
        public int? ImageIndex { get; set; }

        /// <summary>
        /// <para>The relative path of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;imgs/page_0_img_image_box_770_540_1367_860.png&quot;</para>
        /// </summary>
        [NameInMap("ImagePath")]
        [Validation(Required=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// <para>The normalized coordinate of the image on the page.</para>
        /// </summary>
        [NameInMap("NormalizedBox")]
        [Validation(Required=false)]
        public List<float?> NormalizedBox { get; set; }

        /// <summary>
        /// <para>The page number on which the image is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The text result recognized by optical character recognition (OCR) from the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;图片&quot;</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The type of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image、table、code</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
