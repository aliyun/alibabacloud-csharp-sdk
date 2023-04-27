// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskInstanceRelationResponseBody : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **GetTaskInstanceRelation**.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The status of the node. Valid values:
        /// 
        /// *   **0**: The node is waiting to be scheduled.
        /// *   **1**: The node is running.
        /// *   **2**: The node is suspended.
        /// *   **3**: The node failed to run.
        /// *   **4**: The node is run.
        /// *   **5**: The node is complete.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the task flow. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to obtain the ID of the task flow.
        /// </summary>
        [NameInMap("NodeList")]
        [Validation(Required=false)]
        public GetTaskInstanceRelationResponseBodyNodeList NodeList { get; set; }
        public class GetTaskInstanceRelationResponseBodyNodeList : TeaModel {
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<GetTaskInstanceRelationResponseBodyNodeListNode> Node { get; set; }
            public class GetTaskInstanceRelationResponseBodyNodeListNode : TeaModel {
                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("BusinessTime")]
                [Validation(Required=false)]
                public string BusinessTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The information about the nodes in the execution record of the task flow.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The ID of the execution record of the task flow.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                /// <summary>
                /// The type of the node. For more information about the valid values for this parameter, see [NodeType parameter](~~424705~~).
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
