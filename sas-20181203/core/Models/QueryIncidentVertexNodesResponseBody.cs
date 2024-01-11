// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentVertexNodesResponseBody : TeaModel {
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
        /// The results that are returned.
        /// </summary>
        [NameInMap("VertexNodes")]
        [Validation(Required=false)]
        public QueryIncidentVertexNodesResponseBodyVertexNodes VertexNodes { get; set; }
        public class QueryIncidentVertexNodesResponseBodyVertexNodes : TeaModel {
            /// <summary>
            /// The edges that are returned.
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexNodesResponseBodyVertexNodesEdgeList> EdgeList { get; set; }
            public class QueryIncidentVertexNodesResponseBodyVertexNodesEdgeList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the edge belongs.
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// The ID of the end node for the edge.
                /// </summary>
                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                /// <summary>
                /// The type of the end node for the edge. Valid values include but are not limited to:
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
                /// The name of the edge.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The original name of the edge.
                /// </summary>
                [NameInMap("Origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                /// <summary>
                /// The edge properties. The value is in the text format.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// The property of the edge.
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                /// <summary>
                /// The ID of the rule for which the edge was created.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The display type of the edge.
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// The ID of the start node for the edge.
                /// </summary>
                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                /// <summary>
                /// The type of the start node for the edge. Valid values include but are not limited to:
                /// 
                /// *   **process**
                /// *   **file**
                /// *   **alert**
                /// *   **ip**
                /// *   **domain**
                /// </summary>
                [NameInMap("StartType")]
                [Validation(Required=false)]
                public string StartType { get; set; }

                /// <summary>
                /// The time when the edge was created.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The UNIX timestamp when the edge was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The type of the edge.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The type name of the edge.
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

                /// <summary>
                /// The time when the edge was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The UUID of the edge.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// The entities that are returned.
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexNodesResponseBodyVertexNodesEntityTypeList> EntityTypeList { get; set; }
            public class QueryIncidentVertexNodesResponseBodyVertexNodesEntityTypeList : TeaModel {
                /// <summary>
                /// The version of the entity.
                /// </summary>
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                /// <summary>
                /// The display color of the entity.
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// The display icon of the entity.
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// The display order of the entity.
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                /// <summary>
                /// The display template of the entity.
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// The time when the entity was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the entity was updated.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the entity.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Indicates whether the entity is a virtual node.
                /// </summary>
                [NameInMap("IsVirtualNode")]
                [Validation(Required=false)]
                public int? IsVirtualNode { get; set; }

                /// <summary>
                /// The name of the entity.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace of the entity.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The synchronization ID of the entity.
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

                /// <summary>
                /// Indicates whether the entity is traced. Valid values:
                /// 
                /// *   **1**: The entity is traced.
                /// *   **0**: The entity fails to be traced.
                /// </summary>
                [NameInMap("TraceSuccessFlag")]
                [Validation(Required=false)]
                public int? TraceSuccessFlag { get; set; }

            }

            /// <summary>
            /// The language of the content within the request. Valid values:
            /// 
            /// *   **zh**: Chinese
            /// *   **en**: English
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// The relationships that are returned.
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexNodesResponseBodyVertexNodesRelationTypeList> RelationTypeList { get; set; }
            public class QueryIncidentVertexNodesResponseBodyVertexNodesRelationTypeList : TeaModel {
                /// <summary>
                /// The version of the relationship.
                /// </summary>
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                /// <summary>
                /// The display icon of the relationship.
                /// </summary>
                [NameInMap("DIsplayIcon")]
                [Validation(Required=false)]
                public string DIsplayIcon { get; set; }

                /// <summary>
                /// The direction of the relationship. Valid values:
                /// 
                /// *   **1**: forward
                /// *   **0**: reverse
                /// </summary>
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public int? Directed { get; set; }

                /// <summary>
                /// The display color of the relationship.
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// The display template of the relationship.
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// The time when the relationship was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the relationship was updated.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the relationship.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the relationship.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace of the relationship.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The display type of the relationship.
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// The synchronization ID of the relationship.
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

            }

            /// <summary>
            /// The detailed information about the node.
            /// </summary>
            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexNodesResponseBodyVertexNodesVertexList> VertexList { get; set; }
            public class QueryIncidentVertexNodesResponseBodyVertexNodesVertexList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the node belongs.
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// The display information about the node.
                /// </summary>
                [NameInMap("DisplayInfo")]
                [Validation(Required=false)]
                public List<QueryIncidentVertexNodesResponseBodyVertexNodesVertexListDisplayInfo> DisplayInfo { get; set; }
                public class QueryIncidentVertexNodesResponseBodyVertexNodesVertexListDisplayInfo : TeaModel {
                    /// <summary>
                    /// The display name of the property.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The display value of the property.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The display language of the neighboring node. Valid values:
                /// 
                /// *   **zh**: Chinese
                /// *   **en**: English
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// The node name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The neighboring nodes of the node.
                /// </summary>
                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<QueryIncidentVertexNodesResponseBodyVertexNodesVertexListNeighborList> NeighborList { get; set; }
                public class QueryIncidentVertexNodesResponseBodyVertexNodesVertexListNeighborList : TeaModel {
                    /// <summary>
                    /// The number of neighboring nodes.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// Indicates whether more neighboring nodes exist. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// The type of the neighboring node. Valid values include but are not limited to:
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
                /// The node properties. The value is in the text format.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// The node property.
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                /// <summary>
                /// The ID of the rule for which the node was created.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The time when the node was created.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The UNIX timestamp when the node was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The node type. Valid values include but are not limited to:
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
                /// The time when the node was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The node UUID.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

    }

}
