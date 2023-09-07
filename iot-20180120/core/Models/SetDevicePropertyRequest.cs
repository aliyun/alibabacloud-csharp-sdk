// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class SetDevicePropertyRequest : TeaModel {
        /// <summary>
        /// The DeviceName of the device.
        /// 
        /// > If you configure this parameter, you must specify a value for the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
        /// 
        /// > The IotId parameter specifies a globally unique identifier (GUID) for the device. The value of the **IotId** parameter corresponds to a combination of the values of the **ProductKey** and **DeviceName** parameters. If you specify a value for this parameter, you do not need to configure the **ProductKey** or **DeviceName** parameter. If you specify values for the **IotId**, **ProductKey**, and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the elastic container instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.****
        /// >*   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The properties that you want to specify. The properties must be in the JSON format.
        /// 
        /// Each property consists of a **key-value pair in the key:value format**. Separate multiple properties with commas (,).
        /// 
        /// For example, you can configure the following properties for a smart lamp:
        /// 
        /// *   A switch property whose key is **Switch** and whose data type is **BOOLEAN**. The value is **1**. The value 1 indicates that the light is on.
        /// *   A color property whose key is **Color** and whose data type is **STRING**. The value is **blue**.
        /// 
        /// In this case, you can specify the following properties in the JSON format:
        /// 
        /// `Items={"Switch":1,"Color":"blue"}`
        /// 
        /// >  If you specify properties for the custom module testFb, set the Items parameter to `{"testFb:Switch":1,"testFb:Color":"blue"}`. The testFb module is not the default module.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public string Items { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// 
        /// > If you configure this parameter, you must also specify a value for the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Qos")]
        [Validation(Required=false)]
        public int? Qos { get; set; }

    }

}
