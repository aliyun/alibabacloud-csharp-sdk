// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRoleResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The roles.
        /// </summary>
        [NameInMap("RoleList")]
        [Validation(Required=false)]
        public ListRoleResponseBodyRoleList RoleList { get; set; }
        public class ListRoleResponseBodyRoleList : TeaModel {
            [NameInMap("RoleItem")]
            [Validation(Required=false)]
            public List<ListRoleResponseBodyRoleListRoleItem> RoleItem { get; set; }
            public class ListRoleResponseBodyRoleListRoleItem : TeaModel {
                /// <summary>
                /// The set of permissions to be granted to the role.
                /// </summary>
                [NameInMap("ActionList")]
                [Validation(Required=false)]
                public ListRoleResponseBodyRoleListRoleItemActionList ActionList { get; set; }
                public class ListRoleResponseBodyRoleListRoleItemActionList : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public List<ListRoleResponseBodyRoleListRoleItemActionListAction> Action { get; set; }
                    public class ListRoleResponseBodyRoleListRoleItemActionListAction : TeaModel {
                        /// <summary>
                        /// The serial number of the permission that is granted to the role.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// The description of the permission to be granted to the role.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The ID of the permission group to which the permission that is granted to the role belongs.
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        /// <summary>
                        /// The name of the permission to be granted to the role.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// The roles.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public ListRoleResponseBodyRoleListRoleItemRole Role { get; set; }
                public class ListRoleResponseBodyRoleListRoleItemRole : TeaModel {
                    /// <summary>
                    /// The ID of the Alibaba Cloud account.
                    /// </summary>
                    [NameInMap("AdminUserId")]
                    [Validation(Required=false)]
                    public string AdminUserId { get; set; }

                    /// <summary>
                    /// The timestamp when the role was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// The ID of the role.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    /// <summary>
                    /// Indicates whether the role is a default role.
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// The name of the role.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The timestamp when the role was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

            }

        }

    }

}
