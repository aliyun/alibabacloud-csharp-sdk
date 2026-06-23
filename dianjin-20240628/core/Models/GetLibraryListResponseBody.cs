// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetLibraryListResponseBody : TeaModel {
        /// <summary>
        /// <para>Time consumed</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetLibraryListResponseBodyData Data { get; set; }
        public class GetLibraryListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>Number of records per page</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Record list</para>
            /// </summary>
            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetLibraryListResponseBodyDataRecords> Records { get; set; }
            public class GetLibraryListResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>Document library description</para>
                /// 
                /// <b>Example:</b>
                /// <para>文档库</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Document count</para>
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
                /// <para>Modification time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Document library ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>24vs4aa42jv1rg7</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Document library index settings</para>
                /// </summary>
                [NameInMap("indexSetting")]
                [Validation(Required=false)]
                public GetLibraryListResponseBodyDataRecordsIndexSetting IndexSetting { get; set; }
                public class GetLibraryListResponseBodyDataRecordsIndexSetting : TeaModel {
                    /// <summary>
                    /// <para>Chunking strategy</para>
                    /// </summary>
                    [NameInMap("chunkStrategy")]
                    [Validation(Required=false)]
                    public GetLibraryListResponseBodyDataRecordsIndexSettingChunkStrategy ChunkStrategy { get; set; }
                    public class GetLibraryListResponseBodyDataRecordsIndexSettingChunkStrategy : TeaModel {
                        /// <summary>
                        /// <para>Layout chunking</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("docTreeSplit")]
                        [Validation(Required=false)]
                        public bool? DocTreeSplit { get; set; }

                        /// <summary>
                        /// <para>Layout chunking size</para>
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
                        /// <para>40</para>
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
                        /// <para>Split by sentence size</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>160</para>
                        /// </summary>
                        [NameInMap("sentenceSplitSize")]
                        [Validation(Required=false)]
                        public int? SentenceSplitSize { get; set; }

                        /// <summary>
                        /// <para>Chunk size</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>256</para>
                        /// </summary>
                        [NameInMap("size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        /// <summary>
                        /// <para>Chunking enabled</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("split")]
                        [Validation(Required=false)]
                        public bool? Split { get; set; }

                    }

                    /// <summary>
                    /// <para>Model Configuration</para>
                    /// </summary>
                    [NameInMap("modelConfig")]
                    [Validation(Required=false)]
                    public GetLibraryListResponseBodyDataRecordsIndexSettingModelConfig ModelConfig { get; set; }
                    public class GetLibraryListResponseBodyDataRecordsIndexSettingModelConfig : TeaModel {
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
                    /// <para>Prompt role style</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>你是一个信息处理专家。</para>
                    /// </summary>
                    [NameInMap("promptRoleStyle")]
                    [Validation(Required=false)]
                    public string PromptRoleStyle { get; set; }

                    /// <summary>
                    /// <para>Query enhancement</para>
                    /// </summary>
                    [NameInMap("queryEnhancer")]
                    [Validation(Required=false)]
                    public GetLibraryListResponseBodyDataRecordsIndexSettingQueryEnhancer QueryEnhancer { get; set; }
                    public class GetLibraryListResponseBodyDataRecordsIndexSettingQueryEnhancer : TeaModel {
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
                        /// <para>Use Large Language Model (LLM) knowledge to decompose questions</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enableMultiQuery")]
                        [Validation(Required=false)]
                        public bool? EnableMultiQuery { get; set; }

                        /// <summary>
                        /// <para>Use Large Language Model (LLM) knowledge to answer questions</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enableOpenQa")]
                        [Validation(Required=false)]
                        public bool? EnableOpenQa { get; set; }

                        /// <summary>
                        /// <para>Rewrite questions based on domain knowledge</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enableQueryRewrite")]
                        [Validation(Required=false)]
                        public bool? EnableQueryRewrite { get; set; }

                        /// <summary>
                        /// <para>Record session</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enableSession")]
                        [Validation(Required=false)]
                        public bool? EnableSession { get; set; }

                        /// <summary>
                        /// <para>Document library ID used for knowledge rewriting</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sdbcjsbc</para>
                        /// </summary>
                        [NameInMap("localKnowledgeId")]
                        [Validation(Required=false)]
                        public string LocalKnowledgeId { get; set; }

                        /// <summary>
                        /// <para>Include document reference</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("withDocumentReference")]
                        [Validation(Required=false)]
                        public bool? WithDocumentReference { get; set; }

                    }

                    /// <summary>
                    /// <para>Recall strategy</para>
                    /// </summary>
                    [NameInMap("recallStrategy")]
                    [Validation(Required=false)]
                    public GetLibraryListResponseBodyDataRecordsIndexSettingRecallStrategy RecallStrategy { get; set; }
                    public class GetLibraryListResponseBodyDataRecordsIndexSettingRecallStrategy : TeaModel {
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
                        /// <para>Number of results from two-way merge summary</para>
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
                    public GetLibraryListResponseBodyDataRecordsIndexSettingTextIndexSetting TextIndexSetting { get; set; }
                    public class GetLibraryListResponseBodyDataRecordsIndexSettingTextIndexSetting : TeaModel {
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
                        /// <para>Text index enabled</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>Index analyzer for text index: (Standard, IkMaxWord, IkSmart)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Standard</para>
                        /// </summary>
                        [NameInMap("indexAnalyzer")]
                        [Validation(Required=false)]
                        public string IndexAnalyzer { get; set; }

                        /// <summary>
                        /// <para>Text index sort threshold</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("rankThreshold")]
                        [Validation(Required=false)]
                        public double? RankThreshold { get; set; }

                        /// <summary>
                        /// <para>Search analyzer for text index: (Standard, IkMaxWord, IkSmart)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Standard</para>
                        /// </summary>
                        [NameInMap("searchAnalyzer")]
                        [Validation(Required=false)]
                        public string SearchAnalyzer { get; set; }

                        /// <summary>
                        /// <para>Number of final summary results for text index</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
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
                    public GetLibraryListResponseBodyDataRecordsIndexSettingVectorIndexSetting VectorIndexSetting { get; set; }
                    public class GetLibraryListResponseBodyDataRecordsIndexSettingVectorIndexSetting : TeaModel {
                        /// <summary>
                        /// <para>Vector index source. Recommended: ADB</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ADB</para>
                        /// </summary>
                        [NameInMap("category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>Vector index text embedding model</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DashScope</para>
                        /// </summary>
                        [NameInMap("embeddingType")]
                        [Validation(Required=false)]
                        public string EmbeddingType { get; set; }

                        /// <summary>
                        /// <para>Enabled</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>Vector index sort threshold</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("rankThreshold")]
                        [Validation(Required=false)]
                        public double? RankThreshold { get; set; }

                        /// <summary>
                        /// <para>Number of final summary results for vector index</para>
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
                /// <para>Document library name</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试文档库</para>
                /// </summary>
                [NameInMap("libraryName")]
                [Validation(Required=false)]
                public string LibraryName { get; set; }

            }

            /// <summary>
            /// <para>Total pages</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

            /// <summary>
            /// <para>Total records</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06dfe817156528535968405edce3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
