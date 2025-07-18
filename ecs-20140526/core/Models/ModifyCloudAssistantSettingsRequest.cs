// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCloudAssistantSettingsRequest : TeaModel {
        /// <summary>
        /// <para>The configurations for upgrading Cloud Assistant Agent.</para>
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestAgentUpgradeConfig AgentUpgradeConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestAgentUpgradeConfig : TeaModel {
            /// <summary>
            /// <para>The time windows during which Cloud Assistant Agent can be upgraded. The time windows can be accurate to minutes. The Coordinated Universal Time (UTC) time zone is used by default.</para>
            /// <para>Make sure that the upgrade windows specified by this parameter are not shorter than 1 hour.</para>
            /// <para>Specify each upgrade window in the following format: \<Start time in the HH:mm format>-\<End time in the HH:mm format>.</para>
            /// <para>For example, [ &quot;02:00-03:00&quot;, &quot;05:00-06:00&quot; ] specifies that Cloud Assistant Agent can be upgraded from 2:00:00 to 3:00:00 and from 5:00:00 to 6:00:00 every day in the UTC time zone.</para>
            /// </summary>
            [NameInMap("AllowedUpgradeWindow")]
            [Validation(Required=false)]
            public List<string> AllowedUpgradeWindow { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable custom upgrade for Cloud Assistant Agent. If you set this parameter to false, an upgrade attempt is performed for Cloud Assistant Agent every 30 minutes.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time zone of the time windows. Default value: UTC. You can specify a time zone in the following forms:</para>
            /// <list type="bullet">
            /// <item><description>The time zone name. Examples: Asia/Shanghai and America/Los_Angeles.</description></item>
            /// <item><description>The time offset from GMT. Examples: GMT+8:00 (UTC+8) and GMT-7:00 (UTC-7). You cannot add leading zeros to the hour value.</description></item>
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
        /// <para>The configurations for delivering records to Object Storage Service (OSS).</para>
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
            /// <para>Specifies whether to deliver records to OSS. Default value: false.</para>
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
            /// <para>The ID of the customer master key (CMK) when EncryptionType is set to KMS.</para>
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
            /// <item><description>Inherit: the encryption method used by the specified bucket.</description></item>
            /// <item><description>OssManaged: server-side encryption by using OSS-managed keys (SSE-OSS).</description></item>
            /// <item><description>KMS: server-side encryption by using Key Management Service managed keys (SSE-KMS).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Inherit</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// <para>The prefix of the OSS bucket directory. The prefix must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description>The prefix can be up to 254 characters in length.</description></item>
            /// <item><description>The prefix cannot start with a forward slash (/) or a backslash (\\).</description></item>
            /// </list>
            /// <para>Note: If you do not need a directory prefix, specify a pair of double quotation marks (&quot;&quot;) for this parameter to clear the directory prefix that you specified.</para>
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

        [NameInMap("SessionManagerConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestSessionManagerConfig SessionManagerConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestSessionManagerConfig : TeaModel {
            [NameInMap("SessionManagerEnabled")]
            [Validation(Required=false)]
            public bool? SessionManagerEnabled { get; set; }

        }

        /// <summary>
        /// <para>The Cloud Assistant feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SessionManagerDelivery: the Session Record Delivery configurations.</description></item>
        /// <item><description>InvocationDelivery: the Operation Content and Result Delivery configurations.</description></item>
        /// <item><description>AgentUpgradeConfig: the Cloud Assistant Agent Upgrade configurations.</description></item>
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
        /// <para>The configurations for delivering records to Simple Log Service.</para>
        /// </summary>
        [NameInMap("SlsDeliveryConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestSlsDeliveryConfig SlsDeliveryConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestSlsDeliveryConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to deliver records to Simple Log Service. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The name of the Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-logstore</para>
            /// </summary>
            [NameInMap("LogstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project.</para>
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
