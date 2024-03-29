// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetUserByExtensionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserByExtensionResponseBodyUser User { get; set; }
        public class GetUserByExtensionResponseBodyUser : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public GetUserByExtensionResponseBodyUserDetail Detail { get; set; }
            public class GetUserByExtensionResponseBodyUserDetail : TeaModel {
                [NameInMap("Department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("LoginName")]
                [Validation(Required=false)]
                public string LoginName { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("RamId")]
            [Validation(Required=false)]
            public string RamId { get; set; }
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<GetUserByExtensionResponseBodyUserRoles> Roles { get; set; }
            public class GetUserByExtensionResponseBodyUserRoles : TeaModel {
                public string InstanceId { get; set; }
                public string RoleDescription { get; set; }
                public string RoleId { get; set; }
                public string RoleName { get; set; }
            }
            [NameInMap("SkillLevels")]
            [Validation(Required=false)]
            public List<GetUserByExtensionResponseBodyUserSkillLevels> SkillLevels { get; set; }
            public class GetUserByExtensionResponseBodyUserSkillLevels : TeaModel {
                public int? Level { get; set; }
                public GetUserByExtensionResponseBodyUserSkillLevelsSkill Skill { get; set; }
                public class GetUserByExtensionResponseBodyUserSkillLevelsSkill : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("SkillGroupDescription")]
                    [Validation(Required=false)]
                    public string SkillGroupDescription { get; set; }

                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    [NameInMap("SkillGroupName")]
                    [Validation(Required=false)]
                    public string SkillGroupName { get; set; }

                }
                public string SkillLevelId { get; set; }
            }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
        };

    }

}
