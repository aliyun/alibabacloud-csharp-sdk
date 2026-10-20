// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextTranslateAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The business ID of the caller. The maximum length is 128 characters. This ID is passed through in the translation results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-20260928-001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The business name of the caller. This field represents your identity and facilitates subsequent communication. If you are an internal Alibaba organization, specify this parameter based on the actual scenario, such as BU name-product or BU name-chat. If you are an external partner, specify the full name of your company. The company name must be the same as the one used when registering your Alibaba Cloud account.</para>
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
        /// <para>The ID of the intervention glossary. You must create the glossary in the console and provide its ID in the request parameters. If the intervention glossary ID is empty, the translation results are not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot; glossary_1&quot;</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The source language code. For more information, see the supported language list below. If this parameter is not specified, the language is automatically detected.</para>
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
        public List<string> SourceTextList { get; set; }

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
        /// <para>The business scenario identifier. You can specify only one of the following values. After you specify a value, the translation engine uses the terminology library and style policy of the corresponding industry to output industry-specific translations. If this parameter is not specified or an invalid value is specified, the general translation policy is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>e-commerce-title: Translates cross-border e-commerce product titles.</description></item>
        /// <item><description>e-commerce-description: Translates cross-border e-commerce product descriptions.</description></item>
        /// <item><description>e-commerce-chat: Translates cross-border e-commerce conversations.</description></item>
        /// <item><description>e-commerce-cpv: Translates cross-border e-commerce product CPV attributes.</description></item>
        /// <item><description>novel: Translates novels.</description></item>
        /// <item><description>game: Translates games.</description></item>
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
