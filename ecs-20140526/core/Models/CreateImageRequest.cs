// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// The system architecture of the system disk. If you specify a data disk snapshot to create the system disk of the custom image, you must use Architecture to specify the system architecture of the system disk. Valid values:
        /// 
        /// *   i386
        /// *   x86\_64
        /// *   arm64
        /// 
        /// Default value: x86\_64.
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// The boot mode of the image. Valid values:
        /// 
        /// *   BIOS
        /// *   UEFI
        /// 
        /// > You must be familiar with the boot modes supported by the specified image. When you use this parameter to change the boot mode of the image, specify a boot mode supported by the image to ensure that instances that use this image can be started as expected.
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The value of **ClientToken** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The image description. The description must be 2 to 256 characters in length and cannot start with [http:// or https://.](http://https://。)
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The mode that you want to use to check the source image. If you do not specify this parameter, the source image is not checked. Only Linux images can be checked. Set the value to Standard, which indicates standard check mode.
        /// 
        /// The following items are checked in standard check mode:
        /// 
        /// *   Virtio: whether the virtio driver is installed.
        /// *   Fstab: whether mounting configurations in the fstab file are correct.
        /// *   Grub: whether GRand Unified Bootloader (GRUB) configurations are correct.
        /// *   SystemImage: whether the image is valid. Do not import images that are in the ISO format or empty.
        /// *   CloudInit: whether cloud-init is installed.
        /// *   NVMe: whether the Non-Volatile Memory Express (NVMe) driver is installed.
        /// *   Selinux: whether SElinux is enabled.
        /// *   OnlineResizeFS: whether the root partition can be automatically resized.
        /// *   Dhcp: whether Dynamic Host Configuration Protocol (DHCP) is enabled for network interface controllers (NICs).
        /// *   RtcTimeMode: the RTC time mode.
        /// *   Platform: the platform. Examples: Linux and Windows.
        /// *   OSVersion: the operating system version. Example: Centos 7.9.
        /// *   Architecture: the architecture. Examples: ARM and x86\_64.
        /// *   BootMode: the boot mode. Examples: UEFI and Legacy.
        /// *   KernelVersion: the kernel version.
        /// *   CloudAssistant: whether the Cloud Assistant client is installed.
        /// *   SecurityCenterAgent: whether the Security Center agent is installed.
        /// </summary>
        [NameInMap("DetectionStrategy")]
        [Validation(Required=false)]
        public string DetectionStrategy { get; set; }

        /// <summary>
        /// The custom images.
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<CreateImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class CreateImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// The device name of disk N in the custom image. Valid values:
            /// 
            /// *   For disks other than basic disks, such as standard SSDs, ultra disks, and enhanced SSDs (ESSDs), the valid values range from /dev/vda to /dev/vdz in ascending alphabetical order.
            /// *   For basic disks, the valid values are in alphabetical order from /dev/xvda to /dev/xvdz.
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// The type of disk N in the custom image. You can specify this parameter to create the system disk of the custom image from a data disk snapshot. If you do not specify this parameter, the disk type is determined by the corresponding snapshot. Valid values:
            /// 
            /// *   system: system disk
            /// *   data: data disk
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The size of disk N in the custom image. Unit: GiB. The valid values and default value of DiskDeviceMapping.N.Size depend on the value of DiskDeviceMapping.N.SnapshotId.
            /// 
            /// *   If no corresponding snapshot IDs are specified in the DiskDeviceMapping.N.SnapshotId value, the following valid values and default values are available for DiskDeviceMapping.N.Size:
            /// 
            ///     *   For basic disks, the valid values are 5 to 2000, and the default value is 5.
            ///     *   For other types of disk, the valid values are 20 to 32768, and the default value is 20.
            /// 
            /// *   If a corresponding snapshot ID is specified in the DiskDeviceMapping.N.SnapshotId value, the value of DiskDeviceMapping.N.Size must be greater than or equal to the size of the specified snapshot. The default value of DiskDeviceMapping.N.Size is the size of the specified snapshot.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The ID of the snapshot that is used to create the custom image.
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// The name of the image family. The name must be 2 to 128 characters in length and can contain digits, colons (:), underscores (\_), and hyphens (-). The name must start with a letter and cannot start with acs: or aliyun. It cannot contain [http:// or https://.](http://https://。、（:）、（\_）（-）。)
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// The image name. The name must be 2 to 128 characters in length and can contain digits, colons (:), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with [http:// or https://.](http://https://。、（:）、（\_）（-）。)
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The image version.
        /// 
        /// > If you specify an instance by configuring `InstanceId`, and the instance uses an Alibaba Cloud Marketplace image or a custom image that is created from an Alibaba Cloud Marketplace image, you must leave this parameter empty or set this parameter to the value of ImageVersion of the instance.
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The distribution of the operating system for the system disk in the custom image. If you specify a data disk snapshot to create the system disk of the custom image, you must use Platform to specify the distribution of the operating system for the system disk. Valid values:
        /// 
        /// *   CentOS
        /// *   Ubuntu
        /// *   SUSE
        /// *   OpenSUSE
        /// *   RedHat
        /// *   Debian
        /// *   CoreOS
        /// *   Aliyun
        /// *   Windows Server 2012
        /// *   Windows 7
        /// *   Customized Linux
        /// *   Others Linux
        /// 
        /// Default value: Others Linux.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The region ID of the custom image that you want to create. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the custom image. If you leave this parameter empty, the image is assigned to the default resource group.
        /// 
        /// > If you call the CreateImage operation as a RAM user who is not authorized to manage the default resource group and leave `ResourceGroupId` empty, the `Forbidden: User not authorized to operate on the specified resource` error message is returned. Before you call the CreateImage operation again, you must specify the ID of a resource group that the RAM user is authorized to manage or authorize the RAM user to manage the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the snapshot that is used to create the custom image.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImageRequestTag> Tag { get; set; }
        public class CreateImageRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the custom image. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with `aliyun` or `acs:`. The tag key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the custom image. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with `acs:`. The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
