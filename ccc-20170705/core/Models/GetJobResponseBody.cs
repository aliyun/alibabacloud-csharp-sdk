// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetJobResponseBodyJob Job { get; set; }
        public class GetJobResponseBodyJob : TeaModel {
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobContacts> Contacts { get; set; }
            public class GetJobResponseBodyJobContacts : TeaModel {
                public string ContactId { get; set; }
                public string ContactName { get; set; }
                public string Honorific { get; set; }
                public string PhoneNumber { get; set; }
                public string ReferenceId { get; set; }
                public string Role { get; set; }
                public string State { get; set; }
            }
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobExtras> Extras { get; set; }
            public class GetJobResponseBodyJobExtras : TeaModel {
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
            public List<GetJobResponseBodyJobSummary> Summary { get; set; }
            public class GetJobResponseBodyJobSummary : TeaModel {
                public string Category { get; set; }
                public string Content { get; set; }
                public string SummaryName { get; set; }
            }
            [NameInMap("SystemPriority")]
            [Validation(Required=false)]
            public int? SystemPriority { get; set; }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobTasks> Tasks { get; set; }
            public class GetJobResponseBodyJobTasks : TeaModel {
                public long? ActualTime { get; set; }
                public string Brief { get; set; }
                public string CallId { get; set; }
                public string CalledNumber { get; set; }
                public string CallingNumber { get; set; }
                public string ChatbotId { get; set; }
                public GetJobResponseBodyJobTasksContact Contact { get; set; }
                public class GetJobResponseBodyJobTasksContact : TeaModel {
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    [NameInMap("Honorific")]
                    [Validation(Required=false)]
                    public string Honorific { get; set; }

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
                public List<GetJobResponseBodyJobTasksConversation> Conversation { get; set; }
                public class GetJobResponseBodyJobTasksConversation : TeaModel {
                    public string Script { get; set; }
                    public string Speaker { get; set; }
                    public List<GetJobResponseBodyJobTasksConversationSummary> Summary { get; set; }
                    public class GetJobResponseBodyJobTasksConversationSummary : TeaModel {
                        public string Category { get; set; }
                        public string Content { get; set; }
                        public string SummaryName { get; set; }
                    }
                    public long? Timestamp { get; set; }
                }
                public int? Duration { get; set; }
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
