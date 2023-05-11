// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class NotifyAddThingTopoRequest : TeaModel {
        /// <summary>
        /// A JSON array of the sub-device identity information. You can use a combination of **ProductKey** and **DeviceName** or only **IotId** to specify a device, such as **\[{"productKey":"a1BwAGxxx","deviceName":"device1"},{"IotId":"Q7uOhxxx"}]**.
        /// </summary>
        [NameInMap("DeviceListStr")]
        [Validation(Required=false)]
        public string DeviceListStr { get; set; }

        /// <summary>
        /// The DeviceName of the gateway.
        /// 
        /// >  If you specify this parameter, you must also specify the **ProductKey** parameter.
        /// </summary>
        [NameInMap("GwDeviceName")]
        [Validation(Required=false)]
        public string GwDeviceName { get; set; }

        /// <summary>
        /// The ID of the gateway device. The ID is a unique identifier that is issued by IoT Platform to the device.
        /// 
        /// >  If you specify this parameter, you do not need to specify **ProductKey** or **DeviceName**. The **IotId** parameter specifies a globally unique identifier (GUID) of the device, which corresponds to a combination of **ProductKey** and **DeviceName**. If you specify both **IotId** and the combination of **ProductKey** and **DeviceName**, **IotId** takes precedence.
        /// </summary>
        [NameInMap("GwIotId")]
        [Validation(Required=false)]
        public string GwIotId { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the gateway belongs.
        /// 
        /// >  If you specify this parameter, you must also specify the **DeviceName** parameter.
        /// </summary>
        [NameInMap("GwProductKey")]
        [Validation(Required=false)]
        public string GwProductKey { get; set; }

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

    }

}
