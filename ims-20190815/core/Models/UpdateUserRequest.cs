// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the RAM user.</para>
        /// <para>The description must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a cloud computing engineer.</para>
        /// </summary>
        [NameInMap("NewComments")]
        [Validation(Required=false)]
        public string NewComments { get; set; }

        /// <summary>
        /// <para>The new display name of the RAM user.</para>
        /// <para>The name must be 1 to 24 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new</para>
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// <para>The new email address of the RAM user.</para>
        /// <remarks>
        /// <para>This parameter is valid only on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
        /// </summary>
        [NameInMap("NewEmail")]
        [Validation(Required=false)]
        public string NewEmail { get; set; }

        /// <summary>
        /// <para>The new mobile phone number of the RAM user.</para>
        /// <para>Format: \<Country code>-\<Mobile phone number>.</para>
        /// <remarks>
        /// <para>This parameter is valid only on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86-1868888****</para>
        /// </summary>
        [NameInMap("NewMobilePhone")]
        [Validation(Required=false)]
        public string NewMobilePhone { get; set; }

        /// <summary>
        /// <para>The new logon name of the RAM user.</para>
        /// <para>The name is in the format of <c>&lt;username&gt;@&lt;AccountAlias&gt;.onaliyun.com</c>. <c>&lt;username&gt;</c> indicates the name of the RAM user. <c>&lt;AccountAlias&gt;.onaliyun.com</c> indicates the default domain name.</para>
        /// <para>The value of <c>UserPrincipalName</c> must be 1 to 128 characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (_). The value of <c>&lt;username&gt;</c> must be 1 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:new@example.onaliyun.com">new@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("NewUserPrincipalName")]
        [Validation(Required=false)]
        public string NewUserPrincipalName { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: <c>UserPrincipalName</c> and <c>UserId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20732900249392****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The logon name of the RAM user.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: <c>UserPrincipalName</c> and <c>UserId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
