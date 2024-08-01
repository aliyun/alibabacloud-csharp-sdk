// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCloudAssistantSettingsResponseBody : TeaModel {
        /// <summary>
        /// The configurations for upgrading Cloud Assistant Agent.
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public DescribeCloudAssistantSettingsResponseBodyAgentUpgradeConfig AgentUpgradeConfig { get; set; }
        public class DescribeCloudAssistantSettingsResponseBodyAgentUpgradeConfig : TeaModel {
            /// <summary>
            /// The time windows during which Cloud Assistant Agent can be upgraded.
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
            /// Indicates whether custom upgrade is enabled for Cloud Assistant Agent. If the value is false or empty, an upgrade attempt is performed for Cloud Assistant Agent every 30 minutes.
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The time zone of the time windows.
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// The configurations for delivering items to Object Storage Service (OSS).
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
                /// The name of the OSS bucket.
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// The type of items to be delivered. Valid values:
                /// 
                /// *   SessionManager: session records.
                /// *   Invocation: task execution records.
                /// </summary>
                [NameInMap("DeliveryType")]
                [Validation(Required=false)]
                public string DeliveryType { get; set; }

                /// <summary>
                /// Indicates whether to deliver the specified items to OSS.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The OSS encryption algorithm. Valid values:
                /// 
                /// *   AES256
                /// *   SM4
                /// </summary>
                [NameInMap("EncryptionAlgorithm")]
                [Validation(Required=false)]
                public string EncryptionAlgorithm { get; set; }

                /// <summary>
                /// The ID of the customer master key (CMK) when EncryptionType is set to KMS.
                /// </summary>
                [NameInMap("EncryptionKeyId")]
                [Validation(Required=false)]
                public string EncryptionKeyId { get; set; }

                /// <summary>
                /// The OSS encryption method. Valid values:
                /// 
                /// *   Inherit: the encryption method used by the specified bucket.
                /// *   OssManaged: server-side encryption by using OSS-managed keys (SSE-OSS).
                /// *   KMS: server-side encryption with Key Management Service (SSE-KMS).
                /// </summary>
                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public string EncryptionType { get; set; }

                /// <summary>
                /// The prefix of the OSS bucket directory.
                /// </summary>
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations for delivering items to Simple Log Service.
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
                /// The type of items to be delivered. Valid values:
                /// 
                /// *   SessionManager: session records.
                /// *   Invocation: task execution records.
                /// </summary>
                [NameInMap("DeliveryType")]
                [Validation(Required=false)]
                public string DeliveryType { get; set; }

                /// <summary>
                /// Indicates whether to deliver the specified items to Simple Log Service.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The name of the Logstore.
                /// </summary>
                [NameInMap("LogstoreName")]
                [Validation(Required=false)]
                public string LogstoreName { get; set; }

                /// <summary>
                /// The name of the Simple Log Service project.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

        }

    }

}
