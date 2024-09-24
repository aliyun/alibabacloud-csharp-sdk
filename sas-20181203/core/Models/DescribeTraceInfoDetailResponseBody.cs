// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the tracing diagram.</para>
        /// </summary>
        [NameInMap("TraceInfoDetail")]
        [Validation(Required=false)]
        public DescribeTraceInfoDetailResponseBodyTraceInfoDetail TraceInfoDetail { get; set; }
        public class DescribeTraceInfoDetailResponseBodyTraceInfoDetail : TeaModel {
            /// <summary>
            /// <para>An array that consists of the edges of the tracing diagram.</para>
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailEdgeList> EdgeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailEdgeList : TeaModel {
                /// <summary>
                /// <para>The number of times.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The ending vertex ID of the edge of the tracing diagram.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a1d1fa39e5345dcef3f9712172cxxxxx</para>
                /// </summary>
                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                /// <summary>
                /// <para>The starting vertex ID of the edge of the tracing diagram.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02b4bf933c8e3bb8b9465eee502xxxxx</para>
                /// </summary>
                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                /// <summary>
                /// <para>The point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-21 10:24:42</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The type of the edge of the tracing diagram.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trigger_file_alert</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>An array that consists of the metadata configurations of the vertex type.</para>
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailEntityTypeList> EntityTypeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailEntityTypeList : TeaModel {
                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deprecated</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                /// <summary>
                /// <para>The rendering color of the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#fff</para>
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// <para>The icon style of the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/tfs/TB176P5OgDqK1RjSZSyXXaxEVXa-49-48.png">https://img.alicdn.com/tfs/TB176P5OgDqK1RjSZSyXXaxEVXa-49-48.png</a></para>
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;name&quot;:&quot;${logtime}&quot;,&quot;value&quot;:&quot;$!{time}&quot;}]</para>
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// <para>The timestamp when the vertex was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-09T11:47Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the vertex was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-09T11:47Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the vertex type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alert</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deprecated</para>
                /// </summary>
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                /// <summary>
                /// <para>The name of the vertex type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alert</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deprecated</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

            }

            /// <summary>
            /// <para>An array that consists of the metadata configurations of the edge type.</para>
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailRelationTypeList> RelationTypeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailRelationTypeList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the edge is a directional edge. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public int? Directed { get; set; }

                /// <summary>
                /// <para>The rendering color of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#fff</para>
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// <para>The name of the edge type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the edge type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>netflow_to_process</para>
                /// </summary>
                [NameInMap("RelationTypeId")]
                [Validation(Required=false)]
                public string RelationTypeId { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deprecated</para>
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

            }

            /// <summary>
            /// <para>An array that consists of all vertexes of the tracing diagram.</para>
            /// </summary>
            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexList> VertexList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexList : TeaModel {
                /// <summary>
                /// <para>The number of times.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The ID of the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a1d1fa39e5345dcef3f9712172xxxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the entity represented by the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local/tomcat</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>An array that consists of the neighbor nodes.</para>
                /// </summary>
                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexListNeighborList> NeighborList { get; set; }
                public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexListNeighborList : TeaModel {
                    /// <summary>
                    /// <para>The number of neighbor nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>Indicates whether one more page is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>False</para>
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// <para>The type of the neighbor node. The value is fixed as <b>alert</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alert</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-21 10:24:42</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The type of the entity represented by the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_path</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
