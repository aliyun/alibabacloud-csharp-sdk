// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class UpdateLibraryRequest : TeaModel {
        /// <summary>
        /// <para>Document library description</para>
        /// 
        /// <b>Example:</b>
        /// <para>文档库描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Document library index configuration</para>
        /// </summary>
        [NameInMap("indexSetting")]
        [Validation(Required=false)]
        public UpdateLibraryRequestIndexSetting IndexSetting { get; set; }
        public class UpdateLibraryRequestIndexSetting : TeaModel {
            /// <summary>
            /// <para>Chunking strategy</para>
            /// </summary>
            [NameInMap("chunkStrategy")]
            [Validation(Required=false)]
            public UpdateLibraryRequestIndexSettingChunkStrategy ChunkStrategy { get; set; }
            public class UpdateLibraryRequestIndexSettingChunkStrategy : TeaModel {
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
                /// <para>Layout-based chunking size</para>
                /// 
                /// <b>Example:</b>
                /// <para>160</para>
                /// </summary>
                [NameInMap("docTreeSplitSize")]
                [Validation(Required=false)]
                public int? DocTreeSplitSize { get; set; }

                /// <summary>
                /// <para>Enhance images</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enhanceGraph")]
                [Validation(Required=false)]
                public bool? EnhanceGraph { get; set; }

                /// <summary>
                /// <para>Enhance tables</para>
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
                /// <para>Split by sentence. Default is true</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("sentenceSplit")]
                [Validation(Required=false)]
                public bool? SentenceSplit { get; set; }

                /// <summary>
                /// <para>Average sentence-based chunking length</para>
                /// 
                /// <b>Example:</b>
                /// <para>160</para>
                /// </summary>
                [NameInMap("sentenceSplitSize")]
                [Validation(Required=false)]
                public int? SentenceSplitSize { get; set; }

                /// <summary>
                /// <para>Fixed-length chunking size</para>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
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
            public UpdateLibraryRequestIndexSettingModelConfig ModelConfig { get; set; }
            public class UpdateLibraryRequestIndexSettingModelConfig : TeaModel {
                /// <summary>
                /// <para>Temperature</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

                /// <summary>
                /// <para>Top P</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("topP")]
                [Validation(Required=false)]
                public double? TopP { get; set; }

            }

            /// <summary>
            /// <para>Prompt role style</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是一位文档分析专家，非常善于从给定的知识中，找到重点，像老师给学生讲课一样把问题回答清晰。你的回答富有逻辑性，遇到复杂问题，你善于一步一步思考。</para>
            /// </summary>
            [NameInMap("promptRoleStyle")]
            [Validation(Required=false)]
            public string PromptRoleStyle { get; set; }

            /// <summary>
            /// <para>Query enhancement</para>
            /// </summary>
            [NameInMap("queryEnhancer")]
            [Validation(Required=false)]
            public UpdateLibraryRequestIndexSettingQueryEnhancer QueryEnhancer { get; set; }
            public class UpdateLibraryRequestIndexSettingQueryEnhancer : TeaModel {
                /// <summary>
                /// <para>Multi-turn enhancement</para>
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
                /// <para>Use Large Language Models (LLMs) to answer queries</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableOpenQa")]
                [Validation(Required=false)]
                public bool? EnableOpenQa { get; set; }

                /// <summary>
                /// <para>Rewrite queries using domain knowledge</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableQueryRewrite")]
                [Validation(Required=false)]
                public bool? EnableQueryRewrite { get; set; }

                /// <summary>
                /// <para>Record session history</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableSession")]
                [Validation(Required=false)]
                public bool? EnableSession { get; set; }

                /// <summary>
                /// <para>Document library ID used for query rewriting</para>
                /// 
                /// <b>Example:</b>
                /// <para>sjdhgfc</para>
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
            public UpdateLibraryRequestIndexSettingRecallStrategy RecallStrategy { get; set; }
            public class UpdateLibraryRequestIndexSettingRecallStrategy : TeaModel {
                /// <summary>
                /// <para>Merge and sort strategy</para>
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
                /// <para>10</para>
                /// </summary>
                [NameInMap("limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

            }

            /// <summary>
            /// <para>Text index settings</para>
            /// </summary>
            [NameInMap("textIndexSetting")]
            [Validation(Required=false)]
            public UpdateLibraryRequestIndexSettingTextIndexSetting TextIndexSetting { get; set; }
            public class UpdateLibraryRequestIndexSettingTextIndexSetting : TeaModel {
                /// <summary>
                /// <para>Text index type</para>
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
                /// <para>Number of final summarized results from text indexing</para>
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
            public UpdateLibraryRequestIndexSettingVectorIndexSetting VectorIndexSetting { get; set; }
            public class UpdateLibraryRequestIndexSettingVectorIndexSetting : TeaModel {
                /// <summary>
                /// <para>Vector index source. We recommend ADB</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADB</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Text embedding model for vector indexing</para>
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
                /// <para>Number of final summarized results from vector indexing</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

            }

        }

        /// <summary>
        /// <para>Document library ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsfbashdbb</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>Document library name</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试文档库</para>
        /// </summary>
        [NameInMap("libraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

    }

}
