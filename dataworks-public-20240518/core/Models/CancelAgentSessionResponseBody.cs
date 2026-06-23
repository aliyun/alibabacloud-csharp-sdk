// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CancelAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public CancelAgentSessionResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class CancelAgentSessionResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The ID passed by the requester. The value is returned as-is in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7675839888324361477</para>
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
            /// <para>The result object of the session cancellation.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public CancelAgentSessionResponseBodyJsonRpcResponseResult Result { get; set; }
            public class CancelAgentSessionResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session-d5d549fe4c2c4180a9814fb74190f502</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7CD3D216-5876-5DB1-A34A-396806F4A413</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
