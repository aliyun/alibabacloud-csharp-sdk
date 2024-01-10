// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetDeviceStateResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The device status information returned if the call is successful. For more information, see the following parameters that are included in the DeviceStatus parameter.
        /// </summary>
        [NameInMap("DeviceStatusList")]
        [Validation(Required=false)]
        public BatchGetDeviceStateResponseBodyDeviceStatusList DeviceStatusList { get; set; }
        public class BatchGetDeviceStateResponseBodyDeviceStatusList : TeaModel {
            [NameInMap("DeviceStatus")]
            [Validation(Required=false)]
            public List<BatchGetDeviceStateResponseBodyDeviceStatusListDeviceStatus> DeviceStatus { get; set; }
            public class BatchGetDeviceStateResponseBodyDeviceStatusListDeviceStatus : TeaModel {
                /// <summary>
                /// The IP address of the device.
                /// </summary>
                [NameInMap("AsAddress")]
                [Validation(Required=false)]
                public string AsAddress { get; set; }

                /// <summary>
                /// The ID of the device (expired).
                /// 
                /// >  This parameter is no longer supported. Do not use this parameter to identify a device. You can use the value of the **IotId**** parameter or a combination of the values of the ****ProductKey** and DeviceName parameters to identify a device.
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// The DeviceName of the device.
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// The ID of the device. The ID is the unique identifier that is issued by IoT Platform to the device.
                /// </summary>
                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                /// <summary>
                /// The last time when the device was online.
                /// </summary>
                [NameInMap("LastOnlineTime")]
                [Validation(Required=false)]
                public string LastOnlineTime { get; set; }

                /// <summary>
                /// The status of the device. Valid values: Valid values:
                /// 
                /// *   **ONLINE**: The device is online.
                /// *   **OFFLINE**: The device is offline.
                /// *   **UNACTIVE**: The device is not activated.
                /// *   **DISABLE**: The device is disabled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

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
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
