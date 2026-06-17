// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawCronJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>Application ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>List of scheduled tasks</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<DescribePolarClawCronJobsResponseBodyJobs> Jobs { get; set; }
        public class DescribePolarClawCronJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>Execution Agent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>Creation timestamp (milliseconds)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777370572517</para>
            /// </summary>
            [NameInMap("CreatedAtMs")]
            [Validation(Required=false)]
            public long? CreatedAtMs { get; set; }

            /// <summary>
            /// <para>Delete after first execution</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeleteAfterRun")]
            [Validation(Required=false)]
            public bool? DeleteAfterRun { get; set; }

            /// <summary>
            /// <para>Result delivery configuration</para>
            /// </summary>
            [NameInMap("Delivery")]
            [Validation(Required=false)]
            public DescribePolarClawCronJobsResponseBodyJobsDelivery Delivery { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsDelivery : TeaModel {
                /// <summary>
                /// <para>Channel account ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>Ignore delivery failures</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BestEffort")]
                [Validation(Required=false)]
                public bool? BestEffort { get; set; }

                /// <summary>
                /// <para>Delivery channel</para>
                /// 
                /// <b>Example:</b>
                /// <para>feishu</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Delivery mode: none/announce/webhook</para>
                /// 
                /// <b>Example:</b>
                /// <para>announce</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>Delivery destination</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_***</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            /// <summary>
            /// <para>Task description</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily report generation</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Whether enabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Task ID (UUID)</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ee00f56-f467-4d41-858c-ca4ede2c770e</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Task name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Execution payload</para>
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public DescribePolarClawCronJobsResponseBodyJobsPayload Payload { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsPayload : TeaModel {
                /// <summary>
                /// <para>Ignore delivery failures</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BestEffortDeliver")]
                [Validation(Required=false)]
                public bool? BestEffortDeliver { get; set; }

                /// <summary>
                /// <para>Delivery channel ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>feishu</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Deliver output to channel</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Deliver")]
                [Validation(Required=false)]
                public bool? Deliver { get; set; }

                /// <summary>
                /// <para>Payload type: agentTurn/systemEvent</para>
                /// 
                /// <b>Example:</b>
                /// <para>systemEvent</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>Indicates whether lightweight context is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LightContext")]
                [Validation(Required=false)]
                public bool? LightContext { get; set; }

                /// <summary>
                /// <para>Agent conversation prompt</para>
                /// 
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Model override</para>
                /// 
                /// <b>Example:</b>
                /// <para>bailian/qwen3.5-plus</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>System event text</para>
                /// 
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>Execution timeout in seconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>Delivery destination</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_***</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            /// <summary>
            /// <para>Run history</para>
            /// </summary>
            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<DescribePolarClawCronJobsResponseBodyJobsRuns> Runs { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsRuns : TeaModel {
                /// <summary>
                /// <para>Action: finished/error/skipped</para>
                /// 
                /// <b>Example:</b>
                /// <para>finished</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>Indicates whether the job has been delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Delivered")]
                [Validation(Required=false)]
                public bool? Delivered { get; set; }

                /// <summary>
                /// <para>Delivery status</para>
                /// 
                /// <b>Example:</b>
                /// <para>not-requested</para>
                /// </summary>
                [NameInMap("DeliveryStatus")]
                [Validation(Required=false)]
                public string DeliveryStatus { get; set; }

                /// <summary>
                /// <para>Execution duration (milliseconds)</para>
                /// 
                /// <b>Example:</b>
                /// <para>27586</para>
                /// </summary>
                [NameInMap("DurationMs")]
                [Validation(Required=false)]
                public long? DurationMs { get; set; }

                /// <summary>
                /// <para>Associated task ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>f83f5278-1abe-40a6-b10e-ad3ecdc05de2</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Task name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>Model used</para>
                /// 
                /// <b>Example:</b>
                /// <para>bailian/qwen3.5-plus</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>Next execution timestamp (milliseconds)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777424400000</para>
                /// </summary>
                [NameInMap("NextRunAtMs")]
                [Validation(Required=false)]
                public long? NextRunAtMs { get; set; }

                /// <summary>
                /// <para>Model provider</para>
                /// 
                /// <b>Example:</b>
                /// <para>bailian</para>
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// <para>Actual execution timestamp (milliseconds)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370544931</para>
                /// </summary>
                [NameInMap("RunAtMs")]
                [Validation(Required=false)]
                public long? RunAtMs { get; set; }

                /// <summary>
                /// <para>Associated session ID</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>Status: ok/error/skipped</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Run summary text</para>
                /// 
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>Run timestamp (milliseconds)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370572518</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public long? Ts { get; set; }

                /// <summary>
                /// <para>Token usage details</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public DescribePolarClawCronJobsResponseBodyJobsRunsUsage Usage { get; set; }
                public class DescribePolarClawCronJobsResponseBodyJobsRunsUsage : TeaModel {
                    /// <summary>
                    /// <para>Number of input tokens</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30250</para>
                    /// </summary>
                    [NameInMap("InputTokens")]
                    [Validation(Required=false)]
                    public int? InputTokens { get; set; }

                    /// <summary>
                    /// <para>Number of output tokens</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30250</para>
                    /// </summary>
                    [NameInMap("OutputTokens")]
                    [Validation(Required=false)]
                    public int? OutputTokens { get; set; }

                    /// <summary>
                    /// <para>Total number of tokens</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60500</para>
                    /// </summary>
                    [NameInMap("TotalTokens")]
                    [Validation(Required=false)]
                    public int? TotalTokens { get; set; }

                }

            }

            /// <summary>
            /// <para>Scheduling Configuration</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public DescribePolarClawCronJobsResponseBodyJobsSchedule Schedule { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsSchedule : TeaModel {
                /// <summary>
                /// <para>Alignment anchor timestamp for interval</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370572518</para>
                /// </summary>
                [NameInMap("AnchorMs")]
                [Validation(Required=false)]
                public long? AnchorMs { get; set; }

                /// <summary>
                /// <para>ISO 8601 timestamp</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-10T09:00:00+08:00</para>
                /// </summary>
                [NameInMap("At")]
                [Validation(Required=false)]
                public string At { get; set; }

                /// <summary>
                /// <para>Interval in milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("EveryMs")]
                [Validation(Required=false)]
                public long? EveryMs { get; set; }

                /// <summary>
                /// <para>Cron expression</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 9 * * *</para>
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// <para>Schedule type: cron/every/at</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>IANA time zone</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Tz")]
                [Validation(Required=false)]
                public string Tz { get; set; }

            }

            /// <summary>
            /// <para>Session routing key</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent:main:feishu:direct:***</para>
            /// </summary>
            [NameInMap("SessionKey")]
            [Validation(Required=false)]
            public string SessionKey { get; set; }

            /// <summary>
            /// <para>Session target: main/isolated/current</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("SessionTarget")]
            [Validation(Required=false)]
            public string SessionTarget { get; set; }

            /// <summary>
            /// <para>Run status</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public DescribePolarClawCronJobsResponseBodyJobsState State { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsState : TeaModel {
                /// <summary>
                /// <para>Number of consecutive failures</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ConsecutiveErrors")]
                [Validation(Required=false)]
                public int? ConsecutiveErrors { get; set; }

                /// <summary>
                /// <para>Last execution timestamp (milliseconds)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370544931</para>
                /// </summary>
                [NameInMap("LastRunAtMs")]
                [Validation(Required=false)]
                public long? LastRunAtMs { get; set; }

                /// <summary>
                /// <para>Last execution status</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("LastRunStatus")]
                [Validation(Required=false)]
                public string LastRunStatus { get; set; }

                /// <summary>
                /// <para>Next execution timestamp (milliseconds)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777424400000</para>
                /// </summary>
                [NameInMap("NextRunAtMs")]
                [Validation(Required=false)]
                public long? NextRunAtMs { get; set; }

            }

            /// <summary>
            /// <para>Update timestamp (milliseconds)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777368967284</para>
            /// </summary>
            [NameInMap("UpdatedAtMs")]
            [Validation(Required=false)]
            public long? UpdatedAtMs { get; set; }

            /// <summary>
            /// <para>Wake mode: now/next-heartbeat</para>
            /// 
            /// <b>Example:</b>
            /// <para>now</para>
            /// </summary>
            [NameInMap("WakeMode")]
            [Validation(Required=false)]
            public string WakeMode { get; set; }

        }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2281C6C9-CBAB-1AFD-8400-670750CF6025_2212</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of tasks</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
