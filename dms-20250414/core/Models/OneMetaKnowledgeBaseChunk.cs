// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaKnowledgeBaseChunk : TeaModel {
        /// <summary>
        /// <para>The time when the chunk was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-20 15:51:27</para>
        /// </summary>
        [NameInMap("ChunkMtime")]
        [Validation(Required=false)]
        public string ChunkMtime { get; set; }

        /// <summary>
        /// <para>The title of the chunk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>titile1</para>
        /// </summary>
        [NameInMap("ChunkTitle")]
        [Validation(Required=false)]
        public string ChunkTitle { get; set; }

        /// <summary>
        /// <para>The content of the chunk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The name of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.md</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The unique identifier for the chunk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e12aeb5-52cd-4834-bcd8-****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
