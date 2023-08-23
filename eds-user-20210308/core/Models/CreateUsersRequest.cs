// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateUsersRequest : TeaModel {
        /// <summary>
        /// The initial password. If this parameter is left empty, an email for password reset is sent to the specified email address.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Details of the convenience users.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<CreateUsersRequestUsers> Users { get; set; }
        public class CreateUsersRequestUsers : TeaModel {
            /// <summary>
            /// The email address of the end user. The email address is used to receive notifications about events such as desktop assignment. You must specify an email address or a mobile number to receive notifications.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The name of the end user. The name must be 3 to 24 characters in length, and can contain lowercase letters, digits, and underscores (\_).
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The organization to which the end user belongs.
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// The type of the account ownership.
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// The password of the end user.
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
            /// The remarks of the end user.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

    }

}
