// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeDriverResponseBody : TeaModel {
        /// <summary>
        /// The error code. Success indicates that the call was successful. Other values indicate that specific errors occurred. For more information, see [Error codes](~~135200~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about each driver.
        /// </summary>
        [NameInMap("DriverList")]
        [Validation(Required=false)]
        public List<BatchGetEdgeDriverResponseBodyDriverList> DriverList { get; set; }
        public class BatchGetEdgeDriverResponseBodyDriverList : TeaModel {
            /// <summary>
            /// The CPU architecture that the driver supports. Valid values:
            /// 
            /// *   ARMv7
            /// *   ARMv7-HF
            /// *   AArch64
            /// *   x86-64
            /// *   x86
            /// </summary>
            [NameInMap("CpuArch")]
            [Validation(Required=false)]
            public string CpuArch { get; set; }

            /// <summary>
            /// The ID of the driver.
            /// </summary>
            [NameInMap("DriverId")]
            [Validation(Required=false)]
            public string DriverId { get; set; }

            /// <summary>
            /// The name of the driver.
            /// </summary>
            [NameInMap("DriverName")]
            [Validation(Required=false)]
            public string DriverName { get; set; }

            /// <summary>
            /// The communications protocol that the driver uses. Valid values:
            /// 
            /// *   modbus: Modbus protocol
            /// *   opc-ua: OPC UA protocol
            /// *   customize: custom protocol
            /// </summary>
            [NameInMap("DriverProtocol")]
            [Validation(Required=false)]
            public string DriverProtocol { get; set; }

            /// <summary>
            /// The time when the driver was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }

            /// <summary>
            /// The time when the driver was last modified. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }

            /// <summary>
            /// Indicates whether the driver is a built-in driver.
            /// 
            /// *   true: indicates that the driver is a built-in driver, that is, the driver code is pre-configured on the gateway device.
            /// *   false: indicates that the driver is not a built-in driver.
            /// </summary>
            [NameInMap("IsBuiltIn")]
            [Validation(Required=false)]
            public bool? IsBuiltIn { get; set; }

            /// <summary>
            /// The language in which the driver is programmed. Valid values:
            /// 
            /// *   nodejs8: Node.js v8
            /// *   python3: Python v3.5
            /// *   c: C
            /// </summary>
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// The type of the driver. Valid values:
            /// 
            /// *   0: official driver
            /// *   1: custom driver
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// The error message returned if the call failed.
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
        /// Indicates whether the call was successful. true indicates that the call was successful. false indicates that the call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
