// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserProvisioningResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the RAM user provisioning.
        /// </summary>
        [NameInMap("UserProvisioning")]
        [Validation(Required=false)]
        public UpdateUserProvisioningResponseBodyUserProvisioning UserProvisioning { get; set; }
        public class UpdateUserProvisioningResponseBodyUserProvisioning : TeaModel {
            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The deletion policy. The policy is used to manage synchronized users when you delete the RAM user provisioning. Valid values:
            /// 
            /// *   Delete: When you delete the RAM user provisioning, the system deletes the synchronized users.
            /// *   Keep: When you delete the RAM user provisioning, the system retains the synchronized users.
            /// </summary>
            [NameInMap("DeletionStrategy")]
            [Validation(Required=false)]
            public string DeletionStrategy { get; set; }

            /// <summary>
            /// The description for the RAM user provisioning.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The conflict handling policy. The policy is used when a RAM user has the same username as the CloudSSO user who is synchronized to RAM. Valid values:
            /// 
            /// *   KeepBoth: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system creates a RAM user whose username is the username of the CloudSSO user plus the suffix `_sso`.
            /// *   TakeOver: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system replaces the RAM user with the CloudSSO user.
            /// </summary>
            [NameInMap("DuplicationStrategy")]
            [Validation(Required=false)]
            public string DuplicationStrategy { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource directory belongs.
            /// </summary>
            [NameInMap("OwnerPk")]
            [Validation(Required=false)]
            public string OwnerPk { get; set; }

            /// <summary>
            /// The identity ID of the RAM user provisioning. Valid values:
            /// 
            /// *   If `Group` is returned for the `PrincipalType` parameter, the value of this parameter is the ID of a CloudSSO user group (g-\\*\\*\\*\\*\\*\\*\\*\\*).
            /// *   If `User` is returned for the `PrincipalType` parameter, the value of this parameter is the ID of a CloudSSO user (u-\\*\\*\\*\\*\\*\\*\\*\\*).
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// The identity name of the RAM user provisioning. Valid values:
            /// 
            /// *   If `Group` is returned for the `PrincipalType` parameter, the value of this parameter is the name of a CloudSSO user group.
            /// *   If `User` is returned for the `PrincipalType` parameter, the value of this parameter is the name of a CloudSSO user.
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// The identity type of the RAM user provisioning. Valid values:
            /// 
            /// *   User: indicates that the identity of the RAM user provisioning is a CloudSSO user.
            /// *   Group: indicates that the identity of the RAM user provisioning is a CloudSSO user group.
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// The status of the RAM user provisioning. Valid values:
            /// 
            /// *   Enabled
            /// *   Disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the object for which you create the RAM user provisioning. The value is fixed as the ID of the account in the resource directory.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the object for which you create the RAM user provisioning. The value is fixed as the name of the resource directory.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The path of the resource directory in which you create the RAM user provisioning for the object.
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// The object for which you create the RAM user provisioning. The value is fixed as `RD-Account`.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The modification time.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// The ID of the RAM user provisioning.
            /// </summary>
            [NameInMap("UserProvisioningId")]
            [Validation(Required=false)]
            public string UserProvisioningId { get; set; }

        }

    }

}
