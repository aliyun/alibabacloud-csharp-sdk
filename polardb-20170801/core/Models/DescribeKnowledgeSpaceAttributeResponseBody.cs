// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeSpaceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ENFORCED</para>
        /// </summary>
        [NameInMap("ACLMode")]
        [Validation(Required=false)]
        public string ACLMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-06-25T09:53:44Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>polar_rag_meta</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1536</para>
        /// </summary>
        [NameInMap("EmbeddingDimension")]
        [Validation(Required=false)]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KnowledgeBaseCount")]
        [Validation(Required=false)]
        public int? KnowledgeBaseCount { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen3-rerank</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("ShardSize")]
        [Validation(Required=false)]
        public int? ShardSize { get; set; }

        [NameInMap("ShardingStrategyConfig")]
        [Validation(Required=false)]
        public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfig ShardingStrategyConfig { get; set; }
        public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfig : TeaModel {
            [NameInMap("DefaultStrategy")]
            [Validation(Required=false)]
            public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigDefaultStrategy DefaultStrategy { get; set; }
            public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigDefaultStrategy : TeaModel {
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigDefaultStrategyParameters Parameters { get; set; }
                public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigDefaultStrategyParameters : TeaModel {
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
            public List<DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRules> Rules { get; set; }
            public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRules : TeaModel {
                [NameInMap("Match")]
                [Validation(Required=false)]
                public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesMatch Match { get; set; }
                public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesMatch : TeaModel {
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
                public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesStrategy Strategy { get; set; }
                public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesStrategy : TeaModel {
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesStrategyParameters Parameters { get; set; }
                    public class DescribeKnowledgeSpaceAttributeResponseBodyShardingStrategyConfigRulesStrategyParameters : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>Activation</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hybrid</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalDocs")]
        [Validation(Required=false)]
        public int? TotalDocs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>318881</para>
        /// </summary>
        [NameInMap("TotalSizeBytes")]
        [Validation(Required=false)]
        public long? TotalSizeBytes { get; set; }

    }

}
