// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ReBindLicenseDeviceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The result of the batch rebinding operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReBindLicenseDeviceResponseBodyData Data { get; set; }
        public class ReBindLicenseDeviceResponseBodyData : TeaModel {
            /// <summary>
            /// The unique ID that can be used to query the progress of the batch rebinding operation.
            /// </summary>
            [NameInMap("CheckProgressId")]
            [Validation(Required=false)]
            public string CheckProgressId { get; set; }

            /// <summary>
            /// The number of devices that failed to be rebound to the license.
            /// </summary>
            [NameInMap("FailSum")]
            [Validation(Required=false)]
            public long? FailSum { get; set; }

            /// <summary>
            /// The progress of the batch rebinding operation. The progress is a percentage. Valid values: 1 to 100.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The URL of the file that contains unbound devices. The devices failed to be rebound with the license.
            /// </summary>
            [NameInMap("ResultCsvFile")]
            [Validation(Required=false)]
            public string ResultCsvFile { get; set; }

            /// <summary>
            /// The number of devices to which the license is rebound.
            /// </summary>
            [NameInMap("SuccessSum")]
            [Validation(Required=false)]
            public long? SuccessSum { get; set; }

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
