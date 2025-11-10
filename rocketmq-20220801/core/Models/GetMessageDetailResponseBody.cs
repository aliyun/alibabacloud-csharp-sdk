// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetMessageDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Topic.NotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMessageDetailResponseBodyData Data { get; set; }
        public class GetMessageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>The size of the message body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("bodySize")]
            [Validation(Required=false)]
            public int? BodySize { get; set; }

            /// <summary>
            /// <para>The client on which the message was produced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.xx.xxx.xx</para>
            /// </summary>
            [NameInMap("bornHost")]
            [Validation(Required=false)]
            public string BornHost { get; set; }

            /// <summary>
            /// <para>The time when the message was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-22 12:17:08</para>
            /// </summary>
            [NameInMap("bornTime")]
            [Validation(Required=false)]
            public string BornTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("liteTopicName")]
            [Validation(Required=false)]
            public string LiteTopicName { get; set; }

            /// <summary>
            /// <para>The sharding key. This parameter is returned only for ordered messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("messageGroup")]
            [Validation(Required=false)]
            public string MessageGroup { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01BE87E485F0C7808C04543CAF00000001</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The message keys.</para>
            /// </summary>
            [NameInMap("messageKeys")]
            [Validation(Required=false)]
            public List<string> MessageKeys { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("messageTag")]
            [Validation(Required=false)]
            public string MessageTag { get; set; }

            /// <summary>
            /// <para>The message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The broker on which the message was stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.xx.xxx.xx</para>
            /// </summary>
            [NameInMap("storeHost")]
            [Validation(Required=false)]
            public string StoreHost { get; set; }

            /// <summary>
            /// <para>The time when the message was stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-22 12:17:08</para>
            /// </summary>
            [NameInMap("storeTime")]
            [Validation(Required=false)]
            public string StoreTime { get; set; }

            /// <summary>
            /// <para>The default system attributes.</para>
            /// </summary>
            [NameInMap("systemProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> SystemProperties { get; set; }

            /// <summary>
            /// <para>The topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topic_test</para>
            /// </summary>
            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// <para>The user attributes.</para>
            /// </summary>
            [NameInMap("userProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> UserProperties { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter instanceId is mandatory for this action .</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAEBD71F-E839-52F9-BD7B-8F1290525841</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
