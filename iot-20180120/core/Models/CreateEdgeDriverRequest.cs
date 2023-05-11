// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateEdgeDriverRequest : TeaModel {
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
        /// The name of the driver to create. The name cannot exceed 20 characters in length and can contain only uppercase letters, lowercase letters, digits, and underscores (\_). It must start with a letter.
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
        /// The ID of the Internet of Things (IoT) service instance. This parameter is not required for public instances. However, this parameter is required for the instances that you have purchased.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// Specifies whether the driver is a built-in driver.
        /// 
        /// *   true: indicates that the driver is a built-in driver, that is, the driver code is pre-configured on the gateway device.
        /// 
        /// *   false: indicates that the driver is not a built-in driver and you must upload the driver code. Default value: false.
        /// 
        /// > If the driver is not a built-in driver, you must upload the driver code.
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

    }

}
