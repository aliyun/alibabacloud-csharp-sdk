// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261105.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// <para>The correlation ID, session, and application identity information for the current request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public ChatRequestCommunication Communication { get; set; }
        public class ChatRequestCommunication : TeaModel {
            /// <summary>
            /// <para>The application ID provided based on the gateway credential identity configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-app</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The optional business scene marker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>travel</para>
            /// </summary>
            [NameInMap("appScene")]
            [Validation(Required=false)]
            public string AppScene { get; set; }

            /// <summary>
            /// <para>The owner of the session history, which must be consistent with the first call of the session.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLIENT</para>
            /// </summary>
            [NameInMap("historyOwner")]
            [Validation(Required=false)]
            public string HistoryOwner { get; set; }

            /// <summary>
            /// <para>The business request ID of the customer.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>req-example-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The session ID of the customer, which is reused for continued chats.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session-example-001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The business user and device information provided by the customer. Identity fields are passed based on the configuration of the business gateway credentials.</para>
            /// </summary>
            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public ChatRequestCommunicationUserInfo UserInfo { get; set; }
            public class ChatRequestCommunicationUserInfo : TeaModel {
                /// <summary>
                /// <para>The terminal device identifier provided by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>device-example-001</para>
                /// </summary>
                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>The business user identifier within the customer application, provided based on the user binding or delegation configuration of the business gateway credentials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The IP address of the business user provided by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.10</para>
                /// </summary>
                [NameInMap("userIp")]
                [Validation(Required=false)]
                public string UserIp { get; set; }

                /// <summary>
                /// <para>The username of the business user provided by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例用户</para>
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>The business data that carries the messages for the current request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ChatRequestData Data { get; set; }
        public class ChatRequestData : TeaModel {
            /// <summary>
            /// <para>The list of messages arranged in conversational order. When history is managed by the client, it can include the session history provided by the client.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<ChatRequestDataMessages> Messages { get; set; }
            public class ChatRequestDataMessages : TeaModel {
                /// <summary>
                /// <para>The text or an array of supported multimodal content blocks.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>请介绍杭州西湖。</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public object Content { get; set; }

                /// <summary>
                /// <para>The sender of the message. user indicates the business user, and assistant indicates the assistant.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

        }

        /// <summary>
        /// <para>An optional extensible JSON object. responseStreaming is an optional boolean value. A value of false returns a complete JSON response, and a value of true returns a Server-Sent Events (SSE) response.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public ChatRequestParams Params { get; set; }
        public class ChatRequestParams : TeaModel {
            /// <summary>
            /// <para>The deep thinking switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("deepthink")]
            [Validation(Required=false)]
            public string Deepthink { get; set; }

            /// <summary>
            /// <para>The agent selector for the current turn.</para>
            /// 
            /// <b>Example:</b>
            /// <para>study_qa</para>
            /// </summary>
            [NameInMap("directAgent")]
            [Validation(Required=false)]
            public string DirectAgent { get; set; }

            /// <summary>
            /// <para>The mixed text and image output switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableTextImageMixed")]
            [Validation(Required=false)]
            public bool? EnableTextImageMixed { get; set; }

            /// <summary>
            /// <para>The maximum number of output tokens for the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("maxTokens")]
            [Validation(Required=false)]
            public int? MaxTokens { get; set; }

            /// <summary>
            /// <para>The HTTP audio output switch.</para>
            /// </summary>
            [NameInMap("outputAudio")]
            [Validation(Required=false)]
            public bool? OutputAudio { get; set; }

            /// <summary>
            /// <para>Specifies whether to use Server-Sent Events (SSE) for conversation responses.</para>
            /// </summary>
            [NameInMap("responseStreaming")]
            [Validation(Required=false)]
            public bool? ResponseStreaming { get; set; }

            /// <summary>
            /// <para>The model sampling temperature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7</para>
            /// </summary>
            [NameInMap("temperature")]
            [Validation(Required=false)]
            public float? Temperature { get; set; }

            /// <summary>
            /// <para>The nucleus sampling probability for the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("topP")]
            [Validation(Required=false)]
            public float? TopP { get; set; }

        }

    }

}
