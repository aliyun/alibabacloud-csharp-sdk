// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListRealTimeAgentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRealTimeAgentResponseBodyData Data { get; set; }
        public class ListRealTimeAgentResponseBodyData : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListRealTimeAgentResponseBodyDataUser> User { get; set; }
            public class ListRealTimeAgentResponseBodyDataUser : TeaModel {
                public string DisplayName { get; set; }
                public string Dn { get; set; }
                public string Phone { get; set; }
                public string RamId { get; set; }
                public ListRealTimeAgentResponseBodyDataUserSkillLevels SkillLevels { get; set; }
                public class ListRealTimeAgentResponseBodyDataUserSkillLevels : TeaModel {
                    [NameInMap("SkillLevel")]
                    [Validation(Required=false)]
                    public List<ListRealTimeAgentResponseBodyDataUserSkillLevelsSkillLevel> SkillLevel { get; set; }
                    public class ListRealTimeAgentResponseBodyDataUserSkillLevelsSkillLevel : TeaModel {
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public int? Level { get; set; }

                        [NameInMap("Skill")]
                        [Validation(Required=false)]
                        public ListRealTimeAgentResponseBodyDataUserSkillLevelsSkillLevelSkill Skill { get; set; }
                        public class ListRealTimeAgentResponseBodyDataUserSkillLevelsSkillLevelSkill : TeaModel {
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
                        };

                        [NameInMap("SkillLevelId")]
                        [Validation(Required=false)]
                        public string SkillLevelId { get; set; }

                    }

                }
                public string State { get; set; }
                public string StateDesc { get; set; }
            }
        };

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

    }

}
