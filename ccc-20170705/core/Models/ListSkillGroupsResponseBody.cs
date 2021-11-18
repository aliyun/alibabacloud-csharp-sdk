// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListSkillGroupsResponseBody : TeaModel {
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

        [NameInMap("SkillGroups")]
        [Validation(Required=false)]
        public ListSkillGroupsResponseBodySkillGroups SkillGroups { get; set; }
        public class ListSkillGroupsResponseBodySkillGroups : TeaModel {
            [NameInMap("SkillGroup")]
            [Validation(Required=false)]
            public List<ListSkillGroupsResponseBodySkillGroupsSkillGroup> SkillGroup { get; set; }
            public class ListSkillGroupsResponseBodySkillGroupsSkillGroup : TeaModel {
                public string AccQueueName { get; set; }
                public string AccSkillGroupName { get; set; }
                public string InstanceId { get; set; }
                public ListSkillGroupsResponseBodySkillGroupsSkillGroupOutboundPhoneNumbers OutboundPhoneNumbers { get; set; }
                public class ListSkillGroupsResponseBodySkillGroupsSkillGroupOutboundPhoneNumbers : TeaModel {
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupsResponseBodySkillGroupsSkillGroupOutboundPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                    public class ListSkillGroupsResponseBodySkillGroupsSkillGroupOutboundPhoneNumbersPhoneNumber : TeaModel {
                        [NameInMap("AllowOutbound")]
                        [Validation(Required=false)]
                        public bool? AllowOutbound { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("Number")]
                        [Validation(Required=false)]
                        public string Number { get; set; }

                        [NameInMap("PhoneNumberDescription")]
                        [Validation(Required=false)]
                        public string PhoneNumberDescription { get; set; }

                        [NameInMap("PhoneNumberId")]
                        [Validation(Required=false)]
                        public string PhoneNumberId { get; set; }

                        [NameInMap("RemainingTime")]
                        [Validation(Required=false)]
                        public int? RemainingTime { get; set; }

                        [NameInMap("TestOnly")]
                        [Validation(Required=false)]
                        public bool? TestOnly { get; set; }

                        [NameInMap("Trunks")]
                        [Validation(Required=false)]
                        public int? Trunks { get; set; }

                        [NameInMap("Usage")]
                        [Validation(Required=false)]
                        public string Usage { get; set; }

                    }

                }
                public string RoutingStrategy { get; set; }
                public string SkillGroupDescription { get; set; }
                public string SkillGroupId { get; set; }
                public string SkillGroupName { get; set; }
                public int? UserCount { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
