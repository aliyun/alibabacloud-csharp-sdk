// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeParentsResponseBody : TeaModel {
        /// <summary>
        /// The information about the ancestor nodes.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNodeParentsResponseBodyData Data { get; set; }
        public class GetNodeParentsResponseBodyData : TeaModel {
            /// <summary>
            /// The ancestor nodes.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetNodeParentsResponseBodyDataNodes> Nodes { get; set; }
            public class GetNodeParentsResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// The baseline ID.
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// The CRON expression. CRON expressions are used to run auto triggered nodes.
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// The node ID.
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
                /// The ID of the Alibaba Cloud account used by the node owner.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The priority. Valid values: 1 to 8. A large value indicates a high priority.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The type of the node.
                /// </summary>
                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public string ProgramType { get; set; }

                /// <summary>
                /// The ID of the workspace to which the node belongs.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// Indicates whether the node can be rerun if the node fails to run. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("Repeatability")]
                [Validation(Required=false)]
                public bool? Repeatability { get; set; }

                /// <summary>
                /// The scheduling type of the node. Valid values:
                /// 
                /// *   NORMAL: The node is an auto triggered node.
                /// *   MANUAL: The node is a manually triggered node. Manually triggered nodes cannot be automatically triggered.
                /// *   PAUSE: The node is a paused node. Paused nodes are started as scheduled but the system sets the status of the nodes to failed when it starts to run them.
                /// *   SKIP: The node is a dry-run node. Dry-run nodes are started as scheduled but the system sets the status of the nodes to successful when it starts to run them.
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                [NameInMap("StepType")]
                [Validation(Required=false)]
                public string StepType { get; set; }

            }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
