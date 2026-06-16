// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AssetOptimizeProShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of column names to recognize in size chart images. Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;胸围&quot;,&quot;腰围&quot;,&quot;臀围&quot;]</para>
        /// </summary>
        [NameInMap("ColumnNameList")]
        [Validation(Required=false)]
        public string ColumnNameListShrink { get; set; }

        /// <summary>
        /// <para>The glossary ID. Optional. Create a glossary in the console and provide its ID. If left empty, translation results are not modified by any glossary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate text on the product subject area of images. Setting this to false helps protect embedded information such as product names from being translated. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludingProductArea")]
        [Validation(Required=false)]
        public bool? IncludingProductArea { get; set; }

        /// <summary>
        /// <para>The output language format for size chart images. If not specified, the original format is used. Set to en for English output or cn for Chinese output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("LanguageModel")]
        [Validation(Required=false)]
        public string LanguageModel { get; set; }

        /// <summary>
        /// <para>Specifies whether translation is required (true/false). If set to true, SourceLanguage and TargetLanguage are required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedTrans")]
        [Validation(Required=false)]
        public bool? NeedTrans { get; set; }

        /// <summary>
        /// <para>The product URL. This parameter is required. Only 1688 product links are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://detail.1688.com/offer/771024907536.html">https://detail.1688.com/offer/771024907536.html</a></para>
        /// </summary>
        [NameInMap("ProductUrl")]
        [Validation(Required=false)]
        public string ProductUrl { get; set; }

        /// <summary>
        /// <para>The source language code. Optional. For supported language pairs, refer to the supported translation language list. This parameter is required if NeedTrans is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The source platform. Only 1688 is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688</para>
        /// </summary>
        [NameInMap("SourcePlatform")]
        [Validation(Required=false)]
        public string SourcePlatform { get; set; }

        /// <summary>
        /// <para>The target language code. Optional. For supported language pairs, refer to the supported translation language list. This parameter is required if NeedTrans is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The target listing platform. Only temu is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temu</para>
        /// </summary>
        [NameInMap("TargetPlatform")]
        [Validation(Required=false)]
        public string TargetPlatform { get; set; }

        /// <summary>
        /// <para>The confidence threshold for size chart detection. Default value: 0.4. A value of 0 treats all images as size charts. A value of 1 treats no images as size charts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.4</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate brand names on images. Optional. Default value: false. Setting this to false helps protect brand name information from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranslatingBrandInTheProduct")]
        [Validation(Required=false)]
        public bool? TranslatingBrandInTheProduct { get; set; }

    }

}
