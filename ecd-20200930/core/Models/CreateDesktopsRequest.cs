// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopsRequest : TeaModel {
        /// <summary>
        /// The number of cloud desktops that you want to create. Valid values: 1 to 300. Default value: 1.
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
        /// Specifies whether to enable auto-renewal. This parameter takes effect only when the ChargeType parameter is set to PrePaid.````
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The ID of the desktop template.
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// The desktop templates that you want to use.
        /// </summary>
        [NameInMap("BundleModels")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestBundleModels> BundleModels { get; set; }
        public class CreateDesktopsRequestBundleModels : TeaModel {
            /// <summary>
            /// The number of cloud desktops that you want to create. Valid values: 1 to 300. Default value: 0.
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// The ID of the desktop template.
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// The name of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The users to whom you want to assign the cloud desktops.
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// The hostname that you specify for the cloud desktop. You can only specify the hostname of a Windows cloud desktop in the workspace of the enterprise AD account type.
            /// 
            /// The hostname must meet the following requirements:
            /// 
            /// *   It must be 2 to 15 characters in length.
            /// *   It can contain letters, digits, and hyphens (-). The hostname cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.
            /// 
            /// If you create multiple cloud desktops, you can use the`  name_prefix[begin_number,bits]name_suffix ` format to determine the hostnames of the cloud desktops. For example, if you set Hostname to ecd-\[1,4]-test, the hostname of the first cloud desktop is ecd-0001-test and the hostname of the second cloud desktop is ecd-0002-test. Other hostnames follow the same rule.
            /// 
            /// *   `name_prefix`: the prefix of the hostname.
            /// *   `[begin_number,bits]`: the ordered numbers in the hostname. begin_number: the start number. Valid values: 0 to 999999. Default value: 0. bits: the digit. Valid values: 1 to 6. Default value: 6.
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
            /// The ID of the Key Management Service (KMS) key that you want to use when disk encryption is enabled. You can call the [ListKeys](~~28951~~) operation to obtain a list of KMS keys.
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// The billing method of the cloud desktop.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("DesktopMemberIp")]
        [Validation(Required=false)]
        public string DesktopMemberIp { get; set; }

        /// <summary>
        /// The name of the cloud desktop. The name must meet the following requirements:
        /// 
        /// *   The name must be 1 to 64 characters in length.
        /// *   The name can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-). It must start with a letter but cannot start with http:// or https://.
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// Specifies whether to automatically add a suffix to the cloud desktop name when you create multiple cloud desktops at a time.
        /// </summary>
        [NameInMap("DesktopNameSuffix")]
        [Validation(Required=false)]
        public bool? DesktopNameSuffix { get; set; }

        [NameInMap("DesktopTimers")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestDesktopTimers> DesktopTimers { get; set; }
        public class CreateDesktopsRequestDesktopTimers : TeaModel {
            [NameInMap("AllowClientSetting")]
            [Validation(Required=false)]
            public bool? AllowClientSetting { get; set; }

            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            [NameInMap("Enforce")]
            [Validation(Required=false)]
            public bool? Enforce { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public string ResetType { get; set; }

            [NameInMap("TimerType")]
            [Validation(Required=false)]
            public string TimerType { get; set; }

        }

        /// <summary>
        /// This parameter is not available.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The IDs of the users that you want to authorize to use the cloud desktop. The cloud desktop is assigned to the users. You can specify IDs of 1 to 100 users.
        /// 
        /// *   Only one user can use the cloud desktop at a time.
        /// *   If you do not specify the `EndUserId` parameter, the cloud desktop that you create is not assigned to users.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// The ID of the desktop group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The hostname that you specify for the cloud desktop. You can specify only the hostname of a Windows cloud desktop in the workspace of the enterprise AD account type.
        /// 
        /// The hostname must meet the following requirements:
        /// 
        /// *   It must be 2 to 15 characters in length.
        /// *   It can contain letters, digits, and hyphens (-). The hostname cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.
        /// 
        /// If you create multiple cloud desktops, you can use the`  name_prefix[begin_number,bits]name_suffix ` format to determine the hostnames of the cloud desktops. For example, if you set Hostname to ecd-\[1,4]-test, the hostname of the first cloud desktop is ecd-0001-test and the hostname of the second cloud desktop is ecd-0002-test. Other hostnames follow the same rule.
        /// 
        /// *   `name_prefix`: the prefix of the hostname.
        /// *   `[begin_number,bits]`: the ordered numbers in the hostname. begin_number: the start number. Valid values: 0 to 999999. Default value: 0. bits: the digit. Valid values: 1 to 6. Default value: 6.
        /// *   `name_suffix`: the suffix of the hostname.
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// The ID of the workspace.
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
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// The assignment mode of the cloud desktop.
        /// 
        /// > If you do not specify the `EndUserId` parameter, the cloud desktop that you create is not assigned to users.
        /// </summary>
        [NameInMap("UserAssignMode")]
        [Validation(Required=false)]
        public string UserAssignMode { get; set; }

        /// <summary>
        /// The custom command scripts of the user.
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
            /// The encoding mode of the command content (CommandContent).
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
            /// The command language.
            /// 
            /// Valid values:
            /// 
            /// *   RunPowerShellScript: PowerShell command (applicable to Windows cloud desktops).
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   RunShellScript: shell command (applicable to Linux cloud desktops).
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   RunBatScript: batch command (applicable to Windows cloud desktops).
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
        /// This parameter is not available.
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
        /// The ID of the Key Management Service (KMS) key that you want to use when disk encryption is enabled. You can call the [ListKeys](~~28951~~) operation to obtain a list of KMS keys.
        /// </summary>
        [NameInMap("VolumeEncryptionKey")]
        [Validation(Required=false)]
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// This parameter is not available.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
