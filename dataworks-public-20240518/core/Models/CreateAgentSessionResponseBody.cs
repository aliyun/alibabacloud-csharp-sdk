// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response result.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public CreateAgentSessionResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class CreateAgentSessionResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The JSON-RPC error message. This field is not returned when the request is successful.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public CreateAgentSessionResponseBodyJsonRpcResponseError Error { get; set; }
            public class CreateAgentSessionResponseBodyJsonRpcResponseError : TeaModel {
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
                /// <para>To create a DataAgent instance, you must specify a resource group. Pass the resource group ID in _meta.dataAgent.resourceGroupId of the request</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The ID passed by the requester. The value is returned as is.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-RPC version. Fixed to 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>The business data. The value is null when an error occurs.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public CreateAgentSessionResponseBodyJsonRpcResponseResult Result { get; set; }
            public class CreateAgentSessionResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The ID of the newly created session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sess_0f12abc34</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

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
        /// <para>The request ID for this OpenAPI call. You can use it to troubleshoot issues with the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A9D5E6C-5817-5837-9715-6E3967EC6123</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
