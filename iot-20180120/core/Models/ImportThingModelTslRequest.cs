// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ImportThingModelTslRequest : TeaModel {
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
        /// The ProductKey of the product.
        /// 
        /// You can view the ProductKey on the Product Details page of the IoT Platform console. You can also obtain the ProductKey by calling the [QueryProductList](~~69271~~) operation.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// >  You cannot specify this parameter.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The TSL model to be edited. The value is a JSON string. The TSL model defines the properties, services, and events of the product.
        /// 
        /// The value of the **TslStr** parameter must conform to the standard TSL data format. For more information, see [TSL data format](~~73727~~).
        /// 
        /// >  To import a TSL model, you must specify the **TslStr** parameter.
        /// </summary>
        [NameInMap("TslStr")]
        [Validation(Required=false)]
        public string TslStr { get; set; }

        /// <summary>
        /// The URI that is used to store the TSL data in Object Storage Service (OSS).
        /// 
        /// >  This parameter does not take effect. To import a TSL model, you must specify the **TslStr** parameter.
        /// </summary>
        [NameInMap("TslUrl")]
        [Validation(Required=false)]
        public string TslUrl { get; set; }

    }

}
