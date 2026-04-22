// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentSessionTokenUsageResponseBody : TeaModel {
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public GetAgentSessionTokenUsageResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class GetAgentSessionTokenUsageResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8212598228302533855</para>
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
            public GetAgentSessionTokenUsageResponseBodyJsonRpcResponseResult Result { get; set; }
            public class GetAgentSessionTokenUsageResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("CachedTokens")]
                [Validation(Required=false)]
                public long? CachedTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("CompletionTokens")]
                [Validation(Required=false)]
                public long? CompletionTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("PromptTokens")]
                [Validation(Required=false)]
                public long? PromptTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("ThoughtsTokens")]
                [Validation(Required=false)]
                public long? ThoughtsTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B313938A-4475-599B-98EB-A0875019FD5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
