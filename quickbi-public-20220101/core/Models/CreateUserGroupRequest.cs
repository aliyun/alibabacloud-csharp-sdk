// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateUserGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the parent user group. You can add new user groups to this group:
        /// 
        /// *   If you enter the ID of a parent user group, the new user group is added to the user group with the ID.
        /// *   If you enter -1, the new user group is added to the root directory.
        /// </summary>
        [NameInMap("ParentUserGroupId")]
        [Validation(Required=false)]
        public string ParentUserGroupId { get; set; }

        /// <summary>
        /// The description of the user group.
        /// 
        /// *   Format verification: Maximum length 255
        /// *   Special format verification: Chinese and English digits\_ \ / | () ] \[
        /// </summary>
        [NameInMap("UserGroupDescription")]
        [Validation(Required=false)]
        public string UserGroupDescription { get; set; }

        /// <summary>
        /// The unique ID of the user group.
        /// 
        /// *   If you specify the UserGroupId parameter, the system automatically generates the UserGroupId parameter. If you specify the UserGroupId parameter, the user ID is used as the user group ID. You must ensure that the user ID is unique within the organization.
        /// *   Format verification: Maximum length 64, cannot be -1,
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// The name of the RAM user group.
        /// 
        /// *   Format verification: Maximum length 255
        /// *   Special format verification: Chinese and English digits\_ \ / | () ] \[
        /// </summary>
        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

    }

}
