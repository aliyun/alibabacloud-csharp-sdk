// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The task list.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The allowed operation information. When used, the system matches the Action based on currentStepName and status in this information. If no Action is matched, the task does not support operations in its current state. Example:</para>
            /// <pre><c>  &quot;steps&quot;: [
            ///     {
            ///       &quot;step_name&quot;: &quot;exec_task&quot;, // Step name, matched with currentStepName
            ///       &quot;action_info&quot;: {    // Operations supported by the step
            ///         &quot;Waiting&quot;: [      // Status, matched with status
            ///           &quot;modifySwitchTime&quot; // Action. Multiple actions may be available.
            ///         ]
            ///       }
            ///     },
            ///     {
            ///       &quot;step_name&quot;: &quot;init_task&quot;, // Step name
            ///       &quot;action_info&quot;: {    // Operations supported by the step
            ///         &quot;Running&quot;: [      // Status
            ///           &quot;cancel&quot;,       // Action
            ///           &quot;pause&quot;
            ///         ]
            ///       }
            ///     }
            ///   ]
            /// }
            /// </c></pre>
            /// <para>Supported operations:</para>
            /// <list type="bullet">
            /// <item><description><b>retry</b>: Retry.</description></item>
            /// <item><description><b>cancel</b>: Cancel.</description></item>
            /// <item><description><b>modifySwitchTime</b>: Modify the switchover time or recovery time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;steps\&quot;:[{\&quot;action_info\&quot;:{\&quot;Waiting\&quot;:[\&quot;modifySwitchTime\&quot;]},\&quot;step_name\&quot;:\&quot;exec_task\&quot;}]}</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The request user ID. If callerSource is User, this value indicates the user UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
            /// </summary>
            [NameInMap("CallerSource")]
            [Validation(Required=false)]
            public string CallerSource { get; set; }

            /// <summary>
            /// <para>The request source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>System</b>: System.</description></item>
            /// <item><description><b>User</b>: User.</description></item>
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
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The task end time.</para>
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
            /// <para>rm-uf62br2491p5l****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
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
            /// <para>rds</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The current progress.</para>
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
            /// <hr>
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
            /// <para>The estimated remaining execution time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// <para>The task start time.</para>
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
            /// <item><description>Scheduled: Waiting to be executed.</description></item>
            /// <item><description>Running: Running.</description></item>
            /// <item><description>Succeed: Succeeded.</description></item>
            /// <item><description>Failed: Failed.</description></item>
            /// <item><description>Cancelling: Being terminated.</description></item>
            /// <item><description>Canceled: Terminated.</description></item>
            /// <item><description>Waiting: Waiting for the scheduled time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task details.</para>
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
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest_dispatch_cases</para>
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
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. If you encounter an issue, provide this request ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CD61041-35F7-10F7-BE94-33A48B22****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks that meet the filter conditions, regardless of pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
