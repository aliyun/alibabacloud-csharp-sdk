// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// Indicates whether the organization administrator. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("AdminUser")]
        [Validation(Required=false)]
        public bool? AdminUser { get; set; }

        /// <summary>
        /// Indicate whether the RAM user is a permission administrator. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("AuthAdminUser")]
        [Validation(Required=false)]
        public bool? AuthAdminUser { get; set; }

        /// <summary>
        /// The nickname of the account.
        /// 
        /// *   Format check: The value can be up to 50 characters in length.
        /// *   Special format verification: Chinese and English digits\_ \ / | () ] \[
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// The ID of the user to be updated. The user ID is the UserID of the Quick BI, not the UID of Alibaba Cloud.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The role type of the organization member. Valid values:
        /// 
        /// *   1 : developer
        /// *   2 : visitors
        /// *   3 : Analyst
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
