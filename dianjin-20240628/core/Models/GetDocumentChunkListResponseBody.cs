// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetDocumentChunkListResponseBody : TeaModel {
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDocumentChunkListResponseBodyData Data { get; set; }
        public class GetDocumentChunkListResponseBodyData : TeaModel {
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetDocumentChunkListResponseBodyDataRecords> Records { get; set; }
            public class GetDocumentChunkListResponseBodyDataRecords : TeaModel {
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
                public List<GetDocumentChunkListResponseBodyDataRecordsPos> Pos { get; set; }
                public class GetDocumentChunkListResponseBodyDataRecordsPos : TeaModel {
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

            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

            [NameInMap("totalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

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
