// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PrintByTemplateResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The result of the printing operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PrintByTemplateResponseBodyData Data { get; set; }
        public class PrintByTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// The error code returned by the printer. Valid values:
            /// 
            /// *   2: The printer ran out of paper.
            /// *   3: A paper jam occurred in the printer.
            /// </summary>
            [NameInMap("DeviceErrorCode")]
            [Validation(Required=false)]
            public string DeviceErrorCode { get; set; }

            /// <summary>
            /// The error message returned by the printer.
            /// </summary>
            [NameInMap("DeviceErrorMessage")]
            [Validation(Required=false)]
            public string DeviceErrorMessage { get; set; }

            /// <summary>
            /// The ID of the printing operation.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The maximum number of retries. The value is fixed at 2, which indicates that up to two printing retries are supported.
            /// 
            /// If the printer responds to the printing command with a failure or timeout error, IoT Platform delivers the printing command to the printer.
            /// </summary>
            [NameInMap("MaxRetryCount")]
            [Validation(Required=false)]
            public int? MaxRetryCount { get; set; }

            /// <summary>
            /// The actual number of retries.
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public int? RetryCount { get; set; }

            /// <summary>
            /// Indicates whether the printing operation was successful.
            /// 
            /// *   **true**: The printing operation was successful.
            /// *   **false**: The printing operation failed.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
