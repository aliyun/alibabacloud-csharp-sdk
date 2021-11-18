// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetTaskListResponseBody : TeaModel {
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

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<GetTaskListResponseBodyTasks> Tasks { get; set; }
        public class GetTaskListResponseBodyTasks : TeaModel {
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
            public GetTaskListResponseBodyTasksContact Contact { get; set; }
            public class GetTaskListResponseBodyTasksContact : TeaModel {
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
            };

            [NameInMap("Conversation")]
            [Validation(Required=false)]
            public List<GetTaskListResponseBodyTasksConversation> Conversation { get; set; }
            public class GetTaskListResponseBodyTasksConversation : TeaModel {
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

                [NameInMap("Speaker")]
                [Validation(Required=false)]
                public string Speaker { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public List<GetTaskListResponseBodyTasksConversationSummary> Summary { get; set; }
                public class GetTaskListResponseBodyTasksConversationSummary : TeaModel {
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

}
