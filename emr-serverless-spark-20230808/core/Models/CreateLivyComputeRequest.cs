// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateLivyComputeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Token</para>
        /// </summary>
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("autoStartConfiguration")]
        [Validation(Required=false)]
        public CreateLivyComputeRequestAutoStartConfiguration AutoStartConfiguration { get; set; }
        public class CreateLivyComputeRequestAutoStartConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        [NameInMap("autoStopConfiguration")]
        [Validation(Required=false)]
        public CreateLivyComputeRequestAutoStopConfiguration AutoStopConfiguration { get; set; }
        public class CreateLivyComputeRequestAutoStopConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("idleTimeoutMinutes")]
            [Validation(Required=false)]
            public long? IdleTimeoutMinutes { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpuLimit")]
        [Validation(Required=false)]
        public string CpuLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esr-4.3.0 (Spark 3.5.2, Scala 2.12)</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enablePublic")]
        [Validation(Required=false)]
        public bool? EnablePublic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ev-ctfq0fem1hkhgv4hapng</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;sparkDefaultsConf&quot;: &quot;spark.driver.cores     1\nspark.driver.memory    4g\nspark.executor.cores   1\nspark.executor.memory  4g\n&quot;,
        ///   &quot;sparkBlackListConf&quot;: &quot;spark.driver.cores\nspark.driver.memory&quot;,
        ///   &quot;livyConf&quot;: &quot;livy.server.session.timeout  1h\n&quot;,
        ///   &quot;livyClientConf&quot;: &quot;livy.rsc.sql.num-rows  1000\n&quot;
        /// }</para>
        /// </summary>
        [NameInMap("livyServerConf")]
        [Validation(Required=false)]
        public string LivyServerConf { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.8.0</para>
        /// </summary>
        [NameInMap("livyVersion")]
        [Validation(Required=false)]
        public string LivyVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4Gi</para>
        /// </summary>
        [NameInMap("memoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testGateway</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("networkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>root_queue</para>
        /// </summary>
        [NameInMap("queueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esr-4.3.0 (Spark 3.5.2, Scala 2.12, Java Runtime)</para>
        /// </summary>
        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
