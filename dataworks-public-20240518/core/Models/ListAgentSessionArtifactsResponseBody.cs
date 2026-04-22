// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentSessionArtifactsResponseBody : TeaModel {
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ListAgentSessionArtifactsResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ListAgentSessionArtifactsResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>28477817</para>
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
            public ListAgentSessionArtifactsResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ListAgentSessionArtifactsResponseBodyJsonRpcResponseResult : TeaModel {
                [NameInMap("Artifacts")]
                [Validation(Required=false)]
                public List<ListAgentSessionArtifactsResponseBodyJsonRpcResponseResultArtifacts> Artifacts { get; set; }
                public class ListAgentSessionArtifactsResponseBodyJsonRpcResponseResultArtifacts : TeaModel {
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>md</para>
                    /// </summary>
                    [NameInMap("ArtifactType")]
                    [Validation(Required=false)]
                    public string ArtifactType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("MaxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CAESExFsbyH...</para>
                /// </summary>
                [NameInMap("NextToken")]
                [Validation(Required=false)]
                public string NextToken { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
