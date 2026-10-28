// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotaWorkloadsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the workload before which to query the queue information of instances in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsw654433**</para>
        /// </summary>
        [NameInMap("BeforeWorkloadId")]
        [Validation(Required=false)]
        public string BeforeWorkloadId { get; set; }

        /// <summary>
        /// <para>The time range used for a range search on the time when the workloads were dequeued.</para>
        /// </summary>
        [NameInMap("GmtDequeuedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtDequeuedTimeRange { get; set; }

        /// <summary>
        /// <para>The time range used for a range search on the time when the workloads entered the queue.</para>
        /// </summary>
        [NameInMap("GmtEnqueuedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtEnqueuedTimeRange { get; set; }

        /// <summary>
        /// <para>The time range used for a range search on the time when the queue positions of the workloads changed.</para>
        /// </summary>
        [NameInMap("GmtPositionModifiedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtPositionModifiedTimeRange { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>train129f212o89d-master-0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the node on which to search for workloads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lrn482781276**</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The position in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

        /// <summary>
        /// <para>The priority of the workload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Specifies whether to display only the workloads corresponding to this resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowOwn")]
        [Validation(Required=false)]
        public bool? ShowOwn { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreatedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The status of the workload in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enqueued</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of sub-resource quota IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota123446**,quota644322**</para>
        /// </summary>
        [NameInMap("SubQuotaIds")]
        [Validation(Required=false)]
        public string SubQuotaIds { get; set; }

        /// <summary>
        /// <para>Specifies whether the workload uses oversold resources.</para>
        /// </summary>
        [NameInMap("UseOversoldResource")]
        [Validation(Required=false)]
        public bool? UseOversoldResource { get; set; }

        /// <summary>
        /// <para>The IDs of the users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>290438938**,238290930**</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to include historical data.</para>
        /// </summary>
        [NameInMap("WithHistoricalData")]
        [Validation(Required=false)]
        public bool? WithHistoricalData { get; set; }

        /// <summary>
        /// <para>The time range used for a range search on the workload creation time.</para>
        /// </summary>
        [NameInMap("WorkloadCreatedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter WorkloadCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>The IDs of the workloads to query for queue information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc123445**</para>
        /// </summary>
        [NameInMap("WorkloadIds")]
        [Validation(Required=false)]
        public string WorkloadIds { get; set; }

        /// <summary>
        /// <para>The names of the workloads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlcxxxx</para>
        /// </summary>
        [NameInMap("WorkloadNames")]
        [Validation(Required=false)]
        public string WorkloadNames { get; set; }

        /// <summary>
        /// <para>The workload statuses used to filter the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("WorkloadStatuses")]
        [Validation(Required=false)]
        public string WorkloadStatuses { get; set; }

        /// <summary>
        /// <para>The workload type used to query the queue information of instances for the specified sub-product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// <para>The IDs of the workspaces for which to query the workload queue information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1866**</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
