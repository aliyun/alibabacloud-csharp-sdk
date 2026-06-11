// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListJobExecutorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of executors.</para>
        /// </summary>
        [NameInMap("exexutors")]
        [Validation(Required=false)]
        public List<ListJobExecutorsResponseBodyExexutors> Exexutors { get; set; }
        public class ListJobExecutorsResponseBodyExexutors : TeaModel {
            /// <summary>
            /// <para>The total number of active tasks that the executor is running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("activeTasks")]
            [Validation(Required=false)]
            public long? ActiveTasks { get; set; }

            /// <summary>
            /// <para>The time when the executor was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760601***</para>
            /// </summary>
            [NameInMap("addTime")]
            [Validation(Required=false)]
            public long? AddTime { get; set; }

            /// <summary>
            /// <para>The total number of completed tasks that the executor has run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("completedTasks")]
            [Validation(Required=false)]
            public long? CompletedTasks { get; set; }

            /// <summary>
            /// <para>The disk usage of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("diskUsed")]
            [Validation(Required=false)]
            public long? DiskUsed { get; set; }

            /// <summary>
            /// <para>The job executor ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// <para>The executor type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>driver</para>
            /// </summary>
            [NameInMap("executorType")]
            [Validation(Required=false)]
            public string ExecutorType { get; set; }

            /// <summary>
            /// <para>The total number of failed tasks that the executor has run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("failedTasks")]
            [Validation(Required=false)]
            public long? FailedTasks { get; set; }

            /// <summary>
            /// <para>The address of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21.10.x.x:1201x</para>
            /// </summary>
            [NameInMap("hostPort")]
            [Validation(Required=false)]
            public string HostPort { get; set; }

            /// <summary>
            /// <para>The job run ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jr-1fe145df8ade366a</para>
            /// </summary>
            [NameInMap("jobRunId")]
            [Validation(Required=false)]
            public string JobRunId { get; set; }

            /// <summary>
            /// <para>The maximum memory of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4294967296</para>
            /// </summary>
            [NameInMap("maxMemory")]
            [Validation(Required=false)]
            public long? MaxMemory { get; set; }

            /// <summary>
            /// <para>The memory usage of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("memoryUsed")]
            [Validation(Required=false)]
            public long? MemoryUsed { get; set; }

            /// <summary>
            /// <para>The number of Resilient Distributed Dataset (RDD) blocks managed by the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("rddBlocks")]
            [Validation(Required=false)]
            public long? RddBlocks { get; set; }

            /// <summary>
            /// <para>The running status of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of cores for the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("totalCores")]
            [Validation(Required=false)]
            public long? TotalCores { get; set; }

            /// <summary>
            /// <para>The total runtime of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("totalDuration")]
            [Validation(Required=false)]
            public long? TotalDuration { get; set; }

            /// <summary>
            /// <para>The total garbage collection (GC) time of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("totalGCTime")]
            [Validation(Required=false)]
            public long? TotalGCTime { get; set; }

            /// <summary>
            /// <para>The number of bytes of input data for the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("totalInputBytes")]
            [Validation(Required=false)]
            public long? TotalInputBytes { get; set; }

            /// <summary>
            /// <para>The number of bytes read during the shuffle phase by the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("totalShuffleRead")]
            [Validation(Required=false)]
            public long? TotalShuffleRead { get; set; }

            /// <summary>
            /// <para>The number of bytes written during the shuffle phase by the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("totalShuffleWrite")]
            [Validation(Required=false)]
            public long? TotalShuffleWrite { get; set; }

            /// <summary>
            /// <para>The total number of tasks that the executor has run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("totalTasks")]
            [Validation(Required=false)]
            public long? TotalTasks { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-78faee4da118f02e</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
