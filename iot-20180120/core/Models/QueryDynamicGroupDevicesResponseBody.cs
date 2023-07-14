// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDynamicGroupDevicesResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The devices returned after the request succeeds. The information is included in the **SimpleDeviceInfo** field.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDynamicGroupDevicesResponseBodyData Data { get; set; }
        public class QueryDynamicGroupDevicesResponseBodyData : TeaModel {
            [NameInMap("SimpleDeviceInfo")]
            [Validation(Required=false)]
            public List<QueryDynamicGroupDevicesResponseBodyDataSimpleDeviceInfo> SimpleDeviceInfo { get; set; }
            public class QueryDynamicGroupDevicesResponseBodyDataSimpleDeviceInfo : TeaModel {
                /// <summary>
                /// The time when the device was activated.
                /// </summary>
                [NameInMap("ActiveTime")]
                [Validation(Required=false)]
                public string ActiveTime { get; set; }

                /// <summary>
                /// The identifier of the category to which the product belongs.
                /// 
                /// This parameter is returned if the product uses the Thing Specification Language (TSL) model of a standard category that is pre-defined by IoT Platform.
                /// </summary>
                [NameInMap("CategoryKey")]
                [Validation(Required=false)]
                public string CategoryKey { get; set; }

                /// <summary>
                /// The DeviceName of the device.
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
                /// </summary>
                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                /// <summary>
                /// The last time when the device went online.
                /// </summary>
                [NameInMap("LastOnlineTime")]
                [Validation(Required=false)]
                public string LastOnlineTime { get; set; }

                /// <summary>
                /// The alias of the device.
                /// </summary>
                [NameInMap("Nickname")]
                [Validation(Required=false)]
                public string Nickname { get; set; }

                /// <summary>
                /// The node type of the product. Valid values:
                /// 
                /// *   **0**: device. A device can connect to IoT Platform directly, or be attached to a gateway as a sub-device and then connect to IoT Platform. Sub-devices cannot be attached to a device.
                /// *   **1**: gateway. Sub-devices can be attached to a gateway. A gateway can manage sub-devices, maintain topological relationships with sub-devices, and synchronize topological relationships to IoT Platform.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

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

                /// <summary>
                /// The device status. Valid values:
                /// 
                /// *   **ONLINE**: The device is online.
                /// *   **OFFLINE**: The device is offline.
                /// *   **UNACTIVE**: The device is not activated.
                /// *   **DISABLE**: The device is deactivated.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the device was activated. The time is in the UTC format.
                /// </summary>
                [NameInMap("UtcActiveTime")]
                [Validation(Required=false)]
                public string UtcActiveTime { get; set; }

                /// <summary>
                /// The last time when the device went online. The time is in the UTC format.
                /// </summary>
                [NameInMap("UtcLastOnlineTime")]
                [Validation(Required=false)]
                public string UtcLastOnlineTime { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// 
        /// If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
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
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

        /// <summary>
        /// The total number of devices.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
