// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentTracingDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TracingDetail")]
        [Validation(Required=false)]
        public QueryIncidentTracingDetailResponseBodyTracingDetail TracingDetail { get; set; }
        public class QueryIncidentTracingDetailResponseBodyTracingDetail : TeaModel {
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailEdgeList> EdgeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailEdgeList : TeaModel {
                /// <summary>
                /// AliUid
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                [NameInMap("EndType")]
                [Validation(Required=false)]
                public string EndType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Origin
                /// </summary>
                [NameInMap("Origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                [NameInMap("StartType")]
                [Validation(Required=false)]
                public string StartType { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// UUID
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailEntityTypeList> EntityTypeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailEntityTypeList : TeaModel {
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IsVirtualNode")]
                [Validation(Required=false)]
                public int? IsVirtualNode { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// namespace
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// SyncId
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

                [NameInMap("TraceSuccessFlag")]
                [Validation(Required=false)]
                public int? TraceSuccessFlag { get; set; }

            }

            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailRelationTypeList> RelationTypeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailRelationTypeList : TeaModel {
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                [NameInMap("Directed")]
                [Validation(Required=false)]
                public int? Directed { get; set; }

                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// ICON
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// SyncID
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

            }

            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexList> VertexList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexList : TeaModel {
                /// <summary>
                /// aliuid
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                [NameInMap("DisplayInfo")]
                [Validation(Required=false)]
                public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexListDisplayInfo> DisplayInfo { get; set; }
                public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexListDisplayInfo : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexListNeighborList> NeighborList { get; set; }
                public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexListNeighborList : TeaModel {
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

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// UUID
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

    }

}
