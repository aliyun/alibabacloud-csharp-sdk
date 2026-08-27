// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow Facebook to automatically change the template category (to improve the template approval rate). This property is valid only when TemplateType is set to WHATSAPP.</para>
        /// <remarks>
        /// <para>Notice: This property has been deprecated. WhatsApp no longer supports this property.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// <para>WhatsApp template category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: transaction-related.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: marketing.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: identity verification.</para>
        /// </description></item>
        /// </list>
        /// <para>Viber template category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: transaction-related.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: marketing.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: identity verification.</para>
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

        /// <summary>
        /// <para>Specifies whether to pause template sending when a Utility template is changed to Marketing type. This property is valid only for WhatsApp templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>The list of message template components.</para>
        /// <remarks>
        /// <para>When Category=AUTHENTICATION, Components cannot contain nodes with Type=HEADER. When Type=BODY or FOOTER, the Text content must be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// <para>The SpaceId of the ISV sub-customer or the direct customer instance ID.</para>
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
        /// <para>The ISV customer WabaId.</para>
        /// <remarks>
        /// <para>Deprecated parameter. Use CustSpaceId instead.</para>
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
        /// <para>The example for creating the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello_whatsapp</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string ExampleShrink { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ISV verification code, used to verify whether the sub-account is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The template language. For detailed language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) for template messages in WhatsApp.</para>
        /// <list type="bullet">
        /// <item><description>AUTHENTICATION: valid values range from 30 to 900. </description></item>
        /// <item><description>UTILITY: valid values range from 30 to 43200.</description></item>
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
        /// <para>productSetId</para>
        /// 
        /// <b>Example:</b>
        /// <para>9928**</para>
        /// </summary>
        [NameInMap("ProductSetId")]
        [Validation(Required=false)]
        public string ProductSetId { get; set; }

        /// <summary>
        /// <para>The templatetype. Valid values:</para>
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
