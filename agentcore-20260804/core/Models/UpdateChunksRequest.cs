// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateChunksRequest : TeaModel {
        /// <summary>
        /// <para>同一资产内最多 100 条。</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateChunksRequestBody Body { get; set; }
        public class UpdateChunksRequestBody : TeaModel {
            /// <summary>
            /// <para>1 至 100 项，chunkSeq 不得重复。按请求开始读取的已发布结果校验所有令牌并固定写入目标。</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("chunks")]
            [Validation(Required=false)]
            public List<UpdateChunksRequestBodyChunks> Chunks { get; set; }
            public class UpdateChunksRequestBodyChunks : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("chunkSeq")]
                [Validation(Required=false)]
                public int? ChunkSeq { get; set; }

                /// <summary>
                /// <para>原样回传查询返回的 chunkToken，请求开始已过期返回 Chunk.VersionConflict。</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
                /// </summary>
                [NameInMap("chunkToken")]
                [Validation(Required=false)]
                public string ChunkToken { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

        }

    }

}
