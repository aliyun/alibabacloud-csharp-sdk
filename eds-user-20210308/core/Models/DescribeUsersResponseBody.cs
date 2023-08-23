// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUsersResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the convenience users.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeUsersResponseBodyUsers> Users { get; set; }
        public class DescribeUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// The email address.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The name of the user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether the user is an administrator. If the convenience user is of the administrator-activated type, you must specify a user administrator. Notifications such as password reset on a client are sent to the email address or mobile phone of the user administrator. For more information, see [Create a convenience user](~~214472~~).
            /// </summary>
            [NameInMap("IsTenantManager")]
            [Validation(Required=false)]
            public bool? IsTenantManager { get; set; }

            /// <summary>
            /// The nickname of the user.
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// The ID of the organization to which the user belongs.
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// The type of the convenience account.
            /// 
            /// *   The administrator-activated type. The administrator specifies the username and the password of the convenience account. User notifications such as password reset are sent to the email address or mobile number of the administrator.
            /// *   The user-activated type. The administrator specifies the username and the email address or mobile number of a user. Activation notifications are sent to the email address or mobile number of the user.
            /// 
            /// Valid values:
            /// 
            /// *   CreateFromManager
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     administrator-activated
            /// 
            ///     <!-- -->
            /// 
            /// *   Normal: user-activated
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// The mobile number of the user. If you leave this parameter empty, the value of this parameter is not returned.
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// The remarks on the user.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the user.
            /// 
            /// Valid values:
            /// 
            /// *   0: The user status is normal.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   9: The user is locked.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// The user ID that is globally unique.
            /// </summary>
            [NameInMap("WyId")]
            [Validation(Required=false)]
            public string WyId { get; set; }

        }

    }

}
