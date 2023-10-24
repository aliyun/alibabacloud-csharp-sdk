// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRunningJobsResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRunningJobsResponseBodyData Data { get; set; }
        public class GetRunningJobsResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The list of jobs in the running state.
            /// </summary>
            [NameInMap("runningJobInfoList")]
            [Validation(Required=false)]
            public List<GetRunningJobsResponseBodyDataRunningJobInfoList> RunningJobInfoList { get; set; }
            public class GetRunningJobsResponseBodyDataRunningJobInfoList : TeaModel {
                /// <summary>
                /// The compute unit (CU) snapshot proportion of the job.
                /// </summary>
                [NameInMap("cuSnapshot")]
                [Validation(Required=false)]
                public double? CuSnapshot { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The account that submits the job.
                /// </summary>
                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                /// <summary>
                /// The memory snapshot proportion of the job.
                /// </summary>
                [NameInMap("memorySnapshot")]
                [Validation(Required=false)]
                public double? MemorySnapshot { get; set; }

                /// <summary>
                /// The progress of the job.
                /// </summary>
                [NameInMap("progress")]
                [Validation(Required=false)]
                public double? Progress { get; set; }

                /// <summary>
                /// The name of the MaxCompute project.
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// The nickname of the quota that is used by the job.
                /// </summary>
                [NameInMap("quotaNickname")]
                [Validation(Required=false)]
                public string QuotaNickname { get; set; }

                /// <summary>
                /// The time when the job starts to run.
                /// </summary>
                [NameInMap("runningAtTime")]
                [Validation(Required=false)]
                public long? RunningAtTime { get; set; }

                /// <summary>
                /// The time when the job is submitted.
                /// </summary>
                [NameInMap("submittedAtTime")]
                [Validation(Required=false)]
                public long? SubmittedAtTime { get; set; }

            }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// *   If the value of success was false, an error code was returned.
        /// *   If the value of success was true, a null value was returned.
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
