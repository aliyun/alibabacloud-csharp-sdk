// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeCommitContainerTaskResponseBody : TeaModel {
        /// <summary>
        /// Details of the task.
        /// </summary>
        [NameInMap("CommitTasks")]
        [Validation(Required=false)]
        public List<DescribeCommitContainerTaskResponseBodyCommitTasks> CommitTasks { get; set; }
        public class DescribeCommitContainerTaskResponseBodyCommitTasks : TeaModel {
            /// <summary>
            /// The information about the phase that the task arrives.
            /// </summary>
            [NameInMap("CommitPhaseInfos")]
            [Validation(Required=false)]
            public List<DescribeCommitContainerTaskResponseBodyCommitTasksCommitPhaseInfos> CommitPhaseInfos { get; set; }
            public class DescribeCommitContainerTaskResponseBodyCommitTasksCommitPhaseInfos : TeaModel {
                /// <summary>
                /// The message about the phase.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The phase name. Valid values:
                /// 
                /// *   PullBaseImage: Pull the original container image.
                /// *   CommitContainer: Commit the container to generate an image.
                /// *   PushCommittedImage: Push the image to Container Registry.
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// The record time of the phase.
                /// </summary>
                [NameInMap("RecordTime")]
                [Validation(Required=false)]
                public string RecordTime { get; set; }

                /// <summary>
                /// The state of the phase.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The container name.
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// The message about the state.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// The time when the task was started.
            /// </summary>
            [NameInMap("TaskCreationTime")]
            [Validation(Required=false)]
            public string TaskCreationTime { get; set; }

            /// <summary>
            /// The time when the task was complete.
            /// </summary>
            [NameInMap("TaskFinishedTime")]
            [Validation(Required=false)]
            public string TaskFinishedTime { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The progress of the task in percentage.
            /// </summary>
            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public string TaskProgress { get; set; }

            /// <summary>
            /// The state of the task. Valid values:
            /// 
            /// *   Running
            /// *   Succeeded
            /// *   Failed
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// The query token that is returned in this request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
