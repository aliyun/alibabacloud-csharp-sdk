// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetGatewayBySubDeviceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The gateway details returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayBySubDeviceResponseBodyData Data { get; set; }
        public class GetGatewayBySubDeviceResponseBodyData : TeaModel {
            /// <summary>
            /// The DeviceName of the gateway.
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// The DeviceSecret of the gateway.
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
            /// The activation time of the gateway. The time is displayed in GMT. The time is the local time of the region where the gateway resides.
            /// </summary>
            [NameInMap("GmtActive")]
            [Validation(Required=false)]
            public string GmtActive { get; set; }

            /// <summary>
            /// The creation time of the gateway. The time is displayed in GMT. The time is the local time of the region where the gateway resides.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The last online time of the gateway. The time is displayed in GMT. The time is the local time of the region where the gateway resides.
            /// </summary>
            [NameInMap("GmtOnline")]
            [Validation(Required=false)]
            public string GmtOnline { get; set; }

            /// <summary>
            /// The IP address of the gateway.
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// The node type. The value 1 indicates that the device is a gateway.
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// The **ProductKey** of the product to which the gateway belongs.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// The name of the product to which the gateway belongs.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// The status of the gateway device. Valid values:
            /// 
            /// *   **online**: The device is online.
            /// *   **offline**: The device is offline.
            /// *   **unactive**: The device is not activated.
            /// *   **disable**: The device is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The activation time of the gateway. The time is displayed in UTC. The actual time of the region where the gateway resides is calculated based on the time zone of the region.
            /// </summary>
            [NameInMap("UtcActive")]
            [Validation(Required=false)]
            public string UtcActive { get; set; }

            /// <summary>
            /// The creation time of the gateway. The time is displayed in UTC. The actual time of the region where the gateway resides is calculated based on the time zone of the region.
            /// </summary>
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            /// <summary>
            /// The last online time of the gateway. The time is displayed in UTC. The actual time of the region where the gateway resides is calculated based on the time zone of the region.
            /// </summary>
            [NameInMap("UtcOnline")]
            [Validation(Required=false)]
            public string UtcOnline { get; set; }

            /// <summary>
            /// The ID of the gateway device. The ID is the unique identifier that is issued by IoT Platform to the device.
            /// </summary>
            [NameInMap("iotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            /// <summary>
            /// The region where the gateway resides. This region corresponds to the region that is displayed in the IoT Platform console.
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

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
