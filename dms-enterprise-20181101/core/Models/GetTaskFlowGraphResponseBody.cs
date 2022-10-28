// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskFlowGraphResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskFlowGraph")]
        [Validation(Required=false)]
        public GetTaskFlowGraphResponseBodyTaskFlowGraph TaskFlowGraph { get; set; }
        public class GetTaskFlowGraphResponseBodyTaskFlowGraph : TeaModel {
            [NameInMap("CanEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

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

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public GetTaskFlowGraphResponseBodyTaskFlowGraphNodes Nodes { get; set; }
            public class GetTaskFlowGraphResponseBodyTaskFlowGraphNodes : TeaModel {
                [NameInMap("Node")]
                [Validation(Required=false)]
                public List<GetTaskFlowGraphResponseBodyTaskFlowGraphNodesNode> Node { get; set; }
                public class GetTaskFlowGraphResponseBodyTaskFlowGraphNodesNode : TeaModel {
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    [NameInMap("GraphParam")]
                    [Validation(Required=false)]
                    public string GraphParam { get; set; }

                    [NameInMap("NodeConfig")]
                    [Validation(Required=false)]
                    public string NodeConfig { get; set; }

                    [NameInMap("NodeContent")]
                    [Validation(Required=false)]
                    public string NodeContent { get; set; }

                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public long? NodeId { get; set; }

                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public long? NodeType { get; set; }

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
