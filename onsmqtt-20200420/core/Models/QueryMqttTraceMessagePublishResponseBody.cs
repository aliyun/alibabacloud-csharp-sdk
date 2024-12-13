// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceMessagePublishResponseBody : TeaModel {
        /// <summary>
        /// <para>The message traces.</para>
        /// </summary>
        [NameInMap("MessageTraceLists")]
        [Validation(Required=false)]
        public List<QueryMqttTraceMessagePublishResponseBodyMessageTraceLists> MessageTraceLists { get; set; }
        public class QueryMqttTraceMessagePublishResponseBodyMessageTraceLists : TeaModel {
            /// <summary>
            /// <para>The action on the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pub_mqtt</b>: indicates that the message was sent by an ApsaraMQ for MQTT client.</description></item>
            /// <item><description><b>pub_mq</b>: indicates that the message was sent by an ApsaraMQ for RocketMQ client.</description></item>
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
            /// <item><description><b>mqtt.trace.action.msg.pub.mq</b>: This value is returned if the value of Action is <b>pub_mq</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt.trace.action.msg.pub.mqtt</para>
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// <para>The returned information for the action on the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pub From Mqtt Client</b>: This value is returned if the value of Action is <b>pub_mqtt</b>.</description></item>
            /// <item><description><b>Pub From MQ</b>: This value is returned if the value of Action is <b>pub_mq</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pub From Mqtt Client</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The ID of the client that sends the message.</para>
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
            /// <para>AC1EC0030EAB78308DB16A3EC773BD95</para>
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// <para>The time when the message was sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-21 15:08:19.210</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to troubleshoot issues. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69AD5550-BF22-438A-9202-A6E89185****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
