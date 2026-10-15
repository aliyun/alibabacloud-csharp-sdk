// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRecognitionAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image. The image must be in JPG, JPEG, PNG, BMP, or WEBP format. The resolution must be between 256 × 256 and 3000 × 3000 pixels, and the file size cannot exceed 10 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Specifies the types of elements to be detected outside the image subject. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Watermark.</description></item>
        /// <item><description>2: Logo.</description></item>
        /// <item><description>3: Text.</description></item>
        /// <item><description>4: Text-containing color block.
        /// You can specify multiple element types. This parameter and ObjectDetectElements cannot be empty at the same time.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NonObjectDetectElements")]
        [Validation(Required=false)]
        public List<int?> NonObjectDetectElements { get; set; }

        /// <summary>
        /// <para>Specifies the types of elements to be detected on the image subject. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Watermark.</description></item>
        /// <item><description>2: Logo.</description></item>
        /// <item><description>3: Text.</description></item>
        /// <item><description>4: Text-containing color block.
        /// You can specify multiple element types.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ObjectDetectElements")]
        [Validation(Required=false)]
        public List<int?> ObjectDetectElements { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the marginalization distance of the subject. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Yes.</description></item>
        /// <item><description>0: No.
        /// Default value: 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnBorderPixel")]
        [Validation(Required=false)]
        public int? ReturnBorderPixel { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the OCR results of the text in the recognized area. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Yes.</description></item>
        /// <item><description>0: No.
        /// Default value: 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnCharacter")]
        [Validation(Required=false)]
        public int? ReturnCharacter { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the text proportion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Yes.</description></item>
        /// <item><description>0: No.
        /// Default value: 0.
        /// This parameter takes effect only when the following two conditions are met:</description></item>
        /// </list>
        /// <ol>
        /// <item><description>ReturnCharacter is set to 1.</description></item>
        /// <item><description>ObjectDetectElements or NonObjectDetectElements is set to 3, which means text recognition is required.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnCharacterProp")]
        [Validation(Required=false)]
        public int? ReturnCharacterProp { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the number of subjects. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Yes.</description></item>
        /// <item><description>0: No.
        /// Default value: 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnProductNum")]
        [Validation(Required=false)]
        public int? ReturnProductNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the area proportion of the subject. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Yes.</description></item>
        /// <item><description>0: No.
        /// Default value: 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnProductProp")]
        [Validation(Required=false)]
        public int? ReturnProductProp { get; set; }

    }

}
