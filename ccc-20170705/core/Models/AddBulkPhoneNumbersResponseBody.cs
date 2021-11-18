// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class AddBulkPhoneNumbersResponseBody : TeaModel {
        [NameInMap("ArrearagePhoneNumbers")]
        [Validation(Required=false)]
        public AddBulkPhoneNumbersResponseBodyArrearagePhoneNumbers ArrearagePhoneNumbers { get; set; }
        public class AddBulkPhoneNumbersResponseBodyArrearagePhoneNumbers : TeaModel {
            [NameInMap("ArrearagePhoneNumber")]
            [Validation(Required=false)]
            public List<string> ArrearagePhoneNumber { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FailedPhoneNumbers")]
        [Validation(Required=false)]
        public AddBulkPhoneNumbersResponseBodyFailedPhoneNumbers FailedPhoneNumbers { get; set; }
        public class AddBulkPhoneNumbersResponseBodyFailedPhoneNumbers : TeaModel {
            [NameInMap("FailedPhoneNumber")]
            [Validation(Required=false)]
            public List<string> FailedPhoneNumber { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public AddBulkPhoneNumbersResponseBodyPhoneNumbers PhoneNumbers { get; set; }
        public class AddBulkPhoneNumbersResponseBodyPhoneNumbers : TeaModel {
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public List<AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
            public class AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumber : TeaModel {
                public bool? AllowOutbound { get; set; }
                public AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumberContactFlow ContactFlow { get; set; }
                public class AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumberContactFlow : TeaModel {
                    [NameInMap("ContactFlowDescription")]
                    [Validation(Required=false)]
                    public string ContactFlowDescription { get; set; }

                    [NameInMap("ContactFlowId")]
                    [Validation(Required=false)]
                    public string ContactFlowId { get; set; }

                    [NameInMap("ContactFlowName")]
                    [Validation(Required=false)]
                    public string ContactFlowName { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
                public string InstanceId { get; set; }
                public string Number { get; set; }
                public string PhoneNumberDescription { get; set; }
                public string PhoneNumberId { get; set; }
                public int? RemainingTime { get; set; }
                public AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroups SkillGroups { get; set; }
                public class AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroups : TeaModel {
                    [NameInMap("SkillGroup")]
                    [Validation(Required=false)]
                    public List<AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroupsSkillGroup> SkillGroup { get; set; }
                    public class AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroupsSkillGroup : TeaModel {
                        [NameInMap("SkillGroupId")]
                        [Validation(Required=false)]
                        public string SkillGroupId { get; set; }

                        [NameInMap("SkillGroupName")]
                        [Validation(Required=false)]
                        public string SkillGroupName { get; set; }

                    }

                }
                public bool? TestOnly { get; set; }
                public int? Trunks { get; set; }
                public string Usage { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("UserdPhoneNumbers")]
        [Validation(Required=false)]
        public AddBulkPhoneNumbersResponseBodyUserdPhoneNumbers UserdPhoneNumbers { get; set; }
        public class AddBulkPhoneNumbersResponseBodyUserdPhoneNumbers : TeaModel {
            [NameInMap("UserdPhoneNumber")]
            [Validation(Required=false)]
            public List<string> UserdPhoneNumber { get; set; }
        };

    }

}
