// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            [NameInMap("SkillLevels")]
            [Validation(Required=false)]
            public GetUserResponseBodyUserSkillLevels SkillLevels { get; set; }
            public class GetUserResponseBodyUserSkillLevels : TeaModel {
                [NameInMap("SkillLevel")]
                [Validation(Required=false)]
                public List<GetUserResponseBodyUserSkillLevelsSkillLevel> SkillLevel { get; set; }
                public class GetUserResponseBodyUserSkillLevelsSkillLevel : TeaModel {
                    [NameInMap("Skill")]
                    [Validation(Required=false)]
                    public GetUserResponseBodyUserSkillLevelsSkillLevelSkill Skill { get; set; }
                    public class GetUserResponseBodyUserSkillLevelsSkillLevelSkill : TeaModel {
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
                    };

                    [NameInMap("SkillLevelId")]
                    [Validation(Required=false)]
                    public string SkillLevelId { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                }

            }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public GetUserResponseBodyUserRoles Roles { get; set; }
            public class GetUserResponseBodyUserRoles : TeaModel {
                [NameInMap("Role")]
                [Validation(Required=false)]
                public List<GetUserResponseBodyUserRolesRole> Role { get; set; }
                public class GetUserResponseBodyUserRolesRole : TeaModel {
                    [NameInMap("RoleDescription")]
                    [Validation(Required=false)]
                    public string RoleDescription { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public string RoleId { get; set; }

                }

            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("RamId")]
            [Validation(Required=false)]
            public string RamId { get; set; }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public GetUserResponseBodyUserDetail Detail { get; set; }
            public class GetUserResponseBodyUserDetail : TeaModel {
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

            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
