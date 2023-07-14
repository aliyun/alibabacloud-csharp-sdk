// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateTopicConfigRequest : TeaModel {
        [NameInMap("Codec")]
        [Validation(Required=false)]
        public string Codec { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to enable the retained message broadcasting feature for a custom topic.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("EnableBroadcast")]
        [Validation(Required=false)]
        public bool? EnableBroadcast { get; set; }

        [NameInMap("EnableProxySubscribe")]
        [Validation(Required=false)]
        public bool? EnableProxySubscribe { get; set; }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see the [Overview](~~356505~~) topic of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the device belongs. The device receives the retained message.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The custom topic for which you want to enable the retained message broadcasting feature.
        /// 
        /// *   If you use an MQTT gateway device, set this parameter to the original custom topic of the device. For more information, see [Topics](~~433806~~).
        /// *   If you use a non-MQTT gateway device, set this parameter to a custom topic in the following format: `/broadcast/${productKey}/${Custom field}`. `${productKey}` is the value of the **ProductKey** request parameter. You can specify `${Custom field}` based on your business requirements.
        /// 
        /// >  When you develop devices, use code to define a broadcast topic. You do not need to create a topic in the IoT Platform console. You must grant devices the Subscribe permission or the Publish and Subscribe permission on the topic.
        /// </summary>
        [NameInMap("TopicFullName")]
        [Validation(Required=false)]
        public string TopicFullName { get; set; }

    }

}
