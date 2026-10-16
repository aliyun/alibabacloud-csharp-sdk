// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetExternalAgentBootstrapOptionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value is SUCCESS when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The access network information available for the external agent.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetExternalAgentBootstrapOptionsResponseBodyData Data { get; set; }
        public class GetExternalAgentBootstrapOptionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The external agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The list of available access networks.</para>
            /// </summary>
            [NameInMap("networkOptions")]
            [Validation(Required=false)]
            public List<GetExternalAgentBootstrapOptionsResponseBodyDataNetworkOptions> NetworkOptions { get; set; }
            public class GetExternalAgentBootstrapOptionsResponseBodyDataNetworkOptions : TeaModel {
                /// <summary>
                /// <para>Indicates whether the access network is available.</para>
                /// </summary>
                [NameInMap("available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                /// <summary>
                /// <para>The access network type. Valid values: INTRANET (internal network) and INTERNET (public network).</para>
                /// 
                /// <b>Example:</b>
                /// <para>INTERNET</para>
                /// </summary>
                [NameInMap("networkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

            }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. The value is 200 when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request processing result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a2b3c4d-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
