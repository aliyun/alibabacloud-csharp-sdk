// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductResponseBody : TeaModel {
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
        public CreateProductResponseBodyData Data { get; set; }
        public class CreateProductResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the product.
            /// 
            /// *   **iothub_senior**: A TSL model was used.
            /// *   **iothub**: No TSL model was used.
            /// </summary>
            [NameInMap("AliyunCommodityCode")]
            [Validation(Required=false)]
            public string AliyunCommodityCode { get; set; }

            /// <summary>
            /// The authentication method that is used to connect the devices of the product to IoT Platform. Valid values:
            /// 
            /// *   **secret**: uses DeviceSecrets to verify the devices.
            /// *   **id2**: uses IoT Internet Device ID to verify the devices.
            /// *   **x509**: uses X.509 certificates to verify the devices.
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// The data format.
            /// 
            /// *   **0**: custom data format.
            /// *   **1**: Alink JSON format.
            /// 
            /// >  This parameter is returned only if the AliyunCommodityCode parameter is set to iothub_senior.
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
            /// Indicates whether IoT Internet Device ID was enabled.
            /// 
            /// *   **true**: IoT Internet Device ID was enabled.
            /// *   **false**: IoT Internet Device ID was disabled.
            /// </summary>
            [NameInMap("Id2")]
            [Validation(Required=false)]
            public bool? Id2 { get; set; }

            /// <summary>
            /// The node type of the product. Valid values:
            /// 
            /// *   **0**: device. Sub-devices cannot be attached to a device. A device can be directly connected to IoT Platform or connected to IoT Platform as a sub-device of a gateway.
            /// *   **1**: gateway. Sub-devices can be attached to a gateway. A gateway can manage sub-devices, maintain topological relationships with sub-devices, and synchronize topological relationships to IoT Platform.
            /// 
            /// >  This parameter is available only if the AliyunCommodityCode parameter is set to iothub_senior.
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public int? NodeType { get; set; }

            /// <summary>
            /// The ProductKey of the product. A ProductKey is a globally unique identifier (GUID) issued by IoT Platform to a new product.
            /// 
            /// >  Secure the **ProductKey** of the product. The ProductKey is required when you perform specific operations.
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
            /// The protocol used by the devices of the product to connect to the gateway.
            /// 
            /// >  This parameter is available only if the AliyunCommodityCode parameter is set to iothub_senior.
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ProductKey of the product. A ProductKey is a GUID that is issued by IoT Platform to a product.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
