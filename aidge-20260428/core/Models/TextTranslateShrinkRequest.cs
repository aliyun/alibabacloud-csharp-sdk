// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextTranslateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario identifier. Optional. Valid values: e-commerce-title, e-commerce-description, e-commerce-chat, e-commerce-cpv, novel, game. If not specified or invalid, the general translation strategy is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCompany-Chat</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The format type of the source text. Optional. Supports text (plain text format) and html (web page format, preserving HTML tags).</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The intervention glossary ID. Optional. The glossary must be created separately in the console and its ID provided. If the glossary ID is empty, the translation result is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The source language code. Optional. If not specified, the language is automatically detected. You can pass auto for language detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The list of texts to translate. Required. The total character length cannot exceed 50,000, and the list length cannot exceed 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Hello world&quot;]</para>
        /// </summary>
        [NameInMap("SourceTextList")]
        [Validation(Required=false)]
        public string SourceTextListShrink { get; set; }

        /// <summary>
        /// <para>The target language code. Required. Supports more than 100 language directions. For details, refer to the supported language directions list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ko</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The format of the translation text. <b>html</b> (web page format. This setting processes both the source text and translated text in HTML format). <b>text</b> (text format. This setting processes both the source text and translated result as plain text without format processing).</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-commerce-title</para>
        /// </summary>
        [NameInMap("TranslateScene")]
        [Validation(Required=false)]
        public string TranslateScene { get; set; }

    }

}
