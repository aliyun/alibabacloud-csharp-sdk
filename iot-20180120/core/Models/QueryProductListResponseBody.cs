// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductListResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The product information returned if the call is successful. For more information, see the following parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProductListResponseBodyData Data { get; set; }
        public class QueryProductListResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The details of the products.
            /// 
            /// >  The returned product information is sorted in reverse-chronological order based on the time when the products were created.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryProductListResponseBodyDataList List { get; set; }
            public class QueryProductListResponseBodyDataList : TeaModel {
                [NameInMap("ProductInfo")]
                [Validation(Required=false)]
                public List<QueryProductListResponseBodyDataListProductInfo> ProductInfo { get; set; }
                public class QueryProductListResponseBodyDataListProductInfo : TeaModel {
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
                    /// The data format that was used by a communication protocol to transmit data between the devices and IoT Platform. This parameter is available only if the AliyunCommodityCode parameter is set to iothub_senior.
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
                    /// The number of devices in the product.
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
                    /// The node type of the product. This parameter is available only if the AliyunCommodityCode parameter is set to iothub_senior. Valid values:
                    /// 
                    /// *   **0**: device. Sub-devices cannot be attached to a device. A device can be directly connected to IoT Platform or connected to IoT Platform as a sub-device of a gateway.
                    /// *   **1**: gateway. Sub-devices can be attached to a gateway. A gateway can manage sub-devices, maintain topological relationships with sub-devices, and synchronize topological relationships to IoT Platform.
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public int? NodeType { get; set; }

                    /// <summary>
                    /// The ProductKey of the product. When you create a product, a ProductKey is a globally unique identifier (GUID) that is issued by IoT Platform to the product.
                    /// </summary>
                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    /// <summary>
                    /// The name of the service.
                    /// </summary>
                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                }

            }

            /// <summary>
            /// The total number of returned pages.
            /// </summary>
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of products.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The error message returned if the request fails.
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
