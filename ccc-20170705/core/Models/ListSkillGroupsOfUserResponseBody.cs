// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListSkillGroupsOfUserResponseBody : TeaModel {
        [NameInMap("SkillLevels")]
        [Validation(Required=false)]
        public ListSkillGroupsOfUserResponseBodySkillLevels SkillLevels { get; set; }
        public class ListSkillGroupsOfUserResponseBodySkillLevels : TeaModel {
            [NameInMap("SkillLevel")]
            [Validation(Required=false)]
            public List<ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevel> SkillLevel { get; set; }
            public class ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevel : TeaModel {
                [NameInMap("OutboundPhoneNumbers")]
                [Validation(Required=false)]
                public ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelOutboundPhoneNumbers OutboundPhoneNumbers { get; set; }
                public class ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelOutboundPhoneNumbers : TeaModel {
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelOutboundPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                    public class ListSkillGroupsOfUserResponseBodySkillLevelsSkillLevelOutboundPhoneNumbersPhoneNumber : TeaModel {
                        public bool? TestOnly { get; set; }
                        public int? Trunks { get; set; }
                        public int? RemainingTime { get; set; }
                        public string Number { get; set; }
                        public string City { get; set; }
                        public string InstanceId { get; set; }
                        public string Usage { get; set; }
                        public bool? AllowOutbound { get; set; }
                        public string PhoneNumberDescription { get; set; }
                        public string Province { get; set; }
                        public string PhoneNumberId { get; set; }
                    }
                };

                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("SkillGroupDescription")]
                [Validation(Required=false)]
                public string SkillGroupDescription { get; set; }

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
