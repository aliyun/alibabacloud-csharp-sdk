// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCloudAssistantSettingsRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of upgrading the Cloud Assistant agent.</para>
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestAgentUpgradeConfig AgentUpgradeConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestAgentUpgradeConfig : TeaModel {
            /// <summary>
            /// <para>A list of time windows during which the agent is allowed to be upgraded. The time windows are accurate to minutes and are in UTC by default.</para>
            /// <para>The interval between two consecutive time windows must be at least 1 hour.</para>
            /// <para>Format: StartTime(HH:mm)-EndTime(HH:mm).</para>
            /// <para>For example, [
            /// &quot;02:00-03:00&quot;,
            /// &quot;05:00-06:00&quot;
            /// ]
            /// indicates that the agent can be upgraded from 2:00 to 3:00 and from 5:00 to 6:00 every day in UTC.</para>
            /// </summary>
            [NameInMap("AllowedUpgradeWindow")]
            [Validation(Required=false)]
            public List<string> AllowedUpgradeWindow { get; set; }

            /// <summary>
            /// <para>Specifies whether to immediately check the version and perform an update when the Cloud Assistant agent is started. Default value: true.</para>
            /// <para>This setting takes effect only when the version of the Cloud Assistant agent is not earlier than the following versions:</para>
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
            /// <para>Specifies whether to disallow the Cloud Assistant agent to check for or perform updates. Default value: false.</para>
            /// <para>This setting takes effect only when the version of the Cloud Assistant agent is not earlier than the following versions:</para>
            /// <list type="bullet">
            /// <item><description><para>Windows: 2.1.4.1065</para>
            /// </description></item>
            /// <item><description><para>Linux: 2.2.4.1065</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableUpgrade")]
            [Validation(Required=false)]
            public bool? DisableUpgrade { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable custom upgrade configurations for the agent. If you set this parameter to false, the agent attempts to upgrade every 30 minutes by default.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time zone of the time windows for agent upgrade. Default value: UTC.
            /// The following formats are supported for the time zone:</para>
            /// <list type="bullet">
            /// <item><description><para>Time zone name: for example, Asia/Shanghai (China/Shanghai time) and America/Los_Angeles (US/Los Angeles time).</para>
            /// </description></item>
            /// <item><description><para>Offset from Greenwich Mean Time (GMT): for example, GMT+8:00 (UTC+8) and GMT-7:00 (UTC-7). The hour part cannot have a leading zero.</para>
            /// </description></item>
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
        /// <para>The configurations of delivering records to OSS.</para>
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
            /// <para>Specifies whether to enable the feature of delivering records to OSS. Default value: false.</para>
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
            /// <item><description><para>AES256</para>
            /// </description></item>
            /// <item><description><para>SM4</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AES256</para>
            /// </summary>
            [NameInMap("EncryptionAlgorithm")]
            [Validation(Required=false)]
            public string EncryptionAlgorithm { get; set; }

            /// <summary>
            /// <para>The ID of the customer master key (CMK) when KMS encryption is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a807****7a70e</para>
            /// </summary>
            [NameInMap("EncryptionKeyId")]
            [Validation(Required=false)]
            public string EncryptionKeyId { get; set; }

            /// <summary>
            /// <para>The OSS encryption mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Inherit: inherits the bucket encryption.</para>
            /// </description></item>
            /// <item><description><para>OssManaged: uses OSS-managed server-side encryption.</para>
            /// </description></item>
            /// <item><description><para>KMS: uses KMS encryption.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Inherit</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// <para>The prefix of the directory in the OSS bucket. The following limits apply:</para>
            /// <list type="bullet">
            /// <item><description><para>The prefix can be up to 254 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The prefix cannot start with a forward slash (/) or a backslash ().</para>
            /// </description></item>
            /// </list>
            /// <para>Note: If you want to deliver records to the root directory of the bucket, enter &quot;&quot;. To clear the prefix that is previously set, enter &quot;&quot;.</para>
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
        /// <para>The ID of the region.</para>
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
        /// <para>The configurations of resource usage for Cloud Assistant. This setting takes effect only when the version of the Cloud Assistant agent is not earlier than the following versions:</para>
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
            /// <para>The maximum CPU usage that is allowed for the main process of the Cloud Assistant agent.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit: %.</para>
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
            /// <para>Specifies whether to retain the script file of a command in the Cloud Assistant directory after the command execution is complete.
            /// Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("KeepScriptFile")]
            [Validation(Required=false)]
            public bool? KeepScriptFile { get; set; }

            /// <summary>
            /// <para>The maximum number of Cloud Assistant log files that can be retained.</para>
            /// <list type="bullet">
            /// <item><description><para>Default value: 30.</para>
            /// </description></item>
            /// <item><description><para>Minimum value: 7.</para>
            /// </description></item>
            /// <item><description><para>Maximum value: 365.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LogFileCountLimit")]
            [Validation(Required=false)]
            public int? LogFileCountLimit { get; set; }

            /// <summary>
            /// <para>The maximum size of a single Cloud Assistant log file. You must specify a unit (B, KB, or MB).</para>
            /// <list type="bullet">
            /// <item><description><para>Default value: 100 MB.</para>
            /// </description></item>
            /// <item><description><para>Minimum value: 10 MB.</para>
            /// </description></item>
            /// <item><description><para>Maximum value: 1024 MB.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10MB</para>
            /// </summary>
            [NameInMap("LogSizeLimit")]
            [Validation(Required=false)]
            public string LogSizeLimit { get; set; }

            /// <summary>
            /// <para>The maximum memory usage that is allowed for the main process of the Cloud Assistant agent. You must specify a unit (B, KB, or MB).</para>
            /// <list type="bullet">
            /// <item><description><para>Default value: 50 MB.</para>
            /// </description></item>
            /// <item><description><para>Minimum value: 35 MB.</para>
            /// </description></item>
            /// <item><description><para>Maximum value: 1024 MB.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>50MB</para>
            /// </summary>
            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public string MemoryLimit { get; set; }

            /// <summary>
            /// <para>The maximum number of consecutive times that CPU or memory usage can exceed the specified limits. If the limits are consecutively exceeded for the specified number of times, the Cloud Assistant agent is automatically stopped.</para>
            /// <list type="bullet">
            /// <item><description><para>Default value: 3.</para>
            /// </description></item>
            /// <item><description><para>Minimum value: 3.</para>
            /// </description></item>
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
        /// <para>The configurations of the Session Manager feature.</para>
        /// </summary>
        [NameInMap("SessionManagerConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestSessionManagerConfig SessionManagerConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestSessionManagerConfig : TeaModel {
            /// <summary>
            /// <para>The switch for the Session Manager feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enables the feature.</para>
            /// </description></item>
            /// <item><description><para>false: disables the feature.</para>
            /// </description></item>
            /// </list>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>After you enable or disable the Session Manager feature, the setting takes effect for all regions.</description></item>
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
        /// <para>The type of the service configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SessionManagerDelivery</c>: the configurations of delivering session records.</para>
        /// </description></item>
        /// <item><description><para><c>InvocationDelivery</c>: the configurations of delivering command execution records.</para>
        /// </description></item>
        /// <item><description><para><c>AgentUpgradeConfig</c>: the configurations of upgrading the Cloud Assistant agent.</para>
        /// </description></item>
        /// <item><description><para><c>SessionManagerConfig</c>: the configurations of Cloud Assistant Session Manager.</para>
        /// </description></item>
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
        /// <para>The configurations of delivering records to SLS.</para>
        /// </summary>
        [NameInMap("SlsDeliveryConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestSlsDeliveryConfig SlsDeliveryConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestSlsDeliveryConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the feature of delivering records to SLS.
            /// Default value: false.</para>
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
