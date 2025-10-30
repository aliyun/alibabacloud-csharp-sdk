// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ChatWithKnowledgeBaseStreamRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeKnowledgeBaseResults")]
        [Validation(Required=false)]
        public bool? IncludeKnowledgeBaseResults { get; set; }

        [NameInMap("KnowledgeParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseStreamRequestKnowledgeParams KnowledgeParams { get; set; }
        public class ChatWithKnowledgeBaseStreamRequestKnowledgeParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;RRF&quot;</para>
            /// </summary>
            [NameInMap("MergeMethod")]
            [Validation(Required=false)]
            public string MergeMethod { get; set; }

            [NameInMap("MergeMethodArgs")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgs MergeMethodArgs { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgs : TeaModel {
                [NameInMap("Rrf")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsRrf Rrf { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsRrf : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("K")]
                    [Validation(Required=false)]
                    public long? K { get; set; }

                }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsWeight Weight { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsWeight : TeaModel {
                    [NameInMap("Weights")]
                    [Validation(Required=false)]
                    public List<double?> Weights { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("RerankFactor")]
            [Validation(Required=false)]
            public double? RerankFactor { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SourceCollection")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollection> SourceCollection { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollection : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_index_adb_50943_prod</para>
                /// </summary>
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ddstar_vector</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespacePassword</para>
                /// </summary>
                [NameInMap("NamespacePassword")]
                [Validation(Required=false)]
                public string NamespacePassword { get; set; }

                [NameInMap("QueryParams")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParams QueryParams { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParams : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>method_id=\&quot;e41695f0-2851-40ac-b21d-dd337b60d71c\&quot;</para>
                    /// </summary>
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public string Filter { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("GraphEnhance")]
                    [Validation(Required=false)]
                    public bool? GraphEnhance { get; set; }

                    [NameInMap("GraphSearchArgs")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                    public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("GraphTopK")]
                        [Validation(Required=false)]
                        public long? GraphTopK { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Cascaded</para>
                    /// </summary>
                    [NameInMap("HybridSearch")]
                    [Validation(Required=false)]
                    public string HybridSearch { get; set; }

                    [NameInMap("HybridSearchArgs")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> HybridSearchArgs { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cosine</para>
                    /// </summary>
                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public string Metrics { get; set; }

                    [NameInMap("RecallWindow")]
                    [Validation(Required=false)]
                    public List<long?> RecallWindow { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RerankFactor")]
                    [Validation(Required=false)]
                    public double? RerankFactor { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>101</para>
                    /// </summary>
                    [NameInMap("TopK")]
                    [Validation(Required=false)]
                    public long? TopK { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("UseFullTextRetrieval")]
                    [Validation(Required=false)]
                    public bool? UseFullTextRetrieval { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public long? TopK { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseStreamRequestModelParams ModelParams { get; set; }
        public class ChatWithKnowledgeBaseStreamRequestModelParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("MaxTokens")]
            [Validation(Required=false)]
            public long? MaxTokens { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamRequestModelParamsMessages> Messages { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestModelParamsMessages : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("N")]
            [Validation(Required=false)]
            public long? N { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("PresencePenalty")]
            [Validation(Required=false)]
            public double? PresencePenalty { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("Seed")]
            [Validation(Required=false)]
            public long? Seed { get; set; }

            [NameInMap("Stop")]
            [Validation(Required=false)]
            public List<string> Stop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Temperature")]
            [Validation(Required=false)]
            public double? Temperature { get; set; }

            [NameInMap("Tools")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamRequestModelParamsTools> Tools { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestModelParamsTools : TeaModel {
                [NameInMap("Function")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestModelParamsToolsFunction Function { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestModelParamsToolsFunction : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>get_weather</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;type&quot;: &quot;object&quot;, ...}</para>
                    /// </summary>
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public object Parameters { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("TopP")]
            [Validation(Required=false)]
            public double? TopP { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PromptParams")]
        [Validation(Required=false)]
        public string PromptParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
