// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SearchMediaWorkflowResponseBody : TeaModel {
        /// <summary>
        /// The details of the media workflows.
        /// </summary>
        [NameInMap("MediaWorkflowList")]
        [Validation(Required=false)]
        public SearchMediaWorkflowResponseBodyMediaWorkflowList MediaWorkflowList { get; set; }
        public class SearchMediaWorkflowResponseBodyMediaWorkflowList : TeaModel {
            [NameInMap("MediaWorkflow")]
            [Validation(Required=false)]
            public List<SearchMediaWorkflowResponseBodyMediaWorkflowListMediaWorkflow> MediaWorkflow { get; set; }
            public class SearchMediaWorkflowResponseBodyMediaWorkflowListMediaWorkflow : TeaModel {
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
                /// *   **Inactive**: The media workflow is deactivated.
                /// *   **Active**: The media workflow is activated.
                /// *   **Deleted**: The media workflow is deleted.
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
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
