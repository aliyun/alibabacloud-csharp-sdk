// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ModifyTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The source channel through which the user accesses the service. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Direct access through Alibaba Cloud.</description></item>
        /// <item><description>2: Access through a partner channel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FromType")]
        [Validation(Required=false)]
        public int? FromType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The remarks or application description for the SMS template. This parameter is required only when the templatetype is SMS. Maximum length: 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for verification</para>
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
        /// <para>The body content of the SMS template. This parameter is required only when the templatetype is SMS. Length: 2 to 400 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello {name}</para>
        /// </summary>
        [NameInMap("SmsContent")]
        [Validation(Required=false)]
        public string SmsContent { get; set; }

        /// <summary>
        /// <para>The business type of the SMS template. This parameter is required only when the templatetype is SMS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: verification code</description></item>
        /// <item><description>2: notification or promotion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsType")]
        [Validation(Required=false)]
        public int? SmsType { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>409481</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <para>The template name. Maximum length: 30 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verification code</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The nickname of the template or the alias of the sender. This parameter is required only when the templatetype is email. Maximum length: 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Lisa Gao</para>
        /// </summary>
        [NameInMap("TemplateNickName")]
        [Validation(Required=false)]
        public string TemplateNickName { get; set; }

        /// <summary>
        /// <para>The subject of the email template. This parameter is required only when the templatetype is email. Maximum length: 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REAL\&quot;EN OPEN TONNAGE</para>
        /// </summary>
        [NameInMap("TemplateSubject")]
        [Validation(Required=false)]
        public string TemplateSubject { get; set; }

        /// <summary>
        /// <para>The body content of the email. This parameter is required only when the templatetype is email. Maximum size: 1 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello {name}</para>
        /// </summary>
        [NameInMap("TemplateText")]
        [Validation(Required=false)]
        public string TemplateText { get; set; }

    }

}
