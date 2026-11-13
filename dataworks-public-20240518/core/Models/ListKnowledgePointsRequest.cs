// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListKnowledgePointsRequest : TeaModel {
        /// <summary>
        /// <para>The stable ID of the target knowledge base. You can obtain the ID by calling the ListKnowledgeBases operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The maximum number of knowledge points to return per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination cursor. Do not specify this parameter for the first page. For subsequent pages, pass the NextToken value returned in the previous response as is, and keep the knowledge base, type, and page size unchanged. An empty cursor indicates that no more data is available. If the current page is empty but the cursor is not empty, continue querying.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The type of the knowledge point. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GRAPH: local graph entry.</description></item>
        /// <item><description>WIKI: Wiki page.</description></item>
        /// <item><description>KNOWLEDGE_CONTENT: knowledge content.
        /// If you do not specify this parameter, knowledge points of all types are listed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GRAPH</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
