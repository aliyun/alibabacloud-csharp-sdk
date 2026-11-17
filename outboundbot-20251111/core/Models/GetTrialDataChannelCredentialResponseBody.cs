// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class GetTrialDataChannelCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. OK indicates success. When an exception occurs, the corresponding business error code is returned. The error types and mapping rules follow the current API configuration. No error codes are added or modified in this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data channel connection and authentication information for the specified device. Use the actual return values and do not deduce topics or credentials manually.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DeviceId&quot;:&quot;10001&quot;,&quot;Topic&quot;:&quot;example-topic-10001&quot;,&quot;ClientId&quot;:&quot;example-client-10001&quot;,&quot;Endpoint&quot;:&quot;example.invalid&quot;,&quot;UserName&quot;:&quot;example-user&quot;,&quot;Password&quot;:&quot;example-password-not-a-credential&quot;,&quot;ExpirationTime&quot;:1794564000000}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTrialDataChannelCredentialResponseBodyData Data { get; set; }
        public class GetTrialDataChannelCredentialResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The client connection ID returned by the data channel service. It must be used together with the address, username, and password returned in this response. The example is a desensitized placeholder value and does not declare a fixed naming rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-client-10001</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The ID of the client device that initiates web voice calls or receives data channel events. The same client must use the same DeviceId when retrieving data channel credentials and initiating calls. The example is only a business device ID and not a real credential assigned by the platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>The access endpoint of the data channel. The actual address, protocol, port, and authentication method are subject to the return values of the RTC gateway and client conventions. Local code only delegates to the gateway service and cannot be used to confirm a fixed production domain name or MQTT/WebSocket protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.invalid</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The expiration time of the temporary credentials for the data channel. The current POP maps to expirationTime, while the local RTC second-party package field is expiredTime. The field mapping compatibility and time unit must be verified against the actual gateway version. Do not assume that the field is always returned or interpret it as milliseconds without authorization. The example only demonstrates the integer format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794564000000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>The temporary authentication password used to connect to the data channel. It must be used together with UserName and within the validity period. It is a sensitive credential and the real value must not be disclosed. The example is a placeholder value that cannot be used for authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-password-not-a-credential</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The topic ID returned by the data channel service. The client subscribes to or receives events based on the actual protocol and this topic. The client must not deduce the topic based on DeviceId or treat the example as a real available topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-topic-10001</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The temporary authentication username used to connect to the data channel. It must be used together with the Password and Endpoint returned in the same response. The example placeholder value cannot be used for logon.</para>
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
        /// <para>The business response or error description. It is usually empty or not returned upon success, and no fixed text is returned upon success. Upon failure, it provides an error description to assist in troubleshooting. Combine it with Code and Params to understand the cause of the error. The example is an error message when the trial link visitor token expires (corresponding to the Code Expired.VisitorToken) and is for format reference only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VisitorToken: example-visitor-token is expired.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of parameters used for the localized display of error messages. It is not a scenario variable or business result. A normal successful response is usually an empty array. When an error occurs, parameters corresponding to the error template may be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID used to correlate and troubleshoot this POP request. The value in the response corresponds to this request. System request parameters are injected by the gateway, and the caller does not need to fill in system fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
