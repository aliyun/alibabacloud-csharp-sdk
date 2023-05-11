// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryBatchRegisterDeviceStatusResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// 
        /// >  X.509 certificates are available only for devices in the China (Shanghai) region. If devices do not reside in the China (Shanghai) region, you cannot generate X.509 certificates for the devices and the iot.device.RegionNotSupportX509 error code is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The status information returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBatchRegisterDeviceStatusResponseBodyData Data { get; set; }
        public class QueryBatchRegisterDeviceStatusResponseBodyData : TeaModel {
            [NameInMap("InvalidDetailList")]
            [Validation(Required=false)]
            public QueryBatchRegisterDeviceStatusResponseBodyDataInvalidDetailList InvalidDetailList { get; set; }
            public class QueryBatchRegisterDeviceStatusResponseBodyDataInvalidDetailList : TeaModel {
                [NameInMap("invalidDetailList")]
                [Validation(Required=false)]
                public List<QueryBatchRegisterDeviceStatusResponseBodyDataInvalidDetailListInvalidDetailList> InvalidDetailList { get; set; }
                public class QueryBatchRegisterDeviceStatusResponseBodyDataInvalidDetailListInvalidDetailList : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                }

            }

            /// <summary>
            /// *   If the value of the **Status** parameter is **CHECK_FAILED** or **CREATE_FAILED**, some devices failed to be created and the names of the devices that failed to be created are returned in this parameter.
            /// *   If the value of the **Status** parameter is **CHECK_SUCCESS** or **CREATE_SUCCESS**, all devices are created and an empty array is returned in this parameter.
            /// </summary>
            [NameInMap("InvalidList")]
            [Validation(Required=false)]
            public QueryBatchRegisterDeviceStatusResponseBodyDataInvalidList InvalidList { get; set; }
            public class QueryBatchRegisterDeviceStatusResponseBodyDataInvalidList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public List<string> Name { get; set; }

            }

            /// <summary>
            /// The processing status and result. Valid values:
            /// 
            /// *   **CHECK**: The system is verifying device names.
            /// 
            /// *   **CHECK_SUCCESS**: All devices in the application form are verified.
            /// 
            /// *   **CHECK_FAILED**: All devices in the application form failed to be verified.
            /// 
            /// *   **CREATE**: The system is creating devices.
            /// 
            /// *   **CREATE_SUCCESS**: All devices in the application form are created.
            /// 
            /// > If the authentication type of the product to which the devices belong is X.509, all devices and the related X.509 certificates are created.
            /// 
            /// *   **CREATE_FAILED**: Some devices in the application form failed to be created.
            /// 
            /// > If a device or X.509 certificate fails to be created in the current batch when the authentication type is X.509, all devices fail to be created.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// *   If the value of the **Status** parameter is **CHECK_FAILED** or **CREATE_FAILED**, some devices failed to be created and the names of the created devices are returned in this parameter.
            /// *   If the value of the **Status** parameter is **CHECK_SUCCESS** or **CREATE_SUCCESS**, all devices are created and an empty array is returned in this parameter.
            /// </summary>
            [NameInMap("ValidList")]
            [Validation(Required=false)]
            public QueryBatchRegisterDeviceStatusResponseBodyDataValidList ValidList { get; set; }
            public class QueryBatchRegisterDeviceStatusResponseBodyDataValidList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public List<string> Name { get; set; }

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
