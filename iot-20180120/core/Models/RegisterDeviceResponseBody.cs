// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class RegisterDeviceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The device information returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RegisterDeviceResponseBodyData Data { get; set; }
        public class RegisterDeviceResponseBodyData : TeaModel {
            /// <summary>
            /// The DevEUI of the LoRaWAN device. This parameter is returned only when you create a LoRaWAN device.
            /// </summary>
            [NameInMap("DevEui")]
            [Validation(Required=false)]
            public string DevEui { get; set; }

            /// <summary>
            /// The DeviceName of the device.
            /// 
            /// > Keep the information confidential.
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// The DeviceSecret of the device.
            /// 
            /// > Keep the information confidential.
            /// </summary>
            [NameInMap("DeviceSecret")]
            [Validation(Required=false)]
            public string DeviceSecret { get; set; }

            /// <summary>
            /// The ID of the device. The ID is the unique identifier that is issued by IoT Platform to the device.
            /// 
            /// > Keep the information confidential.
            /// </summary>
            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            /// <summary>
            /// The JoinEUI of the LoRaWAN device. This parameter is returned only when you create a LoRaWAN device.
            /// </summary>
            [NameInMap("JoinEui")]
            [Validation(Required=false)]
            public string JoinEui { get; set; }

            /// <summary>
            /// The alias of the device.
            /// 
            /// If you do not specify an alias for the device, this parameter is empty.
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
