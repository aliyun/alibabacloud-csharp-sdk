// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class BackFillShrinkRequest : TeaModel {
        /// <summary>
        /// The running sequence of task flows for data backfill. Valid values:
        /// 
        /// *   **0**: reverse chronological order.
        /// *   **1**: chronological order. This is the default value.
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// The date for the data to be backfilled. This parameter is required if you specify a date for data backfill.
        /// </summary>
        [NameInMap("BackFillDate")]
        [Validation(Required=false)]
        public string BackFillDate { get; set; }

        /// <summary>
        /// The start date of the date range for the data to be backfilled. This parameter is required if you specify a date range for data backfill.
        /// </summary>
        [NameInMap("BackFillDateBegin")]
        [Validation(Required=false)]
        public string BackFillDateBegin { get; set; }

        /// <summary>
        /// The end date of the date range for the data to be backfilled. This parameter is required if you specify a date range for data backfill.
        /// </summary>
        [NameInMap("BackFillDateEnd")]
        [Validation(Required=false)]
        public string BackFillDateEnd { get; set; }

        /// <summary>
        /// The ID of the task flow. You can call the [ListTaskFlow](https://help.aliyun.com/document_detail/424565.html) or [ListLhTaskFlowAndScenario](https://help.aliyun.com/document_detail/426672.html) operation to query the task flow ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// Filter condition, which specifies the list of node IDs in the task flow that do not need to supplement data.
        /// </summary>
        [NameInMap("FilterNodeIds")]
        [Validation(Required=false)]
        public string FilterNodeIdsShrink { get; set; }

        /// <summary>
        /// The ID of the historical task flow.
        /// </summary>
        [NameInMap("HistoryDagId")]
        [Validation(Required=false)]
        public long? HistoryDagId { get; set; }

        /// <summary>
        /// The interval at which data backfill is performed. Unit: hours. Minimum value: 1. Default value: 24.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// Specifies whether to run descendant nodes. Default value: true.
        /// </summary>
        [NameInMap("IsTriggerSubTree")]
        [Validation(Required=false)]
        public bool? IsTriggerSubTree { get; set; }

        /// <summary>
        /// The number of nodes for which you want to backfill data.
        /// </summary>
        [NameInMap("StartNodeIds")]
        [Validation(Required=false)]
        public string StartNodeIdsShrink { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](https://help.aliyun.com/document_detail/181330.html).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
