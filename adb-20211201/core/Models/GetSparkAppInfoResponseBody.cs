// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the Spark application. Response parameter description:</para>
        /// <list type="bullet">
        /// <item><description><b>Data</b>: the Spark application template data.</description></item>
        /// <item><description><b>EstimateExecutionCpuTimeInSeconds</b>: the CPU time consumed to execute the Spark application, in milliseconds.</description></item>
        /// <item><description><b>LogRootPath</b>: the storage path of the log file.</description></item>
        /// <item><description><b>LastAttemptId</b>: the retry ID.</description></item>
        /// <item><description><b>WebUiAddress</b>: the web UI address.</description></item>
        /// <item><description><b>SubmittedTimeInMillis</b>: the time when the Spark application was submitted. The value is a UNIX timestamp in milliseconds.</description></item>
        /// <item><description><b>StartedTimeInMillis</b>: the time when the Spark application was created. The value is a UNIX timestamp in milliseconds.</description></item>
        /// <item><description><b>LastUpdatedTimeInMillis</b>: the time when the Spark application was last updated. The value is a UNIX timestamp in milliseconds.</description></item>
        /// <item><description><b>TerminatedTimeInMillis</b>: the time when the execution of the Spark application was terminated. The value is a UNIX timestamp in milliseconds.</description></item>
        /// <item><description><b>DBClusterId</b>: the ID of the cluster where the Spark application is executed.</description></item>
        /// <item><description><b>ResourceGroupName</b>: the name of the job resource group.</description></item>
        /// <item><description><b>DurationInMillis</b>: the execution duration of the Spark application, in milliseconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;name&quot;: &quot;SparkPi&quot;,     &quot;file&quot;: &quot;local:///tmp/spark-examples.jar&quot;,     &quot;className&quot;: &quot;org.apache.spark.examples.SparkPi&quot;,     &quot;args&quot;: [         &quot;1000000&quot;     ],     &quot;conf&quot;: {         &quot;spark.driver.resourceSpec&quot;: &quot;small&quot;,         &quot;spark.executor.instances&quot;: 1,         &quot;spark.executor.resourceSpec&quot;: &quot;small&quot;     } }&quot;,
        ///       &quot;EstimateExecutionCpuTimeInSeconds&quot; : 100,
        ///       &quot;LogRootPath&quot; : &quot;oss://test/logs/driver&quot;,
        ///       &quot;LastAttemptId&quot; : &quot;s202204291426hzpre60cfabb0000004-0003&quot;,
        ///       &quot;WebUiAddress&quot; : &quot;<a href="https://sparkui.aliyuncs.com/token=xxx">https://sparkui.aliyuncs.com/token=xxx</a>&quot;,
        ///       &quot;SubmittedTimeInMillis&quot; : 1651213645000,
        ///       &quot;StartedTimeInMillis&quot; : 1651213645010,
        ///       &quot;LastUpdatedTimeInMillis&quot; : 1651213645200,
        ///       &quot;TerminatedTimeInMillis&quot; : 1651213645300,
        ///       &quot;DBClusterId&quot; : &quot;am-dbclusterid&quot;,
        ///       &quot;ResourceGroupName&quot; : &quot;spark-rg&quot;,
        ///       &quot;DurationInMillis&quot; : 100
        ///     }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SparkAppInfo Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
