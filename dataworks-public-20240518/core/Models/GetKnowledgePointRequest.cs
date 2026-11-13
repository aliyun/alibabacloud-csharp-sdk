// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetKnowledgePointRequest : TeaModel {
        /// <summary>
        /// <para>The location ID of the knowledge point. Copy this value exactly as it appears in the search results and use it together with the corresponding KnowledgeBaseId and Type. Do not parse or convert this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node-sales</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base to which the knowledge point belongs. This parameter is used together with Type and Id to locate the knowledge point.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The maximum number of relationships to return per page. This parameter is valid only when Type is set to GRAPH. Default value: 20. Valid values: 1 to 100. This parameter is not supported for WIKI and KNOWLEDGE_CONTENT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination cursor. Do not specify this parameter when you request the first page. For subsequent pages, use the NextToken value returned in the previous response. An empty response indicates that no more pages are available. If the current page is empty but the cursor is not empty, continue pagination. This parameter is used only when Type is set to GRAPH. You must keep the same knowledge base, entry point, and MaxResults values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The read category of the knowledge point. Valid values: GRAPH for local graphs, WIKI for topic pages, and KNOWLEDGE_CONTENT for knowledge content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GRAPH</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
