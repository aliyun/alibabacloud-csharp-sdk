// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SearchKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. This parameter, together with Namespace and KnowledgeBaseName, uniquely identifies a knowledge base. You can call ListCatalogs to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name is unique within a namespace and is specified at creation time. It cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>Filters search results by document metadata. The value is a JSON expression tree. Nodes are classified into two types: logical nodes {&quot;AndAll&quot;: [child nodes...]} (all conditions must be met), {&quot;OrAll&quot;: [child nodes...]} (any condition must be met), or {&quot;NotAll&quot;: [child nodes...]} (none of the conditions must be met), which support arbitrary nesting; and leaf conditions {&quot;Key&quot;: field name, &quot;Operator&quot;: operator, &quot;Value&quot;: value}, where the In and NotIn operators use &quot;Values&quot;: [values...]. Valid values of Operator: Equals, NotEquals, In, NotIn, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual (the last four range operators apply only to LONG, DOUBLE, or DATETIME fields), StartsWith, and StringContains (applies only to STRING fields). Fields must be declared in the knowledge base schema. The nesting depth cannot exceed 5, and the total number of leaf conditions cannot exceed 20. DATETIME field value format: ISO-8601 with time zone, yyyy-MM-dd HH:mm:ss, or yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AndAll&quot;: [{&quot;Key&quot;: &quot;env&quot;, &quot;Operator&quot;: &quot;In&quot;, &quot;Values&quot;: [&quot;prod&quot;, &quot;staging&quot;]}, {&quot;OrAll&quot;: [{&quot;Key&quot;: &quot;score&quot;, &quot;Operator&quot;: &quot;GreaterThan&quot;, &quot;Value&quot;: &quot;0.8&quot;}, {&quot;Key&quot;: &quot;owner&quot;, &quot;Operator&quot;: &quot;Equals&quot;, &quot;Value&quot;: &quot;alice&quot;}]}]}</para>
        /// </summary>
        [NameInMap("MetadataFilter")]
        [Validation(Required=false)]
        public string MetadataFilter { get; set; }

        /// <summary>
        /// <para>The retrieval mode. KEYWORD indicates keyword retrieval. VECTOR indicates vector retrieval. HYBRID indicates hybrid retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HYBRID</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. This parameter, together with Catalog and KnowledgeBaseName, uniquely identifies a knowledge base. You can call ListNamespaces to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The query text. Both keyword retrieval and vector retrieval are based on this text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How to configure event rules</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Optional. Overrides the fusion algorithm configured for the knowledge base for this request. This parameter takes effect only in hybrid search (HYBRID) mode. RRF indicates reciprocal rank fusion. WEIGHTED indicates weighted normalization fusion (used together with VectorWeight). If you set this parameter to WEIGHTED in keyword-only or vector-only mode, an InvalidParameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("RankAlgorithm")]
        [Validation(Required=false)]
        public string RankAlgorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable reranking for search results. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Rerank")]
        [Validation(Required=false)]
        public bool? Rerank { get; set; }

        /// <summary>
        /// <para>Optional. Overrides the reranking model configured for the knowledge base for this request. This parameter takes effect when reranking is enabled (in all search modes). Valid values: qwen3-rerank, gte-rerank-v2, and qwen3-vl-rerank. If this parameter is not specified, the value configured for the knowledge base is used. If no value is configured, the default value qwen3-rerank is used. Score distributions differ across models and cannot be compared. Use the same model consistently for a given knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-rerank</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModel { get; set; }

        /// <summary>
        /// <para>Optional. Overrides the reciprocal rank fusion (RRF) parameter k configured for the knowledge base for this request. This parameter takes effect only in hybrid search (HYBRID) mode. The value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RrfK")]
        [Validation(Required=false)]
        public int? RrfK { get; set; }

        /// <summary>
        /// <para>The number of most relevant results to return. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>Optional. The vector weight for the WEIGHTED fusion algorithm. Valid values: 0 to 1. The keyword weight equals 1 minus this value. If this parameter is not specified, the value configured for the knowledge base is used. If no value is configured, the default value 0.7 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("VectorWeight")]
        [Validation(Required=false)]
        public double? VectorWeight { get; set; }

    }

}
