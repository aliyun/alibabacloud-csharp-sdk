// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchQueryDeviceDetailResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The device details returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchQueryDeviceDetailResponseBodyData Data { get; set; }
        public class BatchQueryDeviceDetailResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<BatchQueryDeviceDetailResponseBodyDataData> Data { get; set; }
            public class BatchQueryDeviceDetailResponseBodyDataData : TeaModel {
                /// <summary>
                /// The DeviceName of the device.
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
                /// The firmware version number of the device.
                /// </summary>
                [NameInMap("FirmwareVersion")]
                [Validation(Required=false)]
                public string FirmwareVersion { get; set; }

                /// <summary>
                /// The activation time of the device. The time is displayed in UTC.
                /// </summary>
                [NameInMap("GmtActive")]
                [Validation(Required=false)]
                public string GmtActive { get; set; }

                /// <summary>
                /// The creation time of the device. The time is displayed in UTC.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The unique ID of the device. The device ID is issued by IoT Platform.
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
                /// The type of the node. Valid values:
                /// 
                /// *   **0**: device. Sub-devices cannot be mounted on a gateway. A device can connect to IoT Platform directly or as a sub-device of a gateway.
                /// *   **1**: gateway. Sub-devices can be attached to a gateway. A gateway can manage sub-devices, maintain the topological relationships with sub-devices, and synchronize the topological relationships to IoT Platform.
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
                /// The name of the product to which the device belongs.
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// The ID of the region where the device resides. The region is the same as the region where IoT Platform resides. You can view the region in the IoT Platform console.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The status of the device. Valid values:
                /// 
                /// *   **ONLINE**: The device is online.
                /// *   **OFFLINE**: The device is offline.
                /// *   **UNACTIVE**: The device is not activated.
                /// *   **DISABLE**: The device is disabled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The activation time of the device. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UtcActive")]
                [Validation(Required=false)]
                public string UtcActive { get; set; }

                /// <summary>
                /// The creation time of the device. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

            }

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
