// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentSessionArtifactMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response object.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public GetAgentSessionArtifactMetaResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class GetAgentSessionArtifactMetaResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The ID from the original request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300010555</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-RPC version. The value is <c>2.0</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>Contains the metadata and content of the artifact.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetAgentSessionArtifactMetaResponseBodyJsonRpcResponseResult Result { get; set; }
            public class GetAgentSessionArtifactMetaResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The content of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is md content</para>
                /// </summary>
                [NameInMap("ArtifactContent")]
                [Validation(Required=false)]
                public string ArtifactContent { get; set; }

                /// <summary>
                /// <para>The name of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mock_report.md</para>
                /// </summary>
                [NameInMap("ArtifactName")]
                [Validation(Required=false)]
                public string ArtifactName { get; set; }

                /// <summary>
                /// <para>The path of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mock/mock_report.md</para>
                /// </summary>
                [NameInMap("ArtifactPath")]
                [Validation(Required=false)]
                public string ArtifactPath { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. You can use it to trace the request in logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE70C54F-A3BD-5C19-88EF-2A7D3451C449</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
