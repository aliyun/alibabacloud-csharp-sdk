// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUserProvisioningEventsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the queried entries are truncated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The maximum number of entries per page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to initiate the next request.
        /// 
        /// >  This parameter is returned only when the `IsTruncated` parameter is set to `true`.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

        /// <summary>
        /// The RAM user provisioning events.
        /// </summary>
        [NameInMap("UserProvisioningEvents")]
        [Validation(Required=false)]
        public List<ListUserProvisioningEventsResponseBodyUserProvisioningEvents> UserProvisioningEvents { get; set; }
        public class ListUserProvisioningEventsResponseBodyUserProvisioningEvents : TeaModel {
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
            /// The number of execution failures.
            /// </summary>
            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// The error message that is displayed when the last execution of the RAM user provisioning event failed.
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// The ID of the RAM user provisioning event.
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// The time at which the RAM user provisioning event was last executed.
            /// </summary>
            [NameInMap("LatestAsyncTime")]
            [Validation(Required=false)]
            public string LatestAsyncTime { get; set; }

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
            /// *   User: The identity of the RAM user provisioning is a CloudSSO user.
            /// *   Group: The identity of the RAM user provisioning is a CloudSSO user group.
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// The type of the source operation. Valid values:
            /// 
            /// *   StartProvisioning: enables the RAM user provisioning.
            /// *   DeleteProvisioning: deletes the RAM user provisioning.
            /// *   AddUserToGroup: adds a user to a user group.
            /// *   RemoveUserFromGroup: removes a user from a user group.
            /// *   UserProvisioningDeletionClearing: deletes the RAM user provisioning and clears resources in the background.
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The ID of the object for which you create the RAM user provisioning.
            /// 
            /// The value is fixed as the ID of the account in the resource directory.````
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the object for which you create the RAM user provisioning.
            /// 
            /// If `RD-Account` is returned, the value of this parameter is the name of the account that is used to access the instance.``
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
