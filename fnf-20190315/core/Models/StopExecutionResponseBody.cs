// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StopExecutionResponseBody : TeaModel {
        /// <summary>
        /// The definition of the flow.
        /// </summary>
        [NameInMap("FlowDefinition")]
        [Validation(Required=false)]
        public string FlowDefinition { get; set; }

        /// <summary>
        /// The name of the flow.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The input of the execution, which is in the JSON format.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// The name of the execution.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The execution result, which is in the JSON format.
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the execution started.
        /// </summary>
        [NameInMap("StartedTime")]
        [Validation(Required=false)]
        public string StartedTime { get; set; }

        /// <summary>
        /// The execution state. Valid values:
        /// 
        /// *   **Running**
        /// *   **Stopped**
        /// *   **Succeeded**
        /// *   **Failed**
        /// *   **TimedOut**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The time when the execution stopped.
        /// </summary>
        [NameInMap("StoppedTime")]
        [Validation(Required=false)]
        public string StoppedTime { get; set; }

    }

}
