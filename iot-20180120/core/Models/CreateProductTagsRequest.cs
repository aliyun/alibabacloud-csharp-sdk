// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductTagsRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// 
        /// **Important**
        /// 
        /// *   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// *   If no **Overview** page or ID is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The **ProductKey** of the product. A **ProductKey** is a GUID that is issued by IoT Platform to a product.
        /// 
        /// You can use the IoT Platform console or call the [QueryProductList](~~69271~~) operation to view the information about all products within the current account.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ProductTag")]
        [Validation(Required=false)]
        public List<CreateProductTagsRequestProductTag> ProductTag { get; set; }
        public class CreateProductTagsRequestProductTag : TeaModel {
            /// <summary>
            /// The keys of product tags. Each key must be 1 to 30 characters in length, and can contain letters, digits, and periods (.).
            /// 
            /// 
            /// **Important** `abc` is a **key** that is reserved by IoT Platform. You cannot set a **key** to `abc`. If you set a `key` to abc, the key is automatically filtered when you query tags.
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// The values of the product tags. Each tag value must be 1 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-).
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
