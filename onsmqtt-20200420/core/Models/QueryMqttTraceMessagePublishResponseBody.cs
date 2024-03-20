// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceMessagePublishResponseBody : TeaModel {
        /// <summary>
        /// The message traces.
        /// </summary>
        [NameInMap("MessageTraceLists")]
        [Validation(Required=false)]
        public List<QueryMqttTraceMessagePublishResponseBodyMessageTraceLists> MessageTraceLists { get; set; }
        public class QueryMqttTraceMessagePublishResponseBodyMessageTraceLists : TeaModel {
            /// <summary>
            /// The action on the message. Valid values:
            /// 
            /// *   **pub_mqtt**: indicates that the message was sent by an ApsaraMQ for MQTT client.
            /// *   **pub_mq**: indicates that the message was sent by an ApsaraMQ for RocketMQ client.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The returned code for the action on the message. Valid values:
            /// 
            /// *   **mqtt.trace.action.msg.pub.mqtt**: This value is returned if the value of Action is **pub_mqtt**.
            /// *   **mqtt.trace.action.msg.pub.mq**: This value is returned if the value of Action is **pub_mq**.
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// The returned information for the action on the message. Valid values:
            /// 
            /// *   **Pub From Mqtt Client**: This value is returned if the value of Action is **pub_mqtt**.
            /// *   **Pub From MQ**: This value is returned if the value of Action is **pub_mq**.
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// The ID of the client that sends the message.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The message ID.
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// The time when the message was sent.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the ID to troubleshoot issues. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
