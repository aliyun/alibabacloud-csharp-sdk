// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class UpdateLibraryRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("indexSetting")]
        [Validation(Required=false)]
        public UpdateLibraryRequestIndexSetting IndexSetting { get; set; }
        public class UpdateLibraryRequestIndexSetting : TeaModel {
            [NameInMap("chunkStrategy")]
            [Validation(Required=false)]
            public UpdateLibraryRequestIndexSettingChunkStrategy ChunkStrategy { get; set; }
            public class UpdateLibraryRequestIndexSettingChunkStrategy : TeaModel {
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
            public UpdateLibraryRequestIndexSettingModelConfig ModelConfig { get; set; }
            public class UpdateLibraryRequestIndexSettingModelConfig : TeaModel {
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
            public UpdateLibraryRequestIndexSettingQueryEnhancer QueryEnhancer { get; set; }
            public class UpdateLibraryRequestIndexSettingQueryEnhancer : TeaModel {
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
            public UpdateLibraryRequestIndexSettingRecallStrategy RecallStrategy { get; set; }
            public class UpdateLibraryRequestIndexSettingRecallStrategy : TeaModel {
                [NameInMap("documentRankType")]
                [Validation(Required=false)]
                public string DocumentRankType { get; set; }

                [NameInMap("limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

            }

            [NameInMap("textIndexSetting")]
            [Validation(Required=false)]
            public UpdateLibraryRequestIndexSettingTextIndexSetting TextIndexSetting { get; set; }
            public class UpdateLibraryRequestIndexSettingTextIndexSetting : TeaModel {
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
            public UpdateLibraryRequestIndexSettingVectorIndexSetting VectorIndexSetting { get; set; }
            public class UpdateLibraryRequestIndexSettingVectorIndexSetting : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("libraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

    }

}
