// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageFixTaskResponseBody : TeaModel {
        /// <summary>
        /// The tasks returned.
        /// </summary>
        [NameInMap("BuildTasks")]
        [Validation(Required=false)]
        public List<DescribeImageFixTaskResponseBodyBuildTasks> BuildTasks { get; set; }
        public class DescribeImageFixTaskResponseBodyBuildTasks : TeaModel {
            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("BuildTaskId")]
            [Validation(Required=false)]
            public string BuildTaskId { get; set; }

            /// <summary>
            /// The timestamp when the task starts. Unit: milliseconds.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// The timestamp when the task ends. Unit: milliseconds.
            /// </summary>
            [NameInMap("FixTime")]
            [Validation(Required=false)]
            public string FixTime { get; set; }

            /// <summary>
            /// The version of the image after image risks are fixed.
            /// </summary>
            [NameInMap("NewTag")]
            [Validation(Required=false)]
            public string NewTag { get; set; }

            /// <summary>
            /// The UUID of the image after image risks are fixed.
            /// </summary>
            [NameInMap("NewUuid")]
            [Validation(Required=false)]
            public string NewUuid { get; set; }

            /// <summary>
            /// The version of the image.
            /// </summary>
            [NameInMap("OldTag")]
            [Validation(Required=false)]
            public string OldTag { get; set; }

            /// <summary>
            /// The UUID of the image.
            /// </summary>
            [NameInMap("OldUuid")]
            [Validation(Required=false)]
            public string OldUuid { get; set; }

            /// <summary>
            /// The region of the image.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The namespace of the image.
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **1**: The task is running.
            /// *   **2**: The task is successful.
            /// *   **3**: The task failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The type of the task. The value is fixed as IMAGE_REPAIR. The value indicates a task that fixes image risks.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The alias of the fixed vulnerability.
            /// </summary>
            [NameInMap("VulAlias")]
            [Validation(Required=false)]
            public string VulAlias { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageFixTaskResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageFixTaskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of tasks returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page. Default value: **1**
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of tasks returned.
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
