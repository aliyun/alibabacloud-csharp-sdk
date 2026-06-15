// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// <para>The system disk architecture. If you create the image\&quot;s system disk from a data disk snapshot, you must specify this parameter to identify the system disk architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>i386</para>
        /// </description></item>
        /// <item><description><para>x86_64</para>
        /// </description></item>
        /// <item><description><para>arm64</para>
        /// </description></item>
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
        /// <item><description><para>BIOS: BIOS boot mode.</para>
        /// </description></item>
        /// <item><description><para>UEFI: UEFI boot mode.</para>
        /// </description></item>
        /// <item><description><para>UEFI-Preferred: The image supports both BIOS and UEFI boot modes. The UEFI boot mode is preferred. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If you specify a boot mode that the image does not support, instances created from the image may fail to start. Before you specify this parameter, ensure you know the boot modes that the image supports. For more information, see <a href="~~2244655#b9caa9b8bb1wf~~">Boot modes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure the request is idempotent. You must ensure that the token is unique across different requests. The <c>ClientToken</c> value can contain only ASCII characters and cannot exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotency</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The image description. It must be 2 to 256 characters long and cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageTestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image check policy. If you do not specify this parameter, no check is performed. Only the Standard mode is supported.</para>
        /// <remarks>
        /// <para>This feature is supported for most Linux and Windows versions. For more information about the check items and the operating systems that support this feature, see <a href="https://help.aliyun.com/document_detail/439819.html">Overview of image check</a> and <a href="https://help.aliyun.com/document_detail/475800.html">Operating systems that support image check</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("DetectionStrategy")]
        [Validation(Required=false)]
        public string DetectionStrategy { get; set; }

        /// <summary>
        /// <para>The mappings between disks and snapshots used to create the custom image. If you need to create a custom image from a system disk snapshot and data disk snapshots, specify this parameter.</para>
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
            /// <item><description><para>The device names of data disks are assigned in sequence from /dev/xvdb to /dev/xvdz and cannot be repeated.</para>
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
            /// <para>The type of the disk in the image. You can specify this parameter to use a data disk snapshot as the system disk of the image. If you do not specify this parameter, the disk type is determined by the type of the source snapshot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>system: system disk. You can specify only one system disk snapshot.</para>
            /// </description></item>
            /// <item><description><para>data: data disk. You can specify a maximum of 16 data disk snapshots.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The size of the cloud disk, in GiB. The valid values and default value of <c>DiskDeviceMapping.N.Size</c> vary based on whether <c>DiskDeviceMapping.N.SnapshotId</c> is specified.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>DiskDeviceMapping.N.SnapshotId</c> is not specified, the value of this parameter depends on the disk type:</para>
            /// <list type="bullet">
            /// <item><description><para>For basic disks, the value range is 5 to 2,000 and the default value is 5.</para>
            /// </description></item>
            /// <item><description><para>For other disk types, the value range is 20 to 32,768 and the default value is 20.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <c>DiskDeviceMapping.N.SnapshotId</c> is specified, the value of <c>DiskDeviceMapping.N.Size</c> must be greater than or equal to the snapshot\&quot;s size. The default value is the snapshot\&quot;s size.</para>
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

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: performs a dry run but does not create the image. The system checks whether your AccessKey pair is valid, whether RAM users are granted permissions, and whether the required parameters are specified. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para>false: Sends the request to perform the operation. If the request is valid, a 2xx HTTP status code is returned and the image is created.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The image attributes.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public CreateImageRequestFeatures Features { get; set; }
        public class CreateImageRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The instance metadata access mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>v1: The normal mode. When you create an ECS instance from an image that has the metadata access mode set to this value, you cannot configure the instance metadata access mode as Enforced.</para>
            /// </description></item>
            /// <item><description><para>v2: The enforced mode. When you create an ECS instance from an image that has the metadata access mode set to this value, you can configure the instance metadata access mode as Enforced.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: v1 if you create the image from a snapshot. If you create the image from an instance, the value is inherited from the source instance\&quot;s image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("ImdsSupport")]
            [Validation(Required=false)]
            public string ImdsSupport { get; set; }

        }

        /// <summary>
        /// <para>The name of the image family. The name must be 2 to 128 characters long and start with a letter or a Chinese character. It cannot start with aliyun or acs:, nor contain http\:// or https\://. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The name of the image. The name must be 2 to 128 characters long. It must start with a letter or a Chinese character and must not start with http\:// or https\://. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestCentOS</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The version of the image.</para>
        /// <remarks>
        /// <para>If you specify an instance ID (<c>InstanceId</c>) and the instance was created from an Alibaba Cloud Marketplace image (or a custom image based on a Marketplace image), this parameter must match the <c>ImageVersion</c> of the instance\&quot;s image or be left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017011017</para>
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// <para>The ID of the instance. This parameter is required when you create a custom image from an instance.</para>
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
        /// <para>The operating system distribution. You must specify this parameter to identify the operating system distribution when you use a data disk snapshot to create the image\&quot;s system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Aliyun</para>
        /// </description></item>
        /// <item><description><para>Anolis</para>
        /// </description></item>
        /// <item><description><para>CentOS</para>
        /// </description></item>
        /// <item><description><para>Ubuntu</para>
        /// </description></item>
        /// <item><description><para>CoreOS</para>
        /// </description></item>
        /// <item><description><para>SUSE</para>
        /// </description></item>
        /// <item><description><para>Debian</para>
        /// </description></item>
        /// <item><description><para>OpenSUSE</para>
        /// </description></item>
        /// <item><description><para>FreeBSD</para>
        /// </description></item>
        /// <item><description><para>RedHat</para>
        /// </description></item>
        /// <item><description><para>Kylin</para>
        /// </description></item>
        /// <item><description><para>UOS</para>
        /// </description></item>
        /// <item><description><para>Fedora</para>
        /// </description></item>
        /// <item><description><para>Fedora CoreOS</para>
        /// </description></item>
        /// <item><description><para>CentOS Stream</para>
        /// </description></item>
        /// <item><description><para>AlmaLinux</para>
        /// </description></item>
        /// <item><description><para>Rocky Linux</para>
        /// </description></item>
        /// <item><description><para>Gentoo</para>
        /// </description></item>
        /// <item><description><para>Customized Linux</para>
        /// </description></item>
        /// <item><description><para>Others Linux</para>
        /// </description></item>
        /// <item><description><para>Windows Server 2022</para>
        /// </description></item>
        /// <item><description><para>Windows Server 2019</para>
        /// </description></item>
        /// <item><description><para>Windows Server 2016</para>
        /// </description></item>
        /// <item><description><para>Windows Server 2012</para>
        /// </description></item>
        /// <item><description><para>Windows Server 2008</para>
        /// </description></item>
        /// <item><description><para>Windows Server 2003</para>
        /// </description></item>
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
        /// <para>The ID of the region where the image will be created. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to get the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to add the custom image. If you do not specify this parameter, the image is added to the default resource group.</para>
        /// <remarks>
        /// <para>As a RAM user, you must have the required permissions to call this operation. If you leave <c>ResourceGroupId</c> empty, the <c>Forbidden: User not authorized to operate on the specified resource</c> error is returned if you lack permissions on the default resource group. To resolve this issue, specify the ID of a resource group for which you have permissions, or ask an administrator to grant you permissions on the default resource group.</para>
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
        /// <para>The ID of the snapshot used to create the custom image.</para>
        /// <remarks>
        /// <para>If you create a custom image from only a system disk snapshot, you can use either this parameter or the <c>DiskDeviceMapping.N.SnapshotId</c> parameter. If you want to include data disk snapshots, you must use the <c>DiskDeviceMapping.N.SnapshotId</c> parameter to specify the snapshots.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp17441ohwkdca0****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The tags to add to the image.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImageRequestTag> Tag { get; set; }
        public class CreateImageRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the image.</para>
            /// <remarks>
            /// <para>For compatibility, we recommend that you use the <c>Tag.N.Key</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the image. Valid values of N: 1 to 20. The tag value can be an empty string, up to 128 characters long, and cannot start with <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
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
