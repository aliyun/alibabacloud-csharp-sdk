// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateAgentSessionTitleResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response. Result is returned upon success, and Error is returned upon a protocol error.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public UpdateAgentSessionTitleResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class UpdateAgentSessionTitleResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The JSON-RPC error message. This field is not returned upon success.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public UpdateAgentSessionTitleResponseBodyJsonRpcResponseError Error { get; set; }
            public class UpdateAgentSessionTitleResponseBodyJsonRpcResponseError : TeaModel {
                /// <summary>
                /// <para>The JSON-RPC error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The optional additional error information. The content depends on the error type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                /// <summary>
                /// <para>The business error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0x4883300000000019</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The session does not exist or the current account is not authorized to access it. Return to the session list and select another session</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The JSON-RPC correlation ID for the current request. It is passed by the caller and returned as is.</para>
            /// 
            /// <b>Example:</b>
            /// <para>updateagentsessiontitle-rpc-001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-RPC protocol version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>The operation result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public UpdateAgentSessionTitleResponseBodyJsonRpcResponseResult Result { get; set; }
            public class UpdateAgentSessionTitleResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The ID of the agent session whose title is modified. It corresponds to the SessionId in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123e4567-e89b-42d3-a456-426614174000</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The saved session title after modification. Leading and trailing whitespace characters are removed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>New title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The response time. It is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1789549200000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the current OpenAPI request. You can use it to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A0B6E0-E005-1465-B5DE-5CD17677426F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
