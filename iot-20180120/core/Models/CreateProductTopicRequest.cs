// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductTopicRequest : TeaModel {
        [NameInMap("Codec")]
        [Validation(Required=false)]
        public string Codec { get; set; }

        /// <summary>
        /// The description of the topic category. The description must be 1 to 100 characters in length.
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("EnableProxySubscribe")]
        [Validation(Required=false)]
        public bool? EnableProxySubscribe { get; set; }

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
        /// The operation permissions of the device on the topic category. Valid values:
        /// 
        /// *   **SUB**: Subscribe.
        /// *   **PUB**: Publish.
        /// *   **ALL**: Publish and Subscribe.
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// The ProductKey of the product for which you want to create a topic category.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The name of the user-defined category level that you want to set. By default, a topic category includes the following levels: \_productkey\_ and \_devicename\_. Separate the two levels with slashes (/). Format of a topic category: `productKey/deviceName/topicShortName` .
        /// 
        /// >  Each level can contain letters, digits, and underscores (\_), and cannot be empty.
        /// </summary>
        [NameInMap("TopicShortName")]
        [Validation(Required=false)]
        public string TopicShortName { get; set; }

    }

}
