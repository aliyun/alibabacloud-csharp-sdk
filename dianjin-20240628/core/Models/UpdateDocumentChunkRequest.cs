// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class UpdateDocumentChunkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("chunks")]
        [Validation(Required=false)]
        public List<UpdateDocumentChunkRequestChunks> Chunks { get; set; }
        public class UpdateDocumentChunkRequestChunks : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1987834755763847</para>
            /// </summary>
            [NameInMap("chunkId")]
            [Validation(Required=false)]
            public string ChunkId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("chunkText")]
            [Validation(Required=false)]
            public string ChunkText { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sjdgdsfg</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

    }

}
