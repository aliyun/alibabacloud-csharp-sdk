// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DeleteThingModelRequest : TeaModel {
        [NameInMap("EventIdentifier")]
        [Validation(Required=false)]
        public List<string> EventIdentifier { get; set; }

        /// <summary>
        /// The identifier of the custom TSL module. Each identifier is unique in a product.
        /// 
        /// *   If you configure the BatteryModule parameter when a value is specified for the **PropertyIdentifier.N**, **ServiceIdentifier.N**, or **EventIdentifier.N** parameter, the operation removes one or more specified features from the specified custom TSL module. If you do not configure the BatteryModule parameter, the operation removes one or more specified features from the default TSL module.
        /// *   If you configure the BatteryModule parameter when the **PropertyIdentifier.N**, **ServiceIdentifier.N**, and **EventIdentifier.N** parameters are empty, the operation removes all features from the specified custom TSL module.
        /// </summary>
        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If no **Overview** page or ID is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ProductKey of the product.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("PropertyIdentifier")]
        [Validation(Required=false)]
        public List<string> PropertyIdentifier { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// >  You cannot configure this parameter.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ServiceIdentifier")]
        [Validation(Required=false)]
        public List<string> ServiceIdentifier { get; set; }

    }

}
