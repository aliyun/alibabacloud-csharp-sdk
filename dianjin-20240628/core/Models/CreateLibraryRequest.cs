// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateLibraryRequest : TeaModel {
        /// <summary>
        /// <para>Document library description</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述文档库的具体作用</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Index settings for the document library</para>
        /// </summary>
        [NameInMap("indexSetting")]
        [Validation(Required=false)]
        public CreateLibraryRequestIndexSetting IndexSetting { get; set; }
        public class CreateLibraryRequestIndexSetting : TeaModel {
            /// <summary>
            /// <para>Chunking strategy</para>
            /// </summary>
            [NameInMap("chunkStrategy")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingChunkStrategy ChunkStrategy { get; set; }
            public class CreateLibraryRequestIndexSettingChunkStrategy : TeaModel {
                /// <summary>
                /// <para>Layout-based chunking</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("docTreeSplit")]
                [Validation(Required=false)]
                public bool? DocTreeSplit { get; set; }

                /// <summary>
                /// <para>Layout-based chunk size</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("docTreeSplitSize")]
                [Validation(Required=false)]
                public int? DocTreeSplitSize { get; set; }

                /// <summary>
                /// <para>Parse images in documents</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enhanceGraph")]
                [Validation(Required=false)]
                public bool? EnhanceGraph { get; set; }

                /// <summary>
                /// <para>Parse tables in documents</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enhanceTable")]
                [Validation(Required=false)]
                public bool? EnhanceTable { get; set; }

                /// <summary>
                /// <para>Chunk overlap length</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("overlap")]
                [Validation(Required=false)]
                public int? Overlap { get; set; }

                /// <summary>
                /// <para>Split by sentence</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("sentenceSplit")]
                [Validation(Required=false)]
                public bool? SentenceSplit { get; set; }

                /// <summary>
                /// <para>Sentence-based chunk size</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("sentenceSplitSize")]
                [Validation(Required=false)]
                public int? SentenceSplitSize { get; set; }

                /// <summary>
                /// <para>Chunk size</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>Enable chunking</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("split")]
                [Validation(Required=false)]
                public bool? Split { get; set; }

            }

            /// <summary>
            /// <para>Model configuration</para>
            /// </summary>
            [NameInMap("modelConfig")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingModelConfig ModelConfig { get; set; }
            public class CreateLibraryRequestIndexSettingModelConfig : TeaModel {
                /// <summary>
                /// <para>Control the randomness and diversity of model responses. Higher values flatten the probability distribution over candidate tokens, increasing diversity. Lower values sharpen the distribution, increasing determinism.</para>
                /// <para>Valid range: [0, 2). Avoid 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

                /// <summary>
                /// <para>Probability threshold for nucleus sampling. For example, with a value of 0.8, only the smallest set of most likely tokens whose cumulative probability is at least 0.8 is used. Higher values increase randomness. Lower values increase determinism.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("topP")]
                [Validation(Required=false)]
                public double? TopP { get; set; }

            }

            /// <summary>
            /// <para>Prompt role style. Specify a role and tone to guide response quality. Examples: Document analysis expert, friendly customer service agent, professional financial analyst.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是一位信息处理专家，耐心、友好、逻辑清晰。</para>
            /// </summary>
            [NameInMap("promptRoleStyle")]
            [Validation(Required=false)]
            public string PromptRoleStyle { get; set; }

            /// <summary>
            /// <para>Query enhancement configuration</para>
            /// </summary>
            [NameInMap("queryEnhancer")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingQueryEnhancer QueryEnhancer { get; set; }
            public class CreateLibraryRequestIndexSettingQueryEnhancer : TeaModel {
                /// <summary>
                /// <para>Rewrite queries using history</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableFollowUp")]
                [Validation(Required=false)]
                public bool? EnableFollowUp { get; set; }

                /// <summary>
                /// <para>Use Large Language Models (LLMs) to decompose queries</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableMultiQuery")]
                [Validation(Required=false)]
                public bool? EnableMultiQuery { get; set; }

                /// <summary>
                /// <para>Use LLMs to answer queries</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableOpenQa")]
                [Validation(Required=false)]
                public bool? EnableOpenQa { get; set; }

                /// <summary>
                /// <para>Enable query rewriting</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableQueryRewrite")]
                [Validation(Required=false)]
                public bool? EnableQueryRewrite { get; set; }

                /// <summary>
                /// <para>Enable multi-turn conversations</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableSession")]
                [Validation(Required=false)]
                public bool? EnableSession { get; set; }

                /// <summary>
                /// <para>Document library ID for knowledge rewriting</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("localKnowledgeId")]
                [Validation(Required=false)]
                public string LocalKnowledgeId { get; set; }

                /// <summary>
                /// <para>Include document references in responses</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("withDocumentReference")]
                [Validation(Required=false)]
                public bool? WithDocumentReference { get; set; }

            }

            /// <summary>
            /// <para>Retrieval strategy</para>
            /// </summary>
            [NameInMap("recallStrategy")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingRecallStrategy RecallStrategy { get; set; }
            public class CreateLibraryRequestIndexSettingRecallStrategy : TeaModel {
                /// <summary>
                /// <para>Merge and sort policy</para>
                /// 
                /// <b>Example:</b>
                /// <para>model</para>
                /// </summary>
                [NameInMap("documentRankType")]
                [Validation(Required=false)]
                public string DocumentRankType { get; set; }

                /// <summary>
                /// <para>Number of results from two-way merge and summarization</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

            }

            /// <summary>
            /// <para>Text index configuration</para>
            /// </summary>
            [NameInMap("textIndexSetting")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingTextIndexSetting TextIndexSetting { get; set; }
            public class CreateLibraryRequestIndexSettingTextIndexSetting : TeaModel {
                /// <summary>
                /// <para>Text index type. Only ElasticSearch is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ElasticSearch</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Enable text indexing</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Text index analyzer: Standard, IkMaxWord, or IkSmart</para>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("indexAnalyzer")]
                [Validation(Required=false)]
                public string IndexAnalyzer { get; set; }

                /// <summary>
                /// <para>Text index ranking threshold</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("rankThreshold")]
                [Validation(Required=false)]
                public double? RankThreshold { get; set; }

                /// <summary>
                /// <para>Text index search analyzer: Standard, IkMaxWord, or IkSmart</para>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("searchAnalyzer")]
                [Validation(Required=false)]
                public string SearchAnalyzer { get; set; }

                /// <summary>
                /// <para>Number of final text index results</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

            }

            /// <summary>
            /// <para>Vector index settings</para>
            /// </summary>
            [NameInMap("vectorIndexSetting")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingVectorIndexSetting VectorIndexSetting { get; set; }
            public class CreateLibraryRequestIndexSettingVectorIndexSetting : TeaModel {
                /// <summary>
                /// <para>Vector index source. Only ADB is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADB</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Text embedding type for vector indexing</para>
                /// 
                /// <b>Example:</b>
                /// <para>DashScope</para>
                /// </summary>
                [NameInMap("embeddingType")]
                [Validation(Required=false)]
                public string EmbeddingType { get; set; }

                /// <summary>
                /// <para>Enable vector indexing</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Vector index ranking threshold</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("rankThreshold")]
                [Validation(Required=false)]
                public double? RankThreshold { get; set; }

                /// <summary>
                /// <para>Number of final vector index results</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

            }

        }

        /// <summary>
        /// <para>Document library name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>金融知识文档库</para>
        /// </summary>
        [NameInMap("libraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

    }

}
