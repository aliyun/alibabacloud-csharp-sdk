// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawCronJobsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<DescribePolarClawCronJobsResponseBodyJobs> Jobs { get; set; }
        public class DescribePolarClawCronJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1777370572517</para>
            /// </summary>
            [NameInMap("CreatedAtMs")]
            [Validation(Required=false)]
            public long? CreatedAtMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeleteAfterRun")]
            [Validation(Required=false)]
            public bool? DeleteAfterRun { get; set; }

            [NameInMap("Delivery")]
            [Validation(Required=false)]
            public DescribePolarClawCronJobsResponseBodyJobsDelivery Delivery { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsDelivery : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BestEffort")]
                [Validation(Required=false)]
                public bool? BestEffort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>feishu</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>announce</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ou_***</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Daily report generation</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0ee00f56-f467-4d41-858c-ca4ede2c770e</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Payload")]
            [Validation(Required=false)]
            public DescribePolarClawCronJobsResponseBodyJobsPayload Payload { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsPayload : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BestEffortDeliver")]
                [Validation(Required=false)]
                public bool? BestEffortDeliver { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>feishu</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Deliver")]
                [Validation(Required=false)]
                public bool? Deliver { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>systemEvent</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LightContext")]
                [Validation(Required=false)]
                public bool? LightContext { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bailian/qwen3.5-plus</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ou_***</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<DescribePolarClawCronJobsResponseBodyJobsRuns> Runs { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsRuns : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>finished</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Delivered")]
                [Validation(Required=false)]
                public bool? Delivered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>not-requested</para>
                /// </summary>
                [NameInMap("DeliveryStatus")]
                [Validation(Required=false)]
                public string DeliveryStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>27586</para>
                /// </summary>
                [NameInMap("DurationMs")]
                [Validation(Required=false)]
                public long? DurationMs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f83f5278-1abe-40a6-b10e-ad3ecdc05de2</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bailian/qwen3.5-plus</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1777424400000</para>
                /// </summary>
                [NameInMap("NextRunAtMs")]
                [Validation(Required=false)]
                public long? NextRunAtMs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bailian</para>
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1777370544931</para>
                /// </summary>
                [NameInMap("RunAtMs")]
                [Validation(Required=false)]
                public long? RunAtMs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Generate the daily report.</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1777370572518</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public long? Ts { get; set; }

                [NameInMap("Usage")]
                [Validation(Required=false)]
                public DescribePolarClawCronJobsResponseBodyJobsRunsUsage Usage { get; set; }
                public class DescribePolarClawCronJobsResponseBodyJobsRunsUsage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30250</para>
                    /// </summary>
                    [NameInMap("InputTokens")]
                    [Validation(Required=false)]
                    public int? InputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30250</para>
                    /// </summary>
                    [NameInMap("OutputTokens")]
                    [Validation(Required=false)]
                    public int? OutputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60500</para>
                    /// </summary>
                    [NameInMap("TotalTokens")]
                    [Validation(Required=false)]
                    public int? TotalTokens { get; set; }

                }

            }

            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public DescribePolarClawCronJobsResponseBodyJobsSchedule Schedule { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsSchedule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1777370572518</para>
                /// </summary>
                [NameInMap("AnchorMs")]
                [Validation(Required=false)]
                public long? AnchorMs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-04-10T09:00:00+08:00</para>
                /// </summary>
                [NameInMap("At")]
                [Validation(Required=false)]
                public string At { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("EveryMs")]
                [Validation(Required=false)]
                public long? EveryMs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0 9 * * *</para>
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Tz")]
                [Validation(Required=false)]
                public string Tz { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent:main:feishu:direct:***</para>
            /// </summary>
            [NameInMap("SessionKey")]
            [Validation(Required=false)]
            public string SessionKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("SessionTarget")]
            [Validation(Required=false)]
            public string SessionTarget { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public DescribePolarClawCronJobsResponseBodyJobsState State { get; set; }
            public class DescribePolarClawCronJobsResponseBodyJobsState : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ConsecutiveErrors")]
                [Validation(Required=false)]
                public int? ConsecutiveErrors { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1777370544931</para>
                /// </summary>
                [NameInMap("LastRunAtMs")]
                [Validation(Required=false)]
                public long? LastRunAtMs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("LastRunStatus")]
                [Validation(Required=false)]
                public string LastRunStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1777424400000</para>
                /// </summary>
                [NameInMap("NextRunAtMs")]
                [Validation(Required=false)]
                public long? NextRunAtMs { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1777368967284</para>
            /// </summary>
            [NameInMap("UpdatedAtMs")]
            [Validation(Required=false)]
            public long? UpdatedAtMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>now</para>
            /// </summary>
            [NameInMap("WakeMode")]
            [Validation(Required=false)]
            public string WakeMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2281C6C9-CBAB-1AFD-8400-670750CF6025_2212</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
