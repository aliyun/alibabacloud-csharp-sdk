// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopsRequest : TeaModel {
        /// <summary>
        /// The number of cloud computers that you want to create. Valid values: 1 to 300. Default value: 1.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal. This parameter takes effect only when the ChargeType parameter is set to PrePaid.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The ID of the cloud computer template.
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// The cloud computer templates.
        /// </summary>
        [NameInMap("BundleModels")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestBundleModels> BundleModels { get; set; }
        public class CreateDesktopsRequestBundleModels : TeaModel {
            /// <summary>
            /// The number of cloud computers that you want to create. Valid values: 1 to 300. Default value: null.
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// The ID of a cloud computer template.
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// The name of the cloud computer. The name must meet the following requirements:
            /// 
            /// *   The name must be 1 to 64 characters in length.
            /// *   The name must start with a letter but cannot start with `http://` or `https://`.
            /// *   The name can only contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The IDs of the end users to whom the cloud computer are assigned.
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// The custom hostnames of the cloud computers. This parameter is valid only if the office network is an AD office network and the operating system type of the cloud computers is Windows.
            /// 
            /// The hostnames must meet the following requirements:
            /// 
            /// *   The hostnames must be 2 to 15 characters in length.
            /// *   The hostnames can contain only letters, digits, and hyphens (-). The hostnames cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.
            /// 
            /// When you create multiple cloud computers, you can use the `name_prefix[begin_number,bits]name_suffix` naming format to name the cloud computers. For example, if you set the value of the Hostname parameter to ecd-[1,4]-test, the hostname of the first cloud computer is ecd-0001-test, the hostname of the second cloud computer is ecd-0002-test, and so on.
            /// 
            /// *   `name_prefix`: the prefix of the hostname.
            /// *   `[begin_number,bits]`: the sequential number in the hostname. The `begin_number` value is the starting digit. Valid values of begin_number: 0 to 999999. Default value: 0. The `bits` value is the number of digits. Valid values: 1 to 6. Default value: 6.
            /// *   `name_suffix`: the suffix of the hostname.
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// Specifies whether to enable disk encryption.
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// The ID of the Key Management Service (KMS) key that is used when disk encryption is enabled. You can call the [ListKeys](https://help.aliyun.com/document_detail/28951.html) operation to query the list of KMS keys.
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// The billing method of the cloud computers.
        /// 
        /// Default value: PostPaid. Valid values:
        /// 
        /// *   Postpaid: pay-as-you-go
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   PrePaid: subscription
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The private IP address of the cloud computer.
        /// </summary>
        [NameInMap("DesktopMemberIp")]
        [Validation(Required=false)]
        public string DesktopMemberIp { get; set; }

        /// <summary>
        /// The name of the cloud computer. The name must meet the following requirements:
        /// 
        /// *   The name must be 1 to 64 characters in length.
        /// *   The name must start with a letter but cannot start with `http://` or `https://`.
        /// *   The name can only contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// Specifies whether to automatically add suffixes to the names of cloud computers when you create multiple cloud computers at the same time.
        /// 
        /// Default value: true. Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   False
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("DesktopNameSuffix")]
        [Validation(Required=false)]
        public bool? DesktopNameSuffix { get; set; }

        /// <summary>
        /// The details of the scheduled task on cloud computers.
        /// </summary>
        [NameInMap("DesktopTimers")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestDesktopTimers> DesktopTimers { get; set; }
        public class CreateDesktopsRequestDesktopTimers : TeaModel {
            /// <summary>
            /// Specifies whether to allow the end user to configure the scheduled task.
            /// </summary>
            [NameInMap("AllowClientSetting")]
            [Validation(Required=false)]
            public bool? AllowClientSetting { get; set; }

            /// <summary>
            /// The cron expression for the scheduled task.
            /// 
            /// >  The time must be in UTC. For example, for 24:00 (UTC+8), you must set the value to 0 0 16 ? \\* 1,2,3,4,5,6,7
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// Specifies whether to forcibly execute the scheduled task.
            /// 
            /// Valid values:
            /// 
            /// *   true: forcibly executes the scheduled task regardless of the status and connection of the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   false: does not forcibly execute the scheduled task.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Enforce")]
            [Validation(Required=false)]
            public bool? Enforce { get; set; }

            /// <summary>
            /// The interval at which cloud computers are created. Unit: minutes.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// The operations that scheduled tasks support. This parameter is valid only when TimerType is set to NoConnect.
            /// 
            /// Valid values:
            /// 
            /// *   Hibernate: hibernates the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Shutdown: stops the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// The reset type of the cloud computers.
            /// 
            /// Valid values:
            /// 
            /// *   RESET_TYPE_SYSTEM: resets the system disks.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   RESET_TYPE_BOTH: resets the system disks and data disks.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public string ResetType { get; set; }

            /// <summary>
            /// The type of the scheduled task.
            /// </summary>
            [NameInMap("TimerType")]
            [Validation(Required=false)]
            public string TimerType { get; set; }

        }

        /// <summary>
        /// >  This parameter is not publicly available.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The IDs of the end users to which you want to assign the cloud computers. You can specify 1 to 100 IDs.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// The ID of the cloud computer pool.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The custom hostnames of the cloud computers. This parameter is valid only if the office network is an AD office network and the operating system type of the cloud computers is Windows.
        /// 
        /// The hostnames must meet the following requirements:
        /// 
        /// *   The hostnames must be 2 to 15 characters in length.
        /// *   The hostnames can contain only letters, digits, and hyphens (-). The hostnames cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.
        /// 
        /// When you create multiple cloud computers, you can use the `name_prefix[begin_number,bits]name_suffix` naming format to name the cloud computers. For example, if you set the value of the Hostname parameter to ecd-[1,4]-test, the hostname of the first cloud computer is ecd-0001-test, the hostname of the second cloud computer is ecd-0002-test, and so on.
        /// 
        /// *   `name_prefix`: the prefix of the hostname.
        /// *   `[begin_number,bits]`: the sequential number in the hostname. The `begin_number` value is the starting digit. Valid values of begin_number: 0 to 999999. Default value: 0. The `bits` value is the number of digits. Valid values: 1 to 6. Default value: 6.
        /// *   `name_suffix`: the suffix of the hostname.
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// > This parameter is not publicly available.
        /// </summary>
        [NameInMap("MonthDesktopSetting")]
        [Validation(Required=false)]
        public CreateDesktopsRequestMonthDesktopSetting MonthDesktopSetting { get; set; }
        public class CreateDesktopsRequestMonthDesktopSetting : TeaModel {
            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public long? BuyerId { get; set; }

            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("UseDuration")]
            [Validation(Required=false)]
            public int? UseDuration { get; set; }

        }

        /// <summary>
        /// The office network ID.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The subscription duration of the cloud desktop that you want to create. The unit is specified by the `PeriodUnit` parameter. This parameter takes effect and is required only when the `ChargeType` parameter is set to `PrePaid`.
        /// 
        /// *   Valid values if the `PeriodUnit` parameter is set to `Month`:
        /// 
        ///     *   1
        ///     *   2
        ///     *   3
        ///     *   6
        /// 
        /// *   Valid values if the `PeriodUnit` parameter is set to `Year`:
        /// 
        ///     *   1
        ///     *   2
        ///     *   3
        ///     *   4
        ///     *   5
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// The ID of the sales promotion.
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SnapshotPolicyId")]
        [Validation(Required=false)]
        public string SnapshotPolicyId { get; set; }

        /// <summary>
        /// The tags that you want to add to the cloud desktop.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestTag> Tag { get; set; }
        public class CreateDesktopsRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. You can specify 1 to 20 keys for a tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. You can specify 1 to 20 values for a tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// How the cloud computers are assigned.
        /// 
        /// >  If you do not specify the `EndUserId` parameter, the cloud computers are not assigned to end users after the cloud computers are created.
        /// 
        /// Default value: ALL. Valid values:
        /// 
        /// *   ALL: If you specify the EndUserId parameter, the cloud computers are assigned to all specified end users after the cloud computers are created.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   PER_USER: If you specify the EndUserId parameter, the cloud computers are evenly assigned to the specified end users after the cloud computers are created.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     In this case, you must make sure that the value of the Amount parameter can be divided by the N value of the EndUserId.N parameter that you specify.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("UserAssignMode")]
        [Validation(Required=false)]
        public string UserAssignMode { get; set; }

        /// <summary>
        /// Details about the custom command scripts.
        /// </summary>
        [NameInMap("UserCommands")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestUserCommands> UserCommands { get; set; }
        public class CreateDesktopsRequestUserCommands : TeaModel {
            /// <summary>
            /// The command content.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The encoding mode of the command content.
            /// 
            /// Valid values:
            /// 
            /// *   Base64: encodes the command content in Base64.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   PlainText: does not encode the command content.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ContentEncoding")]
            [Validation(Required=false)]
            public string ContentEncoding { get; set; }

            /// <summary>
            /// The language type of the command.
            /// 
            /// Valid values:
            /// 
            /// *   RunPowerShellScript: PowerShell commands (applicable to Windows cloud computers).
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   RunShellScript: shell commands (applicable to Linux cloud computers).
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   RunBatScript: batch commands (applicable to Windows cloud computers).
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

        }

        /// <summary>
        /// >  This parameter is not publicly available.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Specifies whether to enable disk encryption.
        /// </summary>
        [NameInMap("VolumeEncryptionEnabled")]
        [Validation(Required=false)]
        public bool? VolumeEncryptionEnabled { get; set; }

        /// <summary>
        /// The ID of the Key Management Service (KMS) key that you want to use when disk encryption is enabled. You can call the [ListKeys](https://help.aliyun.com/document_detail/28951.html) operation to obtain a list of KMS keys.
        /// </summary>
        [NameInMap("VolumeEncryptionKey")]
        [Validation(Required=false)]
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// >  This parameter is not publicly available.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
