// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageTranslationProRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use the asynchronous mode. Default value: false, which indicates the synchronous mode. If you set this parameter to true, the API immediately returns a TaskId, and you must call the query translation result API to obtain the final result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The ID of the intervention glossary. This parameter is optional. You must create the glossary in the console and provide its ID. If the intervention glossary ID is empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The URL of the original image. This parameter is required.<br>Image requirements:  </para>
        /// <list type="bullet">
        /// <item><description>Image URL: Must be publicly accessible.   </description></item>
        /// <item><description>Formats: PNG, JPEG, JPG, BMP, and WebP.   </description></item>
        /// <item><description>Pixels: Both width and height must not exceed 4,000 pixels.  </description></item>
        /// <item><description>File size: The original file must be less than or equal to 10 MB.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i3/O1CN01HTDhDi28Fd85ZYs7H_!!6000000007903-0-tps-800-800.jpg">https://img.alicdn.com/imgextra/i3/O1CN01HTDhDi28Fd85ZYs7H_!!6000000007903-0-tps-800-800.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate the text on the product subject in the image. Default value: false. This helps protect information and prevents embedded information such as product names from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludingProductArea")]
        [Validation(Required=false)]
        public bool? IncludingProductArea { get; set; }

        /// <summary>
        /// <para>The source language code. This parameter is required.<br>&lt;props=&quot;china&quot;&gt;For supported language pairs, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language pair mapping table</a>.<br>&lt;props=&quot;intl&quot;&gt;For supported language pairs, see <a href="https://www.alibabacloud.com/help/zh/aidge/language-direction-mapping">Language pair mapping table</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The target language code. This parameter is required.<br>&lt;props=&quot;china&quot;&gt;For supported language pairs, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language pair mapping table</a>.<br>&lt;props=&quot;intl&quot;&gt;For supported language pairs, see <a href="https://www.alibabacloud.com/help/zh/aidge/language-direction-mapping">Language pair mapping table</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ko</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate brand names in the image. Default value: false. This helps protect brand name information from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranslatingBrandInTheProduct")]
        [Validation(Required=false)]
        public bool? TranslatingBrandInTheProduct { get; set; }

        /// <summary>
        /// <para>Specifies whether to return layout information such as the position, font, and color of the text. If you set this parameter to true, layer information is returned, which can be used for secondary editing when you integrate an image editor. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseImageEditor")]
        [Validation(Required=false)]
        public bool? UseImageEditor { get; set; }

    }

}
