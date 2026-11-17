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
            /// <para>The creation time of the task. The value is a millisecond timestamp (Unix epoch in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The end time of the task. The value is a millisecond timestamp (Unix epoch in milliseconds). If the task has not ended, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of samples that have been executed for the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ExecuteCaseCount")]
            [Validation(Required=false)]
            public long? ExecuteCaseCount { get; set; }

            /// <summary>
            /// <para>The report language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("ReportLanguage")]
            [Validation(Required=false)]
            public string ReportLanguage { get; set; }

            /// <summary>
            /// <para>The risk level of the task result. If the task is not completed or no risk assessment is generated, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The sample language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("SampleLanguage")]
            [Validation(Required=false)]
            public string SampleLanguage { get; set; }

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
            /// <para>The scan mode of the task. For historical tasks that do not have a recorded scan mode, the value is normalized to attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attack</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The unique identifier of the scan task. It can be used to download results and track status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-abc123def4567</para>
            /// </summary>
            [NameInMap("ScannerTaskId")]
            [Validation(Required=false)]
            public string ScannerTaskId { get; set; }

            /// <summary>
            /// <para>The task message. If the task fails, this parameter indicates the cause of the failure. If the task succeeds or no message is available, this parameter is empty.</para>
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
            /// <para>The actual execution mode used by the scan task, which is obtained from the scannerType field of the task. classic indicates the sample mode. agent indicates the autonomous multi-round attack mode of the agent. executor is a historical compatibility value, which is equivalent to classic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>classic</para>
            /// </summary>
            [NameInMap("ScannerType")]
            [Validation(Required=false)]
            public string ScannerType { get; set; }

            /// <summary>
            /// <para>The start time of the task. The value is a millisecond timestamp (Unix epoch in milliseconds). If the task has not started, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The name of the task. If no name is specified during creation, the default value is Target Scan - target name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Target Scan - My Model Studio target</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The total number of samples planned to be executed for the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("TotalCaseCount")]
            [Validation(Required=false)]
            public long? TotalCaseCount { get; set; }

        }

        /// <summary>
        /// <para>The actual effective page number after normalization. This value may not be equal to the input parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The actual effective number of entries per page after normalization. This value may not be equal to the input parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. It is used for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-B7AB7B5A9C8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of scan tasks that meet the filter conditions within the last 366 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
