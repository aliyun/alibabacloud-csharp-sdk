// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSessionClusterRequest : TeaModel {
        /// <summary>
        /// <para>The Spark application configurations.</para>
        /// </summary>
        [NameInMap("applicationConfigs")]
        [Validation(Required=false)]
        public List<CreateSessionClusterRequestApplicationConfigs> ApplicationConfigs { get; set; }
        public class CreateSessionClusterRequestApplicationConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark-defaults.conf</para>
            /// </summary>
            [NameInMap("configFileName")]
            [Validation(Required=false)]
            public string ConfigFileName { get; set; }

            /// <summary>
            /// <para>The Spark Conf key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark.app.name</para>
            /// </summary>
            [NameInMap("configItemKey")]
            [Validation(Required=false)]
            public string ConfigItemKey { get; set; }

            /// <summary>
            /// <para>The Spark Conf value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("configItemValue")]
            [Validation(Required=false)]
            public string ConfigItemValue { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable automatic startup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("autoStartConfiguration")]
        [Validation(Required=false)]
        public CreateSessionClusterRequestAutoStartConfiguration AutoStartConfiguration { get; set; }
        public class CreateSessionClusterRequestAutoStartConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic startup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
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
        public CreateSessionClusterRequestAutoStopConfiguration AutoStopConfiguration { get; set; }
        public class CreateSessionClusterRequestAutoStopConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow automatic stop. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Allowed.</description></item>
            /// <item><description>false: Not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The number of idle minutes after which the session is automatically stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("idleTimeoutMinutes")]
            [Validation(Required=false)]
            public int? IdleTimeoutMinutes { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-token-asxkxxxxxxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The version displayed in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-3.3.1</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <para>The Python environment ID. This parameter takes effect only for Notebook sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cpv569tlhtgndjl86t40</para>
        /// </summary>
        [NameInMap("envId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

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
        /// <para>The session type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SQL: SQL session.</description></item>
        /// <item><description>NOTEBOOK: NOTEBOOK session.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The node name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark_job_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the public network access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
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
        /// <para>The Spark DPI engine version number.</para>
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
