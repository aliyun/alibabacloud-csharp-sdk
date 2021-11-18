// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetJobStatusByCallIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetJobStatusByCallIdResponseBodyJob Job { get; set; }
        public class GetJobStatusByCallIdResponseBodyJob : TeaModel {
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<GetJobStatusByCallIdResponseBodyJobContacts> Contacts { get; set; }
            public class GetJobStatusByCallIdResponseBodyJobContacts : TeaModel {
                public string ContactId { get; set; }
                public string ContactName { get; set; }
                public string Honorific { get; set; }
                public string JobId { get; set; }
                public string PhoneNumber { get; set; }
                public string ReferenceId { get; set; }
                public string Role { get; set; }
                public string State { get; set; }
            }
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public List<GetJobStatusByCallIdResponseBodyJobExtras> Extras { get; set; }
            public class GetJobStatusByCallIdResponseBodyJobExtras : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public List<GetJobStatusByCallIdResponseBodyJobSummary> Summary { get; set; }
            public class GetJobStatusByCallIdResponseBodyJobSummary : TeaModel {
                public string Category { get; set; }
                public string Content { get; set; }
                public string SummaryId { get; set; }
                public string SummaryName { get; set; }
            }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetJobStatusByCallIdResponseBodyJobTasks> Tasks { get; set; }
            public class GetJobStatusByCallIdResponseBodyJobTasks : TeaModel {
                public long? ActualTime { get; set; }
                public string Brief { get; set; }
                public string CallId { get; set; }
                public string CalledNumber { get; set; }
                public string CallingNumber { get; set; }
                public string ChatbotId { get; set; }
                public GetJobStatusByCallIdResponseBodyJobTasksContact Contact { get; set; }
                public class GetJobStatusByCallIdResponseBodyJobTasksContact : TeaModel {
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    [NameInMap("Honorific")]
                    [Validation(Required=false)]
                    public string Honorific { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    [NameInMap("ReferenceId")]
                    [Validation(Required=false)]
                    public string ReferenceId { get; set; }

                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }
                public List<GetJobStatusByCallIdResponseBodyJobTasksConversation> Conversation { get; set; }
                public class GetJobStatusByCallIdResponseBodyJobTasksConversation : TeaModel {
                    public string ConversationDetailId { get; set; }
                    public string Script { get; set; }
                    public string Speaker { get; set; }
                    public List<GetJobStatusByCallIdResponseBodyJobTasksConversationSummary> Summary { get; set; }
                    public class GetJobStatusByCallIdResponseBodyJobTasksConversationSummary : TeaModel {
                        public string Category { get; set; }
                        public string Content { get; set; }
                        public string SummaryId { get; set; }
                        public string SummaryName { get; set; }
                    }
                    public string TaskId { get; set; }
                    public long? Timestamp { get; set; }
                }
                public int? Duration { get; set; }
                public long? EndTime { get; set; }
                public string JobId { get; set; }
                public long? PlanedTime { get; set; }
                public string ScenarioId { get; set; }
                public string Status { get; set; }
                public string TaskId { get; set; }
            }
        };

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
