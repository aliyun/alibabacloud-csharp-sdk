// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOnlineDDLProgressResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of the task.
        /// </summary>
        [NameInMap("OnlineDDLTaskDetail")]
        [Validation(Required=false)]
        public GetOnlineDDLProgressResponseBodyOnlineDDLTaskDetail OnlineDDLTaskDetail { get; set; }
        public class GetOnlineDDLProgressResponseBodyOnlineDDLTaskDetail : TeaModel {
            /// <summary>
            /// The cleanup policy of the original table after the cut-over. Valid values:
            /// 
            /// *   **DROP**: Invalid original tables are deleted.
            /// *   **MOVE**: Invalid original tables are moved to the test database. You can delete the tables manually.
            /// *   **NOTHING**: Invalid original tables are retained in the original database. You can delete the tables manually.
            /// </summary>
            [NameInMap("CleanStrategy")]
            [Validation(Required=false)]
            public string CleanStrategy { get; set; }

            /// <summary>
            /// The policy of full replication. Valid values:
            /// 
            /// *   **AUTO**: DMS dynamically adjusts the chunk size based on the performance of the database. Tables are locked for less than 1.5 seconds during a single replication operation.
            /// *   **RUNNING**: DMS uses the specified value of the CopyChunkSize parameter. The valid value of the CopyChunkSize parameter ranges from 1 to 60000. If you set this parameter to RUNNING, you must specify the CopyChunkSize parameter.
            /// </summary>
            [NameInMap("CopyChunkMode")]
            [Validation(Required=false)]
            public string CopyChunkMode { get; set; }

            /// <summary>
            /// The size of each chunk that is used to replicate data. This parameter is used to specify the size of each chunk. A larger chunk size increases the replication efficiency and decreases the business performance.
            /// 
            /// > During full replication, the original table is divided into N small chunks and each chunk is replicated to the temporary table one by one. By default, DMS dynamically adjusts the size of each chunk.
            /// </summary>
            [NameInMap("CopyChunkSize")]
            [Validation(Required=false)]
            public long? CopyChunkSize { get; set; }

            /// <summary>
            /// The actual amount of data replicated from the original table in the lock-free change operation.
            /// </summary>
            [NameInMap("CopyCount")]
            [Validation(Required=false)]
            public long? CopyCount { get; set; }

            /// <summary>
            /// The estimated total number of rows of the data. The value is obtained from the statistical data in the information_schema database. In most cases, the estimated total number of rows is smaller than the actual number of rows in a table.
            /// </summary>
            [NameInMap("CopyTotal")]
            [Validation(Required=false)]
            public long? CopyTotal { get; set; }

            /// <summary>
            /// The number of retries when the cut-over fails.
            /// </summary>
            [NameInMap("CutoverFailRetryTimes")]
            [Validation(Required=false)]
            public long? CutoverFailRetryTimes { get; set; }

            /// <summary>
            /// The maximum period of time that a table can be locked during cut-over. Unit: seconds.
            /// </summary>
            [NameInMap("CutoverLockTimeSeconds")]
            [Validation(Required=false)]
            public long? CutoverLockTimeSeconds { get; set; }

            /// <summary>
            /// The end of the time window of the cut-over operation. This value is at least 30 minutes later than the CutoverWindowStartTime parameter. Default value: 23:59:59
            /// </summary>
            [NameInMap("CutoverWindowEndTime")]
            [Validation(Required=false)]
            public string CutoverWindowEndTime { get; set; }

            /// <summary>
            /// The beginning of the time window of the cut-over operation. Default value: 00:00:00. This parameter controls the time window of the cut-over. Cut-over can be performed only when the cut-over conditions are met and the time is within the specified time window. If the time is not within the time window, the cut-over operation is not performed until the time reaches the beginning of the time window.
            /// </summary>
            [NameInMap("CutoverWindowStartTime")]
            [Validation(Required=false)]
            public string CutoverWindowStartTime { get; set; }

            /// <summary>
            /// The replay latency of DMS. Unit: seconds. The replay latency is the period of time that is taken to replay the binary logs of the table to the temporary table. The latency does not indicate the data migration latency between a primary database and a secondary database.
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            /// <summary>
            /// The state of the task. Valid values:
            /// 
            /// *   **INIT**: The task is being initialized.
            /// *   **SUCCESS**: The task is complete.
            /// *   **RUNNING**: The task is being executed.
            /// *   **WAITING_CUTOVER**: The task is waiting for cut-over.
            /// *   **RESTARTING**: The task is restarting.
            /// *   **PAUSE**: The task is suspended.
            /// *   **UNSUPPORTED**: The task is not supported.
            /// *   **CANCELED**: The task is canceled.
            /// *   **FAIL**: The task failed.
            /// *   **INTERRUPT**: The task is interrupted.
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// The estimated execution progress. The actual progress is subject to the task status.
            /// </summary>
            [NameInMap("ProgressRatio")]
            [Validation(Required=false)]
            public string ProgressRatio { get; set; }

            /// <summary>
            /// The description of the task status.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
