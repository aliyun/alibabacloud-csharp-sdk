// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAssetResponseBody : TeaModel {
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
        /// <para>The asset management properties, original file name, source, number of chunks, metadata, asset-level chunking configuration snapshot, and the current status, lastError, and publishedResultAvailable. This does not include chunkUpdate or clientToken.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAssetResponseBodyData Data { get; set; }
        public class GetAssetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The stable ID of the asset. You can specify this ID when creating an asset. If assetId is not specified but clientToken is provided, the platform stably derives the ID based on the resource scope and clientToken. If neither is provided, a new asset is created for each request. Setting overwrite=true registers a new upload session for the same asset, and the previously published version remains in use until the new result is published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asset-001</para>
            /// </summary>
            [NameInMap("assetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The effective chunking configuration used for processing this asset. Explicitly uploaded configurations take precedence over the knowledge base default values. Subsequent modifications to the knowledge base configuration do not change this snapshot.</para>
            /// </summary>
            [NameInMap("chunkConfiguration")]
            [Validation(Required=false)]
            public GetAssetResponseBodyDataChunkConfiguration ChunkConfiguration { get; set; }
            public class GetAssetResponseBodyDataChunkConfiguration : TeaModel {
                /// <summary>
                /// <para>Required when the strategy is BY_HEADING. The value ranges from 1 to 6. Headings at or above this level are used as boundaries. Deeper headings are retained in the body text. Overlong sections fall back to paragraph or sentence splitting. Documents without headings fall back to intelligent splitting. This parameter is ignored for other strategies and is validated by the backend based on the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("headingLevel")]
                [Validation(Required=false)]
                public int? HeadingLevel { get; set; }

                /// <summary>
                /// <para>The value ranges from 1 to 6000 characters. It follows the character length metric of EB and is not the number of tokens. If omitted, the server-side default value is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("maxChunkSize")]
                [Validation(Required=false)]
                public int? MaxChunkSize { get; set; }

                /// <summary>
                /// <para>Effective only when the strategy is BY_LENGTH. The unit is characters, and the default value is 0. The valid value must be greater than or equal to 0 and less than the effective maxChunkSize. The total length after overlapping must not exceed the maximum chunk size. This parameter is ignored for other strategies and is validated by the backend based on the strategy.</para>
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
                public GetAssetResponseBodyDataChunkConfigurationPreprocessRules PreprocessRules { get; set; }
                public class GetAssetResponseBodyDataChunkConfigurationPreprocessRules : TeaModel {
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
                /// <para>Required and non-empty when the strategy is BY_SEPARATOR. It matches the literal string as a whole and does not use regular expressions. This parameter is ignored for other strategies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\n\n</para>
                /// </summary>
                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <para>The saved chunking strategy. AUTO indicates automatic chunking, and BY_SEPARATOR indicates chunking by separator. BY_LENGTH and BY_HEADING are returned only for backward compatibility with historical configurations. Only AUTO and BY_SEPARATOR are accepted when creating or updating configurations in the current phase.</para>
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
            /// <para>The total number of chunks in the currently published result. This value is 0 before the first publication. During re-chunking or editing, it still counts the published result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("chunkCount")]
            [Validation(Required=false)]
            public int? ChunkCount { get; set; }

            /// <summary>
            /// <para>The MIME type of the uploaded original file for this asset.</para>
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
            /// <para>Specifies whether the asset is enabled. If disabled, the asset is excluded from regular viewing, retrieval, and downloading. Management APIs remain subject to management permissions.</para>
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
            /// <para>The ID of the knowledge base to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-001</para>
            /// </summary>
            [NameInMap("knowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The redacted error of the current upload or processing. It does not contain internal credentials, paths, or run identifiers.</para>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public GetAssetResponseBodyDataLastError LastError { get; set; }
            public class GetAssetResponseBodyDataLastError : TeaModel {
                /// <summary>
                /// <para>The stable product error code. It does not return internal task identifiers, stacks, or storage addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ProcessingFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The redacted error summary that can be displayed to users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>File parsing failed</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The complete list of effective metadata key-value pairs, including constants and system variable results. Patches involving retrieval projection do not overwrite old effective values before the new result is published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;key&quot;:&quot;department&quot;,&quot;value&quot;:&quot;engineering&quot;}]</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public List<GetAssetResponseBodyDataMetadata> Metadata { get; set; }
            public class GetAssetResponseBodyDataMetadata : TeaModel {
                /// <summary>
                /// <para>The field name declared in metadataSchema. It must not be duplicated in the same request. Fixed value and system variable fields are generated by the server and do not accept customer overrides.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The string parsed according to the schema type. If omitted or null during upload, no value is assigned and the value is populated by the schema. In the UpdateAsset operation, omitting the field, specifying a null value, or providing an empty string deletes the key. Unsubmitted keys remain unchanged. The DATETIME type accepts ISO 8601 with a time zone, yyyy-MM-dd HH:mm:ss, or yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>engineering</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The default name is the uploaded file name. You can modify the display name by calling UpdateAsset.</para>
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
            /// <para>The import channel of the asset, such as UPLOAD or OSS. This is recorded by the platform based on the trusted access path and is not used to grant access permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOAD</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The URI of the original source. This is used only for tracing. It does not grant download authorization and does not trigger server-side fetching.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://source-bucket/path/guide.pdf</para>
            /// </summary>
            [NameInMap("sourceUri")]
            [Validation(Required=false)]
            public string SourceUri { get; set; }

            /// <summary>
            /// <para>The current upload or processing status of the document. Upload, rebuild, and chunk body editing are all polled through GetAsset. PENDING indicates waiting for processing, PROCESSING indicates processing in progress, COMPLETED indicates that publication is finished, and FAILED indicates final failure and returns lastError. This does not represent the result of a specific historical request. No readable result is available if the first processing fails. During overwrite upload, rebuild, or editing, and after failure, the published result remains readable if the enabled and deletion statuses allow it.</para>
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
        /// <para>The actual HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the redacted result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
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
