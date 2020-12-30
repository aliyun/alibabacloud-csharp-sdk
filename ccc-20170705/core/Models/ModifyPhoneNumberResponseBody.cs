// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifyPhoneNumberResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public ModifyPhoneNumberResponseBodyPhoneNumber PhoneNumber { get; set; }
        public class ModifyPhoneNumberResponseBodyPhoneNumber : TeaModel {
            [NameInMap("SkillGroups")]
            [Validation(Required=false)]
            public ModifyPhoneNumberResponseBodyPhoneNumberSkillGroups SkillGroups { get; set; }
            public class ModifyPhoneNumberResponseBodyPhoneNumberSkillGroups : TeaModel {
                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public List<ModifyPhoneNumberResponseBodyPhoneNumberSkillGroupsSkillGroup> SkillGroup { get; set; }
                public class ModifyPhoneNumberResponseBodyPhoneNumberSkillGroupsSkillGroup : TeaModel {
                    [NameInMap("SkillGroupName")]
                    [Validation(Required=false)]
                    public string SkillGroupName { get; set; }

                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                }

            }
            [NameInMap("TestOnly")]
            [Validation(Required=false)]
            public bool? TestOnly { get; set; }
            [NameInMap("Trunks")]
            [Validation(Required=false)]
            public int? Trunks { get; set; }
            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public int? RemainingTime { get; set; }
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }
            [NameInMap("AllowOutbound")]
            [Validation(Required=false)]
            public bool? AllowOutbound { get; set; }
            [NameInMap("PhoneNumberDescription")]
            [Validation(Required=false)]
            public string PhoneNumberDescription { get; set; }
            [NameInMap("ContactFlow")]
            [Validation(Required=false)]
            public ModifyPhoneNumberResponseBodyPhoneNumberContactFlow ContactFlow { get; set; }
            public class ModifyPhoneNumberResponseBodyPhoneNumberContactFlow : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("ContactFlowDescription")]
                [Validation(Required=false)]
                public string ContactFlowDescription { get; set; }

                [NameInMap("ContactFlowName")]
                [Validation(Required=false)]
                public string ContactFlowName { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ContactFlowId")]
                [Validation(Required=false)]
                public string ContactFlowId { get; set; }

            }
            [NameInMap("PhoneNumberId")]
            [Validation(Required=false)]
            public string PhoneNumberId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
