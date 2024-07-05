// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class DeactivateMediaWorkflowResponseBody : TeaModel {
        /// <summary>
        /// The topology of the media workflow.
        /// </summary>
        [NameInMap("MediaWorkflow")]
        [Validation(Required=false)]
        public DeactivateMediaWorkflowResponseBodyMediaWorkflow MediaWorkflow { get; set; }
        public class DeactivateMediaWorkflowResponseBodyMediaWorkflow : TeaModel {
            /// <summary>
            /// *   After you deactivate a media workflow, you can modify the workflow information.
            /// *   After you delete or deactivate a media workflow, the workflow cannot be used. In this case, the workflow is not automatically triggered when you upload a file to the bucket specified by the workflow.
            /// 
            /// ## Limits on QPS
            /// 
            /// You can call this operation up to 100 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation. For more information, see [QPS limits](https://www.alibabacloud.com/help/en/apsaravideo-for-media-processing/latest/qps-limit).
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the media workflow that you want to deactivate. To obtain the ID of the media workflow, you can log on to the **ApsaraVideo Media Processing (MPS) console** and choose **Workflows** > **Workflow Settings** in the left-side navigation pane.
            /// </summary>
            [NameInMap("MediaWorkflowId")]
            [Validation(Required=false)]
            public string MediaWorkflowId { get; set; }

            /// <summary>
            /// The details of the media workflow.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The topology of the media workflow.The status of the media workflow. The value is **Inactive**.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The status of the media workflow. The value is **Inactive**.
            /// </summary>
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public string Topology { get; set; }

        }

        /// <summary>
        /// The name of the media workflow that is deactivated.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
