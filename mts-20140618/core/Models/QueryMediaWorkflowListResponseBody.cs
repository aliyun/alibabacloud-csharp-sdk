// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaWorkflowListResponseBody : TeaModel {
        /// <summary>
        /// The media workflows.
        /// </summary>
        [NameInMap("MediaWorkflowList")]
        [Validation(Required=false)]
        public QueryMediaWorkflowListResponseBodyMediaWorkflowList MediaWorkflowList { get; set; }
        public class QueryMediaWorkflowListResponseBodyMediaWorkflowList : TeaModel {
            [NameInMap("MediaWorkflow")]
            [Validation(Required=false)]
            public List<QueryMediaWorkflowListResponseBodyMediaWorkflowListMediaWorkflow> MediaWorkflow { get; set; }
            public class QueryMediaWorkflowListResponseBodyMediaWorkflowListMediaWorkflow : TeaModel {
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
                /// The state of the media workflow. Valid values:
                /// 
                /// *   **Inactive**: The media workflow was deactivated.
                /// *   **Active**: The media workflow was activated.
                /// *   **Deleted**: The media workflow was deleted.
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

        }

        /// <summary>
        /// The workflows that do not exist.
        /// </summary>
        [NameInMap("NonExistMediaWorkflowIds")]
        [Validation(Required=false)]
        public QueryMediaWorkflowListResponseBodyNonExistMediaWorkflowIds NonExistMediaWorkflowIds { get; set; }
        public class QueryMediaWorkflowListResponseBodyNonExistMediaWorkflowIds : TeaModel {
            [NameInMap("MediaWorkflowId")]
            [Validation(Required=false)]
            public List<string> MediaWorkflowId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
