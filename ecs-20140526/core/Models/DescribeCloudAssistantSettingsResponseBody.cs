// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCloudAssistantSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The Cloud Assistant Agent upgrade configuration.</para>
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
            /// <para>Indicates whether Cloud Assistant Agent checks for and performs updates immediately upon startup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BootstrapUpgrade")]
            [Validation(Required=false)]
            public bool? BootstrapUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether Cloud Assistant Agent is prohibited from checking for and performing updates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisableUpgrade")]
            [Validation(Required=false)]
            public bool? DisableUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether the custom Agent upgrade configuration is enabled. If the value is false or empty, the default behavior is to attempt an upgrade every 30 minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time zone of the allowed upgrade time windows.</para>
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
        /// <para>The Cloud Assistant resource usage configuration.</para>
        /// </summary>
        [NameInMap("ResourceUsageConfig")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodyResourceUsageConfig ResourceUsageConfig { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodyResourceUsageConfig : TeaModel {
            /// <summary>
            /// <para>The maximum CPU usage allowed for the Cloud Assistant Agent main process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            /// <summary>
            /// <para>Indicates whether the script file is retained in the Cloud Assistant directory after command execution is complete.</para>
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
            /// <para>The size limit of Cloud Assistant log files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100MB</para>
            /// </summary>
            [NameInMap("LogSizeLimit")]
            [Validation(Required=false)]
            public string LogSizeLimit { get; set; }

            /// <summary>
            /// <para>The maximum memory usage allowed for the Cloud Assistant Agent main process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35MB</para>
            /// </summary>
            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public string MemoryLimit { get; set; }

            /// <summary>
            /// <para>The maximum number of consecutive times that CPU or memory resources usage can exceed the limit. When this limit is reached, Cloud Assistant Agent automatically stops running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OverloadLimit")]
            [Validation(Required=false)]
            public int? OverloadLimit { get; set; }

        }

        /// <summary>
        /// <para>The Cloud Assistant session feature configuration.</para>
        /// </summary>
        [NameInMap("SessionManagerConfig")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodySessionManagerConfig SessionManagerConfig { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodySessionManagerConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether the Cloud Assistant session feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>Enabling or disabling the session feature takes effect across all regions.</description></item>
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
