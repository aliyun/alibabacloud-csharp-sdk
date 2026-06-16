// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VisionFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The AI capabilities to apply (1 = intelligent element detection, 2 = intelligent matting, 3 = intelligent removal, 4 = Image Translation Pro, 5 = intelligent cropping, 6 = HD upscaling). Multiple selections allowed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,4]</para>
        /// </summary>
        [NameInMap("Ability")]
        [Validation(Required=false)]
        public string AbilityShrink { get; set; }

        /// <summary>
        /// <para>The background type of the returned image. Valid values: WHITE_BACKGROUND (white background) and TRANSPARENT (transparent background). Required when the intelligent matting capability is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE_BACKGROUND</para>
        /// </summary>
        [NameInMap("BackGroundType")]
        [Validation(Required=false)]
        public string BackGroundType { get; set; }

        /// <summary>
        /// <para>The intervention glossary ID. Optional. Create a glossary separately in the console and provide its ID. If left empty, translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The URL of the image to process. Required. The resolution must be greater than 256 × 256, the long side must not exceed 1920 pixels, and the short side must not exceed 1080 pixels. The file size must not exceed 5 MB. Supported formats: png, jpeg, jpg, bmp, and webp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate text on the image subject. Optional. Default value: false. Helps protect embedded information such as product names from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludingProductArea")]
        [Validation(Required=false)]
        public bool? IncludingProductArea { get; set; }

        /// <summary>
        /// <para>Specifies whether images with the detected elements proceed to subsequent processing. A value of true indicates that images containing the elements proceed to subsequent processing. A value of false indicates that they do not. Required when the intelligent element detection capability is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFilter")]
        [Validation(Required=false)]
        public bool? IsFilter { get; set; }

        /// <summary>
        /// <para>The specific removal area in RLE format. Optional. If provided, this parameter takes priority and the ObjectRemoveElements and NonobjectRemoveElements parameters are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474556 160 475356 160</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The elements to detect on the non-subject area of the image (1 = watermark, 2 = logo, 3 = text, 4 = text-bearing color block). Multiple selections allowed. When the intelligent element detection capability is selected, at least one of NonobjectDetectElements and ObjectDetectElements is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3]</para>
        /// </summary>
        [NameInMap("NonobjectDetectElements")]
        [Validation(Required=false)]
        public string NonobjectDetectElementsShrink { get; set; }

        /// <summary>
        /// <para>The elements to remove from the non-subject area of the image (1 = transparent text block, 2 = specific name, 3 = text, 4 = overlay patch). Multiple selections allowed. When the intelligent removal capability is selected, at least one of NonobjectRemoveElements and ObjectRemoveElements is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,4]</para>
        /// </summary>
        [NameInMap("NonobjectRemoveElements")]
        [Validation(Required=false)]
        public string NonobjectRemoveElementsShrink { get; set; }

        /// <summary>
        /// <para>The elements to detect on the image subject (1 = watermark, 2 = logo, 3 = text, 4 = text-bearing color block). Multiple selections allowed. When the intelligent element detection capability is selected, at least one of ObjectDetectElements and NonobjectDetectElements is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3,4]</para>
        /// </summary>
        [NameInMap("ObjectDetectElements")]
        [Validation(Required=false)]
        public string ObjectDetectElementsShrink { get; set; }

        /// <summary>
        /// <para>The elements to remove from the image subject (1 = transparent text block, 2 = specific name, 3 = text, 4 = overlay patch). Multiple selections allowed. When the intelligent removal capability is selected, at least one of ObjectRemoveElements and NonobjectRemoveElements is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,4]</para>
        /// </summary>
        [NameInMap("ObjectRemoveElements")]
        [Validation(Required=false)]
        public string ObjectRemoveElementsShrink { get; set; }

        /// <summary>
        /// <para>The source language code. Optional. For supported language pairs, see the supported translation language pairs list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The desired height of the cropped image, in pixels. Valid values: 100 to 5000. Required when the intelligent cropping capability is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetHeight")]
        [Validation(Required=false)]
        public int? TargetHeight { get; set; }

        /// <summary>
        /// <para>The target language code. Optional. For supported language pairs, see the supported translation language pairs list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The desired width of the cropped image, in pixels. Valid values: 100 to 5000. Required when the intelligent cropping capability is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetWidth")]
        [Validation(Required=false)]
        public int? TargetWidth { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate brand names on the image. Optional. Default value: false. Helps protect brand name information from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranslatingBrandInTheProduct")]
        [Validation(Required=false)]
        public bool? TranslatingBrandInTheProduct { get; set; }

        /// <summary>
        /// <para>The image upscaling factor. Optional. Default value: 2. Valid values: 2 to 4. Required when the HD upscaling capability is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UpscaleFactor")]
        [Validation(Required=false)]
        public int? UpscaleFactor { get; set; }

    }

}
