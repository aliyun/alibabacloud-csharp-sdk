// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRecognitionAsyncShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business order number of the caller. It is recorded upon acceptance and returned as is when querying the asynchronous task result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-20260928-001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The URL of the image. The image must be in JPG, JPEG, PNG, BMP, or WEBP format. The resolution must be between 256 × 256 and 3000 × 3000 pixels, and the file size must not exceed 10 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Specifies the types of elements to detect outside the image subject. Valid values: 1: Watermark. 2: Logo. 3: Text. 4: Text-containing color block. You can specify multiple values. This parameter and ObjectDetectElements cannot be empty at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,4]</para>
        /// </summary>
        [NameInMap("NonObjectDetectElements")]
        [Validation(Required=false)]
        public string NonObjectDetectElementsShrink { get; set; }

        /// <summary>
        /// <para>Specifies the types of elements to detect on the image subject. Valid values: 1: Watermark. 2: Logo. 3: Text. 4: Text-containing color block. You can specify multiple values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,4]</para>
        /// </summary>
        [NameInMap("ObjectDetectElements")]
        [Validation(Required=false)]
        public string ObjectDetectElementsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the marginalization distance of the subject. Valid values: 1: Yes. 0: No. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnBorderPixel")]
        [Validation(Required=false)]
        public int? ReturnBorderPixel { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the OCR results of the text in the recognized area. Valid values: 1: Yes. 0: No. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnCharacter")]
        [Validation(Required=false)]
        public int? ReturnCharacter { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the text proportion. Valid values: 1: Yes. 0: No. Default value: 0. This parameter takes effect only when the following two conditions are met: 1. ReturnCharacter is set to 1. 2. ObjectDetectElements or NonObjectDetectElements is set to 3, which means text recognition is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnCharacterProp")]
        [Validation(Required=false)]
        public int? ReturnCharacterProp { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the number of subjects. Valid values: 1: Yes. 0: No. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnProductNum")]
        [Validation(Required=false)]
        public int? ReturnProductNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the area proportion of the subject. Valid values: 1: Yes. 0: No. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnProductProp")]
        [Validation(Required=false)]
        public int? ReturnProductProp { get; set; }

    }

}
