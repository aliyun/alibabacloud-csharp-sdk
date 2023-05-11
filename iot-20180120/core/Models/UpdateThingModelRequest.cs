// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateThingModelRequest : TeaModel {
        /// <summary>
        /// The identifier of the custom TSL module. Each identifier is unique in a product.
        /// 
        /// If you do not specify this parameter or the **FunctionBlockName** parameter, the system updates the features of the default module.
        /// </summary>
        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

        /// <summary>
        /// The name of the custom module. The name must be 4 to 30 characters in length, and can contain letters, digits, and underscores (\_).
        /// 
        /// *   If you do not specify this parameter or the **FunctionBlockId** parameter, the system updates the features of the default module.
        /// *   If you specify this parameter, the parameter must be used in combination with the **FunctionBlockId** parameter. You can modify the name of the specified custom module. The name corresponds to the value of the **FunctionBlockId** parameter.
        /// 
        /// >  You cannot modify the name of the default module.
        /// </summary>
        [NameInMap("FunctionBlockName")]
        [Validation(Required=false)]
        public string FunctionBlockName { get; set; }

        /// <summary>
        /// The identifier of the feature.
        /// 
        /// You can call the [GetThingModelTsl](~~150319~~) operation and view the identifier in the **TslStr** response parameter.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

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
        /// The updated details of the feature.
        /// 
        /// *   If you specify the **Identifier** parameter, you can define only the identifier of the feature.
        /// *   If you do not specify the **Identifier** parameter, you can define a maximum of 50 input and output parameters for a service or event.
        /// 
        /// For more information about how to specify this parameter, see [Data structure of ThingModelJson](~~150457~~).
        /// </summary>
        [NameInMap("ThingModelJson")]
        [Validation(Required=false)]
        public string ThingModelJson { get; set; }

    }

}
