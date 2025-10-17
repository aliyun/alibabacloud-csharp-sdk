// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ListJobStepResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("JobSteps")]
        [Validation(Required=false)]
        public List<ListJobStepResponseBodyJobSteps> JobSteps { get; set; }
        public class ListJobStepResponseBodyJobSteps : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-11T09:33:23Z</para>
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-28T17:13:51Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fullcheck find different records : 2372</para>
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            [NameInMap("ErrorDetails")]
            [Validation(Required=false)]
            public List<ListJobStepResponseBodyJobStepsErrorDetails> ErrorDetails { get; set; }
            public class ListJobStepResponseBodyJobStepsErrorDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("HelpUrl")]
                [Validation(Required=false)]
                public string HelpUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-15T02:15:14Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IncLatencyMilliseconds")]
            [Validation(Required=false)]
            public long? IncLatencyMilliseconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("IncLatencySeconds")]
            [Validation(Required=false)]
            public long? IncLatencySeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>l02c1f7h179****</para>
            /// </summary>
            [NameInMap("JobStepId")]
            [Validation(Required=false)]
            public string JobStepId { get; set; }

            [NameInMap("JobStepName")]
            [Validation(Required=false)]
            public string JobStepName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-03T02:26:14Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedAcceleration")]
            [Validation(Required=false)]
            public bool? NeedAcceleration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Serial")]
            [Validation(Required=false)]
            public int? Serial { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>○ Finished</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubJobCount")]
            [Validation(Required=false)]
            public int? SubJobCount { get; set; }

            [NameInMap("SubJobSteps")]
            [Validation(Required=false)]
            public List<ListJobStepResponseBodyJobStepsSubJobSteps> SubJobSteps { get; set; }
            public class ListJobStepResponseBodyJobStepsSubJobSteps : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-02T02:00:21Z</para>
                /// </summary>
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>03</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-09-20T02:13:12Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UncaughtException:java.lang.NullPointerException</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<ListJobStepResponseBodyJobStepsSubJobStepsErrorDetails> ErrorDetails { get; set; }
                public class ListJobStepResponseBodyJobStepsSubJobStepsErrorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Success</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("HelpUrl")]
                    [Validation(Required=false)]
                    public string HelpUrl { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-03-15T02:15:14Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IncLatencyMilliseconds")]
                [Validation(Required=false)]
                public string IncLatencyMilliseconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IncLatencySeconds")]
                [Validation(Required=false)]
                public long? IncLatencySeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mj3z9w9s10am68o_0004_0000</para>
                /// </summary>
                [NameInMap("JobStepId")]
                [Validation(Required=false)]
                public string JobStepId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("JobStepName")]
                [Validation(Required=false)]
                public string JobStepName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-08-22T02:04:35Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NeedAcceleration")]
                [Validation(Required=false)]
                public bool? NeedAcceleration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Serial")]
                [Validation(Required=false)]
                public int? Serial { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("redisPhaseType")]
            [Validation(Required=false)]
            public string RedisPhaseType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("UseV2API")]
        [Validation(Required=false)]
        public bool? UseV2API { get; set; }

    }

}
