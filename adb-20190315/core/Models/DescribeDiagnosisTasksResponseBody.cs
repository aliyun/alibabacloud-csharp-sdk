// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisTasksResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried tasks.
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisTasksResponseBodyTaskList> TaskList { get; set; }
        public class DescribeDiagnosisTasksResponseBodyTaskList : TeaModel {
            /// <summary>
            /// The compute time ratio, which can be used to determine whether the task is really time-consuming. This parameter can be calculated by using the following formula: OperatorCost/Drivers/ElapsedTime. A greater value indicates that the task was executed for computing for most of the task time. A less value indicates that the task was waiting for scheduling or blocked due to other reasons for most of the task time.
            /// </summary>
            [NameInMap("ComputeTimeRatio")]
            [Validation(Required=false)]
            public string ComputeTimeRatio { get; set; }

            /// <summary>
            /// The number of tasks that can be executed concurrently.
            /// </summary>
            [NameInMap("Drivers")]
            [Validation(Required=false)]
            public string Drivers { get; set; }

            /// <summary>
            /// The amount of time that elapsed from when the task was created to when the task was completed. Unit: milliseconds.
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// The amount of input data in the task. Unit: bytes.
            /// </summary>
            [NameInMap("InputDataSize")]
            [Validation(Required=false)]
            public long? InputDataSize { get; set; }

            /// <summary>
            /// The number of input rows in the task.
            /// </summary>
            [NameInMap("InputRows")]
            [Validation(Required=false)]
            public long? InputRows { get; set; }

            /// <summary>
            /// The total amount of time that is consumed by all operators in the task on a node. This parameter can be used to determine whether long tails occur in computing. Unit: milliseconds.
            /// </summary>
            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

            /// <summary>
            /// The amount of output data in the task. Unit: bytes.
            /// </summary>
            [NameInMap("OutputDataSize")]
            [Validation(Required=false)]
            public long? OutputDataSize { get; set; }

            /// <summary>
            /// The number of output rows in the task.
            /// </summary>
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// The peak memory of the task. Unit: bytes.
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// The queuing duration of the task. Unit: milliseconds.
            /// </summary>
            [NameInMap("QueuedTime")]
            [Validation(Required=false)]
            public string QueuedTime { get; set; }

            /// <summary>
            /// The amount of time that is consumed to scan data from a data source in the task. Unit: milliseconds.
            /// </summary>
            [NameInMap("ScanCost")]
            [Validation(Required=false)]
            public long? ScanCost { get; set; }

            /// <summary>
            /// The amount of scanned data in the task. Unit: bytes.
            /// </summary>
            [NameInMap("ScanDataSize")]
            [Validation(Required=false)]
            public long? ScanDataSize { get; set; }

            /// <summary>
            /// The number of rows that are scanned from a data source in the task.
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            /// <summary>
            /// The final execution state of the task. Valid values:
            /// 
            /// *   FINISHED
            /// *   CANCELED
            /// *   ABORTED
            /// *   FAILED
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The timestamp when the task was created.
            /// </summary>
            [NameInMap("TaskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            /// <summary>
            /// The timestamp when the task ends.
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public long? TaskEndTime { get; set; }

            /// <summary>
            /// The IP address of the host where the task was executed.
            /// </summary>
            [NameInMap("TaskHost")]
            [Validation(Required=false)]
            public string TaskHost { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// The total number of tasks in the stage.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
