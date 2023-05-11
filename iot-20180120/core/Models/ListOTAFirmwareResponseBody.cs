// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAFirmwareResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The OTA update packages returned if the call is successful. For more information, see SimpleFirmwareInfo.
        /// </summary>
        [NameInMap("FirmwareInfo")]
        [Validation(Required=false)]
        public ListOTAFirmwareResponseBodyFirmwareInfo FirmwareInfo { get; set; }
        public class ListOTAFirmwareResponseBodyFirmwareInfo : TeaModel {
            [NameInMap("SimpleFirmwareInfo")]
            [Validation(Required=false)]
            public List<ListOTAFirmwareResponseBodyFirmwareInfoSimpleFirmwareInfo> SimpleFirmwareInfo { get; set; }
            public class ListOTAFirmwareResponseBodyFirmwareInfoSimpleFirmwareInfo : TeaModel {
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
                /// </summary>
                [NameInMap("FirmwareSign")]
                [Validation(Required=false)]
                public string FirmwareSign { get; set; }

                /// <summary>
                /// The size of the update package. Unit: bytes.
                /// </summary>
                [NameInMap("FirmwareSize")]
                [Validation(Required=false)]
                public int? FirmwareSize { get; set; }

                /// <summary>
                /// The name of the module.
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// The ProductKey of the product to which the OTA update package belongs.
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
                /// >  The return value is null if you perform a full update.
                /// </summary>
                [NameInMap("SrcVersion")]
                [Validation(Required=false)]
                public string SrcVersion { get; set; }

                /// <summary>
                /// The status of the OTA update package. Valid values:
                /// 
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
                /// *   **0**: complete firmware
                /// *   **1**: differential firmware
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// The time when the update package was created. The time is displayed in UTC.
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

            }

        }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

        /// <summary>
        /// The total number of OTA update packages.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
