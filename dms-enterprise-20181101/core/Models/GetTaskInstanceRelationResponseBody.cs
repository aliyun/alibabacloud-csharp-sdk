// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskInstanceRelationResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The information about the nodes in the execution record of the task flow.
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
                /// The business time of the node.
                /// </summary>
                [NameInMap("BusinessTime")]
                [Validation(Required=false)]
                public string BusinessTime { get; set; }

                /// <summary>
                /// The time when the execution of the task flow was complete. The time is displayed in the yyyy-MM-DD HH:mm:ss format.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The amount of time consumed for running the node. Unit: milliseconds.
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// The ID of the execution record of the task flow.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The description of the task.
                /// </summary>
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
                public int? NodeType { get; set; }

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
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
