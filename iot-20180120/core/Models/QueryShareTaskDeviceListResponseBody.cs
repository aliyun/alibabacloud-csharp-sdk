// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryShareTaskDeviceListResponseBody : TeaModel {
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
        public QueryShareTaskDeviceListResponseBodyData Data { get; set; }
        public class QueryShareTaskDeviceListResponseBodyData : TeaModel {
            /// <summary>
            /// The devices in the sharing task.
            /// </summary>
            [NameInMap("DeviceList")]
            [Validation(Required=false)]
            public QueryShareTaskDeviceListResponseBodyDataDeviceList DeviceList { get; set; }
            public class QueryShareTaskDeviceListResponseBodyDataDeviceList : TeaModel {
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<QueryShareTaskDeviceListResponseBodyDataDeviceListItems> Items { get; set; }
                public class QueryShareTaskDeviceListResponseBodyDataDeviceListItems : TeaModel {
                    /// <summary>
                    /// The DeviceName of the device.
                    /// </summary>
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// The time when the device was added to the sharing task.
                    /// </summary>
                    [NameInMap("GmtAdded")]
                    [Validation(Required=false)]
                    public long? GmtAdded { get; set; }

                    /// <summary>
                    /// The ID of the device. The ID is the unique identifier that is issued by IoT Platform to the device.
                    /// </summary>
                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    /// <summary>
                    /// The **ProductKey** of the product to which the device belongs.
                    /// </summary>
                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

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
