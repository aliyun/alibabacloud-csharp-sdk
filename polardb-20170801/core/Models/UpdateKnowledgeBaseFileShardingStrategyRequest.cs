// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKnowledgeBaseFileShardingStrategyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e347ddb8-49bb-5c66-94bc-fa05cedaeac8</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InheritSpaceStrategy")]
        [Validation(Required=false)]
        public bool? InheritSpaceStrategy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-2zesv6l6a63xsrym</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ShardingStrategyConfig")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfig ShardingStrategyConfig { get; set; }
        public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DefaultStrategy")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigDefaultStrategy DefaultStrategy { get; set; }
            public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigDefaultStrategy : TeaModel {
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigDefaultStrategyParameters Parameters { get; set; }
                public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigDefaultStrategyParameters : TeaModel {
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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hybrid</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRules> Rules { get; set; }
            public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRules : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Match")]
                [Validation(Required=false)]
                public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesMatch Match { get; set; }
                public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesMatch : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesStrategy Strategy { get; set; }
                public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesStrategy : TeaModel {
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesStrategyParameters Parameters { get; set; }
                    public class UpdateKnowledgeBaseFileShardingStrategyRequestShardingStrategyConfigRulesStrategyParameters : TeaModel {
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
