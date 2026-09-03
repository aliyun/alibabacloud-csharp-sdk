// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageTranslationProRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use asynchronous mode. Default value: false (synchronous mode). When set to true, the API immediately returns a TaskId. Use the query translation result API to retrieve the final result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The ID of the intervention glossary. This parameter is optional. Create the glossary separately in the console and provide its ID. If the glossary ID is empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The URL of the original image. This parameter is required.</para>
        /// <para>Image requirements:</para>
        /// <list type="bullet">
        /// <item><description>Image URL: Must be publicly accessible.</description></item>
        /// <item><description>Format: png, jpeg, jpg, bmp, or webp.</description></item>
        /// <item><description>Pixels: The width and height must not exceed 4000 pixels each.</description></item>
        /// <item><description>File size: The original file must be 10 MB or smaller.</description></item>
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
        /// <para>Specifies whether to translate text on the image subject. This parameter is optional. Default value: false. Setting this parameter to false helps protect information such as embedded product names from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludingProductArea")]
        [Validation(Required=false)]
        public bool? IncludingProductArea { get; set; }

        /// <summary>
        /// <para>The source language code. This parameter is required. For supported language directions, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language Direction Mapping Table</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The target language code. This parameter is required. For supported language directions, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language Direction Mapping Table</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ko</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate brand names on the image. This parameter is optional. Default value: false. Setting this parameter to false helps protect brand name information from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranslatingBrandInTheProduct")]
        [Validation(Required=false)]
        public bool? TranslatingBrandInTheProduct { get; set; }

        /// <summary>
        /// <para>Specifies whether to return layout information such as text position, font, and color. When set to true, layer information is returned for secondary editing with an image editor. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseImageEditor")]
        [Validation(Required=false)]
        public bool? UseImageEditor { get; set; }

    }

}
