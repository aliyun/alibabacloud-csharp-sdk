// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried task objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>A set of allowed actions that can be taken on the task. The system matches the current step name and status of the task to the available actions specified by ActionInfo. If no matching action is found, the current status of the task does not support any action. Example:</para>
            /// <pre><c>{&quot;steps&quot;: [
            ///     {
            ///       &quot;step_name&quot;: &quot;exec_task&quot;, // The name of the step, which matches CurrentStepName.
            ///       &quot;action_info&quot;: {    // The actions supported for this step.
            ///         &quot;Waiting&quot;: [      // The status, which matches Status.
            ///           &quot;modifySwitchTime&quot; // The action. Multiple actions are supported.
            ///         ]
            ///       }
            ///     },
            ///     {
            ///       &quot;step_name&quot;: &quot;init_task&quot;, // The name of the step.
            ///       &quot;action_info&quot;: {    // The actions supported for this step.
            ///         &quot;Running&quot;: [      // The status.
            ///           &quot;cancel&quot;,       // The action.
            ///           &quot;pause&quot;
            ///         ]
            ///       }
            ///     }
            ///   ]
            /// }
            /// </c></pre>
            /// <para>The system may support the following actions:</para>
            /// <list type="bullet">
            /// <item><description><b>retry</b></description></item>
            /// <item><description><b>cancel</b></description></item>
            /// <item><description><b>modifySwitchTime</b>: changes the switching or restoration time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;steps\&quot;:[{\&quot;action_info\&quot;:{\&quot;Waiting\&quot;:[\&quot;modifySwitchTime\&quot;]},\&quot;step_name\&quot;:\&quot;exec_task\&quot;}]}</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The ID of the user who made the request. If CallerSource is set to User, CallerUid indicates the unique ID (UID) of the user.</para>
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
            /// <item><description><b>System</b></description></item>
            /// <item><description><b>User</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("CallerUid")]
            [Validation(Required=false)]
            public string CallerUid { get; set; }

            /// <summary>
            /// <para>The name of the current step. If this parameter is left empty, the task is not started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec_task</para>
            /// </summary>
            [NameInMap("CurrentStepName")]
            [Validation(Required=false)]
            public string CurrentStepName { get; set; }

            /// <summary>
            /// <para>The database type. The return value is redis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The end time of the task. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
            /// <para>The instance type. The return value is Instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The product. The return value is kvstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kvstore</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The task progress. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79.0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The reason why the current task was initiated.</para>
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
            /// <para>The estimated amount of time remaining to complete the task. Unit: seconds. A value of 0 indicates that the task is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// <para>The start time of the task. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-03T11:31:03Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// <list type="bullet">
            /// <item><description><b>Scheduled</b></description></item>
            /// <item><description><b>Running</b></description></item>
            /// <item><description><b>Succeed</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// <item><description><b>Cancelling</b></description></item>
            /// <item><description><b>Canceled</b></description></item>
            /// <item><description><b>Waiting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The task details. The details vary based on the task type.</para>
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
            /// <list type="bullet">
            /// <item><description><b>ModifyInsSpec</b></description></item>
            /// <item><description><b>DeleteInsNode</b></description></item>
            /// <item><description><b>AddInsNode</b></description></item>
            /// <item><description><b>HaSwitch</b></description></item>
            /// <item><description><b>RestartIns</b></description></item>
            /// <item><description><b>CreateIns</b></description></item>
            /// <item><description><b>ModifyInsConfig</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ModifyInsSpec</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the resources belong.</para>
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
        /// <para>The maximum number of entries returned per page.</para>
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
        /// <para>The total number of tasks that meet these constraints without taking pagination into account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
