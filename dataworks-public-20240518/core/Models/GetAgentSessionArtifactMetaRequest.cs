// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentSessionArtifactMetaRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>900335678024</para>
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

        [NameInMap("Params")]
        [Validation(Required=false)]
        public GetAgentSessionArtifactMetaRequestParams Params { get; set; }
        public class GetAgentSessionArtifactMetaRequestParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mock/mock_report.md</para>
            /// </summary>
            [NameInMap("ArtifactPath")]
            [Validation(Required=false)]
            public string ArtifactPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sess_0f12abc34</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

    }

}
