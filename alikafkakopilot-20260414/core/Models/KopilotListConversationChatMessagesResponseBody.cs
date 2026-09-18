// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class KopilotListConversationChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The data returned when the call is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public KopilotListConversationChatMessagesResponseBodyData Data { get; set; }
        public class KopilotListConversationChatMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The list of messages.</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<KopilotListConversationChatMessagesResponseBodyDataMessages> Messages { get; set; }
            public class KopilotListConversationChatMessagesResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>The actual content of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp when the message was created, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17575885545677</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The user satisfaction level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public string Feedback { get; set; }

                /// <summary>
                /// <para>The role identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>assistant</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2345</para>
                /// </summary>
                [NameInMap("TurnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

            }

            /// <summary>
            /// <para>The cursor for the next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NextBeforeTurnId")]
            [Validation(Required=false)]
            public long? NextBeforeTurnId { get; set; }

            /// <summary>
            /// <para>The details of scheduled tasks associated with the current session. Only tasks in the enabled, paused, or pending authorization state are counted.</para>
            /// </summary>
            [NameInMap("ScheduledTaskInfo")]
            [Validation(Required=false)]
            public KopilotListConversationChatMessagesResponseBodyDataScheduledTaskInfo ScheduledTaskInfo { get; set; }
            public class KopilotListConversationChatMessagesResponseBodyDataScheduledTaskInfo : TeaModel {
                /// <summary>
                /// <para>The time when the overview was generated, in UTC ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-17T12:00:00Z</para>
                /// </summary>
                [NameInMap("AsOf")]
                [Validation(Required=false)]
                public string AsOf { get; set; }

                /// <summary>
                /// <para>The number of associated tasks in the ENABLED state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EnabledCount")]
                [Validation(Required=false)]
                public long? EnabledCount { get; set; }

                /// <summary>
                /// <para>Indicates whether there is a next page of associated tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasMoreTasks")]
                [Validation(Required=false)]
                public bool? HasMoreTasks { get; set; }

                /// <summary>
                /// <para>Indicates whether the current session has associated scheduled tasks in the enabled, paused, or pending authorization state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasScheduledTask")]
                [Validation(Required=false)]
                public bool? HasScheduledTask { get; set; }

                /// <summary>
                /// <para>The cursor for the next page. This value is empty if there is no next page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("NextTaskCursor")]
                [Validation(Required=false)]
                public string NextTaskCursor { get; set; }

                /// <summary>
                /// <para>The total number of associated tasks. Only tasks in the ENABLED, PAUSED, or NEEDS_AUTH state are counted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskCount")]
                [Validation(Required=false)]
                public long? TaskCount { get; set; }

                /// <summary>
                /// <para>The list of associated tasks on the current page.</para>
                /// </summary>
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<KopilotListConversationChatMessagesResponseBodyDataScheduledTaskInfoTasks> Tasks { get; set; }
                public class KopilotListConversationChatMessagesResponseBodyDataScheduledTaskInfoTasks : TeaModel {
                    /// <summary>
                    /// <para>The run record that is currently queued or running. This value is empty if there is no active run.</para>
                    /// </summary>
                    [NameInMap("ActiveRun")]
                    [Validation(Required=false)]
                    public KopilotListConversationChatMessagesResponseBodyDataScheduledTaskInfoTasksActiveRun ActiveRun { get; set; }
                    public class KopilotListConversationChatMessagesResponseBodyDataScheduledTaskInfoTasksActiveRun : TeaModel {
                        /// <summary>
                        /// <para>The time when the run ended, in UTC ISO 8601 format. This value is typically empty for queued or running tasks.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-09-17T12:01:00Z</para>
                        /// </summary>
                        [NameInMap("FinishedAt")]
                        [Validation(Required=false)]
                        public string FinishedAt { get; set; }

                        /// <summary>
                        /// <para>The unique identifier of a single run.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>run_0123456789abcdef0123456789abcdef</para>
                        /// </summary>
                        [NameInMap("RunId")]
                        [Validation(Required=false)]
                        public string RunId { get; set; }

                        /// <summary>
                        /// <para>The status of a single run. A value of QUEUED indicates that the run is queued. A value of RUNNING indicates that the run is in progress.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RUNNING</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                    /// <summary>
                    /// <para>The most recent completed run record, including failed runs. This value is empty if no record exists.</para>
                    /// </summary>
                    [NameInMap("LastCompletedRun")]
                    [Validation(Required=false)]
                    public KopilotListConversationChatMessagesResponseBodyDataScheduledTaskInfoTasksLastCompletedRun LastCompletedRun { get; set; }
                    public class KopilotListConversationChatMessagesResponseBodyDataScheduledTaskInfoTasksLastCompletedRun : TeaModel {
                        /// <summary>
                        /// <para>The time when the run ended, in UTC ISO 8601 format. This value is empty if the run has not ended.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-09-17T12:01:00Z</para>
                        /// </summary>
                        [NameInMap("FinishedAt")]
                        [Validation(Required=false)]
                        public string FinishedAt { get; set; }

                        /// <summary>
                        /// <para>The unique identifier of a single run.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>run_0123456789abcdef0123456789abcdef</para>
                        /// </summary>
                        [NameInMap("RunId")]
                        [Validation(Required=false)]
                        public string RunId { get; set; }

                        /// <summary>
                        /// <para>The status of the most recent completed run. For example, SUCCEEDED indicates success and FAILED indicates failure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SUCCEEDED</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Kafka Resource Inspection</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The next scheduled execution time, in UTC ISO 8601 format. This value is empty if no next execution is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-17T12:15:00Z</para>
                    /// </summary>
                    [NameInMap("NextRunAt")]
                    [Validation(Required=false)]
                    public string NextRunAt { get; set; }

                    /// <summary>
                    /// <para>The human-readable description of the execution schedule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Every 900 seconds</para>
                    /// </summary>
                    [NameInMap("ScheduleDescription")]
                    [Validation(Required=false)]
                    public string ScheduleDescription { get; set; }

                    /// <summary>
                    /// <para>The status of the scheduled task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>DRAFT: The task is a draft.</description></item>
                    /// <item><description>ENABLED: The task is enabled.</description></item>
                    /// <item><description>PAUSED: The task is paused.</description></item>
                    /// <item><description>NEEDS_AUTH: The task is pending authorization.</description></item>
                    /// <item><description>COMPLETED: The task is completed.</description></item>
                    /// </list>
                    /// <para>This status is independent of the run status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ENABLED</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>task_0123456789abcdef0123456789abcdef</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

            }

            /// <summary>
            /// <para>The scheduled task quota for the current Alibaba Cloud account in this environment, counted across regions.</para>
            /// </summary>
            [NameInMap("ScheduledTaskQuota")]
            [Validation(Required=false)]
            public KopilotListConversationChatMessagesResponseBodyDataScheduledTaskQuota ScheduledTaskQuota { get; set; }
            public class KopilotListConversationChatMessagesResponseBodyDataScheduledTaskQuota : TeaModel {
                /// <summary>
                /// <para>The maximum number of tasks or channels allowed, subject to the actual configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                /// <summary>
                /// <para>The remaining quota, calculated as the limit minus the used quota. The minimum value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Remaining")]
                [Validation(Required=false)]
                public long? Remaining { get; set; }

                /// <summary>
                /// <para>The used task quota. Tasks in the DRAFT, ENABLED, PAUSED, or NEEDS_AUTH state are counted. Completed or deleted tasks do not consume the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87ce9505-7dec-4fd7-bc7c-e66d949bfdc9</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The total number of turn IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalTurns")]
            [Validation(Required=false)]
            public long? TotalTurns { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F69385B9-2139-5A07-AE64-37C4B6ED308E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
