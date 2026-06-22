// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVirusScanLatestTaskStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom result data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVirusScanLatestTaskStatisticResponseBodyData Data { get; set; }
        public class GetVirusScanLatestTaskStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of servers that completed the scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CompleteMachine")]
            [Validation(Required=false)]
            public int? CompleteMachine { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testMahine1</para>
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// <para>The progress percentage of the scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The highest risk level of the alerts detected by the scan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b>: high-risk.</description></item>
            /// <item><description><b>medium</b>: medium-risk.</description></item>
            /// <item><description><b>low</b>: low-risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The number of servers on which no risks are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SafeMachine")]
            [Validation(Required=false)]
            public int? SafeMachine { get; set; }

            /// <summary>
            /// <para>The number of servers scanned in this virus scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScanMachine")]
            [Validation(Required=false)]
            public int? ScanMachine { get; set; }

            /// <summary>
            /// <para>The file paths specified for scanning when the scan type is user-defined.</para>
            /// </summary>
            [NameInMap("ScanPath")]
            [Validation(Required=false)]
            public List<string> ScanPath { get; set; }

            /// <summary>
            /// <para>The timestamp of the scan. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681145862000</para>
            /// </summary>
            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            /// <summary>
            /// <para>The scan type of this virus scan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system</b>: automatic system scan.</description></item>
            /// <item><description><b>user</b>: user-defined scan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The status of the scan task.</para>
            /// <para><b>Valid values for the main task:</b></para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The task is pending.</description></item>
            /// <item><description><b>10</b>: The scan is in progress.</description></item>
            /// <item><description><b>100</b>: The scan is complete.</description></item>
            /// </list>
            /// <para><b>Valid values for the subtask:</b></para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The scan is pending.</description></item>
            /// <item><description><b>20</b>: The detection script is delivered.</description></item>
            /// <item><description><b>50</b>: The scan is running on the server.</description></item>
            /// <item><description><b>100</b>: The scan is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The number of security alerts detected by the scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SuspiciousCount")]
            [Validation(Required=false)]
            public int? SuspiciousCount { get; set; }

            /// <summary>
            /// <para>The number of servers on which risks are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SuspiciousMachine")]
            [Validation(Required=false)]
            public int? SuspiciousMachine { get; set; }

            /// <summary>
            /// <para>The ID of the scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fc98d58eb56f699d49bf7ebbd6d7****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The number of servers that have not completed the scan or failed the scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnCompleteMachine")]
            [Validation(Required=false)]
            public int? UnCompleteMachine { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
