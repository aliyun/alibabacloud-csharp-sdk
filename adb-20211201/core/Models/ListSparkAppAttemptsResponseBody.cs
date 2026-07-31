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
            /// <para>The list of retry information. Metric description:</para>
            /// <list type="bullet">
            /// <item><description><b>AttemptId</b>: the retry ID.</description></item>
            /// <item><description><b>State</b>: the execute status of the application. Valid values:<list type="bullet">
            /// <item><description><b>SUBMITTED</b>: commit.</description></item>
            /// <item><description><b>STARTING</b>: starting.</description></item>
            /// <item><description><b>RUNNING</b>: executing.</description></item>
            /// <item><description><b>FAILING</b>: the node failed and the environment is being cleaned up.</description></item>
            /// <item><description><b>FAILED</b>: failed.</description></item>
            /// <item><description><b>KILLING</b>: aborting the task and cleaning up the environment.</description></item>
            /// <item><description><b>KILLED</b>: the task is aborted.</description></item>
            /// <item><description><b>SUCCEEDING</b>: the node execution is complete and the environment is being cleaned up.</description></item>
            /// <item><description><b>COMPLETED</b>: the node execution is complete.</description></item>
            /// <item><description><b>FATAL</b>: unexpected failure.</description></item>
            /// <item><description><b>UNKNOWN</b>: unknown fault.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>Message</b>: the alerting message. This parameter is empty if no alerting is generated.</description></item>
            /// <item><description><b>Data</b>: the Spark application template data.</description></item>
            /// <item><description><b>EstimateExecutionCpuTimeInSeconds</b>: the CPU time consumed to execute the Spark application, in milliseconds (ms).</description></item>
            /// <item><description><b>LogRootPath</b>: the storage path of log files.</description></item>
            /// <item><description><b>LastAttemptId</b>: the ID of the last retry.</description></item>
            /// <item><description><b>WebUiAddress</b>: the web UI address.</description></item>
            /// <item><description><b>SubmittedTimeInMillis</b>: the time when the Spark application was committed. This value is a UNIX timestamp in milliseconds (ms).</description></item>
            /// <item><description><b>StartedTimeInMillis</b>: the time when the Spark application was created. This value is a UNIX timestamp in milliseconds (ms).</description></item>
            /// <item><description><b>LastUpdatedTimeInMillis</b>: the time when the Spark application was last updated. This value is a UNIX timestamp in milliseconds (ms).</description></item>
            /// <item><description><b>TerminatedTimeInMillis</b>: the time when the Spark application stopped executing. This value is a UNIX timestamp in milliseconds (ms).</description></item>
            /// <item><description><b>DBClusterId</b>: the ID of the cluster that executes the Spark application.</description></item>
            /// <item><description><b>ResourceGroupName</b>: the name of the Job-type resource group.</description></item>
            /// <item><description><b>DurationInMillis</b>: the execution duration of the Spark application, in milliseconds (ms).</description></item>
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
