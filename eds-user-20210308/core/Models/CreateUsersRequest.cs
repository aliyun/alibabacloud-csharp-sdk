// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateUsersRequest : TeaModel {
        /// <summary>
        /// The date on which the convenience users are automatically locked.
        /// </summary>
        [NameInMap("AutoLockTime")]
        [Validation(Required=false)]
        public string AutoLockTime { get; set; }

        [NameInMap("IsLocalAdmin")]
        [Validation(Required=false)]
        public bool? IsLocalAdmin { get; set; }

        /// <summary>
        /// The initial password. If this parameter is left empty, an email for password reset is sent to the specified email address.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PasswordExpireDays")]
        [Validation(Required=false)]
        public string PasswordExpireDays { get; set; }

        /// <summary>
        /// The information about the convenience user.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<CreateUsersRequestUsers> Users { get; set; }
        public class CreateUsersRequestUsers : TeaModel {
            /// <summary>
            /// The email address of the convenience user. The email address is used to receive notifications about events such as desktop assignment. You must specify an email address or a mobile number to receive notifications.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The username of the convenience user. The name can contain lowercase letters, digits, and underscores (_), and must be 3 to 24 characters in length.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The organization to which the convenience user belongs.
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// The type of the account ownership.
            /// 
            /// Valid values:
            /// 
            /// *   CreateFromManager: administrator-activated
            /// *   Normal: user-activated
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// The user password.
            /// 
            /// >  The password must be at least 10 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters (excluding spaces).
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// Mobile numbers are not supported on the international site (alibabacloud.com).
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// The display name of the end user.
            /// </summary>
            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// The remarks on the convenience user.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

    }

}
