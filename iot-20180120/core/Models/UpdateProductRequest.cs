// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateProductRequest : TeaModel {
        /// <summary>
        /// The description of the product. The description must be 1 to 100 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// 
        /// 
        /// **Important**
        /// 
        /// *   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.****
        /// *   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ProductKey of the product. A ProductKey is a GUID that is issued by IoT Platform to the product.****
        /// 
        /// You can use the IoT Platform console or call the [QueryProductList](~~69271~~) operation to view the information about all products within the current Alibaba Cloud account.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The new product name that you want to use.
        /// 
        /// The name must be 4 to 30 characters in length, and can contain letters, digits, and underscores (\_).
        /// 
        /// 
        /// **Important** Each product name must be unique within the current Alibaba Cloud account.
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

    }

}
