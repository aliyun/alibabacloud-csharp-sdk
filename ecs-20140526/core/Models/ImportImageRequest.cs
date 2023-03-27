// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ImportImageRequest : TeaModel {
        /// <summary>
        /// The system architecture. Valid values:
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
        /// Default value: BIOS. If you set the `Architecture` parameter to arm64, the BootMode parameter can only be set to UEFI.
        /// 
        /// > You must be aware of the boot modes supported by the specified image. The modified boot mode needs to be supported by the image. This way, instances that use this image can start.
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// The description of the image. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The mode in which to check the source image. Specify this parameter when you need to check the source image. Only Linux images can be checked. Set the value to Standard, which indicates standard check mode.
        /// 
        /// The following items are checked in standard check mode:
        /// 
        /// *   Virtio: whether the virtio driver is installed.
        /// *   Fstab: whether mounting configurations in the fstab file are correct.
        /// *   Grub: whether GRand Unified Bootloader (GRUB) configurations are correct.
        /// *   SystemImage: whether the image is valid. Do not import images that are in the ISO format or empty.
        /// *   CloudInit: whether cloud-init is installed.
        /// *   NVMe: whether the NVMe driver is installed.
        /// *   Selinux: whether SElinux is enabled.
        /// *   OnlineResizeFS: whether the root partition can be automatically resized.
        /// *   Dhcp: whether Dynamic Host Configuration Protocol (DHCP) is enabled for network interface controllers (NICs).
        /// *   RtcTimeMode: the RTC time mode.
        /// *   Platform: the platform. Example: Linux or Windows.
        /// *   OSVersion: the operating system version. Example: Centos 7.9.
        /// *   Architecture: the architecture. Example: ARM or x86\_64.
        /// *   BootMode: the boot mode. Example: UEFI or Legacy.
        /// *   KernelVersion: the kernel version.
        /// *   CloudAssistant: whether the Cloud Assistant client is installed.
        /// *   SecurityCenterAgent: whether the Security Center is installed.
        /// </summary>
        [NameInMap("DetectionStrategy")]
        [Validation(Required=false)]
        public string DetectionStrategy { get; set; }

        /// <summary>
        /// Details about the custom images.
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<ImportImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class ImportImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// The device name of disk N in the custom image.
            /// 
            /// > This parameter will be deprecated in the future. To ensure future compatibility, we recommend that you do not use this parameter.
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// The size of the custom image.
            /// 
            /// > This parameter will be deprecated in the future. We recommend that you use the `DiskDeviceMapping.N.DiskImageSize` parameter to ensure future compatibility.
            /// </summary>
            [NameInMap("DiskImSize")]
            [Validation(Required=false)]
            public int? DiskImSize { get; set; }

            /// <summary>
            /// The size of disk N in the custom image.
            /// 
            /// You can use this parameter to specify the sizes of the system disk and data disks in the custom image. Make sure that the specified size is greater than or equal to the size of the custom image file. Unit: GiB. Valid values:
            /// 
            /// *   When the value of N is 1, this parameter specifies the size of the system disk in the custom image. Valid values: 5 to 500.
            /// *   When the value of N ranges from 2 to 17, this parameter specifies the size of the data disk in the custom image. Valid values: 5 to 2000.
            /// 
            /// After the source image is uploaded to an OSS bucket, you can view the size of the image in the OSS bucket.
            /// </summary>
            [NameInMap("DiskImageSize")]
            [Validation(Required=false)]
            public int? DiskImageSize { get; set; }

            /// <summary>
            /// The format of the image. Valid values:
            /// 
            /// *   RAW
            /// *   VHD
            /// *   QCOW2
            /// 
            /// This parameter is empty by default, which indicates that the system checks the format of the image and uses the check result as the value of this parameter.
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// The OSS bucket in which the source image is stored.
            /// 
            /// > If this is the first time that you import images to ECS, you must use RAM to authorize ECS to access your OSS buckets. Otherwise, the `NoSetRoletoECSServiceAcount` error code is returned. For more information, see the **Description** section of this topic.
            /// </summary>
            [NameInMap("OSSBucket")]
            [Validation(Required=false)]
            public string OSSBucket { get; set; }

            /// <summary>
            /// The name (key) of the uploaded source image stored in the OSS bucket.
            /// </summary>
            [NameInMap("OSSObject")]
            [Validation(Required=false)]
            public string OSSObject { get; set; }

        }

        /// <summary>
        /// The name of the image. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `acs:` or `aliyun`. The name cannot contain `http://` or `https://`. The name can contain letters, digits, periods (.), colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The type of the license that you want to use to activate the OS after the image is imported. Valid values:
        /// 
        /// *   Auto: ECS checks the operating system of the source image and allocates a license to the operating system. ECS first checks whether the operating system distribution specified by `Platform` has a license allocated through an official Alibaba Cloud channel. If yes, the allocated license is used. If not, the license that comes with the source operating system is used.
        /// *   Aliyun: The license allocated through an official Alibaba Cloud channel is used for the operating system distribution specified by `Platform`.
        /// *   BYOL: The license that comes with the source operating system is used. In this case, make sure that your license key can be used in Alibaba Cloud.
        /// 
        /// Default value: Auto.
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// The operating system platform. Valid values:
        /// 
        /// *   windows
        /// *   linux
        /// 
        /// Default value: linux.
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The operating system distribution. Valid values:
        /// 
        /// *   CentOS
        /// *   CentOS Stream
        /// *   Ubuntu
        /// *   SUSE
        /// *   openSUSE
        /// *   Debian
        /// *   CoreOS
        /// *   Aliyun
        /// *   Anolis
        /// *   AlmaLinux
        /// *   FreeBSD
        /// *   Fedora
        /// *   Rocky Linux
        /// *   UOS
        /// *   Kylin
        /// *   Others Linux
        /// *   Customized Linux
        /// *   Windows Server 2022
        /// *   Windows Server 2019
        /// *   Windows Server 2016
        /// *   Windows Server 2012
        /// *   Windows Server 2008
        /// *   Windows Server 2003
        /// 
        /// Default value: Others Linux.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The region ID of the source custom image. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the custom image.
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
        /// The name of the RAM role used to import the source image.
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// The tags of the image.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ImportImageRequestTag> Tag { get; set; }
        public class ImportImageRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the image. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the image. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
