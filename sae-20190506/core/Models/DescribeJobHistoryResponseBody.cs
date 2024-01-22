// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeJobHistoryResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. Valid values:
        /// 
        /// *   **2xx**: The call was successful.
        /// *   **3xx**: The call was redirected.
        /// *   **4xx**: The call failed.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobHistoryResponseBodyData Data { get; set; }
        public class DescribeJobHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// The jobs.
            /// </summary>
            [NameInMap("Jobs")]
            [Validation(Required=false)]
            public List<DescribeJobHistoryResponseBodyDataJobs> Jobs { get; set; }
            public class DescribeJobHistoryResponseBodyDataJobs : TeaModel {
                /// <summary>
                /// The number of running instances.
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public long? Active { get; set; }

                /// <summary>
                /// The time when the job was executed.
                /// </summary>
                [NameInMap("CompletionTime")]
                [Validation(Required=false)]
                public long? CompletionTime { get; set; }

                /// <summary>
                /// The number of instances that failed to run.
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                /// <summary>
                /// The job ID.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The message returned if exceptions occur during job running.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The time when the job was created.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The status of the job. Valid values:
                /// 
                /// *   **0**: The job was not executed.
                /// *   **1**: The job was executed.
                /// *   **2**: The job failed to be executed.
                /// *   **3**: The job is being executed.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The number of instances that are successfully run.
                /// </summary>
                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }

            }

            /// <summary>
            /// The number of entries to return on each page. Valid values: 0 to 10000.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of jobs.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// The error code returned. Take note of the following rules:
        /// 
        /// *   If the call is successful, the **ErrorCode** parameter is not returned.
        /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned. Take note of the following rules:
        /// 
        /// *   If the call is successful, **success** is returned.
        /// *   If the call fails, an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
