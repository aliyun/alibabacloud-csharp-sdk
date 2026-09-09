// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImagePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID to which the destination image is shared through image sharing. Valid values of N: 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<long?> AddAccount { get; set; }

        /// <summary>
        /// <para>The advanced configuration.</para>
        /// </summary>
        [NameInMap("AdvancedOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestAdvancedOptions AdvancedOptions { get; set; }
        public class CreateImagePipelineRequestAdvancedOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to disable the automatic suffix for the destination image name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disable: The automatic suffix is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("ImageNameSuffix")]
            [Validation(Required=false)]
            public string ImageNameSuffix { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain Cloud Assistant. During the build process, the system automatically installs Cloud Assistant on the intermediate instance to run commands. You can choose whether to retain Cloud Assistant in the destination image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Cloud Assistant is retained.</description></item>
            /// <item><description>false: Cloud Assistant is not retained.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>This setting does not affect Cloud Assistant that is already included in your image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RetainCloudAssistant")]
            [Validation(Required=false)]
            public bool? RetainCloudAssistant { get; set; }

        }

        /// <summary>
        /// <para>The source image.</para>
        /// <list type="bullet">
        /// <item><description>If <c>BaseImageType=IMAGE</c>, set this parameter to an image ID.</description></item>
        /// <item><description>If <c>BaseImageType=IMAGE_FAMILY</c>, set this parameter to an image family name.</description></item>
        /// <item><description>If <c>BaseImageType=OSS</c>, you do not need to set this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("BaseImage")]
        [Validation(Required=false)]
        public string BaseImage { get; set; }

        /// <summary>
        /// <para>The type of the source image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMAGE: image.</description></item>
        /// <item><description>IMAGE_FAMILY: image family.</description></item>
        /// <item><description>OSS: OSS object.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("BaseImageType")]
        [Validation(Required=false)]
        public string BaseImageType { get; set; }

        /// <summary>
        /// <para>The content of the image build template. The content size cannot exceed 16 KB. For more information about supported commands, see <a href="https://help.aliyun.com/document_detail/200206.html">Commands supported by Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPONENT ic-bp12dvdzvr9k9*****
        /// COMPONENT acs:ecs:cn-hangzhou:18689161186*****:imagecomponent/ComponentName/1.<em>.</em></para>
        /// </summary>
        [NameInMap("BuildContent")]
        [Validation(Required=false)]
        public string BuildContent { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The value of <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the intermediate instance if the image fails to be built. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The intermediate instance is released.</description></item>
        /// <item><description>false: The intermediate instance is not released.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <remarks>
        /// <para>If the intermediate instance fails to start, the instance is not retained by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteInstanceOnFailure")]
        [Validation(Required=false)]
        public bool? DeleteInstanceOnFailure { get; set; }

        /// <summary>
        /// <para>The description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The destination image family.
        /// <notice>
        /// <b>[Deprecated]</b> Use ImageOptions.ImageFamily instead.
        /// </notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>family</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageFamily { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The prefix of the destination image name.
        /// <notice>
        /// <b>[Deprecated]</b> Use ImageOptions.ImageName instead.
        /// </notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>testImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The destination image properties.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestImageOptions ImageOptions { get; set; }
        public class CreateImagePipelineRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>The description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination image family. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. The name cannot start with aliyun or acs:. The name cannot contain http:// or https://. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>family</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The feature properties of the destination image.</para>
            /// </summary>
            [NameInMap("ImageFeatures")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImageOptionsImageFeatures ImageFeatures { get; set; }
            public class CreateImagePipelineRequestImageOptionsImageFeatures : TeaModel {
                /// <summary>
                /// <para>Specifies whether the destination image supports NVMe. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>supported: Instances created from this image support the NVMe protocol.</description></item>
                /// <item><description>unsupported: Instances created from this image do not support the NVMe protocol.</description></item>
                /// <item><description>auto: The system automatically detects whether your image has the NVMe driver installed. This detection occurs before the build phase. If you install or uninstall the NVMe driver during the build, the result may be inaccurate. Set this parameter to supported or unsupported based on your build content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("NvmeSupport")]
                [Validation(Required=false)]
                public string NvmeSupport { get; set; }

            }

            /// <summary>
            /// <para>The prefix of the destination image name. The name must be 2 to 64 characters in length and must start with a letter or a Chinese character. The name cannot start with <c>http://</c> or <c>https://</c>. The name can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>The final complete image name is automatically generated by the system by concatenating the name prefix with the build task ID (<c>ExecutionId</c>) in the format of <c>{ImageName}_{ExecutionId}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testImageName</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The tags of the destination image.</para>
            /// </summary>
            [NameInMap("ImageTags")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImageOptionsImageTags> ImageTags { get; set; }
            public class CreateImagePipelineRequestImageOptionsImageTags : TeaModel {
                /// <summary>
                /// <para>The tag key. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the resource. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The properties and settings for importing an image. This parameter is required when <c>BaseImageType=OSS</c>.</para>
        /// </summary>
        [NameInMap("ImportImageOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestImportImageOptions ImportImageOptions { get; set; }
        public class CreateImagePipelineRequestImportImageOptions : TeaModel {
            /// <summary>
            /// <para>The system architecture of the system disk when a data disk snapshot is used as the image for the system disk. Valid values:</para>
            /// <list type="bullet">
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
            /// <para>Default value: BIOS. If <c>Architecture=arm64</c>, the default value is UEFI, and only UEFI can be specified.</para>
            /// <notice>
            /// 
            /// <para>To prevent instances from failing to start due to an unsupported boot mode, make sure that you understand the boot modes supported by the destination image before you set this parameter. For more information about image boot modes, see <a href="~~2244655#b9caa9b8bb1wf~~">Image boot modes</a>.</para>
            /// </notice>
            /// 
            /// <b>Example:</b>
            /// <para>BIOS</para>
            /// </summary>
            [NameInMap("BootMode")]
            [Validation(Required=false)]
            public string BootMode { get; set; }

            /// <summary>
            /// <para>The description of the imported image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The information about the custom image.</para>
            /// <list type="bullet">
            /// <item><description>When N=1, the system disk is specified.</description></item>
            /// <item><description>When N=2 to 17, data disks are specified.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings> DiskDeviceMappings { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings : TeaModel {
                /// <summary>
                /// <para>The size of the custom image after the image is imported.</para>
                /// <para>The size consists of the system disk and data disks. Make sure that the system disk size is greater than or equal to the size of the imported image file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>When N=1, the system disk is specified. Valid values: 1 GiB to 2048 GiB.</description></item>
                /// <item><description>When N=2 to 17, data disks are specified. Valid values: 1 GiB to 2048 GiB.</description></item>
                /// </list>
                /// <para>After you upload the source image file to OSS, you can view the size of the image file in the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
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
                /// </list>
                /// <para>Default value: empty, which indicates that Alibaba Cloud automatically detects the image format. The detected format prevails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RAW</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The OSS bucket in which the image file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecsimageos</para>
                /// </summary>
                [NameInMap("OSSBucket")]
                [Validation(Required=false)]
                public string OSSBucket { get; set; }

                /// <summary>
                /// <para>The name (key) of the image file that is stored in the OSS bucket after the image is uploaded to OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_5.4_32.raw</para>
                /// </summary>
                [NameInMap("OSSObject")]
                [Validation(Required=false)]
                public string OSSObject { get; set; }

            }

            /// <summary>
            /// <para>The image feature properties.</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImportImageOptionsFeatures Features { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsFeatures : TeaModel {
                /// <summary>
                /// <para>The metadata access mode of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>v1: When you create an ECS instance from this image, you cannot set the metadata access mode to &quot;hardened mode only&quot;.</para>
                /// </description></item>
                /// <item><description><para>v2: When you create an ECS instance from this image, you can set the metadata access mode to &quot;hardened mode only&quot;.</para>
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
                /// <para>Specifies whether the imported original image supports NVMe. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>supported: Instances created from this image support the NVMe protocol.</description></item>
                /// <item><description>unsupported: Instances created from this image do not support the NVMe protocol.</description></item>
                /// </list>
                /// <para>Default value: unsupported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>supported</para>
                /// </summary>
                [NameInMap("NvmeSupport")]
                [Validation(Required=false)]
                public string NvmeSupport { get; set; }

            }

            /// <summary>
            /// <para>The name of the imported image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testImageName</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The tags of the image.</para>
            /// </summary>
            [NameInMap("ImportImageTags")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImportImageOptionsImportImageTags> ImportImageTags { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsImportImageTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The license type used to activate the operating system after the image is imported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto: Alibaba Cloud detects the source operating system and assigns a license. In Auto mode, the system first searches for a license from an official Alibaba Cloud channel based on the <c>Platform</c> you specified and assigns it to the imported image. If no such license is available, the system switches to the BYOL (Bring Your Own License) method.</description></item>
            /// <item><description>Aliyun: A license from an official Alibaba Cloud channel is used based on the <c>Platform</c> you specified.</description></item>
            /// <item><description>BYOL: The license that comes with the source operating system is used. When you use BYOL, make sure that your license key supports use on Alibaba Cloud.</description></item>
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
            /// <para>The operating system type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows.</description></item>
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

            /// <summary>
            /// <para>The operating system version. Valid values:</para>
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
            /// <para>Default value: Others Linux when the operating system type is Linux. Otherwise, the default value is Other Windows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Use ImportImageOptions.RetentionStrategy instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RetainImportedImage")]
            [Validation(Required=false)]
            public bool? RetainImportedImage { get; set; }

            /// <summary>
            /// <para>The data retention policy for the imported image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RetainOnlySuccessful: The image is retained only if the build succeeds.</para>
            /// </description></item>
            /// <item><description><para>RetainOnlyFailed: The image is retained only if the build fails.</para>
            /// </description></item>
            /// <item><description><para>RetainAlways: The image is always retained regardless of the build result.</para>
            /// </description></item>
            /// <item><description><para>RetainNever: The image is never retained regardless of the build result.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: RetainNever.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RetainAlways</para>
            /// </summary>
            [NameInMap("RetentionStrategy")]
            [Validation(Required=false)]
            public string RetentionStrategy { get; set; }

            /// <summary>
            /// <para>The name of the RAM role used to import the image.</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>The instance type. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query different instance types.</para>
        /// <para>If you do not specify this parameter, the instance type is automatically set based on the principle of minimum vCPUs and memory, subject to the inventory of the instance type. For example, the ecs.g6.large instance type is selected by default. If the inventory is insufficient, the ecs.g6.xlarge instance type is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The outbound public bandwidth of the intermediate instance. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The template name. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. The name cannot start with <c>http://</c> or <c>https://</c>. The name can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para>If you do not specify <c>Name</c>, the return value of <c>ImagePipelineId</c> is used by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testImagePipeline</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether the destination image supports NVMe.
        /// <notice>
        /// <b>[Deprecated]</b> Use ImageOptions.ImageFeatures.NvmeSupport instead.
        /// </notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("NvmeSupport")]
        [Validation(Required=false)]
        [Obsolete]
        public string NvmeSupport { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The image repair items.</para>
        /// <list type="bullet">
        /// <item><description>Repair items supported for Linux:<list type="bullet">
        /// <item><description>fstab: repairs disk mount configuration issues.</description></item>
        /// <item><description>grub: repairs GRUB boot configuration issues.</description></item>
        /// <item><description>dhcp: repairs network DHCP issues.</description></item>
        /// <item><description>selinux: repairs Security-Enhanced Linux issues.</description></item>
        /// <item><description>growpart: repairs root partition online auto-expansion issues.</description></item>
        /// <item><description>cloudinit: installs the cloud-init initialization service.</description></item>
        /// <item><description>aegis: installs the China Cloud Security Center Agent service.</description></item>
        /// <item><description>nvme: repairs NVMe driver issues.</description></item>
        /// <item><description>virtio: repairs virtio driver issues.</description></item>
        /// <item><description>standardizedtimezone: repairs standardized time zone issues.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Repair items supported for Windows:<list type="bullet">
        /// <item><description>bcd: repairs boot configuration data file issues.</description></item>
        /// <item><description>hotfix: repairs Windows patch issues.</description></item>
        /// <item><description>disk: repairs disk setting issues.</description></item>
        /// <item><description>update: repairs Update process issues.</description></item>
        /// <item><description>server: repairs service configuration issues.</description></item>
        /// <item><description>bootmgr: repairs Windows Boot Manager issues.</description></item>
        /// <item><description>vminit: repairs Windows initialization Agent issues.</description></item>
        /// <item><description>osloader: repairs Windows OS Loader issues.</description></item>
        /// <item><description>virtio: repairs virtio driver issues.</description></item>
        /// <item><description>standardizedtimezone: repairs standardized time zone issues.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepairItem")]
        [Validation(Required=false)]
        public List<string> RepairItem { get; set; }

        /// <summary>
        /// <para>The repair option in the image template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: standard repair mode.</para>
        /// <para>The standard repair package for Linux includes the following items:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.CloudInit</description></item>
        /// <item><description>GUESTOS.Dhcp</description></item>
        /// <item><description>GUESTOS.Virtio</description></item>
        /// <item><description>GUESTOS.OnlineResizeFS</description></item>
        /// <item><description>GUESTOS.Grub</description></item>
        /// <item><description>GUESTOS.Fstab</description></item>
        /// <item><description>GUESTOS.Nvme</description></item>
        /// </list>
        /// <para>The standard repair package for Windows includes the following items:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.Virtio</description></item>
        /// <item><description>GUESTOS.Update</description></item>
        /// <item><description>GUESTOS.Hotfix</description></item>
        /// <item><description>GUESTOS.Server</description></item>
        /// <item><description>GUESTOS.Bcd</description></item>
        /// <item><description>GUESTOS.Disk</description></item>
        /// <item><description>GUESTOS.Bootmgr</description></item>
        /// <item><description>GUESTOS.OSLoader</description></item>
        /// <item><description>GUESTOS.Vminit</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>All: full repair mode.</para>
        /// <para>The full repair package for Linux includes all items in the standard repair package, plus the following items:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.Selinux</description></item>
        /// <item><description>GUESTOS.SecurityCenterAgent</description></item>
        /// </list>
        /// <para>The full repair package for Windows includes all items in the standard repair package, plus the following item:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.Server</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Customized: custom repair mode. In this mode, the repair items in the repair package are specified by the RepairItem parameter.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>As detection and repair capabilities continue to improve, the included repair items may increase. For more information about the specific meaning of each repair item, see <a href="https://help.aliyun.com/document_detail/439819.html">Overview of image detection</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("RepairMode")]
        [Validation(Required=false)]
        public string RepairMode { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group.</para>
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
        /// <para>The system disk size of the intermediate instance. Unit: GiB. Valid values: 20 to 500.</para>
        /// <para>Default value: 40.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImagePipelineRequestTag> Tag { get; set; }
        public class CreateImagePipelineRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The content of the image test template. The content size cannot exceed 16 KB. For more information about supported commands, see <a href="https://help.aliyun.com/document_detail/200206.html">Commands supported by Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPONENT ic-bp12dvdzvr9k9*****
        /// COMPONENT acs:ecs:cn-hangzhou:18689161186*****:imagecomponent/ComponentName/1.<em>.</em></para>
        /// </summary>
        [NameInMap("TestContent")]
        [Validation(Required=false)]
        public string TestContent { get; set; }

        /// <summary>
        /// <para>The regions to which to distribute the destination image. Valid values of N: 1 to 20.</para>
        /// <para>If you do not specify this parameter, the image is created only in the current region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ToRegionId")]
        [Validation(Required=false)]
        public List<string> ToRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the VPC.</para>
        /// <para>If you do not specify this parameter, a new VPC and vSwitch are created by default. Make sure that the VPC resource quota in your account is sufficient. For more information, see <a href="https://help.aliyun.com/document_detail/27750.html">Limits</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
