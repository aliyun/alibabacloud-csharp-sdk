// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyChatappTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The templatetype is immutable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>A list of message template components.</para>
        /// <remarks>
        /// <para>When Category is AUTHENTICATION, Components cannot contain a node with Type set to HEADER. If Type is BODY or FOOTER, the Text content is empty and is automatically generated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer, or the instance ID of a direct customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28251486512358****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The WhatsApp Business Account (WABA) ID of the independent software vendor (ISV) customer.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Use CustSpaceId instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65921621816****</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The template example.</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string ExampleShrink { get; set; }

        /// <summary>
        /// <para>The ISV verification code. This code is used to verify that the RAM user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ksiekdki39ksks93939</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The template language. For a list of language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the template message in seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>For AUTHENTICATION templates, the value ranges from 30 to 900.</para>
        /// </description></item>
        /// <item><description><para>For UTILITY templates, the value ranges from 30 to 43,200.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MessageSendTtlSeconds")]
        [Validation(Required=false)]
        public int? MessageSendTtlSeconds { get; set; }

        /// <summary>
        /// <para>The message template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8472929283883</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The template type.</para>
        /// <list type="bullet">
        /// <item><description><b>WHATSAPP</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
