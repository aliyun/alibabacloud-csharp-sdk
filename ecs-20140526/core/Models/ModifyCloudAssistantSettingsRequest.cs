// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCloudAssistantSettingsRequest : TeaModel {
        /// <summary>
        /// 云助手Agent升级配置。
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public ModifyCloudAssistantSettingsRequestAgentUpgradeConfig AgentUpgradeConfig { get; set; }
        public class ModifyCloudAssistantSettingsRequestAgentUpgradeConfig : TeaModel {
            /// <summary>
            /// 允许升级的时间段列表，可精确到分，默认为 UTC 时区。
            /// 
            /// 各时间段的间隔不能小于1小时。
            /// 
            /// 格式：开始时间(HH:mm)-结束时间(HH:mm)。
            /// 
            /// 如[
            /// "02:00-03:00",
            /// "05:00-06:00"
            /// ]
            /// 代表在 UTC 时区的每天2点-3点、5点-6点允许升级。
            /// </summary>
            [NameInMap("AllowedUpgradeWindow")]
            [Validation(Required=false)]
            public List<string> AllowedUpgradeWindow { get; set; }

            /// <summary>
            /// 是否开启自定义Agent升级配置。如设置为false，默认保持每30分钟尝试升级一次。
            /// 
            /// 默认值：false。
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// 允许升级时间段的时区。默认为 UTC 时区。
            /// 时区支持以下两种形式：
            /// - 时区全称： 如Asia/Shanghai（中国/上海时间）、America/Los_Angeles（美国/洛杉矶时间）等。
            /// - 时区相对于格林威治时间的偏移量： 如GMT+8:00（东八区）、GMT-7:00（西七区）等。小时位不支持添加前导零。
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
