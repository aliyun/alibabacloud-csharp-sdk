// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateContactFlowResponseBody : TeaModel {
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

        [NameInMap("ContactFlow")]
        [Validation(Required=false)]
        public CreateContactFlowResponseBodyContactFlow ContactFlow { get; set; }
        public class CreateContactFlowResponseBodyContactFlow : TeaModel {
            [NameInMap("ContactFlowDescription")]
            [Validation(Required=false)]
            public string ContactFlowDescription { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("PhoneNumbers")]
            [Validation(Required=false)]
            public CreateContactFlowResponseBodyContactFlowPhoneNumbers PhoneNumbers { get; set; }
            public class CreateContactFlowResponseBodyContactFlowPhoneNumbers : TeaModel {
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public List<CreateContactFlowResponseBodyContactFlowPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                public class CreateContactFlowResponseBodyContactFlowPhoneNumbersPhoneNumber : TeaModel {
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

                    [NameInMap("PhoneNumberId")]
                    [Validation(Required=false)]
                    public string PhoneNumberId { get; set; }

                }

            }
            [NameInMap("ContactFlowName")]
            [Validation(Required=false)]
            public string ContactFlowName { get; set; }
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public CreateContactFlowResponseBodyContactFlowVersions Versions { get; set; }
            public class CreateContactFlowResponseBodyContactFlowVersions : TeaModel {
                [NameInMap("ContactFlowVersion")]
                [Validation(Required=false)]
                public List<CreateContactFlowResponseBodyContactFlowVersionsContactFlowVersion> ContactFlowVersion { get; set; }
                public class CreateContactFlowResponseBodyContactFlowVersionsContactFlowVersion : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("LastModified")]
                    [Validation(Required=false)]
                    public string LastModified { get; set; }

                    [NameInMap("Canvas")]
                    [Validation(Required=false)]
                    public string Canvas { get; set; }

                    [NameInMap("LockedBy")]
                    [Validation(Required=false)]
                    public string LockedBy { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("ContactFlowVersionId")]
                    [Validation(Required=false)]
                    public string ContactFlowVersionId { get; set; }

                    [NameInMap("LastModifiedBy")]
                    [Validation(Required=false)]
                    public string LastModifiedBy { get; set; }

                    [NameInMap("ContactFlowVersionDescription")]
                    [Validation(Required=false)]
                    public string ContactFlowVersionDescription { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }

            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("ContactFlowId")]
            [Validation(Required=false)]
            public string ContactFlowId { get; set; }
            [NameInMap("AppliedVersion")]
            [Validation(Required=false)]
            public string AppliedVersion { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
