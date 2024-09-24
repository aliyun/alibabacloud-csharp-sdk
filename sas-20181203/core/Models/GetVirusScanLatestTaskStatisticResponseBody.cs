// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVirusScanLatestTaskStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the virus scan task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVirusScanLatestTaskStatisticResponseBodyData Data { get; set; }
        public class GetVirusScanLatestTaskStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of machines on which the virus scan task is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CompleteMachine")]
            [Validation(Required=false)]
            public int? CompleteMachine { get; set; }

            /// <summary>
            /// <para>The name of the machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testMahine1</para>
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// <para>The progress of the virus scan task in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The highest risk level of the detected alerts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The number of safe machines that are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SafeMachine")]
            [Validation(Required=false)]
            public int? SafeMachine { get; set; }

            /// <summary>
            /// <para>The number of machines that are scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScanMachine")]
            [Validation(Required=false)]
            public int? ScanMachine { get; set; }

            /// <summary>
            /// <para>The paths of files that were scanned. This value is returned only when ScanType is set to user.</para>
            /// </summary>
            [NameInMap("ScanPath")]
            [Validation(Required=false)]
            public List<string> ScanPath { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the virus scan task was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681145862000</para>
            /// </summary>
            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            /// <summary>
            /// <para>The type of the virus scan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system</b>: automatic scan.</description></item>
            /// <item><description><b>user</b>: custom scan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The status of the virus scan task.</para>
            /// <para><b>Valid values for a main task</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The main task is to be started.</description></item>
            /// <item><description><b>10</b>: The main task is running.</description></item>
            /// <item><description><b>100</b>: The main task is complete.</description></item>
            /// </list>
            /// <para><b>Valid values for a subtask</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The subtask is to be started.</description></item>
            /// <item><description><b>20</b>: The scan script is sent.</description></item>
            /// <item><description><b>50</b>: The subtask is running.</description></item>
            /// <item><description><b>100</b>: The subtask is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The number of alerts that are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SuspiciousCount")]
            [Validation(Required=false)]
            public int? SuspiciousCount { get; set; }

            /// <summary>
            /// <para>The number of suspicious machines that are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SuspiciousMachine")]
            [Validation(Required=false)]
            public int? SuspiciousMachine { get; set; }

            /// <summary>
            /// <para>The ID of the virus scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fc98d58eb56f699d49bf7ebbd6d7****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The number of machines on which the virus scan task was not complete or failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnCompleteMachine")]
            [Validation(Required=false)]
            public int? UnCompleteMachine { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
