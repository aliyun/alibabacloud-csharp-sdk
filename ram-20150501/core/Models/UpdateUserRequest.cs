// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
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
        /// <para>The name must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaoq****</para>
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// <para>The new email address of the RAM user.</para>
        /// <remarks>
        /// <para> This parameter can be returned only on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xiaoq****@example.com</para>
        /// </summary>
        [NameInMap("NewEmail")]
        [Validation(Required=false)]
        public string NewEmail { get; set; }

        /// <summary>
        /// <para>The new mobile phone number of the RAM user.</para>
        /// <para>Format: \<Country code>-\<Mobile phone number>.</para>
        /// <remarks>
        /// <para> This parameter can be returned only on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86-1860000****</para>
        /// </summary>
        [NameInMap("NewMobilePhone")]
        [Validation(Required=false)]
        public string NewMobilePhone { get; set; }

        /// <summary>
        /// <para>The new username of the RAM user.</para>
        /// <para>The username must be 1 to 64 characters in length, and can contain letters, digits, periods (.), hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaoq****</para>
        /// </summary>
        [NameInMap("NewUserName")]
        [Validation(Required=false)]
        public string NewUserName { get; set; }

        /// <summary>
        /// <para>The username of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangq****</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
