// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The EventHouse catalog to which the knowledge base belongs. This parameter, together with Namespace and KnowledgeBaseName, uniquely identifies the knowledge base. This parameter cannot be modified after the knowledge base is created. System catalogs cannot be bound.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. The default chunking strategy for the knowledge base. This strategy applies only to documents uploaded after the configuration is set. If this parameter is not specified, the system default chunking strategy is used.</para>
        /// </summary>
        [NameInMap("ChunkConfiguration")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestChunkConfiguration ChunkConfiguration { get; set; }
        public class CreateKnowledgeBaseRequestChunkConfiguration : TeaModel {
            /// <summary>
            /// <para>Required for the BY_HEADING strategy. Valid values: 1 to 6. This parameter is ignored for other strategies. Headings at or above the specified level are used as split boundaries. For example, if you set this parameter to 2, both H1 and H2 headings are used as split boundaries. Deeper-level headings are not used for splitting and are retained in the chunk body. If the content within a section exceeds MaxChunkSize, the system falls back to splitting by paragraphs or sentences. Documents without headings fall back to intelligent chunking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HeadingLevel")]
            [Validation(Required=false)]
            public int? HeadingLevel { get; set; }

            /// <summary>
            /// <para>The maximum character length of a single chunk. Valid values: 1 to 6000 (characters). An error is returned if the value exceeds the limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("MaxChunkSize")]
            [Validation(Required=false)]
            public int? MaxChunkSize { get; set; }

            /// <summary>
            /// <para>Takes effect only for the BY_LENGTH strategy. This parameter is ignored for other strategies. Specifies the overlap length (in characters) between adjacent chunks. If the value is greater than 0, the beginning of the next chunk repeats the content from the end of the previous chunk within this window. The overlap does not cause a chunk to exceed MaxChunkSize. Default value: 0, which indicates no overlap.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("OverlapSize")]
            [Validation(Required=false)]
            public int? OverlapSize { get; set; }

            /// <summary>
            /// <para>The pre-processing rules.</para>
            /// </summary>
            [NameInMap("PreprocessRules")]
            [Validation(Required=false)]
            public CreateKnowledgeBaseRequestChunkConfigurationPreprocessRules PreprocessRules { get; set; }
            public class CreateKnowledgeBaseRequestChunkConfigurationPreprocessRules : TeaModel {
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
                /// <para>Specifies whether to replace consecutive whitespace characters (spaces, line breaks, and tabs) with a single space.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ReplaceConsecutiveWhitespace")]
                [Validation(Required=false)]
                public bool? ReplaceConsecutiveWhitespace { get; set; }

            }

            /// <summary>
            /// <para>Required for the BY_SEPARATOR strategy. This parameter is ignored for other strategies. The system splits content by matching the literal string as a whole (not as a regular expression). The maximum length is 32 characters. Example: \
            /// \
            ///  for paragraph separators.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\\n\\n</para>
            /// </summary>
            [NameInMap("Separator")]
            [Validation(Required=false)]
            public string Separator { get; set; }

            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AUTO: Intelligent chunking (heading-aware + paragraph packing).</description></item>
            /// <item><description>BY_LENGTH: Sliding window chunking by length. You can specify OverlapSize.</description></item>
            /// <item><description>BY_SEPARATOR: Chunking by separator. You must specify Separator.</description></item>
            /// <item><description>BY_HEADING: Chunking by heading level. You must specify HeadingLevel.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BY_SEPARATOR</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

        }

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
        /// <para>Optional. The vector dimensions. The value is validated against the embedding model: text-embedding-v3 supports 64, 128, 256, 512, 768, and 1024. text-embedding-v4 supports 64, 128, 256, 512, 768, 1024, 1536, and 2048. qwen3.7-text-embedding supports 256, 512, 768, 1024, 1536, 2048, and 2560. qwen3.7-text-embedding-flash supports 256, 512, 768, and 1024. Default value: 1024 (the default dimension of the model). This parameter cannot be modified after the knowledge base is created. Even if the dimensions are the same, you must rebuild the knowledge base when switching models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("EmbeddingDimension")]
        [Validation(Required=false)]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// <para>Optional. The embedding model used for vectorization. This parameter cannot be modified after the knowledge base is created. Valid values: text-embedding-v3, text-embedding-v4, qwen3.7-text-embedding, and qwen3.7-text-embedding-flash. Only Bailian Tongyi models are supported. Third-party models are not supported. Default value: text-embedding-v4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be unique within the namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-docs</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>Declares the metadata fields of the knowledge base. When you upload documents, the metadata can contain only the fields declared here. This parameter cannot be modified after the knowledge base is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;department&quot;,&quot;Type&quot;:&quot;STRING&quot;}]</para>
        /// </summary>
        [NameInMap("MetadataSchema")]
        [Validation(Required=false)]
        public List<CreateKnowledgeBaseRequestMetadataSchema> MetadataSchema { get; set; }
        public class CreateKnowledgeBaseRequestMetadataSchema : TeaModel {
            /// <summary>
            /// <para>The name of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Valid values: STRING, LONG, DOUBLE, BOOLEAN, and DATETIME.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>When ValueMode is set to CONSTANT, this parameter specifies a fixed value. An empty value indicates that the value can be assigned during upload. When ValueMode is set to SYSTEM_VARIABLE, this parameter specifies a system variable name, such as DOCUMENT_NAME, FILE_TYPE, FILE_SIZE, DOCUMENT_UPLOAD_TIME, SOURCE_TYPE, SOURCE_URI, or SOURCE_MODIFIED_TIME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EventHouse</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONSTANT: Constant. If Value is not empty, all documents use the fixed value. If Value is empty, the value can be assigned during upload.</description></item>
            /// <item><description>SYSTEM_VARIABLE: System variable. Value specifies the variable name. The system automatically generates the value, and the value cannot be overridden during upload.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("ValueMode")]
            [Validation(Required=false)]
            public string ValueMode { get; set; }

        }

        /// <summary>
        /// <para>The EventHouse namespace to which the knowledge base belongs. The namespace must belong to the specified catalog. This parameter, together with Catalog and KnowledgeBaseName, uniquely identifies the knowledge base. This parameter cannot be modified after the knowledge base is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Optional. The default search configuration at the knowledge base level. This configuration takes effect when the corresponding parameters are not specified in search requests. You can modify this configuration after creation by calling UpdateKnowledgeBase.</para>
        /// </summary>
        [NameInMap("SearchConfiguration")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestSearchConfiguration SearchConfiguration { get; set; }
        public class CreateKnowledgeBaseRequestSearchConfiguration : TeaModel {
            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>KEYWORD: Keyword retrieval.</description></item>
            /// <item><description>VECTOR: Vector retrieval.</description></item>
            /// <item><description>HYBRID: Hybrid retrieval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>Takes effect only in hybrid search mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RRF: Reciprocal rank fusion.</description></item>
            /// <item><description>WEIGHTED: Weighted normalization fusion. Use this value together with VectorWeight.</description></item>
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
            /// <para>Takes effect only in hybrid search mode. Specifies whether to enable reranking by default when the search request does not specify a Rerank parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RerankEnabled")]
            [Validation(Required=false)]
            public bool? RerankEnabled { get; set; }

            /// <summary>
            /// <para>The default reranking model used when the search request does not specify a RerankModel parameter. Valid values: qwen3-rerank. Default value: qwen3-rerank.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-rerank</para>
            /// </summary>
            [NameInMap("RerankModel")]
            [Validation(Required=false)]
            public string RerankModel { get; set; }

            /// <summary>
            /// <para>The k parameter for the RRF fusion algorithm. The value must be greater than 0. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RrfK")]
            [Validation(Required=false)]
            public int? RrfK { get; set; }

            /// <summary>
            /// <para>The default number of results to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public int? TopK { get; set; }

            /// <summary>
            /// <para>The vector weight for the WEIGHTED fusion algorithm. Valid values: 0 to 1. The keyword weight equals 1 minus this value. Default value: 0.7.</para>
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
