// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeHistoryTasksStatRequest : TeaModel {
        /// <summary>
        /// The minimum execution duration of the task. This parameter is used to filter tasks whose execution duration is longer than the minimum execution duration. Unit: seconds. The default value is 0, which indicates that no limit is imposed for the query.
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// The start time of the O\\&M task to perform. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. You can query data within the last 30 days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// The instance ID. Separate multiple instance IDs with commas (,). You can specify up to 30 instance IDs. This parameter is empty by default, which indicates that the tasks of all instances are queried.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the pending event. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61933.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

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
        /// 
        /// Separate multiple states with commas (,). This parameter is empty by default, which indicates that tasks in all states are queried.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The task ID. Separate multiple task IDs with commas (,). You can specify up to 30 task IDs. This parameter is empty by default, which indicates that all tasks are queried.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The task type. This parameter is left empty by default, which indicates that all types of tasks are queried. Valid values:
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
        /// The maximum execution duration of the task. This parameter is used to filter tasks whose execution duration is shorter than or equal to the maximum execution duration. Unit: seconds. The default value is 0, which indicates that no limit is imposed for the query.
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// The end time of the O\\&M task to perform. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. You can query data within the last 30 days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
