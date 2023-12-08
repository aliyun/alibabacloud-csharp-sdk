// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskLeafRecordPageResponseBody : TeaModel {
        /// <summary>
        /// The details of the sub-task.
        /// </summary>
        [NameInMap("OnceTasks")]
        [Validation(Required=false)]
        public List<DescribeOnceTaskLeafRecordPageResponseBodyOnceTasks> OnceTasks { get; set; }
        public class DescribeOnceTaskLeafRecordPageResponseBodyOnceTasks : TeaModel {
            /// <summary>
            /// The time when the sub-task ends.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// Indicates whether the sub-task is complete.
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public int? Finish { get; set; }

            /// <summary>
            /// The number of the assets that are scanned.
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public string FinishCount { get; set; }

            /// <summary>
            /// The progress percentage of the sub-task.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// The execution duration of the sub-task.
            /// </summary>
            [NameInMap("RealRunTime")]
            [Validation(Required=false)]
            public long? RealRunTime { get; set; }

            /// <summary>
            /// The execution result.
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// The time when the sub-task starts.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The sub-task status. Valid values:
            /// 
            /// *   **INIT**: The sub-task is not started.
            /// *   **START**: The sub-task is started.
            /// *   **SUCCESS**: The sub-task is complete.
            /// *   **TIMEOUT**: The sub-task timed out.
            /// </summary>
            [NameInMap("StatusText")]
            [Validation(Required=false)]
            public string StatusText { get; set; }

            /// <summary>
            /// The objective of the sub-task.
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
            /// The sub-task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The information about the image scan.
            /// </summary>
            [NameInMap("TaskImageInfo")]
            [Validation(Required=false)]
            public DescribeOnceTaskLeafRecordPageResponseBodyOnceTasksTaskImageInfo TaskImageInfo { get; set; }
            public class DescribeOnceTaskLeafRecordPageResponseBodyOnceTasksTaskImageInfo : TeaModel {
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
                /// The cluster name.
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// The time consumed. The value is in the JSON format. The end time of each item is displayed.
                /// 
                /// *   **vul**: system vulnerabilities
                /// *   **scaVul**: application vulnerabilities
                /// *   **scaVul**: baseline
                /// *   **binary**: binary
                /// *   **forbiddenPackageInfo**: information about the prohibited package
                /// *   **identificationInfo**: identity authentication
                /// *   **script**: malicious scripts
                /// *   **sensitiveFile**: sensitive files
                /// *   **sensitiveInfo**: AccessKey pair leaks
                /// *   **webshell**: website scripts
                /// </summary>
                [NameInMap("CostTimeInfo")]
                [Validation(Required=false)]
                public string CostTimeInfo { get; set; }

                /// <summary>
                /// The digest of the image.
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// The image of the container.
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
                /// The name of the namespace to which the image repository belongs.
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
                /// The tag that is added to the image.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// The name of the sub-task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The type of the sub-task.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeOnceTaskLeafRecordPageResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeOnceTaskLeafRecordPageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

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
