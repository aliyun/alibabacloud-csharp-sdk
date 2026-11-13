// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListKnowledgePointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. This parameter is omitted when the request is successful. If the request fails, the common error response protocol is followed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The summaries of the knowledge points on the current page and the cursor for the next page.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListKnowledgePointsResponseBodyData Data { get; set; }
        public class ListKnowledgePointsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The summaries of the knowledge points that the current caller has permission to read on the current page. The KnowledgeBaseId, Type, and Id of each item can be directly used in the GetKnowledgePoint operation.</para>
            /// </summary>
            [NameInMap("KnowledgePoints")]
            [Validation(Required=false)]
            public List<ListKnowledgePointsResponseBodyDataKnowledgePoints> KnowledgePoints { get; set; }
            public class ListKnowledgePointsResponseBodyDataKnowledgePoints : TeaModel {
                /// <summary>
                /// <para>The read identifier of the current knowledge point. For GRAPH, it is the ID of the local graph entry node. For WIKI, it is the page ID. For KNOWLEDGE_CONTENT, it is the content ID. Use this value as is in the GetKnowledgePoint operation without parsing or concatenation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-sales</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The ID of the knowledge base to which the knowledge point belongs. This ID is used together with Type and Id to locate the knowledge point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678-1234-4234-8234-123456789abc</para>
                /// </summary>
                [NameInMap("KnowledgeBaseId")]
                [Validation(Required=false)]
                public string KnowledgeBaseId { get; set; }

                /// <summary>
                /// <para>The readable summary of the knowledge point. The summary is not guaranteed to contain the complete content. To obtain the details, call the GetKnowledgePoint operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales metrics and their associated order tables</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The readable title of the knowledge point. For GRAPH, the name of the entry node is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The read category of the knowledge point. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GRAPH: local graph.</description></item>
                /// <item><description>WIKI: topic page.</description></item>
                /// <item><description>KNOWLEDGE_CONTENT: knowledge content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GRAPH</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The pagination cursor. Do not specify this parameter for the first page. For subsequent pages, pass the NextToken value returned in the previous response as is, and keep the knowledge base, type, and page size unchanged. An empty cursor indicates that no more data is available. If the current page is empty but the cursor is not empty, continue querying.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of knowledge bases to return per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The readable description of the business error. This parameter is omitted when the request is successful. When troubleshooting a failure, provide the RequestId at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
