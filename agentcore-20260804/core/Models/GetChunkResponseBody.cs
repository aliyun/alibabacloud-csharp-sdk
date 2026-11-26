// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetChunkResponseBody : TeaModel {
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
        /// <para>The details of the chunk with the specified sequence number in the currently published generation of the asset.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetChunkResponseBodyData Data { get; set; }
        public class GetChunkResponseBodyData : TeaModel {
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
            /// <para>The 1-based logical sequence number within the published asset. Re-chunking may change the sequence number. You must pass back the chunkToken of this item when editing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("chunkSeq")]
            [Validation(Required=false)]
            public int? ChunkSeq { get; set; }

            /// <summary>
            /// <para>The number of UTF-16 code units in the chunk content, using the same ChunkSize metric as EB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("chunkSize")]
            [Validation(Required=false)]
            public int? ChunkSize { get; set; }

            /// <summary>
            /// <para>An opaque token that must be passed back as-is during updates. It is verified against the current published result at the beginning of the request, and an error is reported if it has expired. After a pure enable or disable operation starts, it does not follow new results from concurrent publishing. Do not parse or generate it manually.</para>
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
            /// <para>The time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Disabled chunks do not participate in retrieval. Administrative permissions are still required for chunk O&amp;M queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The name of the original file corresponding to the published chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guide.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>Uses the EB location format, such as p.3 for PDF, s.2 for PPT, or the worksheet name for spreadsheets. The old location is not returned when manual editing invalidates the mapping.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p.3</para>
            /// </summary>
            [NameInMap("sourceLocation")]
            [Validation(Required=false)]
            public string SourceLocation { get; set; }

            /// <summary>
            /// <para>The hierarchical title path where the chunk is located. This field is not returned if the location cannot be determined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product Guide &gt; Configuration</para>
            /// </summary>
            [NameInMap("titlePath")]
            [Validation(Required=false)]
            public string TitlePath { get; set; }

            /// <summary>
            /// <para>The time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

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
        /// <para>The description of the data masking result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

    }

}
