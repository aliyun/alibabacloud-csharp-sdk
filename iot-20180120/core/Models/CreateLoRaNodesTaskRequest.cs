// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateLoRaNodesTaskRequest : TeaModel {
        /// <summary>
        /// The LoRaWAN devices.
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public List<CreateLoRaNodesTaskRequestDeviceInfo> DeviceInfo { get; set; }
        public class CreateLoRaNodesTaskRequestDeviceInfo : TeaModel {
            /// <summary>
            /// The DevEUI of the LoRaWAN device.
            /// </summary>
            [NameInMap("DevEui")]
            [Validation(Required=false)]
            public string DevEui { get; set; }

            /// <summary>
            /// The PIN code of the LoRaWAN device. The value of the parameter is used to verify the DevEUI.
            /// </summary>
            [NameInMap("PinCode")]
            [Validation(Required=false)]
            public string PinCode { get; set; }

        }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see the [Overview](~~356505~~) topic of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the devices belong.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
