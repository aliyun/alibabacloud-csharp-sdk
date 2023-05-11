// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CopyThingModelRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. On the **Overview** page in the IoT Platform console, you can view the ID of the instance.
        /// 
        /// >*   If your instance has an ID, you must specify this parameter. Otherwise, the call fails.
        /// >*   If the **Overview** page or instance ID is not displayed in the IoT Platform console, ignore this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// >  You do not need to configure this parameter.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The version of the TSL model that you want to copy.
        /// 
        /// You can call the [ListThingModelVersion](~~150318~~) operation to view the TSL model versions of a product.
        /// </summary>
        [NameInMap("SourceModelVersion")]
        [Validation(Required=false)]
        public string SourceModelVersion { get; set; }

        /// <summary>
        /// The ProductKey of the source product.
        /// 
        /// You can view the ProductKey on the Product Details page of the IoT Platform console. You can also obtain the ProductKey by calling the [QueryProductList](~~69271~~) operation.
        /// </summary>
        [NameInMap("SourceProductKey")]
        [Validation(Required=false)]
        public string SourceProductKey { get; set; }

        /// <summary>
        /// The ProductKey of the destination product.
        /// 
        /// You can view the ProductKey on the Product Details page of the IoT Platform console. You can also obtain the ProductKey by calling the [QueryProductList](~~69271~~) operation.
        /// </summary>
        [NameInMap("TargetProductKey")]
        [Validation(Required=false)]
        public string TargetProductKey { get; set; }

    }

}
