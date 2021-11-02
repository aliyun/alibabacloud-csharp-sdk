// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGraph4InvestigationOnlineResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeGraph4InvestigationOnlineResponseBodyData Data { get; set; }
        public class DescribeGraph4InvestigationOnlineResponseBodyData : TeaModel {
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<DescribeGraph4InvestigationOnlineResponseBodyDataEdgeList> EdgeList { get; set; }
            public class DescribeGraph4InvestigationOnlineResponseBodyDataEdgeList : TeaModel {
                public string EndId { get; set; }
                public string EndType { get; set; }
                public int? Id { get; set; }
                public string Name { get; set; }
                public string StartId { get; set; }
                public string StartType { get; set; }
                public string Time { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<DescribeGraph4InvestigationOnlineResponseBodyDataEntityTypeList> EntityTypeList { get; set; }
            public class DescribeGraph4InvestigationOnlineResponseBodyDataEntityTypeList : TeaModel {
                public string DisplayColor { get; set; }
                public string DisplayIcon { get; set; }
                public string DisplayOrder { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<DescribeGraph4InvestigationOnlineResponseBodyDataRelationTypeList> RelationTypeList { get; set; }
            public class DescribeGraph4InvestigationOnlineResponseBodyDataRelationTypeList : TeaModel {
                public int? Directed { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public string ShowType { get; set; }
            }
            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<DescribeGraph4InvestigationOnlineResponseBodyDataVertexList> VertexList { get; set; }
            public class DescribeGraph4InvestigationOnlineResponseBodyDataVertexList : TeaModel {
                public string Aliuid { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public List<DescribeGraph4InvestigationOnlineResponseBodyDataVertexListNeighborList> NeighborList { get; set; }
                public class DescribeGraph4InvestigationOnlineResponseBodyDataVertexListNeighborList : TeaModel {
                    public int? Count { get; set; }
                    public bool? HasMore { get; set; }
                    public string Type { get; set; }
                }
                public string Position { get; set; }
                public string PositionId { get; set; }
                public string Properties { get; set; }
                public string Time { get; set; }
                public string Type { get; set; }
                public string Uuid { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
