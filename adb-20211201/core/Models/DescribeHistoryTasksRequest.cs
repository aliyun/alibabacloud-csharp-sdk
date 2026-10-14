// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeHistoryTasksRequest : TeaModel {
        /// <summary>
        /// <para>The minimum execution duration of the task. This parameter is used to filter tasks whose execution duration is greater than this value. Unit: seconds. Default value: 0, which indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// <para>The start time of the time range to query task start times. Tasks that start after this time are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The earliest supported time is 30 days ago. If the specified time is more than 30 days before the current time, it is automatically changed to 30 days ago.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The cluster ID. You can specify multiple cluster IDs separated by commas (,). You can specify up to 30 cluster IDs. If this parameter is left empty, historical tasks of all clusters in the region are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-********</para>
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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Scheduled</b>: Pending execution.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: Running.</para>
        /// </description></item>
        /// <item><description><para><b>Succeed</b>: Succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>Failed</b>: Failed.</para>
        /// </description></item>
        /// <item><description><para><b>Cancelling</b>: Being canceled.</para>
        /// </description></item>
        /// <item><description><para><b>Canceled</b>: Canceled.</para>
        /// </description></item>
        /// <item><description><para><b>Waiting</b>: Waiting for the scheduled time.</para>
        /// </description></item>
        /// </list>
        /// <para>You can specify multiple values separated by commas (,). If this parameter is left empty, all statuses are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID. You can specify multiple task IDs separated by commas (,). You can specify up to 30 task IDs. If this parameter is left empty, historical tasks of all clusters are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-83br18hloy3faf****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type. This parameter is used to query tasks of a specific type. You can specify multiple task types separated by commas (,). You can specify up to 30 task types. If this parameter is left empty, no limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest_dispatch_cases</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The maximum execution duration of the task. This parameter is used to filter tasks whose execution duration does not exceed this value. Unit: seconds. Default value: 0, which indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// <para>The end time of the time range to query task start times. Tasks that start before this time are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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
