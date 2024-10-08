// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateLibraryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("indexSetting")]
        [Validation(Required=false)]
        public CreateLibraryRequestIndexSetting IndexSetting { get; set; }
        public class CreateLibraryRequestIndexSetting : TeaModel {
            [NameInMap("chunkStrategy")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingChunkStrategy ChunkStrategy { get; set; }
            public class CreateLibraryRequestIndexSettingChunkStrategy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("docTreeSplit")]
                [Validation(Required=false)]
                public bool? DocTreeSplit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
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
                /// <para>20</para>
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
                /// <para>300</para>
                /// </summary>
                [NameInMap("sentenceSplitSize")]
                [Validation(Required=false)]
                public int? SentenceSplitSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
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
            public CreateLibraryRequestIndexSettingModelConfig ModelConfig { get; set; }
            public class CreateLibraryRequestIndexSettingModelConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

                /// <summary>
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
            public CreateLibraryRequestIndexSettingQueryEnhancer QueryEnhancer { get; set; }
            public class CreateLibraryRequestIndexSettingQueryEnhancer : TeaModel {
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
                /// <para>xxxx</para>
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
            public CreateLibraryRequestIndexSettingRecallStrategy RecallStrategy { get; set; }
            public class CreateLibraryRequestIndexSettingRecallStrategy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>model</para>
                /// </summary>
                [NameInMap("documentRankType")]
                [Validation(Required=false)]
                public string DocumentRankType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

            }

            [NameInMap("textIndexSetting")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingTextIndexSetting TextIndexSetting { get; set; }
            public class CreateLibraryRequestIndexSettingTextIndexSetting : TeaModel {
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
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("indexAnalyzer")]
                [Validation(Required=false)]
                public string IndexAnalyzer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
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
                /// <para>50</para>
                /// </summary>
                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

            }

            [NameInMap("vectorIndexSetting")]
            [Validation(Required=false)]
            public CreateLibraryRequestIndexSettingVectorIndexSetting VectorIndexSetting { get; set; }
            public class CreateLibraryRequestIndexSettingVectorIndexSetting : TeaModel {
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
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("rankThreshold")]
                [Validation(Required=false)]
                public double? RankThreshold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("libraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

    }

}
