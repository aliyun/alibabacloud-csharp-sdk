// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceDeviceResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The details of the action on the device.
        /// </summary>
        [NameInMap("DeviceInfoList")]
        [Validation(Required=false)]
        public List<QueryMqttTraceDeviceResponseBodyDeviceInfoList> DeviceInfoList { get; set; }
        public class QueryMqttTraceDeviceResponseBodyDeviceInfoList : TeaModel {
            /// <summary>
            /// The action on the device. Valid values:
            /// 
            /// *   **connect**: The ApsaraMQ for MQTT client requests a connection to the ApsaraMQ for MQTT broker.
            /// *   **close**: The TCP connection is closed.
            /// *   **disconnect**: The ApsaraMQ for MQTT client requests a disconnection from the ApsaraMQ for MQTT broker.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The returned code for the action on the device. Valid values:
            /// 
            /// *   **mqtt.trace.action.connect**: This value is returned if the value of Action is **connect**.
            /// *   **mqtt.trace.action.close**: This value is returned if the value of Action is **close**.
            /// *   **mqtt.trace.action.disconnect**: This value is returned if the value of Action is **disconnect**.
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// The returned information for the action on the device. Valid values:
            /// 
            /// *   **accepted**: The ApsaraMQ for MQTT broker accepts the connection request from the ApsaraMQ for MQTT client.
            /// *   **not authorized**: The TCP connection is closed because the permission verification of the client to access the instance fails.
            /// *   **clientId conflict**: The TCP connection is closed due to a conflict in the ID of the ApsaraMQ for MQTT client.
            /// *   **resource auth failed**: The TCP connection is closed because the permission verification for the ApsaraMQ for MQTT client to access the topic or group fails.
            /// *   **no heart**: The TCP connection is closed because no heartbeat is detected on the client.
            /// *   **closed by client**: The TCP connection is closed because an exception occurs on the client.
            /// *   **disconnected by client**: The client requests a disconnection.
            /// *   **invalid param**: The TCP connection is closed due to invalid request parameters.
            /// *   **Socket IOException**: The TCP connection is closed due to network jitter or packet loss.
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// The connection ID.
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// The time when the action occurred on the device.
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
        /// The total number of returned actions on the device.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
