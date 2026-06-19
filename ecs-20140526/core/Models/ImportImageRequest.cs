// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ImportImageRequest : TeaModel {
        /// <summary>
        /// <para>The system architecture. Valid values: </para>
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
        /// </list>
        /// <para>Default value: BIOS. If <c>Architecture=arm64</c>, the default value is UEFI, and only UEFI is supported.</para>
        /// <notice>
        /// 
        /// <para>To prevent instances from failing to start due to an unsupported boot mode, make sure that you understand the boot mode supported by the target image before you set this parameter. For more information about image boot modes, see <a href="~~2244655#b9caa9b8bb1wf~~">Image boot modes</a>.</para>
        /// <para></notice>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the image. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image detection strategy. If this parameter is not specified, detection is not triggered. Only the Standard detection mode is supported.</para>
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
        /// <para>The information list of the custom image to create.</para>
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<ImportImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class ImportImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// <para>The device name of DiskDeviceMapping.N.Device in the custom image.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated. For better compatibility, do not use this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The size of the custom image. Unit: GiB.</para>
            /// <para>The size includes the system disk and data disks. Make sure that the system disk space is greater than or equal to the size of the imported image file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When N is 1, the value specifies the system disk size. Valid values: 1 to 2048.</description></item>
            /// <item><description>When N is 2 to 17, the value specifies the data disk size. Valid values: 1 to 2048.</description></item>
            /// </list>
            /// <para>After you upload the source image file to OSS, you can view the image file size in the OSS bucket.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated. For better compatibility, use <c>DiskDeviceMapping.N.DiskImageSize</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DiskImSize")]
            [Validation(Required=false)]
            public int? DiskImSize { get; set; }

            /// <summary>
            /// <para>The size of the custom image after the image is imported.</para>
            /// <para>The size includes the system disk and data disks. Make sure that the system disk space is greater than or equal to the size of the imported image file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When N is 1, the value specifies the system disk size. Valid values: 1 to 2048. Unit: GiB.</description></item>
            /// <item><description>When N is 2 to 17, the value specifies the data disk size. Valid values: 1 to 2048. Unit: GiB.</description></item>
            /// </list>
            /// <para>After you upload the source image file to OSS, you can view the image file size in the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DiskImageSize")]
            [Validation(Required=false)]
            public int? DiskImageSize { get; set; }

            /// <summary>
            /// <para>The image format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RAW.</description></item>
            /// <item><description>VHD.</description></item>
            /// <item><description>QCOW2.</description></item>
            /// <item><description>VMDK (in invitational preview).</description></item>
            /// </list>
            /// <para>Default value: null, which indicates that Alibaba Cloud automatically detects the image format. The detected format prevails.</para>
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
            /// <para>Before you import an image to this OSS bucket for the first time, add the RAM authorization policy as described in the <b>Operation description</b> section of this topic. Otherwise, the <c>NoSetRoletoECSServiceAccount</c> error is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecsimageos</para>
            /// </summary>
            [NameInMap("OSSBucket")]
            [Validation(Required=false)]
            public string OSSBucket { get; set; }

            /// <summary>
            /// <para>The file name (key) of the image file stored in the OSS bucket after the image is uploaded to OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS_5.4_32.raw</para>
            /// </summary>
            [NameInMap("OSSObject")]
            [Validation(Required=false)]
            public string OSSObject { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including invalid AccessKey pairs, unauthorized RAM users, and missing parameter values. If the request fails the dry run, the corresponding error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false: performs a dry run and sends the request. If the request passes the dry run, a 2XX HTTP status code is returned and the resource status is queried.</description></item>
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
        /// <para>The image feature-related properties.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public ImportImageRequestFeatures Features { get; set; }
        public class ImportImageRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The metadata access mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>v1: When you create an ECS instance from this image, you cannot set the metadata access mode to hardened mode only.</description></item>
            /// <item><description>v2: When you create an ECS instance from this image, you can set the metadata access mode to hardened mode only.</description></item>
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
            /// <item><description>supported: Instances created from this image support NVMe.</description></item>
            /// <item><description>unsupported: Instances created from this image do not support NVMe.</description></item>
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
        /// <para>The name of the image. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. It can contain digits, periods (.), colons (:), underscores (_), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageTestName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The license type. This parameter specifies the authorization mode when instances are created by calling <a href="https://help.aliyun.com/document_detail/2679677.html">RunInstances</a> with the image. This value takes effect only for Windows Server images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Aliyun: Use the Alibaba Cloud official license. After the instance starts, the system attempts to automatically connect to the Alibaba Cloud KMS server for activation. The billing for the instance includes the Windows Server license fee.</description></item>
        /// <item><description>BYOL: Bring Your Own License. After the instance starts, Alibaba Cloud does not automatically activate it. You must manually activate it by using your own valid license key. The billing for the instance does not include the Windows Server license fee.</description></item>
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
        /// <para>The operating system type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>windows. You must also set <c>LicenseType</c>.</description></item>
        /// <item><description>linux.</description></item>
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
        /// <para>The operating system version. Valid values: </para>
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
        /// <item><description>Other Windows</description></item>
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
        /// <para>The region ID of the source custom image. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the imported image belongs.</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the CloudBox, which is used to uniquely identify the cloud storage location.</para>
        /// <remarks>
        /// <para>You need to specify this parameter only when you import an image file from OSS on CloudBox. If you do not use OSS on CloudBox, do not set this parameter. For more information, see <a href="https://help.aliyun.com/document_detail/430190.html">What is OSS on CloudBox</a>.</para>
        /// </remarks>
        /// <para>The ARN must follow this format: <c>arn:acs:cloudbox:{RegionId}:{AliUid}:cloudbox/{CloudBoxId}</c>, where <c>{RegionId}</c> is the region ID of the CloudBox, <c>{AliUid}</c> is the Alibaba Cloud account ID, and <c>{CloudBoxId}</c> is the CloudBox ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:acs:cloudbox:cn-hangzhou:123456:cloudbox/cb-xx***123</para>
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// <para>The tags of the image.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ImportImageRequestTag> Tag { get; set; }
        public class ImportImageRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the image tag. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the image tag. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
