// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of task objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The allowed operation information. When used, the operation Action is matched based on currentStepName and status in this information. If no Action is matched, the task does not support operations in its current state. Example:</para>
            /// <pre><c>{&quot;steps&quot;: [
            ///     {
            ///       &quot;step_name&quot;: &quot;exec_task&quot;, // Step name, matched with currentStepName
            ///       &quot;action_info&quot;: {    // Operations supported by the step
            ///         &quot;Waiting&quot;: [      // Status, matched with status
            ///           &quot;modifySwitchTime&quot; // Operation Action, may have multiple values, indicating multiple supported operations
            ///         ]
            ///       }
            ///     },
            ///     {
            ///       &quot;step_name&quot;: &quot;init_task&quot;, // Step name
            ///       &quot;action_info&quot;: {    // Operations supported by the step
            ///         &quot;Running&quot;: [      // Status
            ///           &quot;cancel&quot;,       // Operation
            ///           &quot;pause&quot;
            ///         ]
            ///       }
            ///     }
            ///   ]
            /// }
            /// </c></pre>
            /// <para>Operations that the system may support: </para>
            /// <list type="bullet">
            /// <item><description><b>retry</b>: Retry.</description></item>
            /// <item><description><b>cancel</b>: Cancel.</description></item>
            /// <item><description><b>modifySwitchTime</b>: Modify the switchover time or recovery time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;steps&quot;:[{&quot;action_info&quot;:{&quot;Waiting&quot;:[&quot;modifySwitchTime&quot;]},&quot;step_name&quot;:&quot;exec_task&quot;}]}</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The request user ID. When callerSource is User, this value represents the user UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
            /// </summary>
            [NameInMap("CallerSource")]
            [Validation(Required=false)]
            public string CallerSource { get; set; }

            /// <summary>
            /// <para>The request source. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>System</b>: Automatically initiated by the system.</description></item>
            /// <item><description><b>User</b>: Initiated by a user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("CallerUid")]
            [Validation(Required=false)]
            public string CallerUid { get; set; }

            /// <summary>
            /// <para>The name of the current step being executed. An empty value indicates that the task has not started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec_task</para>
            /// </summary>
            [NameInMap("CurrentStepName")]
            [Validation(Required=false)]
            public string CurrentStepName { get; set; }

            /// <summary>
            /// <para>The database type. The value is fixed as redis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The end time of the task in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-03T12:06:17Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1zxszhcgatnx****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dba-tair-test-qcloud</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance type. The value is fixed as Instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The product. The value is fixed as kvstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kvstore</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The current progress. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79.0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The reason why the current task was initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小版本升级</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The estimated remaining execution time. Unit: seconds. A value of 0 indicates that the execution is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// <para>The start time of the task in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-03T11:31:03Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Scheduled</b>: Waiting for execution.</description></item>
            /// <item><description><b>Running</b>: Running.</description></item>
            /// <item><description><b>Succeed</b>: Succeeded.</description></item>
            /// <item><description><b>Failed</b>: Failed.</description></item>
            /// <item><description><b>Cancelling</b>: Being stopped.</description></item>
            /// <item><description><b>Canceled</b>: Stopped.</description></item>
            /// <item><description><b>Waiting</b>: Waiting for the scheduled time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task details. Different task types correspond to different outputs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;callerUid\&quot;:\&quot;test\&quot;}</para>
            /// </summary>
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public string TaskDetail { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-83br18hloy3faf****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ModifyInsSpec</b>: Specification change or migration.</description></item>
            /// <item><description><b>DeleteInsNode</b>: Shard deletion.</description></item>
            /// <item><description><b>AddInsNode</b>: Shard addition.</description></item>
            /// <item><description><b>HaSwitch</b>: Primary/secondary switchover.</description></item>
            /// <item><description><b>RestartIns</b>: Instance restart.</description></item>
            /// <item><description><b>CreateIns</b>: Instance creation.</description></item>
            /// <item><description><b>ModifyInsConfig</b>: Configuration change.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ModifyInsSpec</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The user ID of the resource owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D622714-AEDD-4609-9167-F5DDD3D1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks that meet the query conditions, regardless of pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
