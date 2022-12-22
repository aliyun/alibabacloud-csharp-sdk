// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListFlowsResponseBody : TeaModel {
        /// <summary>
        /// A list of workflows.
        /// </summary>
        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<ListFlowsResponseBodyFlows> Flows { get; set; }
        public class ListFlowsResponseBodyFlows : TeaModel {
            /// <summary>
            /// The time when the workflow was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            /// The region to which the workflow belongs.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The template ID. You can call the ListTemplates operation to obtain the template ID.
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

            /// <summary>
            /// The latest version of the workflow.
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of workflows in the current region.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
