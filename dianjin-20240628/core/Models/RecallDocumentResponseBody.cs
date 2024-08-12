// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecallDocumentResponseBody : TeaModel {
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RecallDocumentResponseBodyData Data { get; set; }
        public class RecallDocumentResponseBodyData : TeaModel {
            [NameInMap("chunkList")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataChunkList> ChunkList { get; set; }
            public class RecallDocumentResponseBodyDataChunkList : TeaModel {
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<RecallDocumentResponseBodyDataChunkListPos> Pos { get; set; }
                public class RecallDocumentResponseBodyDataChunkListPos : TeaModel {
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("chunkPartList")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataChunkPartList> ChunkPartList { get; set; }
            public class RecallDocumentResponseBodyDataChunkPartList : TeaModel {
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<RecallDocumentResponseBodyDataChunkPartListPos> Pos { get; set; }
                public class RecallDocumentResponseBodyDataChunkPartListPos : TeaModel {
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("chunkTextList")]
            [Validation(Required=false)]
            public List<string> ChunkTextList { get; set; }

            [NameInMap("documents")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataDocuments> Documents { get; set; }
            public class RecallDocumentResponseBodyDataDocuments : TeaModel {
                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                [NameInMap("documentMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> DocumentMeta { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("embeddingElapsedMs")]
            [Validation(Required=false)]
            public long? EmbeddingElapsedMs { get; set; }

            [NameInMap("textChunkList")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataTextChunkList> TextChunkList { get; set; }
            public class RecallDocumentResponseBodyDataTextChunkList : TeaModel {
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<RecallDocumentResponseBodyDataTextChunkListPos> Pos { get; set; }
                public class RecallDocumentResponseBodyDataTextChunkListPos : TeaModel {
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("textSearchElapsedMs")]
            [Validation(Required=false)]
            public long? TextSearchElapsedMs { get; set; }

            [NameInMap("totalElapsedMs")]
            [Validation(Required=false)]
            public long? TotalElapsedMs { get; set; }

            [NameInMap("vectorChunkList")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataVectorChunkList> VectorChunkList { get; set; }
            public class RecallDocumentResponseBodyDataVectorChunkList : TeaModel {
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<RecallDocumentResponseBodyDataVectorChunkListPos> Pos { get; set; }
                public class RecallDocumentResponseBodyDataVectorChunkListPos : TeaModel {
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("vectorSearchElapsedMs")]
            [Validation(Required=false)]
            public long? VectorSearchElapsedMs { get; set; }

        }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
