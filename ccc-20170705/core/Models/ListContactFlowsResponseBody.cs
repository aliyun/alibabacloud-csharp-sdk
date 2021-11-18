// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListContactFlowsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContactFlows")]
        [Validation(Required=false)]
        public ListContactFlowsResponseBodyContactFlows ContactFlows { get; set; }
        public class ListContactFlowsResponseBodyContactFlows : TeaModel {
            [NameInMap("ContactFlow")]
            [Validation(Required=false)]
            public List<ListContactFlowsResponseBodyContactFlowsContactFlow> ContactFlow { get; set; }
            public class ListContactFlowsResponseBodyContactFlowsContactFlow : TeaModel {
                public string AppliedVersion { get; set; }
                public string ContactFlowDescription { get; set; }
                public string ContactFlowId { get; set; }
                public string ContactFlowName { get; set; }
                public string InstanceId { get; set; }
                public ListContactFlowsResponseBodyContactFlowsContactFlowPhoneNumbers PhoneNumbers { get; set; }
                public class ListContactFlowsResponseBodyContactFlowsContactFlowPhoneNumbers : TeaModel {
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public List<ListContactFlowsResponseBodyContactFlowsContactFlowPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                    public class ListContactFlowsResponseBodyContactFlowsContactFlowPhoneNumbersPhoneNumber : TeaModel {
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
                public string Type { get; set; }
                public ListContactFlowsResponseBodyContactFlowsContactFlowVersions Versions { get; set; }
                public class ListContactFlowsResponseBodyContactFlowsContactFlowVersions : TeaModel {
                    [NameInMap("ContactFlowVersion")]
                    [Validation(Required=false)]
                    public List<ListContactFlowsResponseBodyContactFlowsContactFlowVersionsContactFlowVersion> ContactFlowVersion { get; set; }
                    public class ListContactFlowsResponseBodyContactFlowsContactFlowVersionsContactFlowVersion : TeaModel {
                        [NameInMap("ContactFlowVersionDescription")]
                        [Validation(Required=false)]
                        public string ContactFlowVersionDescription { get; set; }

                        [NameInMap("ContactFlowVersionId")]
                        [Validation(Required=false)]
                        public string ContactFlowVersionId { get; set; }

                        [NameInMap("LastModified")]
                        [Validation(Required=false)]
                        public string LastModified { get; set; }

                        [NameInMap("LastModifiedBy")]
                        [Validation(Required=false)]
                        public string LastModifiedBy { get; set; }

                        [NameInMap("LockedBy")]
                        [Validation(Required=false)]
                        public string LockedBy { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }
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
