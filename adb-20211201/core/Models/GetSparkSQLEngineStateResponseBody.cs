// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkSQLEngineStateResponseBody : TeaModel {
        /// <summary>
        /// <para>The state information about the Spark SQL engine.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkSQLEngineStateResponseBodyData Data { get; set; }
        public class GetSparkSQLEngineStateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Spark application.</para>
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
            /// <para>The third-party JAR package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test.jar</para>
            /// </summary>
            [NameInMap("Jars")]
            [Validation(Required=false)]
            public string Jars { get; set; }

            /// <summary>
            /// <para>The maximum number of started Spark executors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxExecutor")]
            [Validation(Required=false)]
            public string MaxExecutor { get; set; }

            /// <summary>
            /// <para>The minimum number of started Spark executors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinExecutor")]
            [Validation(Required=false)]
            public string MinExecutor { get; set; }

            /// <summary>
            /// <para>The slot number of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SlotNum")]
            [Validation(Required=false)]
            public string SlotNum { get; set; }

            /// <summary>
            /// <para>The execution state of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUBMITTED</description></item>
            /// <item><description>STARTING</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>FAILING</description></item>
            /// <item><description>FAILED</description></item>
            /// <item><description>KILLING</description></item>
            /// <item><description>KILLED</description></item>
            /// <item><description>SUCCEEDING</description></item>
            /// <item><description>COMPLETED</description></item>
            /// <item><description>FATAL</description></item>
            /// <item><description>UNKNOWN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The timestamp when the Spark SQL application was submitted. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1651213645000</para>
            /// </summary>
            [NameInMap("SubmittedTimeInMillis")]
            [Validation(Required=false)]
            public string SubmittedTimeInMillis { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
