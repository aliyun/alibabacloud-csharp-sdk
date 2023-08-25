// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListSparkAppAttemptsResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSparkAppAttemptsResponseBodyData Data { get; set; }
        public class ListSparkAppAttemptsResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the attempts. Fields in the response parameter:
            /// 
            /// *   **AttemptId**: the attempt ID.
            /// 
            /// *   **State**: the state of the Spark application. Valid values:
            /// 
            ///     *   **SUBMITTED**
            ///     *   **STARTING**
            ///     *   **RUNNING**
            ///     *   **FAILING**
            ///     *   **FAILED**
            ///     *   **KILLING**
            ///     *   **KILLED**
            ///     *   **SUCCEEDING**
            ///     *   **COMPLETED**
            ///     *   **FATAL**
            ///     *   **UNKNOWN**
            /// 
            /// *   **Message**: the alert message that is returned. If no alert is generated, null is returned.
            /// 
            /// *   **Data**: the data of the Spark application template.
            /// 
            /// *   **EstimateExecutionCpuTimeInSeconds**: the amount of time it takes to consume CPU resources for running the Spark application. Unit: milliseconds.
            /// 
            /// *   **LogRootPath**: the storage path of log files.
            /// 
            /// *   **LastAttemptId**: the ID of the last attempt.
            /// 
            /// *   **WebUiAddress**: the web UI address.
            /// 
            /// *   **SubmittedTimeInMillis**: the time when the Spark application was submitted. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// 
            /// *   **StartedTimeInMillis**: the time when the Spark application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// 
            /// *   **LastUpdatedTimeInMillis**: the time when the Spark application was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// 
            /// *   **TerminatedTimeInMillis**: the time when the Spark application task was terminated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// 
            /// *   **DBClusterId**: the ID of the cluster on which the Spark application runs.
            /// 
            /// *   **ResourceGroupName**: the name of the job resource group.
            /// 
            /// *   **DurationInMillis**: the amount of time it takes to run the Spark application. Unit: milliseconds.
            /// </summary>
            [NameInMap("AttemptInfoList")]
            [Validation(Required=false)]
            public List<SparkAttemptInfo> AttemptInfoList { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
