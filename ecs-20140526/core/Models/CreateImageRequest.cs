// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// <para>The system architecture. After a data disk snapshot is specified as the system disk of the image, use this parameter to specify the system architecture of the system disk. Valid values:</para>
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
        /// <item><description>(Default) UEFI-Preferred: dual boot mode.</description></item>
        /// </list>
        /// <notice>
        /// 
        /// <para>To prevent instances from failing to start due to an unsupported boot mode, make sure that you understand the boot modes supported by the target image before specifying this parameter. For more information about image boot modes, see <a href="~~2244655#b9caa9b8bb1wf~~">Image boot modes</a>.</para>
        /// </notice>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the image. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageTestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image detection strategy. If this parameter is not specified, detection is not triggered. Only the Standard detection mode is supported. </para>
        /// <remarks>
        /// <para>Most Linux and Windows versions are supported. For more information about image detection items and operating system limitations, see <a href="https://help.aliyun.com/document_detail/439819.html">Image detection overview</a> and <a href="https://help.aliyun.com/document_detail/475800.html">Operating system limitations for image detection</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("DetectionStrategy")]
        [Validation(Required=false)]
        public string DetectionStrategy { get; set; }

        /// <summary>
        /// <para>The disk and snapshot information used to create the custom image. Use this parameter to specify snapshots when you want to create a custom image from system disk and data disk snapshots.</para>
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<CreateImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class CreateImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// <para>The device name in the custom image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>The device name of the system disk must be /dev/xvda.</para>
            /// </description></item>
            /// <item><description><para>Data disk device names are sequentially ordered from /dev/xvdb to /dev/xvdz and cannot be duplicated.</para>
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
            /// <para>The type of the disk in the new image. You can use this parameter to specify a data disk snapshot as the system disk of the image. If this parameter is not specified, the disk type defaults to the type of the disk corresponding to the snapshot. Valid values:</para>
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
            /// <para>The size of the disk, in GiB. The valid values and default value of DiskDeviceMapping.N.Size depend on DiskDeviceMapping.N.SnapshotId:</para>
            /// <list type="bullet">
            /// <item><description>If SnapshotId is not specified, the valid values and default value of Size are:<list type="bullet">
            /// <item><description>Basic disk: 5 to 2000 GiB. Default value: 5.</description></item>
            /// <item><description>Other disk types: 20 to 32768 GiB. Default value: 20.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>If SnapshotId is specified, the value of Size must be greater than or equal to the size of the snapshot. Default value: the size of the snapshot.</description></item>
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
        /// <para>The image feature properties.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public CreateImageRequestFeatures Features { get; set; }
        public class CreateImageRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The metadata access mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>v1: When you create an ECS instance from this image, you cannot set the metadata access mode to &quot;security hardening mode only&quot;.</description></item>
            /// <item><description>v2: When you create an ECS instance from this image, you can set the metadata access mode to &quot;security hardening mode only&quot;.</description></item>
            /// </list>
            /// <para>Default value: When creating an image from a snapshot, the default is v1. When creating an image from an instance, the default is the ImdsSupport value of the image used when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("ImdsSupport")]
            [Validation(Required=false)]
            public string ImdsSupport { get; set; }

        }

        /// <summary>
        /// <para>The image family name. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with aliyun or acs:. It cannot contain http:// or https://. It can contain digits, colons (:), underscores (_), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The image name. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), or hyphens (-).</para>
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
        /// <para>If you specify an instance ID (<c>InstanceId</c>) and the image of the instance is an Alibaba Cloud Marketplace image or a custom image created from an Alibaba Cloud Marketplace image, this parameter must be the same as the <c>ImageVersion</c> of the current instance image or left empty.</para>
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
        /// <para>The operating system distribution. After a data disk snapshot is specified as the system disk of the image, use this parameter to specify the operating system distribution of the system disk. Valid values:</para>
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
        /// <para>The region ID of the image. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the custom image belongs. If this parameter is not set, the created image belongs to the default resource group.</para>
        /// <remarks>
        /// <para>If you invoke this operation as a Resource Access Management (RAM) user and <c>ResourceGroupId</c> is left empty, note that when the RAM user does not have permissions on the default resource group, the error message <c>Forbidden: User not authorized to operate on the specified resource</c> is returned. Set a resource group ID that the RAM user has permissions on, or grant the RAM user permissions on the default resource group before invoking this operation again.</para>
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
        /// <para>The snapshot ID used to create the custom image.</para>
        /// <remarks>
        /// <para>If you want to create a custom image only from the system disk snapshot of an instance, you can use this parameter or the <c>DiskDeviceMapping.N.SnapshotId</c> parameter. To include data disk snapshots, use only the <c>DiskDeviceMapping.N.SnapshotId</c> parameter to specify snapshots.</para>
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
            /// <para>The tag key of the image. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the image. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
