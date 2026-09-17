// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListChunksRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. This parameter, together with Namespace and KnowledgeBaseName, uniquely identifies a knowledge base. You can call ListCatalogs to obtain this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. If specified, only chunks of the specified document are returned, sorted by ChunkSeq in ascending order within the document. If not specified, chunks of all documents in the knowledge base are returned, sorted by DocumentId in lexicographic ascending order, and within the same document by ChunkSeq in ascending order, with chunks listed contiguously. In full knowledge base mode, Keyword filtering is not supported (use SearchKnowledgeBase instead), and TotalCount is not returned. Pagination ends when NextToken is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-bp1xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>Optional. Set to true to return only enabled chunks, or false to return only disabled chunks. If not specified, all chunks are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Optional. Active only when DocumentId is specified. Filters chunks by keyword in the chunk body. Only chunks that contain the specified keyword are returned. In full knowledge base pattern (when DocumentId is not specified), passing this parameter causes an error. To retrieve content across the full text, use SearchKnowledgeBase (set Mode to KEYWORD for full-text index).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Installation</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name is unique within a namespace and is determined at creation time. It cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page. If not specified or set to 0, the default value 20 is used. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. This parameter, together with Catalog and KnowledgeBaseName, uniquely identifies a knowledge base. You can call ListNamespaces to obtain this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Not required for the first query. For subsequent queries, pass the NextToken returned in the previous response. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca1eb85f5d99c7d6a97e6****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
