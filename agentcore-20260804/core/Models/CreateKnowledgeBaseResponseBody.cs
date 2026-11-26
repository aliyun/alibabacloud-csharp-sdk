// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateKnowledgeBaseResponseBody : TeaModel {
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
        /// <para>The details of the knowledge base that has entered the creation process, including the tenant ownership, status, and lastError. You can call the GetKnowledgeBase or ListKnowledgeBases operation to query the creation result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseResponseBodyData Data { get; set; }
        public class CreateKnowledgeBaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The valid configuration with parsed default values. It only affects subsequently newly uploaded or explicitly reprocessed assets.</para>
            /// </summary>
            [NameInMap("chunkConfiguration")]
            [Validation(Required=false)]
            public CreateKnowledgeBaseResponseBodyDataChunkConfiguration ChunkConfiguration { get; set; }
            public class CreateKnowledgeBaseResponseBodyDataChunkConfiguration : TeaModel {
                /// <summary>
                /// <para>Required when the strategy is BY_HEADING, and the value ranges from 1 to 6. Headings at or below this level are used as boundaries. Deeper headings are retained in the body text. Overlong sections fall back to paragraphs or sentences, and documents without headings fall back to intelligent chunking. Ignored for other strategies and verified by the backend according to the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("headingLevel")]
                [Validation(Required=false)]
                public int? HeadingLevel { get; set; }

                /// <summary>
                /// <para>1 to 6000 characters. It follows the character length metric of EB and is not the number of tokens. If omitted, the server-side default value is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("maxChunkSize")]
                [Validation(Required=false)]
                public int? MaxChunkSize { get; set; }

                /// <summary>
                /// <para>Takes effect only when the strategy is BY_LENGTH. The unit is characters, and the default value is 0. The valid value must be greater than or equal to 0 and less than the valid maxChunkSize, and the length after overlapping must not exceed the maximum chunk size. Ignored for other strategies and verified by the backend according to the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("overlapSize")]
                [Validation(Required=false)]
                public int? OverlapSize { get; set; }

                /// <summary>
                /// <para>The text preprocessing rules before chunking.</para>
                /// </summary>
                [NameInMap("preprocessRules")]
                [Validation(Required=false)]
                public CreateKnowledgeBaseResponseBodyDataChunkConfigurationPreprocessRules PreprocessRules { get; set; }
                public class CreateKnowledgeBaseResponseBodyDataChunkConfigurationPreprocessRules : TeaModel {
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
                /// <para>Required and non-empty when the strategy is BY_SEPARATOR. It matches the literal string as a whole and does not use regular expressions. Ignored for other strategies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\n\n</para>
                /// </summary>
                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <para>Returns the saved chunking strategy. AUTO indicates automatic chunking, and BY_SEPARATOR indicates chunking by separator. BY_LENGTH and BY_HEADING are returned only for compatibility with historical configurations. When creating or updating a configuration, only AUTO and BY_SEPARATOR are accepted in the first phase.</para>
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
            /// <para>The time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product documentation</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The actual effective vector dimensions. Default value: 1024. It cannot be modified after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("embeddingDimension")]
            [Validation(Required=false)]
            public int? EmbeddingDimension { get; set; }

            /// <summary>
            /// <para>The actual effective model name. It cannot be modified after creation. Default value: text-embedding-v4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v4</para>
            /// </summary>
            [NameInMap("embeddingModel")]
            [Validation(Required=false)]
            public string EmbeddingModel { get; set; }

            /// <summary>
            /// <para>The stable knowledge base ID generated by the platform, which is persistently bound to the tenantId and workspaceId. Queries and modifications must verify all three identifiers simultaneously. Access based solely on the ID is not allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-001</para>
            /// </summary>
            [NameInMap("knowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The sanitized error summary when a lifecycle operation fails.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public CreateKnowledgeBaseResponseBodyDataLastError LastError { get; set; }
            public class CreateKnowledgeBaseResponseBodyDataLastError : TeaModel {
                /// <summary>
                /// <para>The stable product error code. It does not include internal task identifiers, stack traces, or storage addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ProcessingFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The sanitized error summary that can be displayed to users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>File parsing failed</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The metadata schema is determined during creation and cannot be modified afterward. It contains configurations for constants or system variables.</para>
            /// </summary>
            [NameInMap("metadataSchema")]
            [Validation(Required=false)]
            public List<CreateKnowledgeBaseResponseBodyDataMetadataSchema> MetadataSchema { get; set; }
            public class CreateKnowledgeBaseResponseBodyDataMetadataSchema : TeaModel {
                /// <summary>
                /// <para>The metadata field name of the knowledge base within the workspace. It must be unique within the same schema and cannot occupy system control fields.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>STRING, LONG, DOUBLE, BOOLEAN, or DATETIME. Uploaded and updated string values are parsed by the backend according to this type. Nested objects are not accepted.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The fixed value or system variable name. The following variables are retained: DOCUMENT_NAME, FILE_TYPE, FILE_SIZE, DOCUMENT_UPLOAD_TIME, SOURCE_TYPE, SOURCE_URI, and SOURCE_MODIFIED_TIME. DOCUMENT_* refers to the original asset in this operation, and the variable names retain EB compatibility.</para>
                /// 
                /// <b>Example:</b>
                /// <para>engineering</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>CONSTANT indicates a constant. If the value is not empty, the system uses a fixed value. If no value is configured, the system assigns the value during upload. SYSTEM_VARIABLE indicates that the system generates the value and customers cannot overwrite it. You cannot modify the schema after creation.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONSTANT</para>
                /// </summary>
                [NameInMap("valueMode")]
                [Validation(Required=false)]
                public string ValueMode { get; set; }

            }

            /// <summary>
            /// <para>The display name of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product-docs</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region where the knowledge base is located. This region is the same as that of the associated workspace and is maintained by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The valid search configuration with parsed platform default values, which can be overridden by a single search request.</para>
            /// </summary>
            [NameInMap("searchConfiguration")]
            [Validation(Required=false)]
            public CreateKnowledgeBaseResponseBodyDataSearchConfiguration SearchConfiguration { get; set; }
            public class CreateKnowledgeBaseResponseBodyDataSearchConfiguration : TeaModel {
                /// <summary>
                /// <para>KEYWORD indicates keyword retrieve, VECTOR indicates AISearch, and HYBRID indicates hybrid retrieve. The request configuration takes precedence over the knowledge base configuration. If neither is configured, HYBRID is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HYBRID</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The rank fusion algorithm. RRF indicates reciprocal rank fusion, and WEIGHTED indicates weighted normalization fusion. This parameter takes effect only when the search mode is HYBRID. The default value is RRF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RRF</para>
                /// </summary>
                [NameInMap("rankAlgorithm")]
                [Validation(Required=false)]
                public string RankAlgorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable reranking by default. This parameter applies to all three search modes. The request parameter takes precedence over this configuration. If neither is configured, the default value is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("rerankEnabled")]
                [Validation(Required=false)]
                public bool? RerankEnabled { get; set; }

                /// <summary>
                /// <para>The reranking model. Supported models include qwen3-rerank, qwen3.7-text-rerank, gte-rerank-v2, and qwen3-vl-rerank. The request parameter takes precedence over this configuration. If neither is configured, qwen3-rerank is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-rerank</para>
                /// </summary>
                [NameInMap("rerankModel")]
                [Validation(Required=false)]
                public string RerankModel { get; set; }

                /// <summary>
                /// <para>The k parameter for RRF. The default value is 60. The value must be greater than 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("rrfK")]
                [Validation(Required=false)]
                public int? RrfK { get; set; }

                /// <summary>
                /// <para>The default number of results to return. A maximum of 100 results can be returned. The request parameter takes precedence over the knowledge base configuration. If neither is configured, 10 is used. The actual number of returned results may be less than this value after filtering by permissions and published versions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

                /// <summary>
                /// <para>The vector path weight for WEIGHTED. The default value is 0.7. The keyword path weight is 1 minus this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7</para>
                /// </summary>
                [NameInMap("vectorWeight")]
                [Validation(Required=false)]
                public double? VectorWeight { get; set; }

            }

            /// <summary>
            /// <para>You can call the GetKnowledgeBase and ListKnowledgeBases operations to query the creation progress. Creating indicates that the creation is in progress, Active indicates that the creation is successful, and CreateFailed indicates that the creation failed. The deletion acceptance response may return Deleting, DeleteFailed, or Deleted. After the deletion is accepted, GetKnowledgeBase returns that the resource does not exist, and ListKnowledgeBases no longer displays the resource while the backend continues to clean it up. For the cause of a creation failure, see lastError.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The read-only tenant ownership. It is resolved by Magic based on the trusted gateway call identity and bound during creation, which is consistent with the tenant of the workspace to which it belongs. Client-specified or modified values are not accepted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The AgentCore workspace to which the resource belongs.</para>
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
        /// <para>The description of the data masking result.</para>
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
