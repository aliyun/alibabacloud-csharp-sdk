// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VisionFlowRequest : TeaModel {
        /// <summary>
        /// <para>The AI capabilities to be processed. Valid values: 1 for intelligent element recognition, 2 for intelligent cutout, 3 for intelligent erasure, 4 for image translation Pro, 5 for intelligent cropping, and 6 for high-definition upscaling. You can specify multiple values.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,4]</para>
        /// </summary>
        [NameInMap("Ability")]
        [Validation(Required=false)]
        public List<int?> Ability { get; set; }

        /// <summary>
        /// <para>The background type of the returned image. Valid values: WHITE_BACKGROUND (white background) and TRANSPARENT (transparent background). Required if you select the intelligent cutout capability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE_BACKGROUND</para>
        /// </summary>
        [NameInMap("BackGroundType")]
        [Validation(Required=false)]
        public string BackGroundType { get; set; }

        /// <summary>
        /// <para>The ID of the intervention glossary. Optional. You must create the glossary in the console and provide its ID. If this parameter is empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The URL of the image to be processed. Required. The resolution must be greater than 256×256, the long edge must not exceed 1920 pixels, and the short edge must not exceed 1080 pixels. The maximum size is 5 MB. Supported formats include PNG, JPEG, JPG, BMP, and WEBP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate text on the image subject. Optional. Default value: false. This parameter helps protect embedded information such as product names from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludingProductArea")]
        [Validation(Required=false)]
        public bool? IncludingProductArea { get; set; }

        /// <summary>
        /// <para>Specifies whether to include images with the specified elements in subsequent processing. A value of true indicates that images with the elements are included. A value of false indicates that images with the elements are excluded. Required if you select the intelligent element recognition capability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFilter")]
        [Validation(Required=false)]
        public bool? IsFilter { get; set; }

        /// <summary>
        /// <para>The specific area to remove in Run-Length Encoding (RLE) format. Optional. If specified, this parameter takes precedence, and the ObjectRemoveElements and NonobjectRemoveElements parameters are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474556 160 475356 160</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The elements to detect on the non-subject area of the image. Valid values: 1 for watermark, 2 for logo, 3 for text, and 4 for text block. You can specify multiple values. If you select the intelligent element recognition capability, you must specify at least one of this parameter and ObjectDetectElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3]</para>
        /// </summary>
        [NameInMap("NonobjectDetectElements")]
        [Validation(Required=false)]
        public List<int?> NonobjectDetectElements { get; set; }

        /// <summary>
        /// <para>The elements to remove from the non-subject area of the image. Valid values: 1 for transparent text block, 2 for specific name, 3 for text, and 4 for cluttered text overlay. You can specify multiple values. If you select the intelligent erasure capability, you must specify at least one of this parameter and ObjectRemoveElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,4]</para>
        /// </summary>
        [NameInMap("NonobjectRemoveElements")]
        [Validation(Required=false)]
        public List<int?> NonobjectRemoveElements { get; set; }

        /// <summary>
        /// <para>The elements to detect on the image subject. Valid values: 1 for watermark, 2 for logo, 3 for text, and 4 for text block. You can specify multiple values. If you select the intelligent element recognition capability, you must specify at least one of this parameter and NonobjectDetectElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,4]</para>
        /// </summary>
        [NameInMap("ObjectDetectElements")]
        [Validation(Required=false)]
        public List<int?> ObjectDetectElements { get; set; }

        /// <summary>
        /// <para>The elements to remove from the image subject. Valid values: 1 for transparent text block, 2 for specific name, 3 for text, and 4 for cluttered text overlay. You can specify multiple values. If you select the intelligent erasure capability, you must specify at least one of this parameter and NonobjectRemoveElements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,4]</para>
        /// </summary>
        [NameInMap("ObjectRemoveElements")]
        [Validation(Required=false)]
        public List<int?> ObjectRemoveElements { get; set; }

        /// <summary>
        /// <para>The source language code. Optional. For supported language pairs, see the list of supported translation languages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The expected height of the cropped image in pixels. Valid values: 100 to 5000. Required if you select the intelligent cropping capability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetHeight")]
        [Validation(Required=false)]
        public int? TargetHeight { get; set; }

        /// <summary>
        /// <para>The target language code. Optional. For supported language pairs, see the list of supported translation languages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The expected width of the cropped image in pixels. Valid values: 100 to 5000. Required if you select the intelligent cropping capability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetWidth")]
        [Validation(Required=false)]
        public int? TargetWidth { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate brand names in the image. Optional. Default value: false. This parameter helps protect brand name information from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranslatingBrandInTheProduct")]
        [Validation(Required=false)]
        public bool? TranslatingBrandInTheProduct { get; set; }

        /// <summary>
        /// <para>The image upscaling factor. Optional. Default value: 2. Valid values: 2 to 4. Required if you select the high-definition upscaling capability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UpscaleFactor")]
        [Validation(Required=false)]
        public int? UpscaleFactor { get; set; }

    }

}
