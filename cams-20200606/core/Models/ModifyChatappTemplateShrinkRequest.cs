// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyChatappTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The category of the Viber message template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>text</b>: the template that contains only text</description></item>
        /// <item><description><b>image</b>: the template that contains only images</description></item>
        /// <item><description><b>text_image_button</b>: the template that contains text, images, and buttons</description></item>
        /// <item><description><b>text_button</b>: the template that contains text and buttons</description></item>
        /// <item><description><b>document</b>: the template that contains only documents</description></item>
        /// <item><description><b>video</b>: the template that contains only videos</description></item>
        /// <item><description><b>text_video</b>: the template that contains text and videos</description></item>
        /// <item><description><b>text_video_button</b>: the template that contains text, videos, and buttons</description></item>
        /// <item><description><b>text_image</b>: the template that contains text and images</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only to Viber message templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The components of the message template.</para>
        /// <remarks>
        /// <para> If Category is set to AUTHENTICATION, the Type sub-parameter of the Components parameter cannot be set to HEADER. If the Type sub-parameter is set to BODY or FOOTER, you do not need to set the Text sub-parameter of the Components parameter because the value is automatically generated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// <para>The space ID of the user within the ISV account.</para>
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
        /// <para>The WhatsApp Business account (WABA) ID of the user within the independent software vendor (ISV) account.</para>
        /// <remarks>
        /// <para>CustWabaId is an obsolete parameter. Use CustSpaceId instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>659216218162179</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The examples of variables that are used when you create the message template.</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string ExampleShrink { get; set; }

        /// <summary>
        /// <para>The ISV verification code, which is used to verify whether the user is authorized by the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ksiekdki39ksks93939</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The language that is used in the message template. For more information, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>Validity period of authentication template message sending in WhatsApp</para>
        /// <remarks>
        /// <para>This attribute requires providing waba in advance to Alibaba operators to open the whitelist, otherwise it will result in template submission failure</para>
        /// </remarks>
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
        /// <para>Template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the message template.</para>
        /// <list type="bullet">
        /// <item><description><b>WHATSAPP</b></description></item>
        /// <item><description><b>VIBER</b></description></item>
        /// <item><description>LINE: the Line message template. This type of message template will be released later.</description></item>
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
