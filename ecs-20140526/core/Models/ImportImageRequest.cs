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
        /// <item><description>BIOS</description></item>
        /// <item><description>UEFI</description></item>
        /// </list>
        /// <para>Default value: BIOS. If you set <c>Architecture</c> to arm64, set this parameter to UEFI.</para>
        /// <remarks>
        /// <para>Make sure that you are aware of the boot modes supported by the specified image, as thehe modified boot mode needs to be supported by the image. This way, instances that use this image can start.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. <b>The token can contain only ASCII characters and cannot exceed 64 characters in length.</b> For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The image description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The mode in which to check the image. If you do not specify this parameter, the image is not checked. Only the standard check mode is supported.</para>
        /// <remarks>
        /// <para> This parameter is supported for most Linux and Windows operating system versions. For more information about image check items and operating system limits for image check, see <a href="https://help.aliyun.com/document_detail/439819.html">Overview</a> and <a href="https://help.aliyun.com/document_detail/475800.html">Operating system limits for image check</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("DetectionStrategy")]
        [Validation(Required=false)]
        public string DetectionStrategy { get; set; }

        /// <summary>
        /// <para>Details about the custom images.</para>
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<ImportImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class ImportImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// <para>The device name of disk N in the custom image.</para>
            /// <remarks>
            /// <para> This parameter will be removed in the future. We recommend that you do not use this parameter to ensure future compatibility.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The size of disk N in the custom image. Unit: GiB.</para>
            /// <para>You can use this parameter to specify the sizes of the system disk and data disks in the custom image. When you specify the size of the system disk, make sure that the specified size is greater than or equal to the size of the imported image file. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When the N value is 1, this parameter specifies the size of the system disk in the custom image. Valid values: 1 to 2048.</description></item>
            /// <item><description>When the N value is an integer in the range of 2 to 17, this parameter specifies the size of a data disk in the custom image. Valid values: 1 to 2048.</description></item>
            /// </list>
            /// <para>After the image file is uploaded to an OSS bucket, you can view the size of the image file in the OSS bucket.</para>
            /// <remarks>
            /// <para> This parameter will be removed in the future. We recommend that you use <c>DiskDeviceMapping.N.DiskImageSize</c> to ensure future compatibility.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DiskImSize")]
            [Validation(Required=false)]
            public int? DiskImSize { get; set; }

            /// <summary>
            /// <para>The size of disk N in the custom image after the source image is imported.</para>
            /// <para>You can use this parameter to specify the sizes of the system disk and data disks in the custom image. When you specify the size of the system disk, make sure that the specified size is greater than or equal to the size of the imported image file. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When the N value is 1, this parameter specifies the size of the system disk in the custom image. Valid values: 1 to 2048.</description></item>
            /// <item><description>When the N value is an integer in the range of 2 to 17, this parameter specifies the size of a data disk in the custom image. Valid values: 1 to 2048.</description></item>
            /// </list>
            /// <para>After the image file is uploaded to an OSS bucket, you can view the size of the image file in the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DiskImageSize")]
            [Validation(Required=false)]
            public int? DiskImageSize { get; set; }

            /// <summary>
            /// <para>The format of the source image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RAW</description></item>
            /// <item><description>VHD</description></item>
            /// <item><description>QCOW2</description></item>
            /// <item><description>VMDK (invitational preview)</description></item>
            /// </list>
            /// <para>This parameter is empty by default, which indicates that the system checks the image format and uses the check result as the value of this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QCOW2</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) bucket where the image file is stored.</para>
            /// <remarks>
            /// <para> Before you import images for the first time, you must use RAM to authorize ECS to access your OSS buckets. If ECS is not authorized to access your OSS buckets, the <c>NoSetRoletoECSServiceAcount</c> error code is returned when you call the ImportImage operation. For more information, see <b>Usage notes</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecsimageos</para>
            /// </summary>
            [NameInMap("OSSBucket")]
            [Validation(Required=false)]
            public string OSSBucket { get; set; }

            /// <summary>
            /// <para>The name (key) of the object that the image file is stored as in the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS_5.4_32.raw</para>
            /// </summary>
            [NameInMap("OSSObject")]
            [Validation(Required=false)]
            public string OSSObject { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including invalid AccessKey pairs, unauthorized RAM users, and missing parameter values. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
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
        /// <para>The attributes of the image.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public ImportImageRequestFeatures Features { get; set; }
        public class ImportImageRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The metadata access mode version of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>v1: You cannot set the metadata access mode to security hardening when you create instances from the image.</description></item>
            /// <item><description>v2: You can set the metadata access mode to security hardening when you create instances from the image.</description></item>
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
            /// <para>Specifies whether the image supports the Non-Volatile Memory Express (NVMe) protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>supported: The image supports the NVMe protocol. Instances created from the image also support the NVMe protocol.</description></item>
            /// <item><description>unsupported: The image does not support the NVMe protocol. Instances created from the image do not support the NVMe protocol.</description></item>
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
        /// <para>The image name. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>acs:</c> or <c>aliyun</c>. The name cannot contain <c>http://</c> or <c>https://</c>. The name can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageTestName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The type of the license used to activate the operating system after the image is imported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Auto: ECS checks the operating system of the image and allocates a license to the operating system. ECS first checks whether the operating system distribution specified by <c>Platform</c> has a license allocated through an official Alibaba Cloud channel. If yes, the allocated license is used. If no, the license that comes with the source operating system is used.</description></item>
        /// <item><description>Aliyun: The license allocated through an official Alibaba Cloud channel is used for the operating system distribution specified by <c>Platform</c>.</description></item>
        /// <item><description>BYOL: The license that comes with the source operating system is used. In this case, make sure that your license key is eligible for use in Alibaba Cloud.</description></item>
        /// </list>
        /// <para>Default value: Auto.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// <para>The operating system platform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>windows</description></item>
        /// <item><description>linux</description></item>
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
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The region ID of the source image. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the image.</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the cloud box, which is used to uniquely identify a storage location in the cloud.</para>
        /// <remarks>
        /// <para> Specify this parameter only if you import an image from OSS on CloudBox. Otherwise, you do not need to specify this parameter. For more information, see <a href="https://help.aliyun.com/document_detail/430190.html">What is OSS on CloudBox?</a></para>
        /// </remarks>
        /// <para>The ARN must be in the following format: <c>arn:acs:cloudbox:{RegionId}:{AliUid}:cloudbox/{CloudBoxId}</c>. Replace <c>{RegionId}</c> with the region ID of the cloud box, <c>{AliUid}</c> with the ID of the Alibaba Cloud account to which the cloud box belongs, and <c>{CloudBoxId}</c> with the ID of the cloud box.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:acs:cloudbox:cn-hangzhou:123456:cloudbox/cb-xx***123</para>
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// <para>The image tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ImportImageRequestTag> Tag { get; set; }
        public class ImportImageRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the image. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the image. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>acs:</c>.</para>
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
