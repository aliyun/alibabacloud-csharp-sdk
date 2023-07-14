// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ImportDeviceRequest : TeaModel {
        /// <summary>
        /// The DeviceName of the device.
        /// 
        /// The DeviceName must be 4 to 32 characters in length, and can contain letters, digits, hyphens (-), underscores (\_), at signs (@), periods (.), and colons (:).
        /// 
        /// The DeviceName must be unique in the product.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The DeviceSecret of the device.
        /// 
        /// The DeviceSecret must be 1 to 32 characters in length, and can contain letters, digits, hyphens (-), underscores (\_), at signs (@), periods (.), and colons (:).
        /// </summary>
        [NameInMap("DeviceSecret")]
        [Validation(Required=false)]
        public string DeviceSecret { get; set; }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~) of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The alias of the device.
        /// 
        /// The alias must be 1 to 64 characters in length, and can contain letters, digits, and underscores (\_).
        /// 
        /// > If you do not specify this parameter, IoT Platform does not generate an alias for the device.
        /// </summary>
        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// The **ProductKey** of the gateway product to which the device belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The serial number (SN) of the device.
        /// 
        /// The SN must be 1 to 64 characters in length, and can contain letters, digits, and underscores (\_).
        /// 
        /// > If you do not specify this parameter, IoT Platform does not generate an SN for the device.
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
