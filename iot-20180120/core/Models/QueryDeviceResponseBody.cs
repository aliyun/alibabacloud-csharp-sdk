// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The device information returned if the call is successful. The details of the devices are included in the **DeviceInfo** parameter.
        /// 
        /// >  The returned device information is sorted in reverse chronological order based on the time when the devices were created.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceResponseBodyData Data { get; set; }
        public class QueryDeviceResponseBodyData : TeaModel {
            [NameInMap("DeviceInfo")]
            [Validation(Required=false)]
            public List<QueryDeviceResponseBodyDataDeviceInfo> DeviceInfo { get; set; }
            public class QueryDeviceResponseBodyDataDeviceInfo : TeaModel {
                /// <summary>
                /// The ID of the device.
                /// 
                /// >  This parameter is deprecated. Do not use this parameter to identify a device. You can use the **IotId** parameter or a combination of the **ProductKey** and **DeviceName** parameters to identify a device.
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// The name of the device.
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// The DeviceSecret of the device.
                /// </summary>
                [NameInMap("DeviceSecret")]
                [Validation(Required=false)]
                public string DeviceSecret { get; set; }

                /// <summary>
                /// The status of the device. Valid values:
                /// 
                /// *   **ONLINE**: The device is online.
                /// *   **OFFLINE**: The device is offline.
                /// *   **UNACTIVE**: The device is not activated.
                /// *   **DISABLE**: The device is deactivated.
                /// </summary>
                [NameInMap("DeviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                /// <summary>
                /// The category of the product to which the device belongs.
                /// 
                /// >  This parameter is not returned.
                /// </summary>
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// The time when the device was created. The time is in the GMT format.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the device information was last updated. The time is in the GMT format.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
                /// </summary>
                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                /// <summary>
                /// The alias of the device.
                /// </summary>
                [NameInMap("Nickname")]
                [Validation(Required=false)]
                public string Nickname { get; set; }

                /// <summary>
                /// The ProductKey of the product to which the device belongs.
                /// </summary>
                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                /// <summary>
                /// The time when the device was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                /// <summary>
                /// The time when the device information was last updated. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The token that is used to retrieve the subsequent page of the query results. You can specify this parameter in the subsequent query to obtain the next page of results.
        /// 
        /// If the **NextToken** parameter is empty, no subsequent page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The total number of pages returned.
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
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of devices.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
