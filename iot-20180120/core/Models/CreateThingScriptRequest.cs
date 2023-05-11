// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateThingScriptRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify this parameter. Otherwise, the call fails.
        /// >*   If the **Overview** page does not appear in the console or no ID is generated for your instance, you do not need to specify this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The **ProductKey** of the product.
        /// 
        /// You can view the **ProductKey** on the Product Details page of the IoT Platform console. You can also obtain the ProductKey by calling the [QueryProductList](~~69271~~) operation.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The content of the script. You must specify this parameter.
        /// 
        /// For more information about script examples, see [What is data parsing](~~68702~~).
        /// </summary>
        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public string ScriptContent { get; set; }

        /// <summary>
        /// The language of the script. Valid values:
        /// 
        /// *   JavaScript
        /// *   Python\_27: Python 2.7
        /// *   PHP\_72: PHP 7.2
        /// </summary>
        [NameInMap("ScriptType")]
        [Validation(Required=false)]
        public string ScriptType { get; set; }

    }

}
