// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ExecuteWorkflowResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// If the call is successful, the ID of the workflow instance is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteWorkflowResponseBodyData Data { get; set; }
        public class ExecuteWorkflowResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the workflow instance.
            /// </summary>
            [NameInMap("WfInstanceId")]
            [Validation(Required=false)]
            public long? WfInstanceId { get; set; }

        }

        /// <summary>
        /// The error message that is returned only if the error occurs.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the API call is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
