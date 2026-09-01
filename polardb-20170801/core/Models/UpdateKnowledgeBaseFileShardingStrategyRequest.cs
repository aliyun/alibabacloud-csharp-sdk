// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKnowledgeBaseFileShardingStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the knowledge base file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e347ddb8-49bb-5c66-94bc-fa05cedaeac8</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore inheritance of the chunking strategy from the knowledge space. When this parameter is set to true, ShardingStrategyConfig cannot be specified at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InheritSpaceStrategy")]
        [Validation(Required=false)]
        public bool? InheritSpaceStrategy { get; set; }

        /// <summary>
        /// <para>The unique ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-2zesv6l6a63xsrym</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the knowledge base resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The file-level chunking strategy configuration. This parameter is required when InheritSpaceStrategy is not set to true.</para>
        /// </summary>
        [NameInMap("ShardingStrategyConfig")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfig ShardingStrategyConfig { get; set; }
        public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfig : TeaModel {
            /// <summary>
            /// <para>The default chunking strategy. This strategy is used when no rule is matched.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DefaultStrategy")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigDefaultStrategy DefaultStrategy { get; set; }
            public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigDefaultStrategy : TeaModel {
                /// <summary>
                /// <para>The parameters of the default chunking strategy. MaxTokens and MergePeers are supported only when Type is set to hybrid.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigDefaultStrategyParameters Parameters { get; set; }
                public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigDefaultStrategyParameters : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of tokens per chunk. The value must be a positive integer. This parameter takes effect only when Type is set to hybrid.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>512</para>
                    /// </summary>
                    [NameInMap("MaxTokens")]
                    [Validation(Required=false)]
                    public int? MaxTokens { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to merge adjacent small chunks under the same heading. This parameter takes effect only when Type is set to hybrid.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MergePeers")]
                    [Validation(Required=false)]
                    public bool? MergePeers { get; set; }

                }

                /// <summary>
                /// <para>The type of the default chunking strategy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hybrid: Splits by document structure and limits the token count.</description></item>
                /// <item><description>hierarchical: Splits only by document structure.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
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
            public List<UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRules> Rules { get; set; }
            public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRules : TeaModel {
                /// <summary>
                /// <para>The rule match condition. Currently, only exact matching by content type for table content is supported.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Match")]
                [Validation(Required=false)]
                public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesMatch Match { get; set; }
                public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesMatch : TeaModel {
                    /// <summary>
                    /// <para>The content type. Currently, only table is supported, which matches content that is parsed as tables.</para>
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
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesStrategy Strategy { get; set; }
                public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesStrategy : TeaModel {
                    /// <summary>
                    /// <para>The chunking strategy parameters of the override rule. MaxTokens takes effect only when Type is set to hybrid. MarkdownTables supports auto, on, or off.</para>
                    /// </summary>
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesStrategyParameters Parameters { get; set; }
                    public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesStrategyParameters : TeaModel {
                        /// <summary>
                        /// <para>The Markdown table processing mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>auto: Automatically determines the processing mode.</description></item>
                        /// <item><description>on: Forcefully enables Markdown table processing.</description></item>
                        /// <item><description>off: Disables Markdown table processing.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>auto</para>
                        /// </summary>
                        [NameInMap("MarkdownTables")]
                        [Validation(Required=false)]
                        public string MarkdownTables { get; set; }

                        /// <summary>
                        /// <para>The maximum number of tokens per chunk for matched content. The value must be a positive integer. This parameter takes effect only when Type is set to hybrid.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>512</para>
                        /// </summary>
                        [NameInMap("MaxTokens")]
                        [Validation(Required=false)]
                        public int? MaxTokens { get; set; }

                    }

                    /// <summary>
                    /// <para>The chunking strategy type of the override rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>hybrid</description></item>
                    /// <item><description>hierarchical</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
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
