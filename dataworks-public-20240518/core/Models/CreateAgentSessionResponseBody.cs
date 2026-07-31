// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public CreateAgentSessionResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class CreateAgentSessionResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The request ID passed by the caller. The value is returned as-is.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-RPC version. Fixed value: 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>The business data. The value is null if an error occurs.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public CreateAgentSessionResponseBodyJsonRpcResponseResult Result { get; set; }
            public class CreateAgentSessionResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The ID of the created session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sess_0f12abc34</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A9D5E6C-5817-5837-9715-6E3967EC6123</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
