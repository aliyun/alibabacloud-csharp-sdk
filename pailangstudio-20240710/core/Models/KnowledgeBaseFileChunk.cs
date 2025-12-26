// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class KnowledgeBaseFileChunk : TeaModel {
        [NameInMap("ChunkAttachment")]
        [Validation(Required=false)]
        public List<KnowledgeBaseFileChunkChunkAttachment> ChunkAttachment { get; set; }
        public class KnowledgeBaseFileChunkChunkAttachment : TeaModel {
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("PlaceholderId")]
            [Validation(Required=false)]
            public string PlaceholderId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("ChunkContent")]
        [Validation(Required=false)]
        public string ChunkContent { get; set; }

        [NameInMap("ChunkEnd")]
        [Validation(Required=false)]
        public int? ChunkEnd { get; set; }

        [NameInMap("ChunkId")]
        [Validation(Required=false)]
        public string ChunkId { get; set; }

        [NameInMap("ChunkSequence")]
        [Validation(Required=false)]
        public int? ChunkSequence { get; set; }

        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        [NameInMap("ChunkStart")]
        [Validation(Required=false)]
        public int? ChunkStart { get; set; }

        [NameInMap("ChunkStatus")]
        [Validation(Required=false)]
        public string ChunkStatus { get; set; }

        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public KnowledgeBaseFileChunkMetaData MetaData { get; set; }
        public class KnowledgeBaseFileChunkMetaData : TeaModel {
            [NameInMap("FileMetaId")]
            [Validation(Required=false)]
            public string FileMetaId { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileUri")]
            [Validation(Required=false)]
            public string FileUri { get; set; }

        }

        [NameInMap("Score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        [NameInMap("ThumbnailUrl")]
        [Validation(Required=false)]
        public string ThumbnailUrl { get; set; }

    }

}
