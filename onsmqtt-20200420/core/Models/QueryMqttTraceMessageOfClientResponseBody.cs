// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceMessageOfClientResponseBody : TeaModel {
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
        /// <para>The returned messages.</para>
        /// </summary>
        [NameInMap("MessageOfClientList")]
        [Validation(Required=false)]
        public List<QueryMqttTraceMessageOfClientResponseBodyMessageOfClientList> MessageOfClientList { get; set; }
        public class QueryMqttTraceMessageOfClientResponseBodyMessageOfClientList : TeaModel {
            /// <summary>
            /// <para>The action on the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pub_mqtt</b>: The ApsaraMQ for MQTT client sends the message.</description></item>
            /// <item><description><b>sub</b>: The ApsaraMQ for MQTT client subscribes to the message.</description></item>
            /// <item><description><b>push_offline</b>: The ApsaraMQ for MQTT broker pushes the offline message to the ApsaraMQ for MQTT client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pub_mqtt</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The returned code for the action on the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mqtt.trace.action.msg.pub.mqtt</b>: This value is returned if the value of Action is <b>pub_mqtt</b>.</description></item>
            /// <item><description><b>mqtt.trace.action.msg.sub</b>: This value is returned if the value of Action is <b>sub</b>.</description></item>
            /// <item><description><b>mqtt.trace.action.msg.push.offline</b>: This value is returned if the value of Action is <b>push_offline</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt.trace.action.msg.pub.mqtt</para>
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// <para>The information returned for the action on the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pub From Mqtt Client</b>: This value is returned if the value of Action is <b>pub_mqtt</b>.</description></item>
            /// <item><description><b>Push To Mqtt Client</b>: This value is returned if the value of Action is <b>sub</b>.</description></item>
            /// <item><description><b>Push Offline Msg To Mqtt Client</b>: This value is returned if the value of Action is <b>push_offline</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pub From Mqtt Client</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The client ID of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_test@@@producer</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AC1EC0030EAB78308DB16A3EC773****</para>
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// <para>The time when the message was sent or received.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-21 15:08:19.234</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to troubleshoot issues. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B096B9D6-62F3-4567-BB59-58D1362E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of messages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
