// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the RAM user.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: <c>UserPrincipalName</c>, <c>UserId</c>, and <c>UserAccessKeyId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI*******************</para>
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: <c>UserPrincipalName</c>, <c>UserId</c>, and <c>UserAccessKeyId</c>.</para>
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
        /// <para>The name is in the format of <c>&lt;username&gt;@&lt;AccountAlias&gt;.onaliyun.com</c>. <c>&lt;username&gt;</c> indicates the name of the RAM user. <c>&lt;AccountAlias&gt;.onaliyun.com</c> indicates the default domain name.</para>
        /// <para>The value of <c>UserPrincipalName</c> must be <c>1 to 128</c> characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (_). The value of <c>&lt;username&gt;</c> must be <c>1 to 64</c> characters in length.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: <c>UserPrincipalName</c>, <c>UserId</c>, and <c>UserAccessKeyId</c>.</para>
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
