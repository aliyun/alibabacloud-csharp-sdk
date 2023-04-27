// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskFlowGraphResponseBody : TeaModel {
        /// <summary>
        /// The ID of the task flow.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The advanced configuration of the node.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **GetTaskFlowGraph**.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("TaskFlowGraph")]
        [Validation(Required=false)]
        public GetTaskFlowGraphResponseBodyTaskFlowGraph TaskFlowGraph { get; set; }
        public class GetTaskFlowGraphResponseBodyTaskFlowGraph : TeaModel {
            [NameInMap("CanEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("DagName")]
            [Validation(Required=false)]
            public string DagName { get; set; }

            [NameInMap("Edges")]
            [Validation(Required=false)]
            public GetTaskFlowGraphResponseBodyTaskFlowGraphEdges Edges { get; set; }
            public class GetTaskFlowGraphResponseBodyTaskFlowGraphEdges : TeaModel {
                [NameInMap("Edge")]
                [Validation(Required=false)]
                public List<GetTaskFlowGraphResponseBodyTaskFlowGraphEdgesEdge> Edge { get; set; }
                public class GetTaskFlowGraphResponseBodyTaskFlowGraphEdgesEdge : TeaModel {
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("NodeEnd")]
                    [Validation(Required=false)]
                    public long? NodeEnd { get; set; }

                    [NameInMap("NodeFrom")]
                    [Validation(Required=false)]
                    public long? NodeFrom { get; set; }

                }

            }

            /// <summary>
            /// The ID of the tenant.
            /// 
            /// >  To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](~~181330~~).
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
                    /// The name of the node.
                    /// </summary>
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    [NameInMap("GraphParam")]
                    [Validation(Required=false)]
                    public string GraphParam { get; set; }

                    [NameInMap("NodeConfig")]
                    [Validation(Required=false)]
                    public string NodeConfig { get; set; }

                    /// <summary>
                    /// The ID of the request.
                    /// </summary>
                    [NameInMap("NodeContent")]
                    [Validation(Required=false)]
                    public string NodeContent { get; set; }

                    /// <summary>
                    /// The type of the node. For more information about the valid values for this parameter, see [NodeType parameter](~~424705~~).
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public long? NodeId { get; set; }

                    /// <summary>
                    /// The position of the node in the DAG.
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// The list of DAG variables of the task flow.
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public long? NodeType { get; set; }

                    /// <summary>
                    /// Queries the Directed Acyclic Graph (DAG) of a task flow.
                    /// </summary>
                    [NameInMap("TimeVariables")]
                    [Validation(Required=false)]
                    public string TimeVariables { get; set; }

                }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

    }

}
