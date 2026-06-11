// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListLivyComputeSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FAA8EEC-3026-5D15-8733-4E2A3DD970A1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of sessions.</para>
        /// </summary>
        [NameInMap("sessions")]
        [Validation(Required=false)]
        public List<ListLivyComputeSessionsResponseBodySessions> Sessions { get; set; }
        public class ListLivyComputeSessionsResponseBodySessions : TeaModel {
            /// <summary>
            /// <para>The ID of the Livy Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lc-xxxxxx</para>
            /// </summary>
            [NameInMap("computeId")]
            [Validation(Required=false)]
            public string ComputeId { get; set; }

            /// <summary>
            /// <para>The time when the session was created. This is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1768213240000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The number of compute units (CUs) consumed during the task execution. This is an estimated value. The actual value is subject to the bill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>322.5</para>
            /// </summary>
            [NameInMap("cuHours")]
            [Validation(Required=false)]
            public double? CuHours { get; set; }

            /// <summary>
            /// <para>The time when the session ended. This is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1768213240000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The runtime information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("info")]
            [Validation(Required=false)]
            public string Info { get; set; }

            /// <summary>
            /// <para>The total amount of memory in MB allocated to the task multiplied by the number of seconds the task has been running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1098888</para>
            /// </summary>
            [NameInMap("mbSeconds")]
            [Validation(Required=false)]
            public long? MbSeconds { get; set; }

            /// <summary>
            /// <para>The session name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_session</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root_queue</para>
            /// </summary>
            [NameInMap("queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <para>The ID of the Livy Gateway session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>livy-xxxxxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The Spark job configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;proxyUser&quot;: &quot;test&quot;,
            ///     &quot;conf&quot;: {
            ///         &quot;spark.driver.cores&quot;: 1
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("sparkConf")]
            [Validation(Required=false)]
            public string SparkConf { get; set; }

            /// <summary>
            /// <para>The session state.</para>
            /// <list type="bullet">
            /// <item><description><para>starting: The session is starting.</para>
            /// </description></item>
            /// <item><description><para>running: The session is running.</para>
            /// </description></item>
            /// <item><description><para>terminating: The session is being terminated.</para>
            /// </description></item>
            /// <item><description><para>terminated: The session is terminated.</para>
            /// </description></item>
            /// <item><description><para>error: The session failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The total number of vCores allocated to the task multiplied by the number of seconds the task has been running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>343</para>
            /// </summary>
            [NameInMap("vcoreSeconds")]
            [Validation(Required=false)]
            public long? VcoreSeconds { get; set; }

            /// <summary>
            /// <para>The web UI URL of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://emr-spark-ui-cn-hangzhou.data.aliyun.com">http://emr-spark-ui-cn-hangzhou.data.aliyun.com</a></para>
            /// </summary>
            [NameInMap("webUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
