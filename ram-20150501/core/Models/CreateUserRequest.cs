// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>The description of the RAM user.</para>
        /// <para>The description must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a cloud computing engineer.</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The display name of the RAM user.</para>
        /// <para>The name must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address of the RAM user.</para>
        /// <remarks>
        /// <para> This parameter applies only to the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the RAM user.</para>
        /// <para>Format: \<Country code>-\<Mobile phone number>.</para>
        /// <remarks>
        /// <para> This parameter applies only to the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86-1868888****</para>
        /// </summary>
        [NameInMap("MobilePhone")]
        [Validation(Required=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// <para>The name of the RAM user.</para>
        /// <para>The name must be 1 to 64 characters in length, and can contain letters, digits, periods (.), hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
