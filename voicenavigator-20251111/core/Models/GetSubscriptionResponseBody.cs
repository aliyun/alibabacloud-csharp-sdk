// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status. <c>OK</c> indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The subscription details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionResponseBodyData Data { get; set; }
        public class GetSubscriptionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether the subscription is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The message queue endpoint. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_4</c> or <c>ROCKET_MQ_5</c>. The example endpoint is for the China (Hangzhou) region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-l4p89zajz67.cn-hangzhou.rmq.aliyuncs.com:8080</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>A list of subscribed events.</para>
            /// </summary>
            [NameInMap("EventList")]
            [Validation(Required=false)]
            public List<GetSubscriptionResponseBodyDataEventList> EventList { get; set; }
            public class GetSubscriptionResponseBodyDataEventList : TeaModel {
                /// <summary>
                /// <para>Specifies whether pushes for this event are disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>The event\&quot;s display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>通话结束</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Released</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The RocketMQ instance ID. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-l4p89zajz67.cn</para>
            /// </summary>
            [NameInMap("MqInstanceId")]
            [Validation(Required=false)]
            public string MqInstanceId { get; set; }

            /// <summary>
            /// <para>The message queue type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROCKET_MQ_4</para>
            /// </summary>
            [NameInMap("MqType")]
            [Validation(Required=false)]
            public string MqType { get; set; }

            /// <summary>
            /// <para>The password for authentication. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pwd</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The producer ID. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_4</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("ProducerId")]
            [Validation(Required=false)]
            public string ProducerId { get; set; }

            /// <summary>
            /// <para>The message queue topic. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_4</c> or <c>ROCKET_MQ_5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The username for authentication. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_5</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>username</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Dynamic parameters used in the error message.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7401D698-0AAC-5909-B68E-88C68805FFB8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
