// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class GenerateProductContentRequest : TeaModel {
        /// <summary>
        /// <para>Takes effect only when ContentType is set to bulletPoint. Valid values: 1 to 5. Default value in generate mode: 1. In rewrite mode, if you manually specify this parameter, the value must be the same as the number of non-empty paragraphs in SourceText. This parameter is ignored for other copy types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("BulletPointCount")]
        [Validation(Required=false)]
        public int? BulletPointCount { get; set; }

        /// <summary>
        /// <para>The copy type. Valid values: title, highlight, keywords, bulletPoint, description, and general. The general value is supported only when Operation is set to customize. If a platform is specified, you must select a type supported by the platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable translation. Default value: false. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableTranslation")]
        [Validation(Required=false)]
        public bool? EnableTranslation { get; set; }

        /// <summary>
        /// <para>The maximum number of characters for the final output text. If you specify this parameter, the value must be an integer greater than or equal to 30. If a platform is specified and this parameter is not specified, the configured upper limit for the content type on the platform is used. Example: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// <para>The minimum number of characters for the final output text. If you specify this parameter, the value must be an integer greater than or equal to 10. If a platform is specified and this parameter is not specified, the configured lower limit for the content type on the platform is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MinLength")]
        [Validation(Required=false)]
        public int? MinLength { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values: generate, rewrite, and customize. The customize value allows you to enter custom prompts.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>generate</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The target platform. Valid values: amazon, temu, tiktok, shopify, Wildberries, and tmall. If this parameter is not specified, the general scenario is used. Enum values are case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amazon</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The product attribute information. Default value: empty. The length must be 0 to 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;brand&quot;:&quot;Supor&quot;,&quot;material&quot;:&quot;304 stainless steel&quot;}</para>
        /// </summary>
        [NameInMap("ProductAttributes")]
        [Validation(Required=false)]
        public string ProductAttributes { get; set; }

        /// <summary>
        /// <para>The product category. Default value: an empty string. The length must be 0 to 100 characters. This parameter helps understand the category during generation and eliminates ambiguity during rewriting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kitchenware</para>
        /// </summary>
        [NameInMap("ProductCategory")]
        [Validation(Required=false)]
        public string ProductCategory { get; set; }

        /// <summary>
        /// <para>The custom prompt. The maximum length is 10,000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The source language. Valid values: zh and en. Automatic language detection is not supported. Supported source languages: Chinese (zh) and English (en).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The product information or copy to be rewritten. The length must be 20 to 3,000 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stainless steel steamer 28cm 3-tier large capacity household kitchen essential steaming and boiling dual-use cookware</para>
        /// </summary>
        [NameInMap("SourceText")]
        [Validation(Required=false)]
        public string SourceText { get; set; }

        /// <summary>
        /// <para>Required when EnableTranslation is set to true. For valid values, see Multilingual processing. If translation is disabled, this parameter is optional. If specified, the value must be the same as SourceLanguage. Supported target languages: Chinese (zh), English (en), Russian (ru), German (de), French (fr), Korean (ko), Italian (it), Thai (th), Arabic (ar), Turkish (tr), Hebrew (he), Ukrainian (uk), Polish (pl), Japanese (ja), Dutch (nl), Portuguese (pt), Spanish (es), Malay (ms), Bulgarian (bg), Indonesian (id), and Vietnamese (vi).</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

    }

}
