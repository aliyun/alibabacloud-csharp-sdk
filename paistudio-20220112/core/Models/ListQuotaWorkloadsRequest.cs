// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotaWorkloadsRequest : TeaModel {
        /// <summary>
        /// <para>Retrieves workloads that precede the specified workload ID in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsw654433**</para>
        /// </summary>
        [NameInMap("BeforeWorkloadId")]
        [Validation(Required=false)]
        public string BeforeWorkloadId { get; set; }

        /// <summary>
        /// <para>Filters workloads by their dequeue time range.</para>
        /// </summary>
        [NameInMap("GmtDequeuedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtDequeuedTimeRange { get; set; }

        /// <summary>
        /// <para>Filters workloads by their enqueue time range.</para>
        /// </summary>
        [NameInMap("GmtEnqueuedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtEnqueuedTimeRange { get; set; }

        /// <summary>
        /// <para>Filters workloads by the time range of their last queue position change.</para>
        /// </summary>
        [NameInMap("GmtPositionModifiedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtPositionModifiedTimeRange { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Filters workloads by node name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lrn482781276**</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The sort order for the results. Valid values are <c>asc</c> for ascending and <c>desc</c> for descending.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on a single page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only workloads that belong to the specified quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowOwn")]
        [Validation(Required=false)]
        public bool? ShowOwn { get; set; }

        /// <summary>
        /// <para>The field to use for sorting the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreatedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Filters workloads by their status in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enqueued</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters workloads by sub-quota ID. You can specify multiple IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota123446**,quota644322**</para>
        /// </summary>
        [NameInMap("SubQuotaIds")]
        [Validation(Required=false)]
        public string SubQuotaIds { get; set; }

        [NameInMap("UseOversoldResource")]
        [Validation(Required=false)]
        public bool? UseOversoldResource { get; set; }

        /// <summary>
        /// <para>Filters workloads by user ID. You can specify multiple IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>290438938**,238290930**</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to include historical data in the query results.</para>
        /// </summary>
        [NameInMap("WithHistoricalData")]
        [Validation(Required=false)]
        public bool? WithHistoricalData { get; set; }

        /// <summary>
        /// <para>Filters workloads based on their creation time range.</para>
        /// </summary>
        [NameInMap("WorkloadCreatedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter WorkloadCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>Filters workloads by workload ID. You can specify multiple IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc123445**</para>
        /// </summary>
        [NameInMap("WorkloadIds")]
        [Validation(Required=false)]
        public string WorkloadIds { get; set; }

        [NameInMap("WorkloadNames")]
        [Validation(Required=false)]
        public string WorkloadNames { get; set; }

        /// <summary>
        /// <para>Filters workloads by status. You can specify multiple statuses, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("WorkloadStatuses")]
        [Validation(Required=false)]
        public string WorkloadStatuses { get; set; }

        /// <summary>
        /// <para>Filters workloads by the sub-product type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// <para>Filters workloads by workspace ID. You can specify multiple IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1866**</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
