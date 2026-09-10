// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class GetSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The subscription information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionResponseBodyData Data { get; set; }
        public class GetSubscriptionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the subscription is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: enabled.</description></item>
            /// <item><description>1: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The endpoint. This parameter is required when MqType is set to ROCKET_MQ_4 or ROCKET_MQ_5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-l4p89zajz67.cn-hangzhou.rmq.aliyuncs.com:8080</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The list of subscription events.</para>
            /// </summary>
            [NameInMap("EventList")]
            [Validation(Required=false)]
            public List<GetSubscriptionResponseBodyDataEventList> EventList { get; set; }
            public class GetSubscriptionResponseBodyDataEventList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the event is pushed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>The display name of the subscription content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Call Ended</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The subscription content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Released</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The Bailian business workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm-3pptowd2olrctsvc</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The MQ instance ID. This parameter is required when MqType is set to ROCKET_MQ_5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-l4p89zajz67.cn</para>
            /// </summary>
            [NameInMap("MqInstanceId")]
            [Validation(Required=false)]
            public string MqInstanceId { get; set; }

            /// <summary>
            /// <para>The message push type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROCKET_MQ_4</para>
            /// </summary>
            [NameInMap("MqType")]
            [Validation(Required=false)]
            public string MqType { get; set; }

            /// <summary>
            /// <para>The password. This parameter is required when MqType is set to ROCKET_MQ_5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pwd</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The producer ID. This parameter is required when MqType is set to ROCKET_MQ_4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PID_Webhook</para>
            /// </summary>
            [NameInMap("ProducerId")]
            [Validation(Required=false)]
            public string ProducerId { get; set; }

            /// <summary>
            /// <para>The queue topic. This parameter is required when MqType is set to ROCKET_MQ_4 or ROCKET_MQ_5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The username. This parameter is required when MqType is set to ROCKET_MQ_5.</para>
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
        /// <para>Instance llm-zzu528i29ecnprcl does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of dynamic error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D771A1B6-3D5F-174A-BEE1-98CE1000D337</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
