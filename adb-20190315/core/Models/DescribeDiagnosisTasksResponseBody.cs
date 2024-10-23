// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0983B43-B2EC-536A-8791-142B5CF1E9B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried tasks.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisTasksResponseBodyTaskList> TaskList { get; set; }
        public class DescribeDiagnosisTasksResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>The compute time ratio, which can be used to determine whether the task is really time-consuming. This parameter can be calculated by using the following formula: OperatorCost/Drivers/ElapsedTime. A greater value indicates that the task was executed for computing for most of the task time. A less value indicates that the task was waiting for scheduling or blocked due to other reasons for most of the task time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.89</para>
            /// </summary>
            [NameInMap("ComputeTimeRatio")]
            [Validation(Required=false)]
            public string ComputeTimeRatio { get; set; }

            /// <summary>
            /// <para>The number of tasks that can be executed concurrently.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Drivers")]
            [Validation(Required=false)]
            public string Drivers { get; set; }

            /// <summary>
            /// <para>The amount of time that elapsed from when the task was created to when the task was completed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>456</para>
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The amount of input data in the task. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("InputDataSize")]
            [Validation(Required=false)]
            public long? InputDataSize { get; set; }

            /// <summary>
            /// <para>The number of input rows in the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>105</para>
            /// </summary>
            [NameInMap("InputRows")]
            [Validation(Required=false)]
            public long? InputRows { get; set; }

            /// <summary>
            /// <para>The total amount of time that is consumed by all operators in the task on a node. This parameter can be used to determine whether long tails occur in computing. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

            /// <summary>
            /// <para>The amount of output data in the task. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OutputDataSize")]
            [Validation(Required=false)]
            public long? OutputDataSize { get; set; }

            /// <summary>
            /// <para>The number of output rows in the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>105</para>
            /// </summary>
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// <para>The peak memory of the task. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234</para>
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// <para>The queuing duration of the task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("QueuedTime")]
            [Validation(Required=false)]
            public string QueuedTime { get; set; }

            /// <summary>
            /// <para>The amount of time that is consumed to scan data from a data source in the task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScanCost")]
            [Validation(Required=false)]
            public long? ScanCost { get; set; }

            /// <summary>
            /// <para>The amount of scanned data in the task. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ScanDataSize")]
            [Validation(Required=false)]
            public long? ScanDataSize { get; set; }

            /// <summary>
            /// <para>The number of rows that are scanned from a data source in the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            /// <summary>
            /// <para>The final execution state of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FINISHED</description></item>
            /// <item><description>CANCELED</description></item>
            /// <item><description>ABORTED</description></item>
            /// <item><description>FAILED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The timestamp when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-12 00:00:12</para>
            /// </summary>
            [NameInMap("TaskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the task ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-22 00:00:00</para>
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public long? TaskEndTime { get; set; }

            /// <summary>
            /// <para>The IP address of the host where the task was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("TaskHost")]
            [Validation(Required=false)]
            public string TaskHost { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22568****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The total number of tasks in the stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
