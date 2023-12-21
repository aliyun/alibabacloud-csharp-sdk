// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentIconListResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   **200**: The request was successful.
        /// *   **400**: The request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The information about the entities and edges.
        /// </summary>
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public QueryIncidentIconListResponseBodyInfoList InfoList { get; set; }
        public class QueryIncidentIconListResponseBodyInfoList : TeaModel {
            /// <summary>
            /// The information about the entities.
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentIconListResponseBodyInfoListEntityTypeList> EntityTypeList { get; set; }
            public class QueryIncidentIconListResponseBodyInfoListEntityTypeList : TeaModel {
                /// <summary>
                /// The display color of the entity.
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// The icon that corresponds to the entity.
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// The display sequence of the entity.
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public string DisplayOrder { get; set; }

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
                /// Indicates whether the entity is a virtual node. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("IsVirtualNode")]
                [Validation(Required=false)]
                public string IsVirtualNode { get; set; }

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
                /// The tag that indicates whether tracing was successful.
                /// </summary>
                [NameInMap("TraceSuccessFlag")]
                [Validation(Required=false)]
                public string TraceSuccessFlag { get; set; }

            }

            /// <summary>
            /// The information about the edges.
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentIconListResponseBodyInfoListRelationTypeList> RelationTypeList { get; set; }
            public class QueryIncidentIconListResponseBodyInfoListRelationTypeList : TeaModel {
                /// <summary>
                /// The direction of the edge. Valid values:
                /// 
                /// *   **1**: forward
                /// *   **0**: reverse
                /// </summary>
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public string Directed { get; set; }

                /// <summary>
                /// The display color of the edge.
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// The icon that corresponds to the edge.
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// The display template of the edge.
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// The time when the edge was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the edge was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the edge.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the edge.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace of the edge.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The display type of the edge.
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// The consumed time of the request. Unit: seconds.
        /// </summary>
        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
