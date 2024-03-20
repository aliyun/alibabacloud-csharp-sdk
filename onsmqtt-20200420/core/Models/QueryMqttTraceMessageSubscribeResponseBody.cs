// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceMessageSubscribeResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The delivery trace of the queried message.
        /// </summary>
        [NameInMap("MessageTraceLists")]
        [Validation(Required=false)]
        public List<QueryMqttTraceMessageSubscribeResponseBodyMessageTraceLists> MessageTraceLists { get; set; }
        public class QueryMqttTraceMessageSubscribeResponseBodyMessageTraceLists : TeaModel {
            /// <summary>
            /// The action on the message. Valid values:
            /// 
            /// *   **sub**: The ApsaraMQ for MQTT client subscribes to the message.
            /// *   **push_offline**: The ApsaraMQ for MQTT broker pushes the offline message to the ApsaraMQ for MQTT client.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The code returned for the action on the message. Valid values:
            /// 
            /// *   **mqtt.trace.action.msg.sub**: The value that is returned if the value of Action is **sub**.
            /// *   **mqtt.trace.action.msg.push.offline**: The value that is returned if the value of Action is **push_offline**.
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// The returned information for the action on the message. Valid values:
            /// 
            /// *   **Push To Mqtt Client**: The value that is returned if the value of Action is **sub**.
            /// *   **Push Offline Msg To Mqtt Client**: The value that is returned if the value of Action is **push_offline**.
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// The ID of the client that subscribes to the message.
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
            /// The time when the message was delivered.
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
        /// The unique ID that the system generates for the request. You can use the ID to troubleshoot issues. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned delivery traces.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
