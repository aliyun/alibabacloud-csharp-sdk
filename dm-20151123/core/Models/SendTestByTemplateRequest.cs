// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SendTestByTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The sender address. Maximum length: 60 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Account+@+domain</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The birthday. Maximum length: 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000/01/01</para>
        /// </summary>
        [NameInMap("Birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        /// <summary>
        /// <para>The recipient email address. Maximum length: 60 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Account+@+domain</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The gender. Maximum length: 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mr.</para>
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <para>The mobile number. Maximum length: 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1380000****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The nickname. Maximum length: 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nickname</para>
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
        /// <para>The custom parameters, formatted as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;age&quot;:&quot;20&quot;,&quot;nickName&quot;:&quot;tom&quot;}</para>
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public string TemplateParams { get; set; }

        /// <summary>
        /// <para>The user name. Maximum length: 30 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
