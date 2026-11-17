// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyChatappTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The template category for Viber templates. This parameter is invalid for WhatsApp templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKETING</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Specifies whether to pause sending the template when its category is changed from Utility to Marketing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>The list of message template components.</para>
        /// <remarks>
        /// <para>When Category is AUTHENTICATION, Components cannot contain nodes with Type set to HEADER. When Type is BODY or FOOTER, if Text is empty, the content is automatically generated.</para>
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
        /// <para>cams-did***</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The WABA ID of the ISV customer. This parameter is deprecated. Use CustSpaceId instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>939***</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The variables in a key-value structure.</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string ExampleShrink { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ISV verification code, which is used to verify whether the RAM user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9393***</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The validity period for sending WhatsApp authentication template messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MessageSendTtlSeconds")]
        [Validation(Required=false)]
        public int? MessageSendTtlSeconds { get; set; }

        /// <summary>
        /// <para>productSetId</para>
        /// 
        /// <b>Example:</b>
        /// <para>939***</para>
        /// </summary>
        [NameInMap("ProductSetId")]
        [Validation(Required=false)]
        public string ProductSetId { get; set; }

        /// <summary>
        /// <para>The message template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93938**</para>
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
        /// <para>The templatetype to modify. Valid values: WHATSAPP and VIBER. Default value: WHATSAPP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
