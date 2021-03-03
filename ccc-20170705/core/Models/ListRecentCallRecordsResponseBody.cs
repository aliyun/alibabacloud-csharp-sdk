// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListRecentCallRecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("CallDetailRecords")]
        [Validation(Required=false)]
        public ListRecentCallRecordsResponseBodyCallDetailRecords CallDetailRecords { get; set; }
        public class ListRecentCallRecordsResponseBodyCallDetailRecords : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListRecentCallRecordsResponseBodyCallDetailRecordsList List { get; set; }
            public class ListRecentCallRecordsResponseBodyCallDetailRecordsList : TeaModel {
                [NameInMap("CallDetailRecord")]
                [Validation(Required=false)]
                public List<ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecord> CallDetailRecord { get; set; }
                public class ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecord : TeaModel {
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("Satisfaction")]
                    [Validation(Required=false)]
                    public int? Satisfaction { get; set; }

                    [NameInMap("ContactType")]
                    [Validation(Required=false)]
                    public string ContactType { get; set; }

                    [NameInMap("ContactDisposition")]
                    [Validation(Required=false)]
                    public string ContactDisposition { get; set; }

                    [NameInMap("CallingNumber")]
                    [Validation(Required=false)]
                    public string CallingNumber { get; set; }

                    [NameInMap("CalledNumber")]
                    [Validation(Required=false)]
                    public string CalledNumber { get; set; }

                    [NameInMap("AgentNames")]
                    [Validation(Required=false)]
                    public string AgentNames { get; set; }

                    [NameInMap("SkillGroupNames")]
                    [Validation(Required=false)]
                    public string SkillGroupNames { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("ExtraAttr")]
                    [Validation(Required=false)]
                    public string ExtraAttr { get; set; }

                    [NameInMap("SatisfactionDesc")]
                    [Validation(Required=false)]
                    public string SatisfactionDesc { get; set; }

                    [NameInMap("Feedback")]
                    [Validation(Required=false)]
                    public string Feedback { get; set; }

                    [NameInMap("Agents")]
                    [Validation(Required=false)]
                    public ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecordAgents Agents { get; set; }
                    public class ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecordAgents : TeaModel {
                        [NameInMap("CallDetailAgent")]
                        [Validation(Required=false)]
                        public List<ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecordAgentsCallDetailAgent> CallDetailAgent { get; set; }
                        public class ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecordAgentsCallDetailAgent : TeaModel {
                            public string ContactId { get; set; }
                            public string AgentId { get; set; }
                            public string AgentName { get; set; }
                            public string SkillGroupName { get; set; }
                            public int? QueueTime { get; set; }
                            public int? RingTime { get; set; }
                            public long? StartTime { get; set; }
                            public int? TalkTime { get; set; }
                            public int? HoldTime { get; set; }
                            public int? WorkTime { get; set; }
                            public string Satisfaction { get; set; }
                            public string Feedback { get; set; }
                        }
                    };

                    [NameInMap("Recordings")]
                    [Validation(Required=false)]
                    public ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecordRecordings Recordings { get; set; }
                    public class ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecordRecordings : TeaModel {
                        [NameInMap("Recording")]
                        [Validation(Required=false)]
                        public List<ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecordRecordingsRecording> Recording { get; set; }
                        public class ListRecentCallRecordsResponseBodyCallDetailRecordsListCallDetailRecordRecordingsRecording : TeaModel {
                            public string ContactId { get; set; }
                            public string ContactType { get; set; }
                            public string AgentId { get; set; }
                            public string AgentName { get; set; }
                            public string CallingNumber { get; set; }
                            public string CalledNumber { get; set; }
                            public long? StartTime { get; set; }
                            public int? Duration { get; set; }
                            public string FileName { get; set; }
                            public string FilePath { get; set; }
                            public string FileDescription { get; set; }
                            public string Channel { get; set; }
                            public string InstanceId { get; set; }
                        }
                    };

                }

            }
        };

    }

}
