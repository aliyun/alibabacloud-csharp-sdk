// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachDiskRequest : TeaModel {
        /// <summary>
        /// Specifies whether to attach the disk as a system disk.
        /// 
        /// Default value: false.
        /// 
        /// >  You can set `Bootable` to true only if the instance does not have a system disk.
        /// </summary>
        [NameInMap("Bootable")]
        [Validation(Required=false)]
        public bool? Bootable { get; set; }

        /// <summary>
        /// Specifies whether to release the disk when the instance is released.
        /// 
        /// *   true: releases the disk when the instance is released.
        /// *   false: does not release the disk when the instance is released. The disk is retained as a pay-as-you-go data disk.
        /// 
        /// Default value: false.
        /// 
        /// When you specify this parameter, take note of the following items:
        /// 
        /// *   If `OperationLocks` in the DescribeInstances response contains `"LockReason" : "security"` for the instance to which the disk is attached, the instance is locked for security reasons. Regardless of whether you set `DeleteWithInstance` to `false`, the DeleteWithInstance setting is ignored, and the disk is released when the instance is released.
        /// *   If you want to attach an `elastic ephemeral disk`, you must set `DeleteWithInstance` to `true`.
        /// *   This parameter is unavailable for disks for which the multi-attach feature is enabled.
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// The device name of the disk.
        /// 
        /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// The ID of the disk. The disk specified by `DiskId` and the instance specified by `InstanceId` must reside in the same zone.
        /// 
        /// >  For more information about the limits on attaching a data disk and a system disk, see the "Usage notes" section of this topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// Specifies whether to forcefully attach the disk to the instance.
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The ID of the instance to which you want to attach the disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the SSH key pair that you bind to the Linux instance when you attach the system disk.
        /// 
        /// *   Windows instances do not support logons based on SSH key pairs. The `Password` parameter takes effect even if the KeyPairName parameter is specified.
        /// *   For Linux instances, the username and password-based logon method is disabled by default.
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
        /// The password that is set when you attach the system disk. The password is applicable only to the administrator and root users. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:
        /// 
        ///     ()`~!@#$%^&*-_+=|{}[]:;\\"<>,.?/
        /// 
        /// For Windows instances, passwords cannot start with a forward slash (/).
        /// 
        /// > If `Password` is configured, we recommend that you send requests over HTTPS to prevent password leaks.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
