// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeChildrenResponseBody : TeaModel {
        /// <summary>
        /// The information of the descendant nodes.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNodeChildrenResponseBodyData Data { get; set; }
        public class GetNodeChildrenResponseBodyData : TeaModel {
            /// <summary>
            /// The descendant nodes returned.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetNodeChildrenResponseBodyDataNodes> Nodes { get; set; }
            public class GetNodeChildrenResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// The ID of the baseline.
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// The cron expression. Cron expressions are used to run auto triggered nodes.
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

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
                /// The ID of the Alibaba Cloud account used by the node owner.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The priority of the node. Valid values: 1 to 8. A large value indicates a high priority.
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
                /// *   true: indicates that the node can be rerun.
                /// *   false: indicates that the node cannot be rerun.
                /// </summary>
                [NameInMap("Repeatability")]
                [Validation(Required=false)]
                public bool? Repeatability { get; set; }

                /// <summary>
                /// The scheduling type of the node. Valid values:
                /// 
                /// *   NORMAL: indicates that the node is an auto triggered node.
                /// *   MANUAL: indicates that node is a manually triggered node.
                /// *   PAUSE: indicates that the node is a paused node. Paused nodes are started as scheduled but the system sets the status of the nodes to failed when it starts to run them.
                /// *   SKIP: indicates that the node is a dry-run node. Dry-run nodes are started as scheduled but the system sets the status of the nodes to successful when it starts to run them.
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

            }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
