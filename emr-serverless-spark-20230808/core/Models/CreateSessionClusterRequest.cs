// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSessionClusterRequest : TeaModel {
        /// <summary>
        /// <para>The Spark configurations.</para>
        /// </summary>
        [NameInMap("applicationConfigs")]
        [Validation(Required=false)]
        public List<CreateSessionClusterRequestApplicationConfigs> ApplicationConfigs { get; set; }
        public class CreateSessionClusterRequestApplicationConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark-defaults.conf</para>
            /// </summary>
            [NameInMap("configFileName")]
            [Validation(Required=false)]
            public string ConfigFileName { get; set; }

            /// <summary>
            /// <para>The key of SparkConf.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark.app.name</para>
            /// </summary>
            [NameInMap("configItemKey")]
            [Validation(Required=false)]
            public string ConfigItemKey { get; set; }

            /// <summary>
            /// <para>The value of SparkConf.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("configItemValue")]
            [Validation(Required=false)]
            public string ConfigItemValue { get; set; }

        }

        /// <summary>
        /// <para>The automatic startup configuration.</para>
        /// </summary>
        [NameInMap("autoStartConfiguration")]
        [Validation(Required=false)]
        public CreateSessionClusterRequestAutoStartConfiguration AutoStartConfiguration { get; set; }
        public class CreateSessionClusterRequestAutoStartConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic startup.</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
        /// <para>The automatic termination configuration.</para>
        /// </summary>
        [NameInMap("autoStopConfiguration")]
        [Validation(Required=false)]
        public CreateSessionClusterRequestAutoStopConfiguration AutoStopConfiguration { get; set; }
        public class CreateSessionClusterRequestAutoStopConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic termination.</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The idle timeout period. The session is automatically terminated when the idle timeout period is exceeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("idleTimeoutMinutes")]
            [Validation(Required=false)]
            public int? IdleTimeoutMinutes { get; set; }

        }

        /// <summary>
        /// <para>The version of the Spark engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-3.3.1</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <para>The ID of the Python environment. This parameter takes effect only for notebook sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cpv569tlhtgndjl86t40</para>
        /// </summary>
        [NameInMap("envId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Fusion engine for acceleration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <para>The session type.</para>
        /// <list type="bullet">
        /// <item><description>SQL</description></item>
        /// <item><description>NOTEBOOK</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark_job_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("publicEndpointEnabled")]
        [Validation(Required=false)]
        public bool? PublicEndpointEnabled { get; set; }

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
        /// <para>The version number of Spark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-3.3.1</para>
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
