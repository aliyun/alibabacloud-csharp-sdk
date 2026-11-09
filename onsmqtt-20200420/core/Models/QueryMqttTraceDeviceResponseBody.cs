// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The details of the device activity entries.</para>
        /// </summary>
        [NameInMap("DeviceInfoList")]
        [Validation(Required=false)]
        public List<QueryMqttTraceDeviceResponseBodyDeviceInfoList> DeviceInfoList { get; set; }
        public class QueryMqttTraceDeviceResponseBodyDeviceInfoList : TeaModel {
            /// <summary>
            /// <para>The device action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>connect</b>: The client requests a connection to the server.</para>
            /// </description></item>
            /// <item><description><para><b>close</b>: The TCP connection is closed.</para>
            /// </description></item>
            /// <item><description><para><b>disconnect</b>: The client requests to disconnect from the server.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>connect</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The return code of the device action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>mqtt.trace.action.connect</b>: returned when the device action is <b>connect</b>.</para>
            /// </description></item>
            /// <item><description><para><b>mqtt.trace.action.close</b>: returned when the device action is <b>close</b>.</para>
            /// </description></item>
            /// <item><description><para><b>mqtt.trace.action.disconnect</b>: returned when the device action is <b>disconnect</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt.trace.action.connect</para>
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// <para>The description of the device action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>accepted</b>: The server accepts the connection request from the client.</para>
            /// </description></item>
            /// <item><description><para><b>not authorized</b>: The TCP connection is closed because the permission verification of the instance accessed by the client fails.</para>
            /// </description></item>
            /// <item><description><para><b>clientId conflict</b>: The TCP connection is closed because of a client ID conflict.</para>
            /// </description></item>
            /// <item><description><para><b>resource auth failed</b>: The TCP connection is closed because the permission verification of the topic or group ID resource accessed by the client fails.</para>
            /// </description></item>
            /// <item><description><para><b>no heart</b>: The TCP connection is closed because no heartbeat is detected from the client.</para>
            /// </description></item>
            /// <item><description><para><b>closed by client</b>: The TCP connection is closed because of a client exception.</para>
            /// </description></item>
            /// <item><description><para><b>disconnected by client</b>: The client requests to disconnect.</para>
            /// </description></item>
            /// <item><description><para><b>invalid param</b>: The TCP connection is closed because of invalid request parameters.</para>
            /// </description></item>
            /// <item><description><para><b>Socket IOException</b>: The TCP connection is closed because of network jitter or packet loss.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The connection identifier of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c69fe839209547fa9d073781b9cd****</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The time when the device action occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-21 15:51:54.867</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of device activity entries displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A common parameter. Each request has a unique ID that is active for troubleshooting and locating issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>317076B7-F946-46BC-A98F-4CF9777C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of device activity entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
