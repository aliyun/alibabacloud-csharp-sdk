// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AssetOptimizeProShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of column names to be recognized in the size chart. Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Bust&quot;,&quot;Waist&quot;,&quot;Hip&quot;]</para>
        /// </summary>
        [NameInMap("ColumnNameList")]
        [Validation(Required=false)]
        public string ColumnNameListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the intervention glossary. Optional. You must create the glossary in the console and provide its ID. If this parameter is left empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate the text on the main subject of the image. This helps protect embedded information such as product names from being translated. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludingProductArea")]
        [Validation(Required=false)]
        public bool? IncludingProductArea { get; set; }

        /// <summary>
        /// <para>The output language format for the size chart. If this parameter is left empty, the original language is used. Set this parameter to en for English output or cn for Chinese output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("LanguageModel")]
        [Validation(Required=false)]
        public string LanguageModel { get; set; }

        /// <summary>
        /// <para>Specifies whether translation is required. Valid values: true and false. If this parameter is set to true, SourceLanguage and TargetLanguage are required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedTrans")]
        [Validation(Required=false)]
        public bool? NeedTrans { get; set; }

        /// <summary>
        /// <para>The product URL. Required. Only 1688 product links are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://detail.1688.com/offer/771024907536.html">https://detail.1688.com/offer/771024907536.html</a></para>
        /// </summary>
        [NameInMap("ProductUrl")]
        [Validation(Required=false)]
        public string ProductUrl { get; set; }

        /// <summary>
        /// <para>The source language code. Optional. For supported language pairs, refer to the list of supported translation language pairs. Required if NeedTrans is set to true.</para>
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
        /// <para>The target language code. Optional. For supported language pairs, refer to the list of supported translation language pairs. Required if NeedTrans is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The target platform for listing. Only TEMU is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temu</para>
        /// </summary>
        [NameInMap("TargetPlatform")]
        [Validation(Required=false)]
        public string TargetPlatform { get; set; }

        /// <summary>
        /// <para>The confidence threshold for size chart detection. Default value: 0.4. If this parameter is set to 0, all images are considered size charts. If this parameter is set to 1, no images are considered size charts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.4</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate the brand name in the image. Optional. Default value: false. This helps protect brand name information from being translated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranslatingBrandInTheProduct")]
        [Validation(Required=false)]
        public bool? TranslatingBrandInTheProduct { get; set; }

    }

}
