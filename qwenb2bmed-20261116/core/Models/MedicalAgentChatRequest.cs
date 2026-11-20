// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BMed20261116.Models
{
    public class MedicalAgentChatRequest : TeaModel {
        /// <summary>
        /// <para>The correlation ID, session, and application identity information for this request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public MedicalAgentChatRequestCommunication Communication { get; set; }
        public class MedicalAgentChatRequestCommunication : TeaModel {
            /// <summary>
            /// <para>The business application ID. This parameter is required if no fixed application is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your-app-id</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The optional business scenario tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>health_qa</para>
            /// </summary>
            [NameInMap("appScene")]
            [Validation(Required=false)]
            public string AppScene { get; set; }

            /// <summary>
            /// <para>The session history owner. This value must be the same as the one used in the first call of the session.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLIENT</para>
            /// </summary>
            [NameInMap("historyOwner")]
            [Validation(Required=false)]
            public string HistoryOwner { get; set; }

            /// <summary>
            /// <para>The customer business request ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-req-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The customer session ID. Reuse this ID to continue the conversation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-session-001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The business user and device information provided by the customer. Identity fields are passed based on the configuration of the business gateway credentials.</para>
            /// </summary>
            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public MedicalAgentChatRequestCommunicationUserInfo UserInfo { get; set; }
            public class MedicalAgentChatRequestCommunicationUserInfo : TeaModel {
                /// <summary>
                /// <para>The terminal device identifier provided by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-device-001</para>
                /// </summary>
                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>The business user identifier in the customer application. This is provided based on the user binding or delegation configuration of the business gateway credentials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
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
                /// <para>The name of the business user provided by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample user</para>
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>The business data that carries the message for this request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public MedicalAgentChatRequestData Data { get; set; }
        public class MedicalAgentChatRequestData : TeaModel {
            /// <summary>
            /// <para>The list of messages arranged in conversation order. When the history owner is CLIENT, this list can include the session history provided by the client.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<MedicalAgentChatRequestDataMessages> Messages { get; set; }
            public class MedicalAgentChatRequestDataMessages : TeaModel {
                /// <summary>
                /// <para>The string or array of multimodal content blocks.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>What does the hemoglobin level in the physical examination report mean?</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public object Content { get; set; }

                /// <summary>
                /// <para>The sender of the message. A value of user indicates the business user, and assistant indicates the assistant.</para>
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
        /// <para>The optional extensible JSON object. The directAgent parameter can be omitted or set to med_qa. Other parameters are passed based on the parameters supported by the medical agent.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public MedicalAgentChatRequestParams Params { get; set; }
        public class MedicalAgentChatRequestParams : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable deep thinking for the medical agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("deepthink")]
            [Validation(Required=false)]
            public string Deepthink { get; set; }

            /// <summary>
            /// <para>This parameter can be omitted. If explicitly provided, the value must be med_qa.</para>
            /// 
            /// <b>Example:</b>
            /// <para>med_qa</para>
            /// </summary>
            [NameInMap("directAgent")]
            [Validation(Required=false)]
            public string DirectAgent { get; set; }

            /// <summary>
            /// <para>The response mode. A value of false returns a complete JSON response, and true returns Server-Sent Events (SSE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("responseStreaming")]
            [Validation(Required=false)]
            public bool? ResponseStreaming { get; set; }

        }

    }

}
