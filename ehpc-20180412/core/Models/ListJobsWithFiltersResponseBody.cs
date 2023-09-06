// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobsWithFiltersResponseBody : TeaModel {
        /// <summary>
        /// The list of jobs.
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListJobsWithFiltersResponseBodyJobs> Jobs { get; set; }
        public class ListJobsWithFiltersResponseBodyJobs : TeaModel {
            /// <summary>
            /// The job array. If the job is not in a queue, the output is empty.
            /// 
            /// Format: X-Y:Z. X is the minimum index value. Y is the maximum index value. Z is the step size. For example, 2-7:2 indicates that three jobs need to be run and their index values are 2, 4, and 6.
            /// </summary>
            [NameInMap("ArrayRequest")]
            [Validation(Required=false)]
            public string ArrayRequest { get; set; }

            /// <summary>
            /// The description of the job.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The job ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The time when the job was last modified.
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            /// <summary>
            /// The name of the job.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The list of compute nodes that were used to run the job.
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public string NodeList { get; set; }

            /// <summary>
            /// The name of the user that ran the job.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The priority of the job. Valid values: 0 to 9. A larger value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// The number of queues that ran the job.
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// Indicates whether the job can be run again. Valid values:
            /// 
            /// *   true: yes
            /// *   false: no
            /// </summary>
            [NameInMap("Rerunable")]
            [Validation(Required=false)]
            public bool? Rerunable { get; set; }

            /// <summary>
            /// The resources that were used to run the job.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public ListJobsWithFiltersResponseBodyJobsResources Resources { get; set; }
            public class ListJobsWithFiltersResponseBodyJobsResources : TeaModel {
                /// <summary>
                /// The number of CPUs that were used to run the job.
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public long? Cores { get; set; }

                /// <summary>
                /// The number of nodes that were used to run the job.
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public long? Nodes { get; set; }

            }

            /// <summary>
            /// The path that was used to run the job.
            /// </summary>
            [NameInMap("ShellPath")]
            [Validation(Required=false)]
            public string ShellPath { get; set; }

            /// <summary>
            /// The time when the job was created.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the job. Valid value:
            /// 
            /// *   FINISHED: The job is completed.
            /// *   RUNNING: The job is running.
            /// *   QUEUED: The job is pending in a queue.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The output file path of stderr.
            /// </summary>
            [NameInMap("Stderr")]
            [Validation(Required=false)]
            public string Stderr { get; set; }

            /// <summary>
            /// The output file path of stdout.
            /// </summary>
            [NameInMap("Stdout")]
            [Validation(Required=false)]
            public string Stdout { get; set; }

            /// <summary>
            /// The time when the job was submitted.
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// The list of variables of the job.
            /// </summary>
            [NameInMap("VariableList")]
            [Validation(Required=false)]
            public string VariableList { get; set; }

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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
