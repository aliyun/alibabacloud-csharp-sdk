// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateChunkRequest : TeaModel {
        /// <summary>
        /// <para>You must provide the chunkToken and at least one of the content or enabled parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateChunkRequestBody Body { get; set; }
        public class UpdateChunkRequestBody : TeaModel {
            /// <summary>
            /// <para>Pass back the chunkToken returned by GetChunk, ListChunks, or SearchKnowledgeBase as is. Do not parse or generate it yourself. If the token has expired at the beginning of the request, Chunk.VersionConflict is returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("chunkToken")]
            [Validation(Required=false)]
            public string ChunkToken { get; set; }

            /// <summary>
            /// <para>Replaces the chunk content. The maximum length is 32,768 characters. Affected vectors are regenerated before the new generation is published. If omitted, the original content is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Welcome to the product</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Specifies whether the chunk is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.
            /// Enabling or disabling only modifies the published result determined at the beginning of the request, and does not follow new results during the process. Indexes are synchronized asynchronously, which may cause a brief delay in retrieval. If omitted, the original enabled status is retained.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>Required when modifying the content. Used for idempotent retries of asynchronous edits. This parameter is not used as a query parameter for GetAsset. If the same token is used with different parameters, IdempotencyConflict is returned. This parameter can be omitted when only modifying the enabled status, and no asynchronous receipt is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chunk-update-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
