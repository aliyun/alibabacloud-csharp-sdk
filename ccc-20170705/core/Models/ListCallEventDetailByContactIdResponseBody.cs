// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListCallEventDetailByContactIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCallEventDetailByContactIdResponseBodyData Data { get; set; }
        public class ListCallEventDetailByContactIdResponseBodyData : TeaModel {
            [NameInMap("CallType")]
            [Validation(Required=false)]
            public string CallType { get; set; }
            [NameInMap("Callee")]
            [Validation(Required=false)]
            public string Callee { get; set; }
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }
            [NameInMap("Events")]
            [Validation(Required=false)]
            public ListCallEventDetailByContactIdResponseBodyDataEvents Events { get; set; }
            public class ListCallEventDetailByContactIdResponseBodyDataEvents : TeaModel {
                [NameInMap("CallEventDetail")]
                [Validation(Required=false)]
                public List<ListCallEventDetailByContactIdResponseBodyDataEventsCallEventDetail> CallEventDetail { get; set; }
                public class ListCallEventDetailByContactIdResponseBodyDataEventsCallEventDetail : TeaModel {
                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                    [NameInMap("CallMode")]
                    [Validation(Required=false)]
                    public string CallMode { get; set; }

                    [NameInMap("DetailData")]
                    [Validation(Required=false)]
                    public ListCallEventDetailByContactIdResponseBodyDataEventsCallEventDetailDetailData DetailData { get; set; }
                    public class ListCallEventDetailByContactIdResponseBodyDataEventsCallEventDetailDetailData : TeaModel {
                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public string EventType { get; set; }
                        [NameInMap("HangUper")]
                        [Validation(Required=false)]
                        public string HangUper { get; set; }
                        [NameInMap("Helper")]
                        [Validation(Required=false)]
                        public string Helper { get; set; }
                        [NameInMap("SatisfactionalResearch")]
                        [Validation(Required=false)]
                        public string SatisfactionalResearch { get; set; }
                        [NameInMap("SkillGroup")]
                        [Validation(Required=false)]
                        public string SkillGroup { get; set; }
                    };

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TimeStamp")]
                    [Validation(Required=false)]
                    public string TimeStamp { get; set; }

                }

            }
            [NameInMap("PrivacyNumber")]
            [Validation(Required=false)]
            public string PrivacyNumber { get; set; }
            [NameInMap("ReleaseAgent")]
            [Validation(Required=false)]
            public string ReleaseAgent { get; set; }
            [NameInMap("ReleaseReason")]
            [Validation(Required=false)]
            public string ReleaseReason { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
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
