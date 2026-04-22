// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentSessionArtifactMetaResponseBody : TeaModel {
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public GetAgentSessionArtifactMetaResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class GetAgentSessionArtifactMetaResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>300010555</para>
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
            public GetAgentSessionArtifactMetaResponseBodyJsonRpcResponseResult Result { get; set; }
            public class GetAgentSessionArtifactMetaResponseBodyJsonRpcResponseResult : TeaModel {
                [NameInMap("ArtifactContent")]
                [Validation(Required=false)]
                public string ArtifactContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mock_report.md</para>
                /// </summary>
                [NameInMap("ArtifactName")]
                [Validation(Required=false)]
                public string ArtifactName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mock/mock_report.md</para>
                /// </summary>
                [NameInMap("ArtifactPath")]
                [Validation(Required=false)]
                public string ArtifactPath { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CE70C54F-A3BD-5C19-88EF-2A7D3451C449</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
