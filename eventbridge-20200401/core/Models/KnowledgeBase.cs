// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class KnowledgeBase : TeaModel {
        /// <summary>
        /// <para>The EventHouse data catalog to which the knowledge base belongs. This value cannot be modified after the knowledge base is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The default chunking strategy of the knowledge base. This configuration takes effect only for documents uploaded after the configuration is updated. Existing documents are not re-chunked.</para>
        /// </summary>
        [NameInMap("ChunkConfiguration")]
        [Validation(Required=false)]
        public KnowledgeBaseChunkConfiguration ChunkConfiguration { get; set; }
        public class KnowledgeBaseChunkConfiguration : TeaModel {
            /// <summary>
            /// <para>The heading level (1 to 6) used for splitting in the BY_HEADING strategy. Headings at or above this level serve as split boundaries. Deeper-level headings are retained in the chunk body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HeadingLevel")]
            [Validation(Required=false)]
            public int? HeadingLevel { get; set; }

            /// <summary>
            /// <para>The maximum character length of a single chunk. Starting from revision 22, this value is character-based. Valid values: 1 to 6000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxChunkSize")]
            [Validation(Required=false)]
            public int? MaxChunkSize { get; set; }

            /// <summary>
            /// <para>The overlap character length between adjacent chunks. This parameter takes effect only for the BY_LENGTH strategy. When the value is greater than 0, the beginning of the next chunk repeats the content from the end of the previous chunk within this window. The overlap does not cause a chunk to exceed MaxChunkSize. A value of 0 indicates no overlap.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("OverlapSize")]
            [Validation(Required=false)]
            public int? OverlapSize { get; set; }

            /// <summary>
            /// <para>The preprocessing rules that take effect during document parsing.</para>
            /// </summary>
            [NameInMap("PreprocessRules")]
            [Validation(Required=false)]
            public KnowledgeBaseChunkConfigurationPreprocessRules PreprocessRules { get; set; }
            public class KnowledgeBaseChunkConfigurationPreprocessRules : TeaModel {
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
                /// <para>Specifies whether to replace consecutive whitespace characters (spaces, line breaks, and tab characters) with a single space.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ReplaceConsecutiveWhitespace")]
                [Validation(Required=false)]
                public bool? ReplaceConsecutiveWhitespace { get; set; }

            }

            /// <summary>
            /// <para>The separator used in the BY_SEPARATOR strategy. The separator is matched as a literal string (not a regular expression). The maximum length is 32 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\\n\\n</para>
            /// </summary>
            [NameInMap("Separator")]
            [Validation(Required=false)]
            public string Separator { get; set; }

            /// <summary>
            /// <para>The chunking strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AUTO: intelligent splitting (heading-aware + paragraph packing).</description></item>
            /// <item><description>BY_LENGTH: sliding window splitting by length. You can specify OverlapSize.</description></item>
            /// <item><description>BY_SEPARATOR: splitting by separator. You must specify Separator.</description></item>
            /// <item><description>BY_HEADING: splitting by heading level. You must specify HeadingLevel.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BY_SEPARATOR</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

        }

        /// <summary>
        /// <para>The time when the knowledge base was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-24T10:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product documentation knowledge base</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The embedding vector dimension specified during creation or the default dimension of the model. This value cannot be modified after the knowledge base is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("EmbeddingDimension")]
        [Validation(Required=false)]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// <para>The embedding model specified during creation. This value cannot be modified after the knowledge base is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// <para>The brief reason for the most recent creation or deletion failure. This parameter is returned only when the status is CREATE_FAILED or DELETE_FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OssException: BucketAlreadyExists ...</para>
        /// </summary>
        [NameInMap("FailureReason")]
        [Validation(Required=false)]
        public string FailureReason { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base, which is unique within the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-docs</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>The metadata fields declared when the knowledge base was created. These fields cannot be modified after the knowledge base is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;department&quot;,&quot;Type&quot;:&quot;STRING&quot;}]</para>
        /// </summary>
        [NameInMap("MetadataSchema")]
        [Validation(Required=false)]
        public List<MetadataSchemaField> MetadataSchema { get; set; }

        /// <summary>
        /// <para>The EventHouse namespace to which the knowledge base belongs. This value cannot be modified after the knowledge base is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The default search configuration at the knowledge base level. This configuration takes effect when the corresponding parameters are not specified in a search request. You can modify this configuration by calling the UpdateKnowledgeBase operation.</para>
        /// </summary>
        [NameInMap("SearchConfiguration")]
        [Validation(Required=false)]
        public KnowledgeBaseSearchConfiguration SearchConfiguration { get; set; }
        public class KnowledgeBaseSearchConfiguration : TeaModel {
            /// <summary>
            /// <para>The retrieval mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>KEYWORD: keyword retrieval.</description></item>
            /// <item><description>VECTOR: vector retrieval.</description></item>
            /// <item><description>HYBRID: hybrid retrieval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The fusion algorithm for hybrid search. This parameter takes effect only in hybrid search mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RRF: reciprocal rank fusion.</description></item>
            /// <item><description>WEIGHTED: weighted normalization fusion. Use this value together with VectorWeight.</description></item>
            /// </list>
            /// <para>Default value: RRF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RRF</para>
            /// </summary>
            [NameInMap("RankAlgorithm")]
            [Validation(Required=false)]
            public string RankAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether reranking is enabled by default. This parameter takes effect for all search modes (KEYWORD, VECTOR, and HYBRID). This default value is used when the Rerank parameter is not specified in a search request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RerankEnabled")]
            [Validation(Required=false)]
            public bool? RerankEnabled { get; set; }

            /// <summary>
            /// <para>The default reranking model used when the RerankModel parameter is not specified in a search request. Valid values: qwen3-rerank, gte-rerank-v2, and qwen3-vl-rerank. Default value: qwen3-rerank. Score distributions vary across models and cannot be compared. Use the same model consistently within a knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-rerank</para>
            /// </summary>
            [NameInMap("RerankModel")]
            [Validation(Required=false)]
            public string RerankModel { get; set; }

            /// <summary>
            /// <para>The k parameter of the RRF fusion algorithm. The value must be greater than 0. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RrfK")]
            [Validation(Required=false)]
            public int? RrfK { get; set; }

            /// <summary>
            /// <para>The maximum number of results returned by default for a search request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public int? TopK { get; set; }

            /// <summary>
            /// <para>The weight of the vector path in the WEIGHTED fusion algorithm. Valid values: 0 to 1. The keyword path weight equals 1 minus this value. Default value: 0.7.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7</para>
            /// </summary>
            [NameInMap("VectorWeight")]
            [Validation(Required=false)]
            public double? VectorWeight { get; set; }

        }

        /// <summary>
        /// <para>The current status of the knowledge base. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATING: The knowledge base is being created.</description></item>
        /// <item><description>ACTIVE: The knowledge base is available.</description></item>
        /// <item><description>CREATE_FAILED: The knowledge base failed to be created.</description></item>
        /// <item><description>DELETING: The knowledge base is being deleted.</description></item>
        /// <item><description>DELETE_FAILED: The knowledge base failed to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the knowledge base was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-24T10:00:00Z</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
