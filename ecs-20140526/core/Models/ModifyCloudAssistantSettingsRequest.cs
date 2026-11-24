// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCloudAssistantSettingsRequest : TeaModel {
        /// <summary>
        /// <para>The Cloud Assistant Agent upgrade configuration.</para>
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestAgentUpgradeConfig AgentUpgradeConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestAgentUpgradeConfig : TeaModel {
            /// <summary>
            /// <para>The list of time windows allowed for upgrades, accurate to the minute. The default time zone is UTC. The interval between time windows cannot be less than 1 hour. Format: start time (HH:mm)-end time (HH:mm). For example, [&quot;02:00-03:00&quot;, &quot;05:00-06:00&quot;] indicates that upgrades are allowed every day from 02:00 to 03:00 and from 05:00 to 06:00 in the UTC time zone.</para>
            /// </summary>
            [NameInMap("AllowedUpgradeWindow")]
            [Validation(Required=false)]
            public List<string> AllowedUpgradeWindow { get; set; }

            /// <summary>
            /// <para>Specifies whether to check the version and perform updates immediately when the Cloud Assistant Agent starts. Default value: true. This parameter takes effect only when the Cloud Assistant Agent version is not earlier than the following versions:</para>
            /// <list type="bullet">
            /// <item><description><para>Windows: 2.1.4.1065</para>
            /// </description></item>
            /// <item><description><para>Linux: 2.2.4.1065</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BootstrapUpgrade")]
            [Validation(Required=false)]
            public bool? BootstrapUpgrade { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable the Cloud Assistant Agent from checking and performing updates. Default value: false. Precautions:</para>
            /// <ol>
            /// <item><description>Fully evaluate the security risks and business impacts caused by disabling upgrades or continuing to run an earlier version of the Agent. You are responsible for the resulting risks and impacts.</description></item>
            /// <item><description>The disable upgrade configuration takes effect at the account level. It applies to all ECS instances under the account and does not support individual exemptions by instance. Therefore, the aforementioned risks cover all instances within the account.</description></item>
            /// <item><description>This parameter takes effect only when the Cloud Assistant Agent version is not earlier than the following versions:<list type="bullet">
            /// <item><description>Windows: 2.1.4.1065</description></item>
            /// <item><description>Linux: 2.2.4.1065</description></item>
            /// </list>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableUpgrade")]
            [Validation(Required=false)]
            public bool? DisableUpgrade { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the custom Agent upgrade configuration. If set to false, the system attempts to upgrade the Agent every 30 minutes by default. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time zone for the allowed upgrade time windows. The default time zone is UTC. The time zone supports the following two formats:</para>
            /// <list type="bullet">
            /// <item><description>Full time zone name: such as Asia/Shanghai (China/Shanghai time) and America/Los_Angeles (US/Los Angeles time).</description></item>
            /// <item><description>Time zone offset from Greenwich Mean Time (GMT): such as GMT+8:00 (UTC+8) and GMT-7:00 (UTC-7). Leading zeros are not supported for the hour value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <para>The OSS delivery configuration.</para>
        /// </summary>
        [NameInMap("OssDeliveryConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestOssDeliveryConfig OssDeliveryConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestOssDeliveryConfig : TeaModel {
            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-bucket</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable delivery to OSS. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The OSS encryption algorithm. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AES256</description></item>
            /// <item><description>SM4</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AES256</para>
            /// </summary>
            [NameInMap("EncryptionAlgorithm")]
            [Validation(Required=false)]
            public string EncryptionAlgorithm { get; set; }

            /// <summary>
            /// <para>The ID of the customer master key (CMK) when the encryption method is KMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a807****7a70e</para>
            /// </summary>
            [NameInMap("EncryptionKeyId")]
            [Validation(Required=false)]
            public string EncryptionKeyId { get; set; }

            /// <summary>
            /// <para>The OSS encryption method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Inherit: inherit from the bucket</description></item>
            /// <item><description>OssManaged: fully managed by OSS</description></item>
            /// <item><description>KMS: KMS encryption</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Inherit</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// <para>The directory prefix of the OSS bucket. Constraints:</para>
            /// <list type="bullet">
            /// <item><description>The length cannot exceed 254 characters.</description></item>
            /// <item><description>It cannot start with a forward slash (/) or a backslash (\).</description></item>
            /// </list>
            /// <para>Note: Pass an empty string (&quot;&quot;) if no directory prefix is required. If a directory prefix was previously set and is no longer needed, pass an empty string (&quot;&quot;) to clear it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sessionmanager/audit</para>
            /// </summary>
            [NameInMap("Prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The Cloud Assistant resource usage configuration. This parameter takes effect only when the Cloud Assistant Agent version is not earlier than the following versions:</para>
        /// <list type="bullet">
        /// <item><description><para>Windows: 2.1.4.1065</para>
        /// </description></item>
        /// <item><description><para>Linux: 2.2.4.1065</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceUsageConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestResourceUsageConfig ResourceUsageConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestResourceUsageConfig : TeaModel {
            /// <summary>
            /// <para>The maximum allowed CPU usage limit for the main process of the Cloud Assistant Agent.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit: percentage.</para>
            /// </description></item>
            /// <item><description><para>Valid values: 10 to 95.</para>
            /// </description></item>
            /// <item><description><para>Default value: 20.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain the script file in the Cloud Assistant directory after the command execution is completed. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("KeepScriptFile")]
            [Validation(Required=false)]
            public bool? KeepScriptFile { get; set; }

            /// <summary>
            /// <para>The maximum number of Cloud Assistant log files to retain.</para>
            /// <list type="bullet">
            /// <item><description>Default value: 30.</description></item>
            /// <item><description>Minimum value: 7.</description></item>
            /// <item><description>Maximum value: 365.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LogFileCountLimit")]
            [Validation(Required=false)]
            public int? LogFileCountLimit { get; set; }

            /// <summary>
            /// <para>The size limit for a single Cloud Assistant log file. A unit (B, KB, or MB) must be specified.</para>
            /// <list type="bullet">
            /// <item><description>Default value: 100MB.</description></item>
            /// <item><description>Minimum value: 10MB.</description></item>
            /// <item><description>Maximum value: 1024MB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10MB</para>
            /// </summary>
            [NameInMap("LogSizeLimit")]
            [Validation(Required=false)]
            public string LogSizeLimit { get; set; }

            /// <summary>
            /// <para>The maximum allowed memory usage limit for the main process of the Cloud Assistant Agent. A unit (B, KB, or MB) must be specified.</para>
            /// <list type="bullet">
            /// <item><description>Default value: 50MB.</description></item>
            /// <item><description>Minimum value: 35MB.</description></item>
            /// <item><description>Maximum value: 1024MB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>50MB</para>
            /// </summary>
            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public string MemoryLimit { get; set; }

            /// <summary>
            /// <para>The maximum number of consecutive times that the usage of CPU or memory resources exceeds the limit. When this limit is reached, the Cloud Assistant Agent automatically stops.</para>
            /// <list type="bullet">
            /// <item><description>Default value: 3.</description></item>
            /// <item><description>Minimum value: 3.</description></item>
            /// </list>
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
        public ModifyCloudAssistantSettingsRequestSessionManagerConfig SessionManagerConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestSessionManagerConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the Cloud Assistant session feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled</description></item>
            /// <item><description>false: disabled</description></item>
            /// </list>
            /// <para>Precautions:</para>
            /// <list type="bullet">
            /// <item><description>Enabling or disabling the session feature takes effect in all regions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SessionManagerEnabled")]
            [Validation(Required=false)]
            public bool? SessionManagerEnabled { get; set; }

        }

        /// <summary>
        /// <para>The service configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SessionManagerDelivery: session operation record delivery</description></item>
        /// <item><description>InvocationDelivery: task execution record delivery</description></item>
        /// <item><description>AgentUpgradeConfig: Cloud Assistant Agent upgrade configuration</description></item>
        /// <item><description>SessionManagerConfig: Cloud Assistant SessionManager configuration</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SessionManagerDelivery</para>
        /// </summary>
        [NameInMap("SettingType")]
        [Validation(Required=false)]
        public string SettingType { get; set; }

        /// <summary>
        /// <para>The SLS delivery configuration.</para>
        /// </summary>
        [NameInMap("SlsDeliveryConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestSlsDeliveryConfig SlsDeliveryConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestSlsDeliveryConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable delivery to SLS. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The name of the SLS Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-logstore</para>
            /// </summary>
            [NameInMap("LogstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

            /// <summary>
            /// <para>The name of the SLS project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-project</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

    }

}
