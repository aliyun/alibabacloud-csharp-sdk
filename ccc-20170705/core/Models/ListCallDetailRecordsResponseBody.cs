// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListCallDetailRecordsResponseBody : TeaModel {
        [NameInMap("CallDetailRecords")]
        [Validation(Required=false)]
        public ListCallDetailRecordsResponseBodyCallDetailRecords CallDetailRecords { get; set; }
        public class ListCallDetailRecordsResponseBodyCallDetailRecords : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListCallDetailRecordsResponseBodyCallDetailRecordsList List { get; set; }
            public class ListCallDetailRecordsResponseBodyCallDetailRecordsList : TeaModel {
                [NameInMap("CallDetailRecord")]
                [Validation(Required=false)]
                public List<ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecord> CallDetailRecord { get; set; }
                public class ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecord : TeaModel {
                    [NameInMap("AgentNames")]
                    [Validation(Required=false)]
                    public string AgentNames { get; set; }

                    [NameInMap("Agents")]
                    [Validation(Required=false)]
                    public ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecordAgents Agents { get; set; }
                    public class ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecordAgents : TeaModel {
                        [NameInMap("CallDetailAgent")]
                        [Validation(Required=false)]
                        public List<ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecordAgentsCallDetailAgent> CallDetailAgent { get; set; }
                        public class ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecordAgentsCallDetailAgent : TeaModel {
                            public string AgentId { get; set; }
                            public string Feedback { get; set; }
                            public string Satisfaction { get; set; }
                        }
                    };

                    [NameInMap("CalledNumber")]
                    [Validation(Required=false)]
                    public string CalledNumber { get; set; }

                    [NameInMap("CallingNumber")]
                    [Validation(Required=false)]
                    public string CallingNumber { get; set; }

                    [NameInMap("ContactDisposition")]
                    [Validation(Required=false)]
                    public string ContactDisposition { get; set; }

                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    [NameInMap("ContactType")]
                    [Validation(Required=false)]
                    public string ContactType { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("Feedback")]
                    [Validation(Required=false)]
                    public string Feedback { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Recordings")]
                    [Validation(Required=false)]
                    public ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecordRecordings Recordings { get; set; }
                    public class ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecordRecordings : TeaModel {
                        [NameInMap("Recording")]
                        [Validation(Required=false)]
                        public List<ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecordRecordingsRecording> Recording { get; set; }
                        public class ListCallDetailRecordsResponseBodyCallDetailRecordsListCallDetailRecordRecordingsRecording : TeaModel {
                            public string AgentId { get; set; }
                            public string AgentName { get; set; }
                            public string ContactId { get; set; }
                            public int? Duration { get; set; }
                            public string FileDescription { get; set; }
                            public string FileName { get; set; }
                            public string QualityCheckTaskId { get; set; }
                            public string QualityCheckTid { get; set; }
                            public long? StartTime { get; set; }
                        }
                    };

                    [NameInMap("Satisfaction")]
                    [Validation(Required=false)]
                    public int? Satisfaction { get; set; }

                    [NameInMap("SatisfactionDesc")]
                    [Validation(Required=false)]
                    public string SatisfactionDesc { get; set; }

                    [NameInMap("SkillGroupIdList")]
                    [Validation(Required=false)]
                    public string SkillGroupIdList { get; set; }

                    [NameInMap("SkillGroupNames")]
                    [Validation(Required=false)]
                    public string SkillGroupNames { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
