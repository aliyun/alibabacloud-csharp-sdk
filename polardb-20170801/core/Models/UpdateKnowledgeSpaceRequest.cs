// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKnowledgeSpaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the knowledge space. The description can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The unique identifier of the knowledge space.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pks-xxxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeSpaceId")]
        [Validation(Required=false)]
        public string KnowledgeSpaceId { get; set; }

        /// <summary>
        /// <para>The name of the large language model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.6-plus</para>
        /// </summary>
        [NameInMap("LLMModel")]
        [Validation(Required=false)]
        public string LLMModel { get; set; }

        /// <summary>
        /// <para>The name of the knowledge space. The name must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the reranking model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-rerank</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModel { get; set; }

        /// <summary>
        /// <para>The default chunking strategy configuration for the knowledge space. Both simple strategies and composite strategies that match by content type are supported.</para>
        /// </summary>
        [NameInMap("ShardingStrategyConfig")]
        [Validation(Required=false)]
        public UpdateKnowledgeSpaceRequestShardingStrategyConfig ShardingStrategyConfig { get; set; }
        public class UpdateKnowledgeSpaceRequestShardingStrategyConfig : TeaModel {
            /// <summary>
            /// <para>The default chunking strategy. This strategy is used when no rule is matched.</para>
            /// </summary>
            [NameInMap("DefaultStrategy")]
            [Validation(Required=false)]
            public UpdateKnowledgeSpaceRequestShardingStrategyConfigDefaultStrategy DefaultStrategy { get; set; }
            public class UpdateKnowledgeSpaceRequestShardingStrategyConfigDefaultStrategy : TeaModel {
                /// <summary>
                /// <para>The parameters of the default chunking strategy. MaxTokens and MergePeers take effect only when Type is set to hybrid.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public UpdateKnowledgeSpaceRequestShardingStrategyConfigDefaultStrategyParameters Parameters { get; set; }
                public class UpdateKnowledgeSpaceRequestShardingStrategyConfigDefaultStrategyParameters : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of tokens per chunk. The value must be a positive integer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>512</para>
                    /// </summary>
                    [NameInMap("MaxTokens")]
                    [Validation(Required=false)]
                    public int? MaxTokens { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to merge adjacent small chunks under the same heading.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MergePeers")]
                    [Validation(Required=false)]
                    public bool? MergePeers { get; set; }

                }

                /// <summary>
                /// <para>The type of the default chunking strategy. Valid values: hybrid or hierarchical.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hybrid</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The list of override rules that are matched in order. Currently, a maximum of one exact-match rule with ContentType set to table is supported.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeSpaceRequestShardingStrategyConfigRules> Rules { get; set; }
            public class UpdateKnowledgeSpaceRequestShardingStrategyConfigRules : TeaModel {
                /// <summary>
                /// <para>The match condition of the rule. Currently, only exact matching of table content by content type is supported.</para>
                /// </summary>
                [NameInMap("Match")]
                [Validation(Required=false)]
                public UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesMatch Match { get; set; }
                public class UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesMatch : TeaModel {
                    /// <summary>
                    /// <para>The content type. Currently, only table is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>table</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                }

                /// <summary>
                /// <para>The chunking strategy to use when the rule is matched.</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesStrategy Strategy { get; set; }
                public class UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesStrategy : TeaModel {
                    /// <summary>
                    /// <para>The chunking strategy parameters for the override rule. MaxTokens takes effect only when Type is set to hybrid. MarkdownTables supports auto, on, or off.</para>
                    /// </summary>
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesStrategyParameters Parameters { get; set; }
                    public class UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesStrategyParameters : TeaModel {
                        /// <summary>
                        /// <para>The processing mode for Markdown tables. Valid values: auto, on, or off.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>auto</para>
                        /// </summary>
                        [NameInMap("MarkdownTables")]
                        [Validation(Required=false)]
                        public string MarkdownTables { get; set; }

                        /// <summary>
                        /// <para>The maximum number of tokens per chunk for matched content. The value must be a positive integer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>512</para>
                        /// </summary>
                        [NameInMap("MaxTokens")]
                        [Validation(Required=false)]
                        public int? MaxTokens { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of the chunking strategy to use when the rule is matched. Valid values: hybrid or hierarchical.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hierarchical</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
