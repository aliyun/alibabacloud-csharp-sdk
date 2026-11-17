// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class BridgeTrialWebCallResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. OK indicates success. When an exception occurs, the corresponding business error code is returned. The error types and mapping rules follow the current API configuration, and no error codes are added or modified this time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The session, channel, service address, and temporary authentication token for this web voice call. Use the actually returned connection parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InstanceId&quot;:&quot;instance-example-001&quot;,&quot;SessionId&quot;:&quot;ws-11111111-2222-4333-8444-555555555555&quot;,&quot;ChannelId&quot;:&quot;ch-ws-10001-057100000000-1794560400000-ws-11111111-2222-4333-8444-555555555555&quot;,&quot;ExpirationTime&quot;:&quot;1794564000000&quot;,&quot;ServerUrl&quot;:&quot;wss://example.invalid/voice&quot;,&quot;Token&quot;:&quot;example-web-call-token&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BridgeTrialWebCallResponseBodyData Data { get; set; }
        public class BridgeTrialWebCallResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The web voice connection channel ID assigned or returned by the RTC gateway. It is used to associate and connect the voice channel for this call. It is different from the trial channel AccessChannelId. You must use the real value returned by this API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ch-ws-10001-057100000000-1794560400000-ws-11111111-2222-4333-8444-555555555555</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The expiration time of the web voice connection token for this call. The current POP type is string, and the backend WebCallContext type is long. The code does not mark the time unit. The format and unit must be confirmed according to the actual service provider agreement. The example is only a numeric string and does not represent a verified validity period unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794564000000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The instance identity of the associated product. You must use an instance that the invoker has access to and that actually exists. The instance must be consistent with the instance to which the scenario, channel, and session belong. The maximum length is subject to the current POP parameter definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance-example-001</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The service address used to establish the web voice connection for this call. The format and protocol are determined by the service provider of the RTC gateway. You must use the actual returned value and cannot concatenate it yourself. The example is an unconnectable desensitized address and does not represent a production domain name or protocol guarantee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wss://example.invalid/voice</para>
            /// </summary>
            [NameInMap("ServerUrl")]
            [Validation(Required=false)]
            public string ServerUrl { get; set; }

            /// <summary>
            /// <para>The session ID used to uniquely associate this interaction. For a text session, it is the text- identifier returned when the session is started. For a web voice session, it is the ws- identifier. For a real number outbound call test, it is the test- identifier. Subsequent calls must use the actual returned value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-11111111-2222-4333-8444-555555555555</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The temporary token used to connect to the voice channel for this call. It must be used together with the ServerUrl and ChannelId returned this time. Do not disclose or record the actual token without desensitization. The example is not a valid credential, and the format and validity period are determined by the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-web-call-token</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code recorded in the business response body. A normal return is 200. To determine whether the business is successful, you must also check Code. You cannot determine that the call is successful solely based on the existence of this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The business response or error description. It is usually empty or not returned upon success, and it is not required to return a fixed text upon success. Upon failure, it is an error description used to assist troubleshooting, and it is combined with Code and Params to understand the cause of the error. The example is an error message when the trial link visitor token expires (corresponding to the Code Expired.VisitorToken), and is for format reference only.</para>
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
        /// <para>The ID used to associate and troubleshoot this POP request. The value in the response corresponds to this request. System request parameters are injected by the gateway, and the caller does not need to fill in the system fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
