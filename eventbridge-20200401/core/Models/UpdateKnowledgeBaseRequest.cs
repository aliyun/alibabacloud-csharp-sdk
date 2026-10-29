// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. It is used together with Namespace and KnowledgeBaseName to locate the knowledge base. You can call ListCatalogs to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. Updates the default chunking strategy of the knowledge base. This update takes effect only for newly uploaded documents and does not re-chunk existing documents. If this parameter is not specified, the strategy is not modified.</para>
        /// </summary>
        [NameInMap("ChunkConfiguration")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseRequestChunkConfiguration ChunkConfiguration { get; set; }
        public class UpdateKnowledgeBaseRequestChunkConfiguration : TeaModel {
            /// <summary>
            /// <para>Required for the BY_HEADING strategy. Valid values: 1 to 6. This parameter is ignored for other strategies. Headings at or above the specified level are used as split boundaries. For example, if you set this parameter to 2, both H1 and H2 headings are used for splitting. Deeper-level headings are not split and are retained in the chunk text. If the section content exceeds MaxChunkSize, the system falls back to splitting by paragraphs or sentences. For documents without headings, the system falls back to intelligent chunking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HeadingLevel")]
            [Validation(Required=false)]
            public int? HeadingLevel { get; set; }

            /// <summary>
            /// <para>The maximum token length of a single chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("MaxChunkSize")]
            [Validation(Required=false)]
            public int? MaxChunkSize { get; set; }

            /// <summary>
            /// <para>The overlap token length between adjacent chunks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("OverlapSize")]
            [Validation(Required=false)]
            public int? OverlapSize { get; set; }

            /// <summary>
            /// <para>The preprocessing rules.</para>
            /// </summary>
            [NameInMap("PreprocessRules")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseRequestChunkConfigurationPreprocessRules PreprocessRules { get; set; }
            public class UpdateKnowledgeBaseRequestChunkConfigurationPreprocessRules : TeaModel {
                /// <summary>
                /// <para>Specifies whether to remove URLs and email addresses during parsing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("RemoveUrlsAndEmails")]
                [Validation(Required=false)]
                public bool? RemoveUrlsAndEmails { get; set; }

                /// <summary>
                /// <para>Specifies whether to replace consecutive whitespace characters, such as spaces, line breaks, and tabs, with a single space.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ReplaceConsecutiveWhitespace")]
                [Validation(Required=false)]
                public bool? ReplaceConsecutiveWhitespace { get; set; }

            }

            /// <summary>
            /// <para>The paragraph identifier for the LINE_BREAK strategy, such as a line break.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\\n\\n</para>
            /// </summary>
            [NameInMap("Separator")]
            [Validation(Required=false)]
            public string Separator { get; set; }

            /// <summary>
            /// <para>The chunking strategy. Valid values: AUTO: Automatic chunking. LINE_BREAK: Chunking by paragraph identifier.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LINE_BREAK</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

        }

        /// <summary>
        /// <para>Updates the description of the knowledge base. If this parameter is not specified, the description is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product documentation knowledge base</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be unique within the namespace. It is specified during creation and cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. It is used together with Catalog and KnowledgeBaseName to locate the knowledge base. You can call ListNamespaces to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Optional. Updates the default search configuration at the knowledge base level. The update takes effect immediately for subsequent search requests. If this parameter is not specified, the configuration is not modified.</para>
        /// </summary>
        [NameInMap("SearchConfiguration")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseRequestSearchConfiguration SearchConfiguration { get; set; }
        public class UpdateKnowledgeBaseRequestSearchConfiguration : TeaModel {
            /// <summary>
            /// <para>The search mode. Valid values: KEYWORD: Keyword retrieve. VECTOR: AISearch. HYBRID: Hybrid retrieve.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The hybrid search fusion algorithm. This parameter takes effect only in hybrid search mode. Valid values: RRF: Reciprocal rank fusion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RRF</para>
            /// </summary>
            [NameInMap("RankAlgorithm")]
            [Validation(Required=false)]
            public string RankAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable reranking by default. This parameter takes effect only in hybrid search mode and is used when a search request does not specify the Rerank parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RerankEnabled")]
            [Validation(Required=false)]
            public bool? RerankEnabled { get; set; }

            /// <summary>
            /// <para>The default rerank model used when a search request does not specify the RerankModel parameter. Valid values: qwen3-rerank. Default value: qwen3-rerank.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-rerank</para>
            /// </summary>
            [NameInMap("RerankModel")]
            [Validation(Required=false)]
            public string RerankModel { get; set; }

            /// <summary>
            /// <para>The parameter k for the RRF fusion algorithm. The value must be greater than 0. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RrfK")]
            [Validation(Required=false)]
            public int? RrfK { get; set; }

            /// <summary>
            /// <para>The default number of returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public int? TopK { get; set; }

            /// <summary>
            /// <para>The weight of the vector path in the WEIGHTED fusion algorithm. Valid values: 0 to 1. The weight of the keyword path is 1 minus this value. Default value: 0.7.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7</para>
            /// </summary>
            [NameInMap("VectorWeight")]
            [Validation(Required=false)]
            public double? VectorWeight { get; set; }

        }

    }

}
