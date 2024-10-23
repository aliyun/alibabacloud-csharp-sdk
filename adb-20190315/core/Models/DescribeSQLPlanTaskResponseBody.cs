// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPlanTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeSQLPlanTaskResponseBodyTaskList> TaskList { get; set; }
        public class DescribeSQLPlanTaskResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>The time elapsed from when the task was created to when the task was complete. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

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
            /// <para>The amount of input data in the task. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3763</para>
            /// </summary>
            [NameInMap("InputSize")]
            [Validation(Required=false)]
            public long? InputSize { get; set; }

            /// <summary>
            /// <para>The total amount of time consumed by operators in the task on a specific node. This parameter can be used to determine whether long tails occur in computing. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

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
            /// <para>The amount of output data in the task. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>945</para>
            /// </summary>
            [NameInMap("OutputSize")]
            [Validation(Required=false)]
            public long? OutputSize { get; set; }

            /// <summary>
            /// <para>The peak memory of the task on a specific node. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>898576</para>
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// <para>The time consumed to scan data from a data source in the task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScanCost")]
            [Validation(Required=false)]
            public long? ScanCost { get; set; }

            /// <summary>
            /// <para>The number of rows scanned from a data source in the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            /// <summary>
            /// <para>The amount of data scanned from a data source in the task. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScanSize")]
            [Validation(Required=false)]
            public long? ScanSize { get; set; }

            /// <summary>
            /// <para>The final execution status of the task. Valid values:</para>
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
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>198877623</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

    }

}
