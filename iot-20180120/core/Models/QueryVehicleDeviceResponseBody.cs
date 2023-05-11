// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryVehicleDeviceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see the "**Error codes**" section of this topic.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The device information returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryVehicleDeviceResponseBodyData Data { get; set; }
        public class QueryVehicleDeviceResponseBodyData : TeaModel {
            /// <summary>
            /// The timestamp when the device was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The DeviceName of the device.
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// The ID is a unique identifier that is issued by IoT Platform to the device.
            /// </summary>
            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("JtProtocolDeviceData")]
            [Validation(Required=false)]
            public QueryVehicleDeviceResponseBodyDataJtProtocolDeviceData JtProtocolDeviceData { get; set; }
            public class QueryVehicleDeviceResponseBodyDataJtProtocolDeviceData : TeaModel {
                [NameInMap("AuthCode")]
                [Validation(Required=false)]
                public string AuthCode { get; set; }

                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("DeviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                [NameInMap("Manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("RegisterTime")]
                [Validation(Required=false)]
                public string RegisterTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VehicleColour")]
                [Validation(Required=false)]
                public string VehicleColour { get; set; }

                [NameInMap("VehicleNumber")]
                [Validation(Required=false)]
                public string VehicleNumber { get; set; }

            }

            /// <summary>
            /// The timestamp when the device was last updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// The **ProductKey** of the gateway product to which the device belongs.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

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
