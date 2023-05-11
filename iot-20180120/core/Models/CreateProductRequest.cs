// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductRequest : TeaModel {
        /// <summary>
        /// The edition of the product.
        /// 
        /// *   If you do not configure this parameter, a product of the Basic Edition is automatically created. You cannot use a TSL model to define the product.
        /// *   If you want to configure this parameter, set the value to **iothub_senior**. A product that supports TSL models is created. You must also configure the **DataFormat** parameter.
        /// </summary>
        [NameInMap("AliyunCommodityCode")]
        [Validation(Required=false)]
        public string AliyunCommodityCode { get; set; }

        /// <summary>
        /// The verification method that is used to connect the devices of the product to IoT Platform.
        /// 
        /// You do not need to configure this parameter. **secret**: uses DeviceSecrets to verify the devices. Default value: secret. For more information, see [MQTT connections over TCP](~~73742~~).
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// The identifier of the product category. If you configure this parameter, a TSL model of the product category is used. Otherwise, no TSL model is used.
        /// 
        /// You can call the [ListThingTemplates](~~150316~~) operation to query the details of product categories that are predefined by IoT Platform and obtain category keys.
        /// </summary>
        [NameInMap("CategoryKey")]
        [Validation(Required=false)]
        public string CategoryKey { get; set; }

        /// <summary>
        /// The data format.
        /// 
        /// If the **AliyunCommodityCode** parameter is set to **iothub_senior**, you must configure this parameter.
        /// 
        /// Valid values:
        /// 
        /// *   **0**: custom data format.
        /// *   **1**: Alink JSON format.
        /// </summary>
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public int? DataFormat { get; set; }

        /// <summary>
        /// The description of the product. The description can be up to 100 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// You do not need to configure this parameter.
        /// </summary>
        [NameInMap("Id2")]
        [Validation(Required=false)]
        public bool? Id2 { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// 
        /// **Important**
        /// 
        /// *   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// *   If no **Overview** page or ID is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information about the instance, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// You do not need to configure this parameter.
        /// </summary>
        [NameInMap("JoinPermissionId")]
        [Validation(Required=false)]
        public string JoinPermissionId { get; set; }

        /// <summary>
        /// The network connection method.
        /// 
        /// If the **AliyunCommodityCode** parameter is set to **iothub_senior** and the devices of the product are directly connected devices or gateways, you must configure this parameter.
        /// 
        /// Valid values:
        /// 
        /// *   **WIFI**: Wi-Fi.
        /// *   **CELLULAR**: cellular network.
        /// *   **ETHERNET**: Ethernet.
        /// *   **OTHER**: other networks.
        /// 
        /// Default value: WIFI.
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// The node type of the product. Valid values:
        /// 
        /// *   **0**: device. Sub-devices cannot be attached to a device. A device can be directly connected to IoT Platform or connected to IoT Platform as a sub-device of a gateway. If you use the device as a sub-device, you must also configure the **ProtocolType** parameter.
        /// *   **1**: gateway. Sub-devices can be attached to a gateway. A gateway can manage sub-devices, maintain topological relationships with sub-devices, and synchronize topological relationships to IoT Platform.
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public int? NodeType { get; set; }

        /// <summary>
        /// The name of the product.
        /// 
        /// The name must be 4 to 30 characters in length, and can contain letters, digits, and underscores (\_).
        /// 
        /// 
        /// **Important** Each product name must be unique within the current instance.
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// The protocol used by the devices of the product to connect to the gateway.
        /// 
        /// If the **AliyunCommodityCode** parameter is set to **iothub_senior** and a gateway is required to connect the devices of the product to IoT Platform, you must configure this parameter.
        /// 
        /// Valid values:
        /// 
        /// *   **modbus**: Modbus.
        /// *   **opc-ua**: Open Platform Communication Unified Architecture (OPC UA).
        /// *   **customize**: custom protocol.
        /// *   **ble**: Bluetooth Low Energy (BLE).
        /// *   **zigbee**: ZigBee.
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// Specifies whether to publish the TSL model after the product is created.
        /// 
        /// *   **true**: publishes the TSL model after the product is created.
        /// *   **false**: does not publish the TSL model after the product is created.
        /// 
        /// Default value: **true**.
        /// </summary>
        [NameInMap("PublishAuto")]
        [Validation(Required=false)]
        public bool? PublishAuto { get; set; }

        /// <summary>
        /// The ID of the resource group to which the product belongs. If you specify a value for this parameter, the product is added to the resource group.
        /// 
        /// You can log on to the [Resource Management console](https://resourcemanager.console.aliyun.com/resource-groups) to view the ID of the resource group.
        /// 
        /// 
        /// **Important**
        /// 
        /// You can specify a value for this parameter only if you have activated Resource Management.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The level of data verification. If you do not configure this parameter, the default value is used. Valid values:
        /// 
        /// *   **1**: weak verification. Default value: 1. IoT Platform verifies only the identifier and dataType fields of the data. All data is forwarded.
        /// 
        ///     In the IoT Platform console, the data is displayed on the **TSL Data** tab of the **Device Details** page. The data that fails to be verified is not displayed.
        /// 
        ///     You can view the data that failed to be verified in the **checkFailedData** parameter of the forwarded data. For more information, see [Data formats](~~73736~~).
        /// 
        /// *   **2**: no verification. IoT Platform does not verify the data. All data is forwarded.
        /// 
        ///     In the IoT Platform console, the data is not displayed on the **TSL Data** tab of the **Device Details** page.
        /// </summary>
        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public int? ValidateType { get; set; }

    }

}
