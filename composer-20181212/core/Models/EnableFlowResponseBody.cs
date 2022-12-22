// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class EnableFlowResponseBody : TeaModel {
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the operation was successful. Valid values:
        /// 
        /// *   **true**: The operation was successful.
        /// *   **false**: The operation failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
