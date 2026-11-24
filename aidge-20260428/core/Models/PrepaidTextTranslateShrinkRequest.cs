// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class PrepaidTextTranslateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario identifier. This parameter is optional. Valid values: e-commerce-title, e-commerce-description, e-commerce-chat, e-commerce-cpv, novel, and game. If this parameter is not specified or is invalid, the general translation policy is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba-Product</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The format type of the source text. This parameter is optional. Valid values: text (plain text format) and html (web page format, which retains HTML tags).</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The ID of the intervention glossary. This parameter is optional. You must create the glossary in the console and provide its ID. If the provided intervention glossary ID is empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_glossary</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The source language code. This parameter is optional. If you do not specify this parameter, the language is automatically detected. You can set this parameter to auto to enable language detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The list of text to translate. This parameter is required. The total character length cannot exceed 50,000, and the list length cannot exceed 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Hello world&quot;]</para>
        /// </summary>
        [NameInMap("SourceTextList")]
        [Validation(Required=false)]
        public string SourceTextListShrink { get; set; }

        /// <summary>
        /// <para>The target language code. This parameter is required. More than 100 language pairs are supported. For details, see the list of supported language pairs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The format of the text to translate. <b>html</b>: web page format. If you set this parameter to html, the source text and translated text are processed in HTML format. <b>text</b>: text format. If you set this parameter to text, the source text and translated text are processed as plain text without format processing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-commerce-title</para>
        /// </summary>
        [NameInMap("TranslateScene")]
        [Validation(Required=false)]
        public string TranslateScene { get; set; }

    }

}
