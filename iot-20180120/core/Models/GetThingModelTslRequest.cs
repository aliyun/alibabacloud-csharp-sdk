// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingModelTslRequest : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

        /// <summary>
        /// The ProductKey of the product.
        /// 
        /// You can view the ProductKey on the Product Details page of the IoT Platform console. You can also obtain the ProductKey by calling the [QueryProductList](~~69271~~) operation.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to retrieve a simplified TSL model.
        /// 
        /// *   **true**: retrieves a simplified TSL model.
        /// 
        ///     A simplified TSL model includes only the **identifier** and **dataType** attributes of properties, services, events, and related input or output parameters. Simplified TSL models can be used by device developers for reference.
        /// 
        /// *   **false**: retrieves the complete TSL model.
        /// 
        ///     A complete TSL model includes all the parameters and values of properties, services, and events. Complete TSL models can be used by cloud application developers for reference.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// The version number of the TSL model to be queried.
        /// 
        /// If you do not specify this parameter, IoT Platform returns the draft TSL model that is unpublished.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The identifier of the custom TSL module. Each identifier is unique in a product.
        /// 
        /// If you do not specify this parameter, the default module is queried.
        /// </summary>
        [NameInMap("Simple")]
        [Validation(Required=false)]
        public bool? Simple { get; set; }

    }

}
