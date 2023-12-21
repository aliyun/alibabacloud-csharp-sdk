// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnfinishedOnceTaskResponseBody : TeaModel {
        /// <summary>
        /// The details of the tasks.
        /// </summary>
        [NameInMap("OnceTasks")]
        [Validation(Required=false)]
        public List<ListUnfinishedOnceTaskResponseBodyOnceTasks> OnceTasks { get; set; }
        public class ListUnfinishedOnceTaskResponseBodyOnceTasks : TeaModel {
            /// <summary>
            /// The time when the task ends.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// Indicates whether the task is complete. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public int? Finish { get; set; }

            /// <summary>
            /// The number of assets on which the task is complete.
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public int? FinishCount { get; set; }

            /// <summary>
            /// The progress percentage of the task.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// The execution duration of the task.
            /// </summary>
            [NameInMap("RealRunTime")]
            [Validation(Required=false)]
            public long? RealRunTime { get; set; }

            /// <summary>
            /// The execution result of the task.
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// The time when the task is started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **INIT**: The task is not started.
            /// *   **START**: The task is started.
            /// *   **SUCCESS**: The task is complete.
            /// *   **TIMEOUT**: The task timed out.
            /// </summary>
            [NameInMap("StatusText")]
            [Validation(Required=false)]
            public string StatusText { get; set; }

            /// <summary>
            /// The objective of the task.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The type of the assets that are scanned. Valid values:
            /// 
            /// *   **IMAGE_REPO**: image repository
            /// *   **IMAGE**: image
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The information about the image scan task.
            /// </summary>
            [NameInMap("TaskImageInfo")]
            [Validation(Required=false)]
            public ListUnfinishedOnceTaskResponseBodyOnceTasksTaskImageInfo TaskImageInfo { get; set; }
            public class ListUnfinishedOnceTaskResponseBodyOnceTasksTaskImageInfo : TeaModel {
                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the cluster.
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// The image digest.
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// The container image.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The instance ID of the node.
                /// </summary>
                [NameInMap("NodeInstanceId")]
                [Validation(Required=false)]
                public string NodeInstanceId { get; set; }

                /// <summary>
                /// The IP address of the node.
                /// </summary>
                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The pod of the image.
                /// </summary>
                [NameInMap("Pod")]
                [Validation(Required=false)]
                public string Pod { get; set; }

                /// <summary>
                /// The region ID of the server image.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the image repository.
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// The name of the image repository.
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// The namespace to which the image repository belongs.
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// The region ID of the image repository.
                /// </summary>
                [NameInMap("RepoRegionId")]
                [Validation(Required=false)]
                public string RepoRegionId { get; set; }

                /// <summary>
                /// The image tag.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The type of the task.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
