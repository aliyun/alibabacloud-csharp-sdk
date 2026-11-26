// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>Provide at least one field to be updated. Unprovided fields remain unchanged. You can pass an empty string for the description field to clear the description, or omit it to keep the description unchanged.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseRequestBody Body { get; set; }
        public class UpdateKnowledgeBaseRequestBody : TeaModel {
            /// <summary>
            /// <para>The valid configuration with resolved default values. This configuration affects only subsequently uploaded or explicitly reprocessed assets.</para>
            /// </summary>
            [NameInMap("chunkConfiguration")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseRequestBodyChunkConfiguration ChunkConfiguration { get; set; }
            public class UpdateKnowledgeBaseRequestBodyChunkConfiguration : TeaModel {
                /// <summary>
                /// <para>Required when the strategy is BY_HEADING, with a valid range of 1 to 6. Headings at or above this level are used as boundaries. Deeper headings are retained in the body text. Overlong sections fall back to paragraph or sentence splitting. Documents without headings fall back to intelligent splitting. This parameter is ignored for other strategies and is validated by the backend based on the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("headingLevel")]
                [Validation(Required=false)]
                public int? HeadingLevel { get; set; }

                /// <summary>
                /// <para>The maximum chunk size ranges from 1 to 6,000 characters. This follows the character length metric of EB, not the token count. If omitted, the server-side default value is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("maxChunkSize")]
                [Validation(Required=false)]
                public int? MaxChunkSize { get; set; }

                /// <summary>
                /// <para>Takes effect only when the strategy is BY_LENGTH. The unit is characters, and the default value is 0. The valid value must be greater than or equal to 0 and less than the valid maxChunkSize, ensuring that the chunk size with overlap does not exceed the maximum chunk size. This parameter is ignored for other strategies and is validated by the backend based on the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("overlapSize")]
                [Validation(Required=false)]
                public int? OverlapSize { get; set; }

                /// <summary>
                /// <para>The text preprocessing rules applied before chunking.</para>
                /// </summary>
                [NameInMap("preprocessRules")]
                [Validation(Required=false)]
                public UpdateKnowledgeBaseRequestBodyChunkConfigurationPreprocessRules PreprocessRules { get; set; }
                public class UpdateKnowledgeBaseRequestBodyChunkConfigurationPreprocessRules : TeaModel {
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
                /// <para>Required and non-empty when the strategy is BY_SEPARATOR. The delimiter is matched as a whole literal string without using regular expressions. This parameter is ignored for other strategies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\n\n</para>
                /// </summary>
                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <para>The saved chunking strategy. AUTO indicates automatic chunking, and BY_SEPARATOR indicates delimiter-based chunking. BY_LENGTH and BY_HEADING are returned only for backward compatibility with historical configurations. Only AUTO and BY_SEPARATOR are accepted when creating or updating configurations in the current phase.</para>
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
            /// <para>The description of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product documentation knowledge base</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The updated name of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product-docs-v2</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Updates the default search configuration at the knowledge base level, which takes effect immediately for subsequent search requests. If omitted, the configuration is not modified.</para>
            /// </summary>
            [NameInMap("searchConfiguration")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseRequestBodySearchConfiguration SearchConfiguration { get; set; }
            public class UpdateKnowledgeBaseRequestBodySearchConfiguration : TeaModel {
                /// <summary>
                /// <para>KEYWORD indicates keyword retrieval, VECTOR indicates vector retrieval, and HYBRID indicates hybrid retrieval. The request configuration takes precedence over the knowledge base configuration. If neither is configured, HYBRID is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HYBRID</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>RRF indicates reciprocal rank fusion, and WEIGHTED indicates weighted normalized fusion. This parameter takes effect only in HYBRID mode. The system default is RRF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RRF</para>
                /// </summary>
                [NameInMap("rankAlgorithm")]
                [Validation(Required=false)]
                public string RankAlgorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable reranking. This applies to all three search modes. An explicit specification in the request overrides this configuration. If neither is configured, the value is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("rerankEnabled")]
                [Validation(Required=false)]
                public bool? RerankEnabled { get; set; }

                /// <summary>
                /// <para>Supported models include qwen3-rerank, qwen3.7-text-rerank, gte-rerank-v2, and qwen3-vl-rerank. The request configuration takes precedence over this configuration. If neither is configured, qwen3-rerank is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-rerank</para>
                /// </summary>
                [NameInMap("rerankModel")]
                [Validation(Required=false)]
                public string RerankModel { get; set; }

                /// <summary>
                /// <para>The k parameter for RRF. The system default is 60, and the value must be greater than 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("rrfK")]
                [Validation(Required=false)]
                public int? RrfK { get; set; }

                /// <summary>
                /// <para>The maximum number of results to return is 100. The request configuration takes precedence over the knowledge base configuration. If neither is configured, 10 is used. The actual number of results may be less than this value after permission and release version filtering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

                /// <summary>
                /// <para>The vector path weight for WEIGHTED fusion. The system default is 0.7. The keyword path weight is 1 minus this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7</para>
                /// </summary>
                [NameInMap("vectorWeight")]
                [Validation(Required=false)]
                public double? VectorWeight { get; set; }

            }

        }

        /// <summary>
        /// <para>Optional. For retries on the same knowledge base with the same client token and identical update content, the accepted result is returned without further modifications. If the content differs, an IdempotencyConflict error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-update-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
