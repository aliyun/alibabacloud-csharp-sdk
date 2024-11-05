// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeHistoryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The task objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>A set of allowed actions that can be taken on the task. The system matches the current step name and status of the task to the available actions specified by ActionInfo. If no matching action is found, the current status of the task does not support any action. Example:</para>
            /// <pre><c>   &quot;steps&quot;: [
            ///     {
            ///       &quot;step_name&quot;: &quot;exec_task&quot;, // The name of the step, which matches the value of CurrentStepName.
            ///       &quot;action_info&quot;: {    // The actions supported for this step.
            ///         &quot;Waiting&quot;: [      // The status, which matches the value of Status.
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
            /// <item><description>retry: makes another attempt.</description></item>
            /// <item><description>cancel: makes a cancellation.</description></item>
            /// <item><description>modifySwitchTime: changes the switching or restoration time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><c>{\\&quot;steps\\&quot;:[{\\&quot;action_info\\&quot;:{\\&quot;Waiting\\&quot;:[\\&quot;modifySwitchTime\\&quot;]},\\&quot;step_name\\&quot;:\\&quot;exec_task\\&quot;}]}</c></para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The request source. Valid values: System and User.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("CallerSource")]
            [Validation(Required=false)]
            public string CallerSource { get; set; }

            /// <summary>
            /// <para>The ID of the user who made the request. If CallerSource is set to User, CallerUid indicates the unique ID (UID) of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
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
            /// <para>The database type. The value is fixed to mongodb.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mongodb</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The end time of the performed O\&amp;M task. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-16T02:59Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>dds-t4n18194768fxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-dds</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance type of the instance. The value is fixed to Instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The product. The value is fixed to dds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dds</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The current progress of the task. The valid values range from 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The reason why the current task was initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The estimated remaining execution time. Unit: seconds. The value 0 indicates that the task is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// <para>The start time of the performed O\&amp;M task. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-11T02:33Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Scheduled: The task is waiting to be executed.</description></item>
            /// <item><description>Running: The task is running.</description></item>
            /// <item><description>Succeed: The task is successful.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
            /// <item><description>Cancelling: The task is being terminated.</description></item>
            /// <item><description>Canceled: The task has been terminated.</description></item>
            /// <item><description>Waiting: The task is waiting for scheduled time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The details of the task. The task details vary based on the value of the taskType parameter.</para>
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
            /// <para>t-0mq1yyhm3ffl2bxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// <list type="bullet">
            /// <item><description>CreateIns: Create an instance.</description></item>
            /// <item><description>DeleteIns: Delete an instance.</description></item>
            /// <item><description>ChangeVariable: Modify parameter settings for an instance.</description></item>
            /// <item><description>ModifyInsConfig: Change the configurations of an instance.</description></item>
            /// <item><description>RestartIns: Restart an instance.</description></item>
            /// <item><description>HaSwitch: Perform a primary/secondary switchover on an instance.</description></item>
            /// <item><description>CloneIns: Clone an instance.</description></item>
            /// <item><description>KernelVersionUpgrade: Update the minor version of an instance.</description></item>
            /// <item><description>ProxyVersionUpgrade: Upgrade the agent version of an instance.</description></item>
            /// <item><description>ModifyAccount: Change the account of an instance.</description></item>
            /// <item><description>ModifyInsSpec: Change the specifications of an instance or perform a data migration on the instance.</description></item>
            /// <item><description>CreateReadIns: Create a read-only instance.</description></item>
            /// <item><description>StartIns: Start an instance.</description></item>
            /// <item><description>StopIns: Stop an instance.</description></item>
            /// <item><description>ModifyNetwork: Modify the network type for an instance.</description></item>
            /// <item><description>LockIns: Lock an instance.</description></item>
            /// <item><description>UnlockIns: Unlock an instance.</description></item>
            /// <item><description>DiskOnlineExpansion: Scale out the disks of an instance online.</description></item>
            /// <item><description>StorageOnlineExpansion: Expend the storage capacity of an instance online.</description></item>
            /// <item><description>AddInsNode: Add a node to an instance.</description></item>
            /// <item><description>DeleteInsNode: Delete a node from an instance.</description></item>
            /// <item><description>ManualBackupIns: Manually back up an instance.</description></item>
            /// <item><description>ModifyInsStorageType: Modify the storage type for an instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CreateIns</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the resource belongs.</para>
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
        /// <para>3C4A2494-XXXX-XXXX-93CF-548DB3375193</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks that meet these conditions without taking pagination into account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
