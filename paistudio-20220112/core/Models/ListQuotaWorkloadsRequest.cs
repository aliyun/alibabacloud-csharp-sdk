// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotaWorkloadsRequest : TeaModel {
        /// <summary>
        /// <para>Queries the queuing information for instances before a specified workload ID in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsw654433**</para>
        /// </summary>
        [NameInMap("BeforeWorkloadId")]
        [Validation(Required=false)]
        public string BeforeWorkloadId { get; set; }

        /// <summary>
        /// <para>The range search for workload dequeue time.</para>
        /// </summary>
        [NameInMap("GmtDequeuedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtDequeuedTimeRange { get; set; }

        /// <summary>
        /// <para>The range search for workload enqueue time.</para>
        /// </summary>
        [NameInMap("GmtEnqueuedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtEnqueuedTimeRange { get; set; }

        /// <summary>
        /// <para>The range search for workload queue position change time.</para>
        /// </summary>
        [NameInMap("GmtPositionModifiedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtPositionModifiedTimeRange { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Searches only for nodes on the specified node.</para>
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
        /// <para>The page number of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
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
        /// <para>Specifies whether to display only the workloads associated with the current resource quota.</para>
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
        /// <para>The status in the queue.</para>
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

        [NameInMap("UseOversoldResource")]
        [Validation(Required=false)]
        public bool? UseOversoldResource { get; set; }

        /// <summary>
        /// <para>The list of user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>290438938**,238290930**</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

        [NameInMap("WithHistoricalData")]
        [Validation(Required=false)]
        public bool? WithHistoricalData { get; set; }

        /// <summary>
        /// <para>The range search for workload creation time.</para>
        /// </summary>
        [NameInMap("WorkloadCreatedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter WorkloadCreatedTimeRange { get; set; }

        /// <summary>
        /// <para>Queries the queuing information for specified workload IDs.</para>
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
        /// <para>Filters by workload status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("WorkloadStatuses")]
        [Validation(Required=false)]
        public string WorkloadStatuses { get; set; }

        /// <summary>
        /// <para>Queries the queuing information for instances of a specified sub-product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// <para>Queries the queuing information for workloads in a specified workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1866**</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
