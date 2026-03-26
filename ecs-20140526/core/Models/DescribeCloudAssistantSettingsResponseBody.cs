// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCloudAssistantSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations for upgrading Cloud Assistant Agent.</para>
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

            [NameInMap("BootstrapUpgrade")]
            [Validation(Required=false)]
            public bool? BootstrapUpgrade { get; set; }

            [NameInMap("DisableUpgrade")]
            [Validation(Required=false)]
            public bool? DisableUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether custom upgrade is enabled for Cloud Assistant Agent. If the value is false or empty, an upgrade attempt is performed for Cloud Assistant Agent every 30 minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time zone of the time windows.</para>
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

        [NameInMap("ResourceUsageConfig")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodyResourceUsageConfig ResourceUsageConfig { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodyResourceUsageConfig : TeaModel {
            [NameInMap("CpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            [NameInMap("KeepScriptFile")]
            [Validation(Required=false)]
            public bool? KeepScriptFile { get; set; }

            [NameInMap("LogFileCountLimit")]
            [Validation(Required=false)]
            public int? LogFileCountLimit { get; set; }

            [NameInMap("LogSizeLimit")]
            [Validation(Required=false)]
            public string LogSizeLimit { get; set; }

            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public string MemoryLimit { get; set; }

            [NameInMap("OverloadLimit")]
            [Validation(Required=false)]
            public int? OverloadLimit { get; set; }

        }

        /// <summary>
        /// <para>Cloud Assistant Session Manager configuration.</para>
        /// </summary>
        [NameInMap("SessionManagerConfig")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodySessionManagerConfig SessionManagerConfig { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodySessionManagerConfig : TeaModel {
            /// <summary>
            /// <para>Specify whether to enable Cloud Assistant Session Manager. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables the feature.</description></item>
            /// <item><description>false: Disables the feature.</description></item>
            /// </list>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>The feature applies to all regions.</description></item>
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
