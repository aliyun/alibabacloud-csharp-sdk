// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceInfoDetail")]
        [Validation(Required=false)]
        public DescribeTraceInfoDetailResponseBodyTraceInfoDetail TraceInfoDetail { get; set; }
        public class DescribeTraceInfoDetailResponseBodyTraceInfoDetail : TeaModel {
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailEdgeList> EdgeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailEdgeList : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailEntityTypeList> EntityTypeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailEntityTypeList : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

            }

            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailRelationTypeList> RelationTypeList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailRelationTypeList : TeaModel {
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public int? Directed { get; set; }

                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RelationTypeId")]
                [Validation(Required=false)]
                public string RelationTypeId { get; set; }

                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

            }

            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexList> VertexList { get; set; }
            public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexList : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexListNeighborList> NeighborList { get; set; }
                public class DescribeTraceInfoDetailResponseBodyTraceInfoDetailVertexListNeighborList : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
