// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskResponseBody : TeaModel {
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
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
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
        /// The task node.
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// The ID of the task flow to which the node belongs.
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// The position of the node on the Directed Acyclic Graph (DAG).
            /// </summary>
            [NameInMap("GraphParam")]
            [Validation(Required=false)]
            public string GraphParam { get; set; }

            /// <summary>
            /// The advanced configuration for the node.
            /// </summary>
            [NameInMap("NodeConfig")]
            [Validation(Required=false)]
            public string NodeConfig { get; set; }

            /// <summary>
            /// The configuration for the node.
            /// </summary>
            [NameInMap("NodeContent")]
            [Validation(Required=false)]
            public string NodeContent { get; set; }

            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The output variables for the node. This parameter is available only for some types of nodes.
            /// </summary>
            [NameInMap("NodeOutput")]
            [Validation(Required=false)]
            public string NodeOutput { get; set; }

            /// <summary>
            /// The type of the node. For more information about the valid values for this parameter, see [NodeType parameter](~~424705~~).
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// The time variables configured for the node.
            /// </summary>
            [NameInMap("TimeVariables")]
            [Validation(Required=false)]
            public string TimeVariables { get; set; }

        }

    }

}
