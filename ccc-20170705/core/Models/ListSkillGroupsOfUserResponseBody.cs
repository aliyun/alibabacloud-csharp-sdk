// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListSkillGroupsOfUserResponseBody : TeaModel {
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

        [NameInMap("SkillLevels")]
        [Validation(Required=false)]
        public ListSkillGroupsOfUserResponseBodySkillLevels SkillLevels { get; set; }
        public class ListSkillGroupsOfUserResponseBodySkillLevels : TeaModel {
            [NameInMap("SkillLevel")]
            [Validation(Required=false)]
            public List<ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevel> SkillLevel { get; set; }
            public class ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevel : TeaModel {
                public int? Level { get; set; }
                public ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelSkill Skill { get; set; }
                public class ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelSkill : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("OutboundPhoneNumbers")]
                    [Validation(Required=false)]
                    public ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelSkillOutboundPhoneNumbers OutboundPhoneNumbers { get; set; }
                    public class ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelSkillOutboundPhoneNumbers : TeaModel {
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public List<ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelSkillOutboundPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                        public class ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelSkillOutboundPhoneNumbersPhoneNumber : TeaModel {
                            public bool? AllowOutbound { get; set; }
                            public string City { get; set; }
                            public string InstanceId { get; set; }
                            public string Number { get; set; }
                            public string PhoneNumberDescription { get; set; }
                            public string PhoneNumberId { get; set; }
                            public string Province { get; set; }
                            public int? RemainingTime { get; set; }
                            public bool? TestOnly { get; set; }
                            public int? Trunks { get; set; }
                            public string Usage { get; set; }
                        }
                    };

                    [NameInMap("RoutingStrategy")]
                    [Validation(Required=false)]
                    public string RoutingStrategy { get; set; }

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
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
