// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateLivyComputeRequest : TeaModel {
        /// <summary>
        /// <para>The authentication method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Token</para>
        /// </summary>
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The automatic startup configuration.</para>
        /// </summary>
        [NameInMap("autoStartConfiguration")]
        [Validation(Required=false)]
        public CreateLivyComputeRequestAutoStartConfiguration AutoStartConfiguration { get; set; }
        public class CreateLivyComputeRequestAutoStartConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically start the Livy Gateway after it is created.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The automatic stop configuration.</para>
        /// </summary>
        [NameInMap("autoStopConfiguration")]
        [Validation(Required=false)]
        public CreateLivyComputeRequestAutoStopConfiguration AutoStopConfiguration { get; set; }
        public class CreateLivyComputeRequestAutoStopConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically stop the Livy Gateway.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The number of minutes after which the Livy Gateway is automatically stopped if it is idle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("idleTimeoutMinutes")]
            [Validation(Required=false)]
            public long? IdleTimeoutMinutes { get; set; }

        }

        /// <summary>
        /// <para>The number of CPU cores for the Livy server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpuLimit")]
        [Validation(Required=false)]
        public string CpuLimit { get; set; }

        /// <summary>
        /// <para>The version number of the Spark engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-4.3.0 (Spark 3.5.2, Scala 2.12)</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the public endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enablePublic")]
        [Validation(Required=false)]
        public bool? EnablePublic { get; set; }

        /// <summary>
        /// <para>The ID of the runtime environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ev-ctfq0fem1hkhgv4hapng</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable acceleration with the Fusion engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <para>The configuration of the Livy Gateway. This parameter is in JSON format and supports the following files:</para>
        /// <list type="bullet">
        /// <item><description><para>sparkDefaultsConf</para>
        /// </description></item>
        /// <item><description><para>sparkBlackListConf</para>
        /// </description></item>
        /// <item><description><para>livyConf</para>
        /// </description></item>
        /// <item><description><para>livyClientConf</para>
        /// </description></item>
        /// </list>
        /// 
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
        /// <para>The Livy version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8.0</para>
        /// </summary>
        [NameInMap("livyVersion")]
        [Validation(Required=false)]
        public string LivyVersion { get; set; }

        /// <summary>
        /// <para>The memory size of the Livy server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4Gi</para>
        /// </summary>
        [NameInMap("memoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        /// <summary>
        /// <para>The name of the Livy Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testGateway</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the network connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("networkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// <para>The name of the submission queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root_queue</para>
        /// </summary>
        [NameInMap("queueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The version number of the Spark engine. This parameter is deprecated. Use displayReleaseVersion instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-4.3.0 (Spark 3.5.2, Scala 2.12, Java Runtime)</para>
        /// </summary>
        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
