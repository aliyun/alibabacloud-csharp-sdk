// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListVoiceAppraiseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContactFlow")]
        [Validation(Required=false)]
        public ListVoiceAppraiseResponseBodyContactFlow ContactFlow { get; set; }
        public class ListVoiceAppraiseResponseBodyContactFlow : TeaModel {
            [NameInMap("AppliedVersion")]
            [Validation(Required=false)]
            public string AppliedVersion { get; set; }
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
            [NameInMap("PhoneNumbers")]
            [Validation(Required=false)]
            public ListVoiceAppraiseResponseBodyContactFlowPhoneNumbers PhoneNumbers { get; set; }
            public class ListVoiceAppraiseResponseBodyContactFlowPhoneNumbers : TeaModel {
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public List<ListVoiceAppraiseResponseBodyContactFlowPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                public class ListVoiceAppraiseResponseBodyContactFlowPhoneNumbersPhoneNumber : TeaModel {
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

                    [NameInMap("Trunks")]
                    [Validation(Required=false)]
                    public int? Trunks { get; set; }

                }

            }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public ListVoiceAppraiseResponseBodyContactFlowVersions Versions { get; set; }
            public class ListVoiceAppraiseResponseBodyContactFlowVersions : TeaModel {
                [NameInMap("ContactFlowVersion")]
                [Validation(Required=false)]
                public List<ListVoiceAppraiseResponseBodyContactFlowVersionsContactFlowVersion> ContactFlowVersion { get; set; }
                public class ListVoiceAppraiseResponseBodyContactFlowVersionsContactFlowVersion : TeaModel {
                    [NameInMap("ContactFlowVersionDescription")]
                    [Validation(Required=false)]
                    public string ContactFlowVersionDescription { get; set; }

                    [NameInMap("ContactFlowVersionId")]
                    [Validation(Required=false)]
                    public string ContactFlowVersionId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("LastModified")]
                    [Validation(Required=false)]
                    public string LastModified { get; set; }

                    [NameInMap("LastModifiedBy")]
                    [Validation(Required=false)]
                    public string LastModifiedBy { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Notice")]
        [Validation(Required=false)]
        public string Notice { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
