// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechLicenseDeviceListResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The result of the request.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySpeechLicenseDeviceListResponseBodyData Data { get; set; }
        public class QuerySpeechLicenseDeviceListResponseBodyData : TeaModel {
            /// <summary>
            /// The information about devices.
            /// </summary>
            [NameInMap("DeviceList")]
            [Validation(Required=false)]
            public QuerySpeechLicenseDeviceListResponseBodyDataDeviceList DeviceList { get; set; }
            public class QuerySpeechLicenseDeviceListResponseBodyDataDeviceList : TeaModel {
                [NameInMap("item")]
                [Validation(Required=false)]
                public List<QuerySpeechLicenseDeviceListResponseBodyDataDeviceListItem> Item { get; set; }
                public class QuerySpeechLicenseDeviceListResponseBodyDataDeviceListItem : TeaModel {
                    /// <summary>
                    /// The DeviceName of the device.
                    /// </summary>
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// The status of the device.
                    /// 
                    /// *   **ONLINE**: The device is online.
                    /// *   **OFFLINE**: The device is offline.
                    /// *   **UNACTIVE**: The device is not activated.
                    /// *   **DISABLE**: The device is disabled.
                    /// *   **DELETE**: The device is deleted.
                    /// </summary>
                    [NameInMap("DeviceStatus")]
                    [Validation(Required=false)]
                    public string DeviceStatus { get; set; }

                    /// <summary>
                    /// The expiration time of the license.
                    /// </summary>
                    [NameInMap("ExpiryTime")]
                    [Validation(Required=false)]
                    public long? ExpiryTime { get; set; }

                    /// <summary>
                    /// Indicates whether the device belongs to the specified device group.
                    /// </summary>
                    [NameInMap("InSpecifiedGroup")]
                    [Validation(Required=false)]
                    public bool? InSpecifiedGroup { get; set; }

                    /// <summary>
                    /// The ID of the device. The ID is the unique identifier that is issued by IoT Platform to the device.
                    /// </summary>
                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    /// <summary>
                    /// The license status.
                    /// 
                    /// *   **NORMAL**: The license is valid.
                    /// *   **EXPIRE**: The license is expired.
                    /// *   **EXPIRING**: The license is about to expire.
                    /// </summary>
                    [NameInMap("LicenseStatus")]
                    [Validation(Required=false)]
                    public string LicenseStatus { get; set; }

                    /// <summary>
                    /// The **ProductKey** of the product to which the device belongs.
                    /// </summary>
                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    /// <summary>
                    /// The ProductName of the product to which the device belongs.
                    /// </summary>
                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
