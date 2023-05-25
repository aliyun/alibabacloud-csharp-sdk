// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReplaceSystemDiskRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public ReplaceSystemDiskRequestSystemDisk SystemDisk { get; set; }
        public class ReplaceSystemDiskRequestSystemDisk : TeaModel {
            /// <summary>
            /// The capacity of the new system disk. Unit: GiB. Valid values: Max{20, Size of the image specified by ImageId} to 500.
            /// 
            /// Default value: Max{40, Size of the image specified by ImageId}.
            /// 
            /// > If the capacity of the new system disk exceeds `Max{20, Capacity of the original system disk}`, you are charged for the excess capacity.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// The system architecture. Valid values:
        /// 
        /// *   i386
        /// *   x86\_64
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// This parameter is not available for public use.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<ReplaceSystemDiskRequestArn> Arn { get; set; }
        public class ReplaceSystemDiskRequestArn : TeaModel {
            /// <summary>
            /// > This parameter is unavailable.
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// > This parameter is not available for public use.
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// > This parameter is not available for public use.
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but make sure that the token is unique across requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The disk ID.
        /// 
        /// If the `ImageId` parameter is not specified, this parameter is required.
        /// 
        /// If the DiskId parameter is specified, the `Platform` and `Architecture` parameters are required. The specified values of `Platform` and `Architecture` must be consistent with those of `Platform` and `Architecture` parameters of the instance.
        /// 
        /// > This feature is available to select users. To use this feature, [submit a ticket](https://workorder-intl.console.aliyun.com/console.htm).
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// > This parameter is not available for public use.
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// Specifies whether to encrypt the disk. Valid values:
        /// 
        /// *   true: encrypts the disk.
        /// *   false: does not encrypt the disk.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The ID of the image to be used to replace the system disk.
        /// 
        /// If the `DiskId` parameter is not specified, this parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the KMS key that you want to use for the system disk.
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// The name of the key pair.
        /// 
        /// > This parameter is applicable only to Linux instances. You can bind an SSH key pair to the instance as a logon credential. After you bind the SSH key pair, the username and password logon method is disabled for the instance.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to reset the password for the instance. The password must be 8 to 30 characters in length and contain at least three of the following items: uppercase letters, lowercase letters, digits, and special characters. Special characters include:
        /// 
        ///     ()`~!@#$%^&*-_+=|{}[]:;\"<>,.?/
        /// 
        /// The passwords of Windows instances cannot start with a forward slash (/).
        /// 
        /// This parameter is empty by default, which indicates that the current password remains unchanged.
        /// 
        /// > If you specify `Password`, we recommend that you send requests over HTTPS to prevent password leaks.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether to use the preset password of the image.
        /// 
        /// Default value: false
        /// 
        /// > If the PasswordInherit parameter is specified, you must leave the Password parameter empty. Before you use this parameter, make sure that a password is preset for the image.
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// The operating system distribution. Valid values:
        /// 
        /// *   CentOS
        /// *   Ubuntu
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to use Security Center Basic after the system disk is replaced. Valid values:
        /// 
        /// *   Active: uses Security Center Basic after the system disk is re-initialized. This value is applicable only to public images.
        /// *   Deactive: does not use Security Center Basic after the system disk is re-initialized. This value is applicable to all images.
        /// 
        /// Default value: Deactive.
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// Specifies whether to use the system configurations for virtual machines provided by Alibaba Cloud. System configurations for Windows: NTP and KMS. System configurations for Linux: NTP and YUM.
        /// 
        /// > This parameter takes effect only when you attach a system disk whose device name is /dev/xvda.
        /// </summary>
        [NameInMap("UseAdditionalService")]
        [Validation(Required=false)]
        public bool? UseAdditionalService { get; set; }

    }

}
