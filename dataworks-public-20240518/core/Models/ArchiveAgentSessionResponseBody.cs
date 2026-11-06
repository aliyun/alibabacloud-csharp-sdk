// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ArchiveAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response. Result is returned if the call is successful, and Error is returned if a protocol error occurs.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ArchiveAgentSessionResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ArchiveAgentSessionResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The JSON-RPC fault message. This field is not returned if the call is successful.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public ArchiveAgentSessionResponseBodyJsonRpcResponseError Error { get; set; }
            public class ArchiveAgentSessionResponseBodyJsonRpcResponseError : TeaModel {
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
                /// <para>The session does not exist or the current account does not have access permissions. Return to the session list and select another session</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The JSON-RPC correlation identifier of the current request, which is passed by the caller and returned as-is.</para>
            /// 
            /// <b>Example:</b>
            /// <para>archive-rpc-001</para>
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
            /// <para>The session archive status.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ArchiveAgentSessionResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ArchiveAgentSessionResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The archive status after the operation is completed. A value of true indicates that the session is archived, and a value of false indicates that the session is unarchived.</para>
                /// </summary>
                [NameInMap("Archived")]
                [Validation(Required=false)]
                public bool? Archived { get; set; }

                /// <summary>
                /// <para>The ID of the session for which the archive status is set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session_example</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

            }

            /// <summary>
            /// <para>The response time, which is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1789549200000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The OpenAPI request ID, which can be used to troubleshoot call failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A0B6E0-E005-1465-B5DE-5CD17677426F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
