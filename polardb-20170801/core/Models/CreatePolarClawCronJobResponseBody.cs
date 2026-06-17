// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarClawCronJobResponseBody : TeaModel {
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
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Details of the created cron job.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public CreatePolarClawCronJobResponseBodyJob Job { get; set; }
        public class CreatePolarClawCronJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The ID of the executing agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The creation timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777368967284</para>
            /// </summary>
            [NameInMap("CreatedAtMs")]
            [Validation(Required=false)]
            public long? CreatedAtMs { get; set; }

            /// <summary>
            /// <para>Indicates whether the cron job is deleted after its first run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeleteAfterRun")]
            [Validation(Required=false)]
            public bool? DeleteAfterRun { get; set; }

            /// <summary>
            /// <para>The delivery configuration.</para>
            /// </summary>
            [NameInMap("Delivery")]
            [Validation(Required=false)]
            public CreatePolarClawCronJobResponseBodyJobDelivery Delivery { get; set; }
            public class CreatePolarClawCronJobResponseBodyJobDelivery : TeaModel {
                /// <summary>
                /// <para>The channel account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore delivery failures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BestEffort")]
                [Validation(Required=false)]
                public bool? BestEffort { get; set; }

                /// <summary>
                /// <para>The delivery channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>feishu</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>The delivery mode. Valid values: <c>none</c>, <c>announce</c>, and <c>webhook</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>announce</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_***</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            /// <summary>
            /// <para>The job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the cron job is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The job ID (UUID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>e2c57423-12f0-45cc-a387-6155168b3201</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The execution payload.</para>
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public CreatePolarClawCronJobResponseBodyJobPayload Payload { get; set; }
            public class CreatePolarClawCronJobResponseBodyJobPayload : TeaModel {
                /// <summary>
                /// <para>Specifies whether to ignore delivery failures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BestEffortDeliver")]
                [Validation(Required=false)]
                public bool? BestEffortDeliver { get; set; }

                /// <summary>
                /// <para>The delivery channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>feishu</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Indicates whether to deliver the output to the delivery channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Deliver")]
                [Validation(Required=false)]
                public bool? Deliver { get; set; }

                /// <summary>
                /// <para>The payload type. Valid values: <c>agentTurn</c> and <c>systemEvent</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agentTurn</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>Indicates whether to use a light context.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LightContext")]
                [Validation(Required=false)]
                public bool? LightContext { get; set; }

                /// <summary>
                /// <para>The agent prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The overriding model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bailian/qwen3.5-plus</para>
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
                /// <para>The execution timeout in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_***</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            /// <summary>
            /// <para>The run history.</para>
            /// </summary>
            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<CreatePolarClawCronJobResponseBodyJobRuns> Runs { get; set; }
            public class CreatePolarClawCronJobResponseBodyJobRuns : TeaModel {
                /// <summary>
                /// <para>The action performed. Valid values: <c>finished</c>, <c>error</c>, and <c>skipped</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>finished</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>Specifies whether the results were delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Delivered")]
                [Validation(Required=false)]
                public bool? Delivered { get; set; }

                /// <summary>
                /// <para>The delivery status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>not-requested</para>
                /// </summary>
                [NameInMap("DeliveryStatus")]
                [Validation(Required=false)]
                public string DeliveryStatus { get; set; }

                /// <summary>
                /// <para>The execution duration in milliseconds.</para>
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
                /// <para>f83f5278-1abe-40a6-b10e-ad3ecdc05de2</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The model used for the run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bailian/qwen3.5-plus</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The next run timestamp in milliseconds.</para>
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
                /// <para>bailian</para>
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// <para>The actual execution timestamp in milliseconds.</para>
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
                /// <hr>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The status of the run. Valid values: <c>ok</c>, <c>error</c>, and <c>skipped</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The run summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The run timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370572518</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public long? Ts { get; set; }

                /// <summary>
                /// <para>The token usage details.</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public CreatePolarClawCronJobResponseBodyJobRunsUsage Usage { get; set; }
                public class CreatePolarClawCronJobResponseBodyJobRunsUsage : TeaModel {
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
            public CreatePolarClawCronJobResponseBodyJobSchedule Schedule { get; set; }
            public class CreatePolarClawCronJobResponseBodyJobSchedule : TeaModel {
                /// <summary>
                /// <para>The anchor timestamp for interval alignment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370572518</para>
                /// </summary>
                [NameInMap("AnchorMs")]
                [Validation(Required=false)]
                public long? AnchorMs { get; set; }

                /// <summary>
                /// <para>The ISO 8601 timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-10T09:00:00+08:00</para>
                /// </summary>
                [NameInMap("At")]
                [Validation(Required=false)]
                public string At { get; set; }

                /// <summary>
                /// <para>The interval in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("EveryMs")]
                [Validation(Required=false)]
                public long? EveryMs { get; set; }

                /// <summary>
                /// <para>The cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 9 * * *</para>
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// <para>The schedule type. Valid values: <c>cron</c>, <c>every</c>, and <c>at</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The IANA time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Tz")]
                [Validation(Required=false)]
                public string Tz { get; set; }

            }

            /// <summary>
            /// <para>The session key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent:main:feishu:direct:***</para>
            /// </summary>
            [NameInMap("SessionKey")]
            [Validation(Required=false)]
            public string SessionKey { get; set; }

            /// <summary>
            /// <para>The session target. Valid values: <c>main</c>, <c>isolated</c>, and <c>current</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("SessionTarget")]
            [Validation(Required=false)]
            public string SessionTarget { get; set; }

            /// <summary>
            /// <para>The current state of the job.</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public CreatePolarClawCronJobResponseBodyJobState State { get; set; }
            public class CreatePolarClawCronJobResponseBodyJobState : TeaModel {
                /// <summary>
                /// <para>The number of consecutive execution failures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ConsecutiveErrors")]
                [Validation(Required=false)]
                public int? ConsecutiveErrors { get; set; }

                /// <summary>
                /// <para>The last run timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777370544931</para>
                /// </summary>
                [NameInMap("LastRunAtMs")]
                [Validation(Required=false)]
                public long? LastRunAtMs { get; set; }

                /// <summary>
                /// <para>The last run status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("LastRunStatus")]
                [Validation(Required=false)]
                public string LastRunStatus { get; set; }

                /// <summary>
                /// <para>The next run timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1777424400000</para>
                /// </summary>
                [NameInMap("NextRunAtMs")]
                [Validation(Required=false)]
                public long? NextRunAtMs { get; set; }

            }

            /// <summary>
            /// <para>The update timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777370572517</para>
            /// </summary>
            [NameInMap("UpdatedAtMs")]
            [Validation(Required=false)]
            public long? UpdatedAtMs { get; set; }

            /// <summary>
            /// <para>The wake mode. Valid values: <c>now</c> and <c>next-heartbeat</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>now</para>
            /// </summary>
            [NameInMap("WakeMode")]
            [Validation(Required=false)]
            public string WakeMode { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>Indicates whether the job ran immediately after creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RanImmediately")]
        [Validation(Required=false)]
        public bool? RanImmediately { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
