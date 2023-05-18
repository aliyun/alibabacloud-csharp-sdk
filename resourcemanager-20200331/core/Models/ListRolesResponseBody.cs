// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListRolesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the RAM roles.
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public ListRolesResponseBodyRoles Roles { get; set; }
        public class ListRolesResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyRolesRole> Role { get; set; }
            public class ListRolesResponseBodyRolesRole : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the RAM role.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The time when the RAM role was created.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The description of the RAM role.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether the RAM role is a service linked role.
                /// </summary>
                [NameInMap("IsServiceLinkedRole")]
                [Validation(Required=false)]
                public bool? IsServiceLinkedRole { get; set; }

                /// <summary>
                /// The information of the most recent deletion task.
                /// </summary>
                [NameInMap("LatestDeletionTask")]
                [Validation(Required=false)]
                public ListRolesResponseBodyRolesRoleLatestDeletionTask LatestDeletionTask { get; set; }
                public class ListRolesResponseBodyRolesRoleLatestDeletionTask : TeaModel {
                    /// <summary>
                    /// The time when the deletion task was created.
                    /// </summary>
                    [NameInMap("CreateDate")]
                    [Validation(Required=false)]
                    public string CreateDate { get; set; }

                    /// <summary>
                    /// The ID of the deletion task.
                    /// </summary>
                    [NameInMap("DeletionTaskId")]
                    [Validation(Required=false)]
                    public string DeletionTaskId { get; set; }

                }

                /// <summary>
                /// The maximum session duration of the RAM role.
                /// </summary>
                [NameInMap("MaxSessionDuration")]
                [Validation(Required=false)]
                public long? MaxSessionDuration { get; set; }

                /// <summary>
                /// The ID of the RAM role.
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// The name of the RAM role.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// The name of the RAM role after authorization.
                /// </summary>
                [NameInMap("RolePrincipalName")]
                [Validation(Required=false)]
                public string RolePrincipalName { get; set; }

                /// <summary>
                /// The time when the RAM role was updated.
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// The total number of RAM roles.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
