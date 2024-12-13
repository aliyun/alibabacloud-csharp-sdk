// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceMessageSubscribeResponseBody : TeaModel {
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
        /// <para>The delivery trace of the queried message.</para>
        /// </summary>
        [NameInMap("MessageTraceLists")]
        [Validation(Required=false)]
        public List<QueryMqttTraceMessageSubscribeResponseBodyMessageTraceLists> MessageTraceLists { get; set; }
        public class QueryMqttTraceMessageSubscribeResponseBodyMessageTraceLists : TeaModel {
            /// <summary>
            /// <para>The action on the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sub</b>: The ApsaraMQ for MQTT client subscribes to the message.</description></item>
            /// <item><description><b>push_offline</b>: The ApsaraMQ for MQTT broker pushes the offline message to the ApsaraMQ for MQTT client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sub</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The code returned for the action on the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mqtt.trace.action.msg.sub</b>: The value that is returned if the value of Action is <b>sub</b>.</description></item>
            /// <item><description><b>mqtt.trace.action.msg.push.offline</b>: The value that is returned if the value of Action is <b>push_offline</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mqtt.trace.action.msg.sub</para>
            /// </summary>
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            /// <summary>
            /// <para>The returned information for the action on the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Push To Mqtt Client</b>: The value that is returned if the value of Action is <b>sub</b>.</description></item>
            /// <item><description><b>Push Offline Msg To Mqtt Client</b>: The value that is returned if the value of Action is <b>push_offline</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Push To Mqtt Client</para>
            /// </summary>
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            /// <summary>
            /// <para>The ID of the client that subscribes to the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_test@@@consumer</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AC1EC1B33D5978308DB17F3245E4****</para>
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// <para>The time when the message was delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-25 16:46:41.274</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID that the system generates for the request. You can use the ID to troubleshoot issues. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E685844-ADAF-4D85-9EAC-F9471E8C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned delivery traces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
