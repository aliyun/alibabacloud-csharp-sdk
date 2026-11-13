// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RetrieveKnowledgePointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. This field may be omitted if the request succeeds. If the request fails, the common error response protocol applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The knowledge point summaries, relationship paths, ambiguity candidates, and warnings for the current search.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RetrieveKnowledgePointsResponseBodyData Data { get; set; }
        public class RetrieveKnowledgePointsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ambiguity descriptions and candidate objects returned when the target is not yet confirmed.</para>
            /// </summary>
            [NameInMap("Ambiguities")]
            [Validation(Required=false)]
            public List<RetrieveKnowledgePointsResponseBodyDataAmbiguities> Ambiguities { get; set; }
            public class RetrieveKnowledgePointsResponseBodyDataAmbiguities : TeaModel {
                /// <summary>
                /// <para>The candidate graph nodes when ambiguity exists. Each candidate carries the KnowledgeBaseId, Type, and Id for reading details, which does not indicate that the user has confirmed the selection.</para>
                /// </summary>
                [NameInMap("Candidates")]
                [Validation(Required=false)]
                public List<RetrieveKnowledgePointsResponseBodyDataAmbiguitiesCandidates> Candidates { get; set; }
                public class RetrieveKnowledgePointsResponseBodyDataAmbiguitiesCandidates : TeaModel {
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
                    /// <para>The display title of the current knowledge point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales revenue</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>The read category of the knowledge point. Use GRAPH for the current focus objects and graph nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GRAPH</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The name or description of the object whose referent is not yet determined in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales revenue</para>
                /// </summary>
                [NameInMap("Mention")]
                [Validation(Required=false)]
                public string Mention { get; set; }

            }

            /// <summary>
            /// <para>The relationship paths matched by the search. Path indexes do not correspond to indexes in the Results array. The paths may cover only a subset of relationships.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<RetrieveKnowledgePointsResponseBodyDataPaths> Paths { get; set; }
            public class RetrieveKnowledgePointsResponseBodyDataPaths : TeaModel {
                /// <summary>
                /// <para>The directed relationships that connect the nodes in the Nodes array of the current path.</para>
                /// </summary>
                [NameInMap("Edges")]
                [Validation(Required=false)]
                public List<RetrieveKnowledgePointsResponseBodyDataPathsEdges> Edges { get; set; }
                public class RetrieveKnowledgePointsResponseBodyDataPathsEdges : TeaModel {
                    /// <summary>
                    /// <para>The Id of the start node in the Nodes array of the same path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>node-sales</para>
                    /// </summary>
                    [NameInMap("FromId")]
                    [Validation(Required=false)]
                    public string FromId { get; set; }

                    /// <summary>
                    /// <para>The public relationship type directed from the start node to the end node. For example, CALCULATED_FROM indicates that the start node is calculated based on the end node. You cannot infer the complete formula based solely on the relationship type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CALCULATED_FROM</para>
                    /// </summary>
                    [NameInMap("RelationType")]
                    [Validation(Required=false)]
                    public string RelationType { get; set; }

                    /// <summary>
                    /// <para>The Id of the end node in the Nodes array of the same path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>node-orders</para>
                    /// </summary>
                    [NameInMap("ToId")]
                    [Validation(Required=false)]
                    public string ToId { get; set; }

                }

                /// <summary>
                /// <para>The graph nodes in the relationship path. You can read the details of each node by using its KnowledgeBaseId, Type, and Id.</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<RetrieveKnowledgePointsResponseBodyDataPathsNodes> Nodes { get; set; }
                public class RetrieveKnowledgePointsResponseBodyDataPathsNodes : TeaModel {
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
                    /// <para>The display title of the current knowledge point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales revenue</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>The read category of the knowledge point. Use GRAPH for the current focus objects and graph nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GRAPH</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>Knowledge point summaries ranked by relevance across all knowledge bases. The total number of results does not exceed MaxResults. Results can include GRAPH, WIKI, and KNOWLEDGE_CONTENT.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<RetrieveKnowledgePointsResponseBodyDataResults> Results { get; set; }
            public class RetrieveKnowledgePointsResponseBodyDataResults : TeaModel {
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
                /// <para>The download information of the uploaded original documents explicitly associated with the current content. This parameter is omitted if no reliable source is available or if the caller lacks read permissions for the original files. The ability to retrieve knowledge points does not imply the permission to download the complete original files.</para>
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public List<RetrieveKnowledgePointsResponseBodyDataResultsSources> Sources { get; set; }
                public class RetrieveKnowledgePointsResponseBodyDataResultsSources : TeaModel {
                    /// <summary>
                    /// <para>The temporary HTTPS download URL of the original file. The URL is valid for 2 hours. This parameter is returned only when the source can be reliably located and the caller has read permissions for the original file. Do not forward the URL publicly or store it for a long time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/sales-policy.pdf">https://example.com/sales-policy.pdf</a></para>
                    /// </summary>
                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    /// <summary>
                    /// <para>The expiration time of the download URL. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1794376800000</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The full file name of the original document used for building. This is not the name of the current knowledge point segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales_policy.pdf</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// <para>The readable summary of the knowledge point. The summary is not guaranteed to contain the complete content. To obtain details, call GetKnowledgePoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The sales revenue metric and its associated order table</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The display title of the current knowledge point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales revenue</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The read category of the knowledge point. GRAPH indicates a local graph, WIKI indicates a topic page, and KNOWLEDGE_CONTENT indicates knowledge content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GRAPH</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The truncation, scope limitation, or degradation warnings for the current call. Use Code for programmatic judgment. Message is for reading purposes only.</para>
            /// </summary>
            [NameInMap("Warnings")]
            [Validation(Required=false)]
            public List<RetrieveKnowledgePointsResponseBodyDataWarnings> Warnings { get; set; }
            public class RetrieveKnowledgePointsResponseBodyDataWarnings : TeaModel {
                /// <summary>
                /// <para>The truncation or degradation warning code. For example, CONTENT_TRUNCATED indicates that the content is truncated, and SOURCE_UNAVAILABLE indicates that the original file download is temporarily unavailable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONTENT_TRUNCATED</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The sanitized readable description of the current warning. Use Code for programmatic judgment instead of relying on the text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Some content exceeds the length limit and has been truncated</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// <para>A human-readable description of the business error. This field may be omitted if the request succeeds. Provide the RequestId when troubleshooting failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID to troubleshoot issues.</para>
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
