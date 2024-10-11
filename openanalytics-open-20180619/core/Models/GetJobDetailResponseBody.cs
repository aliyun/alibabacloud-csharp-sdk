// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class GetJobDetailResponseBody : TeaModel {
        [NameInMap("JobDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodyJobDetail JobDetail { get; set; }
        public class GetJobDetailResponseBodyJobDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-10-27 16:23:16</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1603786996000</para>
            /// </summary>
            [NameInMap("CreateTimeValue")]
            [Validation(Required=false)]
            public string CreateTimeValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;args\&quot;:[\&quot;100\&quot;],\&quot;name\&quot;:\&quot;SparkPi\&quot;,\&quot;className\&quot;:\&quot;org.apache.spark.examples.SparkPi\&quot;,\&quot;conf\&quot;:{\&quot;spark.driver.resourceSpec\&quot;:\&quot;medium\&quot;,\&quot;spark.executor.instances\&quot;:5,\&quot;spark.executor.resourceSpec\&quot;:\&quot;medium\&quot;},\&quot;file\&quot;:\&quot;local:///tmp/spark-examples.jar\&quot;}</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>small</para>
            /// </summary>
            [NameInMap("DriverResourceSpec")]
            [Validation(Required=false)]
            public string DriverResourceSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecutorInstances")]
            [Validation(Required=false)]
            public string ExecutorInstances { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>small</para>
            /// </summary>
            [NameInMap("ExecutorResourceSpec")]
            [Validation(Required=false)]
            public string ExecutorResourceSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>j202010271622hangzhouf742a4330000923</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SparkPi</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202105251618hzslot9906b0b40000005-0001</para>
            /// </summary>
            [NameInMap("LastJobAttemptId")]
            [Validation(Required=false)]
            public string LastJobAttemptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dlaui-cn-hangzhou.aliyuncs.com/?token=xxx">https://dlaui-cn-hangzhou.aliyuncs.com/?token=xxx</a></para>
            /// </summary>
            [NameInMap("SparkUI")]
            [Validation(Required=false)]
            public string SparkUI { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-10-27 16:23:16</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1603786996000</para>
            /// </summary>
            [NameInMap("SubmitTimeValue")]
            [Validation(Required=false)]
            public string SubmitTimeValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-10-27 16:23:16</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1603786996000</para>
            /// </summary>
            [NameInMap("UpdateTimeValue")]
            [Validation(Required=false)]
            public string UpdateTimeValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MyCluster</para>
            /// </summary>
            [NameInMap("VcName")]
            [Validation(Required=false)]
            public string VcName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5F10AB6E-8984-4E32-B821-4E1512711B8C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
