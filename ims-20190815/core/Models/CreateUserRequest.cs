// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
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
        /// <para>The name must be 1 to 24 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address of the RAM user.</para>
        /// <remarks>
        /// <para>This parameter is valid only on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The mobile number of the RAM user.</para>
        /// <para>Format: Country code-Mobile phone number.</para>
        /// <remarks>
        /// <para>This parameter is valid only on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86-1868888****</para>
        /// </summary>
        [NameInMap("MobilePhone")]
        [Validation(Required=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateUserRequestTag> Tag { get; set; }
        public class CreateUserRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>operator</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <para>The tag value can be an empty string. The tag value can be up to 128 characters in length. The tag value cannot start with <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The logon name of the Resource Access Management (RAM) user.</para>
        /// <para>The name is in the format of <c>&lt;username&gt;@&lt;AccountAlias&gt;.onaliyun.com</c>. <c>&lt;username&gt;</c> indicates the name of the RAM user. <c>&lt;AccountAlias&gt;.onaliyun.com</c> indicates the default domain name. For more information about how to query the default domain name, see <a href="https://help.aliyun.com/document_detail/186720.html">GetDefaultDomain</a>.</para>
        /// <para>The value of <c>UserPrincipalName</c> must be <c>1 to 128</c> characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (_). The value of <c>&lt;username&gt;</c> must be <c>1 to 64</c> characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
