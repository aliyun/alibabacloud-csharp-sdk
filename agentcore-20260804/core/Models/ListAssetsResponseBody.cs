// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAssetsResponseBody : TeaModel {
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
        /// <para>The asset details on the current page, sorted in descending order by the latest upload acceptance time and assetId. Asynchronous index updates may cause brief sorting delays after new uploads or overwrites.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAssetsResponseBodyItems> Items { get; set; }
        public class ListAssetsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The stable ID of the asset. You can specify this ID when creating an asset. If assetId is not specified but clientToken is provided, the platform stably derives the ID based on the resource scope and clientToken. If neither is provided, a new asset is created for each request. Setting overwrite=true allows you to register a new upload session for the same asset, and the previously published version continues to be used until the new result is published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asset-001</para>
            /// </summary>
            [NameInMap("assetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The effective chunk configuration used for the current asset processing. Explicitly uploaded configurations take precedence over the default values of the knowledge base. Subsequent modifications to the knowledge base configuration do not change this snapshot.</para>
            /// </summary>
            [NameInMap("chunkConfiguration")]
            [Validation(Required=false)]
            public ListAssetsResponseBodyItemsChunkConfiguration ChunkConfiguration { get; set; }
            public class ListAssetsResponseBodyItemsChunkConfiguration : TeaModel {
                /// <summary>
                /// <para>This parameter is required when the strategy is BY_HEADING, and the value ranges from 1 to 6. Headings at or above this level are used as boundaries. Deeper headings are retained in the body text. Overlong sections fall back to paragraph or sentence splitting. Documents without headings fall back to intelligent splitting. This parameter is ignored for other strategies and is validated by the backend based on the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("headingLevel")]
                [Validation(Required=false)]
                public int? HeadingLevel { get; set; }

                /// <summary>
                /// <para>The value ranges from 1 to 6000 characters, following the character length standard of EB, not the number of tokens. If this parameter is omitted, the server-side default value is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("maxChunkSize")]
                [Validation(Required=false)]
                public int? MaxChunkSize { get; set; }

                /// <summary>
                /// <para>This parameter takes effect only when the strategy is BY_LENGTH. The unit is characters, and the default value is 0. The valid value must be greater than or equal to 0 and less than the valid maxChunkSize, ensuring that the length does not exceed the maximum chunk length after overlapping. This parameter is ignored for other strategies and is validated by the backend based on the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("overlapSize")]
                [Validation(Required=false)]
                public int? OverlapSize { get; set; }

                /// <summary>
                /// <para>The text preprocessing rules applied before splitting.</para>
                /// </summary>
                [NameInMap("preprocessRules")]
                [Validation(Required=false)]
                public ListAssetsResponseBodyItemsChunkConfigurationPreprocessRules PreprocessRules { get; set; }
                public class ListAssetsResponseBodyItemsChunkConfigurationPreprocessRules : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to remove URLs and email addresses during parsing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("removeUrlsAndEmails")]
                    [Validation(Required=false)]
                    public bool? RemoveUrlsAndEmails { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to replace consecutive spaces, line breaks, and tabs with a single space.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("replaceConsecutiveWhitespace")]
                    [Validation(Required=false)]
                    public bool? ReplaceConsecutiveWhitespace { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required and cannot be empty when the strategy is BY_SEPARATOR. It matches the entire literal string without using regular expressions. This parameter is ignored for other strategies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\n\n</para>
                /// </summary>
                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <para>The saved chunking strategy. AUTO indicates automatic chunking, and BY_SEPARATOR indicates chunking by separator. BY_LENGTH and BY_HEADING are returned only for backward compatibility with historical configurations. Only AUTO and BY_SEPARATOR are accepted when creating or updating configurations in the first phase.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AUTO</para>
                /// </summary>
                [NameInMap("strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

            /// <summary>
            /// <para>The total number of chunks in the currently published result. This value is 0 before the first publication. During re-chunking or editing, the count still reflects the published result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("chunkCount")]
            [Validation(Required=false)]
            public int? ChunkCount { get; set; }

            /// <summary>
            /// <para>The MIME type of the uploaded original file for the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/pdf</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The creation time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>If disabled, the asset does not participate in regular viewing, retrieval, and downloading. Management APIs are still subject to administrative permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The file name of the currently uploaded original file. Modifying the display name does not change this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guide.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The knowledge base to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-001</para>
            /// </summary>
            [NameInMap("knowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The masked error of the current upload or processing. This error does not contain internal credentials, paths, or run IDs.</para>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public ListAssetsResponseBodyItemsLastError LastError { get; set; }
            public class ListAssetsResponseBodyItemsLastError : TeaModel {
                /// <summary>
                /// <para>The stable product error code. This code does not return internal task IDs, stacks, or storage addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ProcessingFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The masked error summary that can be displayed to users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>File parsing failed</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The complete list of effective metadata key-value pairs, including constants and system variable results. Patches involving retrieval projections do not overwrite previous effective values until new results are published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;key&quot;:&quot;department&quot;,&quot;value&quot;:&quot;engineering&quot;}]</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public List<ListAssetsResponseBodyItemsMetadata> Metadata { get; set; }
            public class ListAssetsResponseBodyItemsMetadata : TeaModel {
                /// <summary>
                /// <para>The field name declared in metadataSchema. It must not be duplicated within the same request. Fixed values and system variable fields are generated by the server and cannot be overwritten by the client.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The string parsed according to the schema type. If omitted or left empty during upload, it indicates that no value is assigned and the schema populates the value. In UpdateAsset, omitting the field, setting it to null, or providing an empty string deletes the key, while unsubmitted keys remain unchanged. For DATETIME, ISO 8601 with a time zone, yyyy-MM-dd HH:mm:ss, or yyyy-MM-dd is accepted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>engineering</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The default value is the uploaded file name. You can call the UpdateAsset operation to modify the display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guide.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the published result is available. The value is true if a published version exists and the asset is neither disabled nor deleted. The value may still be true if re-chunking or editing fails, and is false if the first processing fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("publishedResultAvailable")]
            [Validation(Required=false)]
            public bool? PublishedResultAvailable { get; set; }

            /// <summary>
            /// <para>The size of the current original file in bytes. This value is not returned before the upload is confirmed. After confirmation, the actual size verified by the OSS HEAD request is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102400</para>
            /// </summary>
            [NameInMap("sizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            /// <summary>
            /// <para>The last modification time of the source file in UTC epoch milliseconds. This value is not returned if it is not provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1793066400000</para>
            /// </summary>
            [NameInMap("sourceModifiedTime")]
            [Validation(Required=false)]
            public long? SourceModifiedTime { get; set; }

            /// <summary>
            /// <para>The import channel of the asset, such as UPLOAD or OSS. This value is recorded by the platform based on the trusted access path and is not used to grant access permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOAD</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The URI of the original file source. This value is used only for tracing, does not authorize downloads, and does not trigger server-side fetching.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://source-bucket/path/guide.pdf</para>
            /// </summary>
            [NameInMap("sourceUri")]
            [Validation(Required=false)]
            public string SourceUri { get; set; }

            /// <summary>
            /// <para>The current upload or processing status of the document. Uploads, rebuilds, and chunk body edits are polled by using the GetAsset operation. PENDING indicates waiting for processing, PROCESSING indicates processing, COMPLETED indicates that the publication is complete, and FAILED indicates a final failure and returns lastError. This status does not represent the result of a specific historical request. No readable result is available if the first processing fails. During overwrite uploads, rebuilds, or edits, and after failures, the published result remains readable if the enabled and deletion statuses allow it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROCESSING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The creation time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-001</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

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
        /// <para>The description of the masked result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pass this value as is to continue pagination. If this value is empty, pagination ends. Do not use totalCount to determine the next page. Cross-page snapshots are not guaranteed during concurrent uploads, overwrites, deletions, or status changes.</para>
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
        /// <para>The count of undeleted assets that meet the file name prefix and status filter conditions of the current request. This count is cached for 60 seconds based on the resource scope and filter conditions, and may be briefly stale. The first request after a cold cache or expiration synchronously scans the count. Concurrent scans do not guarantee transactional snapshots or exact consistency with the current page, and cannot be used for quota verification or determining the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
