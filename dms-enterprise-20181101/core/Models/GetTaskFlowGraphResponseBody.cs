// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskFlowGraphResponseBody : TeaModel {
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
        /// The list of DAG variables of the task flow.
        /// </summary>
        [NameInMap("TaskFlowGraph")]
        [Validation(Required=false)]
        public GetTaskFlowGraphResponseBodyTaskFlowGraph TaskFlowGraph { get; set; }
        public class GetTaskFlowGraphResponseBodyTaskFlowGraph : TeaModel {
            /// <summary>
            /// Indicates whether the task flow is editable. Valid values:
            /// 
            /// - **true**: editable
            /// - **false**: non-editable
            /// </summary>
            [NameInMap("CanEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

            /// <summary>
            /// The name of the task flow.
            /// </summary>
            [NameInMap("DagName")]
            [Validation(Required=false)]
            public string DagName { get; set; }

            /// <summary>
            /// The list of task flow edges.
            /// </summary>
            [NameInMap("Edges")]
            [Validation(Required=false)]
            public GetTaskFlowGraphResponseBodyTaskFlowGraphEdges Edges { get; set; }
            public class GetTaskFlowGraphResponseBodyTaskFlowGraphEdges : TeaModel {
                [NameInMap("Edge")]
                [Validation(Required=false)]
                public List<GetTaskFlowGraphResponseBodyTaskFlowGraphEdgesEdge> Edge { get; set; }
                public class GetTaskFlowGraphResponseBodyTaskFlowGraphEdgesEdge : TeaModel {
                    /// <summary>
                    /// The ID of the task flow.
                    /// </summary>
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

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
            /// The node list of the task flow.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public GetTaskFlowGraphResponseBodyTaskFlowGraphNodes Nodes { get; set; }
            public class GetTaskFlowGraphResponseBodyTaskFlowGraphNodes : TeaModel {
                [NameInMap("Node")]
                [Validation(Required=false)]
                public List<GetTaskFlowGraphResponseBodyTaskFlowGraphNodesNode> Node { get; set; }
                public class GetTaskFlowGraphResponseBodyTaskFlowGraphNodesNode : TeaModel {
                    /// <summary>
                    /// The ID of the task flow.
                    /// </summary>
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    /// <summary>
                    /// The position of the node in the DAG.
                    /// </summary>
                    [NameInMap("GraphParam")]
                    [Validation(Required=false)]
                    public string GraphParam { get; set; }

                    /// <summary>
                    /// The advanced configuration of the node.
                    /// </summary>
                    [NameInMap("NodeConfig")]
                    [Validation(Required=false)]
                    public string NodeConfig { get; set; }

                    /// <summary>
                    /// The configuration of the node.
                    /// </summary>
                    [NameInMap("NodeContent")]
                    [Validation(Required=false)]
                    public string NodeContent { get; set; }

                    /// <summary>
                    /// The ID of the node.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public long? NodeId { get; set; }

                    /// <summary>
                    /// The name of the node.
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// The type of the node. For more information about the valid values for this parameter, see [NodeType parameter](~~424705~~).
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public long? NodeType { get; set; }

                    /// <summary>
                    /// The time variables for the node.
                    /// </summary>
                    [NameInMap("TimeVariables")]
                    [Validation(Required=false)]
                    public string TimeVariables { get; set; }

                }

            }

            /// <summary>
            /// The status of the task flow. Valid values:
            /// 
            /// - **0**: invalid
            /// - **1**: not scheduled
            /// - **2**: to be scheduled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

    }

}
