// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateThingModelRequest : TeaModel {
        /// <summary>
        /// The identifier of the custom TSL module. Each identifier is unique in a product. The identifier must be 1 to 30 characters in length, and can contain letters, digits, and underscores (\_).
        /// 
        /// This parameter must be used in combination with the **FunctionBlockName** parameter. If you do not specify this parameter, the system imports the default module.
        /// </summary>
        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

        /// <summary>
        /// The name of the custom module. The name must be 4 to 30 characters in length, and can contain letters, digits, and underscores (\_).
        /// 
        /// This parameter must be used in combination with the **FunctionBlockId** parameter. If you do not specify this parameter, the system imports the default module.
        /// </summary>
        [NameInMap("FunctionBlockName")]
        [Validation(Required=false)]
        public string FunctionBlockName { get; set; }

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
        /// The **ProductKey** of the product.
        /// 
        /// You can view the ProductKey on the Product Details page of the IoT Platform console. You can also obtain the ProductKey by calling the [QueryProductList](~~69271~~) operation.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The details of the new features.
        /// 
        /// >  You can specify a maximum of 10 features.
        /// 
        /// Example:
        /// 
        /// ```
        /// 
        /// {
        ///   "properties": [
        ///     {
        ///       "custom": true,
        ///       "dataSpecsList": [
        ///         {
        ///           "childDataType": "TEXT",
        ///           "childName": "CCID number of the device SIM card",
        ///           "dataSpecs": {
        ///             "custom": true,
        ///             "dataType": "TEXT",
        ///             "length": 20
        ///           },
        ///           "dataType": "STRUCT",
        ///           "identifier": "CCID",
        ///           "name": "CCID number of the device SIM card"
        ///         },
        ///         {
        ///           "childDataType": "INT",
        ///           "childName": "Battery power",
        ///           "dataSpecs": {
        ///             "custom": true,
        ///             "dataType": "INT",
        ///             "max": "60000",
        ///             "min": "0",
        ///             "step": "1"
        ///           },
        ///           "dataType": "STRUCT",
        ///           "identifier": "battery",
        ///           "name": "Battery power"
        ///         },
        ///         {
        ///           "childDataType": "TEXT",
        ///           "childName": "Other information",
        ///           "dataSpecs": {
        ///             "custom": true,
        ///             "dataType": "TEXT",
        ///             "length": 1024
        ///           },
        ///           "dataType": "STRUCT",
        ///           "identifier": "other_info",
        ///           "name": "Other information"
        ///         }
        ///       ],
        ///       "dataType": "STRUCT",
        ///       "identifier": "DEV_INFO",
        ///       "name": "Device information",
        ///       "productKey": "a1T***",
        ///       "propertyId": 18786548,
        ///       "required": false,
        ///       "rwFlag": "READ_ONLY"
        ///     },
        ///     {
        ///       "custom": true,
        ///       "dataSpecs": {
        ///         "childDataType": "INT",
        ///         "custom": true,
        ///         "dataType": "ARRAY",
        ///         "size": 1,
        ///         "dataSpecs": {
        ///           "custom": true,
        ///           "dataType": "INT",
        ///           "max": "65535",
        ///           "min": "0",
        ///           "step": "1",
        ///           "unit": "ppm",
        ///           "unitName": "Parts per million"
        ///         }
        ///       },
        ///       "dataType": "ARRAY",
        ///       "identifier": "airRH_SR",
        ///       "name": "Dehumidifier humidity",
        ///       "productKey": "a1T***",
        ///       "propertyId": 18786551,
        ///       "required": false,
        ///       "rwFlag": "READ_ONLY"
        ///     }
        ///   ],
        ///   "services": [...],
        ///   "events": [...]
        /// }
        ///                                 
        /// ```
        /// 
        /// In the **properties** structure of the **ThingModelJson** parameter, you can use the **extendConfig** parameter to define the extended information of the TSL model. For more information, see [Data structure of ThingModelJson](~~150457~~).
        /// </summary>
        [NameInMap("ThingModelJson")]
        [Validation(Required=false)]
        public string ThingModelJson { get; set; }

    }

}
