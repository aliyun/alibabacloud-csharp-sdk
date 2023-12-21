// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentTracingDetailResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The information about the provenance graph.
        /// </summary>
        [NameInMap("TracingDetail")]
        [Validation(Required=false)]
        public QueryIncidentTracingDetailResponseBodyTracingDetail TracingDetail { get; set; }
        public class QueryIncidentTracingDetailResponseBodyTracingDetail : TeaModel {
            /// <summary>
            /// The edges.
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailEdgeList> EdgeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailEdgeList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the current edge belongs.
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// The ID of the end node for the current edge.
                /// </summary>
                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                /// <summary>
                /// The type of the end node for the current edge. Valid values include the following values:
                /// 
                /// *   **process**
                /// *   **file**
                /// *   **alert**
                /// *   **ip**
                /// *   **domain**
                /// </summary>
                [NameInMap("EndType")]
                [Validation(Required=false)]
                public string EndType { get; set; }

                /// <summary>
                /// The name of the current edge.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The origin vertex ID of the current edge.
                /// </summary>
                [NameInMap("Origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                /// <summary>
                /// The text that contains the properties of the current edge.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// The property of the current edge.
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                /// <summary>
                /// The ID of the rule based on which the current edge is generated.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The display type of the current edge.
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// The ID of the start node for the current edge.
                /// </summary>
                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                /// <summary>
                /// The type of the start node for the current edge. Valid values include the following values:
                /// 
                /// *   **process**
                /// *   **file**
                /// *   **alert**:
                /// *   **ip**
                /// *   **domain**
                /// </summary>
                [NameInMap("StartType")]
                [Validation(Required=false)]
                public string StartType { get; set; }

                /// <summary>
                /// The time when the current edge was created.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The UNIX timestamp when the current edge was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The type of the current edge. Valid values include the following values:
                /// 
                /// *   **process_exec_file**: The relationship indicates an executable file that is run by a process.
                /// *   **process_connect_ip**: The relationship indicates an IP address that is connected by a process.
                /// *   **domain_trgger_alert**: The relationship indicates an alert that is triggered for a domain name.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The type of the current edge.
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

                /// <summary>
                /// The time when the current edge was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The UUID of the current edge. The SIEM system generates UUIDs for nodes and edges in the provenance graph to help you locate the nodes or edges.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// The entities.
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailEntityTypeList> EntityTypeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailEntityTypeList : TeaModel {
                /// <summary>
                /// The version ID of the current entity.
                /// </summary>
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                /// <summary>
                /// The display color of the current entity.
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// The display icon of the current entity.
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// The display sequence of the current entity.
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                /// <summary>
                /// The display template of the current entity.
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// The time when the current entity was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the current entity was updated.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the current entity.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Indicates whether the entity is a virtual node. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("IsVirtualNode")]
                [Validation(Required=false)]
                public int? IsVirtualNode { get; set; }

                /// <summary>
                /// The type of the current entity. Valid values include the following values:
                /// 
                /// *   **process**
                /// *   **file**
                /// *   **alert**
                /// *   **ip**
                /// *   **domain**
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace of the current entity.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The synchronization ID of the current entity.
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

                /// <summary>
                /// The tag that indicates whether tracing was successful. Valid values:
                /// 
                /// *   **1**: successful
                /// *   **0**: failed
                /// </summary>
                [NameInMap("TraceSuccessFlag")]
                [Validation(Required=false)]
                public int? TraceSuccessFlag { get; set; }

            }

            /// <summary>
            /// The rendering language of the returned result. Valid values:
            /// 
            /// *   **zh**: Chinese
            /// *   **en**: English
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// The relationships.
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailRelationTypeList> RelationTypeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailRelationTypeList : TeaModel {
                /// <summary>
                /// The version ID of the current relationship.
                /// </summary>
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                /// <summary>
                /// The direction of the current relationship. Valid values:
                /// 
                /// *   **1**: forward
                /// *   **0**: reverse
                /// </summary>
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public int? Directed { get; set; }

                /// <summary>
                /// The display color of the current relationship.
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// The display icon of the current relationship.
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// The display template of the current relationship.
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// The time when the current relationship was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the current relationship was updated.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the current relationship.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The type of the current relationship. Valid values include the following values:
                /// 
                /// *   **process_exec_file**: The relationship indicates an executable file that is run by a process.
                /// *   **process_connect_ip**: The relationship indicates an IP address that is connected by a process.
                /// *   **domain_trgger_alert**: The relationship indicates an alert that is triggered for a domain name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace of the current relationship.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The display type of the current relationship.
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// The synchronization ID of the current relationship.
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

            }

            /// <summary>
            /// The nodes.
            /// </summary>
            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexList> VertexList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the current node belongs.
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// The display information of the current node.
                /// </summary>
                [NameInMap("DisplayInfo")]
                [Validation(Required=false)]
                public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexListDisplayInfo> DisplayInfo { get; set; }
                public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexListDisplayInfo : TeaModel {
                    /// <summary>
                    /// The name of the property that needs to be displayed for the current node.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The value of the property that needs to be displayed for the current node.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The ID of the current node.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The rendering language of the current node.
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// The name of the current node.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The nodes that are adjacent to the current node.
                /// </summary>
                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexListNeighborList> NeighborList { get; set; }
                public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexListNeighborList : TeaModel {
                    /// <summary>
                    /// The number of nodes.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// Indicates whether more nodes are adjacent to the current node. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// The type of the node. Valid values include the following values:
                    /// 
                    /// *   **process**
                    /// *   **file**
                    /// *   **alert**
                    /// *   **ip**
                    /// *   **domain**
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The text that contains the properties of the current node.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// The property of the current node.
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                /// <summary>
                /// The ID of the rule based on which the current node is generated.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The time when the current node was created.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The UNIX timestamp when the current node was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The type of the current node. Valid values include the following values:
                /// 
                /// *   **process**
                /// *   **file**
                /// *   **alert**
                /// *   **ip**
                /// *   **domain**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The time when the current node was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The UUID of the current node. The security information and event management (SIEM) system generates UUIDs for nodes and edges in the provenance graph to help you locate the nodes or edges.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

    }

}
