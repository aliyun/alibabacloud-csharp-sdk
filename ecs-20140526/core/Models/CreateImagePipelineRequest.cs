// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImagePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID for image sharing of the destination image. Valid values of N: 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<long?> AddAccount { get; set; }

        /// <summary>
        /// <para>The advanced settings.</para>
        /// </summary>
        [NameInMap("AdvancedOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestAdvancedOptions AdvancedOptions { get; set; }
        public class CreateImagePipelineRequestAdvancedOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to disable the automatic addition of a suffix to the destination image name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disable: disables the automatic addition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("ImageNameSuffix")]
            [Validation(Required=false)]
            public string ImageNameSuffix { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain Cloud Assistant. During the build process, the system automatically installs Cloud Assistant on the intermediate instance to execute commands. You can choose whether to retain it in the built destination image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: retains Cloud Assistant.</description></item>
            /// <item><description>false: does not retain Cloud Assistant.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>This setting does not affect the Cloud Assistant that is pre-installed in your image.</para>
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
        /// <item><description>If BaseImageType is set to IMAGE, set this parameter to the image ID.</description></item>
        /// <item><description>If BaseImageType is set to IMAGE_FAMILY, set this parameter to the image family name.</description></item>
        /// <item><description>If BaseImageType is set to OSS, you do not need to specify this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("BaseImage")]
        [Validation(Required=false)]
        public string BaseImage { get; set; }

        /// <summary>
        /// <para>The source image type. Valid values:</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the intermediate instance if the image build fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the instance.</description></item>
        /// <item><description>false: does not release the instance.</description></item>
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
        /// <para>The properties of the destination image.</para>
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
            /// <para>The target image family. The value must be 2 to 128 characters in length. It must start with a letter or a Chinese character, and cannot start with aliyun or acs:. It cannot contain http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>family</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The properties related to destination image features.</para>
            /// </summary>
            [NameInMap("ImageFeatures")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImageOptionsImageFeatures ImageFeatures { get; set; }
            public class CreateImagePipelineRequestImageOptionsImageFeatures : TeaModel {
                /// <summary>
                /// <para>Specifies whether the built destination image supports NVMe. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>supported: supported. This indicates that instances created from this image support the NVMe protocol.</description></item>
                /// <item><description>unsupported: not supported. This indicates that instances created from this image do not support the NVMe protocol.</description></item>
                /// <item><description>auto: automatic detection. The system automatically detects whether the NVMe driver is installed in your image. This detection occurs before the build phase. If you install or uninstall the NVMe driver during the build, the detection result may be inaccurate. We recommend that you set this parameter to supported or unsupported based on the build content.</description></item>
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
            /// <para>The prefix of the target image name. The prefix must be 2 to 64 characters in length and must start with a letter or a Chinese character. It cannot start with http:// or https://. It can contain letters, Chinese characters, digits, colons (:), underscores (<em>), periods (.), and hyphens (-). The system automatically generates the final image name by concatenating the prefix and the build task ID (ExecutionId) in the {ImageName}</em>{ExecutionId} format.</para>
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
                /// <para>The tag key. Valid values of N: 1 to 20. If this parameter is specified, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. Valid values of N: 1 to 20. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The properties and settings of the imported image. This parameter is required when BaseImageType is set to OSS.</para>
        /// </summary>
        [NameInMap("ImportImageOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestImportImageOptions ImportImageOptions { get; set; }
        public class CreateImagePipelineRequestImportImageOptions : TeaModel {
            /// <summary>
            /// <para>The system architecture of the system disk. After you specify a data disk snapshot to create a system disk, you must use Architecture to determine the system architecture of the system disk. Valid values:</para>
            /// <list type="bullet">
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
            /// <item><description>BIOS: BIOS boot mode.</description></item>
            /// <item><description>UEFI: UEFI boot mode.</description></item>
            /// </list>
            /// <para>Default value: BIOS. If Architecture is set to arm64, the default value is UEFI, and you can only set this parameter to UEFI.</para>
            /// <notice>
            /// 
            /// <para>To prevent instances from failing to start due to unsupported boot modes, make sure that you understand the boot modes supported by the destination image before you specify this parameter. For more information about image boot modes, see <a href="~~2244655#b9caa9b8bb1wf~~">Image boot modes</a>.</para>
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
            /// <para>The list of custom image information to be created.</para>
            /// <list type="bullet">
            /// <item><description>If N is set to 1, it indicates the system disk.</description></item>
            /// <item><description>If N is set to 2 to 17, it indicates data disks.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings> DiskDeviceMappings { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings : TeaModel {
                /// <summary>
                /// <para>The size of the custom image after the image is imported.</para>
                /// <para>The space consists of the system disk and data disks. You must ensure that the size of the system disk is greater than or equal to the size of the imported image file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>If N is set to 1, it indicates the system disk. Valid values: 1 to 2048. Unit: GiB.</description></item>
                /// <item><description>If N is set to 2 to 17, it indicates data disks. Valid values: 1 to 2048. Unit: GiB.</description></item>
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
                /// <item><description>RAW</description></item>
                /// <item><description>VHD</description></item>
                /// <item><description>QCOW2</description></item>
                /// </list>
                /// <para>Default value: none. This indicates that Alibaba Cloud automatically detects the image format, and the detected format prevails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RAW</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The OSS bucket where the image file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecsimageos</para>
                /// </summary>
                [NameInMap("OSSBucket")]
                [Validation(Required=false)]
                public string OSSBucket { get; set; }

                /// <summary>
                /// <para>The name (key) of the image file saved in the OSS bucket after the image is uploaded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_5.4_32.raw</para>
                /// </summary>
                [NameInMap("OSSObject")]
                [Validation(Required=false)]
                public string OSSObject { get; set; }

            }

            /// <summary>
            /// <para>The properties related to image features.</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImportImageOptionsFeatures Features { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsFeatures : TeaModel {
                /// <summary>
                /// <para>The metadata access mode of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>v1: When you create an ECS instance from this image, you cannot set the metadata access mode to &quot;Reinforced mode only&quot;.</para>
                /// </description></item>
                /// <item><description><para>v2: When you create an ECS instance from this image, you can set the metadata access mode to &quot;Reinforced mode only&quot;.</para>
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
                /// <item><description>supported: supported. This indicates that instances created from this image support the NVMe protocol.</description></item>
                /// <item><description>unsupported: not supported. This indicates that instances created from this image do not support the NVMe protocol.</description></item>
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
            /// <para>The list of tags for the image.</para>
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
            /// <item><description>Auto: Alibaba Cloud detects the source operating system and assigns a license. In auto mode, the system first checks whether the Platform you specified has a license from official Alibaba Cloud channels and assigns it to the imported image. If no such license is available, the system switches to the Bring Your Own License (BYOL) method.</description></item>
            /// <item><description>Aliyun: uses a license from official Alibaba Cloud channels based on the Platform you specified.</description></item>
            /// <item><description>BYOL: uses the license provided by the source operating system. If you use BYOL, you must ensure that your license key is supported on Alibaba Cloud.</description></item>
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
            /// <para>Default value: Others Linux if the operating system type is Linux, or Other Windows if the operating system type is Windows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <notice>
            /// **[Deprecated]** Use ImportImageOptions.RetentionStrategy instead.
            /// </notice>
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
            /// <item><description>RetainOnlySuccessful: retains the image only if the build succeeds.</description></item>
            /// <item><description>RetainOnlyFailed: retains the image only if the build fails.</description></item>
            /// <item><description>RetainAlways: always retains the image regardless of the build result.</description></item>
            /// <item><description>RetainNever: never retains the image regardless of the build result.</description></item>
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
            /// <para>The name of the RAM role used when the image is imported.</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>The instance type. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query available instance types.</para>
        /// <para>If you do not specify this parameter, the system automatically selects an instance type with the minimum number of vCPUs and memory size based on resource availability. For example, the system selects the ecs.g6.large instance type by default. If ecs.g6.large is out of stock, the system selects ecs.g6.xlarge.</para>
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
        /// <para>The template name. It must be 2 to 128 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, Chinese characters, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para>If you do not specify <c>Name</c>, the value of <c>ImagePipelineId</c> is used by default.</para>
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
        /// <para>Specifies whether the built destination image supports NVMe.
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <item><description>Repair items supported by Linux:<list type="bullet">
        /// <item><description>fstab: fixes disk attach configuration issues.</description></item>
        /// <item><description>grub: fixes GRUB boot configuration issues.</description></item>
        /// <item><description>dhcp: fixes network DHCP issues.</description></item>
        /// <item><description>selinux: fixes Security-Enhanced Linux (SELinux) issues.</description></item>
        /// <item><description>growpart: fixes online automatic scale-out issues of the root partition.</description></item>
        /// <item><description>cloudinit: installs the cloud-init initialization service.</description></item>
        /// <item><description>aegis: installs the Security Center agent.</description></item>
        /// <item><description>nvme: fixes NVMe driver issues.</description></item>
        /// <item><description>virtio: fixes virtio driver issues.</description></item>
        /// <item><description>standardizedtimezone: fixes standard time zone issues.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Repair items supported by Windows:<list type="bullet">
        /// <item><description>bcd: fixes boot configuration data file issues.</description></item>
        /// <item><description>hotfix: fixes Windows patch issues.</description></item>
        /// <item><description>disk: fixes disk Settings issues.</description></item>
        /// <item><description>update: fixes Windows Update process issues.</description></item>
        /// <item><description>server: fixes service configuration issues.</description></item>
        /// <item><description>bootmgr: fixes Windows Boot Manager issues.</description></item>
        /// <item><description>vminit: fixes Windows initialization agent issues.</description></item>
        /// <item><description>osloader: fixes Windows OS Loader issues.</description></item>
        /// <item><description>virtio: fixes virtio driver issues.</description></item>
        /// <item><description>standardizedtimezone: fixes standard time zone issues.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepairItem")]
        [Validation(Required=false)]
        public List<string> RepairItem { get; set; }

        /// <summary>
        /// <para>The repair mode in the image template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: standard repair mode.</para>
        /// <para>The standard repair package for Linux includes:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.CloudInit</description></item>
        /// <item><description>GUESTOS.Dhcp</description></item>
        /// <item><description>GUESTOS.Virtio</description></item>
        /// <item><description>GUESTOS.OnlineResizeFS</description></item>
        /// <item><description>GUESTOS.Grub</description></item>
        /// <item><description>GUESTOS.Fstab</description></item>
        /// <item><description>GUESTOS.Nvme</description></item>
        /// </list>
        /// <para>The standard repair package for Windows includes:</para>
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
        /// <para>The full repair package for Linux includes the following items in addition to those in the standard repair package:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.Selinux</description></item>
        /// <item><description>GUESTOS.SecurityCenterAgent</description></item>
        /// </list>
        /// <para>The full repair package for Windows includes the following items in addition to those in the standard repair package:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.Server</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Customized: custom repair mode. In this mode, the repair items in the repair package are specified by the RepairItem parameter.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>As the detection and repair capabilities improve, the included repair items may increase. For more information about the specific meanings of repair items, see <a href="https://help.aliyun.com/document_detail/439819.html">Image check overview</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("RepairMode")]
        [Validation(Required=false)]
        public string RepairMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImagePipelineRequestTag> Tag { get; set; }
        public class CreateImagePipelineRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20. If this parameter is specified, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The list of regions to which the destination image is distributed. Valid values of N: 1 to 20.</para>
        /// <para>If you do not specify this parameter, the image is created only in the current region by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ToRegionId")]
        [Validation(Required=false)]
        public List<string> ToRegionId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the VPC.</para>
        /// <para>If you do not specify this parameter, a new VPC and vSwitch are created by default. Make sure that your account has sufficient VPC resource quotas. For more information, see <a href="https://help.aliyun.com/document_detail/27750.html">Limits</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
