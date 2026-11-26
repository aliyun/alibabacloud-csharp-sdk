// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListChunksResponseBody : TeaModel {
        /// <summary>
        /// <para>The stable result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The actual HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The currently published chunks. Chunks within a single asset are sorted by chunkSeq. Chunks across assets are sorted by assetId and chunkSeq.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListChunksResponseBodyItems> Items { get; set; }
        public class ListChunksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The asset to which the chunk belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asset-001</para>
            /// </summary>
            [NameInMap("assetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The logical sequence number that starts from 1 within the published asset. Resplitting may change the sequence number. You must pass back the chunkToken of this chunk when you edit it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("chunkSeq")]
            [Validation(Required=false)]
            public int? ChunkSeq { get; set; }

            /// <summary>
            /// <para>The number of UTF-16 code units in the chunk content. This metric follows the EB ChunkSize calculation standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("chunkSize")]
            [Validation(Required=false)]
            public int? ChunkSize { get; set; }

            /// <summary>
            /// <para>The opaque token that must be passed back as is during updates. The token is validated against the current publish result at the beginning of the request. An error is returned if the token has expired. After a pure enable or disable operation starts, the token does not follow new concurrent publish results. Do not parse or generate this token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("chunkToken")]
            [Validation(Required=false)]
            public string ChunkToken { get; set; }

            /// <summary>
            /// <para>The content of the currently published chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Welcome to the product</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The creation time in ISO 8601 format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Indicates whether the chunk is enabled. Disabled chunks are not included in searches. Administrative permissions are still required for chunk O&amp;M queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The name of the source file that corresponds to the published chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guide.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The location in the source file. The format follows the EB positioning convention, such as p.3 for PDF files, s.2 for PPT files, or the worksheet name for spreadsheets. The previous location is not returned if manual editing invalidates the mapping.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p.3</para>
            /// </summary>
            [NameInMap("sourceLocation")]
            [Validation(Required=false)]
            public string SourceLocation { get; set; }

            /// <summary>
            /// <para>The hierarchical heading path where the chunk is located. This parameter is not returned if the location cannot be determined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product Guide &gt; Configuration</para>
            /// </summary>
            [NameInMap("titlePath")]
            [Validation(Required=false)]
            public string TitlePath { get; set; }

            /// <summary>
            /// <para>The update time in ISO 8601 format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The page size used for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The description of the data masking result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page. Pass this value as is in the nextToken parameter of the subsequent request to continue pagination. If this value is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-next-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of chunks that match the filter conditions in the current published generation of the asset. This parameter is returned only when assetId is specified. It is not returned for cross-asset queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
