// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The details of the action on the device.</para>
        /// </summary>
        [NameInMap("DeviceInfoList")]
        [Validation(Required=false)]
        public List<QueryMqttTraceDeviceResponseBodyDeviceInfoList> DeviceInfoList { get; set; }
        public class QueryMqttTraceDeviceResponseBodyDeviceInfoList : TeaModel {
            /// <summary>
            /// <para>The action on the device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>connect</b>: The ApsaraMQ for MQTT client requests a connection to the ApsaraMQ for MQTT broker.</description></item>
            /// <item><description><b>close</b>: The TCP connection is closed.</description></item>
            /// <item><description><b>disconnect</b>: The ApsaraMQ for MQTT client requests a disconnection from the ApsaraMQ for MQTT broker.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>connect</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The returned code for the action on the device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mqtt.trace.action.connect</b>: This value is returned if the value of Action is <b>connect</b>.</description></item>
            /// <item><description><b>mqtt.trace.action.close</b>: This value is returned if the value of Action is <b>close</b>.</description></item>
            /// <item><description><b>mqtt.trace.action.disconnect</b>: This value is returned if the value of Action is <b>disconnect</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt.trace.action.connect</para>
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// <para>The returned information for the action on the device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accepted</b>: The ApsaraMQ for MQTT broker accepts the connection request from the ApsaraMQ for MQTT client.</description></item>
            /// <item><description><b>not authorized</b>: The TCP connection is closed because the permission verification of the client to access the instance fails.</description></item>
            /// <item><description><b>clientId conflict</b>: The TCP connection is closed due to a conflict in the ID of the ApsaraMQ for MQTT client.</description></item>
            /// <item><description><b>resource auth failed</b>: The TCP connection is closed because the permission verification for the ApsaraMQ for MQTT client to access the topic or group fails.</description></item>
            /// <item><description><b>no heart</b>: The TCP connection is closed because no heartbeat is detected on the client.</description></item>
            /// <item><description><b>closed by client</b>: The TCP connection is closed because an exception occurs on the client.</description></item>
            /// <item><description><b>disconnected by client</b>: The client requests a disconnection.</description></item>
            /// <item><description><b>invalid param</b>: The TCP connection is closed due to invalid request parameters.</description></item>
            /// <item><description><b>Socket IOException</b>: The TCP connection is closed due to network jitter or packet loss.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The connection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c69fe839209547fa9d073781b9cd****</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The time when the action occurred on the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-21 15:51:54.867</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to troubleshoot issues. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>317076B7-F946-46BC-A98F-4CF9777C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned actions on the device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
