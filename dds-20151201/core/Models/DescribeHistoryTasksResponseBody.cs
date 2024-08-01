// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeHistoryTasksResponseBody : TeaModel {
        /// <summary>
        /// The task objects.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// A set of allowed actions that can be taken on the task. The system matches the current step name and status of the task to the available actions specified by ActionInfo. If no matching action is found, the current status of the task does not support any action. Example:
            /// 
            ///        "steps": [
            ///         {
            ///           "step_name": "exec_task", // The name of the step, which matches the value of CurrentStepName.
            ///           "action_info": {    // The actions supported for this step.
            ///             "Waiting": [      // The status, which matches the value of Status.
            ///               "modifySwitchTime" // The action. Multiple actions are supported.
            ///             ]
            ///           }
            ///         },
            ///         {
            ///           "step_name": "init_task", // The name of the step.
            ///           "action_info": {    // The actions supported for this step.
            ///             "Running": [      // The status.
            ///               "cancel",       // The action.
            ///               "pause"
            ///             ]
            ///           }
            ///         }
            ///       ]
            ///     }
            /// 
            /// The system may support the following actions:
            /// 
            /// *   retry: makes another attempt.
            /// *   cancel: makes a cancellation.
            /// *   modifySwitchTime: changes the switching or restoration time.
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// The request source. Valid values: System and User.
            /// </summary>
            [NameInMap("CallerSource")]
            [Validation(Required=false)]
            public string CallerSource { get; set; }

            /// <summary>
            /// The ID of the user who made the request. If CallerSource is set to User, CallerUid indicates the unique ID (UID) of the user.
            /// </summary>
            [NameInMap("CallerUid")]
            [Validation(Required=false)]
            public string CallerUid { get; set; }

            /// <summary>
            /// The name of the current step. If this parameter is left empty, the task is not started.
            /// </summary>
            [NameInMap("CurrentStepName")]
            [Validation(Required=false)]
            public string CurrentStepName { get; set; }

            /// <summary>
            /// The database type. The value is fixed to mongodb.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The end time of the performed O\\&M task. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The instance ID
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The instance type of the instance. The value is fixed to Instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The product. The value is fixed to dds.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The current progress of the task. The valid values range from 0 to 100.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// The reason why the current task was initiated.
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// The region ID of the instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The estimated remaining execution time. Unit: seconds. The value 0 indicates that the task is completed.
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// The start time of the performed O\\&M task. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The task status. Valid values:
            /// 
            /// *   Scheduled: The task is waiting to be executed.
            /// *   Running: The task is running.
            /// *   Succeed: The task is successful.
            /// *   Failed: The task failed.
            /// *   Cancelling: The task is being terminated.
            /// *   Canceled: The task has been terminated.
            /// *   Waiting: The task is waiting for scheduled time.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The details of the task. The task details vary based on the value of the taskType parameter.
            /// </summary>
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public string TaskDetail { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The task type.
            /// 
            /// *   CreateIns: Create an instance.
            /// *   DeleteIns: Delete an instance.
            /// *   ChangeVariable: Modify parameter settings for an instance.
            /// *   ModifyInsConfig: Change the configurations of an instance.
            /// *   RestartIns: Restart an instance.
            /// *   HaSwitch: Perform a primary/secondary switchover on an instance.
            /// *   CloneIns: Clone an instance.
            /// *   KernelVersionUpgrade: Update the minor version of an instance.
            /// *   ProxyVersionUpgrade: Upgrade the agent version of an instance.
            /// *   ModifyAccount: Change the account of an instance.
            /// *   ModifyInsSpec: Change the specifications of an instance or perform a data migration on the instance.
            /// *   CreateReadIns: Create a read-only instance.
            /// *   StartIns: Start an instance.
            /// *   StopIns: Stop an instance.
            /// *   ModifyNetwork: Modify the network type for an instance.
            /// *   LockIns: Lock an instance.
            /// *   UnlockIns: Unlock an instance.
            /// *   DiskOnlineExpansion: Scale out the disks of an instance online.
            /// *   StorageOnlineExpansion: Expend the storage capacity of an instance online.
            /// *   AddInsNode: Add a node to an instance.
            /// *   DeleteInsNode: Delete a node from an instance.
            /// *   ManualBackupIns: Manually back up an instance.
            /// *   ModifyInsStorageType: Modify the storage type for an instance.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The ID of the user to which the resource belongs.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of tasks that meet these conditions without taking pagination into account.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
