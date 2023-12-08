// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppInfoResponseBody : TeaModel {
        /// <summary>
        /// The queried Spark application. Fields in the response parameter:
        /// 
        /// *   **Data**: the data of the Spark application template.
        /// *   **EstimateExecutionCpuTimeInSeconds**: the amount of time that is required to consume CPU resources for running the Spark application. Unit: milliseconds.
        /// *   **LogRootPath**: the storage path of log files.
        /// *   **LastAttemptId**: the most recent attempt ID.
        /// *   **WebUiAddress**: the web UI URL.
        /// *   **SubmittedTimeInMillis**: the time when the Spark application was submitted. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// *   **StartedTimeInMillis**: the time when the Spark application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// *   **LastUpdatedTimeInMillis**: the time when the Spark application was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// *   **TerminatedTimeInMillis**: the time when the Spark application was terminated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// *   **DBClusterId**: the ID of the cluster on which the Spark application runs.
        /// *   **ResourceGroupName**: the name of the job resource group.
        /// *   **DurationInMillis**: the amount of time that is required to run the Spark application. Unit: milliseconds.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SparkAppInfo Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
