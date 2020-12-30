// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListUsersOfSkillGroupResponseBody : TeaModel {
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
        public ListUsersOfSkillGroupResponseBodyUsers Users { get; set; }
        public class ListUsersOfSkillGroupResponseBodyUsers : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListUsersOfSkillGroupResponseBodyUsersList List { get; set; }
            public class ListUsersOfSkillGroupResponseBodyUsersList : TeaModel {
                [NameInMap("User")]
                [Validation(Required=false)]
                public List<ListUsersOfSkillGroupResponseBodyUsersListUser> User { get; set; }
                public class ListUsersOfSkillGroupResponseBodyUsersListUser : TeaModel {
                    [NameInMap("SkillLevels")]
                    [Validation(Required=false)]
                    public ListUsersOfSkillGroupResponseBodyUsersListUserSkillLevels SkillLevels { get; set; }
                    public class ListUsersOfSkillGroupResponseBodyUsersListUserSkillLevels : TeaModel {
                        [NameInMap("SkillLevel")]
                        [Validation(Required=false)]
                        public List<ListUsersOfSkillGroupResponseBodyUsersListUserSkillLevelsSkillLevel> SkillLevel { get; set; }
                        public class ListUsersOfSkillGroupResponseBodyUsersListUserSkillLevelsSkillLevel : TeaModel {
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

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("Roles")]
                    [Validation(Required=false)]
                    public ListUsersOfSkillGroupResponseBodyUsersListUserRoles Roles { get; set; }
                    public class ListUsersOfSkillGroupResponseBodyUsersListUserRoles : TeaModel {
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public List<ListUsersOfSkillGroupResponseBodyUsersListUserRolesRole> Role { get; set; }
                        public class ListUsersOfSkillGroupResponseBodyUsersListUserRolesRole : TeaModel {
                            public string RoleDescription { get; set; }
                            public ListUsersOfSkillGroupResponseBodyUsersListUserRolesRolePrivileges Privileges { get; set; }
                            public class ListUsersOfSkillGroupResponseBodyUsersListUserRolesRolePrivileges : TeaModel {
                                [NameInMap("Privilege")]
                                [Validation(Required=false)]
                                public List<ListUsersOfSkillGroupResponseBodyUsersListUserRolesRolePrivilegesPrivilege> Privilege { get; set; }
                                public class ListUsersOfSkillGroupResponseBodyUsersListUserRolesRolePrivilegesPrivilege : TeaModel {
                                    [NameInMap("PrivilegeName")]
                                    [Validation(Required=false)]
                                    public string PrivilegeName { get; set; }

                                    [NameInMap("PrivilegeId")]
                                    [Validation(Required=false)]
                                    public string PrivilegeId { get; set; }

                                    [NameInMap("PrivilegeDescription")]
                                    [Validation(Required=false)]
                                    public string PrivilegeDescription { get; set; }

                                }

                            }
                            public int? UserCount { get; set; }
                            public string RoleName { get; set; }
                            public string InstanceId { get; set; }
                            public string RoleId { get; set; }
                        }
                    };

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("RamId")]
                    [Validation(Required=false)]
                    public string RamId { get; set; }

                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public ListUsersOfSkillGroupResponseBodyUsersListUserDetail Detail { get; set; }
                    public class ListUsersOfSkillGroupResponseBodyUsersListUserDetail : TeaModel {
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
