// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceDeploymentResponseBody : TeaModel {
        /// <summary>
        /// The return code of the operation. A value of Success indicates that the call was successful. Other values indicate that specific errors occurred. For more information, see [Error codes](~~135200~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned if the call was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEdgeInstanceDeploymentResponseBodyData Data { get; set; }
        public class GetEdgeInstanceDeploymentResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the deployment task.
            /// </summary>
            [NameInMap("DeploymentId")]
            [Validation(Required=false)]
            public string DeploymentId { get; set; }

            /// <summary>
            /// The description of the deployment task.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the deployment task was complete.
            /// </summary>
            [NameInMap("GmtCompleted")]
            [Validation(Required=false)]
            public string GmtCompleted { get; set; }

            /// <summary>
            /// The UNIX timestamp when the deployment task was complete.
            /// </summary>
            [NameInMap("GmtCompletedTimestamp")]
            [Validation(Required=false)]
            public long? GmtCompletedTimestamp { get; set; }

            /// <summary>
            /// The time when the deployment task was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The UNIX timestamp when the deployment task was created.
            /// </summary>
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }

            /// <summary>
            /// The last time when the deployment task was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The last UNIX timestamp when the deployment task was modified.
            /// </summary>
            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }

            /// <summary>
            /// The status of the deployment task.
            /// 
            /// *   0: The task was not started.
            /// *   1: The task was being processed.
            /// *   2: The task was successful.
            /// *   3: The task failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The list of deployment subtasks.
            /// </summary>
            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<GetEdgeInstanceDeploymentResponseBodyDataTaskList> TaskList { get; set; }
            public class GetEdgeInstanceDeploymentResponseBodyDataTaskList : TeaModel {
                /// <summary>
                /// The ID of the gateway.
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// The time when the deployment subtask was complete.
                /// </summary>
                [NameInMap("GmtCompleted")]
                [Validation(Required=false)]
                public string GmtCompleted { get; set; }

                /// <summary>
                /// The UNIX timestamp when the deployment subtask was complete.
                /// </summary>
                [NameInMap("GmtCompletedTimestamp")]
                [Validation(Required=false)]
                public long? GmtCompletedTimestamp { get; set; }

                /// <summary>
                /// The time when the deployment subtask was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The UNIX timestamp when the deployment subtask was created.
                /// </summary>
                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=false)]
                public long? GmtCreateTimestamp { get; set; }

                /// <summary>
                /// The last time when the deployment subtask was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The last UNIX timestamp when the deployment subtask was modified.
                /// </summary>
                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=false)]
                public long? GmtModifiedTimestamp { get; set; }

                /// <summary>
                /// The list of deployment task snapshots.
                /// </summary>
                [NameInMap("ResourceSnapshotList")]
                [Validation(Required=false)]
                public List<GetEdgeInstanceDeploymentResponseBodyDataTaskListResourceSnapshotList> ResourceSnapshotList { get; set; }
                public class GetEdgeInstanceDeploymentResponseBodyDataTaskListResourceSnapshotList : TeaModel {
                    /// <summary>
                    /// The time when the deployment task snapshot was complete.
                    /// </summary>
                    [NameInMap("GmtCompleted")]
                    [Validation(Required=false)]
                    public string GmtCompleted { get; set; }

                    /// <summary>
                    /// The UNIX timestamp when the deployment task snapshot was complete.
                    /// </summary>
                    [NameInMap("GmtCompletedTimestamp")]
                    [Validation(Required=false)]
                    public long? GmtCompletedTimestamp { get; set; }

                    /// <summary>
                    /// The time when the deployment task snapshot was created.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// The UNIX timestamp when the deployment task snapshot was created.
                    /// </summary>
                    [NameInMap("GmtCreateTimestamp")]
                    [Validation(Required=false)]
                    public long? GmtCreateTimestamp { get; set; }

                    /// <summary>
                    /// The last time when the deployment task snapshot was modified.
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// The last UNIX timestamp when the deployment task snapshot was modified.
                    /// </summary>
                    [NameInMap("GmtModifiedTimestamp")]
                    [Validation(Required=false)]
                    public long? GmtModifiedTimestamp { get; set; }

                    /// <summary>
                    /// The logs of resource deployment.
                    /// </summary>
                    [NameInMap("Log")]
                    [Validation(Required=false)]
                    public string Log { get; set; }

                    /// <summary>
                    /// The type of the operation.
                    /// 
                    /// *   0: deploys resources.
                    /// *   1: deletes resources.
                    /// </summary>
                    [NameInMap("OperateType")]
                    [Validation(Required=false)]
                    public int? OperateType { get; set; }

                    /// <summary>
                    /// The ID of the resource.
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// The name of the resource.
                    /// </summary>
                    [NameInMap("ResourceName")]
                    [Validation(Required=false)]
                    public string ResourceName { get; set; }

                    /// <summary>
                    /// The type of the resource.
                    /// </summary>
                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    /// <summary>
                    /// The ID of the deployment task snapshot.
                    /// </summary>
                    [NameInMap("SnapshotId")]
                    [Validation(Required=false)]
                    public string SnapshotId { get; set; }

                    /// <summary>
                    /// The stage of the snapshot task.
                    /// 
                    /// *   0: The snapshot task was in the initial state.
                    /// *   8: The snapshot task was being assembled.
                    /// *   16: The snapshot task was being packaged.
                    /// *   24: The snapshot task was being dispatched.
                    /// *   32: The snapshot task was complete.
                    /// </summary>
                    [NameInMap("Stage")]
                    [Validation(Required=false)]
                    public int? Stage { get; set; }

                    /// <summary>
                    /// The status of the snapshot task.
                    /// 
                    /// *   0: The snapshot task was not started.
                    /// *   1: The snapshot task was being processed.
                    /// *   2: The snapshot task was successful.
                    /// *   3: The snapshot task failed.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

                /// <summary>
                /// The stage of the deployment subtask.
                /// 
                /// *   0: The subtask was not started.
                /// *   8: The subtask was being assembled.
                /// *   16: The subtask was being packaged.
                /// *   24: The subtask was being dispatched.
                /// *   32: The subtask was complete.
                /// </summary>
                [NameInMap("Stage")]
                [Validation(Required=false)]
                public int? Stage { get; set; }

                /// <summary>
                /// The status of the deployment subtask.
                /// 
                /// *   0: The subtask was in the initial state.
                /// *   1: The subtask was being processed.
                /// *   2: The subtask was successful.
                /// *   3: The subtask failed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The ID of the deployment subtask.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// The type of the deployment task.
            /// 
            /// *   deploy: deploys the edge instance.
            /// *   reset: resets the edge instance.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the call failed.
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
        /// Indicates whether the call was successful. A value of true indicates that the call was successful. A value of false indicates that the call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
