// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoDetailResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The details of the tracing diagram.
        /// </summary>
        [NameInMap("TraceInfoDetail")]
        [Validation(Required=false)]
        public DescribeTraceInfoDetailResponseBodyTraceInfoDetail TraceInfoDetail { get; set; }
        public class DescribeTraceInfoDetailResponseBodyTraceInfoDetail : TeaModel {
            /// <summary>
            /// An array that consists of the edges of the tracing diagram.
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailEdgeList> EdgeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailEdgeList : TeaModel {
                /// <summary>
                /// The number of times.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The ending vertex ID of the edge of the tracing diagram.
                /// </summary>
                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                /// <summary>
                /// The starting vertex ID of the edge of the tracing diagram.
                /// </summary>
                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                /// <summary>
                /// The point in time.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The type of the edge of the tracing diagram.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// An array that consists of the metadata configurations of the vertex type.
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailEntityTypeList> EntityTypeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailEntityTypeList : TeaModel {
                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                /// <summary>
                /// The rendering color of the vertex.
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// The icon style of the vertex.
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// The timestamp when the vertex was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The time when the vertex was last modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// The ID of the vertex type.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                /// <summary>
                /// The name of the vertex type.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

            }

            /// <summary>
            /// An array that consists of the metadata configurations of the edge type.
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailRelationTypeList> RelationTypeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailRelationTypeList : TeaModel {
                /// <summary>
                /// Indicates whether the edge is a directional edge. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public int? Directed { get; set; }

                /// <summary>
                /// The rendering color of the edge.
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// The name of the edge type.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the edge type.
                /// </summary>
                [NameInMap("RelationTypeId")]
                [Validation(Required=false)]
                public string RelationTypeId { get; set; }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

            }

            /// <summary>
            /// An array that consists of all vertexes of the tracing diagram.
            /// </summary>
            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexList> VertexList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexList : TeaModel {
                /// <summary>
                /// The number of times.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The ID of the vertex.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the entity represented by the vertex.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// An array that consists of the neighbor nodes.
                /// </summary>
                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexListNeighborList> NeighborList { get; set; }
                public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexListNeighborList : TeaModel {
                    /// <summary>
                    /// The number of neighbor nodes.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// Indicates whether one more page is returned.
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// The type of the neighbor node. The value is fixed as **alert**.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The point in time.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The type of the entity represented by the vertex.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
