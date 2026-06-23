// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetLibraryResponseBody : TeaModel {
        /// <summary>
        /// <para>Response time in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>The response data object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetLibraryResponseBodyData Data { get; set; }
        public class GetLibraryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The document library description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文档库的描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of documents in the library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("documentCount")]
            [Validation(Required=false)]
            public long? DocumentCount { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time in YYYY-MM-DD HH:MM:SS format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The document library ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19386728376</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The document library index settings.</para>
            /// </summary>
            [NameInMap("indexSetting")]
            [Validation(Required=false)]
            public GetLibraryResponseBodyDataIndexSetting IndexSetting { get; set; }
            public class GetLibraryResponseBodyDataIndexSetting : TeaModel {
                /// <summary>
                /// <para>The chunking strategy.</para>
                /// </summary>
                [NameInMap("chunkStrategy")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingChunkStrategy ChunkStrategy { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingChunkStrategy : TeaModel {
                    /// <summary>
                    /// <para>Enable layout-based splitting.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("docTreeSplit")]
                    [Validation(Required=false)]
                    public bool? DocTreeSplit { get; set; }

                    /// <summary>
                    /// <para>The layout-based splitting size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>160</para>
                    /// </summary>
                    [NameInMap("docTreeSplitSize")]
                    [Validation(Required=false)]
                    public int? DocTreeSplitSize { get; set; }

                    /// <summary>
                    /// <para>Enhance images.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enhanceGraph")]
                    [Validation(Required=false)]
                    public bool? EnhanceGraph { get; set; }

                    /// <summary>
                    /// <para>Enhance tables.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enhanceTable")]
                    [Validation(Required=false)]
                    public bool? EnhanceTable { get; set; }

                    /// <summary>
                    /// <para>The overlap length between chunks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("overlap")]
                    [Validation(Required=false)]
                    public int? Overlap { get; set; }

                    /// <summary>
                    /// <para>Split by sentence.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("sentenceSplit")]
                    [Validation(Required=false)]
                    public bool? SentenceSplit { get; set; }

                    /// <summary>
                    /// <para>The sentence-based splitting size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>160</para>
                    /// </summary>
                    [NameInMap("sentenceSplitSize")]
                    [Validation(Required=false)]
                    public int? SentenceSplitSize { get; set; }

                    /// <summary>
                    /// <para>The chunk size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>256</para>
                    /// </summary>
                    [NameInMap("size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    /// <summary>
                    /// <para>Enable chunking.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("split")]
                    [Validation(Required=false)]
                    public bool? Split { get; set; }

                }

                /// <summary>
                /// <para>Model configuration.</para>
                /// </summary>
                [NameInMap("modelConfig")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingModelConfig ModelConfig { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingModelConfig : TeaModel {
                    /// <summary>
                    /// <para>temperature</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("temperature")]
                    [Validation(Required=false)]
                    public double? Temperature { get; set; }

                    /// <summary>
                    /// <para>topP</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("topP")]
                    [Validation(Required=false)]
                    public double? TopP { get; set; }

                }

                /// <summary>
                /// <para>The prompt role style.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你是一个信息处理专家。</para>
                /// </summary>
                [NameInMap("promptRoleStyle")]
                [Validation(Required=false)]
                public string PromptRoleStyle { get; set; }

                /// <summary>
                /// <para>Query enhancement settings.</para>
                /// </summary>
                [NameInMap("queryEnhancer")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingQueryEnhancer QueryEnhancer { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingQueryEnhancer : TeaModel {
                    /// <summary>
                    /// <para>Enable multi-turn query enhancement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableFollowUp")]
                    [Validation(Required=false)]
                    public bool? EnableFollowUp { get; set; }

                    /// <summary>
                    /// <para>Use Large Language Model (LLM) knowledge to decompose queries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableMultiQuery")]
                    [Validation(Required=false)]
                    public bool? EnableMultiQuery { get; set; }

                    /// <summary>
                    /// <para>Use Large Language Model (LLM) knowledge to answer questions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableOpenQa")]
                    [Validation(Required=false)]
                    public bool? EnableOpenQa { get; set; }

                    /// <summary>
                    /// <para>Rewrite queries using domain-specific knowledge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableQueryRewrite")]
                    [Validation(Required=false)]
                    public bool? EnableQueryRewrite { get; set; }

                    /// <summary>
                    /// <para>Record session history.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableSession")]
                    [Validation(Required=false)]
                    public bool? EnableSession { get; set; }

                    /// <summary>
                    /// <para>The document library ID used for knowledge rewriting.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2836482634</para>
                    /// </summary>
                    [NameInMap("localKnowledgeId")]
                    [Validation(Required=false)]
                    public string LocalKnowledgeId { get; set; }

                    /// <summary>
                    /// <para>Include document references in responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("withDocumentReference")]
                    [Validation(Required=false)]
                    public bool? WithDocumentReference { get; set; }

                }

                /// <summary>
                /// <para>The recall strategy.</para>
                /// </summary>
                [NameInMap("recallStrategy")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingRecallStrategy RecallStrategy { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingRecallStrategy : TeaModel {
                    /// <summary>
                    /// <para>The merge and sort policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>model</para>
                    /// </summary>
                    [NameInMap("documentRankType")]
                    [Validation(Required=false)]
                    public string DocumentRankType { get; set; }

                    /// <summary>
                    /// <para>The number of results returned after merging two recall paths.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("limit")]
                    [Validation(Required=false)]
                    public int? Limit { get; set; }

                }

                /// <summary>
                /// <para>Text index settings.</para>
                /// </summary>
                [NameInMap("textIndexSetting")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingTextIndexSetting TextIndexSetting { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingTextIndexSetting : TeaModel {
                    /// <summary>
                    /// <para>The text index type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ElasticSearch</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Enable text indexing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The text index analyzer: Standard, IkMaxWord, or IkSmart.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IkMaxWord</para>
                    /// </summary>
                    [NameInMap("indexAnalyzer")]
                    [Validation(Required=false)]
                    public string IndexAnalyzer { get; set; }

                    /// <summary>
                    /// <para>The ranking threshold for text indexing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("rankThreshold")]
                    [Validation(Required=false)]
                    public double? RankThreshold { get; set; }

                    /// <summary>
                    /// <para>The text index search analyzer: Standard, IkMaxWord, or IkSmart.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Standard</para>
                    /// </summary>
                    [NameInMap("searchAnalyzer")]
                    [Validation(Required=false)]
                    public string SearchAnalyzer { get; set; }

                    /// <summary>
                    /// <para>The number of final summary results from text indexing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("topK")]
                    [Validation(Required=false)]
                    public int? TopK { get; set; }

                }

                /// <summary>
                /// <para>Vector index settings.</para>
                /// </summary>
                [NameInMap("vectorIndexSetting")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingVectorIndexSetting VectorIndexSetting { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingVectorIndexSetting : TeaModel {
                    /// <summary>
                    /// <para>The vector index source. We recommend ADB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ADB</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The text embedding model for the vector index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DashScope</para>
                    /// </summary>
                    [NameInMap("embeddingType")]
                    [Validation(Required=false)]
                    public string EmbeddingType { get; set; }

                    /// <summary>
                    /// <para>Enable vector indexing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The ranking threshold for vector indexing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("rankThreshold")]
                    [Validation(Required=false)]
                    public double? RankThreshold { get; set; }

                    /// <summary>
                    /// <para>Number of final results returned by the vector index.</para>
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
            /// <para>The document library name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试文档库</para>
            /// </summary>
            [NameInMap("libraryName")]
            [Validation(Required=false)]
            public string LibraryName { get; set; }

        }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Fault type</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44BD277A-87F9-5310-8D63-3E6645F1DA85</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>UNIX timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
