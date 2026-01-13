// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetKyuubiServiceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetKyuubiServiceResponseBodyData Data { get; set; }
        public class GetKyuubiServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2c8g</para>
            /// </summary>
            [NameInMap("computeInstance")]
            [Validation(Required=false)]
            public string ComputeInstance { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1749456094000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>150978934701****</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kyuubi-cn-beijing-internal.spark.emr.aliyuncs.com</para>
            /// </summary>
            [NameInMap("innerEndpoint")]
            [Validation(Required=false)]
            public string InnerEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("kyuubiConfigs")]
            [Validation(Required=false)]
            public string KyuubiConfigs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.9.2-0.0.2</para>
            /// </summary>
            [NameInMap("kyuubiReleaseVersion")]
            [Validation(Required=false)]
            public string KyuubiReleaseVersion { get; set; }

            /// <summary>
            /// <para>Kyuubi Service ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-4e209b04588***95f04ad3538ae4</para>
            /// </summary>
            [NameInMap("kyuubiServiceId")]
            [Validation(Required=false)]
            public string KyuubiServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev_serverless_spark</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>emr-spark-kyuubi-gateway-cn-beijing.aliyuncs.com</para>
            /// </summary>
            [NameInMap("publicEndpoint")]
            [Validation(Required=false)]
            public string PublicEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("publicEndpointEnabled")]
            [Validation(Required=false)]
            public bool? PublicEndpointEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev_queue</para>
            /// </summary>
            [NameInMap("queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>esr-4.6.0 (Spark 3.5.2, Scala 2.12)</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("sparkConfigs")]
            [Validation(Required=false)]
            public string SparkConfigs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1749456094000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8CE06D75-E6A2-505D-9B4B-31DEE3D98A04</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
