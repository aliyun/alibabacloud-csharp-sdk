// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageTranslationStandardRequest : TeaModel {
        /// <summary>
        /// <para>The intervention glossary ID. Optional. You must create the glossary separately in the console and provide its ID. If the provided glossary ID is empty, the translation results will not be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Image URL: Must be publicly accessible.</description></item>
        /// <item><description>Format: png, jpeg, jpg, bmp, webp</description></item>
        /// <item><description>Pixels: Width and height must not exceed 4000</description></item>
        /// <item><description>File size: Original file ≤ 10 MB</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://images-na.ssl-images-amazon.com/images/I/41bKsNBDcwL.jpg">https://images-na.ssl-images-amazon.com/images/I/41bKsNBDcwL.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate text on the image subject. Optional. Default value: false. This helps protect information and avoids translating embedded information such as product names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludingProductArea")]
        [Validation(Required=false)]
        public bool? IncludingProductArea { get; set; }

        /// <summary>
        /// <para>The source language code. Required. For supported language directions, see the supported language direction list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The target language code. Required. For supported language directions, see the supported language direction list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ko</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate brand names on the image. Optional. Default value: false. This helps protect brand name information from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranslatingBrandInTheProduct")]
        [Validation(Required=false)]
        public bool? TranslatingBrandInTheProduct { get; set; }

        /// <summary>
        /// <para>Specifies whether to return layer information such as text position, font, and color. When set to true, layer information is returned for secondary editing through an image editor. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseImageEditor")]
        [Validation(Required=false)]
        public bool? UseImageEditor { get; set; }

    }

}
