// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentSessionArtifactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ListAgentSessionArtifactsResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ListAgentSessionArtifactsResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The ID passed by the caller. The value is returned as-is in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28477817</para>
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
            /// <para>The paginated information of artifacts.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListAgentSessionArtifactsResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ListAgentSessionArtifactsResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The list of artifacts.</para>
                /// </summary>
                [NameInMap("Artifacts")]
                [Validation(Required=false)]
                public List<ListAgentSessionArtifactsResponseBodyJsonRpcResponseResultArtifacts> Artifacts { get; set; }
                public class ListAgentSessionArtifactsResponseBodyJsonRpcResponseResultArtifacts : TeaModel {
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

                    /// <summary>
                    /// <para>The type of the artifact, which is typically the file extension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>md</para>
                    /// </summary>
                    [NameInMap("ArtifactType")]
                    [Validation(Required=false)]
                    public string ArtifactType { get; set; }

                }

                /// <summary>
                /// <para>The actual number of entries returned per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("MaxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <para>The token for the next page. The value is null if there are no more pages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CAESExFsbyH...</para>
                /// </summary>
                [NameInMap("NextToken")]
                [Validation(Required=false)]
                public string NextToken { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
