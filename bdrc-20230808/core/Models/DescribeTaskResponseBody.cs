// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTaskResponseBodyData Data { get; set; }
        public class DescribeTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The completion time, formatted as a Unix timestamp in seconds.</para>
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
            /// <para>too many requests.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The execution ID. This parameter is deprecated and always returns an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// <para>The expiration time, formatted as a Unix timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719026680</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The task\&quot;s progress, measured on a scale of 0 to 10,000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The ID of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>784076D6-BD6D-5564-9CEA-834EB11F0C62</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The start time, formatted as a Unix timestamp in seconds.</para>
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
            /// <para>The details of the task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;resourceTypes&quot;:[&quot;ACS::ECS::Instance&quot;,&quot;ACS::OSS::Bucket&quot;,&quot;ACS::OTS::Instance&quot;,&quot;ACS::NAS::FileSystem&quot;]}</para>
            /// </summary>
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public string TaskDetail { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-xxxxxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test5566</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The task priority. Valid values: <c>HIGH</c> (typically for user-initiated tasks) and <c>LOW</c> (typically for background tasks).</para>
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
            /// <para>The status of the task. Valid values: <c>CREATED</c> (Created), <c>RUNNING</c> (Running), <c>COMPLETE</c> (Completed), <c>FAILED</c> (Failed), <c>EXPIRED</c> (Expired), and <c>CANCELED</c> (Canceled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The task type. Valid values: <c>UPDATE_RESOURCES</c> (updates resources and their statuses) and <c>CHECK_RULES</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE_RESOURCES</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14DFF801-A4E3-5136-AAB8-7D246012CD7A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
