// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateUsersRequest : TeaModel {
        /// <summary>
        /// <para>The date on which the convenience users are automatically locked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-03</para>
        /// </summary>
        [NameInMap("AutoLockTime")]
        [Validation(Required=false)]
        public string AutoLockTime { get; set; }

        [NameInMap("IsLocalAdmin")]
        [Validation(Required=false)]
        public bool? IsLocalAdmin { get; set; }

        /// <summary>
        /// <para>The initial password. If this parameter is left empty, an email for password reset is sent to the specified email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PasswordExpireDays")]
        [Validation(Required=false)]
        public string PasswordExpireDays { get; set; }

        /// <summary>
        /// <para>The information about the convenience user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateUsers</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<CreateUsersRequestUsers> Users { get; set; }
        public class CreateUsersRequestUsers : TeaModel {
            /// <summary>
            /// <para>The email address of the convenience user. The email address is used to receive notifications about events such as desktop assignment. You must specify an email address or a mobile number to receive notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username of the convenience user. The name can contain lowercase letters, digits, and underscores (_), and must be 3 to 24 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The organization to which the convenience user belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111****</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The type of the account ownership.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateFromManager: administrator-activated</description></item>
            /// <item><description>Normal: user-activated</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The user password.</para>
            /// <remarks>
            /// <para> The password must be at least 10 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters (excluding spaces).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>password1</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>Mobile numbers are not supported on the international site (alibabacloud.com).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The display name of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bean</para>
            /// </summary>
            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// <para>The remarks on the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark1</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

    }

}
