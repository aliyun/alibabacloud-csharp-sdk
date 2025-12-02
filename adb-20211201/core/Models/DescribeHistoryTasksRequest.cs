// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeHistoryTasksRequest : TeaModel {
        /// <summary>
        /// <para>Minimum task execution time. Used to filter tasks with execution time greater than this value, in seconds. Default 0, meaning no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// <para>Start time of task start time, indicating querying tasks whose start time is after this time. Expressed according to ISO8601 standard, and must use UTC +0 time, format: yyyy-MM-ddTHH:mm:ssZ. Earliest supports 30 days ago, automatically converts to 30 days ago if more than 30 days from current time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The cluster ID. Separate multiple cluster IDs with commas (,). Maximum 30 cluster IDs. If not filled, defaults to querying historical tasks of all clusters in that region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type. The value is fixed to Instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Valid range: positive integers. Default value: 1</para>
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
        /// <para>The region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The state of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Scheduled</b></description></item>
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Succeed</b></description></item>
        /// <item><description><b>Failed</b>: The task failed.</description></item>
        /// <item><description><b>Cancelling</b></description></item>
        /// <item><description><b>Canceled</b></description></item>
        /// <item><description><b>Waiting</b></description></item>
        /// </list>
        /// <para>If querying multiple statuses, separate them with English commas. Default is empty, meaning select all.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The job IDs. Separate multiple task IDs with commas (,). Maximum 30 task IDs. If not filled, defaults to querying historical tasks of all clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-83br18hloy3faf****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Task type, used to query specific type task situations. If multiple, separate with English commas (,), maximum 30 supported. Default is empty, meaning no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest_dispatch_cases</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>Maximum task execution time. Used to filter tasks with execution time not less than this value, in seconds. Default 0, meaning no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// <para>End time of task start time, indicating querying tasks whose start time is before this time. Expressed according to ISO8601 standard, and must use UTC +0 time, format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
