// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetMqttTicketResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the request fails. For example, <c>Client.Forbidden</c> indicates that the client is forbidden from establishing a connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Client.Forbidden</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The expiration time of the MQTT connection password. It is a UNIX timestamp in milliseconds and is returned as a string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1794278400000</para>
        /// </summary>
        [NameInMap("ExpireTimeStamp")]
        [Validation(Required=false)]
        public string ExpireTimeStamp { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails. It corresponds to the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Client forbidden connect</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The access endpoint for the MQTT client. Use the endpoint returned in this response to establish a connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt.example.com</para>
        /// </summary>
        [NameInMap("MqttEndpoint")]
        [Validation(Required=false)]
        public string MqttEndpoint { get; set; }

        /// <summary>
        /// <para>The MQTT group ID, used to concatenate the MQTT ClientId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_EXAMPLE</para>
        /// </summary>
        [NameInMap("MqttGroupId")]
        [Validation(Required=false)]
        public string MqttGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the MQTT instance, used for token authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-7mz2****</para>
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        /// <summary>
        /// <para>The password used to establish an MQTT connection. It consists of publish and subscribe tokens in the format of <c>W|PublishToken|R|SubscribeToken</c>. Use the complete password returned in the response. The desensitized examples in the documentation cannot be used for connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>W|pubTokenExample****|R|subTokenExample****</para>
        /// </summary>
        [NameInMap("MqttPassword")]
        [Validation(Required=false)]
        public string MqttPassword { get; set; }

        /// <summary>
        /// <para>The username used to establish an MQTT connection. The format is <c>Token|AccessKeyId|InstanceId</c>. AccessKeyId and InstanceId are identifiers used by the server to generate credentials. Use the complete username returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Token|LTAI5tExample****|post-cn-7mz2****</para>
        /// </summary>
        [NameInMap("MqttUsername")]
        [Validation(Required=false)]
        public string MqttUsername { get; set; }

        /// <summary>
        /// <para>The VPC access endpoint for MQTT. It is used by clients that meet the required VPC network access conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt-vpc.example.com</para>
        /// </summary>
        [NameInMap("MqttVPCEndpoint")]
        [Validation(Required=false)]
        public string MqttVPCEndpoint { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B9E3F7B2-5B13-4A7B-8C36-6D1B0A8F0000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of <c>true</c> indicates success, and a value of <c>false</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The topic list. Each element in the list contains <c>topic</c> (the topic name), <c>type</c> (the topic type), and <c>permission</c> (the permission). The list returned by this operation includes topics for publishing, tenant subscription, device subscription, and system subscription. The publish permission is <c>W</c>, and the subscribe permission is <c>R</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;topic&quot;:&quot;pub/550e8400-e29b-41d4-a716-446655440000&quot;,&quot;type&quot;:&quot;pub&quot;,&quot;permission&quot;:&quot;W&quot;},{&quot;topic&quot;:&quot;sub/ten/123456789012****&quot;,&quot;type&quot;:&quot;sub-ten&quot;,&quot;permission&quot;:&quot;R&quot;},{&quot;topic&quot;:&quot;sub/uuid/550e8400-e29b-41d4-a716-446655440000&quot;,&quot;type&quot;:&quot;sub-uuid&quot;,&quot;permission&quot;:&quot;R&quot;},{&quot;topic&quot;:&quot;sub/sys&quot;,&quot;type&quot;:&quot;sub-sys&quot;,&quot;permission&quot;:&quot;R&quot;}]</para>
        /// </summary>
        [NameInMap("TopicList")]
        [Validation(Required=false)]
        public string TopicList { get; set; }

    }

}
