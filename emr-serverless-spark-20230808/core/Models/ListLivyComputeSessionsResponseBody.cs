// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListLivyComputeSessionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8FAA8EEC-3026-5D15-8733-4E2A3DD970A1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sessions")]
        [Validation(Required=false)]
        public List<ListLivyComputeSessionsResponseBodySessions> Sessions { get; set; }
        public class ListLivyComputeSessionsResponseBodySessions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>lc-xxxxxx</para>
            /// </summary>
            [NameInMap("computeId")]
            [Validation(Required=false)]
            public string ComputeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1768213240000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>322.5</para>
            /// </summary>
            [NameInMap("cuHours")]
            [Validation(Required=false)]
            public double? CuHours { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1768213240000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("info")]
            [Validation(Required=false)]
            public string Info { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1098888</para>
            /// </summary>
            [NameInMap("mbSeconds")]
            [Validation(Required=false)]
            public long? MbSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_session</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>root_queue</para>
            /// </summary>
            [NameInMap("queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>livy-xxxxxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>343</para>
            /// </summary>
            [NameInMap("vcoreSeconds")]
            [Validation(Required=false)]
            public long? VcoreSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://emr-spark-ui-cn-hangzhou.data.aliyun.com">http://emr-spark-ui-cn-hangzhou.data.aliyun.com</a></para>
            /// </summary>
            [NameInMap("webUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
