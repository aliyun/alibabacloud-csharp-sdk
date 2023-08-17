// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPlanTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of tasks.
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeSQLPlanTaskResponseBodyTaskList> TaskList { get; set; }
        public class DescribeSQLPlanTaskResponseBodyTaskList : TeaModel {
            /// <summary>
            /// The time elapsed from when the task was created to when the task was complete. Unit: milliseconds.
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// The number of input rows in the task.
            /// </summary>
            [NameInMap("InputRows")]
            [Validation(Required=false)]
            public long? InputRows { get; set; }

            /// <summary>
            /// The amount of input data in the task. Unit: bytes.
            /// </summary>
            [NameInMap("InputSize")]
            [Validation(Required=false)]
            public long? InputSize { get; set; }

            /// <summary>
            /// The total amount of time consumed by operators in the task on a specific node. This parameter can be used to determine whether long tails occur in computing. Unit: milliseconds.
            /// </summary>
            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

            /// <summary>
            /// The number of output rows in the task.
            /// </summary>
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// The amount of output data in the task. Unit: bytes.
            /// </summary>
            [NameInMap("OutputSize")]
            [Validation(Required=false)]
            public long? OutputSize { get; set; }

            /// <summary>
            /// The peak memory of the task on a specific node. Unit: bytes.
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// The time consumed to scan data from a data source in the task. Unit: milliseconds.
            /// </summary>
            [NameInMap("ScanCost")]
            [Validation(Required=false)]
            public long? ScanCost { get; set; }

            /// <summary>
            /// The number of rows scanned from a data source in the task.
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            /// <summary>
            /// The amount of data scanned from a data source in the task. Unit: bytes.
            /// </summary>
            [NameInMap("ScanSize")]
            [Validation(Required=false)]
            public long? ScanSize { get; set; }

            /// <summary>
            /// The final execution status of the task. Valid values:
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
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

    }

}
