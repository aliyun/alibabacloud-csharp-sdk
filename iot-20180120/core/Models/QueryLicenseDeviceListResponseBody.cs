// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryLicenseDeviceListResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see the **"Error codes"** section in this topic.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response message.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLicenseDeviceListResponseBodyData Data { get; set; }
        public class QueryLicenseDeviceListResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the devices.
            /// </summary>
            [NameInMap("DeviceList")]
            [Validation(Required=false)]
            public QueryLicenseDeviceListResponseBodyDataDeviceList DeviceList { get; set; }
            public class QueryLicenseDeviceListResponseBodyDataDeviceList : TeaModel {
                [NameInMap("item")]
                [Validation(Required=false)]
                public List<QueryLicenseDeviceListResponseBodyDataDeviceListItem> Item { get; set; }
                public class QueryLicenseDeviceListResponseBodyDataDeviceListItem : TeaModel {
                    /// <summary>
                    /// The DeviceName of the device.
                    /// </summary>
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// The expiration time of the license.
                    /// </summary>
                    [NameInMap("ExpiryTime")]
                    [Validation(Required=false)]
                    public long? ExpiryTime { get; set; }

                    /// <summary>
                    /// The time when the license was bound to the device.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    /// <summary>
                    /// The device ID.
                    /// </summary>
                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    /// <summary>
                    /// The license type that indicates the audio and video specifications. Valid values: **480P** and **720P**.
                    /// </summary>
                    [NameInMap("LicenseCode")]
                    [Validation(Required=false)]
                    public string LicenseCode { get; set; }

                    /// <summary>
                    /// The **ProductKey** of the product to which the device belongs.
                    /// </summary>
                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    /// <summary>
                    /// The ProductName of the product.
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
