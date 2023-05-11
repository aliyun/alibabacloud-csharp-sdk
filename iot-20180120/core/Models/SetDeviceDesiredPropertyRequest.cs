// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class SetDeviceDesiredPropertyRequest : TeaModel {
        /// <summary>
        /// The name of the device.
        /// 
        /// > If you specify a value for this parameter, you must also specify a value for the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
        /// 
        /// > The IotId parameter specifies a globally unique identifier (GUID) for the device. The value of the **IotId** parameter corresponds to a combination of the values of the **ProductKey** and **DeviceName** parameters. If you specify a value for this parameter, you do not need to specify the **ProductKey** or **DeviceName** parameters. If you specify values for the **IotId**, **ProductKey**, and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.****
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
        /// The property value that you want to specify. The value of this parameter is a JSON string. Format: **Key:Value**. Example: {"Temperature":35}. You can specify up to 10 desired property values.
        /// 
        /// *   **Key** specifies the identifier of the property. You can view the property identifier on the **Define Feature**[ tab of the Product Details page in the IoT Platform console. You can also call the ](~~150321~~)QueryThingModel operation and view the property identifier in the returned TSL data.
        /// 
        ///     If the temperature property belongs to a custom module named testFb, this parameter is set to **{"testFb:temperature":35}**.
        /// 
        /// >The specified property must allow read/write access. If you specify a read-only property, the setting fails. The property identifier must be unique.
        /// 
        /// *   **Value** specifies the desired value of the property. The value must match the data type and value range that are defined for the property.
        /// 
        /// > If you set Value to null, the desired value of the property is cleared.
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

        /// <summary>
        /// The version number of the desired property value. The value of this parameter is a JSON string. Format: Key:Value. Example: {"Temperature":2}.
        /// 
        /// *   **Key** specifies the identifier of the property. You can view the property identifier on the Define Feature tab of the Product Details page in the IoT Platform console.
        /// 
        /// > The property identifier must be unique.
        /// 
        /// *   **Value** specifies the version number of the desired property value.
        /// 
        ///     The first time you specify a desired property value, set the Value parameter to 0. After you set the property value, the version number changes to 1. Each time you specify a desired property value, IoT Platform automatically increases the version number by 1. The second time that you specify a desired property value, the version number changes to 2. The third time that you specify a desired property value, set the version number to 2. After you specify the desired property value, the version number changes to 3.
        /// 
        /// > If the version number that you specify for this parameter is not the current version number, the server rejects the request. If you are not sure about the current version number, you do not need to specify a version number. However, you must enter a valid JSON object {}.
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

    }

}
