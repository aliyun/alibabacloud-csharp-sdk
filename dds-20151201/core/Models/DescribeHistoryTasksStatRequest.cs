// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeHistoryTasksStatRequest : TeaModel {
        /// <summary>
        /// <para>The minimum execution duration of the task. This parameter is used to filter tasks whose execution duration is longer than the minimum execution duration. Unit: seconds. The default value is 0, which indicates that no limit is imposed for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// <para>The start time of the O\&amp;M task to perform. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. You can query data within the last 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-16T02:46:21Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The instance ID. Separate multiple instance IDs with commas (,). You can specify up to 30 instance IDs. This parameter is empty by default, which indicates that the tasks of all instances are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-8vb38f0e7933xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the pending event. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

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
        /// <para>Separate multiple states with commas (,). This parameter is empty by default, which indicates that tasks in all states are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID. Separate multiple task IDs with commas (,). You can specify up to 30 task IDs. This parameter is empty by default, which indicates that all tasks are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0mq1yyhm3ffl2bxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type. This parameter is left empty by default, which indicates that all types of tasks are queried. Valid values:</para>
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
        /// <para>DeleteIns</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The maximum execution duration of the task. This parameter is used to filter tasks whose execution duration is shorter than or equal to the maximum execution duration. Unit: seconds. The default value is 0, which indicates that no limit is imposed for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// <para>The end time of the O\&amp;M task to perform. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. You can query data within the last 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-16T02:15:52Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
