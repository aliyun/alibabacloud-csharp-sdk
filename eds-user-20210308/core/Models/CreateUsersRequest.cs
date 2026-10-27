// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateUsersRequest : TeaModel {
        /// <summary>
        /// <para>The date when the account is automatically locked. Specify the date in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-28 00:00:00</para>
        /// </summary>
        [NameInMap("AutoLockTime")]
        [Validation(Required=false)]
        public string AutoLockTime { get; set; }

        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>Specifies whether to set the convenience account as a local administrator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLocalAdmin")]
        [Validation(Required=false)]
        public bool? IsLocalAdmin { get; set; }

        /// <summary>
        /// <para>The initial password. If you do not specify this parameter, a password reset email is sent to the user\&quot;s email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The validity period of the password for the user account. By default, the password never expires. You can set this parameter to a value from 30 to 365 to specify the validity period in days. After the password expires, the end user must change the password before logging on again.</para>
        /// <remarks>
        /// <para>This feature is in invitational preview. To use this feature, submit a ticket.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PasswordExpireDays")]
        [Validation(Required=false)]
        public string PasswordExpireDays { get; set; }

        /// <summary>
        /// <para>The convenience account information.</para>
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
            /// <para>The email address. The email address is used to receive relevant emails, such as notification emails for cloud computer allocation. You must specify either the email address or the phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username. The username is custom and must be 3 to 24 characters in length. It can contain only lowercase letters, digits, and underscores.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The IDs of the user groups to join.</para>
            /// </summary>
            [NameInMap("GroupIdList")]
            [Validation(Required=false)]
            public List<string> GroupIdList { get; set; }

            /// <summary>
            /// <para>The organization to which the user belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>design</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The account activation type.</para>
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
            /// <para>The password must be at least 10 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters (excluding spaces).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Wuying1234</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The phone number. The phone number is used to receive relevant text messages, such as notification text messages for cloud computer allocation. You must specify either the email address or the phone number.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;Phone numbers are not supported on the international site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bean</para>
            /// </summary>
            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// <para>The user remarks.</para>
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
