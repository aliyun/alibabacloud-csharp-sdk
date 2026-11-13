// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RetrieveKnowledgePointsRequest : TeaModel {
        /// <summary>
        /// <para>The graph objects to focus the search on. You can specify up to 2 unique objects. The objects must be within the current authorized search scope and do not expand permissions.</para>
        /// </summary>
        [NameInMap("FocusObjects")]
        [Validation(Required=false)]
        public List<RetrieveKnowledgePointsRequestFocusObjects> FocusObjects { get; set; }
        public class RetrieveKnowledgePointsRequestFocusObjects : TeaModel {
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
            /// <para>The read category of the knowledge point. Use GRAPH for the current focus objects and graph nodes.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GRAPH</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>A list of 1 to 50 unique knowledge base IDs that restricts the search. If you omit this parameter, the operation discovers knowledge bases within the caller’s authorized scope. If you provide IDs, the operation checks access to each knowledge base and the entire request fails if the caller lacks access to any of them.</para>
        /// </summary>
        [NameInMap("KnowledgeBaseIds")]
        [Validation(Required=false)]
        public List<string> KnowledgeBaseIds { get; set; }

        /// <summary>
        /// <para>The maximum number of hits across all knowledge bases. Default value: 10. Valid values: 1 to 50. This parameter does not specify the quota for each knowledge base or the page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The natural language question. The length cannot exceed 256 Unicode code points after leading and trailing whitespaces are removed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How is sales revenue calculated, and which tables does it come from?</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
