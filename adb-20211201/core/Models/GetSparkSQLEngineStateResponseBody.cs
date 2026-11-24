// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkSQLEngineStateResponseBody : TeaModel {
        /// <summary>
        /// <para>The status details of the Spark SQL engine.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkSQLEngineStateResponseBodyData Data { get; set; }
        public class GetSparkSQLEngineStateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202207151211hz0c****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The configuration of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key1&quot;: &quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The third-party JAR packages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test.jar</para>
            /// </summary>
            [NameInMap("Jars")]
            [Validation(Required=false)]
            public string Jars { get; set; }

            /// <summary>
            /// <para>The maximum number of Spark executors to start.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxExecutor")]
            [Validation(Required=false)]
            public string MaxExecutor { get; set; }

            /// <summary>
            /// <para>The minimum number of Spark executors to start.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinExecutor")]
            [Validation(Required=false)]
            public string MinExecutor { get; set; }

            /// <summary>
            /// <para>The slot value of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SlotNum")]
            [Validation(Required=false)]
            public string SlotNum { get; set; }

            /// <summary>
            /// <para>The execution status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUBMITTED: Submitted.</description></item>
            /// <item><description>STARTING: Starting.</description></item>
            /// <item><description>RUNNING: Running.</description></item>
            /// <item><description>FAILING: The task failed and the environment is being cleaned up.</description></item>
            /// <item><description>FAILED: Failed.</description></item>
            /// <item><description>KILLING: The task is being terminated and the environment is being cleaned up.</description></item>
            /// <item><description>KILLED: Terminated.</description></item>
            /// <item><description>SUCCEEDING: The task execution is complete and the environment is being cleaned up.</description></item>
            /// <item><description>COMPLETED: Completed.</description></item>
            /// <item><description>FATAL: Unexpected failure.</description></item>
            /// <item><description>UNKNOWN: Unknown error.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The submission time of the Spark SQL application. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1651213645000</para>
            /// </summary>
            [NameInMap("SubmittedTimeInMillis")]
            [Validation(Required=false)]
            public string SubmittedTimeInMillis { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
