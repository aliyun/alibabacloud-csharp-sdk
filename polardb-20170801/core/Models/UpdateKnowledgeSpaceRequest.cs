// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKnowledgeSpaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pks-xxxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeSpaceId")]
        [Validation(Required=false)]
        public string KnowledgeSpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen3.6-plus</para>
        /// </summary>
        [NameInMap("LLMModel")]
        [Validation(Required=false)]
        public string LLMModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen3-rerank</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModel { get; set; }

        [NameInMap("ShardingStrategyConfig")]
        [Validation(Required=false)]
        public UpdateKnowledgeSpaceRequestShardingStrategyConfig ShardingStrategyConfig { get; set; }
        public class UpdateKnowledgeSpaceRequestShardingStrategyConfig : TeaModel {
            [NameInMap("DefaultStrategy")]
            [Validation(Required=false)]
            public UpdateKnowledgeSpaceRequestShardingStrategyConfigDefaultStrategy DefaultStrategy { get; set; }
            public class UpdateKnowledgeSpaceRequestShardingStrategyConfigDefaultStrategy : TeaModel {
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public UpdateKnowledgeSpaceRequestShardingStrategyConfigDefaultStrategyParameters Parameters { get; set; }
                public class UpdateKnowledgeSpaceRequestShardingStrategyConfigDefaultStrategyParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>512</para>
                    /// </summary>
                    [NameInMap("MaxTokens")]
                    [Validation(Required=false)]
                    public int? MaxTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MergePeers")]
                    [Validation(Required=false)]
                    public bool? MergePeers { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hybrid</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeSpaceRequestShardingStrategyConfigRules> Rules { get; set; }
            public class UpdateKnowledgeSpaceRequestShardingStrategyConfigRules : TeaModel {
                [NameInMap("Match")]
                [Validation(Required=false)]
                public UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesMatch Match { get; set; }
                public class UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesMatch : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                }

                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesStrategy Strategy { get; set; }
                public class UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesStrategy : TeaModel {
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesStrategyParameters Parameters { get; set; }
                    public class UpdateKnowledgeSpaceRequestShardingStrategyConfigRulesStrategyParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>auto</para>
                        /// </summary>
                        [NameInMap("MarkdownTables")]
                        [Validation(Required=false)]
                        public string MarkdownTables { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>512</para>
                        /// </summary>
                        [NameInMap("MaxTokens")]
                        [Validation(Required=false)]
                        public int? MaxTokens { get; set; }

                    }

                    /// <summary>
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
