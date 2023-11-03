// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVirusScanLatestTaskStatisticResponseBody : TeaModel {
        /// <summary>
        /// The information about the virus scan task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVirusScanLatestTaskStatisticResponseBodyData Data { get; set; }
        public class GetVirusScanLatestTaskStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// The number of machines on which the virus scan task is complete.
            /// </summary>
            [NameInMap("CompleteMachine")]
            [Validation(Required=false)]
            public int? CompleteMachine { get; set; }

            /// <summary>
            /// The name of the machine.
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// The progress of the virus scan task in percentage.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The highest risk level of the detected alerts. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The number of safe machines that are detected.
            /// </summary>
            [NameInMap("SafeMachine")]
            [Validation(Required=false)]
            public int? SafeMachine { get; set; }

            /// <summary>
            /// The number of machines that are scanned.
            /// </summary>
            [NameInMap("ScanMachine")]
            [Validation(Required=false)]
            public int? ScanMachine { get; set; }

            /// <summary>
            /// The paths of files that were scanned. This value is returned only when ScanType is set to user.
            /// </summary>
            [NameInMap("ScanPath")]
            [Validation(Required=false)]
            public List<string> ScanPath { get; set; }

            /// <summary>
            /// The timestamp generated when the virus scan task was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            /// <summary>
            /// The type of the virus scan. Valid values:
            /// 
            /// *   **system**: automatic scan.
            /// *   **user**: custom scan.
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// The status of the virus scan task.
            /// 
            /// **Valid values for a main task**:
            /// 
            /// *   **0**: The main task is to be started.
            /// *   **10**: The main task is running.
            /// *   **100**: The main task is complete.
            /// 
            /// **Valid values for a subtask**:
            /// 
            /// *   **0**: The subtask is to be started.
            /// *   **20**: The scan script is sent.
            /// *   **50**: The subtask is running.
            /// *   **100**: The subtask is complete.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The number of alerts that are detected.
            /// </summary>
            [NameInMap("SuspiciousCount")]
            [Validation(Required=false)]
            public int? SuspiciousCount { get; set; }

            /// <summary>
            /// The number of suspicious machines that are detected.
            /// </summary>
            [NameInMap("SuspiciousMachine")]
            [Validation(Required=false)]
            public int? SuspiciousMachine { get; set; }

            /// <summary>
            /// The ID of the virus scan task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The number of machines on which the virus scan task was not complete or failed.
            /// </summary>
            [NameInMap("UnCompleteMachine")]
            [Validation(Required=false)]
            public int? UnCompleteMachine { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
