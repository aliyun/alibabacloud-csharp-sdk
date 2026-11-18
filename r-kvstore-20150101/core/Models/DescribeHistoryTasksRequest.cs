// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryTasksRequest : TeaModel {
        /// <summary>
        /// <para>The minimum execution duration of the tasks. This parameter is used to filter tasks whose execution duration is greater than the specified value. Unit: seconds. Default value: 0, which means no limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// <para>The earliest start time of the tasks to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. You can query data from up to 30 days ago.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance, which is used to query tasks of the specified instance. By default, this parameter is empty, which means no limit is applied. To query multiple instances, separate the instance IDs with commas (,). You can specify up to 30 instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-uf62br2491p5l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type. Set the value to Instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The page number of the query result. Valid values: positive integers. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the pending events belong. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public long? ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The task status, which is used to filter tasks by status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Scheduled</b>: Pending execution.</description></item>
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Succeed</b>: Succeeded.</description></item>
        /// <item><description><b>Failed</b>: Failed.</description></item>
        /// <item><description><b>Cancelling</b>: Cancelling.</description></item>
        /// <item><description><b>Canceled</b>: Canceled.</description></item>
        /// <item><description><b>Waiting</b>: Waiting for the scheduled time.
        /// By default, this parameter is empty, which means all statuses are selected. To specify multiple statuses, separate them with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the task, which is used to query tasks with known IDs. By default, this parameter is empty, which means no limit is applied. To query multiple tasks, separate the task IDs with commas (,). You can specify up to 30 task IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-83br18hloy3faf****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type, which is used to query tasks of a specific type. By default, this parameter is empty, which means no limit is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ModifyInsSpec</b>: Instance specification change or migration.</description></item>
        /// <item><description><b>DeleteInsNode</b>: Shard deletion.</description></item>
        /// <item><description><b>AddInsNode</b>: Shard addition.</description></item>
        /// <item><description><b>HaSwitch</b>: Primary/secondary switchover.</description></item>
        /// <item><description><b>RestartIns</b>: Instance restart.</description></item>
        /// <item><description><b>CreateIns</b>: Instance creation.</description></item>
        /// <item><description><b>ModifyInsConfig</b>: Configuration change.
        /// To query multiple task types, separate them with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ModifyInsSpec</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The maximum execution duration of the tasks. This parameter is used to filter tasks whose execution duration is not less than the specified value. Unit: seconds. Default value: 0, which means no limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// <para>The latest start time of the tasks to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The time must be later than the earliest start time of the tasks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
