// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetDocumentChunkListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDocumentChunkListResponseBodyData Data { get; set; }
        public class GetDocumentChunkListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetDocumentChunkListResponseBodyDataRecords> Records { get; set; }
            public class GetDocumentChunkListResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>28377468263482764</para>
                /// </summary>
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;:&quot;1&quot;}</para>
                /// </summary>
                [NameInMap("chunkMeta")]
                [Validation(Required=false)]
                public Dictionary<string, object> ChunkMeta { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss-xxxx-hangzhou.com/test.pdf</para>
                /// </summary>
                [NameInMap("chunkOssUrl")]
                [Validation(Required=false)]
                public string ChunkOssUrl { get; set; }

                [NameInMap("chunkText")]
                [Validation(Required=false)]
                public string ChunkText { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("chunkType")]
                [Validation(Required=false)]
                public string ChunkType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8947387648356</para>
                /// </summary>
                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>jhsdvne</para>
                /// </summary>
                [NameInMap("libraryId")]
                [Validation(Required=false)]
                public string LibraryId { get; set; }

                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>947538465</para>
                /// </summary>
                [NameInMap("nextChunkId")]
                [Validation(Required=false)]
                public string NextChunkId { get; set; }

                [NameInMap("pos")]
                [Validation(Required=false)]
                public List<GetDocumentChunkListResponseBodyDataRecordsPos> Pos { get; set; }
                public class GetDocumentChunkListResponseBodyDataRecordsPos : TeaModel {
                    [NameInMap("axisArray")]
                    [Validation(Required=false)]
                    public List<double?> AxisArray { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    [NameInMap("textHighlightArea")]
                    [Validation(Required=false)]
                    public List<int?> TextHighlightArea { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9848346548365</para>
                /// </summary>
                [NameInMap("preChunkId")]
                [Validation(Required=false)]
                public string PreChunkId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2B8F6DC9-6FAF-576F-9095-CCD90FB2BDDF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
