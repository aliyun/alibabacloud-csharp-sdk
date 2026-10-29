// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListChunksRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. This parameter is used together with Namespace and KnowledgeBaseName to locate the knowledge base. You can obtain the value by calling the ListCatalogs operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. If you specify this parameter, only the chunks of the specified document are listed, sorted in ascending order of ChunkSeq within the document. If you do not specify this parameter, the chunks of all documents in the knowledge base are listed, sorted in ascending lexicographical order of DocumentId and then in ascending order of ChunkSeq within the same document, with chunks arranged consecutively. In full-base mode, Keyword filtering is not supported. Use SearchKnowledgeBase instead. In addition, TotalCount is not returned in full-base mode. Pagination ends when NextToken is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-bp1xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>Optional. If you set this parameter to true, only enabled chunks are returned. If you set it to false, only disabled chunks are returned. If you do not specify this parameter, all chunks are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Optional. This parameter is active only when DocumentId is specified. It filters chunks by keywords in the chunk content. Only chunks that contain the specified keyword are returned. If you specify this parameter in full-base pattern (when DocumentId is not specified), an error is reported. To retrieve full-text content, use SearchKnowledgeBase (set Mode to KEYWORD for full-text index).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Install</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be unique within the namespace. It is specified upon creation and cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page. If you do not specify this parameter or set it to 0, the default value 20 is used. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. This parameter is used together with Catalog and KnowledgeBaseName to locate the knowledge base. You can obtain the value by calling the ListNamespaces operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>You do not need to specify this parameter for the first query. For subsequent queries, use the NextToken value returned in the previous response. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca1eb85f5d99c7d6a97e6****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
