// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetLibraryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetLibraryResponseBodyData Data { get; set; }
        public class GetLibraryResponseBodyData : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("documentCount")]
            [Validation(Required=false)]
            public long? DocumentCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19386728376</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("indexSetting")]
            [Validation(Required=false)]
            public GetLibraryResponseBodyDataIndexSetting IndexSetting { get; set; }
            public class GetLibraryResponseBodyDataIndexSetting : TeaModel {
                [NameInMap("chunkStrategy")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingChunkStrategy ChunkStrategy { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingChunkStrategy : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("docTreeSplit")]
                    [Validation(Required=false)]
                    public bool? DocTreeSplit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>160</para>
                    /// </summary>
                    [NameInMap("docTreeSplitSize")]
                    [Validation(Required=false)]
                    public int? DocTreeSplitSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enhanceGraph")]
                    [Validation(Required=false)]
                    public bool? EnhanceGraph { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enhanceTable")]
                    [Validation(Required=false)]
                    public bool? EnhanceTable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("overlap")]
                    [Validation(Required=false)]
                    public int? Overlap { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("sentenceSplit")]
                    [Validation(Required=false)]
                    public bool? SentenceSplit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>160</para>
                    /// </summary>
                    [NameInMap("sentenceSplitSize")]
                    [Validation(Required=false)]
                    public int? SentenceSplitSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>256</para>
                    /// </summary>
                    [NameInMap("size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("split")]
                    [Validation(Required=false)]
                    public bool? Split { get; set; }

                }

                [NameInMap("modelConfig")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingModelConfig ModelConfig { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingModelConfig : TeaModel {
                    /// <summary>
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

                [NameInMap("promptRoleStyle")]
                [Validation(Required=false)]
                public string PromptRoleStyle { get; set; }

                [NameInMap("queryEnhancer")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingQueryEnhancer QueryEnhancer { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingQueryEnhancer : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableFollowUp")]
                    [Validation(Required=false)]
                    public bool? EnableFollowUp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableMultiQuery")]
                    [Validation(Required=false)]
                    public bool? EnableMultiQuery { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableOpenQa")]
                    [Validation(Required=false)]
                    public bool? EnableOpenQa { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableQueryRewrite")]
                    [Validation(Required=false)]
                    public bool? EnableQueryRewrite { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableSession")]
                    [Validation(Required=false)]
                    public bool? EnableSession { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2836482634</para>
                    /// </summary>
                    [NameInMap("localKnowledgeId")]
                    [Validation(Required=false)]
                    public string LocalKnowledgeId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("withDocumentReference")]
                    [Validation(Required=false)]
                    public bool? WithDocumentReference { get; set; }

                }

                [NameInMap("recallStrategy")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingRecallStrategy RecallStrategy { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingRecallStrategy : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>model</para>
                    /// </summary>
                    [NameInMap("documentRankType")]
                    [Validation(Required=false)]
                    public string DocumentRankType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("limit")]
                    [Validation(Required=false)]
                    public int? Limit { get; set; }

                }

                [NameInMap("textIndexSetting")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingTextIndexSetting TextIndexSetting { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingTextIndexSetting : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ElasticSearch</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>IkMaxWord</para>
                    /// </summary>
                    [NameInMap("indexAnalyzer")]
                    [Validation(Required=false)]
                    public string IndexAnalyzer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("rankThreshold")]
                    [Validation(Required=false)]
                    public double? RankThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Standard</para>
                    /// </summary>
                    [NameInMap("searchAnalyzer")]
                    [Validation(Required=false)]
                    public string SearchAnalyzer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("topK")]
                    [Validation(Required=false)]
                    public int? TopK { get; set; }

                }

                [NameInMap("vectorIndexSetting")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingVectorIndexSetting VectorIndexSetting { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingVectorIndexSetting : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ADB</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DashScope</para>
                    /// </summary>
                    [NameInMap("embeddingType")]
                    [Validation(Required=false)]
                    public string EmbeddingType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("rankThreshold")]
                    [Validation(Required=false)]
                    public double? RankThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("topK")]
                    [Validation(Required=false)]
                    public int? TopK { get; set; }

                }

            }

            [NameInMap("libraryName")]
            [Validation(Required=false)]
            public string LibraryName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44BD277A-87F9-5310-8D63-3E6645F1DA85</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
