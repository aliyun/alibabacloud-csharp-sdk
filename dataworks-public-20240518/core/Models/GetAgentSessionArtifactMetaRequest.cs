// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentSessionArtifactMetaRequest : TeaModel {
        /// <summary>
        /// <para>A client-provided ID that is echoed in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900335678024</para>
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
        /// <para>The container for business parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public GetAgentSessionArtifactMetaRequestParams Params { get; set; }
        public class GetAgentSessionArtifactMetaRequestParams : TeaModel {
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
            /// <para>The ID of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sess_0f12abc34</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

    }

}
