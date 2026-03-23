// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SendTestByTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The sender address. The length cannot exceed 60 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>账号+@+域名</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The birthday. The length cannot exceed 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000/01/01</para>
        /// </summary>
        [NameInMap("Birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        /// <summary>
        /// <para>The recipient email address. The length cannot exceed 60 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>账号+@+域名</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The gender. The length cannot exceed 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>先生</para>
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <para>The mobile number. The length cannot exceed 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1380000****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The nickname. The length cannot exceed 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>昵称</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

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
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;age&quot;:&quot;20&quot;,&quot;nickName&quot;:&quot;tom&quot;}</para>
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public string TemplateParams { get; set; }

        /// <summary>
        /// <para>The user name. The length cannot exceed 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>姓名</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
