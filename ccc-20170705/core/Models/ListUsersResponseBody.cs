// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUsers Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListUsersResponseBodyUsersList List { get; set; }
            public class ListUsersResponseBodyUsersList : TeaModel {
                [NameInMap("User")]
                [Validation(Required=false)]
                public List<ListUsersResponseBodyUsersListUser> User { get; set; }
                public class ListUsersResponseBodyUsersListUser : TeaModel {
                    [NameInMap("SkillLevels")]
                    [Validation(Required=false)]
                    public ListUsersResponseBodyUsersListUserSkillLevels SkillLevels { get; set; }
                    public class ListUsersResponseBodyUsersListUserSkillLevels : TeaModel {
                        [NameInMap("SkillLevel")]
                        [Validation(Required=false)]
                        public List<ListUsersResponseBodyUsersListUserSkillLevelsSkillLevel> SkillLevel { get; set; }
                        public class ListUsersResponseBodyUsersListUserSkillLevelsSkillLevel : TeaModel {
                            [NameInMap("SkillGroupId")]
                            [Validation(Required=false)]
                            public string SkillGroupId { get; set; }

                            [NameInMap("SkillGroupName")]
                            [Validation(Required=false)]
                            public string SkillGroupName { get; set; }

                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }

                            [NameInMap("SkillGroupDescription")]
                            [Validation(Required=false)]
                            public string SkillGroupDescription { get; set; }

                        }
                    };

                    [NameInMap("PrivateOutboundNumberId")]
                    [Validation(Required=false)]
                    public string PrivateOutboundNumberId { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("Roles")]
                    [Validation(Required=false)]
                    public ListUsersResponseBodyUsersListUserRoles Roles { get; set; }
                    public class ListUsersResponseBodyUsersListUserRoles : TeaModel {
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public List<ListUsersResponseBodyUsersListUserRolesRole> Role { get; set; }
                        public class ListUsersResponseBodyUsersListUserRolesRole : TeaModel {
                            public string RoleDescription { get; set; }
                            public string InstanceId { get; set; }
                            public string RoleName { get; set; }
                            public string RoleId { get; set; }
                        }
                    };

                    [NameInMap("Primary")]
                    [Validation(Required=false)]
                    public bool? Primary { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("RamId")]
                    [Validation(Required=false)]
                    public string RamId { get; set; }

                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public ListUsersResponseBodyUsersListUserDetail Detail { get; set; }
                    public class ListUsersResponseBodyUsersListUserDetail : TeaModel {
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }
                        [NameInMap("Email")]
                        [Validation(Required=false)]
                        public string Email { get; set; }
                        [NameInMap("LoginName")]
                        [Validation(Required=false)]
                        public string LoginName { get; set; }
                        [NameInMap("Department")]
                        [Validation(Required=false)]
                        public string Department { get; set; }
                        [NameInMap("Phone")]
                        [Validation(Required=false)]
                        public string Phone { get; set; }
                    };

                }

            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
