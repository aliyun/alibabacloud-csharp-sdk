// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetLibraryResponseBody : TeaModel {
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

            [NameInMap("documentCount")]
            [Validation(Required=false)]
            public long? DocumentCount { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

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
                    [NameInMap("docTreeSplit")]
                    [Validation(Required=false)]
                    public bool? DocTreeSplit { get; set; }

                    [NameInMap("docTreeSplitSize")]
                    [Validation(Required=false)]
                    public int? DocTreeSplitSize { get; set; }

                    [NameInMap("enhanceGraph")]
                    [Validation(Required=false)]
                    public bool? EnhanceGraph { get; set; }

                    [NameInMap("enhanceTable")]
                    [Validation(Required=false)]
                    public bool? EnhanceTable { get; set; }

                    [NameInMap("overlap")]
                    [Validation(Required=false)]
                    public int? Overlap { get; set; }

                    [NameInMap("sentenceSplit")]
                    [Validation(Required=false)]
                    public bool? SentenceSplit { get; set; }

                    [NameInMap("sentenceSplitSize")]
                    [Validation(Required=false)]
                    public int? SentenceSplitSize { get; set; }

                    [NameInMap("size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    [NameInMap("split")]
                    [Validation(Required=false)]
                    public bool? Split { get; set; }

                }

                [NameInMap("modelConfig")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingModelConfig ModelConfig { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingModelConfig : TeaModel {
                    [NameInMap("temperature")]
                    [Validation(Required=false)]
                    public double? Temperature { get; set; }

                    /// <summary>
                    /// topP
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
                    [NameInMap("enableFollowUp")]
                    [Validation(Required=false)]
                    public bool? EnableFollowUp { get; set; }

                    [NameInMap("enableMultiQuery")]
                    [Validation(Required=false)]
                    public bool? EnableMultiQuery { get; set; }

                    [NameInMap("enableOpenQa")]
                    [Validation(Required=false)]
                    public bool? EnableOpenQa { get; set; }

                    [NameInMap("enableQueryRewrite")]
                    [Validation(Required=false)]
                    public bool? EnableQueryRewrite { get; set; }

                    [NameInMap("enableSession")]
                    [Validation(Required=false)]
                    public bool? EnableSession { get; set; }

                    [NameInMap("localKnowledgeId")]
                    [Validation(Required=false)]
                    public string LocalKnowledgeId { get; set; }

                    [NameInMap("withDocumentReference")]
                    [Validation(Required=false)]
                    public bool? WithDocumentReference { get; set; }

                }

                [NameInMap("recallStrategy")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingRecallStrategy RecallStrategy { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingRecallStrategy : TeaModel {
                    [NameInMap("documentRankType")]
                    [Validation(Required=false)]
                    public string DocumentRankType { get; set; }

                    [NameInMap("limit")]
                    [Validation(Required=false)]
                    public int? Limit { get; set; }

                }

                [NameInMap("textIndexSetting")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingTextIndexSetting TextIndexSetting { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingTextIndexSetting : TeaModel {
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("indexAnalyzer")]
                    [Validation(Required=false)]
                    public string IndexAnalyzer { get; set; }

                    [NameInMap("rankThreshold")]
                    [Validation(Required=false)]
                    public double? RankThreshold { get; set; }

                    [NameInMap("searchAnalyzer")]
                    [Validation(Required=false)]
                    public string SearchAnalyzer { get; set; }

                    [NameInMap("topK")]
                    [Validation(Required=false)]
                    public int? TopK { get; set; }

                }

                [NameInMap("vectorIndexSetting")]
                [Validation(Required=false)]
                public GetLibraryResponseBodyDataIndexSettingVectorIndexSetting VectorIndexSetting { get; set; }
                public class GetLibraryResponseBodyDataIndexSettingVectorIndexSetting : TeaModel {
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("embeddingType")]
                    [Validation(Required=false)]
                    public string EmbeddingType { get; set; }

                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("rankThreshold")]
                    [Validation(Required=false)]
                    public double? RankThreshold { get; set; }

                    [NameInMap("topK")]
                    [Validation(Required=false)]
                    public int? TopK { get; set; }

                }

            }

            [NameInMap("libraryName")]
            [Validation(Required=false)]
            public string LibraryName { get; set; }

        }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
