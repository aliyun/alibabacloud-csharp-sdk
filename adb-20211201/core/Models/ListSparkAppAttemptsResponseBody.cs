// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListSparkAppAttemptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSparkAppAttemptsResponseBodyData Data { get; set; }
        public class ListSparkAppAttemptsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The retry information list. Response parameter description:</para>
            /// <list type="bullet">
            /// <item><description><b>AttemptId</b>: The retry ID.</description></item>
            /// <item><description><b>State</b>: The execution state of the application. Valid values:<list type="bullet">
            /// <item><description><b>SUBMITTED</b>: Submitted.</description></item>
            /// <item><description><b>STARTING</b>: Starting.</description></item>
            /// <item><description><b>RUNNING</b>: Running.</description></item>
            /// <item><description><b>FAILING</b>: The task failed. Cleaning up the environment.</description></item>
            /// <item><description><b>FAILED</b>: Failed.</description></item>
            /// <item><description><b>KILLING</b>: Aborting the task. Cleaning up the environment.</description></item>
            /// <item><description><b>KILLED</b>: The task aborted.</description></item>
            /// <item><description><b>SUCCEEDING</b>: The task execution ended. Cleaning up the environment.</description></item>
            /// <item><description><b>COMPLETED</b>: The task execution ended.</description></item>
            /// <item><description><b>FATAL</b>: Unexpected failure.</description></item>
            /// <item><description><b>UNKNOWN</b>: Unknown error.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>Message</b>: The alert information. If no alert is generated, an empty value is returned.</description></item>
            /// <item><description><b>Data</b>: The Spark application template data.</description></item>
            /// <item><description><b>EstimateExecutionCpuTimeInSeconds</b>: The CPU time consumed to execute the Spark application, in milliseconds.</description></item>
            /// <item><description><b>LogRootPath</b>: The storage path of the log file.</description></item>
            /// <item><description><b>LastAttemptId</b>: The ID of the last retry.</description></item>
            /// <item><description><b>WebUiAddress</b>: The Web UI address.</description></item>
            /// <item><description><b>SubmittedTimeInMillis</b>: The time when the Spark application was submitted. The value is a UNIX timestamp in milliseconds.</description></item>
            /// <item><description><b>StartedTimeInMillis</b>: The time when the Spark application was created. The value is a UNIX timestamp in milliseconds.</description></item>
            /// <item><description><b>LastUpdatedTimeInMillis</b>: The time when the Spark application was last updated. The value is a UNIX timestamp in milliseconds.</description></item>
            /// <item><description><b>TerminatedTimeInMillis</b>: The time when the execution of the Spark application was stopped. The value is a UNIX timestamp in milliseconds.</description></item>
            /// <item><description><b>DBClusterId</b>: The ID of the cluster where the Spark application is executed.</description></item>
            /// <item><description><b>ResourceGroupName</b>: The name of the job resource group.</description></item>
            /// <item><description><b>DurationInMillis</b>: The execution duration of the Spark application, in milliseconds.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AttemptInfoList")]
            [Validation(Required=false)]
            public List<SparkAttemptInfo> AttemptInfoList { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
