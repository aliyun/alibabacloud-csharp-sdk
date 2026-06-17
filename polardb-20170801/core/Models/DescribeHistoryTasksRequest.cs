// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHistoryTasksRequest : TeaModel {
        /// <summary>
        /// <para>The minimum task execution time in seconds. Filters for tasks that took longer than this value. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromExecTime")]
        [Validation(Required=false)]
        public int? FromExecTime { get; set; }

        /// <summary>
        /// <para>The start of the time range to query, based on task start time. The time follows the ISO8601 standard and must be in <c>UTC+0</c> time. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <para>The earliest supported time is 30 days ago. If the specified time is more than 30 days ago, it will be automatically converted to 30 days ago.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The resource ID to filter by. You can provide a comma-separated list of up to 30 IDs. Default value: empty, indicating no restriction.</para>
        /// <remarks>
        /// <para>Currently, only PolarDB cluster IDs are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zed3m89cw***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Currently, only Instance is supported.</para>
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
        /// <para>The page number. Valid values: positive integers. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a>.</para>
        /// </remarks>
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
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Scheduled</b>: waiting for execution</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: executing</para>
        /// </description></item>
        /// <item><description><para><b>Succeed</b>: executed successfully</para>
        /// </description></item>
        /// <item><description><para><b>Cancelling</b>: stopping</para>
        /// </description></item>
        /// <item><description><para><b>Canceled</b>: stopped</para>
        /// </description></item>
        /// <item><description><para><b>Waiting</b>: waiting for preset time</para>
        /// </description></item>
        /// </list>
        /// <para>You can provide a comma-separated list. Default value: empty, which indicates all statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID. You can provide a comma-separated list of up to 30 IDs. Default value: empty, indicating no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0mqi38ho0cgjv***</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type. You can provide a comma-separated list of up to 30 task types. Default value: empty, indicating no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChangeVariable</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The maximum task execution time in seconds. Filters for tasks that took less than this value. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ToExecTime")]
        [Validation(Required=false)]
        public int? ToExecTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query, based on task start time. The time follows the ISO8601 standard and must be in <c>UTC+0</c> time. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-03T11:31:03Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
