// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotaWorkloadsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dsw65443322</para>
        /// </summary>
        [NameInMap("BeforeWorkloadId")]
        [Validation(Required=false)]
        public string BeforeWorkloadId { get; set; }

        [NameInMap("GmtDequeuedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtDequeuedTimeRange { get; set; }

        [NameInMap("GmtEnqueuedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtEnqueuedTimeRange { get; set; }

        [NameInMap("GmtPositionModifiedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter GmtPositionModifiedTimeRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lrn48278127617</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowOwn")]
        [Validation(Required=false)]
        public bool? ShowOwn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GmtCreatedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enqueued</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>quota12344666,quota64432233</para>
        /// </summary>
        [NameInMap("SubQuotaIds")]
        [Validation(Required=false)]
        public string SubQuotaIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>29043893812,23829093093</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

        [NameInMap("WithHistoricalData")]
        [Validation(Required=false)]
        public bool? WithHistoricalData { get; set; }

        [NameInMap("WorkloadCreatedTimeRange")]
        [Validation(Required=false)]
        public TimeRangeFilter WorkloadCreatedTimeRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc12344556</para>
        /// </summary>
        [NameInMap("WorkloadIds")]
        [Validation(Required=false)]
        public string WorkloadIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("WorkloadStatuses")]
        [Validation(Required=false)]
        public string WorkloadStatuses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>186692</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
