// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchPubRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public List<string> DeviceName { get; set; }

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
        /// The body of the message to be published. The maximum size of a message is 256 KB.
        /// 
        /// To generate a message body, you must convert the raw message into binary data and perform Base64 encoding.
        /// </summary>
        [NameInMap("MessageContent")]
        [Validation(Required=false)]
        public string MessageContent { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the device belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The quality of service (QoS) level of the message. Valid values:
        /// 
        /// *   **0**: The message is published at most once.
        /// *   **1**: The message is published at least once.
        /// 
        /// Default value: **0**.
        /// 
        /// >  IoT Platform stores QoS 1 messages for up to 7 days. IoT Platform does not store QoS 0 messages.
        /// </summary>
        [NameInMap("Qos")]
        [Validation(Required=false)]
        public int? Qos { get; set; }

        /// <summary>
        /// The suffix of the custom topic.
        /// 
        /// A custom topic is in the following format: `/${productKey}/${deviceName}/user/${TopicShortName}`. ${TopicShortName} specifies the suffix.
        /// 
        /// >  You must specify the Subscribe permission, or Publish and Subscribe permissions for the topic. Make sure that all devices subscribe to the topic.
        /// 
        /// You can use the following methods to view custom topics:
        /// 
        /// *   On the **Topic Categories** tab of the Product Details page, view the custom topics of the product.
        /// *   On the **Topic List** tab of the Device Details page, view the custom topics to which the device has subscribed.
        /// *   Call the [QueryProductTopic](~~69647~~) operation to query the custom topics of the product.
        /// </summary>
        [NameInMap("TopicShortName")]
        [Validation(Required=false)]
        public string TopicShortName { get; set; }

    }

}
