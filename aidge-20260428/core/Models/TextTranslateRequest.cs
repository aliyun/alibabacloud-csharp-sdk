// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextTranslateRequest : TeaModel {
        /// <summary>
        /// <para>This field represents your identity and facilitates communication for various issues. If you are an Alibaba internal organization, specify a value based on your actual scenario, such as BU name-product or BU name-chat. If you are an external Alibaba partner, specify the full name of your company. This company name must be consistent with the company name used when you registered your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCompany-Chat</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The format type of the source text. This parameter is optional. Valid values: text (plain text format) and html (web page format that preserves HTML tags).</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The intervention glossary ID. This parameter is optional. You must create the glossary separately in the console and provide its ID. If the glossary ID is empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The source language code. If not specified, the language is automatically detected. This parameter is optional. You can set it to auto for language detection. For supported language directions, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language direction mapping table</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The list of texts to be translated. This parameter is required. The total character length cannot exceed 50,000, and the list length cannot exceed 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Hello world&quot;]</para>
        /// </summary>
        [NameInMap("SourceTextList")]
        [Validation(Required=false)]
        public List<string> SourceTextList { get; set; }

        /// <summary>
        /// <para>The target language code. This parameter is required. For supported language directions, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language direction mapping table</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ko</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The business scenario identifier. You can pass in only one of the following values. When specified, the translation engine invokes the corresponding industry terminology library and style strategy to produce translations that better fit the industry. If this field is not specified or an invalid value is passed, the general translation strategy is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>e-commerce-title: cross-border e-commerce product title translation.</description></item>
        /// <item><description>e-commerce-description: cross-border e-commerce product description translation.</description></item>
        /// <item><description>e-commerce-chat: cross-border e-commerce conversation translation.</description></item>
        /// <item><description>e-commerce-cpv: cross-border e-commerce product CPV attribute translation.</description></item>
        /// <item><description>novel: novel translation.</description></item>
        /// <item><description>game: game translation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>e-commerce-title</para>
        /// </summary>
        [NameInMap("TranslateScene")]
        [Validation(Required=false)]
        public string TranslateScene { get; set; }

    }

}
