// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryOTAFirmwareResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The update package information returned if the call succeeds. For more information, see **FirmwareInfo**.
        /// </summary>
        [NameInMap("FirmwareInfo")]
        [Validation(Required=false)]
        public QueryOTAFirmwareResponseBodyFirmwareInfo FirmwareInfo { get; set; }
        public class QueryOTAFirmwareResponseBodyFirmwareInfo : TeaModel {
            /// <summary>
            /// The version number of the OTA update package.
            /// </summary>
            [NameInMap("DestVersion")]
            [Validation(Required=false)]
            public string DestVersion { get; set; }

            /// <summary>
            /// The description of the OTA update package.
            /// </summary>
            [NameInMap("FirmwareDesc")]
            [Validation(Required=false)]
            public string FirmwareDesc { get; set; }

            /// <summary>
            /// The unique ID of the OTA update package.
            /// </summary>
            [NameInMap("FirmwareId")]
            [Validation(Required=false)]
            public string FirmwareId { get; set; }

            /// <summary>
            /// The name of the OTA update package.
            /// </summary>
            [NameInMap("FirmwareName")]
            [Validation(Required=false)]
            public string FirmwareName { get; set; }

            /// <summary>
            /// The signature of the OTA update package.
            /// 
            /// >  This parameter is available if the OTA update package contains a single file.
            /// </summary>
            [NameInMap("FirmwareSign")]
            [Validation(Required=false)]
            public string FirmwareSign { get; set; }

            /// <summary>
            /// The size of the OTA update package file. Unit: bytes.
            /// 
            /// >  This parameter is available if the OTA update package contains a single file.
            /// </summary>
            [NameInMap("FirmwareSize")]
            [Validation(Required=false)]
            public int? FirmwareSize { get; set; }

            /// <summary>
            /// The URL of the update package file that is stored in Object Storage Service (OSS).
            /// 
            /// >  This parameter is available if the OTA update package contains a single file.
            /// </summary>
            [NameInMap("FirmwareUrl")]
            [Validation(Required=false)]
            public string FirmwareUrl { get; set; }

            /// <summary>
            /// The name of the module.
            /// 
            /// OTA updates are based on the firmware modules of a device. For more information, see [Add a custom OTA module to an update package](~~202664~~).
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// The information about the OTA update package files. This parameter is available if the OTA update package contains multiple files.
            /// </summary>
            [NameInMap("MultiFiles")]
            [Validation(Required=false)]
            public List<QueryOTAFirmwareResponseBodyFirmwareInfoMultiFiles> MultiFiles { get; set; }
            public class QueryOTAFirmwareResponseBodyFirmwareInfoMultiFiles : TeaModel {
                /// <summary>
                /// The MD5 value of the OTA update package file.
                /// </summary>
                [NameInMap("FileMd5")]
                [Validation(Required=false)]
                public string FileMd5 { get; set; }

                /// <summary>
                /// The name of the OTA update package file.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The signature of the OTA update package file.
                /// </summary>
                [NameInMap("SignValue")]
                [Validation(Required=false)]
                public string SignValue { get; set; }

                /// <summary>
                /// The size of the OTA update package file. Unit: bytes.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The URL of the update package file that is stored in Object Storage Service (OSS).
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// The **ProductKey** of the product to which the OTA update package belongs.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// The name of the product to which the OTA update package belongs.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// The signature method of the OTA update package.
            /// </summary>
            [NameInMap("SignMethod")]
            [Validation(Required=false)]
            public string SignMethod { get; set; }

            /// <summary>
            /// The version number of the original update package to be updated.
            /// 
            /// >  This parameter is returned if you perform a delta update. For more information about update package types, see the description of the **Type** parameter.
            /// </summary>
            [NameInMap("SrcVersion")]
            [Validation(Required=false)]
            public string SrcVersion { get; set; }

            /// <summary>
            /// The status of the OTA update package. Valid values:
            /// 
            /// *   **-1**: no verification is required
            /// *   **0**: unverified
            /// *   **1**: verified
            /// *   **2**: verifying
            /// *   **3**: failed to be verified
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The type of the OTA update package. Valid values:
            /// 
            /// *   **0**: The uploaded file contains a full update package. IoT Platform pushes the full update package to a device for update.
            /// *   **1**: The uploaded file contains only the differences between the latest update package and previous update package. IoT Platform pushes only the differences to a device for update.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// The custom information that was pushed to the device. The information can be up to 4,096 characters in length. No limit is applies to the content format.
            /// 
            /// After you add the update package and create an update task, IoT Platform sends the custom information to the specified device when IoT Platform pushes the update notification.
            /// </summary>
            [NameInMap("Udi")]
            [Validation(Required=false)]
            public string Udi { get; set; }

            /// <summary>
            /// The time when the OTA update package was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            /// <summary>
            /// The time when the update task was last modified. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            /// <summary>
            /// The verification status of the OTA update package. Valid values:
            /// 
            /// *   **0**: unverified
            /// *   **100**: verified
            /// *   A value N between 0 and 100 indicates that the update task is N percent completed. You can check the response parameter **Status** to see the verification status.
            /// </summary>
            [NameInMap("VerifyProgress")]
            [Validation(Required=false)]
            public int? VerifyProgress { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
