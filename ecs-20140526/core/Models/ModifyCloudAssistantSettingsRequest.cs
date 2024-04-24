// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCloudAssistantSettingsRequest : TeaModel {
        /// <summary>
        /// The configurations for upgrading Cloud Assistant Agent.
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestAgentUpgradeConfig AgentUpgradeConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestAgentUpgradeConfig : TeaModel {
            /// <summary>
            /// The time windows during which Cloud Assistant Agent can be upgraded. The time windows can be accurate to minutes. The default time zone is UTC.
            /// 
            /// Make sure that the upgrade windows specified by using this parameter are not shorter than 1 hour.
            /// 
            /// Specify each upgrade window in the following format: \<Start time> (HH:mm)-\<End time> (HH:mm).
            /// 
            /// For example, \[ "02:00-03:00", "05:00-06:00" ] specifies that Cloud Assistant Agent can be upgraded from 2:00:00 to 3:00:00 and from 5:00:00 to 6:00:00 every day in the UTC time zone.
            /// </summary>
            [NameInMap("AllowedUpgradeWindow")]
            [Validation(Required=false)]
            public List<string> AllowedUpgradeWindow { get; set; }

            /// <summary>
            /// Specifies whether to enable custom upgrade for Cloud Assistant Agent. If you set this parameter to false, an upgrade attempt is performed for Cloud Assistant Agent every 30 minutes.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The time zone of the time window. Default value: UTC. The following formats are supported:
            /// 
            /// *   The time zone name. Examples: Asia/Shanghai and America/Los_Angeles.
            /// *   The time offset from GMT. Examples: GMT+8:00 (UTC+8) and GMT-7:00 (UTC-7). Do not add leading zeros to the hour value.
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// The configurations for delivering records to Object Storage Service (OSS).
        /// </summary>
        [NameInMap("OssDeliveryConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestOssDeliveryConfig OssDeliveryConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestOssDeliveryConfig : TeaModel {
            /// <summary>
            /// The name of the OSS bucket.
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// Specifies whether to deliver records to OSS. Default value: false.
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
            /// *   KMS: server-side encryption by using Key Management Service managed keys (SSE-KMS).
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// The prefix of the OSS bucket directory. The prefix must meet the following requirements:
            /// 
            /// *   The prefix can be up to 254 characters in length.
            /// *   The prefix cannot start with a forward slash (/) or a backslash (\\).
            /// 
            /// Note: If you do not need a directory prefix, specify a pair of double quotation marks ("") for this parameter to clear the directory prefix that you specified.
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
        /// The region ID.
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
        /// The Cloud Assistant feature. Valid values:
        /// 
        /// *   SessionManagerDelivery: the Session Record Delivery feature
        /// *   InvocationDelivery: the Operation Content and Result Delivery feature
        /// </summary>
        [NameInMap("SettingType")]
        [Validation(Required=false)]
        public string SettingType { get; set; }

        /// <summary>
        /// The configurations for delivering records to Simple Log Service.
        /// </summary>
        [NameInMap("SlsDeliveryConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestSlsDeliveryConfig SlsDeliveryConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestSlsDeliveryConfig : TeaModel {
            /// <summary>
            /// Specifies whether to deliver records to Simple Log Service. Default value: false.
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
