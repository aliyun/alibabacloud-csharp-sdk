// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListKyuubiServicesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListKyuubiServicesResponseBodyData Data { get; set; }
        public class ListKyuubiServicesResponseBodyData : TeaModel {
            [NameInMap("kyuubiServices")]
            [Validation(Required=false)]
            public List<ListKyuubiServicesResponseBodyDataKyuubiServices> KyuubiServices { get; set; }
            public class ListKyuubiServicesResponseBodyDataKyuubiServices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4C16G</para>
                /// </summary>
                [NameInMap("computeInstance")]
                [Validation(Required=false)]
                public string ComputeInstance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-11T08:21:58Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>103*******</para>
                /// </summary>
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>kyuubi-cn-hangzhou-internal.spark.emr.aliyuncs.com</para>
                /// </summary>
                [NameInMap("innerEndpoint")]
                [Validation(Required=false)]
                public string InnerEndpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>kyuubi.conf.key=value1
                /// kyuubi.conf.key1=value2</para>
                /// </summary>
                [NameInMap("kyuubiConfigs")]
                [Validation(Required=false)]
                public string KyuubiConfigs { get; set; }

                [NameInMap("kyuubiReleaseVersion")]
                [Validation(Required=false)]
                public string KyuubiReleaseVersion { get; set; }

                /// <summary>
                /// <para>KyuubiServer ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>kb-070104e7631242448d12a1377c309f30</para>
                /// </summary>
                [NameInMap("kyuubiServiceId")]
                [Validation(Required=false)]
                public string KyuubiServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>emr-spark-kyuubi-gateway-cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("publicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dev_queue</para>
                /// </summary>
                [NameInMap("queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>esr-4.2.0 (Spark 3.5.2, Scala 2.12)</para>
                /// </summary>
                [NameInMap("releaseVersion")]
                [Validation(Required=false)]
                public string ReleaseVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("replica")]
                [Validation(Required=false)]
                public int? Replica { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>spark.conf.key=value1
                /// spark.conf.key1=value2</para>
                /// </summary>
                [NameInMap("sparkConfigs")]
                [Validation(Required=false)]
                public string SparkConfigs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-23 09:22:00</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
