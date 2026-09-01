// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeSpaceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The access control list (ACL) mode of the knowledge space. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DISABLED</description></item>
        /// <item><description>ENFORCED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENFORCED</para>
        /// </summary>
        [NameInMap("ACLMode")]
        [Validation(Required=false)]
        public string ACLMode { get; set; }

        /// <summary>
        /// <para>The time when the knowledge space was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-25T09:53:44Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar_rag_meta</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL</description></item>
        /// <item><description>PostgreSQL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The description of the knowledge space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The vector dimensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1536</para>
        /// </summary>
        [NameInMap("EmbeddingDimension")]
        [Validation(Required=false)]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// <para>The embedding model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// <para>The total number of knowledge bases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KnowledgeBaseCount")]
        [Validation(Required=false)]
        public int? KnowledgeBaseCount { get; set; }

        /// <summary>
        /// <para>The unique identifier of the knowledge space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pks-xxxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeSpaceId")]
        [Validation(Required=false)]
        public string KnowledgeSpaceId { get; set; }

        /// <summary>
        /// <para>The large language model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.6-plus</para>
        /// </summary>
        [NameInMap("LLMModel")]
        [Validation(Required=false)]
        public string LLMModel { get; set; }

        /// <summary>
        /// <para>The name of the knowledge space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>OSS Bucket</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The reranking model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-rerank</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModel { get; set; }

        /// <summary>
        /// <para>The chunk size in tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("ShardSize")]
        [Validation(Required=false)]
        public int? ShardSize { get; set; }

        /// <summary>
        /// <para>The default chunking strategy configuration of the knowledge space. This parameter may be empty if existing instances do not have the complete configuration saved.</para>
        /// </summary>
        [NameInMap("ShardingStrategyConfig")]
        [Validation(Required=false)]
        public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfig ShardingStrategyConfig { get; set; }
        public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfig : TeaModel {
            /// <summary>
            /// <para>The default chunking strategy. This strategy is used when no rule is matched.</para>
            /// </summary>
            [NameInMap("DefaultStrategy")]
            [Validation(Required=false)]
            public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigDefaultStrategy DefaultStrategy { get; set; }
            public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigDefaultStrategy : TeaModel {
                /// <summary>
                /// <para>The parameter details.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigDefaultStrategyParameters Parameters { get; set; }
                public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigDefaultStrategyParameters : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of tokens in a single chunk.</para>
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
            /// <para>The list of override rules that are matched in order.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRules> Rules { get; set; }
            public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRules : TeaModel {
                /// <summary>
                /// <para>The content type. Currently, table is supported.</para>
                /// </summary>
                [NameInMap("Match")]
                [Validation(Required=false)]
                public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesMatch Match { get; set; }
                public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesMatch : TeaModel {
                    /// <summary>
                    /// <para>The content type. Currently, table is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>table</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                }

                /// <summary>
                /// <para>The chunking strategy.</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesStrategy Strategy { get; set; }
                public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesStrategy : TeaModel {
                    /// <summary>
                    /// <para>The parameter details.</para>
                    /// </summary>
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesStrategyParameters Parameters { get; set; }
                    public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesStrategyParameters : TeaModel {
                        /// <summary>
                        /// <para>The Markdown table processing mode. Valid values: auto, on, or off.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>auto</para>
                        /// </summary>
                        [NameInMap("MarkdownTables")]
                        [Validation(Required=false)]
                        public string MarkdownTables { get; set; }

                        /// <summary>
                        /// <para>The maximum number of tokens in a single chunk for matched content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>512</para>
                        /// </summary>
                        [NameInMap("MaxTokens")]
                        [Validation(Required=false)]
                        public int? MaxTokens { get; set; }

                    }

                    /// <summary>
                    /// <para>The chunking strategy type used when a rule is matched.</para>
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

        /// <summary>
        /// <para>The instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Activation</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The chunking strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hybrid</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The total number of documents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalDocs")]
        [Validation(Required=false)]
        public int? TotalDocs { get; set; }

        /// <summary>
        /// <para>The total size in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>318881</para>
        /// </summary>
        [NameInMap("TotalSizeBytes")]
        [Validation(Required=false)]
        public long? TotalSizeBytes { get; set; }

    }

}
