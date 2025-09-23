// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetJobExecutionProgressResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobExecutionProgressResponseBodyData Data { get; set; }
        public class GetJobExecutionProgressResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1758594961000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            [NameInMap("RootProgress")]
            [Validation(Required=false)]
            public GetJobExecutionProgressResponseBodyDataRootProgress RootProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataRootProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Finished")]
                [Validation(Required=false)]
                public long? Finished { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            [NameInMap("ShardingProgress")]
            [Validation(Required=false)]
            public List<GetJobExecutionProgressResponseBodyDataShardingProgress> ShardingProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataShardingProgress : TeaModel {
                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1306189481388277762</para>
                /// </summary>
                [NameInMap("JobExecutionId")]
                [Validation(Required=false)]
                public string JobExecutionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2,4,6,8,10</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("StatusType")]
                [Validation(Required=false)]
                public GetJobExecutionProgressResponseBodyDataShardingProgressStatusType StatusType { get; set; }
                public class GetJobExecutionProgressResponseBodyDataShardingProgressStatusType : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TaskStatus.FAILED</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Tips")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Tips { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://192.168.1.9:9999/">http://192.168.1.9:9999/</a></para>
                /// </summary>
                [NameInMap("WorkerAddr")]
                [Validation(Required=false)]
                public string WorkerAddr { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1758506761000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public List<GetJobExecutionProgressResponseBodyDataTaskProgress> TaskProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataTaskProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public int? Failed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>calendar_test_2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Pulled")]
                [Validation(Required=false)]
                public int? Pulled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public int? Queue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Running")]
                [Validation(Required=false)]
                public int? Running { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public int? Success { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            [NameInMap("TotalProgress")]
            [Validation(Required=false)]
            public GetJobExecutionProgressResponseBodyDataTotalProgress TotalProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataTotalProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Finished")]
                [Validation(Required=false)]
                public long? Finished { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            [NameInMap("WorkerProgress")]
            [Validation(Required=false)]
            public List<GetJobExecutionProgressResponseBodyDataWorkerProgress> WorkerProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataWorkerProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public int? Failed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Pulled")]
                [Validation(Required=false)]
                public int? Pulled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public int? Queue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Running")]
                [Validation(Required=false)]
                public int? Running { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public int? Success { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1a0e97fb17244665327205402dbd6d</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.10.116.53:61941</para>
                /// </summary>
                [NameInMap("WorkerAddr")]
                [Validation(Required=false)]
                public string WorkerAddr { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter format error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9B57FDD7-ABBE-5030-B348-86EB9943DB59</para>
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

    }

}
