// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class ListScanTasksByTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of scan tasks on the current page.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListScanTasksByTargetResponseBodyData> Data { get; set; }
        public class ListScanTasksByTargetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task creation time, in milliseconds (Unix epoch milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The task end time, in milliseconds (Unix epoch milliseconds). This value is null if the task has not ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of samples that the task has executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ExecuteCaseCount")]
            [Validation(Required=false)]
            public long? ExecuteCaseCount { get; set; }

            /// <summary>
            /// <para>The risk level of the task result. This value is null if the task is not completed or no risk assessment has been generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The detection intensity of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SampleLevel")]
            [Validation(Required=false)]
            public long? SampleLevel { get; set; }

            /// <summary>
            /// <para>The scan type of the task. Historical tasks without a recorded scan type are normalized to attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attack</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The unique identifier of the scan task. You can use this ID for result download and status tracking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-abc123def4567</para>
            /// </summary>
            [NameInMap("ScannerTaskId")]
            [Validation(Required=false)]
            public string ScannerTaskId { get; set; }

            /// <summary>
            /// <para>The task message. This value contains the failure reason if the task failed, or is empty if the task succeeded or no message is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Execution timed out</para>
            /// </summary>
            [NameInMap("ScannerTaskMessage")]
            [Validation(Required=false)]
            public string ScannerTaskMessage { get; set; }

            /// <summary>
            /// <para>The current status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("ScannerTaskStatus")]
            [Validation(Required=false)]
            public string ScannerTaskStatus { get; set; }

            /// <summary>
            /// <para>The task start time, in milliseconds (Unix epoch milliseconds). This value is null if the task has not started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The task name. If no name is specified during creation, the default value is &quot;Target Scan - target name&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Target Scan - My Bailian Target</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The total number of samples that the task plans to execute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("TotalCaseCount")]
            [Validation(Required=false)]
            public long? TotalCaseCount { get; set; }

        }

        /// <summary>
        /// <para>The normalized page number that actually takes effect. This value may differ from the input parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The normalized number of entries per page that actually takes effect. This value may differ from the input parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, used for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-B7AB7B5A9C8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of scan tasks that match the filter conditions within the last 366-day window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
