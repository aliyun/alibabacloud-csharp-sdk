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

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public AddBulkPhoneNumbersResponseBodyPhoneNumbers PhoneNumbers { get; set; }
        public class AddBulkPhoneNumbersResponseBodyPhoneNumbers : TeaModel {
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public List<AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
            public class AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumber : TeaModel {
                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public List<AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroup> SkillGroup { get; set; }
                public class AddBulkPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroup : TeaModel {
                    [NameInMap("SkillGroupName")]
                    [Validation(Required=false)]
                    public string SkillGroupName { get; set; }

                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                }

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

        [NameInMap("FailedPhoneNumbers")]
        [Validation(Required=false)]
        public AddBulkPhoneNumbersResponseBodyFailedPhoneNumbers FailedPhoneNumbers { get; set; }
        public class AddBulkPhoneNumbersResponseBodyFailedPhoneNumbers : TeaModel {
            [NameInMap("FailedPhoneNumber")]
            [Validation(Required=false)]
            public List<string> FailedPhoneNumber { get; set; }
        };

        [NameInMap("UserdPhoneNumbers")]
        [Validation(Required=false)]
        public AddBulkPhoneNumbersResponseBodyUserdPhoneNumbers UserdPhoneNumbers { get; set; }
        public class AddBulkPhoneNumbersResponseBodyUserdPhoneNumbers : TeaModel {
            [NameInMap("UserdPhoneNumber")]
            [Validation(Required=false)]
            public List<string> UserdPhoneNumber { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
