// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextTranslateAsyncShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The caller business ID. It is used only for asynchronous text translation and returned as-is in the task result. It can be up to 128 characters in length and is passed through in the translation results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-20260928-001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The name of the caller\&quot;s business, which represents your identity and facilitates subsequent communication. If you are an internal Alibaba team, specify this parameter based on the actual scenario, such as BU name-product or BU name-chat. If you are an external partner, specify the full name of your company. The company name must be the same as the one used when you registered your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUxxx-chat</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The format type of the source text. Valid values: text and html.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The ID of the intervention glossary. You must create the glossary in the console and provide its ID in the input parameters. If the intervention glossary ID is empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot; glossary_1&quot;</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The source language code. For more information, see the supported language list below. If this parameter is not specified, the source language is automatically detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The list of texts to be translated.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceTextList")]
        [Validation(Required=false)]
        public string SourceTextListShrink { get; set; }

        /// <summary>
        /// <para>The target language code. For more information, see the supported language pair list below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The business scenario identifier. You can specify only one of the following values. After a value is specified, the translation engine invokes the terminology library and style strategy of the corresponding industry to output more industry-aligned translations. If this field is not specified or an invalid value is specified, the general translation strategy is used. Valid values: e-commerce-title for cross-border e-commerce product title translation, e-commerce-description for cross-border e-commerce product description translation, e-commerce-chat for cross-border e-commerce session translation, e-commerce-cpv for cross-border e-commerce product CPV attribute translation, novel for novel translation, and game for game translation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-commerce-title</para>
        /// </summary>
        [NameInMap("TranslateScene")]
        [Validation(Required=false)]
        public string TranslateScene { get; set; }

    }

}
