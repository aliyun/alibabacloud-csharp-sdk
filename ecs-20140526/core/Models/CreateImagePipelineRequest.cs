// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImagePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of Alibaba Cloud accounts to which to share the image that will be created based on the image template. You can specify up to 20 account IDs.</para>
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
            /// <para>Specifies whether to disable the feature that automatically adds a suffix to the name of the image created based on the image template. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>disable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("ImageNameSuffix")]
            [Validation(Required=false)]
            public string ImageNameSuffix { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain Cloud Assistant Agent that is installed during the image building process. During the image building process, the system automatically installs Cloud Assistant Agent on the intermediate instance to run commands. You can choose whether to retain Cloud Assistant Agent that is installed during the image building process in the new image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para> The setting of this parameter does not affect Cloud Assistant Agent that comes with your image.</para>
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
        /// <item><description>If you set <c>BaseImageType</c> to IMAGE, set BaseImage to the ID of a custom image.</description></item>
        /// <item><description>If you set <c>BaseImageType</c> to IMAGE_FAMILY, set BaseImage to the name of an image family.</description></item>
        /// <item><description>If you set <c>BaseImageType</c> to OSS, you do not need to specify BaseImage.</description></item>
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
        /// <item><description>IMAGE: image</description></item>
        /// <item><description>IMAGE_FAMILY: image family</description></item>
        /// <item><description>OSS: Object Storage Service (OSS) object</description></item>
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
        /// <para>The build content in the image template. The content cannot exceed 16 KB in size. For information about the commands supported by Image Builder, see <a href="https://help.aliyun.com/document_detail/200206.html">Commands supported by Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FROM IMAGE:m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("BuildContent")]
        [Validation(Required=false)]
        public string BuildContent { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.**** For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the intermediate instance when the image cannot be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <remarks>
        /// <para>If the intermediate instance cannot be started, the instance is released by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteInstanceOnFailure")]
        [Validation(Required=false)]
        public bool? DeleteInstanceOnFailure { get; set; }

        /// <summary>
        /// <para>The description of the image template. The description must be 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The family of the image created based on the image template.</para>
        /// <remarks>
        /// <para> This parameter is no longer used. We recommend that you use ImageOptions.ImageFamily.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageFamily { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The name prefix of the image created based on the image template.</para>
        /// <remarks>
        /// <para> This parameter is no longer used. We recommend that you use ImageOptions.ImageName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The attributes of the image created based on the image template.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestImageOptions ImageOptions { get; set; }
        public class CreateImagePipelineRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>The description of the image. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The image family. The image family name must be 2 to 128 characters in length. The name must start with a letter and cannot start with acs: or aliyun. The name cannot contain http:// or https:// and can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>family</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The feature attributes of the image.</para>
            /// </summary>
            [NameInMap("ImageFeatures")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImageOptionsImageFeatures ImageFeatures { get; set; }
            public class CreateImagePipelineRequestImageOptionsImageFeatures : TeaModel {
                /// <summary>
                /// <para>Specifies whether the image created based on the image template supports the NVMe protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>supported: The image supports the NVMe protocol. Instances created from the image also support the NVMe protocol.</description></item>
                /// <item><description>unsupported: The image does not support the NVMe protocol. Instances created from the image do not support the NVMe protocol.</description></item>
                /// <item><description>auto: The system automatically detects whether the image supports the NVMe protocol. The system automatically detects whether the NVMe driver is installed on your image before the new image is built. If you install or uninstall the NVMe driver during the image building process, the detection result may be incorrect. We recommend that you set the value to supported or unsupported based on the image building content.</description></item>
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
            /// <para>The prefix of the image name. The prefix must be 2 to 64 characters in length. The prefix must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The prefix can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>The system generates the final image name that consists of the specified prefix and the ID of the build task (<c>ExecutionId</c>) in the format of <c>{ImageName}_{ExecutionId}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testImageName</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The tags to add to the image.</para>
            /// </summary>
            [NameInMap("ImageTags")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImageOptionsImageTags> ImageTags { get; set; }
            public class CreateImagePipelineRequestImageOptionsImageTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N to add to the image. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N to add to the image. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The attributes and settings of the image that you want to import. If you set <c>BaseImageType</c> to OSS, you must specify this parameter.</para>
        /// </summary>
        [NameInMap("ImportImageOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestImportImageOptions ImportImageOptions { get; set; }
        public class CreateImagePipelineRequestImportImageOptions : TeaModel {
            /// <summary>
            /// <para>The system architecture of the system disk. If you specify a data disk snapshot to create the system disk of the image, use Architecture to specify the system architecture of the system disk. Valid values:</para>
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
            /// <para>The new boot mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BIOS: BIOS mode</description></item>
            /// <item><description>UEFI: Unified Extensible Firmware Interface (UEFI) mode</description></item>
            /// </list>
            /// <para>Default value: BIOS. If you set Architecture to <c>arm64</c>, set this parameter to UEFI.</para>
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

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The information of disks from which the custom images are created.</para>
            /// <list type="bullet">
            /// <item><description>When the N value is 1, this parameter creates a custom image from the system disk.</description></item>
            /// <item><description>When the N value is an integer in the range of 2 to 17, this parameter creates a custom image from a data disk.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings> DiskDeviceMappings { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings : TeaModel {
                /// <summary>
                /// <para>The size of disk N in the custom image after the source image is imported.</para>
                /// <para>You can use this parameter to specify the sizes of the system disk and data disks in the custom image. When you specify the size of the system disk, make sure that the specified size is greater than or equal to the size of the source image file. Unit: GiB. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>When the N value is 1, this parameter specifies the size of the system disk in the custom image. Valid values: 1 to 2048.</description></item>
                /// <item><description>When the N value is an integer in the range of 2 to 17, this parameter creates a custom image from a data disk. Valid values: 1 to 2048.</description></item>
                /// </list>
                /// <para>After the image file is uploaded to an OSS bucket, you can view the size of the image file in the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
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
                /// </list>
                /// <para>This parameter is empty by default, which indicates that the system checks the format of the image and uses the check result as the value of this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RAW</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The Object Storage Service (OSS) bucket where the image file is stored.</para>
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
            /// <para>The attributes of the image.</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImportImageOptionsFeatures Features { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsFeatures : TeaModel {
                [NameInMap("ImdsSupport")]
                [Validation(Required=false)]
                public string ImdsSupport { get; set; }

                /// <summary>
                /// <para>Specifies whether the imported source image supports the Non-Volatile Memory Express (NVMe) protocol. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>supported Instances created from the image also support the NVMe protocol.</description></item>
                /// <item><description>unsupported Instances created from the image do not support the NVMe protocol.</description></item>
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

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ImportImageTags")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImportImageOptionsImportImageTags> ImportImageTags { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsImportImageTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the license to use to activate the operating system after the image is imported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto: ECS detects the operating system of the image and allocates a license to the operating system. In this mode, the system first checks whether a license allocated by an official Alibaba Cloud channel is available for the operating system version specified by <c>Platform</c>. If a license allocated by an official Alibaba Cloud channel is available for the operating system version, the system allocates the license to the imported image. If no such license is available, the Bring Your Own License (BYOL) mode is used.</description></item>
            /// <item><description>Aliyun: The license allocated by an official Alibaba Cloud channel for the operating system version specified by <c>Platform</c> is used.</description></item>
            /// <item><description>BYOL: The license that comes with the source operating system is used. When you use the BYOL license, make sure that your license key is supported by Alibaba Cloud.</description></item>
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
            /// <para>The operating system type. Valid value:</para>
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
            /// <para>The version of the operating system. Valid values:</para>
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
            /// <para>Default value: Others Linux when the operating system type is linux, and Other Windows when the operating system type is windows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RetainImportedImage")]
            [Validation(Required=false)]
            public bool? RetainImportedImage { get; set; }

            [NameInMap("RetentionStrategy")]
            [Validation(Required=false)]
            public string RetentionStrategy { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>The instance type. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query instance types.</para>
        /// <para>If you do not configure this parameter, an instance type that provides the fewest vCPUs and memory resources is automatically selected. This configuration is subject to resource availability of instance types. For example, the ecs.g6.large instance type is automatically selected. If available ecs.g6.large resources are insufficient, the ecs.g6.xlarge instance type is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The size of the outbound public bandwidth for the intermediate instance. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The name of the launch template. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para> If you do not specify <c>Name</c>, the return value of <c>ImagePipelineId</c> is used.</para>
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
        /// <para>Specifies whether the image created based on the image template supports the NVMe protocol.</para>
        /// <remarks>
        /// <para> This parameter is no longer used. We recommend that you use ImageOptions.ImageFeatures.NvmeSupport.</para>
        /// </remarks>
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
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The repair mode of the image template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: the standard mode.</para>
        /// <para>Supported check items in Linux operating systems:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.CloudInit</description></item>
        /// <item><description>GUESTOS.Dhcp</description></item>
        /// <item><description>GUESTOS.Virtio</description></item>
        /// <item><description>GUESTOS.OnlineResizeFS</description></item>
        /// <item><description>GUESTOS.Grub</description></item>
        /// <item><description>GUESTOS.Fstab</description></item>
        /// </list>
        /// <para>Supported check items in Windows operating systems:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.Virtio</description></item>
        /// <item><description>GUESTOS.Update</description></item>
        /// <item><description>GUESTOS.Hotfix</description></item>
        /// <item><description>GUESTOS.Server</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> As the check and repair capabilities continue to improve, the number of check items may increase. For more information about check items, see <a href="https://help.aliyun.com/document_detail/439819.html">Overview of image check</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
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
        /// <para>The tags to add to the template.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImagePipelineRequestTag> Tag { get; set; }
        public class CreateImagePipelineRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. Valid values of N: 1 to 20. You cannot specify empty strings as tag keys. The tag key must be 1 to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value must be 0 to 128 characters in length. It cannot start with <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The test content in the image template. The content cannot exceed 16 KB in size. For information about the commands supported by Image Builder, see <a href="https://help.aliyun.com/document_detail/200206.html">Commands supported by Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("TestContent")]
        [Validation(Required=false)]
        public string TestContent { get; set; }

        /// <summary>
        /// <para>The IDs of regions to which you want to distribute the image that is created based on the image template. You can specify up to 20 region IDs.</para>
        /// <para>If you do not specify this parameter, the image is created only in the current region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ToRegionId")]
        [Validation(Required=false)]
        public List<string> ToRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// <para>If you do not specify this parameter, a new VPC and vSwitch are created. Make sure that the VPC quota in your account is sufficient. For more information, see <a href="https://help.aliyun.com/document_detail/27750.html">Limits and quotas</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
