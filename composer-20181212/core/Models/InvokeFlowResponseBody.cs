// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class InvokeFlowResponseBody : TeaModel {
        /// <summary>
        /// The unique identifier of the execution.
        /// </summary>
        [NameInMap("InvocationId")]
        [Validation(Required=false)]
        public string InvocationId { get; set; }

        /// <summary>
        /// The ID for this request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the workflow execution was triggered.
        /// 
        /// *   **true**: The workflow execution was triggered
        /// *   **false**: The workflow execution failed to be triggered.
        /// 
        /// > : You can call the **GetInvocationLog** operation to check whether the workflow execution is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
