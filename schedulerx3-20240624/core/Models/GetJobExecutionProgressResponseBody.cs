// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetJobExecutionProgressResponseBody : TeaModel {
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
        /// <list type="bullet">
        /// <item><description>The data returned by the request.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobExecutionProgressResponseBodyData Data { get; set; }
        public class GetJobExecutionProgressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The job end time, in Unix milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758594961000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The description of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试任务</para>
            /// </summary>
            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            /// <summary>
            /// <para>The progress of the root task.</para>
            /// </summary>
            [NameInMap("RootProgress")]
            [Validation(Required=false)]
            public GetJobExecutionProgressResponseBodyDataRootProgress RootProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataRootProgress : TeaModel {
                /// <summary>
                /// <para>The number of finished items in the root task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Finished")]
                [Validation(Required=false)]
                public long? Finished { get; set; }

                /// <summary>
                /// <para>The total number of items in the root task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// <para>A list of progress details for each sharding task.</para>
            /// </summary>
            [NameInMap("ShardingProgress")]
            [Validation(Required=false)]
            public List<GetJobExecutionProgressResponseBodyDataShardingProgress> ShardingProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataShardingProgress : TeaModel {
                /// <summary>
                /// <para>The shard ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The execution ID of the sharding task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1306189481388277762</para>
                /// </summary>
                [NameInMap("JobExecutionId")]
                [Validation(Required=false)]
                public string JobExecutionId { get; set; }

                /// <summary>
                /// <para>The execution result of the sharding task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2,4,6,8,10</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The execution status of the sharding task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: UNKNOWN</para>
                /// </description></item>
                /// <item><description><para>1: INIT</para>
                /// </description></item>
                /// <item><description><para>2: PULLED</para>
                /// </description></item>
                /// <item><description><para>3: RUNNING</para>
                /// </description></item>
                /// <item><description><para>4: SUCCESS</para>
                /// </description></item>
                /// <item><description><para>5: FAILED</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Detailed information about the execution status.</para>
                /// </summary>
                [NameInMap("StatusType")]
                [Validation(Required=false)]
                public GetJobExecutionProgressResponseBodyDataShardingProgressStatusType StatusType { get; set; }
                public class GetJobExecutionProgressResponseBodyDataShardingProgressStatusType : TeaModel {
                    /// <summary>
                    /// <para>The status code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The name of the status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TaskStatus.FAILED</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Informational messages about the status.</para>
                    /// </summary>
                    [NameInMap("Tips")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Tips { get; set; }

                }

                /// <summary>
                /// <para>The address of the Worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://192.168.***.9:9999/">http://192.168.***.9:9999/</a></para>
                /// </summary>
                [NameInMap("WorkerAddr")]
                [Validation(Required=false)]
                public string WorkerAddr { get; set; }

            }

            /// <summary>
            /// <para>The job start time, in Unix milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758506761000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>A list of progress details for each subtask.</para>
            /// </summary>
            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public List<GetJobExecutionProgressResponseBodyDataTaskProgress> TaskProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataTaskProgress : TeaModel {
                /// <summary>
                /// <para>The number of failed items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public int? Failed { get; set; }

                /// <summary>
                /// <para>The name of the subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>calendar_test_2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of pulled items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Pulled")]
                [Validation(Required=false)]
                public int? Pulled { get; set; }

                /// <summary>
                /// <para>The number of items in the subtask\&quot;s queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public int? Queue { get; set; }

                /// <summary>
                /// <para>The number of running items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Running")]
                [Validation(Required=false)]
                public int? Running { get; set; }

                /// <summary>
                /// <para>The number of successful items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public int? Success { get; set; }

                /// <summary>
                /// <para>The total number of items in the subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <para>The overall progress of the job.</para>
            /// </summary>
            [NameInMap("TotalProgress")]
            [Validation(Required=false)]
            public GetJobExecutionProgressResponseBodyDataTotalProgress TotalProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataTotalProgress : TeaModel {
                /// <summary>
                /// <para>The number of finished items in the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Finished")]
                [Validation(Required=false)]
                public long? Finished { get; set; }

                /// <summary>
                /// <para>The total number of items in the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// <para>A list of execution progress details for each Worker.</para>
            /// </summary>
            [NameInMap("WorkerProgress")]
            [Validation(Required=false)]
            public List<GetJobExecutionProgressResponseBodyDataWorkerProgress> WorkerProgress { get; set; }
            public class GetJobExecutionProgressResponseBodyDataWorkerProgress : TeaModel {
                /// <summary>
                /// <para>The number of items that failed on this Worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public int? Failed { get; set; }

                /// <summary>
                /// <para>The number of items pulled by this Worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Pulled")]
                [Validation(Required=false)]
                public int? Pulled { get; set; }

                /// <summary>
                /// <para>The number of items in this Worker\&quot;s queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public int? Queue { get; set; }

                /// <summary>
                /// <para>The number of items this Worker is currently running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Running")]
                [Validation(Required=false)]
                public int? Running { get; set; }

                /// <summary>
                /// <para>The number of items successfully processed by this Worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public int? Success { get; set; }

                /// <summary>
                /// <para>The total number of items processed by this Worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <para>The trace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1a0e97fb17244665327205402dbd6d</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

                /// <summary>
                /// <para>The address of the Worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.<em><b>.</b></em>.53:61941</para>
                /// </summary>
                [NameInMap("WorkerAddr")]
                [Validation(Required=false)]
                public string WorkerAddr { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter format error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request, generated by Alibaba Cloud. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B57FDD7-ABBE-5030-B348-86EB9943DB59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
