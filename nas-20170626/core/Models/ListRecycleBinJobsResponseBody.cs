// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecycleBinJobsResponseBody : TeaModel {
        /// <summary>
        /// The information about the jobs of the recycle bin.
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListRecycleBinJobsResponseBodyJobs> Jobs { get; set; }
        public class ListRecycleBinJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// The time when the job was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The error code returned.
            /// 
            /// A valid value is returned only if you set the Status parameter to Fail or PartialSuccess.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message.
            /// 
            /// A valid value is returned only if you set the Status parameter to Fail or PartialSuccess.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The ID of the file or directory in the job.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// The name of the file or directory that is associated with the job.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The job ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The progress of the job.
            /// 
            /// Valid values: 1 to 100.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The status of the job. Valid values:
            /// 
            /// *   Running: The job is running.
            /// *   Defragmenting: The job is defragmenting data.
            /// *   PartialSuccess: The job is partially completed.
            /// *   Success: The job is completed.
            /// *   Fail: The job failed.
            /// *   Cancelled: The job is canceled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the job. Valid values:
            /// 
            /// *   Restore: a file restoration job
            /// *   Delete: a file deletion job
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of jobs returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of jobs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
