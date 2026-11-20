// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BMed20261116.Models
{
    public class MedicalModelInferenceRequest : TeaModel {
        /// <summary>
        /// <para>The association ID, session, and application identity information for the current request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public MedicalModelInferenceRequestCommunication Communication { get; set; }
        public class MedicalModelInferenceRequestCommunication : TeaModel {
            /// <summary>
            /// <para>The business application ID. This parameter is required when no fixed application is configured.</para>
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
            /// <para>The host of the session history. This value must be the same as the value specified in the first call of the session.</para>
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
            /// <para>The customer session ID, which is reused for continued conversations.</para>
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
            public MedicalModelInferenceRequestCommunicationUserInfo UserInfo { get; set; }
            public class MedicalModelInferenceRequestCommunicationUserInfo : TeaModel {
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
                /// <para>The business user identifier in the customer application. This value is provided based on the user binding or delegation configuration of the business gateway credentials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The business user IP address provided by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.10</para>
                /// </summary>
                [NameInMap("userIp")]
                [Validation(Required=false)]
                public string UserIp { get; set; }

                /// <summary>
                /// <para>The business user name provided by the customer.</para>
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
        /// <para>The business data that carries the messages for the current request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public MedicalModelInferenceRequestData Data { get; set; }
        public class MedicalModelInferenceRequestData : TeaModel {
            /// <summary>
            /// <para>The list of messages arranged in conversation order. When hosted by the client, this list can include the session history provided by the client.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<MedicalModelInferenceRequestDataMessages> Messages { get; set; }
            public class MedicalModelInferenceRequestDataMessages : TeaModel {
                /// <summary>
                /// <para>The string or array of multimodal content blocks.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>What does hemoglobin mean in the physical examination report?</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public object Content { get; set; }

                /// <summary>
                /// <para>The sender of the message. A value of user indicates the business user, and a value of assistant indicates the assistant.</para>
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
        /// <para>The extensible JSON object. The modelName parameter is required and its value must be an activated model selector. The directAgent parameter cannot be passed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public MedicalModelInferenceRequestParams Params { get; set; }
        public class MedicalModelInferenceRequestParams : TeaModel {
            /// <summary>
            /// <para>Required. The model selector for this medical API is med_qwen4-vl-125.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>med_qwen4-vl-125</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The response mode. A value of false indicates that a complete JSON object is returned. A value of true indicates that Server-Sent Events (SSE) is returned.</para>
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
