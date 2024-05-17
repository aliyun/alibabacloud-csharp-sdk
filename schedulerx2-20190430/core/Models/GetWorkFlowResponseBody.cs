// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkFlowResponseBody : TeaModel {
        /// <summary>
        /// Error codes
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data of the workflow.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkFlowResponseBodyData Data { get; set; }
        public class GetWorkFlowResponseBodyData : TeaModel {
            /// <summary>
            /// The basic information of the workflow.
            /// </summary>
            [NameInMap("WorkFlowInfo")]
            [Validation(Required=false)]
            public GetWorkFlowResponseBodyDataWorkFlowInfo WorkFlowInfo { get; set; }
            public class GetWorkFlowResponseBodyDataWorkFlowInfo : TeaModel {
                /// <summary>
                /// The description of the workflow.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the workflow.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the workflow.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time expression of the workflow.
                /// </summary>
                [NameInMap("TimeExpression")]
                [Validation(Required=false)]
                public string TimeExpression { get; set; }

                /// <summary>
                /// The time type of the workflow.
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public string TimeType { get; set; }

                /// <summary>
                /// The ID of the workflow.
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

            }

            /// <summary>
            /// The node information of the workflow.
            /// </summary>
            [NameInMap("WorkFlowNodeInfo")]
            [Validation(Required=false)]
            public GetWorkFlowResponseBodyDataWorkFlowNodeInfo WorkFlowNodeInfo { get; set; }
            public class GetWorkFlowResponseBodyDataWorkFlowNodeInfo : TeaModel {
                /// <summary>
                /// The workflow edges.
                /// </summary>
                [NameInMap("Edges")]
                [Validation(Required=false)]
                public List<GetWorkFlowResponseBodyDataWorkFlowNodeInfoEdges> Edges { get; set; }
                public class GetWorkFlowResponseBodyDataWorkFlowNodeInfoEdges : TeaModel {
                    /// <summary>
                    /// The ID of the source job.
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public long? Source { get; set; }

                    /// <summary>
                    /// The ID of the object job.
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public long? Target { get; set; }

                }

                /// <summary>
                /// The list of workflow nodes.
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<GetWorkFlowResponseBodyDataWorkFlowNodeInfoNodes> Nodes { get; set; }
                public class GetWorkFlowResponseBodyDataWorkFlowNodeInfoNodes : TeaModel {
                    /// <summary>
                    /// The ID of the job.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The name of the job.
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The status of the job.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

            }

        }

        /// <summary>
        /// Error message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the API call.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
