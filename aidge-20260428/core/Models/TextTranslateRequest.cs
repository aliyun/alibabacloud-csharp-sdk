// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextTranslateRequest : TeaModel {
        /// <summary>
        /// <para>This field represents your identity and facilitates communication for various issues. If you are an internal Alibaba organization, we recommend that you specify this parameter based on the actual scenario, such as BU name-product or BU name-chat. If you are an external Alibaba partner, we recommend that you specify the full name of your company. The company name must be the same as the company name you used when registering your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCompany-Chat</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The format type of the source text. This parameter is optional. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text: Plain text format.</description></item>
        /// <item><description>html: Web page format, which retains HTML tags.</description></item>
        /// </list>
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
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The source language code. If this parameter is not specified, the language is automatically detected. This parameter is optional. You can set this parameter to auto for language identification.<br>&lt;props=&quot;china&quot;&gt;For supported language pairs, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language pair mapping table</a>.      </para>
        /// <para>&lt;props=&quot;intl&quot;&gt;For supported language pairs, see <a href="https://www.alibabacloud.com/help/zh/aidge/language-direction-mapping">Language pair mapping table</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The list of text to be translated. This parameter is required. The total character length cannot exceed 50,000, and the list length cannot exceed 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Hello world&quot;]</para>
        /// </summary>
        [NameInMap("SourceTextList")]
        [Validation(Required=false)]
        public List<string> SourceTextList { get; set; }

        /// <summary>
        /// <para>The target language code. This parameter is required.<br>&lt;props=&quot;china&quot;&gt;For supported language pairs, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language pair mapping table</a>.      </para>
        /// <para>&lt;props=&quot;intl&quot;&gt;For supported language pairs, see <a href="https://www.alibabacloud.com/help/zh/aidge/language-direction-mapping">Language pair mapping table</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ko</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The business scenario identifier. You can specify only one of the following values. After the value is specified, the translation engine calls the terminology library and style policy of the corresponding industry to output translations that better fit the industry. If this parameter is not specified or an invalid value is specified, the general translation policy is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>e-commerce-title: Cross-border e-commerce product title translation.</description></item>
        /// <item><description>e-commerce-description: Cross-border e-commerce product description translation.</description></item>
        /// <item><description>e-commerce-chat: Cross-border e-commerce conversation translation.</description></item>
        /// <item><description>e-commerce-cpv: Cross-border e-commerce product CPV attribute translation.</description></item>
        /// <item><description>novel: Novel translation.</description></item>
        /// <item><description>game: Game translation.</description></item>
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
