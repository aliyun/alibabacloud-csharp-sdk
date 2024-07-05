// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ActivateMediaWorkflowResponseBody : TeaModel {
        /// <summary>
        /// The details of the media workflow.
        /// </summary>
        [NameInMap("MediaWorkflow")]
        [Validation(Required=false)]
        public ActivateMediaWorkflowResponseBodyMediaWorkflow MediaWorkflow { get; set; }
        public class ActivateMediaWorkflowResponseBodyMediaWorkflow : TeaModel {
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
            /// The status of the media workflow. The value is **Active**.
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

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
