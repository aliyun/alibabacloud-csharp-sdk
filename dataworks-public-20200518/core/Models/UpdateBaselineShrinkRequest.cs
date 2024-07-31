// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateBaselineShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the alerting feature. Valid values: true and false.
        /// </summary>
        [NameInMap("AlertEnabled")]
        [Validation(Required=false)]
        public bool? AlertEnabled { get; set; }

        /// <summary>
        /// The alert margin threshold of the baseline. Unit: minutes.
        /// </summary>
        [NameInMap("AlertMarginThreshold")]
        [Validation(Required=false)]
        public int? AlertMarginThreshold { get; set; }

        /// <summary>
        /// The alert settings of the baseline.
        /// </summary>
        [NameInMap("AlertSettings")]
        [Validation(Required=false)]
        public string AlertSettingsShrink { get; set; }

        /// <summary>
        /// The baseline ID. You can call the [ListBaselines](https://help.aliyun.com/document_detail/2261507.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        /// <summary>
        /// The name of the baseline.
        /// </summary>
        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        /// <summary>
        /// The type of the baseline. Valid values: DAILY and HOURLY.
        /// </summary>
        [NameInMap("BaselineType")]
        [Validation(Required=false)]
        public string BaselineType { get; set; }

        /// <summary>
        /// Specifies whether to enable the baseline. Valid values: true and false.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The ancestor nodes of nodes in the baseline. Separate the ancestor nodes with commas (,). If a large number of ancestor nodes exist, we recommend that you create a zero load node and configure the zero load node as the descendant node of nodes in the baseline to facilitate node management.
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// The settings of the committed completion time of the baseline.
        /// </summary>
        [NameInMap("OvertimeSettings")]
        [Validation(Required=false)]
        public string OvertimeSettingsShrink { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account used by the baseline owner.
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The priority of the baseline. Valid values: {1,3,5,7,8}.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The workspace ID. You can call the [ListBaselines](https://help.aliyun.com/document_detail/2261507.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The ID of the node that you want to disassociate from the baseline. You can specify multiple node IDs. Separate multiple node IDs with commas (,).
        /// </summary>
        [NameInMap("RemoveNodeIds")]
        [Validation(Required=false)]
        public string RemoveNodeIds { get; set; }

    }

}
