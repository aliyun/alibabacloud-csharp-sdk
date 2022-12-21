// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowEdgesByConditionResponseBody : TeaModel {
        /// <summary>
        /// The list of task flow edges.
        /// </summary>
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public ListTaskFlowEdgesByConditionResponseBodyEdges Edges { get; set; }
        public class ListTaskFlowEdgesByConditionResponseBodyEdges : TeaModel {
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<ListTaskFlowEdgesByConditionResponseBodyEdgesEdge> Edge { get; set; }
            public class ListTaskFlowEdgesByConditionResponseBodyEdgesEdge : TeaModel {
                /// <summary>
                /// The ID of the task flow edge.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The ID of the end node on the edge.
                /// </summary>
                [NameInMap("NodeEnd")]
                [Validation(Required=false)]
                public long? NodeEnd { get; set; }

                /// <summary>
                /// The ID of the start node on the edge.
                /// </summary>
                [NameInMap("NodeFrom")]
                [Validation(Required=false)]
                public long? NodeFrom { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
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

    }

}
