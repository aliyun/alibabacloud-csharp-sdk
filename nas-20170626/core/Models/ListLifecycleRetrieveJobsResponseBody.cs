// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListLifecycleRetrieveJobsResponseBody : TeaModel {
        /// <summary>
        /// The details about the data retrieval tasks.
        /// </summary>
        [NameInMap("LifecycleRetrieveJobs")]
        [Validation(Required=false)]
        public List<ListLifecycleRetrieveJobsResponseBodyLifecycleRetrieveJobs> LifecycleRetrieveJobs { get; set; }
        public class ListLifecycleRetrieveJobsResponseBodyLifecycleRetrieveJobs : TeaModel {
            /// <summary>
            /// The time when the task was created.
            /// 
            /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The total number of files that are read in the data retrieval task.
            /// </summary>
            [NameInMap("DiscoveredFileCount")]
            [Validation(Required=false)]
            public long? DiscoveredFileCount { get; set; }

            /// <summary>
            /// The ID of the file system.
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// The ID of the data retrieval task.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// The total number of files that are retrieved.
            /// </summary>
            [NameInMap("RetrievedFileCount")]
            [Validation(Required=false)]
            public long? RetrievedFileCount { get; set; }

            /// <summary>
            /// The status of the data retrieval task. Valid values:
            /// 
            /// *   active: The task is running.
            /// *   canceled: The task is canceled.
            /// *   completed: The task is completed.
            /// *   failed: The task has failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the task was updated.
            /// 
            /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of data retrieval tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
