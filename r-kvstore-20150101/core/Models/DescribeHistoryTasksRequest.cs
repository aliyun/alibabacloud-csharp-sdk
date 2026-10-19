// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryTasksRequest : TeaModel {
        /// <summary>
        /// <para>The minimum execution duration. This parameter is used to filter tasks whose execution duration is greater than the specified value. Unit: seconds. Default value: 0, which indicates no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// <para>The earliest start time for querying tasks. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC). You can query data from up to 30 days ago.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is used to query tasks for the specified instance. The default value is empty, which indicates no restriction. To specify multiple instances, separate them with commas (,). A maximum of 30 instances are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-uf62br2491p5l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Currently fixed as Instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The page number of the query results. Valid values: positive integers. Default value: 1.</para>
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
        /// <para>The region ID of the pending event. You can call <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> to query the region ID.</para>
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
        /// <para>The task status. This parameter is used to filter tasks by status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Scheduled</b>: Waiting for execution.</description></item>
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Succeed</b>: Succeeded.</description></item>
        /// <item><description><b>Failed</b>: Failed.</description></item>
        /// <item><description><b>Cancelling</b>: Being stopped.</description></item>
        /// <item><description><b>Canceled</b>: Stopped.</description></item>
        /// <item><description><b>Waiting</b>: Waiting for the scheduled time.<remarks>
        /// <para>The default value is empty, which indicates all statuses. To specify multiple statuses, separate them with commas (,).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID. This parameter is used to query tasks with known IDs. The default value is empty, which indicates no restriction. To specify multiple task IDs, separate them with commas (,). A maximum of 30 task IDs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-83br18hloy3faf****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type. This parameter is used to query tasks of a specific type. The default value is empty, which indicates no restriction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ModifyInsSpec</b>: Specification change or migration.</description></item>
        /// <item><description><b>DeleteInsNode</b>: Shard deletion.</description></item>
        /// <item><description><b>AddInsNode</b>: Shard addition.</description></item>
        /// <item><description><b>HaSwitch</b>: Primary/secondary switchover.</description></item>
        /// <item><description><b>RestartIns</b>: Instance restart.</description></item>
        /// <item><description><b>CreateIns</b>: Instance creation.</description></item>
        /// <item><description><b>ModifyInsConfig</b>: Configuration change.<remarks>
        /// <para>To specify multiple task types, separate them with commas (,).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ModifyInsSpec</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The maximum execution duration. This parameter is used to filter tasks whose execution duration is not less than the specified value. Unit: seconds. Default value: 0, which indicates no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// <para>The latest start time for querying tasks. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC). The value must be later than the earliest start time of the task.</para>
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
