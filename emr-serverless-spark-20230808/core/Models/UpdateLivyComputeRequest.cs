// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateLivyComputeRequest : TeaModel {
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
        /// <para>The auto-start configuration.</para>
        /// </summary>
        [NameInMap("autoStartConfiguration")]
        [Validation(Required=false)]
        public UpdateLivyComputeRequestAutoStartConfiguration AutoStartConfiguration { get; set; }
        public class UpdateLivyComputeRequestAutoStartConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically start the gateway after creation.</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
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
        /// <para>The auto-stop configuration.</para>
        /// </summary>
        [NameInMap("autoStopConfiguration")]
        [Validation(Required=false)]
        public UpdateLivyComputeRequestAutoStopConfiguration AutoStopConfiguration { get; set; }
        public class UpdateLivyComputeRequestAutoStopConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow automatic stopping.</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The number of idle minutes after which the Livy gateway is automatically stopped.</para>
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
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>4</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpuLimit")]
        [Validation(Required=false)]
        public string CpuLimit { get; set; }

        /// <summary>
        /// <para>The Spark DPI engine database engine version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-4.3.0 (Spark 3.5.2, Scala 2.12)</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <para>The status of the public endpoint switch.</para>
        /// </summary>
        [NameInMap("enablePublic")]
        [Validation(Required=false)]
        public bool? EnablePublic { get; set; }

        /// <summary>
        /// <para>The runtime environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ev-cq146allhtgkulp5smk0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Fusion engine acceleration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <para>The Livy gateway configuration in JSON format. The following files are supported:</para>
        /// <list type="bullet">
        /// <item><description>sparkDefaultsConf</description></item>
        /// <item><description>sparkBlackListConf</description></item>
        /// <item><description>livyConf</description></item>
        /// <item><description>livyClientConf</description></item>
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
        /// <list type="bullet">
        /// <item><description>4Gi</description></item>
        /// <item><description>8Gi</description></item>
        /// <item><description>16Gi</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4Gi</para>
        /// </summary>
        [NameInMap("memoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network connectivity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("networkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// <para>The queue name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root_queue</para>
        /// </summary>
        [NameInMap("queueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The Spark DPI engine database engine version number. Use displayReleaseVersion instead.</para>
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
