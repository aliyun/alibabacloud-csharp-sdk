// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGraph4InvestigationOnlineResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeGraph4InvestigationOnlineResponseBodyData Data { get; set; }
        public class DescribeGraph4InvestigationOnlineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of edges.</para>
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<DescribeGraph4InvestigationOnlineResponseBodyDataEdgeList> EdgeList { get; set; }
            public class DescribeGraph4InvestigationOnlineResponseBodyDataEdgeList : TeaModel {
                /// <summary>
                /// <para>The ID of the end vertex of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f944c2362c7e111dee16f0e70ad2xxxx</para>
                /// </summary>
                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                /// <summary>
                /// <para>The type of the end vertex of the edge. Valid values include but are not limited to:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b>: process</description></item>
                /// <item><description><b>file</b>: file</description></item>
                /// <item><description><b>alert</b>: alert</description></item>
                /// <item><description><b>ip</b>: IP address</description></item>
                /// <item><description><b>domain</b>: domain name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>process</para>
                /// </summary>
                [NameInMap("EndType")]
                [Validation(Required=false)]
                public string EndType { get; set; }

                /// <summary>
                /// <para>The name of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bash-&gt;apt-get</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the start vertex of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f944c2362c7e111dee16f0e70ad2xxxx</para>
                /// </summary>
                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                /// <summary>
                /// <para>The type of the start vertex of the edge. Valid values include but are not limited to:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b>: process</description></item>
                /// <item><description><b>file</b>: file</description></item>
                /// <item><description><b>alert</b>: alert</description></item>
                /// <item><description><b>ip</b>: IP address</description></item>
                /// <item><description><b>domain</b>: domain name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("StartType")]
                [Validation(Required=false)]
                public string StartType { get; set; }

                /// <summary>
                /// <para>The time when the edge was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-07-01 15:25:46</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The type of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>process_spawn_process</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The list of vertex types.</para>
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<DescribeGraph4InvestigationOnlineResponseBodyDataEntityTypeList> EntityTypeList { get; set; }
            public class DescribeGraph4InvestigationOnlineResponseBodyDataEntityTypeList : TeaModel {
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
                /// <para>The icon of the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/tfs/TB176P5OgDqK1RjSZSyXXaxEVXa-49-48.png">https://img.alicdn.com/tfs/TB176P5OgDqK1RjSZSyXXaxEVXa-49-48.png</a></para>
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// <para>The display order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                /// <summary>
                /// <para>The ID of the node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The list of edge types.</para>
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<DescribeGraph4InvestigationOnlineResponseBodyDataRelationTypeList> RelationTypeList { get; set; }
            public class DescribeGraph4InvestigationOnlineResponseBodyDataRelationTypeList : TeaModel {
                /// <summary>
                /// <para>The direction of the edge. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: forward</description></item>
                /// <item><description><b>0</b>: reverse.</description></item>
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
                /// <para>The icon style of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01ft6rvQ22uUX2JsTmv_!!6000000007180-55-tps-12-12.svg">https://img.alicdn.com/imgextra/i4/O1CN01ft6rvQ22uUX2JsTmv_!!6000000007180-55-tps-12-12.svg</a></para>
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// <para>The name of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spawn process</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The list of vertices.</para>
            /// </summary>
            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<DescribeGraph4InvestigationOnlineResponseBodyDataVertexList> VertexList { get; set; }
            public class DescribeGraph4InvestigationOnlineResponseBodyDataVertexList : TeaModel {
                /// <summary>
                /// <para>The name of the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1a79b3a10ad5e6cad090dd697a7axxxxx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of vertices adjacent to the current vertex.</para>
                /// </summary>
                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<DescribeGraph4InvestigationOnlineResponseBodyDataVertexListNeighborList> NeighborList { get; set; }
                public class DescribeGraph4InvestigationOnlineResponseBodyDataVertexListNeighborList : TeaModel {
                    /// <summary>
                    /// <para>The number of adjacent nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>Indicates whether more adjacent vertices exist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>False</para>
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// <para>The type of the neighbor node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alert</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The properties.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;DomainName\&quot;: {\&quot;SupportScratchDetection\&quot;: False, \&quot;Description\&quot;: \&quot;The name of the domain.\&quot;, \&quot;Required\&quot;: True, \&quot;UpdateAllowed\&quot;: False, \&quot;Type\&quot;: \&quot;string\&quot;, \&quot;Immutable\&quot;: False}}</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// <para>The time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-07-02 16:14:01</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The type of the vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The UUID of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5c081b02-f66a-47a4-bd2f-79ee3eafxxxx</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C699E4E4-F2F4-58FC-A949-457FFE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
