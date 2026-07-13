// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyData Data { get; set; }
        public class DescribeTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of tasks.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyDataContent> Content { get; set; }
            public class DescribeTasksResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The task\&quot;s completion time, represented as a Unix timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724983927</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public long? CompleteTime { get; set; }

                /// <summary>
                /// <para>The error message returned if the task fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>device not online</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The execution ID. This parameter is currently unused and returns an empty string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>empty</para>
                /// </summary>
                [NameInMap("ExecutionId")]
                [Validation(Required=false)]
                public string ExecutionId { get; set; }

                /// <summary>
                /// <para>The task\&quot;s expiration time, represented as a Unix timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724983927</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The progress of the task, ranging from 0 to 10,000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AE43C4CB-8074-5EBD-9806-8CA6D12800B1</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The task\&quot;s start time, represented as a Unix timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724983927</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>empty</para>
                /// </summary>
                [NameInMap("TaskDescription")]
                [Validation(Required=false)]
                public string TaskDescription { get; set; }

                /// <summary>
                /// <para>The task details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;resourceTypes&quot;:[&quot;ACS::ECS::Instance&quot;,&quot;ACS::OSS::Bucket&quot;,&quot;ACS::OTS::Instance&quot;,&quot;ACS::NAS::FileSystem&quot;]}</para>
                /// </summary>
                [NameInMap("TaskDetail")]
                [Validation(Required=false)]
                public string TaskDetail { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-0000e4w0u1v592zdf6s7</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>empty</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The task priority. Valid values: <c>HIGH</c> (high-priority, for user-initiated tasks) and <c>LOW</c> (low-priority, for background tasks).</para>
                /// 
                /// <b>Example:</b>
                /// <para>HIGH</para>
                /// </summary>
                [NameInMap("TaskPriority")]
                [Validation(Required=false)]
                public string TaskPriority { get; set; }

                /// <summary>
                /// <para>The result of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;resourceCounts&quot;:[{&quot;resourceType&quot;:&quot;ACS::OSS::Bucket&quot;,&quot;count&quot;:2},{&quot;resourceType&quot;:&quot;ACS::NAS::FileSystem&quot;,&quot;count&quot;:3}]}</para>
                /// </summary>
                [NameInMap("TaskResult")]
                [Validation(Required=false)]
                public string TaskResult { get; set; }

                /// <summary>
                /// <para>The task status. Valid values: <c>CREATED</c>, <c>RUNNING</c>, <c>COMPLETE</c>, <c>FAILED</c>, <c>EXPIRED</c>, and <c>CANCELED</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// <para>The task type. Valid values: <c>TEST</c>, <c>UPDATE_RESOURCES</c>, and <c>CHECK_RULES</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPDATE_RESOURCES</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token used to retrieve the next page of results. If this parameter is empty, no more results are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f4b8c2504545a3b41af5e75147d17d12e3818a0b9b2ff9a2</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries matching the request criteria. This parameter is optional and is not returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE43C4CB-8074-5EBD-9806-8CA6D12800B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
