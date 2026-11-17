// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class GetDataChannelCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. OK indicates success. When an exception occurs, the corresponding business error code is returned. Error types and mapping rules follow the current API configuration, and no error codes are added or modified in this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data channel connection and authentication information for the specified device. Use the actual return values and do not infer topics or credentials.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DeviceId&quot;:&quot;10001&quot;,&quot;Topic&quot;:&quot;example-topic-10001&quot;,&quot;ClientId&quot;:&quot;example-client-10001&quot;,&quot;Endpoint&quot;:&quot;example.invalid&quot;,&quot;UserName&quot;:&quot;example-user&quot;,&quot;Password&quot;:&quot;example-password-not-a-credential&quot;,&quot;ExpirationTime&quot;:1794564000000}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataChannelCredentialResponseBodyData Data { get; set; }
        public class GetDataChannelCredentialResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The client connection identifier returned by the data channel service, which should be used in conjunction with the address, username, and password returned in this response. The example is a desensitized placeholder value and does not declare a fixed naming rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-client-10001</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The device ID corresponding to the current data channel credentials, which should match the requested DeviceId. Use it in conjunction with the Topic, ClientId, and authentication information returned in the same response, and do not mix it with the ChannelId of the voice channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>The access endpoint for the data channel. The actual address, protocol, port, and authentication method are subject to the RTC gateway return and client conventions. Local code only delegates to the gateway service, and you cannot use this to confirm a fixed production domain name or MQTT/WebSocket protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.invalid</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The expiration time of the temporary credentials for the data channel. The current POP maps this to expirationTime, whereas the field in the local RTC SDK is expiredTime. You must verify the actual gateway version for field mapping compatibility and time units. Do not assume that this field is always returned or arbitrarily interpret it as milliseconds. The example only demonstrates the integer format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794564000000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>The temporary authentication password used to connect to the data channel, which should be used in conjunction with UserName and within its validity period. It is a sensitive credential, and the real value must not be disclosed. The example is a placeholder value that cannot be used for authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-password-not-a-credential</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The topic identifier returned by the data channel service. The client subscribes to or receives events based on the actual protocol and this topic. Do not infer the topic based on DeviceId, and do not treat the example as a real usable topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-topic-10001</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The temporary authentication username used to connect to the data channel. It should be used in conjunction with the Password and Endpoint returned in the same response. Do not use the example placeholder value for logon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-user</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code recorded in the business response body. A normal return value is 200. To determine whether the business operation is successful, you must also check Code. You cannot determine the success of the call solely based on the presence of this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The business response or error description. It is usually empty or not returned upon success, and you should not expect a fixed text to be returned upon success. Upon failure, it provides an error description to assist in troubleshooting, and should be used in conjunction with Code and Params to understand the cause of the error. The example shows an error message when the instance does not exist (corresponding to the Code NotExists.InstanceId) and is provided for format reference only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance instance-example-001 does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of parameters used for the localized display of error messages, which are not scenario variables or business results. A normal successful response is usually an empty array. When an error occurs, parameters corresponding to the error template may be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID used to associate and troubleshoot this POP request. The value in the response corresponds to this request. System request parameters are injected by the gateway, and the caller does not need to fill in system fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
