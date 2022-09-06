// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListJobsResponseBodyJobs> Jobs { get; set; }
        public class ListJobsResponseBodyJobs : TeaModel {
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyJobsContacts> Contacts { get; set; }
            public class ListJobsResponseBodyJobsContacts : TeaModel {
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

            [NameInMap("Extras")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyJobsExtras> Extras { get; set; }
            public class ListJobsResponseBodyJobsExtras : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }

            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

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
            public List<ListJobsResponseBodyJobsSummary> Summary { get; set; }
            public class ListJobsResponseBodyJobsSummary : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("SummaryName")]
                [Validation(Required=false)]
                public string SummaryName { get; set; }

            }

            [NameInMap("SystemPriority")]
            [Validation(Required=false)]
            public int? SystemPriority { get; set; }

            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyJobsTasks> Tasks { get; set; }
            public class ListJobsResponseBodyJobsTasks : TeaModel {
                [NameInMap("ActualTime")]
                [Validation(Required=false)]
                public long? ActualTime { get; set; }

                [NameInMap("Brief")]
                [Validation(Required=false)]
                public string Brief { get; set; }

                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                [NameInMap("ChatbotId")]
                [Validation(Required=false)]
                public string ChatbotId { get; set; }

                [NameInMap("Contact")]
                [Validation(Required=false)]
                public ListJobsResponseBodyJobsTasksContact Contact { get; set; }
                public class ListJobsResponseBodyJobsTasksContact : TeaModel {
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

                [NameInMap("Conversation")]
                [Validation(Required=false)]
                public List<ListJobsResponseBodyJobsTasksConversation> Conversation { get; set; }
                public class ListJobsResponseBodyJobsTasksConversation : TeaModel {
                    [NameInMap("Script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                    [NameInMap("Speaker")]
                    [Validation(Required=false)]
                    public string Speaker { get; set; }

                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public List<ListJobsResponseBodyJobsTasksConversationSummary> Summary { get; set; }
                    public class ListJobsResponseBodyJobsTasksConversationSummary : TeaModel {
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("SummaryName")]
                        [Validation(Required=false)]
                        public string SummaryName { get; set; }

                    }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("PlanedTime")]
                [Validation(Required=false)]
                public long? PlanedTime { get; set; }

                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

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
