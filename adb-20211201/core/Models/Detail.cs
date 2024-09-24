// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class Detail : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BATCH</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>amv-bp11q28kv****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;name&quot;: &quot;SparkPi&quot;,     &quot;file&quot;: &quot;local:///tmp/spark-examples.jar&quot;,     &quot;className&quot;: &quot;org.apache.spark.examples.SparkPi&quot;,     &quot;args&quot;: [         &quot;1000000&quot;     ],     &quot;conf&quot;: {         &quot;spark.driver.resourceSpec&quot;: &quot;small&quot;,         &quot;spark.executor.instances&quot;: 1,         &quot;spark.executor.resourceSpec&quot;: &quot;small&quot;     } }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DurationInMillis")]
        [Validation(Required=false)]
        public long? DurationInMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EstimateExecutionCpuTimeInSeconds")]
        [Validation(Required=false)]
        public long? EstimateExecutionCpuTimeInSeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s202204291426hzpre60cfa*****-0003</para>
        /// </summary>
        [NameInMap("LastAttemptId")]
        [Validation(Required=false)]
        public string LastAttemptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1651213645200</para>
        /// </summary>
        [NameInMap("LastUpdatedTimeInMillis")]
        [Validation(Required=false)]
        public long? LastUpdatedTimeInMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://<bucket-name>/logs/driver</para>
        /// </summary>
        [NameInMap("LogRootPath")]
        [Validation(Required=false)]
        public string LogRootPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>spark-rg</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1651213645010</para>
        /// </summary>
        [NameInMap("StartedTimeInMillis")]
        [Validation(Required=false)]
        public long? StartedTimeInMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1651213645000</para>
        /// </summary>
        [NameInMap("SubmittedTimeInMillis")]
        [Validation(Required=false)]
        public long? SubmittedTimeInMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1651213645300</para>
        /// </summary>
        [NameInMap("TerminatedTimeInMillis")]
        [Validation(Required=false)]
        public long? TerminatedTimeInMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://sparkui.aliyuncs.com/token=xxx">https://sparkui.aliyuncs.com/token=xxx</a></para>
        /// </summary>
        [NameInMap("WebUiAddress")]
        [Validation(Required=false)]
        public string WebUiAddress { get; set; }

    }

}
