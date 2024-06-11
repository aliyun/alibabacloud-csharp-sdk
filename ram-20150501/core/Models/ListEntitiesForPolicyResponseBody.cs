// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListEntitiesForPolicyResponseBody : TeaModel {
        /// <summary>
        /// The list of the RAM user groups.
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyGroups Groups { get; set; }
        public class ListEntitiesForPolicyResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyGroupsGroup> Group { get; set; }
            public class ListEntitiesForPolicyResponseBodyGroupsGroup : TeaModel {
                /// <summary>
                /// The time when the policy was attached to the RAM user group.
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// The description of the RAM user group.
                /// </summary>
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                /// <summary>
                /// The name of the RAM user group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of RAM roles.
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyRoles Roles { get; set; }
        public class ListEntitiesForPolicyResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyRolesRole> Role { get; set; }
            public class ListEntitiesForPolicyResponseBodyRolesRole : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the RAM role.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The time when the policy was attached to the RAM user.
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// The description of the RAM role.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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

            }

        }

        /// <summary>
        /// The list of the RAM users to which the policy is attached.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyUsers Users { get; set; }
        public class ListEntitiesForPolicyResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyUsersUser> User { get; set; }
            public class ListEntitiesForPolicyResponseBodyUsersUser : TeaModel {
                /// <summary>
                /// The time when the policy was attached to the RAM user.
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// The display name of the RAM user.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The unique ID of the RAM user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The name of the RAM user.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
