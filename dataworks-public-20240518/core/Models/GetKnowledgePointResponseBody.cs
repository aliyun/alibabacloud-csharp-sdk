// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetKnowledgePointResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. This parameter is omitted when the request is successful. For failures, the common error response protocol is followed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The typed details of a single knowledge point. Only the item corresponding to the Type value is returned among Graph, Wiki, and KnowledgeContent.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKnowledgePointResponseBodyData Data { get; set; }
        public class GetKnowledgePointResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The one-hop local graph with the requested Id as the entry point. This parameter is returned only when Type is set to GRAPH. It includes the entry point, the relationships on the current page, and their visible endpoints.</para>
            /// </summary>
            [NameInMap("Graph")]
            [Validation(Required=false)]
            public GetKnowledgePointResponseBodyDataGraph Graph { get; set; }
            public class GetKnowledgePointResponseBodyDataGraph : TeaModel {
                /// <summary>
                /// <para>The visible one-hop adjacency relationships on the current page. At least one end of each edge is the RootNodeId, and both ends are in the Nodes of the current page.</para>
                /// </summary>
                [NameInMap("Edges")]
                [Validation(Required=false)]
                public List<GetKnowledgePointResponseBodyDataGraphEdges> Edges { get; set; }
                public class GetKnowledgePointResponseBodyDataGraphEdges : TeaModel {
                    /// <summary>
                    /// <para>The readable supplementary description of the current node or relationship. This parameter is omitted when no reliable content is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales revenue is calculated based on the actual paid amount of orders</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The ID of the relationship in the current knowledge base graph.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>edge-sales-orders</para>
                    /// </summary>
                    [NameInMap("EdgeId")]
                    [Validation(Required=false)]
                    public string EdgeId { get; set; }

                    /// <summary>
                    /// <para>The NodeId of the start node of the relationship. The start node must exist in the Graph.Nodes of the same page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>node-sales</para>
                    /// </summary>
                    [NameInMap("FromNodeId")]
                    [Validation(Required=false)]
                    public string FromNodeId { get; set; }

                    /// <summary>
                    /// <para>The typed field association information for verified relationships. This parameter is omitted when no reliable and complete field pairing is available.</para>
                    /// </summary>
                    [NameInMap("Join")]
                    [Validation(Required=false)]
                    public GetKnowledgePointResponseBodyDataGraphEdgesJoin Join { get; set; }
                    public class GetKnowledgePointResponseBodyDataGraphEdgesJoin : TeaModel {
                        /// <summary>
                        /// <para>The association cardinality from the start node to the end node. Valid values: ONE_TO_ONE, ONE_TO_MANY, MANY_TO_ONE, and MANY_TO_MANY. This parameter is returned when the cardinality is reliable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MANY_TO_ONE</para>
                        /// </summary>
                        [NameInMap("Cardinality")]
                        [Validation(Required=false)]
                        public string Cardinality { get; set; }

                        /// <summary>
                        /// <para>The equivalent association field pairing for the nodes at both ends. Composite keys are returned in full.</para>
                        /// </summary>
                        [NameInMap("JoinKeys")]
                        [Validation(Required=false)]
                        public List<GetKnowledgePointResponseBodyDataGraphEdgesJoinJoinKeys> JoinKeys { get; set; }
                        public class GetKnowledgePointResponseBodyDataGraphEdgesJoinJoinKeys : TeaModel {
                            /// <summary>
                            /// <para>The name of the association field for the node corresponding to FromNodeId.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>customer_id</para>
                            /// </summary>
                            [NameInMap("FromField")]
                            [Validation(Required=false)]
                            public string FromField { get; set; }

                            /// <summary>
                            /// <para>The name of the association field for the node corresponding to ToNodeId.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>id</para>
                            /// </summary>
                            [NameInMap("ToField")]
                            [Validation(Required=false)]
                            public string ToField { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The ID of the knowledge base to which the knowledge point belongs. This parameter is used together with Type and Id to locate the knowledge point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345678-1234-4234-8234-123456789abc</para>
                    /// </summary>
                    [NameInMap("KnowledgeBaseId")]
                    [Validation(Required=false)]
                    public string KnowledgeBaseId { get; set; }

                    /// <summary>
                    /// <para>The public relationship type from the start node to the end node. For example, CALCULATED_FROM indicates that the start node is calculated based on the end node. You cannot infer the complete formula based solely on the type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CALCULATED_FROM</para>
                    /// </summary>
                    [NameInMap("RelationType")]
                    [Validation(Required=false)]
                    public string RelationType { get; set; }

                    /// <summary>
                    /// <para>The NodeId of the end node of the relationship. The end node must exist in the Graph.Nodes of the same page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>node-orders</para>
                    /// </summary>
                    [NameInMap("ToNodeId")]
                    [Validation(Required=false)]
                    public string ToNodeId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the knowledge base to which the knowledge point belongs. This parameter is used together with Type and Id to locate the knowledge point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678-1234-4234-8234-123456789abc</para>
                /// </summary>
                [NameInMap("KnowledgeBaseId")]
                [Validation(Required=false)]
                public string KnowledgeBaseId { get; set; }

                /// <summary>
                /// <para>All visible endpoints involved by the entry node and the relationships on the current page, deduplicated by NodeId. Subsequent pages still include the entry node.</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<GetKnowledgePointResponseBodyDataGraphNodes> Nodes { get; set; }
                public class GetKnowledgePointResponseBodyDataGraphNodes : TeaModel {
                    /// <summary>
                    /// <para>The list of reliable aliases for the node. This parameter is omitted when no aliases are available.</para>
                    /// </summary>
                    [NameInMap("Aliases")]
                    [Validation(Required=false)]
                    public List<string> Aliases { get; set; }

                    /// <summary>
                    /// <para>The reliable business definition of the graph node. This parameter is omitted when no public definition is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The sum of the actual paid amounts of paid orders</para>
                    /// </summary>
                    [NameInMap("Definition")]
                    [Validation(Required=false)]
                    public string Definition { get; set; }

                    /// <summary>
                    /// <para>The readable supplementary description of the current node or relationship. This parameter is omitted when no reliable content is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales revenue is calculated based on the actual paid amount of orders</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The asset ID in DataWorks Data Map that can be reliably located. This is not the NodeId of the graph node. This parameter is omitted when no unique and reliable asset mapping is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>maxcompute-table:::sales:public:orders</para>
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// <para>The ID of the knowledge base to which the knowledge point belongs. This parameter is used together with Type and Id to locate the knowledge point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345678-1234-4234-8234-123456789abc</para>
                    /// </summary>
                    [NameInMap("KnowledgeBaseId")]
                    [Validation(Required=false)]
                    public string KnowledgeBaseId { get; set; }

                    /// <summary>
                    /// <para>The display name of the graph node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales revenue</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the node in the current knowledge base graph. You can use this value as the Id parameter when Type is set to GRAPH to read the local graph of this node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>node-sales</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The business category of the graph node, such as TABLE for a data table. This is not the read category of the knowledge point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TABLE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The ID of the entry node for the current local graph, which is the same as the requested Id.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-sales</para>
                /// </summary>
                [NameInMap("RootNodeId")]
                [Validation(Required=false)]
                public string RootNodeId { get; set; }

                /// <summary>
                /// <para>The time when the current graph was last published. This parameter is returned when the time is reliable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1794373200000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The location ID of the knowledge point. Copy this value exactly as it appears in the search results and use it together with the corresponding KnowledgeBaseId and Type. Do not parse or convert this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node-sales</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge base to which the knowledge point belongs. This parameter is used together with Type and Id to locate the knowledge point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The title, Markdown body, and optional sources of the knowledge content. This parameter is returned only when Type is set to KNOWLEDGE_CONTENT.</para>
            /// </summary>
            [NameInMap("KnowledgeContent")]
            [Validation(Required=false)]
            public GetKnowledgePointResponseBodyDataKnowledgeContent KnowledgeContent { get; set; }
            public class GetKnowledgePointResponseBodyDataKnowledgeContent : TeaModel {
                /// <summary>
                /// <para>The currently public Markdown body. The knowledge content may be a document fragment or a readable projection of structured knowledge, and is not guaranteed to be the full text of the original file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales revenue is aggregated based on the actual paid amount of paid orders</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The download information of the uploaded original document explicitly associated with the current content. This parameter is omitted when no reliable source is available or when you do not have read permissions for the original file. The ability to retrieve a knowledge point does not imply the ability to download the complete original file.</para>
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public List<GetKnowledgePointResponseBodyDataKnowledgeContentSources> Sources { get; set; }
                public class GetKnowledgePointResponseBodyDataKnowledgeContentSources : TeaModel {
                    /// <summary>
                    /// <para>The temporary HTTPS download URL of the original file, which is valid for 2 hours. This parameter is returned only when the source can be reliably located and the caller has read permissions for the original file. Do not forward this URL publicly or store it for a long time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/sales-policy.pdf">https://example.com/sales-policy.pdf</a></para>
                    /// </summary>
                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    /// <summary>
                    /// <para>The expiration time of the download URL, in UNIX milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1794376800000</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The full file name of the original document used for building. This is not the name of the current knowledge point fragment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales_policy.pdf</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// <para>The display title of the current knowledge point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales revenue</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

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
            /// 
            /// <b>Example:</b>
            /// <para>GRAPH</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The truncation, scope limitation, or degradation prompts for the current call. Use Code for programmatic judgment. Message is for reading purposes only.</para>
            /// </summary>
            [NameInMap("Warnings")]
            [Validation(Required=false)]
            public List<GetKnowledgePointResponseBodyDataWarnings> Warnings { get; set; }
            public class GetKnowledgePointResponseBodyDataWarnings : TeaModel {
                /// <summary>
                /// <para>The truncation or degradation prompt code. For example, CONTENT_TRUNCATED indicates that the content is truncated, and SOURCE_UNAVAILABLE indicates that the original file download is temporarily unavailable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONTENT_TRUNCATED</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The sanitized and readable description of the current prompt. Use Code for programmatic judgment instead of relying on the text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Some content exceeds the length limit and has been truncated</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The title, Markdown body, and optional sources of the topic page. This parameter is returned only when Type is set to WIKI.</para>
            /// </summary>
            [NameInMap("Wiki")]
            [Validation(Required=false)]
            public GetKnowledgePointResponseBodyDataWiki Wiki { get; set; }
            public class GetKnowledgePointResponseBodyDataWiki : TeaModel {
                /// <summary>
                /// <para>The currently public Markdown body. The knowledge content may be a document fragment or a readable projection of structured knowledge, and is not guaranteed to be the full text of the original file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales revenue is aggregated based on the actual paid amount of paid orders</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The download information of the uploaded original document explicitly associated with the current content. This parameter is omitted when no reliable source is available or when you do not have read permissions for the original file. The ability to retrieve a knowledge point does not imply the ability to download the complete original file.</para>
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public List<GetKnowledgePointResponseBodyDataWikiSources> Sources { get; set; }
                public class GetKnowledgePointResponseBodyDataWikiSources : TeaModel {
                    /// <summary>
                    /// <para>The temporary HTTPS download URL of the original file, which is valid for 2 hours. This parameter is returned only when the source can be reliably located and the caller has read permissions for the original file. Do not forward this URL publicly or store it for a long time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/sales-policy.pdf">https://example.com/sales-policy.pdf</a></para>
                    /// </summary>
                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    /// <summary>
                    /// <para>The expiration time of the download URL, in UNIX milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1794376800000</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The full file name of the original document used for building. This is not the name of the current knowledge point fragment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales_policy.pdf</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// <para>The display title of the current knowledge point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales revenue</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The readable description of the business error. This parameter is omitted when the request is successful. Provide the RequestId when troubleshooting failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot issues.</para>
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
