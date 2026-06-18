// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateUsersRequest : TeaModel {
        /// <summary>
        /// <para>The date and time when the system automatically locks the convenience user\&quot;s account. The value must be in the <c>yyyy-MM-dd HH:mm:ss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-28 00:00:00</para>
        /// </summary>
        [NameInMap("AutoLockTime")]
        [Validation(Required=false)]
        public string AutoLockTime { get; set; }

        /// <summary>
        /// <para>The business channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>Specifies whether to set the convenience user as a local administrator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLocalAdmin")]
        [Validation(Required=false)]
        public bool? IsLocalAdmin { get; set; }

        /// <summary>
        /// <para>The initial password. If you do not specify this parameter, the system sends a password reset email to the convenience user\&quot;s email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>By default, a convenience user\&quot;s password does not expire. You can use this parameter to specify a password validity period of 30 to 365 days. After the password expires, the user must reset it to log in again.</para>
        /// <remarks>
        /// <para>This feature is in invited preview. To use this feature, submit a ticket.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PasswordExpireDays")]
        [Validation(Required=false)]
        public string PasswordExpireDays { get; set; }

        /// <summary>
        /// <para>Details about the convenience users.</para>
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
            /// <para>The email address of the convenience user. This email address is used for notifications, such as an alert when a cloud computer is assigned. You must specify either this parameter or the <c>Phone</c> parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The user name. The user name must be 3 to 24 characters long and can contain lowercase letters, digits, and underscores (_).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("GroupIdList")]
            [Validation(Required=false)]
            public List<string> GroupIdList { get; set; }

            /// <summary>
            /// <para>The ID of the organization to which the convenience user belongs.</para>
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
            /// <para>The password for the convenience user.</para>
            /// <remarks>
            /// <para>The password must be at least 10 characters long and contain characters from at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters (excluding spaces).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Wuying1234</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>The phone number of the convenience user. This phone number is used for notifications, such as a text message when a cloud computer is assigned. You must specify either this parameter or the <c>Email</c> parameter.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>Phone numbers are not supported on the international site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The display name of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bean</para>
            /// </summary>
            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// <para>A remark for the convenience user.</para>
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
