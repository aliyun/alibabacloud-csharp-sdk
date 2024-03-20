// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceMessageOfClientResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The returned messages.
        /// </summary>
        [NameInMap("MessageOfClientList")]
        [Validation(Required=false)]
        public List<QueryMqttTraceMessageOfClientResponseBodyMessageOfClientList> MessageOfClientList { get; set; }
        public class QueryMqttTraceMessageOfClientResponseBodyMessageOfClientList : TeaModel {
            /// <summary>
            /// The action on the message. Valid values:
            /// 
            /// *   **pub_mqtt**: The ApsaraMQ for MQTT client sends the message.
            /// *   **sub**: The ApsaraMQ for MQTT client subscribes to the message.
            /// *   **push_offline**: The ApsaraMQ for MQTT broker pushes the offline message to the ApsaraMQ for MQTT client.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The returned code for the action on the message. Valid values:
            /// 
            /// *   **mqtt.trace.action.msg.pub.mqtt**: This value is returned if the value of Action is **pub_mqtt**.
            /// *   **mqtt.trace.action.msg.sub**: This value is returned if the value of Action is **sub**.
            /// *   **mqtt.trace.action.msg.push.offline**: This value is returned if the value of Action is **push_offline**.
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// The information returned for the action on the message. Valid values:
            /// 
            /// *   **Pub From Mqtt Client**: This value is returned if the value of Action is **pub_mqtt**.
            /// *   **Push To Mqtt Client**: This value is returned if the value of Action is **sub**.
            /// *   **Push Offline Msg To Mqtt Client**: This value is returned if the value of Action is **push_offline**.
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// The client ID of the device.
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
            /// The time when the message was sent or received.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID. You can use the ID to troubleshoot issues. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of messages returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
