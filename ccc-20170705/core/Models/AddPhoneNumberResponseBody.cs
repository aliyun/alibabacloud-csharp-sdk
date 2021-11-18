// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class AddPhoneNumberResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public AddPhoneNumberResponseBodyPhoneNumber PhoneNumber { get; set; }
        public class AddPhoneNumberResponseBodyPhoneNumber : TeaModel {
            [NameInMap("AllowOutbound")]
            [Validation(Required=false)]
            public bool? AllowOutbound { get; set; }
            [NameInMap("ContactFlow")]
            [Validation(Required=false)]
            public AddPhoneNumberResponseBodyPhoneNumberContactFlow ContactFlow { get; set; }
            public class AddPhoneNumberResponseBodyPhoneNumberContactFlow : TeaModel {
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
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
