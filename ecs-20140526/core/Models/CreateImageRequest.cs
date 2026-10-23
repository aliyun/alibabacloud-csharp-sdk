// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// <para>The system architecture. After you specify a data disk snapshot as the system disk of the image, you must use Architecture to determine the system architecture of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>i386.</description></item>
        /// <item><description>x86_64.</description></item>
        /// <item><description>arm64.</description></item>
        /// </list>
        /// <para>Default value: x86_64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x86_64</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The boot mode of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BIOS: BIOS boot mode.</description></item>
        /// <item><description>UEFI: UEFI boot mode.</description></item>
        /// <item><description>UEFI-Preferred: Dual boot mode.</description></item>
        /// </list>
        /// <notice>
        /// 
        /// <para>To prevent the instance from failing to start due to an unsupported boot mode, make sure that you understand the boot modes supported by the target image before you select this parameter. For more information about image boot modes, see <a href="~~2244655#b9caa9b8bb1wf~~">Image boot modes</a>.</para>
        /// </notice>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The image description. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageTestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image detection strategy. If you do not configure this parameter, detection is not triggered. Only the standard (Standard) detection mode is supported. </para>
        /// <remarks>
        /// <para>Most Linux and Windows versions are supported. For more information about image detection items and operating system limits, see <a href="https://help.aliyun.com/document_detail/439819.html">Image detection overview</a> and <a href="https://help.aliyun.com/document_detail/475800.html">Operating system limits for image detection</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("DetectionStrategy")]
        [Validation(Required=false)]
        public string DetectionStrategy { get; set; }

        /// <summary>
        /// <para>The disks and snapshots used to create the custom image. If you want to create a custom image from a system disk snapshot and data disk snapshots, use this parameter to specify the snapshots.</para>
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<CreateImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class CreateImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// <para>The device name of the disk in the custom image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>The device name of the system disk must be /dev/xvda.</para>
            /// </description></item>
            /// <item><description><para>The device names of data disks range from /dev/xvdb to /dev/xvdz and cannot be duplicate.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The disk type in the new image. You can use this parameter to use a data disk snapshot as the system disk of the image. If you do not specify this parameter, the default value is the disk type corresponding to the snapshot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system disk. Only one system disk snapshot can be specified.</description></item>
            /// <item><description>data: data disk. Up to 16 data disk snapshots can be specified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The size of the disk. Unit: GiB. The valid values and default value of DiskDeviceMapping.N.Size depend on DiskDeviceMapping.N.SnapshotId:</para>
            /// <list type="bullet">
            /// <item><description>If SnapshotId is not specified, the valid values and default value of Size are as follows:<list type="bullet">
            /// <item><description>Basic disk: 5 to 2000 GiB. Default value: 5.</description></item>
            /// <item><description>Other disks: 20 to 32768 GiB. Default value: 20.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>If SnapshotId is specified, the value of Size must be greater than or equal to the size of the snapshot specified by SnapshotId. The default value is the size of the snapshot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The snapshot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwkdca0****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The image feature attributes.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public CreateImageRequestFeatures Features { get; set; }
        public class CreateImageRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The metadata access mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>v1: When you create an ECS instance from this image, you cannot set the metadata access mode to Reinforced.</description></item>
            /// <item><description>v2: When you create an ECS instance from this image, you can set the metadata access mode to Reinforced.</description></item>
            /// </list>
            /// <para>Default value: If you create an image from a snapshot, the default value is v1. If you create an image from an instance, the default value is the ImdsSupport attribute value of the image used when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("ImdsSupport")]
            [Validation(Required=false)]
            public string ImdsSupport { get; set; }

        }

        /// <summary>
        /// <para>The name of the image family. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It cannot start with aliyun or acs:, and cannot contain http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The image name. It must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestCentOS</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The image version.</para>
        /// <remarks>
        /// <para>If you specify the instance ID (<c>InstanceId</c>) and the image of the instance is an Alibaba Cloud Marketplace image or a custom image created from an Alibaba Cloud Marketplace image, this parameter must be the same as the <c>ImageVersion</c> of the current instance image or left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017011017</para>
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is required when you create a custom image from an instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1g6zv0ce8oghu7****</para>
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
        /// <para>The operating system. After you specify a data disk snapshot as the system disk of the image, you must use Platform to determine the operating system distribution of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Aliyun</description></item>
        /// <item><description>Anolis</description></item>
        /// <item><description>CentOS</description></item>
        /// <item><description>Ubuntu</description></item>
        /// <item><description>CoreOS</description></item>
        /// <item><description>SUSE</description></item>
        /// <item><description>Debian</description></item>
        /// <item><description>OpenSUSE</description></item>
        /// <item><description>FreeBSD</description></item>
        /// <item><description>RedHat</description></item>
        /// <item><description>Kylin</description></item>
        /// <item><description>UOS</description></item>
        /// <item><description>Fedora</description></item>
        /// <item><description>Fedora CoreOS</description></item>
        /// <item><description>CentOS Stream</description></item>
        /// <item><description>AlmaLinux</description></item>
        /// <item><description>Rocky Linux</description></item>
        /// <item><description>Gentoo</description></item>
        /// <item><description>Customized Linux</description></item>
        /// <item><description>Others Linux</description></item>
        /// <item><description>Windows Server 2022</description></item>
        /// <item><description>Windows Server 2019</description></item>
        /// <item><description>Windows Server 2016</description></item>
        /// <item><description>Windows Server 2012</description></item>
        /// <item><description>Windows Server 2008</description></item>
        /// <item><description>Windows Server 2003</description></item>
        /// </list>
        /// <para>Default value: Others Linux.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The region ID of the image. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the custom image belongs. If you do not specify this parameter, the created image belongs to the default resource group.</para>
        /// <remarks>
        /// <para>If you use a Resource Access Management (RAM) user to invoke this operation and <c>ResourceGroupId</c> is left empty, note that if the RAM user does not have permissions on the default resource group, the operation returns the error message <c>Forbidden: User not authorized to operate on the specified resource</c>. Specify the ID of a resource group that the RAM user has permissions on, or use the corresponding Alibaba Cloud account to grant the RAM user permissions on the default resource group in the RAM Settings before you invoke this operation again.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
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
        /// <para>The secure boot parameters.</para>
        /// </summary>
        [NameInMap("SecureBootOptions")]
        [Validation(Required=false)]
        public CreateImageRequestSecureBootOptions SecureBootOptions { get; set; }
        public class CreateImageRequestSecureBootOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether the image supports secure boot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>supported: The image supports secure boot.</description></item>
            /// <item><description>unsupported: The image does not support secure boot.<remarks>
            /// <para>Secure Boot only supports the UEFI or UEFI-Preferred boot mode.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("SecureBootSupport")]
            [Validation(Required=false)]
            public string SecureBootSupport { get; set; }

        }

        /// <summary>
        /// <para>The ID of the snapshot used to create the custom image.</para>
        /// <remarks>
        /// <para>If you create a custom image only from the system disk snapshot of an instance, you can use this parameter or the <c>DiskDeviceMapping.N.SnapshotId</c> parameter. If you add data disk snapshots, you can only use the <c>DiskDeviceMapping.N.SnapshotId</c> parameter to specify the snapshots.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp17441ohwkdca0****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImageRequestTag> Tag { get; set; }
        public class CreateImageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the image. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the image. Valid values of N: 1 to 20. If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ValueTest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
