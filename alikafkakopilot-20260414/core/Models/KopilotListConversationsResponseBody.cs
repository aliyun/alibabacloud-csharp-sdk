// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class KopilotListConversationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
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
        public KopilotListConversationsResponseBodyData Data { get; set; }
        public class KopilotListConversationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The overview of tasks, notification channels, and quotas for the current account. Returned only when the request includes the overview and the feature is available.</para>
            /// </summary>
            [NameInMap("AutomationOverview")]
            [Validation(Required=false)]
            public KopilotListConversationsResponseBodyDataAutomationOverview AutomationOverview { get; set; }
            public class KopilotListConversationsResponseBodyDataAutomationOverview : TeaModel {
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
                /// <para>The quota for the number of notification channels of the current primary account in this environment, counted across regions.</para>
                /// </summary>
                [NameInMap("DestinationQuota")]
                [Validation(Required=false)]
                public KopilotListConversationsResponseBodyDataAutomationOverviewDestinationQuota DestinationQuota { get; set; }
                public class KopilotListConversationsResponseBodyDataAutomationOverviewDestinationQuota : TeaModel {
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
                    /// <para>The remaining quota, calculated as the limit minus the used quantity. The minimum value is 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Remaining")]
                    [Validation(Required=false)]
                    public long? Remaining { get; set; }

                    /// <summary>
                    /// <para>The number of non-deleted notification channels. Disabled channels still consume quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The paginated results of notification channels. Webhook URLs and signing keys are not returned.</para>
                /// </summary>
                [NameInMap("Destinations")]
                [Validation(Required=false)]
                public KopilotListConversationsResponseBodyDataAutomationOverviewDestinations Destinations { get; set; }
                public class KopilotListConversationsResponseBodyDataAutomationOverviewDestinations : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether more pages are available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// <para>The list of tasks or notification channels on the current page.</para>
                    /// </summary>
                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public List<KopilotListConversationsResponseBodyDataAutomationOverviewDestinationsItems> Items { get; set; }
                    public class KopilotListConversationsResponseBodyDataAutomationOverviewDestinationsItems : TeaModel {
                        /// <summary>
                        /// <para>The time when the record was created, in UTC ISO 8601 format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-09-17T12:00:00Z</para>
                        /// </summary>
                        [NameInMap("CreatedAt")]
                        [Validation(Required=false)]
                        public string CreatedAt { get; set; }

                        /// <summary>
                        /// <para>The unique identifier of the notification channel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dst_0123456789abcdef0123456789abcdef</para>
                        /// </summary>
                        [NameInMap("DestinationId")]
                        [Validation(Required=false)]
                        public string DestinationId { get; set; }

                        /// <summary>
                        /// <para>The most recent delivery record. This field is empty if no delivery has been made.</para>
                        /// </summary>
                        [NameInMap("LastDelivery")]
                        [Validation(Required=false)]
                        public KopilotListConversationsResponseBodyDataAutomationOverviewDestinationsItemsLastDelivery LastDelivery { get; set; }
                        public class KopilotListConversationsResponseBodyDataAutomationOverviewDestinationsItemsLastDelivery : TeaModel {
                            /// <summary>
                            /// <para>The time when the notification service accepted the delivery, in UTC ISO 8601 format. This field is empty if the delivery has not been accepted.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2026-09-17T12:01:00Z</para>
                            /// </summary>
                            [NameInMap("AcceptedAt")]
                            [Validation(Required=false)]
                            public string AcceptedAt { get; set; }

                            /// <summary>
                            /// <para>The time when the record was created, in UTC ISO 8601 format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2026-09-17T12:00:00Z</para>
                            /// </summary>
                            [NameInMap("CreatedAt")]
                            [Validation(Required=false)]
                            public string CreatedAt { get; set; }

                            /// <summary>
                            /// <para>The unique identifier of the delivery record.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>dlv_0123456789abcdef0123456789abcdef</para>
                            /// </summary>
                            [NameInMap("DeliveryId")]
                            [Validation(Required=false)]
                            public string DeliveryId { get; set; }

                            /// <summary>
                            /// <para>The time of the most recent delivery attempt, in UTC ISO 8601 format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2026-09-17T12:01:00Z</para>
                            /// </summary>
                            [NameInMap("LastAttemptAt")]
                            [Validation(Required=false)]
                            public string LastAttemptAt { get; set; }

                            /// <summary>
                            /// <para>The delivery type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>AUTO: automatic delivery.</description></item>
                            /// <item><description>MANUAL: manual delivery.</description></item>
                            /// <item><description>TEST: connectivity test.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AUTO</para>
                            /// </summary>
                            [NameInMap("SendKind")]
                            [Validation(Required=false)]
                            public string SendKind { get; set; }

                            /// <summary>
                            /// <para>The most recent delivery status. ACCEPTED indicates that the notification service has accepted the delivery, but does not mean the recipient has read it.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ACCEPTED</para>
                            /// </summary>
                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the notification channel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Inspection Notification Group</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The configuration status of the channel. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>ACTIVE: enabled.</description></item>
                        /// <item><description>DISABLED: disabled.
                        /// Being enabled does not indicate that a delivery has been successfully sent.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACTIVE</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The type of the notification channel. DINGTALK_WEBHOOK indicates a DingTalk custom chatbot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DINGTALK_WEBHOOK</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The time when the record was last updated, in UTC ISO 8601 format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-09-17T12:00:00Z</para>
                        /// </summary>
                        [NameInMap("UpdatedAt")]
                        [Validation(Required=false)]
                        public string UpdatedAt { get; set; }

                        /// <summary>
                        /// <para>The version number used for concurrent update verification of the record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public long? Version { get; set; }

                    }

                    /// <summary>
                    /// <para>The cursor for the next page. This field is empty if no more pages are available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("NextCursor")]
                    [Validation(Required=false)]
                    public string NextCursor { get; set; }

                    /// <summary>
                    /// <para>The total number of non-deleted records in the list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }

                }

                /// <summary>
                /// <para>The home region for tasks and notification channels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("HomeRegion")]
                [Validation(Required=false)]
                public string HomeRegion { get; set; }

                /// <summary>
                /// <para>The quota for the number of scheduled tasks of the current primary account in this environment, counted across regions.</para>
                /// </summary>
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public KopilotListConversationsResponseBodyDataAutomationOverviewQuota Quota { get; set; }
                public class KopilotListConversationsResponseBodyDataAutomationOverviewQuota : TeaModel {
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
                    /// <para>The remaining quota, calculated as the limit minus the used quantity. The minimum value is 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Remaining")]
                    [Validation(Required=false)]
                    public long? Remaining { get; set; }

                    /// <summary>
                    /// <para>The number of task quota slots consumed. Tasks in DRAFT, ENABLED, PAUSED, or NEEDS_AUTH status are counted. Completed and deleted tasks do not consume quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The paginated results of scheduled tasks for the account.</para>
                /// </summary>
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public KopilotListConversationsResponseBodyDataAutomationOverviewTasks Tasks { get; set; }
                public class KopilotListConversationsResponseBodyDataAutomationOverviewTasks : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether more pages are available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// <para>The list of tasks or notification channels on the current page.</para>
                    /// </summary>
                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public List<KopilotListConversationsResponseBodyDataAutomationOverviewTasksItems> Items { get; set; }
                    public class KopilotListConversationsResponseBodyDataAutomationOverviewTasksItems : TeaModel {
                        /// <summary>
                        /// <para>The currently queued or running execution record. This field is empty if no active run exists.</para>
                        /// </summary>
                        [NameInMap("ActiveRun")]
                        [Validation(Required=false)]
                        public KopilotListConversationsResponseBodyDataAutomationOverviewTasksItemsActiveRun ActiveRun { get; set; }
                        public class KopilotListConversationsResponseBodyDataAutomationOverviewTasksItemsActiveRun : TeaModel {
                            /// <summary>
                            /// <para>The error code of a failed run. This field is empty if no error occurred.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>UPSTREAM_TIMEOUT</para>
                            /// </summary>
                            [NameInMap("ErrorCode")]
                            [Validation(Required=false)]
                            public string ErrorCode { get; set; }

                            /// <summary>
                            /// <para>The user-facing failure reason. This field is empty if no error occurred.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Model or tool calling invoke timed out. Try again later</para>
                            /// </summary>
                            [NameInMap("ErrorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <para>The time when the run finished, in UTC ISO 8601 format. This field is typically empty for queued or running executions.</para>
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
                            /// <para>The status of a single run. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>QUEUED: queued.</description></item>
                            /// <item><description>RUNNING: running.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>RUNNING</para>
                            /// </summary>
                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                        }

                        /// <summary>
                        /// <para>The task execution configuration.</para>
                        /// </summary>
                        [NameInMap("Configuration")]
                        [Validation(Required=false)]
                        public KopilotListConversationsResponseBodyDataAutomationOverviewTasksItemsConfiguration Configuration { get; set; }
                        public class KopilotListConversationsResponseBodyDataAutomationOverviewTasksItemsConfiguration : TeaModel {
                            /// <summary>
                            /// <para>The six-field cron expression with the seconds field fixed to 0. This field is used only for the CRON schedule type.</para>
                            /// </summary>
                            [NameInMap("CronExpression")]
                            [Validation(Required=false)]
                            public string CronExpression { get; set; }

                            /// <summary>
                            /// <para>The list of notification channel IDs that receive task results. A maximum of 3 IDs are supported.</para>
                            /// </summary>
                            [NameInMap("DestinationIds")]
                            [Validation(Required=false)]
                            public List<string> DestinationIds { get; set; }

                            /// <summary>
                            /// <para>The list of instance IDs within the query scope.</para>
                            /// </summary>
                            [NameInMap("InstanceIds")]
                            [Validation(Required=false)]
                            public List<string> InstanceIds { get; set; }

                            /// <summary>
                            /// <para>The instruction for the scheduled task execution.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Query the current risks of the specified instances and summarize the results</para>
                            /// </summary>
                            [NameInMap("Instruction")]
                            [Validation(Required=false)]
                            public string Instruction { get; set; }

                            /// <summary>
                            /// <para>The fixed interval in seconds. Valid values: 900 to 31536000. This field is used only for the FIXED_INTERVAL schedule type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>900</para>
                            /// </summary>
                            [NameInMap("IntervalSeconds")]
                            [Validation(Required=false)]
                            public int? IntervalSeconds { get; set; }

                            /// <summary>
                            /// <para>The time budget for a single task run, in seconds. Default value: 600. Valid values: 30 to 1800.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>600</para>
                            /// </summary>
                            [NameInMap("MaxRunSeconds")]
                            [Validation(Required=false)]
                            public int? MaxRunSeconds { get; set; }

                            /// <summary>
                            /// <para>The token budget for a single task run. Default value: 3000000. Valid values: 1000 to 10000000.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3000000</para>
                            /// </summary>
                            [NameInMap("MaxTokens")]
                            [Validation(Required=false)]
                            public long? MaxTokens { get; set; }

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
                            /// <para>The region where the queried resources reside.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cn-beijing</para>
                            /// </summary>
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                            /// <summary>
                            /// <para>The resource scope mode. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>ACCOUNT: account-level query.</description></item>
                            /// <item><description>NONE: no resource task.</description></item>
                            /// <item><description>EXPLICIT: specified instances.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ACCOUNT</para>
                            /// </summary>
                            [NameInMap("ResourceMode")]
                            [Validation(Required=false)]
                            public string ResourceMode { get; set; }

                            /// <summary>
                            /// <para>The one-time execution time in ISO 8601 format with time zone. This field is used only for the ONCE schedule type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2026-09-18T12:00:00Z</para>
                            /// </summary>
                            [NameInMap("RunAt")]
                            [Validation(Required=false)]
                            public string RunAt { get; set; }

                            /// <summary>
                            /// <para>The schedule type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>ONCE: one-time execution.</description></item>
                            /// <item><description>CRON: cron expression.</description></item>
                            /// <item><description>FIXED_INTERVAL: fixed interval.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>FIXED_INTERVAL</para>
                            /// </summary>
                            [NameInMap("ScheduleType")]
                            [Validation(Required=false)]
                            public string ScheduleType { get; set; }

                            /// <summary>
                            /// <para>The session mode for displaying results. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>SHARED: shared session.</description></item>
                            /// <item><description>PER_RUN: independent session for each run.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SHARED</para>
                            /// </summary>
                            [NameInMap("SessionMode")]
                            [Validation(Required=false)]
                            public string SessionMode { get; set; }

                            /// <summary>
                            /// <para>The ID of the target session that stores run results in shared mode.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>00000000-0000-4000-8000-000000000001</para>
                            /// </summary>
                            [NameInMap("TargetSessionId")]
                            [Validation(Required=false)]
                            public string TargetSessionId { get; set; }

                            /// <summary>
                            /// <para>The scheduling time zone. Default value: Asia/Shanghai.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Asia/Shanghai</para>
                            /// </summary>
                            [NameInMap("Timezone")]
                            [Validation(Required=false)]
                            public string Timezone { get; set; }

                        }

                        /// <summary>
                        /// <para>The time when the record was created, in UTC ISO 8601 format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-09-17T12:00:00Z</para>
                        /// </summary>
                        [NameInMap("CreatedAt")]
                        [Validation(Required=false)]
                        public string CreatedAt { get; set; }

                        /// <summary>
                        /// <para>The most recent completed run record, including failed runs. This field is empty if no record exists.</para>
                        /// </summary>
                        [NameInMap("LastCompletedRun")]
                        [Validation(Required=false)]
                        public KopilotListConversationsResponseBodyDataAutomationOverviewTasksItemsLastCompletedRun LastCompletedRun { get; set; }
                        public class KopilotListConversationsResponseBodyDataAutomationOverviewTasksItemsLastCompletedRun : TeaModel {
                            /// <summary>
                            /// <para>The error code of a failed run. This field is empty if no error occurred.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>UPSTREAM_TIMEOUT</para>
                            /// </summary>
                            [NameInMap("ErrorCode")]
                            [Validation(Required=false)]
                            public string ErrorCode { get; set; }

                            /// <summary>
                            /// <para>The user-facing failure reason. This field is empty if no error occurred.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Model or tool calling invoke timed out. Try again later</para>
                            /// </summary>
                            [NameInMap("ErrorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <para>The time when the run finished, in UTC ISO 8601 format. This field is empty if the run has not finished.</para>
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
                        /// <para>The next scheduled execution time, in UTC ISO 8601 format. This field is empty if no next run is scheduled.</para>
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
                        /// <para>The session mode for displaying results. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>SHARED: shared session.</description></item>
                        /// <item><description>PER_RUN: independent session for each run.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SHARED</para>
                        /// </summary>
                        [NameInMap("SessionMode")]
                        [Validation(Required=false)]
                        public string SessionMode { get; set; }

                        /// <summary>
                        /// <para>The ID of the source session from which the task was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>00000000-0000-4000-8000-000000000001</para>
                        /// </summary>
                        [NameInMap("SourceSessionId")]
                        [Validation(Required=false)]
                        public string SourceSessionId { get; set; }

                        /// <summary>
                        /// <para>The status of the scheduled task. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>DRAFT: Draft.</description></item>
                        /// <item><description>ENABLED: Enabled.</description></item>
                        /// <item><description>PAUSED: Paused.</description></item>
                        /// <item><description>NEEDS_AUTH: Pending authorization.</description></item>
                        /// <item><description>COMPLETED: Completed.</description></item>
                        /// </list>
                        /// <para>This status is independent of the running status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ENABLED</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The ID of the target session that stores run results in shared mode.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>00000000-0000-4000-8000-000000000001</para>
                        /// </summary>
                        [NameInMap("TargetSessionId")]
                        [Validation(Required=false)]
                        public string TargetSessionId { get; set; }

                        /// <summary>
                        /// <para>The unique identifier of the scheduled task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>task_0123456789abcdef0123456789abcdef</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                        /// <summary>
                        /// <para>The time when the record was last updated, in UTC ISO 8601 format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-09-17T12:00:00Z</para>
                        /// </summary>
                        [NameInMap("UpdatedAt")]
                        [Validation(Required=false)]
                        public string UpdatedAt { get; set; }

                        /// <summary>
                        /// <para>The version number used for concurrent update verification of the current record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public long? Version { get; set; }

                    }

                    /// <summary>
                    /// <para>The cursor for the next page. This field is empty if no more pages are available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("NextCursor")]
                    [Validation(Required=false)]
                    public string NextCursor { get; set; }

                    /// <summary>
                    /// <para>The total number of non-deleted records in the list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public long? Total { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of session IDs.</para>
            /// </summary>
            [NameInMap("ConversationIds")]
            [Validation(Required=false)]
            public List<string> ConversationIds { get; set; }

            /// <summary>
            /// <para>The number of entries returned on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>A mapping that uses session IDs as keys and associated task summaries as values.</para>
            /// </summary>
            [NameInMap("ScheduledTaskInfoBySessionId")]
            [Validation(Required=false)]
            public Dictionary<string, DataScheduledTaskInfoBySessionIdValue> ScheduledTaskInfoBySessionId { get; set; }

            /// <summary>
            /// <para>The quota for the number of scheduled tasks of the current primary account in this environment, counted across regions.</para>
            /// </summary>
            [NameInMap("ScheduledTaskQuota")]
            [Validation(Required=false)]
            public KopilotListConversationsResponseBodyDataScheduledTaskQuota ScheduledTaskQuota { get; set; }
            public class KopilotListConversationsResponseBodyDataScheduledTaskQuota : TeaModel {
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
                /// <para>The remaining quota, calculated as the limit minus the used quantity. The minimum value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Remaining")]
                [Validation(Required=false)]
                public long? Remaining { get; set; }

                /// <summary>
                /// <para>The number of task quota slots consumed. Tasks in DRAFT, ENABLED, PAUSED, or NEEDS_AUTH status are counted. Completed and deleted tasks do not consume quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

            /// <summary>
            /// <para>The user UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1734455674565</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DF166F2-F581-5254-AAB6-B482083FA7B4</para>
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
