// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRecognitionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image to recognize.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://fb-es.mrvcdn.com/kf/E6332bde0101849968532c4f08dac757cZ.jpg">https://fb-es.mrvcdn.com/kf/E6332bde0101849968532c4f08dac757cZ.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The list of non-subject element types to detect. Valid values: 1 (background), 2 (border), 3 (watermark), and 4 (collage).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,4]</para>
        /// </summary>
        [NameInMap("NonObjectDetectElements")]
        [Validation(Required=false)]
        public string NonObjectDetectElementsShrink { get; set; }

        /// <summary>
        /// <para>The list of subject element types to detect. Valid values: 1 (product subject), 2 (model), 3 (text), and 4 (logo).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,4]</para>
        /// </summary>
        [NameInMap("ObjectDetectElements")]
        [Validation(Required=false)]
        public string ObjectDetectElementsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to return border pixel information. Valid values: 1 (return) and 0 (do not return).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnBorderPixel")]
        [Validation(Required=false)]
        public int? ReturnBorderPixel { get; set; }

        /// <summary>
        /// <para>Specifies whether to return text information. Valid values: 1 (return) and 0 (do not return).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnCharacter")]
        [Validation(Required=false)]
        public int? ReturnCharacter { get; set; }

        /// <summary>
        /// <para>Specifies whether to return text property information. Valid values: 1 (return) and 0 (do not return).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnCharacterProp")]
        [Validation(Required=false)]
        public int? ReturnCharacterProp { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the product count. Valid values: 1 (return) and 0 (do not return).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnProductNum")]
        [Validation(Required=false)]
        public int? ReturnProductNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to return product property information. Valid values: 1 (return) and 0 (do not return).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnProductProp")]
        [Validation(Required=false)]
        public int? ReturnProductProp { get; set; }

    }

}
