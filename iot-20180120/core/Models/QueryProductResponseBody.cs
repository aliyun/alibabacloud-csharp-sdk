// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The product information returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProductResponseBodyData Data { get; set; }
        public class QueryProductResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the product. This parameter indicates whether a Thing Specification Language (TSL) model was used.
            /// 
            /// Valid values:
            /// 
            /// *   **iothub_senior**: A TSL model was used.
            /// *   **iothub**: No TSL model was used.
            /// </summary>
            [NameInMap("AliyunCommodityCode")]
            [Validation(Required=false)]
            public string AliyunCommodityCode { get; set; }

            /// <summary>
            /// The authentication method that was used to connect the devices of the product to IoT Platform. Valid values:
            /// 
            /// *   **secret**: DeviceSecrets were used to authenticate the devices.
            /// *   **id2**: IoT Internet Device ID was used to authenticate the devices.
            /// *   **x509**: X.509 certificates were used to authenticate the devices.
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// The identifier of the category to which the product belongs.
            /// 
            /// This parameter is returned if the product uses the TSL model of a standard category that is pre-defined by IoT Platform.
            /// 
            /// This parameter is available if the AliyunCommodityCode parameter is set to iothub_senior.
            /// </summary>
            [NameInMap("CategoryKey")]
            [Validation(Required=false)]
            public string CategoryKey { get; set; }

            /// <summary>
            /// The name of the product category.
            /// 
            /// This parameter is returned if the product uses the TSL model of a standard category that is pre-defined by IoT Platform.
            /// 
            /// This parameter is available if the AliyunCommodityCode parameter is set to iothub_senior.
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// The data format that was used by a communication protocol to transmit data between the devices and IoT Platform. This parameter is available if the AliyunCommodityCode parameter is set to iothub_senior.
            /// 
            /// Valid values:
            /// 
            /// *   **0**: custom. A custom serial data format was used. In this case, the device can submit raw data, such as binary data streams. IoT Platform converts the raw data into standard Alink JSON data by using a specified data parsing script.
            /// *   **1**: Alink JSON. Alink JSON data is transmitted between the devices and IoT Platform. Alink is a data exchange protocol that is pre-defined by IoT Platform.
            /// </summary>
            [NameInMap("DataFormat")]
            [Validation(Required=false)]
            public int? DataFormat { get; set; }

            /// <summary>
            /// The description of the product.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The number of devices under the product.
            /// </summary>
            [NameInMap("DeviceCount")]
            [Validation(Required=false)]
            public int? DeviceCount { get; set; }

            /// <summary>
            /// The time when the product was created. The value is a timestamp in milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// Indicates whether IoT Internet Device ID was enabled. Valid values:
            /// 
            /// *   **true**: IoT Internet Device ID was enabled.
            /// *   **false**: IoT Internet Device ID was disabled.
            /// </summary>
            [NameInMap("Id2")]
            [Validation(Required=false)]
            public bool? Id2 { get; set; }

            /// <summary>
            /// The network connection method. Valid values:
            /// 
            /// *   **3**: Wi-Fi.
            /// *   **6**: cellular network (2G/3G/4G/5G).
            /// *   **7**: Ethernet.
            /// *   **8**: others.
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public int? NetType { get; set; }

            /// <summary>
            /// The node type of the product. This parameter is available if the AliyunCommodityCode parameter is set to iothub_senior. Valid values:
            /// 
            /// *   **0**: device. Sub-devices cannot be attached to a device. A device can connect to IoT Platform directly or as a sub-device of a gateway.
            /// *   **1**: gateway. Sub-devices can be attached to a gateway. A gateway can manage sub-devices, maintain the topological relationships with sub-devices, and synchronize the topological relationships to IoT Platform.
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public int? NodeType { get; set; }

            /// <summary>
            /// Indicates whether the operation was called by the owner of the product.
            /// 
            /// *   **true**: yes.
            /// *   **false**: no.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public bool? Owner { get; set; }

            /// <summary>
            /// The ProductKey of the product. When you create a product, a ProductKey is the globally unique identifier (GUID) that is issued by IoT Platform to the product.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// The name of the product.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// The ProductSecret of the product.
            /// </summary>
            [NameInMap("ProductSecret")]
            [Validation(Required=false)]
            public string ProductSecret { get; set; }

            /// <summary>
            /// The status of the product.
            /// 
            /// *   **DEVELOPMENT_STATUS**: The product is being developed.
            /// *   **RELEASE_STATUS**: The product was published.
            /// </summary>
            [NameInMap("ProductStatus")]
            [Validation(Required=false)]
            public string ProductStatus { get; set; }

            /// <summary>
            /// The type of the protocol that was used by the sub-devices to connect with a gateway.
            /// 
            /// This parameter is available if the AliyunCommodityCode parameter is set to iothub_senior and the NodeType parameter is set to 1. Valid values:
            /// 
            /// *   **modbus**: Modbus.
            /// *   **opc-ua**: OPC UA.
            /// *   **customize**: custom protocol.
            /// *   **ble**: BLE.
            /// *   **zigbee**: ZigBee.
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The level of the data verification. Valid values:
            /// 
            /// *   **2**: no verification. IoT Platform does not verify the data. All data is forwarded.
            /// 
            ///     In the IoT Platform console, the data is not displayed on the TSL Data tab of the Device Details page.
            /// 
            /// *   **1**: low-level verification. IoT Platform verifies only the identifier and dataType fields of the data. All data is forwarded.
            /// 
            /// *   **0**: high-level verification. IoT Platform verifies all fields of the data. Only the data that passes the verification is forwarded.
            /// 
            ///     The products that were created before October 14, 2020 support only high-level verification.
            /// 
            /// The products that were created on October 14, 2020 or later support low-level verification or no verification.
            /// 
            /// After verification, you can view the data that passes or fails the verification.
            /// 
            /// *   In the IoT Platform console, the data is displayed on the **TSL Data** tab of the **Device Details** page. The data that fails the verification is not displayed.
            /// *   You can view the data that fails the verification in the **checkFailedData** parameter of the forwarded data. For more information, see [Data formats](~~73736~~).
            /// </summary>
            [NameInMap("ValidateType")]
            [Validation(Required=false)]
            public int? ValidateType { get; set; }

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
