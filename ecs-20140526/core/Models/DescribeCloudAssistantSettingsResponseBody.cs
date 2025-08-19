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
            /// <summary>
            /// <para>The time windows during which Cloud Assistant Agent can be upgraded.</para>
            /// </summary>
            [NameInMap("AllowedUpgradeWindows")]
            [Validation(Required=false)]
            public DescribeCloudAssistantSettingsResponseBodyAgentUpgradeConfigAllowedUpgradeWindows AllowedUpgradeWindows { get; set; }
            public class DescribeCloudAssistantSettingsResponseBodyAgentUpgradeConfigAllowedUpgradeWindows : TeaModel {
                [NameInMap("AllowedUpgradeWindow")]
                [Validation(Required=false)]
                public List<string> AllowedUpgradeWindow { get; set; }

            }

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

        /// <summary>
        /// <para>The configurations for delivering items to Object Storage Service (OSS).</para>
        /// </summary>
        [NameInMap("OssDeliveryConfigs")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodyOssDeliveryConfigs OssDeliveryConfigs { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodyOssDeliveryConfigs : TeaModel {
            [NameInMap("OssDeliveryConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudAssistantSettingsResponseBodyOssDeliveryConfigsOssDeliveryConfig> OssDeliveryConfig { get; set; }
            public class DescribeCloudAssistantSettingsResponseBodyOssDeliveryConfigsOssDeliveryConfig : TeaModel {
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
                /// <para>The type of items to be delivered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SessionManager: session records.</description></item>
                /// <item><description>Invocation: task execution records.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SessionManager</para>
                /// </summary>
                [NameInMap("DeliveryType")]
                [Validation(Required=false)]
                public string DeliveryType { get; set; }

                /// <summary>
                /// <para>Indicates whether to deliver the specified items to OSS.</para>
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
                /// <item><description>KMS: server-side encryption with Key Management Service (SSE-KMS).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Inherit</para>
                /// </summary>
                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public string EncryptionType { get; set; }

                /// <summary>
                /// <para>The prefix of the OSS bucket directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sessionmanager/audit</para>
                /// </summary>
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

        /// <summary>
        /// <para>The configurations for delivering items to Simple Log Service.</para>
        /// </summary>
        [NameInMap("SlsDeliveryConfigs")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodySlsDeliveryConfigs SlsDeliveryConfigs { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodySlsDeliveryConfigs : TeaModel {
            [NameInMap("SlsDeliveryConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudAssistantSettingsResponseBodySlsDeliveryConfigsSlsDeliveryConfig> SlsDeliveryConfig { get; set; }
            public class DescribeCloudAssistantSettingsResponseBodySlsDeliveryConfigsSlsDeliveryConfig : TeaModel {
                /// <summary>
                /// <para>The type of items to be delivered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SessionManager: session records.</description></item>
                /// <item><description>Invocation: task execution records.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SessionManager</para>
                /// </summary>
                [NameInMap("DeliveryType")]
                [Validation(Required=false)]
                public string DeliveryType { get; set; }

                /// <summary>
                /// <para>Indicates whether to deliver the specified items to Simple Log Service.</para>
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

}
