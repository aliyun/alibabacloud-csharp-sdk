// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class SearchKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The search text and the search configuration overrides for the current request. If the mode, count, fusion, and reranking parameters are omitted, the knowledge base configuration is used. If the knowledge base is not configured, the system default values specified in each field description are used. If metadataFilter is omitted, no metadata filtering is applied.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SearchKnowledgeBaseRequestBody Body { get; set; }
        public class SearchKnowledgeBaseRequestBody : TeaModel {
            /// <summary>
            /// <para>The JSON expression tree used to filter search results by document metadata. The maximum length is 8,192 characters. Logical nodes include {&quot;AndAll&quot;:[child nodes...]} (all conditions met), {&quot;OrAll&quot;:[child nodes...]} (any condition met), and {&quot;NotAll&quot;:[child nodes...]} (no conditions met). Nesting is supported. Leaf nodes are in the format of {&quot;Key&quot;:field name,&quot;Operator&quot;:operator,&quot;Value&quot;:value}. For In and NotIn operators, use &quot;Values&quot;:[values...]. Valid operators include Equals, NotEquals, In, NotIn, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, StartsWith, and StringContains. Range operators apply only to LONG, DOUBLE, and DATETIME types. String operators apply only to the STRING type. Fields must be declared in the metadataSchema of the knowledge base. The nesting depth cannot exceed 5, and the total number of leaf conditions cannot exceed 20. DATETIME values accept ISO-8601 format with time zone, yyyy-MM-dd HH:mm:ss, or yyyy-MM-dd. OTS DSL, system fields, and tenant control fields are not accepted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AndAll&quot;:[{&quot;Key&quot;:&quot;env&quot;,&quot;Operator&quot;:&quot;In&quot;,&quot;Values&quot;:[&quot;prod&quot;,&quot;staging&quot;]},{&quot;Key&quot;:&quot;score&quot;,&quot;Operator&quot;:&quot;GreaterThan&quot;,&quot;Value&quot;:&quot;0.8&quot;}]}</para>
            /// </summary>
            [NameInMap("metadataFilter")]
            [Validation(Required=false)]
            public string MetadataFilter { get; set; }

            /// <summary>
            /// <para>The search mode. KEYWORD indicates keyword retrieve, VECTOR indicates vector retrieve, and HYBRID indicates hybrid retrieve. If this parameter is omitted, the knowledge base configuration is used. If the knowledge base is not configured, the default value is HYBRID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The text used for both keyword retrieve and vector retrieve. The maximum length is 4,096 characters.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product documentation</para>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The fusion algorithm. RRF indicates reciprocal rank fusion, and WEIGHTED indicates weighted normalization fusion. This parameter takes effect only in HYBRID mode. If WEIGHTED is explicitly passed in a non-HYBRID mode, an InvalidParameter error is returned. If this parameter is omitted, the knowledge base configuration is used. If the knowledge base is not configured, the default value is RRF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RRF</para>
            /// </summary>
            [NameInMap("rankAlgorithm")]
            [Validation(Required=false)]
            public string RankAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable reranking. This parameter applies to the KEYWORD, VECTOR, and HYBRID modes. An explicit value overrides the knowledge base configuration. If this parameter is omitted, the knowledge base configuration is used. If the knowledge base is not configured, the default value is false.</para>
            /// </summary>
            [NameInMap("rerank")]
            [Validation(Required=false)]
            public bool? Rerank { get; set; }

            /// <summary>
            /// <para>The reranking model. This parameter takes effect in all search modes when reranking is enabled. Valid values: qwen3-rerank, qwen3.7-text-rerank, gte-rerank-v2, and qwen3-vl-rerank. If this parameter is omitted, the knowledge base configuration is used. If the knowledge base is not configured, the default value is qwen3-rerank. Do not compare score distributions across different models. Use the same model for a given knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-rerank</para>
            /// </summary>
            [NameInMap("rerankModel")]
            [Validation(Required=false)]
            public string RerankModel { get; set; }

            /// <summary>
            /// <para>The RRF fusion parameter k that overrides the knowledge base configuration for the current request. This parameter takes effect only in HYBRID mode and must be greater than 0. If this parameter is omitted, the knowledge base configuration is used. If the knowledge base is not configured, the default value is 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("rrfK")]
            [Validation(Required=false)]
            public int? RrfK { get; set; }

            /// <summary>
            /// <para>The expected number of results. Valid values: 1 to 100. If this parameter is omitted, the knowledge base configuration is used. If the knowledge base is not configured, the default value is 10. The actual number of results may be smaller after permission and filtering verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("topK")]
            [Validation(Required=false)]
            public int? TopK { get; set; }

            /// <summary>
            /// <para>The vector leg weight for WEIGHTED fusion. Valid values: 0 to 1. The keyword leg weight is 1 minus this value. If this parameter is omitted, the knowledge base configuration is used. If the knowledge base is not configured, the default value is 0.7.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7</para>
            /// </summary>
            [NameInMap("vectorWeight")]
            [Validation(Required=false)]
            public double? VectorWeight { get; set; }

        }

    }

}
