// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextTranslateRequest : TeaModel {
        /// <summary>
        /// <para>The format type of the source text. Optional. Valid values: text (plain text format) and html (web page format that preserves HTML tags).</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The intervention glossary ID. Optional. Create the glossary in the console and provide its ID. If the glossary ID is empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The source language code. Optional. If not specified, the language is automatically detected. Set to auto for automatic language detection.</para>
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
        public List<string> SourceTextList { get; set; }

        /// <summary>
        /// <para>The target language code. Required. More than 100 language directions are supported. For details, refer to the supported language directions list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ko</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

    }

}
