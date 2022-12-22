// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GetFlowResponseBody : TeaModel {
        /// <summary>
        /// The time when the workflow was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The version ID of the workflow.
        /// </summary>
        [NameInMap("CurrentVersionId")]
        [Validation(Required=false)]
        public string CurrentVersionId { get; set; }

        /// <summary>
        /// The definition of the workflow.
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The description of the workflow.
        /// </summary>
        [NameInMap("FlowDescription")]
        [Validation(Required=false)]
        public string FlowDescription { get; set; }

        /// <summary>
        /// The edit mode of the workflow.
        /// </summary>
        [NameInMap("FlowEditMode")]
        [Validation(Required=false)]
        public string FlowEditMode { get; set; }

        /// <summary>
        /// The ID of the workflow.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The source of the workflow.
        /// </summary>
        [NameInMap("FlowSource")]
        [Validation(Required=false)]
        public string FlowSource { get; set; }

        /// <summary>
        /// The status of the workflow. Valid values:
        /// 
        /// *   **Enabled**: The workflow is enabled.
        /// *   **Disabled**: The workflow is disabled.
        /// </summary>
        [NameInMap("FlowStatus")]
        [Validation(Required=false)]
        public string FlowStatus { get; set; }

        /// <summary>
        /// The ID of the region where the workflow resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The template ID.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The time when the workflow was last updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
