// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SearchKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. This parameter, together with Namespace and KnowledgeBaseName, uniquely identifies the knowledge base. You can call ListCatalogs to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be unique within the namespace. The name is specified upon creation and cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>Filters search results by document metadata. The value is a JSON expression tree. Nodes are divided into two types: logical nodes and leaf conditions. Logical nodes include {&quot;AndAll&quot;: [child nodes...]} (all conditions met), {&quot;OrAll&quot;: [child nodes...]} (any condition met), and {&quot;NotAll&quot;: [child nodes...]} (no conditions met). Arbitrary nesting is supported. Leaf conditions are in the format of {&quot;Key&quot;: field name, &quot;Operator&quot;: operator, &quot;Value&quot;: value}. For the In and NotIn operators, use &quot;Values&quot;: [values...]. Valid values for Operator: Equals, NotEquals, In, NotIn, GreaterThan, GreaterThanOrEqual, LessThan, and LessThanOrEqual (the last four range operators apply only to LONG, DOUBLE, and DATETIME fields), StartsWith, and StringContains (applies only to STRING fields). The field must be declared in the knowledge base schema. The nesting depth cannot exceed 5, and the total number of leaf conditions cannot exceed 20. Valid formats for DATETIME field values: ISO-8601 with time zone, yyyy-MM-dd HH:mm:ss, or yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AndAll&quot;: [{&quot;Key&quot;: &quot;env&quot;, &quot;Operator&quot;: &quot;In&quot;, &quot;Values&quot;: [&quot;prod&quot;, &quot;staging&quot;]}, {&quot;OrAll&quot;: [{&quot;Key&quot;: &quot;score&quot;, &quot;Operator&quot;: &quot;GreaterThan&quot;, &quot;Value&quot;: &quot;0.8&quot;}, {&quot;Key&quot;: &quot;owner&quot;, &quot;Operator&quot;: &quot;Equals&quot;, &quot;Value&quot;: &quot;alice&quot;}]}]}</para>
        /// </summary>
        [NameInMap("MetadataFilter")]
        [Validation(Required=false)]
        public string MetadataFilter { get; set; }

        /// <summary>
        /// <para>The retrieve mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KEYWORD: keyword retrieve.</description></item>
        /// <item><description>VECTOR: AISearch.</description></item>
        /// <item><description>HYBRID: hybrid retrieve.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HYBRID</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. This parameter, together with Catalog and KnowledgeBaseName, uniquely identifies the knowledge base. You can call ListNamespaces to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The retrieve text. Both keyword retrieve and AISearch are based on this text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How to configure event rules</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Optional. Overrides the fusion algorithm configured for the knowledge base in this request. This parameter takes effect only in HYBRID search mode. Valid values: RRF for reciprocal rank fusion, and WEIGHTED for weighted normalization fusion (used with VectorWeight). If you set this parameter to WEIGHTED in KEYWORD or VECTOR single mode, the InvalidParameter error is returned.</para>
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
        /// <para>Optional. Overrides the reranking model configured for the knowledge base in this request. This parameter takes effect when reranking is enabled across all search modes. Valid values: qwen3-rerank, gte-rerank-v2, and qwen3-vl-rerank. If this parameter is not specified, the value configured for the knowledge base is used. If no value is configured, the default value is qwen3-rerank. Score distributions of different models cannot be compared horizontally. We recommend that you use a fixed model for each knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-rerank</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModel { get; set; }

        /// <summary>
        /// <para>Optional. Overrides the RRF fusion parameter k configured for the knowledge base in this request. This parameter takes effect only in HYBRID search mode and must be greater than 0.</para>
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
        /// <para>Optional. The vector path weight for the WEIGHTED fusion algorithm. Valid values: 0 to 1. The keyword path weight is 1 minus this value. If this parameter is not specified, the value configured for the knowledge base is used. If no value is configured, the default value is 0.7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("VectorWeight")]
        [Validation(Required=false)]
        public double? VectorWeight { get; set; }

    }

}
