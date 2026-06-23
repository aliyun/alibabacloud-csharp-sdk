// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreatePredefinedDocumentRequest : TeaModel {
        /// <summary>
        /// <para>A list of document chunks.</para>
        /// </summary>
        [NameInMap("chunks")]
        [Validation(Required=false)]
        public List<CreatePredefinedDocumentRequestChunks> Chunks { get; set; }
        public class CreatePredefinedDocumentRequestChunks : TeaModel {
            /// <summary>
            /// <para>The metadata for the document chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;a&quot;: &quot;1&quot;}</para>
            /// </summary>
            [NameInMap("chunkMeta")]
            [Validation(Required=false)]
            public Dictionary<string, object> ChunkMeta { get; set; }

            /// <summary>
            /// <para>The order of the chunk. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("chunkOrder")]
            [Validation(Required=false)]
            public int? ChunkOrder { get; set; }

            /// <summary>
            /// <para>The text content of the document chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一段测试文本</para>
            /// </summary>
            [NameInMap("chunkText")]
            [Validation(Required=false)]
            public string ChunkText { get; set; }

            /// <summary>
            /// <para>The type of the document chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("chunkType")]
            [Validation(Required=false)]
            public string ChunkType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the document library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;a&quot;: &quot;1&quot;}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>The title of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试文档</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
