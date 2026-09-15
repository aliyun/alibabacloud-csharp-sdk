// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SearchLumaKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The name of the Agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_agent</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The name of the data catalog bound to the Agent. You can call ListLumaCatalogs to obtain the catalog name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base bound to the Agent. You can call ListLumaKnowledgeBases to obtain the knowledge base name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>A JSON string that filters the retrieval scope based on document metadata. For available fields, refer to the MetadataSchema of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;category&quot;:&quot;faq&quot;}</para>
        /// </summary>
        [NameInMap("MetadataFilter")]
        [Validation(Required=false)]
        public string MetadataFilter { get; set; }

        /// <summary>
        /// <para>Valid values: vector (AISearch), keyword (keyword match), hybrid (hybrid search). If not specified, the retrieve configuration of the knowledge base is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hybrid</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The name of the namespace bound to the Agent. You can call ListLumaNamespaces to obtain the namespace name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The natural language query for retrieval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How to configure event rules</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable reranking for the retrieved results. Reranking improves accuracy but increases latency. If not specified, the retrieval configuration of the knowledge base is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Rerank")]
        [Validation(Required=false)]
        public bool? Rerank { get; set; }

        /// <summary>
        /// <para>Valid values: 1 to 100. If not specified, the retrieval configuration of the knowledge base is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

    }

}
