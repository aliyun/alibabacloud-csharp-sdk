// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PubRequest : TeaModel {
        /// <summary>
        /// The content type of the message when you use MQTT 5.0 for communication.
        /// 
        /// The content type is usually MIME, such as text or plain********.
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The related data in the request/response communication mode when you use MQTT 5.0. You can specify this parameter as needed.
        /// 
        /// A message recipient can process the request based on the data.
        /// 
        /// >  You must convert the related data into binary data and perform Base64 encoding to generate a value of the string type.
        /// </summary>
        [NameInMap("CorrelationData")]
        [Validation(Required=false)]
        public string CorrelationData { get; set; }

        /// <summary>
        /// The name of the MQTT cloud gateway.
        /// 
        /// >When you publish a message to an MQTT cloud gateway, you must specify this parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the instance. You can obtain the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify this parameter. Otherwise, the call fails.
        /// >*   If the **Overview** page or the instance ID is not displayed in the IoT Platform console, ignore this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The body of the message that you want to publish.
        /// 
        /// To generate a message body, you must convert the raw message into binary data and perform Base64 encoding.
        /// </summary>
        [NameInMap("MessageContent")]
        [Validation(Required=false)]
        public string MessageContent { get; set; }

        /// <summary>
        /// The payload identifier of the message when you use MQTT 5.0 for communication. Valid values:
        /// 
        /// *   **0**: The message is unknown byte data.
        /// *   **1**: The payload of the message is UTF-8 encoded character data.
        /// </summary>
        [NameInMap("PayloadFormatIndicator")]
        [Validation(Required=false)]
        public int? PayloadFormatIndicator { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the device that receives the message belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The quality of service (QoS) level of the message. Valid values:
        /// 
        /// *   **0**: The message is published at most once.
        /// *   **1**: The message is published at least once. If a PUBACK response is not returned after you publish a QoS 1 message, the message is pushed to the device again when the device reconnects to IoT Platform.
        /// 
        /// Default value: **0**.
        /// 
        /// For more information about message communication, see [Limits](~~30527~~).
        /// </summary>
        [NameInMap("Qos")]
        [Validation(Required=false)]
        public int? Qos { get; set; }

        /// <summary>
        /// The response topic in the request/response communication mode when you use MQTT 5.0. For more information, see [MQTT 5.0](~~30540~~).
        /// </summary>
        [NameInMap("ResponseTopic")]
        [Validation(Required=false)]
        public string ResponseTopic { get; set; }

        /// <summary>
        /// The custom topic for the device that receives the message.
        /// 
        /// *   Topic format: `/${productKey}/${deviceName}/user/${TopicShortName}`.
        /// *   You must specify the **Subscribe** permission, or **Publish and Subscribe** permissions for the topic.
        /// 
        /// > Make sure that the device subscribes to the topic before you call the Pub operation. Otherwise, the device cannot receive the message.
        /// 
        /// You can view the custom topics of a product on the **Topic Categories** tab of the **Product Details** page, or by calling the [QueryProductTopic](~~69647~~) operation. You can view the topics to which the device subscribes on the **Topic List** tab of the **Device Details** page.
        /// </summary>
        [NameInMap("TopicFullName")]
        [Validation(Required=false)]
        public string TopicFullName { get; set; }

        [NameInMap("UserProp")]
        [Validation(Required=false)]
        public List<PubRequestUserProp> UserProp { get; set; }
        public class PubRequestUserProp : TeaModel {
            /// <summary>
            /// The custom property key that is specified when you use MQTT 5.0 for communication.
            /// 
            /// This parameter must be used together with the **UserProp.N.Value** parameter.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The custom property value that is specified when you use MQTT 5.0 for communication.
            /// 
            /// This parameter must be used together with the **UserProp.N.Key** parameter.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
