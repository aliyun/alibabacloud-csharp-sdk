// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateShrinkRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Indicates whether to allow Facebook to automatically change the category of the template. This can increase the approval rate of the template. This parameter is valid only when TemplateType is set to WHATSAPP.</para>
        /// <remarks>
        /// <para>Notice: This property is deprecated. WhatsApp no longer supports this property.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// <para>WhatsApp template categories:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: Transactional.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: Marketing.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: Authentication.</para>
        /// </description></item>
        /// </list>
        /// <para>Viber template categories:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: Transactional.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: Marketing.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: Authentication.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTILITY</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>The list of message template components.</para>
        /// <remarks>
        /// <para>When Category is set to AUTHENTICATION, the Components array cannot contain a component of the HEADER type. If the component type is BODY or FOOTER, the Text parameter must be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer or the instance ID of the direct customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493</para>
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
        /// <para>An example of how to create a template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello_whatsapp</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string ExampleShrink { get; set; }

        /// <summary>
        /// <para>The ISV verification code, used to verify whether the RAM user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The template language. For more information about language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the template message in WhatsApp.</para>
        /// <list type="bullet">
        /// <item><description><para>For AUTHENTICATION templates, the value ranges from 30 to 900.</para>
        /// </description></item>
        /// <item><description><para>For UTILITY templates, the value ranges from 30 to 43200.</para>
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
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello_whatsapp</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The template type.</para>
        /// <list type="bullet">
        /// <item><description><para><b>WHATSAPP</b></para>
        /// </description></item>
        /// <item><description><para><b>VIBER</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
