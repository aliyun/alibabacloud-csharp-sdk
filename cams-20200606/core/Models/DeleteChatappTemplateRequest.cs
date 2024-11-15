// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class DeleteChatappTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the RAM user within the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28251486512358****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The WhatsApp Business Account (WABA) ID of the RAM user within the independent software vendor (ISV) account.</para>
        /// <remarks>
        /// <para> CustWabaId is an obsolete parameter. Use CustSpaceId instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65921621816****</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The ISV verification code. This parameter is used to verify whether the RAM user is authorized by the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The template language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>744c4b5c79c9432497a075bdfca3****</para>
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
        /// <para>The template type. This parameter is required if you delete a template in a language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
