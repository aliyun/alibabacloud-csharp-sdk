// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTAFirmwareResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The OTA update package information that is returned if the call is successful. For more information, see the "**Data**" section of this topic.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOTAFirmwareResponseBodyData Data { get; set; }
        public class CreateOTAFirmwareResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the OTA update package. The ID is a unique identifier issued by IoT Platform to the OTA update package.
            /// </summary>
            [NameInMap("FirmwareId")]
            [Validation(Required=false)]
            public string FirmwareId { get; set; }

            /// <summary>
            /// The time when the OTA update package was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful. The value indicates that the OTA update package was created.
        /// *   **false**: The call failed. The value indicates that the system failed to create the OTA update package.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
