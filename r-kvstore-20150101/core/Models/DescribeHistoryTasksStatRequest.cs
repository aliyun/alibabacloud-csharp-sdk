// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryTasksStatRequest : TeaModel {
        /// <summary>
        /// <para>The minimum execution duration used to filter tasks whose execution duration is greater than this value. Unit: seconds. Default value: 0, which indicates no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// <para>The beginning of the query time range. Specify the time in the <i>yyyy-mm-dd</i>t<i>hh:mm</i>z format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

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
        /// <para>The region ID of the pending event. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The task status. This parameter is used to filter tasks by status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Scheduled</b>: Waiting to be executed.</description></item>
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Succeed</b>: Succeeded.</description></item>
        /// <item><description><b>Failed</b>: Failed.</description></item>
        /// <item><description><b>Cancelling</b>: Being stopped.</description></item>
        /// <item><description><b>Canceled</b>: Stopped.</description></item>
        /// <item><description><b>Waiting</b>: Waiting for the scheduled time.<remarks>
        /// <para>By default, this parameter is empty, which indicates that tasks in all statuses are queried. To specify multiple statuses, separate them with commas (,).</para>
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
        /// <para>The task ID. This parameter is used to query a task with a known ID. By default, this parameter is empty, which indicates no restriction. To specify multiple task IDs, separate them with commas (,). A maximum of 30 task IDs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0mq1yyhm3ffl2bxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The maximum execution duration used to filter tasks whose execution duration is not less than this value. Unit: seconds. Default value: 0, which indicates no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// <para>The end of the query time range. Specify the time in the <i>yyyy-mm-dd</i>t<i>hh:mm</i>z format (UTC).</para>
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
