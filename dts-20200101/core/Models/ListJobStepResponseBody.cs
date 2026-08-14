// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ListJobStepResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The task step information.</para>
        /// </summary>
        [NameInMap("JobSteps")]
        [Validation(Required=false)]
        public List<ListJobStepResponseBodyJobSteps> JobSteps { get; set; }
        public class ListJobStepResponseBodyJobSteps : TeaModel {
            /// <summary>
            /// <para>The job start time, in the format <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-11T09:33:23Z</para>
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// <para>Task step identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The job creation time, in the format <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-28T17:13:51Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fullcheck find different records : 2372</para>
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// </summary>
            [NameInMap("ErrorDetails")]
            [Validation(Required=false)]
            public List<ListJobStepResponseBodyJobStepsErrorDetails> ErrorDetails { get; set; }
            public class ListJobStepResponseBodyJobStepsErrorDetails : TeaModel {
                /// <summary>
                /// <para>Error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>URL of the help document.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("HelpUrl")]
                [Validation(Required=false)]
                public string HelpUrl { get; set; }

            }

            /// <summary>
            /// <para>Task end time, in the format <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-15T02:15:14Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>Incremental data latency, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IncLatencyMilliseconds")]
            [Validation(Required=false)]
            public long? IncLatencyMilliseconds { get; set; }

            /// <summary>
            /// <para>Incremental data latency, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("IncLatencySeconds")]
            [Validation(Required=false)]
            public long? IncLatencySeconds { get; set; }

            /// <summary>
            /// <para>The task step ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>l02c1f7h179****</para>
            /// </summary>
            [NameInMap("JobStepId")]
            [Validation(Required=false)]
            public string JobStepId { get; set; }

            /// <summary>
            /// <para>Task step information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Precheck: precheck phase</description></item>
            /// <item><description>Incremental data service: incremental data collection phase</description></item>
            /// <item><description>dts.step.struct.load: schema migration phase</description></item>
            /// <item><description>dts.step.data.load: full migration phase</description></item>
            /// <item><description>etl-check: extract, transform, and load phase</description></item>
            /// <item><description>Consistency validation: data verification phase</description></item>
            /// <item><description>Synchronization: incremental synchronization phase</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>预检查</para>
            /// </summary>
            [NameInMap("JobStepName")]
            [Validation(Required=false)]
            public string JobStepName { get; set; }

            /// <summary>
            /// <para>The time when the job was updated, in the format <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-03T02:26:14Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the acceleration feature should be provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedAcceleration")]
            [Validation(Required=false)]
            public bool? NeedAcceleration { get; set; }

            /// <summary>
            /// <para>The progress of the task step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>Task step serial number. Indicates the task execution order. A smaller value indicates an earlier execution order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Serial")]
            [Validation(Required=false)]
            public int? Serial { get; set; }

            /// <summary>
            /// <para>Task step status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>○ Finished</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The number of sub-jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubJobCount")]
            [Validation(Required=false)]
            public int? SubJobCount { get; set; }

            /// <summary>
            /// <para>Step information of the sub-job.</para>
            /// </summary>
            [NameInMap("SubJobSteps")]
            [Validation(Required=false)]
            public List<ListJobStepResponseBodyJobStepsSubJobSteps> SubJobSteps { get; set; }
            public class ListJobStepResponseBodyJobStepsSubJobSteps : TeaModel {
                /// <summary>
                /// <para>The time when the sub-job was started, in the format <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-02T02:00:21Z</para>
                /// </summary>
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                /// <summary>
                /// <para>Sub-task step identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>03</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The time when the sub-job was created, in the format <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-20T02:13:12Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UncaughtException:java.lang.NullPointerException</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>Error message.</para>
                /// </summary>
                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<ListJobStepResponseBodyJobStepsSubJobStepsErrorDetails> ErrorDetails { get; set; }
                public class ListJobStepResponseBodyJobStepsSubJobStepsErrorDetails : TeaModel {
                    /// <summary>
                    /// <para>Error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Success</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>URL of the help document.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("HelpUrl")]
                    [Validation(Required=false)]
                    public string HelpUrl { get; set; }

                }

                /// <summary>
                /// <para>End time of the sub-task, in the format <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T02:15:14Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>Incremental data latency, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IncLatencyMilliseconds")]
                [Validation(Required=false)]
                public string IncLatencyMilliseconds { get; set; }

                /// <summary>
                /// <para>Incremental data latency, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IncLatencySeconds")]
                [Validation(Required=false)]
                public long? IncLatencySeconds { get; set; }

                /// <summary>
                /// <para>Job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mj3z9w9s10am68o_0004_0000</para>
                /// </summary>
                [NameInMap("JobStepId")]
                [Validation(Required=false)]
                public string JobStepId { get; set; }

                /// <summary>
                /// <para>Sub-job step information. Valid values are as follows:</para>
                /// <list type="bullet">
                /// <item><description>Precheck: precheck phase</description></item>
                /// <item><description>Incremental data service: incremental data collection phase</description></item>
                /// <item><description>dts.step.struct.load: schema migration phase</description></item>
                /// <item><description>dts.step.data.load: full migration phase</description></item>
                /// <item><description>etl-check: extract, transform, and load (ETL) phase</description></item>
                /// <item><description>Consistency validation: data verification phase</description></item>
                /// <item><description>Synchronization: incremental synchronization phase</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("JobStepName")]
                [Validation(Required=false)]
                public string JobStepName { get; set; }

                /// <summary>
                /// <para>The time when the sub-job was updated, in the format <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-22T02:04:35Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the acceleration feature is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NeedAcceleration")]
                [Validation(Required=false)]
                public bool? NeedAcceleration { get; set; }

                /// <summary>
                /// <para>Progress of the sub-job step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>Serial number of the sub-task step. Indicates the task execution order; the smaller the numeric value, the earlier the execution order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Serial")]
                [Validation(Required=false)]
                public int? Serial { get; set; }

                /// <summary>
                /// <para>Status of the sub-task step. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Failed: failed.</description></item>
                /// <item><description>Pause: paused.</description></item>
                /// <item><description>Schedule: scheduled.</description></item>
                /// <item><description>Init: initialization.</description></item>
                /// <item><description>Running: synchronizing.</description></item>
                /// <item><description>Catched: waiting for synchronization.</description></item>
                /// <item><description>Finished: ended.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <para>Used to distinguish between the Redis full and incremental phases. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>full: Full phase</description></item>
            /// <item><description>inc: Incremental phase</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("redisPhaseType")]
            [Validation(Required=false)]
            public string RedisPhaseType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Indicates whether the Console 2.0 API is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("UseV2API")]
        [Validation(Required=false)]
        public bool? UseV2API { get; set; }

    }

}
