// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// The ID of the ApsaraMQ for MQTT instance. The ID must be consistent with the ID of the instance that the ApsaraMQ for MQTT client uses. You can view the instance ID in the **Basic Information** section on the **Instance Details** page that corresponds to the instance in the [ApsaraMQ for MQTT console](https://mqtt.console.aliyun.com).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The topic to which you want to send a message on the ApsaraMQ for MQTT instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MqttTopic")]
        [Validation(Required=false)]
        public string MqttTopic { get; set; }

        /// <summary>
        /// The message content, which is the payload of the message. We recommend that you encode the content in Base64 to prevent non-printable characters from being transmitted.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

    }

}
