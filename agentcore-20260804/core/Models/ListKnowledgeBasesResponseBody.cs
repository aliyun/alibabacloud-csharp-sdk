// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListKnowledgeBasesResponseBody : TeaModel {
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
        /// <para>The list of knowledge bases returned on the current page.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListKnowledgeBasesResponseBodyItems> Items { get; set; }
        public class ListKnowledgeBasesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The valid configuration with parsed default values. It only affects subsequently uploaded or explicitly reprocessed assets.</para>
            /// </summary>
            [NameInMap("chunkConfiguration")]
            [Validation(Required=false)]
            public ListKnowledgeBasesResponseBodyItemsChunkConfiguration ChunkConfiguration { get; set; }
            public class ListKnowledgeBasesResponseBodyItemsChunkConfiguration : TeaModel {
                /// <summary>
                /// <para>Required when the strategy is BY_HEADING. Valid values: 1 to 6. Headings at or above this level are used as boundaries. Deeper headings are retained in the body text. Overlong sections fall back to paragraph or sentence splitting. Documents without headings fall back to intelligent splitting. Ignored for other strategies and validated by the backend based on the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("headingLevel")]
                [Validation(Required=false)]
                public int? HeadingLevel { get; set; }

                /// <summary>
                /// <para>The maximum chunk size, ranging from 1 to 6,000 characters. It follows the character length metric of EB and is not the token count. If omitted, the server-side default value is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("maxChunkSize")]
                [Validation(Required=false)]
                public int? MaxChunkSize { get; set; }

                /// <summary>
                /// <para>The overlap size in characters. It takes effect only when the strategy is BY_LENGTH. Default value: 0. The valid value must be greater than or equal to 0 and less than the valid maxChunkSize. The total length after overlapping must not exceed the maximum chunk size. Ignored for other strategies and validated by the backend based on the strategy.</para>
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
                public ListKnowledgeBasesResponseBodyItemsChunkConfigurationPreprocessRules PreprocessRules { get; set; }
                public class ListKnowledgeBasesResponseBodyItemsChunkConfigurationPreprocessRules : TeaModel {
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
                /// <para>Required and non-empty when the strategy is BY_SEPARATOR. It matches the literal string as a whole without using regular expressions. Ignored for other strategies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\n\n</para>
                /// </summary>
                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <para>The saved chunking strategy. Valid values: AUTO (automatic chunking) and BY_SEPARATOR (separator-based chunking). BY_LENGTH and BY_HEADING are returned only for backward compatibility with historical configurations. Only AUTO and BY_SEPARATOR are accepted when you create or update a configuration in the first phase.</para>
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
            /// <para>The effective vector dimensions. Default value: 1024. It cannot be modified after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("embeddingDimension")]
            [Validation(Required=false)]
            public int? EmbeddingDimension { get; set; }

            /// <summary>
            /// <para>The effective model name. It cannot be modified after creation. Default value: text-embedding-v4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v4</para>
            /// </summary>
            [NameInMap("embeddingModel")]
            [Validation(Required=false)]
            public string EmbeddingModel { get; set; }

            /// <summary>
            /// <para>The stable knowledge base ID generated by the platform. It is persistently bound to the tenantId and workspaceId. Queries and modifications must verify all three identifiers simultaneously. Access based solely on the ID is not allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-001</para>
            /// </summary>
            [NameInMap("knowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The desensitized error summary when a lifecycle operation fails.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public ListKnowledgeBasesResponseBodyItemsLastError LastError { get; set; }
            public class ListKnowledgeBasesResponseBodyItemsLastError : TeaModel {
                /// <summary>
                /// <para>The stable product error code. Internal task identifiers, stacks, or storage addresses are not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ProcessingFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The desensitized error summary that can be displayed to users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>File parsing failed</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The metadata schema. It is determined upon creation and cannot be modified afterward. It includes constant or system variable configurations.</para>
            /// </summary>
            [NameInMap("metadataSchema")]
            [Validation(Required=false)]
            public List<ListKnowledgeBasesResponseBodyItemsMetadataSchema> MetadataSchema { get; set; }
            public class ListKnowledgeBasesResponseBodyItemsMetadataSchema : TeaModel {
                /// <summary>
                /// <para>The name of the metadata field for the knowledge base in the workspace. It must be unique within the same schema and cannot occupy system control fields.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The field type. Valid values: STRING, LONG, DOUBLE, BOOLEAN, and DATETIME. Uploaded and updated string values are parsed by the backend according to this type. Nested objects are not accepted.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The fixed value or system variable name. The following variables are retained: DOCUMENT_NAME, FILE_TYPE, FILE_SIZE, DOCUMENT_UPLOAD_TIME, SOURCE_TYPE, SOURCE_URI, and SOURCE_MODIFIED_TIME. DOCUMENT_* refers to the original asset in this operation, and the variable names are retained for EB compatibility.</para>
                /// 
                /// <b>Example:</b>
                /// <para>engineering</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The value mode. CONSTANT indicates a constant: a fixed value is used if the value is not empty, and the value is assigned during upload if not configured. SYSTEM_VARIABLE indicates a system-generated value that cannot be overwritten by customers. The mode cannot be modified after the schema is created.</para>
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
            /// <para>The region where the knowledge base is located. It is consistent with the workspace to which it belongs and is maintained by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The valid search configuration with parsed platform default values. It can be overridden by a single search request.</para>
            /// </summary>
            [NameInMap("searchConfiguration")]
            [Validation(Required=false)]
            public ListKnowledgeBasesResponseBodyItemsSearchConfiguration SearchConfiguration { get; set; }
            public class ListKnowledgeBasesResponseBodyItemsSearchConfiguration : TeaModel {
                /// <summary>
                /// <para>The retrieve mode. Valid values: KEYWORD (keyword retrieve), VECTOR (vector retrieve), and HYBRID (hybrid retrieve). The request configuration takes precedence over the knowledge base configuration. If neither is configured, HYBRID is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HYBRID</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The ranking algorithm. Valid values: RRF (reciprocal rank fusion) and WEIGHTED (weighted normalization fusion). It takes effect only in HYBRID mode. Default value: RRF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RRF</para>
                /// </summary>
                [NameInMap("rankAlgorithm")]
                [Validation(Required=false)]
                public string RankAlgorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether reranking is enabled by default. It applies to all three search modes. An explicit specification in the request overrides this configuration. If neither is configured, the value is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("rerankEnabled")]
                [Validation(Required=false)]
                public bool? RerankEnabled { get; set; }

                /// <summary>
                /// <para>Specifies the rerank model. Valid values: qwen3-rerank, qwen3.7-text-rerank, gte-rerank-v2, and qwen3-vl-rerank. The request parameter takes precedence over this configuration. If neither is specified, qwen3-rerank is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-rerank</para>
                /// </summary>
                [NameInMap("rerankModel")]
                [Validation(Required=false)]
                public string RerankModel { get; set; }

                /// <summary>
                /// <para>The k parameter for RRF. Default value: 60. The value must be greater than 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("rrfK")]
                [Validation(Required=false)]
                public int? RrfK { get; set; }

                /// <summary>
                /// <para>The maximum number of results to return. Maximum value: 100. The request configuration takes precedence over the knowledge base configuration. If neither is configured, 10 is used. The actual number of results may be less than this value after permission and release version filtering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

                /// <summary>
                /// <para>The vector path weight for WEIGHTED. Default value: 0.7. The keyword path weight is 1 minus this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7</para>
                /// </summary>
                [NameInMap("vectorWeight")]
                [Validation(Required=false)]
                public double? VectorWeight { get; set; }

            }

            /// <summary>
            /// <para>The lifecycle status. You can query the creation progress by using GetKnowledgeBase and ListKnowledgeBases. Valid values: Creating (creation in progress), Active (creation successful), and CreateFailed (creation failed). A deletion acceptance response may return Deleting, DeleteFailed, or Deleted. After deletion is accepted, GetKnowledgeBase indicates that the resource does not exist, ListKnowledgeBases no longer displays the resource, and the backend continues cleanup. For the cause of a creation failure, refer to lastError.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The read-only tenant ownership. It is resolved by Magic based on the trusted gateway call identity and bound during creation. It matches the tenant of the associated workspace. Client-specified values or modifications are not accepted.</para>
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
        /// <para>The token used to retrieve the next page of results. Pass the nextToken value from the previous response as is to continue pagination. If the value is empty, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// <para>The total number of knowledge bases in the current workspace. Pagination ends when nextToken is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
