// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreatePredefinedDocumentRequest : TeaModel {
        [NameInMap("chunks")]
        [Validation(Required=false)]
        public List<CreatePredefinedDocumentRequestChunks> Chunks { get; set; }
        public class CreatePredefinedDocumentRequestChunks : TeaModel {
            [NameInMap("chunkMeta")]
            [Validation(Required=false)]
            public Dictionary<string, object> ChunkMeta { get; set; }

            [NameInMap("chunkOrder")]
            [Validation(Required=false)]
            public int? ChunkOrder { get; set; }

            [NameInMap("chunkText")]
            [Validation(Required=false)]
            public string ChunkText { get; set; }

            [NameInMap("chunkType")]
            [Validation(Required=false)]
            public string ChunkType { get; set; }

        }

        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
