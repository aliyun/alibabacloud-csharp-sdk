// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateCustomAgentDebugTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. SUCCESS is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The debug token issued in this request, the token fingerprint, and the corresponding resource and network information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateCustomAgentDebugTokenResponseBodyData Data { get; set; }
        public class CreateCustomAgentDebugTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the high-code agent corresponding to the token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The token used by the AgentCore SDK for local debugging. Keep the token secure. Do not write it to logs or commit it to code repositories.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJwcm9kdWN0****</para>
            /// </summary>
            [NameInMap("bootstrapToken")]
            [Validation(Required=false)]
            public string BootstrapToken { get; set; }

            /// <summary>
            /// <para>The network type used for the token, which is the same as the networkType parameter in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The fingerprint used to identify the issued token, which can be used to troubleshoot issuance records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c4f5b8813a0d</para>
            /// </summary>
            [NameInMap("tokenFingerprint")]
            [Validation(Required=false)]
            public string TokenFingerprint { get; set; }

            /// <summary>
            /// <para>The ID of the workspace corresponding to the token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-0123456789abcdef01234</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2B17684-703A-4F29-9D14-30C334A85162</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
