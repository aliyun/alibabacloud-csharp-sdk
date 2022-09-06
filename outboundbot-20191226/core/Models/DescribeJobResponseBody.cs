// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Job")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyJob Job { get; set; }
        public class DescribeJobResponseBodyJob : TeaModel {
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobContacts> Contacts { get; set; }
            public class DescribeJobResponseBodyJobContacts : TeaModel {
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

            [NameInMap("DsReport")]
            [Validation(Required=false)]
            public string DsReport { get; set; }

            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public int? EndReason { get; set; }

            [NameInMap("Extras")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobExtras> Extras { get; set; }
            public class DescribeJobResponseBodyJobExtras : TeaModel {
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

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("NextExecutionTime")]
            [Validation(Required=false)]
            public long? NextExecutionTime { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            [NameInMap("Script")]
            [Validation(Required=false)]
            public DescribeJobResponseBodyJobScript Script { get; set; }
            public class DescribeJobResponseBodyJobScript : TeaModel {
                [NameInMap("AsrConfig")]
                [Validation(Required=false)]
                public string AsrConfig { get; set; }

                [NameInMap("ChatbotId")]
                [Validation(Required=false)]
                public string ChatbotId { get; set; }

                [NameInMap("DebugStatus")]
                [Validation(Required=false)]
                public string DebugStatus { get; set; }

                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                [NameInMap("IsDebugDrafted")]
                [Validation(Required=false)]
                public bool? IsDebugDrafted { get; set; }

                [NameInMap("IsDrafted")]
                [Validation(Required=false)]
                public bool? IsDrafted { get; set; }

                [NameInMap("MiniPlaybackConfigEnabled")]
                [Validation(Required=false)]
                public bool? MiniPlaybackConfigEnabled { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("ScriptDescription")]
                [Validation(Required=false)]
                public string ScriptDescription { get; set; }

                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TtsConfig")]
                [Validation(Required=false)]
                public string TtsConfig { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobSummary> Summary { get; set; }
            public class DescribeJobResponseBodyJobSummary : TeaModel {
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
            public List<DescribeJobResponseBodyJobTasks> Tasks { get; set; }
            public class DescribeJobResponseBodyJobTasks : TeaModel {
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
                public DescribeJobResponseBodyJobTasksContact Contact { get; set; }
                public class DescribeJobResponseBodyJobTasksContact : TeaModel {
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
                public List<DescribeJobResponseBodyJobTasksConversation> Conversation { get; set; }
                public class DescribeJobResponseBodyJobTasksConversation : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    [NameInMap("ActionParams")]
                    [Validation(Required=false)]
                    public string ActionParams { get; set; }

                    [NameInMap("Script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                    [NameInMap("SequenceId")]
                    [Validation(Required=false)]
                    public string SequenceId { get; set; }

                    [NameInMap("Speaker")]
                    [Validation(Required=false)]
                    public string Speaker { get; set; }

                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public List<DescribeJobResponseBodyJobTasksConversationSummary> Summary { get; set; }
                    public class DescribeJobResponseBodyJobTasksConversationSummary : TeaModel {
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

                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public string EndReason { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("HangUpDirection")]
                [Validation(Required=false)]
                public string HangUpDirection { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("PlanedTime")]
                [Validation(Required=false)]
                public long? PlanedTime { get; set; }

                [NameInMap("RingingDuration")]
                [Validation(Required=false)]
                public long? RingingDuration { get; set; }

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
