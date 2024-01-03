// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetExecuteOperationResultResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. A value of 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The detailed result of the queried operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetExecuteOperationResultResponseBodyData Data { get; set; }
        public class GetExecuteOperationResultResponseBodyData : TeaModel {
            /// <summary>
            /// The output of the operation.
            /// </summary>
            [NameInMap("Arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }

            /// <summary>
            /// The returned message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the operation.
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// The status of the operation.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The error message.
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

    }

}
