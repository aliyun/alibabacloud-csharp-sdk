// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListSparkAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSparkAppsResponseBodyData Data { get; set; }
        public class ListSparkAppsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application information list. Returned parameter descriptions:</para>
            /// <list type="bullet">
            /// <item><description><b>Data</b>: The Spark application template data.</description></item>
            /// <item><description><b>EstimateExecutionCpuTimeInSeconds</b>: The CPU time consumed to execute the Spark application, in milliseconds.</description></item>
            /// <item><description><b>LogRootPath</b>: The storage path of log files.</description></item>
            /// <item><description><b>LastAttemptId</b>: The retry ID.</description></item>
            /// <item><description><b>WebUiAddress</b>: The Web UI address.</description></item>
            /// <item><description><b>SubmittedTimeInMillis</b>: The time when the Spark application was committed. The value is a UNIX timestamp in milliseconds.</description></item>
            /// <item><description><b>StartedTimeInMillis</b>: The time when the Spark application was created. The value is a UNIX timestamp in milliseconds.</description></item>
            /// <item><description><b>LastUpdatedTimeInMillis</b>: The time when the Spark application was last updated. The value is a UNIX timestamp in milliseconds.</description></item>
            /// <item><description><b>TerminatedTimeInMillis</b>: The time when the execution of the Spark application was stopped. The value is a UNIX timestamp in milliseconds.</description></item>
            /// <item><description><b>DBClusterId</b>: The ID of the cluster where the Spark application is executed.</description></item>
            /// <item><description><b>ResourceGroupName</b>: The name of the job resource group.</description></item>
            /// <item><description><b>DurationInMillis</b>: The execution duration of the Spark application, in milliseconds.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AppInfoList")]
            [Validation(Required=false)]
            public List<SparkAppInfo> AppInfoList { get; set; }

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
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
