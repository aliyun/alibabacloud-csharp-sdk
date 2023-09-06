// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListServerlessJobsResponseBody : TeaModel {
        /// <summary>
        /// The list of serverless jobs.
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListServerlessJobsResponseBodyJobs> Jobs { get; set; }
        public class ListServerlessJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// The time at which the serverless job ended.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// Indicates whether the job is an array job. Valid values:
            /// 
            /// *   True: yes
            /// *   False: no
            /// </summary>
            [NameInMap("IsArrayJob")]
            [Validation(Required=false)]
            public bool? IsArrayJob { get; set; }

            /// <summary>
            /// The ID of the serverless job or subtask (array job).
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The name of the serverless job.
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// The scheduling priority of the serverless job. Valid values are 0 to 999. A greater value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// The name of the queue in which the serverless job is run.
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// The time at which the serverless job started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the serverless job. Valid values:
            /// 
            /// *   Pending
            /// *   Initing
            /// *   Running
            /// *   Succeeded
            /// *   Canceled
            /// *   Failed
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The time at which the serverless job is submitted.
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// The username that is used to run the serverless job.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The page number returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
