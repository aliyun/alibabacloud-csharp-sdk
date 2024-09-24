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
            /// <para>The information about the attempts. Fields in the response parameter:</para>
            /// <list type="bullet">
            /// <item><description><para><b>AttemptId</b>: the attempt ID.</para>
            /// </description></item>
            /// <item><description><para><b>State</b>: the state of the Spark application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUBMITTED</b></description></item>
            /// <item><description><b>STARTING</b></description></item>
            /// <item><description><b>RUNNING</b></description></item>
            /// <item><description><b>FAILING</b></description></item>
            /// <item><description><b>FAILED</b></description></item>
            /// <item><description><b>KILLING</b></description></item>
            /// <item><description><b>KILLED</b></description></item>
            /// <item><description><b>SUCCEEDING</b></description></item>
            /// <item><description><b>COMPLETED</b></description></item>
            /// <item><description><b>FATAL</b></description></item>
            /// <item><description><b>UNKNOWN</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Message</b>: the alert message that is returned. If no alert is generated, null is returned.</para>
            /// </description></item>
            /// <item><description><para><b>Data</b>: the data of the Spark application template.</para>
            /// </description></item>
            /// <item><description><para><b>EstimateExecutionCpuTimeInSeconds</b>: the amount of time it takes to consume CPU resources for running the Spark application. Unit: milliseconds.</para>
            /// </description></item>
            /// <item><description><para><b>LogRootPath</b>: the storage path of log files.</para>
            /// </description></item>
            /// <item><description><para><b>LastAttemptId</b>: the ID of the last attempt.</para>
            /// </description></item>
            /// <item><description><para><b>WebUiAddress</b>: the web UI address.</para>
            /// </description></item>
            /// <item><description><para><b>SubmittedTimeInMillis</b>: the time when the Spark application was submitted. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// </description></item>
            /// <item><description><para><b>StartedTimeInMillis</b>: the time when the Spark application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// </description></item>
            /// <item><description><para><b>LastUpdatedTimeInMillis</b>: the time when the Spark application was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// </description></item>
            /// <item><description><para><b>TerminatedTimeInMillis</b>: the time when the Spark application task was terminated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// </description></item>
            /// <item><description><para><b>DBClusterId</b>: the ID of the cluster on which the Spark application runs.</para>
            /// </description></item>
            /// <item><description><para><b>ResourceGroupName</b>: the name of the job resource group.</para>
            /// </description></item>
            /// <item><description><para><b>DurationInMillis</b>: the amount of time it takes to run the Spark application. Unit: milliseconds.</para>
            /// </description></item>
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
            /// <para>The total number of entries returned.</para>
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
