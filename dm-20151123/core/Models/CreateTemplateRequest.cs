// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Deprecated. This parameter is retained for backward compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("FromType")]
        [Validation(Required=false)]
        public int? FromType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Deprecated. This parameter is retained for backward compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Deprecated. This parameter is retained for backward compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("SmsContent")]
        [Validation(Required=false)]
        public string SmsContent { get; set; }

        /// <summary>
        /// <para>Deprecated. This parameter is retained for backward compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("SmsType")]
        [Validation(Required=false)]
        public int? SmsType { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The sender name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tom</para>
        /// </summary>
        [NameInMap("TemplateNickName")]
        [Validation(Required=false)]
        public string TemplateNickName { get; set; }

        /// <summary>
        /// <para>The email subject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subject test</para>
        /// </summary>
        [NameInMap("TemplateSubject")]
        [Validation(Required=false)]
        public string TemplateSubject { get; set; }

        /// <summary>
        /// <para>The email HTML body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TemplateText")]
        [Validation(Required=false)]
        public string TemplateText { get; set; }

        /// <summary>
        /// <para>The template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

    }

}
