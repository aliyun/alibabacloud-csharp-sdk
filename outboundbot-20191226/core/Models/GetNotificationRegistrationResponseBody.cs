// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetNotificationRegistrationResponseBody : TeaModel {
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
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNotificationRegistrationResponseBodyData Data { get; set; }
        public class GetNotificationRegistrationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID for message queue access authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The access point of the message queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-pd24po6ds06.cn-hangzhou.rmq.aliyuncs.com:8080</para>
            /// </summary>
            [NameInMap("AccessPoint")]
            [Validation(Required=false)]
            public string AccessPoint { get; set; }

            /// <summary>
            /// <para>The access point type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENDPOINT</para>
            /// </summary>
            [NameInMap("AccessPointType")]
            [Validation(Required=false)]
            public string AccessPointType { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account to which the device currently belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1927084019820962</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The authentication type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USERNAME_PASSWORD</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735660800000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The task group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a5207fec-0732-4160-89c0-e660b353102a</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7f04f92c-ccfc-4f8f-a816-6902023be5c6</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID of the MSMQ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-3g84vpf3712</para>
            /// </summary>
            [NameInMap("MqInstanceId")]
            [Validation(Required=false)]
            public string MqInstanceId { get; set; }

            /// <summary>
            /// <para>The MSMQ type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROCKET_MQ_4</para>
            /// </summary>
            [NameInMap("MqType")]
            [Validation(Required=false)]
            public string MqType { get; set; }

            /// <summary>
            /// <para>The password for Message Queue authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The producer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9142e041-e83c-4f82-9e39-43c4b39caef1</para>
            /// </summary>
            [NameInMap("ProducerId")]
            [Validation(Required=false)]
            public string ProducerId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret for message queue access authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OUTBOUND_BOT_TOPIC</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786085104904</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// <para>The username for Message Queue authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_example</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

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
        /// <para>The API message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
