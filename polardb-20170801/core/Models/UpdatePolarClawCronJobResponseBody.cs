// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdatePolarClawCronJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Details of the updated job.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public UpdatePolarClawCronJobResponseBodyJob Job { get; set; }
        public class UpdatePolarClawCronJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The optional ID of the Agent that runs the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>work</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The creation timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777368967284</para>
            /// </summary>
            [NameInMap("CreatedAtMs")]
            [Validation(Required=false)]
            public long? CreatedAtMs { get; set; }

            /// <summary>
            /// <para>Indicates whether the job is deleted after its first run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeleteAfterRun")]
            [Validation(Required=false)]
            public bool? DeleteAfterRun { get; set; }

            /// <summary>
            /// <para>The optional result delivery configuration.</para>
            /// </summary>
            [NameInMap("Delivery")]
            [Validation(Required=false)]
            public UpdatePolarClawCronJobResponseBodyJobDelivery Delivery { get; set; }
            public class UpdatePolarClawCronJobResponseBodyJobDelivery : TeaModel {
                /// <summary>
                /// <para>The optional channel account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>Indicates whether to ignore delivery failures.</para>
                /// </summary>
                [NameInMap("BestEffort")]
                [Validation(Required=false)]
                public bool? BestEffort { get; set; }

                /// <summary>
                /// <para>The delivery channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>telegram</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>The delivery mode. Valid values: <c>none</c>, <c>announce</c>, or <c>webhook</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>announce</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The delivery target. Required and must be a URL if <c>Mode</c> is <c>webhook</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/webhook">https://example.com/webhook</a></para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            /// <summary>
            /// <para>The optional job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily report generation</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the job is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The job ID (UUID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ee00f56-f467-4d41-858c-ca4ede2c770e</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>daily-report</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The execution payload configuration.</para>
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public UpdatePolarClawCronJobResponseBodyJobPayload Payload { get; set; }
            public class UpdatePolarClawCronJobResponseBodyJobPayload : TeaModel {
                /// <summary>
                /// <para>Indicates whether to ignore delivery failures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BestEffortDeliver")]
                [Validation(Required=false)]
                public bool? BestEffortDeliver { get; set; }

                /// <summary>
                /// <para>The optional delivery channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>telegram</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Indicates whether to deliver the output to a channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Deliver")]
                [Validation(Required=false)]
                public bool? Deliver { get; set; }

                /// <summary>
                /// <para>The payload type. Valid values: <c>agentTurn</c> (Agent conversation) or <c>systemEvent</c> (system event).</para>
                /// 
                /// <b>Example:</b>
                /// <para>agentTurn</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>Indicates whether to use a lightweight context.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LightContext")]
                [Validation(Required=false)]
                public bool? LightContext { get; set; }

                /// <summary>
                /// <para>The Agent conversation prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The model override.</para>
                /// 
                /// <b>Example:</b>
                /// <para>anthropic/sonnet-4.6</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The system event text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The optional execution timeout in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The optional delivery target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>team</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            /// <summary>
            /// <para><b>The run history. Returned only if <c>IncludeRuns</c> is <c>true</c>.</b></para>
            /// </summary>
            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<UpdatePolarClawCronJobResponseBodyJobRuns> Runs { get; set; }
            public class UpdatePolarClawCronJobResponseBodyJobRuns : TeaModel {
                /// <summary>
                /// <para>The action performed. Valid values: <c>finished</c>, <c>error</c>, or <c>skipped</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>finished</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>Indicates whether the result was delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Delivered")]
                [Validation(Required=false)]
                public bool? Delivered { get; set; }

                /// <summary>
                /// <para>The delivery status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>delivered</para>
                /// </summary>
                [NameInMap("DeliveryStatus")]
                [Validation(Required=false)]
                public string DeliveryStatus { get; set; }

                /// <summary>
                /// <para>The execution duration, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>27586</para>
                /// </summary>
                [NameInMap("DurationMs")]
                [Validation(Required=false)]
                public long? DurationMs { get; set; }

                /// <summary>
                /// <para>The associated job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0ee00f56-f467-4d41-858c-ca4ede2c770e</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>daily-report</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The model used for the run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>anthropic/sonnet-4.6</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The timestamp of the next scheduled run, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777424400000</para>
                /// </summary>
                [NameInMap("NextRunAtMs")]
                [Validation(Required=false)]
                public long? NextRunAtMs { get; set; }

                /// <summary>
                /// <para>The model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>anthropic</para>
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// <para>The actual execution timestamp, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370544931</para>
                /// </summary>
                [NameInMap("RunAtMs")]
                [Validation(Required=false)]
                public long? RunAtMs { get; set; }

                /// <summary>
                /// <para>The associated session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc123</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The status of the run. Valid values: <c>ok</c>, <c>error</c>, or <c>skipped</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The run summary text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Report generated successfully.</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The run timestamp, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370572518</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public long? Ts { get; set; }

                /// <summary>
                /// <para>Optional token usage details.</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public UpdatePolarClawCronJobResponseBodyJobRunsUsage Usage { get; set; }
                public class UpdatePolarClawCronJobResponseBodyJobRunsUsage : TeaModel {
                    /// <summary>
                    /// <para>The number of input tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30250</para>
                    /// </summary>
                    [NameInMap("InputTokens")]
                    [Validation(Required=false)]
                    public int? InputTokens { get; set; }

                    /// <summary>
                    /// <para>The number of output tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30250</para>
                    /// </summary>
                    [NameInMap("OutputTokens")]
                    [Validation(Required=false)]
                    public int? OutputTokens { get; set; }

                    /// <summary>
                    /// <para>The total number of tokens.</para>
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
            /// <para>The schedule configuration.</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public UpdatePolarClawCronJobResponseBodyJobSchedule Schedule { get; set; }
            public class UpdatePolarClawCronJobResponseBodyJobSchedule : TeaModel {
                /// <summary>
                /// <para>The base timestamp for interval alignment, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370572518</para>
                /// </summary>
                [NameInMap("AnchorMs")]
                [Validation(Required=false)]
                public long? AnchorMs { get; set; }

                /// <summary>
                /// <para>The ISO 8601 timestamp. Required if <c>Kind</c> is <c>at</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-10T09:00:00+08:00</para>
                /// </summary>
                [NameInMap("At")]
                [Validation(Required=false)]
                public string At { get; set; }

                /// <summary>
                /// <para>The interval in milliseconds. Required if <c>Kind</c> is <c>every</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("EveryMs")]
                [Validation(Required=false)]
                public long? EveryMs { get; set; }

                /// <summary>
                /// <para>The cron expression. Required if <c>Kind</c> is <c>cron</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 9 * * *</para>
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// <para>The schedule type. Valid values: <c>cron</c> (cron expression), <c>every</c> (fixed interval), or <c>at</c> (one-time).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The IANA time zone, such as <c>Asia/Shanghai</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Tz")]
                [Validation(Required=false)]
                public string Tz { get; set; }

            }

            /// <summary>
            /// <para>The optional session routing key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123</para>
            /// </summary>
            [NameInMap("SessionKey")]
            [Validation(Required=false)]
            public string SessionKey { get; set; }

            /// <summary>
            /// <para>The session target. Valid values: <c>main</c>, <c>isolated</c>, or <c>current</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("SessionTarget")]
            [Validation(Required=false)]
            public string SessionTarget { get; set; }

            /// <summary>
            /// <para><b>The running state of the job.</b></para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public UpdatePolarClawCronJobResponseBodyJobState State { get; set; }
            public class UpdatePolarClawCronJobResponseBodyJobState : TeaModel {
                /// <summary>
                /// <para><b>The number of consecutive failures.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ConsecutiveErrors")]
                [Validation(Required=false)]
                public int? ConsecutiveErrors { get; set; }

                /// <summary>
                /// <para><b>The optional timestamp of the last run, in milliseconds.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370544931</para>
                /// </summary>
                [NameInMap("LastRunAtMs")]
                [Validation(Required=false)]
                public long? LastRunAtMs { get; set; }

                /// <summary>
                /// <para><b>The optional status of the last run.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("LastRunStatus")]
                [Validation(Required=false)]
                public string LastRunStatus { get; set; }

                /// <summary>
                /// <para><b>The timestamp for the next run, in milliseconds.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>1777424400000</para>
                /// </summary>
                [NameInMap("NextRunAtMs")]
                [Validation(Required=false)]
                public long? NextRunAtMs { get; set; }

            }

            /// <summary>
            /// <para>The last update timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777370572517</para>
            /// </summary>
            [NameInMap("UpdatedAtMs")]
            [Validation(Required=false)]
            public long? UpdatedAtMs { get; set; }

            /// <summary>
            /// <para>The wake mode. Valid values: <c>now</c> or <c>next-heartbeat</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>now</para>
            /// </summary>
            [NameInMap("WakeMode")]
            [Validation(Required=false)]
            public string WakeMode { get; set; }

        }

        /// <summary>
        /// <para>The success message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ok")]
        [Validation(Required=false)]
        public bool? Ok { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2281C6C9-CBAB-1AFD-8400-670750CF6025_2212</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
