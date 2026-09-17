// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220602.Models
{
    public class CreateAgentSessionResponseBody : TeaModel {
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public CreateAgentSessionResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class CreateAgentSessionResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2072736942627512345</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public CreateAgentSessionResponseBodyJsonRpcResponseResult Result { get; set; }
            public class CreateAgentSessionResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>046d002e-0c68-4fa2-9fd8-341d9b85afb7</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01A08F39-467F-1B64-A8D4-16357083FF3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
