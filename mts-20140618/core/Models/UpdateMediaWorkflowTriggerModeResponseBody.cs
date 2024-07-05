// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaWorkflowTriggerModeResponseBody : TeaModel {
        /// <summary>
        /// The information about the media workflow.
        /// </summary>
        [NameInMap("MediaWorkflow")]
        [Validation(Required=false)]
        public UpdateMediaWorkflowTriggerModeResponseBodyMediaWorkflow MediaWorkflow { get; set; }
        public class UpdateMediaWorkflowTriggerModeResponseBodyMediaWorkflow : TeaModel {
            /// <summary>
            /// The time when the media workflow was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the media workflow.
            /// </summary>
            [NameInMap("MediaWorkflowId")]
            [Validation(Required=false)]
            public string MediaWorkflowId { get; set; }

            /// <summary>
            /// The name of the media workflow.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the media workflow. Valid values:
            /// 
            /// *   **Inactive**: The media workflow is disabled.
            /// *   **Active**: The media workflow is enabled.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The topology of the media workflow.
            /// </summary>
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public string Topology { get; set; }

            /// <summary>
            /// The trigger mode of the media workflow. Valid values:
            /// 
            /// *   **OssAutoTrigger**: The media workflow is automatically triggered.
            /// *   **NotInAuto**: The media workflow is not automatically triggered.
            /// </summary>
            [NameInMap("TriggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
