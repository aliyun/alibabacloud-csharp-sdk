// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The EventHouse catalog to which the knowledge base belongs. This parameter, together with Namespace and KnowledgeBaseName, uniquely identifies the knowledge base. This parameter cannot be modified after the knowledge base is created. You cannot bind a system catalog.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. The default chunking strategy for the knowledge base. This strategy applies only to documents uploaded after the configuration. If this parameter is not specified, the system default chunking strategy is used.</para>
        /// </summary>
        [NameInMap("ChunkConfiguration")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestChunkConfiguration ChunkConfiguration { get; set; }
        public class CreateKnowledgeBaseRequestChunkConfiguration : TeaModel {
            /// <summary>
            /// <para>Required for the BY_HEADING strategy. Valid values: 1 to 6. This parameter is ignored for other strategies. Headings at or above the specified level are used as chunking boundaries. For example, if you set this parameter to 2, both H1 and H2 headings are used as boundaries. Lower-level headings are not used as boundaries and are retained in the chunk text. If the section content exceeds MaxChunkSize, the system falls back to chunking by paragraph or sentence. For documents without headings, the system falls back to intelligent chunking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HeadingLevel")]
            [Validation(Required=false)]
            public int? HeadingLevel { get; set; }

            /// <summary>
            /// <para>The maximum number of characters in a single chunk. Valid values: 1 to 6000. An error is reported if the limit is exceeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("MaxChunkSize")]
            [Validation(Required=false)]
            public int? MaxChunkSize { get; set; }

            /// <summary>
            /// <para>Applies only to the BY_LENGTH strategy. This parameter is ignored for other strategies. The overlap size between adjacent chunks, in characters. If the value is greater than 0, the beginning of the next chunk repeats the content at the end of the previous chunk within this window. The overlap does not cause the chunk to exceed MaxChunkSize. Default value: 0, which indicates no overlap.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("OverlapSize")]
            [Validation(Required=false)]
            public int? OverlapSize { get; set; }

            /// <summary>
            /// <para>The preprocessing rules.</para>
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
            /// <para>Required for the BY_SEPARATOR strategy. This parameter is ignored for other strategies. The literal string used to split the text. Regular expressions are not supported. The maximum length is 32 characters. Example: \
            /// \
            ///  for paragraph breaks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\\n\\n</para>
            /// </summary>
            [NameInMap("Separator")]
            [Validation(Required=false)]
            public string Separator { get; set; }

            /// <summary>
            /// <para>The chunking strategy. AUTO indicates intelligent chunking, which is heading-aware and groups paragraphs. BY_LENGTH indicates sliding window chunking by length, where you can specify OverlapSize. BY_SEPARATOR indicates chunking by separator, where you must specify Separator. BY_HEADING indicates chunking by heading level, where you must specify HeadingLevel. Valid values: AUTO, BY_LENGTH, BY_SEPARATOR, and BY_HEADING.</para>
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
        /// <para>Optional. The vector dimensions. This parameter is attached to the embedding model for validation. Valid values for text-embedding-v3: 64, 128, 256, 512, 768, and 1024. Valid values for text-embedding-v4: 64, 128, 256, 512, 768, 1024, 1536, and 2048. Valid values for qwen3.7-text-embedding: 256, 512, 768, 1024, 1536, 2048, and 2560. Valid values for qwen3.7-text-embedding-flash: 256, 512, 768, and 1024. If this parameter is not specified, the default dimension of the model, 1024, is used. This parameter cannot be modified after the knowledge base is created. To change the model, you must rebuild the knowledge base, even if the dimensions remain the same.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("EmbeddingDimension")]
        [Validation(Required=false)]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// <para>Optional. The embedding model. This parameter cannot be modified after the knowledge base is created. Valid values: text-embedding-v3, text-embedding-v4, qwen3.7-text-embedding, and qwen3.7-text-embedding-flash. Only Qwen models provided by Model Studio are supported. Third-party models are not supported. Default value: text-embedding-v4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be unique within the same namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-docs</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>Declares the metadata fields for the knowledge base. When you upload documents, the metadata can only contain the fields declared here. This parameter cannot be modified after the knowledge base is created.</para>
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
            /// <para>The type of the field. Valid values: STRING, LONG, DOUBLE, BOOLEAN, and DATETIME.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value configuration. If ValueMode is set to CONSTANT, this parameter specifies a fixed value. If it is left empty, you can assign a value during upload. If ValueMode is set to SYSTEM_VARIABLE, this parameter specifies a system variable name, such as DOCUMENT_NAME, FILE_TYPE, FILE_SIZE, DOCUMENT_UPLOAD_TIME, SOURCE_TYPE, SOURCE_URI, or SOURCE_MODIFIED_TIME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EventHouse</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The value mode. CONSTANT indicates a constant. If Value is not empty, all documents use the fixed value. If Value is empty, you can assign a value during upload. SYSTEM_VARIABLE indicates a system variable. Value specifies the variable name, which is automatically generated by the system and cannot be overwritten during upload.</para>
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
        /// <para>Optional. The default search configuration at the knowledge base level. This configuration takes effect when the corresponding parameters are not specified in a search request. You can modify this configuration by calling UpdateKnowledgeBase after the knowledge base is created.</para>
        /// </summary>
        [NameInMap("SearchConfiguration")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestSearchConfiguration SearchConfiguration { get; set; }
        public class CreateKnowledgeBaseRequestSearchConfiguration : TeaModel {
            /// <summary>
            /// <para>The search mode. KEYWORD indicates keyword retrieve. VECTOR indicates AISearch. HYBRID indicates hybrid retrieve. Valid values: KEYWORD, VECTOR, and HYBRID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>Applies only to the hybrid search mode. RRF indicates reciprocal rank fusion. WEIGHTED indicates weighted normalization fusion, which is used together with VectorWeight. Default value: RRF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RRF</para>
            /// </summary>
            [NameInMap("RankAlgorithm")]
            [Validation(Required=false)]
            public string RankAlgorithm { get; set; }

            /// <summary>
            /// <para>Applies only to the hybrid search mode. Specifies whether to enable reranking by default when a search request does not specify the Rerank parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RerankEnabled")]
            [Validation(Required=false)]
            public bool? RerankEnabled { get; set; }

            /// <summary>
            /// <para>The default rerank model used when a search request does not specify the RerankModel parameter. Valid value: qwen3-rerank. Default value: qwen3-rerank.</para>
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
            /// <para>The vector weight for the WEIGHTED fusion algorithm. Valid values: 0 to 1. The keyword weight is 1 minus this value. Default value: 0.7.</para>
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
