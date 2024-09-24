// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListSparkAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSparkAppsResponseBodyData Data { get; set; }
        public class ListSparkAppsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Details of the applications. Fields in the response parameter:</para>
            /// <list type="bullet">
            /// <item><description><b>Data</b>: the data of the Spark application template.</description></item>
            /// <item><description><b>EstimateExecutionCpuTimeInSeconds</b>: the amount of time it takes to consume CPU resources for running the Spark application. Unit: milliseconds.</description></item>
            /// <item><description><b>LogRootPath</b>: the storage path of log files.</description></item>
            /// <item><description><b>LastAttemptId</b>: the most recent attempt ID.</description></item>
            /// <item><description><b>WebUiAddress</b>: the web UI URL.</description></item>
            /// <item><description><b>SubmittedTimeInMillis</b>: the time when the Spark application was submitted. The time is displayed in the UNIX timestamp format. Unit: milliseconds.</description></item>
            /// <item><description><b>StartedTimeInMillis</b>: the time when the Spark application was created. The time is displayed in the UNIX timestamp format. Unit: milliseconds.</description></item>
            /// <item><description><b>LastUpdatedTimeInMillis</b>: the time when the Spark application was last updated. The time is displayed in the UNIX timestamp format. Unit: milliseconds.</description></item>
            /// <item><description><b>TerminatedTimeInMillis</b>: the time when the Spark application task was terminated. The time is displayed in the UNIX timestamp format. Unit: milliseconds.</description></item>
            /// <item><description><b>DBClusterId</b>: the ID of the cluster on which the Spark application runs.</description></item>
            /// <item><description><b>ResourceGroupName</b>: the name of the job resource group.</description></item>
            /// <item><description><b>DurationInMillis</b>: the amount of time it takes to run the Spark application. Unit: milliseconds.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AppInfoList")]
            [Validation(Required=false)]
            public List<SparkAppInfo> AppInfoList { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
