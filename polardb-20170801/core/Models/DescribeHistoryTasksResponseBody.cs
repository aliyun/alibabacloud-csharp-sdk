// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHistoryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The allowed operation information.</para>
            /// <remarks>
            /// <para>This feature is not supported yet.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The request source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>System</b>: system</para>
            /// </description></item>
            /// <item><description><para><b>User</b>: user</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("CallerSource")]
            [Validation(Required=false)]
            public string CallerSource { get; set; }

            /// <summary>
            /// <para>The ID of the requesting user. If <c>CallerSource</c> is <c>User</c>, this is the user\&quot;s UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1816563541899***</para>
            /// </summary>
            [NameInMap("CallerUid")]
            [Validation(Required=false)]
            public string CallerUid { get; set; }

            /// <summary>
            /// <para>The name of the current step being executed. If this parameter is empty, the task has not started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finish_task</para>
            /// </summary>
            [NameInMap("CurrentStepName")]
            [Validation(Required=false)]
            public string CurrentStepName { get; set; }

            /// <summary>
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_mysql</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The end time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-03T07:30:57Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-2zed3m89cw***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-2zed3m89cw***</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The completion progress of the task, from 0.0 to 100.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The reason for initiating the current task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The estimated remaining execution time, in seconds (s).</para>
            /// <remarks>
            /// <para>This value is for reference only. The actual execution time prevails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// <para>The start time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-03T07:25:16Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The final status of the task.</para>
            /// <list type="bullet">
            /// <item><description><para>Scheduled: waiting for execution</para>
            /// </description></item>
            /// <item><description><para>Running: executing</para>
            /// </description></item>
            /// <item><description><para>Succeed: executed successfully</para>
            /// </description></item>
            /// <item><description><para>Failed: execution failed</para>
            /// </description></item>
            /// <item><description><para>Cancelling: stopping</para>
            /// </description></item>
            /// <item><description><para>Canceled: stopped</para>
            /// </description></item>
            /// <item><description><para>Waiting: waiting for preset time</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;steps\&quot;:[{\&quot;step_name\&quot;:\&quot;init_task\&quot;},{\&quot;step_name\&quot;:\&quot;exec_task\&quot;},{\&quot;step_name\&quot;:\&quot;finish_task\&quot;}]}</para>
            /// </summary>
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public string TaskDetail { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-0mqt8qhnw04ipz0***</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ChangeVariable</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The UID of the account that owns the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1816563541899***</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The page number of the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F90D7C14-2D1C-5B88-9CD1-23AB2CF89***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks that meet the conditions, regardless of paging factors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
