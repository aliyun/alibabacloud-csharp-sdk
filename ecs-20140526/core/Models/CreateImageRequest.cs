// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// <para>The system architecture of the system disk. If you specify a data disk snapshot to create the system disk of the custom image, use Architecture to specify the system architecture of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>i386</description></item>
        /// <item><description>x86_64</description></item>
        /// <item><description>arm64</description></item>
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
        /// <item><description>BIOS: BIOS mode</description></item>
        /// <item><description>UEFI: Unified Extensible Firmware Interface (UEFI) mode</description></item>
        /// <item><description>UEFI-Preferred (default): BIOS mode and UEFI mode</description></item>
        /// </list>
        /// <remarks>
        /// <para> Before you specify this parameter, make sure that you are familiar with the boot modes supported by the image. If you specify a boot mode that is not supported by the image, ECS instances created from the image cannot start as expected. For information about the boot modes of images, see the <a href="~~2244655#b9caa9b8bb1wf~~">Boot modes of images</a> section of the &quot;Best practices for ECS instance boot modes&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The value of <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The image description. The description must be 2 to 256 characters in length and cannot start with <a href="http://https://%E3%80%82">http:// or https://.</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageTestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The mode in which to check the custom image. If you do not specify this parameter, the image is not checked. Only the standard check mode is supported.</para>
        /// <remarks>
        /// <para> This parameter is supported for most Linux and Windows operating system versions. For information about image check items and operating system limits for image check, see <a href="https://help.aliyun.com/document_detail/439819.html">Overview of image check</a> and <a href="https://help.aliyun.com/document_detail/475800.html">Operating system limits for image check</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("DetectionStrategy")]
        [Validation(Required=false)]
        public string DetectionStrategy { get; set; }

        /// <summary>
        /// <para>Details of the disks and snapshots from which the custom image is created. If you want to create a custom image based on a system disk snapshot and data disk snapshots, use this parameter to specify the snapshots.</para>
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<CreateImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class CreateImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// <para>The device name of disk N in the custom image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>The device name of the system disk must be /dev/xvda.</description></item>
            /// <item><description>The device names of the data disks are unique and range from /dev/xvdb to /dev/xvdz in alphabetical order.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/vdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The type of disk N in the custom image. You can specify this parameter to create the system disk of the custom image from a data disk snapshot. If you do not specify this parameter, the disk type is determined by the corresponding snapshot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system disk. You can specify only one snapshot to use to create the system disk in the custom image.</description></item>
            /// <item><description>data: data disk. You can specify up to 16 snapshots to use to create data disks in the custom image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The size of disk N in the custom image. Unit: GiB. The valid values and default value of DiskDeviceMapping.N.Size vary based on the value of DiskDeviceMapping.N.SnapshotId.</para>
            /// <list type="bullet">
            /// <item><description><para>If you leave DiskDeviceMapping.N.SnapshotId empty, DiskDeviceMapping.N.Size has the following valid values and default values:</para>
            /// <list type="bullet">
            /// <item><description>For basic disks, the valid values range from 5 to 2000, and the default value is 5.</description></item>
            /// <item><description>For other disks, the valid values range from 20 to 32768, and the default value is 20.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If you specify DiskDeviceMapping.N.SnapshotId, the value of DiskDeviceMapping.N.Size must be greater than or equal to the size of the specified snapshot. The default value of DiskDeviceMapping.N.Size is the size of the specified snapshot.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot.</para>
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
        /// <para>The attributes of the custom image.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public CreateImageRequestFeatures Features { get; set; }
        public class CreateImageRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The image metadata access mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>v1: You cannot set the image metadata access mode to security hardening when you create instances from the image.</description></item>
            /// <item><description>v2: You can set the image metadata access mode to security hardening when you create instances from the image.</description></item>
            /// </list>
            /// <para>When you use a snapshot to create instances, the default value is set to 1. If you use an instance to create an image, the value of the ImdsSupport parameter is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("ImdsSupport")]
            [Validation(Required=false)]
            public string ImdsSupport { get; set; }

        }

        /// <summary>
        /// <para>The name of the image family. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with acs: or aliyun. The name cannot contain http:// or https://. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The name of the custom image. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with http:// or https://. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
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
        /// <para> If you specify an ECS instance that runs an Alibaba Cloud Marketplace image or a custom image derived from an Alibaba Cloud Marketplace image by using <c>InstanceId</c>, you must leave this parameter empty or set this parameter to the <c>ImageVersion</c> value of the image run by the specified ECS instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017011017</para>
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance from which to create the custom image. To create a custom image from an ECS instance, you must specify this parameter.</para>
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
        /// <para>The operating system distribution for the system disk in the custom image. If you specify a data disk snapshot to create the system disk of the custom image, use Platform to specify the operating system distribution for the system disk. Valid values:</para>
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
        /// <para>The region ID of the custom image that you want to create. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the custom image. If you leave this parameter empty, the image is assigned to the default resource group.</para>
        /// <remarks>
        /// <para> If you call the CreateImage operation as a Resource Access Management (RAM) user who does not have permissions on the default resource group and leave <c>ResourceGroupId</c> empty, the <c>Forbidden: User not authorized to operate on the specified resource</c> error message is returned. You must specify the ID of a resource group on which the RAM user has permissions or grant the RAM user permissions on the default resource group, and then call the CreateImage operation again.</para>
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
        /// <para>The ID of the snapshot from which to create the custom image.</para>
        /// <remarks>
        /// <para> To create a custom image from only a system disk snapshot of an ECS instance, you can specify this parameter or <c>DiskDeviceMapping.N.SnapshotId</c> to specify the snapshot ID. If you add data disk snapshots, you can use only <c>DiskDeviceMapping.N.SnapshotId</c> to specify snapshots.</para>
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
            /// <para>The key of tag N of the custom image. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the custom image. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
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
