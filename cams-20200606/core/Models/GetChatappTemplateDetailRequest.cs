// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateDetailRequest : TeaModel {
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
        /// <para> CustWabaId is an obsolete parameter. Use CustSpaceId instead.</para>
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
        /// <para>The independent software vendor (ISV) verification code. This parameter is used to verify whether the user is authorized by the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The language that is used in the message template. For more information, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en_US</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The code of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****4b5c79c9432497a075bdfca36bf5</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>Name of a template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the message template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WHATSAPP</b></description></item>
        /// <item><description><b>VIBER</b></description></item>
        /// <item><description>LINE (developing)</description></item>
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
