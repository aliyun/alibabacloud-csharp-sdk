// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecallDocumentResponseBody : TeaModel {
        /// <summary>
        /// <para>Time elapsed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RecallDocumentResponseBodyData Data { get; set; }
        public class RecallDocumentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Chunk list.</para>
            /// </summary>
            [NameInMap("chunkList")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataChunkList> ChunkList { get; set; }
            public class RecallDocumentResponseBodyDataChunkList : TeaModel {
                /// <summary>
                /// <para>Document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>823746762354</para>
                /// </summary>
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;:&quot;1&quot;}</para>
                /// </summary>
                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                /// <summary>
                /// <para>Document chunk OSS address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss-xxx-hangzhou.com/xxx">http://oss-xxx-hangzhou.com/xxx</a></para>
                /// </summary>
                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                /// <summary>
                /// <para>Document chunk text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档块</para>
                /// </summary>
                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                /// <summary>
                /// <para>Document chunk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                /// <summary>
                /// <para>Document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>839468263472</para>
                /// </summary>
                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>Document type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>Document library ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dscsbdsk</para>
                /// </summary>
                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                /// <summary>
                /// <para>Document library name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档库</para>
                /// </summary>
                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                /// <summary>
                /// <para>Next document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>982374872364</para>
                /// </summary>
                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk position.</para>
                /// </summary>
                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<RecallDocumentResponseBodyDataChunkListPos> Pos { get; set; }
                public class RecallDocumentResponseBodyDataChunkListPos : TeaModel {
                    /// <summary>
                    /// <para>Coordinates.</para>
                    /// </summary>
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    /// <summary>
                    /// <para>Page number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    /// <summary>
                    /// <para>Text highlight area, used for text-type file highlighting.</para>
                    /// </summary>
                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                /// <summary>
                /// <para>Previous document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>827364827364832</para>
                /// </summary>
                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>Document title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Chunk part (layout recognition result) list.</para>
            /// </summary>
            [NameInMap("chunkPartList")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataChunkPartList> ChunkPartList { get; set; }
            public class RecallDocumentResponseBodyDataChunkPartList : TeaModel {
                /// <summary>
                /// <para>Document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>98327482364</para>
                /// </summary>
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;:&quot;1&quot;}</para>
                /// </summary>
                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                /// <summary>
                /// <para>Document chunk OSS address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss-xxx-hangzhou.com/xxx">http://oss-xxx-hangzhou.com/xxx</a></para>
                /// </summary>
                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                /// <summary>
                /// <para>Document chunk text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档块</para>
                /// </summary>
                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                /// <summary>
                /// <para>Document chunk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                /// <summary>
                /// <para>Document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92837482364</para>
                /// </summary>
                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>Document type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>Document library ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sjdhgjsd</para>
                /// </summary>
                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                /// <summary>
                /// <para>Document library name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档库</para>
                /// </summary>
                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                /// <summary>
                /// <para>Next document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2387648263542</para>
                /// </summary>
                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk position.</para>
                /// </summary>
                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<RecallDocumentResponseBodyDataChunkPartListPos> Pos { get; set; }
                public class RecallDocumentResponseBodyDataChunkPartListPos : TeaModel {
                    /// <summary>
                    /// <para>Coordinates.</para>
                    /// </summary>
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    /// <summary>
                    /// <para>Page number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    /// <summary>
                    /// <para>Text highlight area, used for text-type file highlighting.</para>
                    /// </summary>
                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                /// <summary>
                /// <para>Previous document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32874682764</para>
                /// </summary>
                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>Document title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档标题</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Chunk text list.</para>
            /// </summary>
            [NameInMap("chunkTextList")]
            [Validation(Required=false)]
            public List<string> ChunkTextList { get; set; }

            /// <summary>
            /// <para>Document list.</para>
            /// </summary>
            [NameInMap("documents")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataDocuments> Documents { get; set; }
            public class RecallDocumentResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>Document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92837482364</para>
                /// </summary>
                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>Document metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;:&quot;1&quot;}</para>
                /// </summary>
                [NameInMap("documentMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> DocumentMeta { get; set; }

                /// <summary>
                /// <para>Document type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Document library ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sjdhgjsd</para>
                /// </summary>
                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                /// <summary>
                /// <para>Document title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Document link.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss-xxx-hangzhou.com/test.pdf">http://oss-xxx-hangzhou.com/test.pdf</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Vector computation time elapsed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("embeddingElapsedMs")]
            [Validation(Required=false)]
            public long? EmbeddingElapsedMs { get; set; }

            /// <summary>
            /// <para>List of chunks retrieved from the text index.</para>
            /// </summary>
            [NameInMap("textChunkList")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataTextChunkList> TextChunkList { get; set; }
            public class RecallDocumentResponseBodyDataTextChunkList : TeaModel {
                /// <summary>
                /// <para>Document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32874682364</para>
                /// </summary>
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;:&quot;1&quot;}</para>
                /// </summary>
                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                /// <summary>
                /// <para>Document chunk OSS address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss-xxx-hangzhou.com/xxx">http://oss-xxx-hangzhou.com/xxx</a></para>
                /// </summary>
                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                /// <summary>
                /// <para>Document chunk text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一段测试文档块</para>
                /// </summary>
                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                /// <summary>
                /// <para>Document chunk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                /// <summary>
                /// <para>Document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8372467263542</para>
                /// </summary>
                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>Document type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>Document library ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>djsgfsjd</para>
                /// </summary>
                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                /// <summary>
                /// <para>Document library name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档库</para>
                /// </summary>
                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                /// <summary>
                /// <para>Next document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23874682432</para>
                /// </summary>
                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk position.</para>
                /// </summary>
                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<RecallDocumentResponseBodyDataTextChunkListPos> Pos { get; set; }
                public class RecallDocumentResponseBodyDataTextChunkListPos : TeaModel {
                    /// <summary>
                    /// <para>Coordinates.</para>
                    /// </summary>
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    /// <summary>
                    /// <para>Page number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    /// <summary>
                    /// <para>Text highlight area, used for text-type file highlighting.</para>
                    /// </summary>
                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                /// <summary>
                /// <para>Previous document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>89473868346</para>
                /// </summary>
                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>Document title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档标题</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Text search time elapsed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("textSearchElapsedMs")]
            [Validation(Required=false)]
            public long? TextSearchElapsedMs { get; set; }

            /// <summary>
            /// <para>Total time elapsed, including vector computation time, vector search time, and text search time (depending on retrieval parameters).</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("totalElapsedMs")]
            [Validation(Required=false)]
            public long? TotalElapsedMs { get; set; }

            /// <summary>
            /// <para>List of chunks retrieved from the vector index.</para>
            /// </summary>
            [NameInMap("vectorChunkList")]
            [Validation(Required=false)]
            public List<RecallDocumentResponseBodyDataVectorChunkList> VectorChunkList { get; set; }
            public class RecallDocumentResponseBodyDataVectorChunkList : TeaModel {
                /// <summary>
                /// <para>Document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8723642345276</para>
                /// </summary>
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;:&quot;1&quot;}</para>
                /// </summary>
                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                /// <summary>
                /// <para>Document chunk OSS address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oss-xxxx-hangzhou.com/test.pdf">https://oss-xxxx-hangzhou.com/test.pdf</a></para>
                /// </summary>
                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                /// <summary>
                /// <para>Document chunk text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一段测试文本</para>
                /// </summary>
                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                /// <summary>
                /// <para>Document chunk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                /// <summary>
                /// <para>Document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>78326476235675372</para>
                /// </summary>
                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>Document type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>Document library ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>djsgfsjd</para>
                /// </summary>
                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                /// <summary>
                /// <para>Document library name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档库</para>
                /// </summary>
                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                /// <summary>
                /// <para>Next document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>293846872343</para>
                /// </summary>
                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk position.</para>
                /// </summary>
                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<RecallDocumentResponseBodyDataVectorChunkListPos> Pos { get; set; }
                public class RecallDocumentResponseBodyDataVectorChunkListPos : TeaModel {
                    /// <summary>
                    /// <para>Coordinates.</para>
                    /// </summary>
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    /// <summary>
                    /// <para>Page number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    /// <summary>
                    /// <para>Text highlight area, used for text-type file highlighting.</para>
                    /// </summary>
                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                /// <summary>
                /// <para>Previous document chunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>873647326542</para>
                /// </summary>
                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                /// <summary>
                /// <para>Document chunk score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>Document title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Vector search time elapsed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("vectorSearchElapsedMs")]
            [Validation(Required=false)]
            public long? VectorSearchElapsedMs { get; set; }

        }

        /// <summary>
        /// <para>Data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc13a9517168617617186457e401f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
