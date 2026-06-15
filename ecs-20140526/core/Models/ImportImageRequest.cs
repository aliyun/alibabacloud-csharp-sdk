// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ImportImageRequest : TeaModel {
        /// <summary>
        /// <para>The system architecture. Valid values:</para>
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
        /// <item><description><para>BIOS: the BIOS boot mode.</para>
        /// </description></item>
        /// <item><description><para>UEFI: the UEFI boot mode.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: BIOS. If you set <c>Architecture</c> to <c>arm64</c>, the value of this parameter defaults to UEFI and can only be set to UEFI.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>To prevent startup failures, ensure the boot mode you specify is supported by the image. For more information, see <a href="~~2244655#b9caa9b8bb1wf~~">Image boot modes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of a request. The token must be unique across requests. The token can contain only ASCII characters and must be no more than 64 characters long. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the image. The description must be 2 to 256 characters long and cannot start with <c>http://</c> or <c>https://</c>. Both English and Chinese characters are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The policy for checking the image. If you do not specify this parameter, the system does not check the image. This parameter supports only the standard detection mode. Set the value to <c>Standard</c>.</para>
        /// <remarks>
        /// <para>This feature is supported on most Linux and Windows versions. For more information about the check items and the operating systems that support this feature, see <a href="https://help.aliyun.com/document_detail/439819.html">Image detection overview</a> and <a href="https://help.aliyun.com/document_detail/475800.html">Operating system limitations for image detection</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("DetectionStrategy")]
        [Validation(Required=false)]
        public string DetectionStrategy { get; set; }

        /// <summary>
        /// <para>A list of disk device mappings for the custom image.</para>
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<ImportImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class ImportImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// <para>The device name of the disk (<c>DiskDeviceMapping.N.Device</c>) in the custom image.</para>
            /// <remarks>
            /// <para>This parameter is being phased out. To ensure compatibility, we recommend that you avoid using this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The size of the disk, in GiB.</para>
            /// <para>The system disk size must be greater than or equal to the size of the imported image file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>For N=1, the disk is a system disk. The value must be in the range of 1 to 2,048.</para>
            /// </description></item>
            /// <item><description><para>For N=2 to 17, the disk is a data disk. The value must be in the range of 1 to 2,048.</para>
            /// </description></item>
            /// </list>
            /// <para>After you upload the source image file to an OSS bucket, you can view the size of the file in the bucket.</para>
            /// <remarks>
            /// <para>This parameter is being deprecated. For better compatibility, we recommend that you use the <c>DiskDeviceMapping.N.DiskImageSize</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DiskImSize")]
            [Validation(Required=false)]
            public int? DiskImSize { get; set; }

            /// <summary>
            /// <para>The size of the disk after the image is imported, in GiB.</para>
            /// <para>The value of this parameter for the system disk must be greater than or equal to the size of the image file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>For N=1, the disk is a system disk. The value must be in the range of 1 to 2,048.</para>
            /// </description></item>
            /// <item><description><para>For N=2 to 17, the disk is a data disk. The value must be in the range of 1 to 2,048.</para>
            /// </description></item>
            /// </list>
            /// <para>After you upload the source image file to an OSS bucket, you can view the size of the file in the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DiskImageSize")]
            [Validation(Required=false)]
            public int? DiskImageSize { get; set; }

            /// <summary>
            /// <para>The format of the image file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RAW</para>
            /// </description></item>
            /// <item><description><para>VHD</para>
            /// </description></item>
            /// <item><description><para>QCOW2</para>
            /// </description></item>
            /// <item><description><para>VMDK (This feature is in invitation-only preview.)</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: None. If you leave this parameter empty, Alibaba Cloud automatically detects the image format and uses the detected format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QCOW2</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The OSS bucket where the image file is stored.</para>
            /// <remarks>
            /// <para>Before you import an image from an OSS bucket for the first time, you must add a RAM policy as described in the <b>Description</b> section of this topic. Otherwise, the API returns the <c>NoSetRoletoECSServiceAccount</c> error.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecsimageos</para>
            /// </summary>
            [NameInMap("OSSBucket")]
            [Validation(Required=false)]
            public string OSSBucket { get; set; }

            /// <summary>
            /// <para>The object key of the image file in the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS_5.4_32.raw</para>
            /// </summary>
            [NameInMap("OSSObject")]
            [Validation(Required=false)]
            public string OSSObject { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: performs a check request without executing the actual operation. The system checks whether the request parameters are valid, the request format is correct, and the required permissions are granted. If the check fails, the system returns an error message. If the check succeeds, the system returns the <c>DryRunOperation</c> error code.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: sends a normal request. After the request passes the check, the system returns a 2xx HTTP status code and performs the operation.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The properties of image features.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public ImportImageRequestFeatures Features { get; set; }
        public class ImportImageRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The metadata access mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>v1: When you create an ECS instance from the image, you cannot set the metadata access mode to Security-Hardened Mode.</para>
            /// </description></item>
            /// <item><description><para>v2: When you create an ECS instance from the image, you can set the metadata access mode to Security-Hardened Mode.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: v1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("ImdsSupport")]
            [Validation(Required=false)]
            public string ImdsSupport { get; set; }

            /// <summary>
            /// <para>Specifies whether the image supports NVMe. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>supported: Instances created from the image support the NVMe protocol.</para>
            /// </description></item>
            /// <item><description><para>unsupported: Instances created from the image do not support the NVMe protocol.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>supported</para>
            /// </summary>
            [NameInMap("NvmeSupport")]
            [Validation(Required=false)]
            public string NvmeSupport { get; set; }

        }

        /// <summary>
        /// <para>The name of the image. The name must be 2 to 128 characters long and start with a letter or a Chinese character. It can contain digits, periods (.), colons (:), underscores (_), and hyphens (-). The name cannot start with <c>aliyun</c> or <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageTestName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The license type. This parameter sets the licensing model for instances that are created from the image by calling the <a href="https://help.aliyun.com/document_detail/2679677.html">RunInstances</a> operation. This parameter applies only to Windows Server images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Aliyun: Uses a license provided by Alibaba Cloud. When you start an instance created from this image, the system attempts to automatically connect to the Alibaba Cloud KMS server for activation. The fees for the instance include the cost of the Windows Server license.</para>
        /// </description></item>
        /// <item><description><para>BYOL: Bring Your Own License. When you start an instance created from this image, Alibaba Cloud does not provide activation. You must use your own license key to manually activate the operating system. The fees for the instance do not include the cost of the Windows Server license.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Aliyun.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BYOL</para>
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// <para>The operating system type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>windows</c>: You must also set the <c>LicenseType</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><c>linux</c></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: linux.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The operating system distribution. Valid values:</para>
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
        /// <item><description><para>Other Windows</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Others Linux.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The ID of the region where the source custom image is located. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the imported image belongs.</para>
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
        /// <para>The name of the RAM role used to import the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunECSImageImportDefaultRole</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the CloudBox, which uniquely identifies the cloud storage location.</para>
        /// <remarks>
        /// <para>You must specify this parameter only when you import an image file from OSS ON CloudBox. If you do not use OSS ON CloudBox, do not specify this parameter. For more information, see <a href="https://help.aliyun.com/document_detail/430190.html">What is OSS ON CloudBox?</a>.</para>
        /// </remarks>
        /// <para>The ARN must be in the <c>arn:acs:cloudbox:{RegionId}:{AliUid}:cloudbox/{CloudBoxId}</c> format. Replace <c>{RegionId}</c> with the ID of the region where the CloudBox is located, <c>{AliUid}</c> with the ID of your Alibaba Cloud account, and <c>{CloudBoxId}</c> with the ID of the CloudBox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:acs:cloudbox:cn-hangzhou:123456:cloudbox/cb-xx***123</para>
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// <para>The tags to add to the image.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ImportImageRequestTag> Tag { get; set; }
        public class ImportImageRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters long and cannot start with <c>aliyun</c> or <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters long, cannot start with <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
