// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCloudAssistantSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The upgrade settings for the Cloud Assistant agent.</para>
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodyAgentUpgradeConfig AgentUpgradeConfig { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodyAgentUpgradeConfig : TeaModel {
            [NameInMap("AllowedUpgradeWindows")]
            [Validation(Required=false)]
            public DescribeCloudAssistantSettingsResponseBodyAgentUpgradeConfigAllowedUpgradeWindows AllowedUpgradeWindows { get; set; }
            public class DescribeCloudAssistantSettingsResponseBodyAgentUpgradeConfigAllowedUpgradeWindows : TeaModel {
                [NameInMap("AllowedUpgradeWindow")]
                [Validation(Required=false)]
                public List<string> AllowedUpgradeWindow { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the Cloud Assistant agent checks for and applies updates upon startup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BootstrapUpgrade")]
            [Validation(Required=false)]
            public bool? BootstrapUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether to prevent the Cloud Assistant agent from automatically updating.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisableUpgrade")]
            [Validation(Required=false)]
            public bool? DisableUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether custom agent upgrade settings are enabled. If this parameter is not specified or is set to <c>false</c>, the system attempts to upgrade the agent every 30 minutes by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time zone of the allowed upgrade windows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("OssDeliveryConfigs")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodyOssDeliveryConfigs OssDeliveryConfigs { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodyOssDeliveryConfigs : TeaModel {
            [NameInMap("OssDeliveryConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudAssistantSettingsResponseBodyOssDeliveryConfigsOssDeliveryConfig> OssDeliveryConfig { get; set; }
            public class DescribeCloudAssistantSettingsResponseBodyOssDeliveryConfigsOssDeliveryConfig : TeaModel {
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("DeliveryType")]
                [Validation(Required=false)]
                public string DeliveryType { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("EncryptionAlgorithm")]
                [Validation(Required=false)]
                public string EncryptionAlgorithm { get; set; }

                [NameInMap("EncryptionKeyId")]
                [Validation(Required=false)]
                public string EncryptionKeyId { get; set; }

                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public string EncryptionType { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource usage settings for the Cloud Assistant agent.</para>
        /// </summary>
        [NameInMap("ResourceUsageConfig")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodyResourceUsageConfig ResourceUsageConfig { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodyResourceUsageConfig : TeaModel {
            /// <summary>
            /// <para>The maximum CPU usage limit for the main process of the Cloud Assistant agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            /// <summary>
            /// <para>Indicates whether to retain the script file in the Cloud Assistant directory after a command invocation is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("KeepScriptFile")]
            [Validation(Required=false)]
            public bool? KeepScriptFile { get; set; }

            /// <summary>
            /// <para>The maximum number of Cloud Assistant log files to retain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LogFileCountLimit")]
            [Validation(Required=false)]
            public int? LogFileCountLimit { get; set; }

            /// <summary>
            /// <para>The maximum size for a single Cloud Assistant log file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100MB</para>
            /// </summary>
            [NameInMap("LogSizeLimit")]
            [Validation(Required=false)]
            public string LogSizeLimit { get; set; }

            /// <summary>
            /// <para>The maximum memory usage limit for the main process of the Cloud Assistant agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35MB</para>
            /// </summary>
            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public string MemoryLimit { get; set; }

            /// <summary>
            /// <para>The number of consecutive times CPU or memory usage can exceed the configured limits before the Cloud Assistant agent process is terminated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OverloadLimit")]
            [Validation(Required=false)]
            public int? OverloadLimit { get; set; }

        }

        /// <summary>
        /// <para>Configurations for the Session Manager feature.</para>
        /// </summary>
        [NameInMap("SessionManagerConfig")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodySessionManagerConfig SessionManagerConfig { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodySessionManagerConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Session Manager feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disabled</para>
            /// </description></item>
            /// </list>
            /// <para><b>Note</b>:</para>
            /// <list type="bullet">
            /// <item><description>This setting takes effect in all regions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SessionManagerEnabled")]
            [Validation(Required=false)]
            public bool? SessionManagerEnabled { get; set; }

        }

        [NameInMap("SlsDeliveryConfigs")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodySlsDeliveryConfigs SlsDeliveryConfigs { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodySlsDeliveryConfigs : TeaModel {
            [NameInMap("SlsDeliveryConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudAssistantSettingsResponseBodySlsDeliveryConfigsSlsDeliveryConfig> SlsDeliveryConfig { get; set; }
            public class DescribeCloudAssistantSettingsResponseBodySlsDeliveryConfigsSlsDeliveryConfig : TeaModel {
                [NameInMap("DeliveryType")]
                [Validation(Required=false)]
                public string DeliveryType { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("LogstoreName")]
                [Validation(Required=false)]
                public string LogstoreName { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

        }

    }

}
