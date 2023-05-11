// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class RegisterDeviceRequest : TeaModel {
        /// <summary>
        /// The AppKey of the LoRaWAN device.
        /// 
        /// When you create a LoRaWAN device, set **LoraNodeType** to **USERDEFINED**. This parameter is required.
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// The DevEUI of the LoRaWAN device.
        /// 
        /// This parameter is required when you create a LoRaWAN device.
        /// </summary>
        [NameInMap("DevEui")]
        [Validation(Required=false)]
        public string DevEui { get; set; }

        /// <summary>
        /// The DeviceName of the device. The name must be 4 to 32 characters in length, and can contain letters, digits, hyphens (-), underscores (\_), at signs (@), periods (.), and colons (:).
        /// 
        /// You can use a combination of the DeviceName and ProductKey parameters to identify a device.
        /// 
        /// >  If you do not specify this parameter, IoT Platform randomly generates a DeviceName.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The JoinEUI of the LoRaWAN device.
        /// 
        /// When you create a LoRaWAN device, set **LoraNodeType** to **USERDEFINED**. This parameter is required.
        /// </summary>
        [NameInMap("JoinEui")]
        [Validation(Required=false)]
        public string JoinEui { get; set; }

        /// <summary>
        /// The type of the LoRaWAN device. Valid values:
        /// 
        /// *   **ALIYUNDEFINED**: The device is issued by Alibaba Cloud. You must specify **DevEui** and **PinCode**.
        /// *   **USERDEFINED**: The device is user-defined. You must specify **DevEui**, **JoinEui**, and **AppKey**.
        /// </summary>
        [NameInMap("LoraNodeType")]
        [Validation(Required=false)]
        public string LoraNodeType { get; set; }

        /// <summary>
        /// The alias of the device. The alias must be 4 to 64 characters in length, and can contain letters, digits, and underscores (\_).
        /// 
        /// >  If you do not specify this parameter, IoT Platform does not generate an alias for the device.
        /// </summary>
        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// The PIN code of the LoRaWAN device. This parameter is used to verify the DevEUI.
        /// 
        /// When you create a LoRaWAN device, set **LoraNodeType** to **ALIYUNDEFINED**. This parameter is required.
        /// </summary>
        [NameInMap("PinCode")]
        [Validation(Required=false)]
        public string PinCode { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs. A ProductKey is a GUID that is issued by IoT Platform to a product.
        /// 
        /// You can use the IoT Platform console or call the [QueryProductList](~~69271~~) operation to view the information about all products within the current account.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
