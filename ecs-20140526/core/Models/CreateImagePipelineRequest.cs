// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImagePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the Alibaba Cloud accounts to share the destination images with. You can specify up to 20 account IDs.</para>
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
            /// <para>Specifies whether to disable the feature that automatically appends a suffix to the destination image name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disable: Disables the feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("ImageNameSuffix")]
            [Validation(Required=false)]
            public string ImageNameSuffix { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain Cloud Assistant in the destination image. During the image building process, Cloud Assistant is automatically installed on the intermediate instance to run commands. You can select whether to retain Cloud Assistant after the process is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Retain Cloud Assistant.</para>
            /// </description></item>
            /// <item><description><para>false: Do not retain Cloud Assistant.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>This setting does not affect the Cloud Assistant client that is already installed in your image.</para>
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
        /// <para>The base image. The value of this parameter varies based on the value of <c>BaseImageType</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>BaseImageType</c> is <c>IMAGE</c>, specify the ID of the base image.</para>
        /// </description></item>
        /// <item><description><para>If <c>BaseImageType</c> is <c>IMAGE_FAMILY</c>, specify the name of the base image family.</para>
        /// </description></item>
        /// <item><description><para>If <c>BaseImageType</c> is <c>OSS</c>, this parameter is not required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("BaseImage")]
        [Validation(Required=false)]
        public string BaseImage { get; set; }

        /// <summary>
        /// <para>The type of the base image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IMAGE: An ECS image.</para>
        /// </description></item>
        /// <item><description><para>IMAGE_FAMILY: An image family.</para>
        /// </description></item>
        /// <item><description><para>OSS: An OSS object.</para>
        /// </description></item>
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
        /// <para>The content of the image build template. The content can be up to 16 KB in size. For more information about the supported commands, see <a href="https://help.aliyun.com/document_detail/200206.html">Command reference for Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPONENT ic-bp12dvdzvr9k9*****
        /// COMPONENT acs:ecs:cn-hangzhou:18689161186*****:imagecomponent/ComponentName/1.<em>.</em></para>
        /// </summary>
        [NameInMap("BuildContent")]
        [Validation(Required=false)]
        public string BuildContent { get; set; }

        /// <summary>
        /// <para>A client-generated, globally unique token to ensure the idempotence of the request. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Determines whether to release the intermediate instance when the image build fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The instance is released.</para>
        /// </description></item>
        /// <item><description><para>false: The instance is not released.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <remarks>
        /// <para>If an intermediate instance cannot be started, it is not retained by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteInstanceOnFailure")]
        [Validation(Required=false)]
        public bool? DeleteInstanceOnFailure { get; set; }

        /// <summary>
        /// <para>The description of the image pipeline template. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The name of the destination image family.</para>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated. Use <c>ImageOptions.ImageFamily</c> instead.</para>
        /// </remarks>
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
        /// <para>The prefix of the destination image name.</para>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated. Use <c>ImageOptions.ImageName</c> instead.</para>
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
        /// <para>The properties of the destination image.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestImageOptions ImageOptions { get; set; }
        public class CreateImagePipelineRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>The description of the destination image. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the destination image family. The name must be 2 to 128 characters long and start with a letter or a Chinese character. It cannot start with <c>aliyun</c> or <c>acs:</c> or contain <c>http://</c> or <c>https://</c>. Allowed characters include letters, digits, Chinese characters, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>family</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The feature attributes of the destination image.</para>
            /// </summary>
            [NameInMap("ImageFeatures")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImageOptionsImageFeatures ImageFeatures { get; set; }
            public class CreateImagePipelineRequestImageOptionsImageFeatures : TeaModel {
                /// <summary>
                /// <para>Specifies whether the destination image supports NVMe. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>supported: Instances created from this image support the NVMe protocol.</para>
                /// </description></item>
                /// <item><description><para>unsupported: Instances created from this image do not support the NVMe protocol.</para>
                /// </description></item>
                /// <item><description><para>auto: The system automatically checks whether the NVMe driver is installed on your image. This check is performed before the build phase. If you install or uninstall the NVMe driver during the build, the result may be inaccurate. We recommend that you set this parameter to supported or unsupported based on the build content.</para>
                /// </description></item>
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
            /// <para>The prefix of the destination image name. The prefix must be 2 to 64 characters in length. It must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>. It can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
            /// <para>The complete image name is automatically generated by concatenating the prefix and the build task ID (<c>ExecutionId</c>) in the <c>{ImageName}_{ExecutionId}</c> format.</para>
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
                /// <para>The key of the tag. The tag key must be 1 to 128 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag. The tag value can be empty or up to 128 characters long. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The settings for importing an image. This parameter is required when <c>BaseImageType</c> is set to <c>OSS</c>.</para>
        /// </summary>
        [NameInMap("ImportImageOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestImportImageOptions ImportImageOptions { get; set; }
        public class CreateImagePipelineRequestImportImageOptions : TeaModel {
            /// <summary>
            /// <para>The architecture of the image to import. Valid values:</para>
            /// <list type="bullet">
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
            /// </list>
            /// <para>Default value: BIOS. If <c>Architecture</c> is set to <c>arm64</c>, the default value is UEFI and this parameter can be set only to UEFI.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>To prevent startup failures, ensure the boot mode is supported by the image.</para>
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
            /// <para>The information about the disks of the custom image.</para>
            /// <list type="bullet">
            /// <item><description><para>When N is 1, the disk is a system disk.</para>
            /// </description></item>
            /// <item><description><para>When N is a value from 2 to 17, the disk is a data disk.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings> DiskDeviceMappings { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings : TeaModel {
                /// <summary>
                /// <para>The size of the disk to create from the image file, in GiB. For the system disk, this value must be greater than or equal to the size of the image file.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>When N is 1, the disk is the system disk. The size of the system disk can range from 1 GiB to 2,048 GiB.</para>
                /// </description></item>
                /// <item><description><para>When N is a value from 2 to 17, the disk is a data disk. The size of a data disk can range from 1 GiB to 2,048 GiB.</para>
                /// </description></item>
                /// </list>
                /// <para>After you upload the base image file to an OSS bucket, you can view the size of the image file in the bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("DiskImageSize")]
                [Validation(Required=false)]
                public int? DiskImageSize { get; set; }

                /// <summary>
                /// <para>The format of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>RAW</para>
                /// </description></item>
                /// <item><description><para>VHD</para>
                /// </description></item>
                /// <item><description><para>QCOW2</para>
                /// </description></item>
                /// </list>
                /// <para>Default value: If left empty, the system automatically detects the image format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RAW</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The OSS bucket that contains the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecsimageos</para>
                /// </summary>
                [NameInMap("OSSBucket")]
                [Validation(Required=false)]
                public string OSSBucket { get; set; }

                /// <summary>
                /// <para>The name (key) of the image file that is stored in the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_5.4_32.raw</para>
                /// </summary>
                [NameInMap("OSSObject")]
                [Validation(Required=false)]
                public string OSSObject { get; set; }

            }

            /// <summary>
            /// <para>The image feature attributes.</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImportImageOptionsFeatures Features { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsFeatures : TeaModel {
                [NameInMap("ImdsSupport")]
                [Validation(Required=false)]
                public string ImdsSupport { get; set; }

                /// <summary>
                /// <para>Specifies whether the base image to be imported supports NVMe. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>supported: Instances created from this image support the NVMe protocol.</para>
                /// </description></item>
                /// <item><description><para>unsupported: Instances created from this image do not support the NVMe protocol.</para>
                /// </description></item>
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
            /// <para>The license type used to activate the operating system after the image is imported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Auto: Alibaba Cloud attempts to assign a license based on the detected operating system. If an official Alibaba Cloud license for the specified <c>Platform</c> is unavailable, the system defaults to BYOL.</para>
            /// </description></item>
            /// <item><description><para>Aliyun: A license from an official Alibaba Cloud channel is used based on the specified <c>Platform</c>.</para>
            /// </description></item>
            /// <item><description><para>BYOL: The license that comes with the base operating system is used. When you use the BYOL mode, you must make sure that your license key is supported in Alibaba Cloud.</para>
            /// </description></item>
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
            /// <para>The type of the operating system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>windows</para>
            /// </description></item>
            /// <item><description><para>linux</para>
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
            /// <para>Default value: Others Linux if OSType is set to Linux, or Other Windows if OSType is set to Windows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview.</para>
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
        /// <para>The instance type of the intermediate instance. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query instance types.</para>
        /// <para>If you do not specify this parameter, the system automatically selects an instance type with the minimum vCPUs and memory, subject to inventory. For example, <c>ecs.g6.large</c> is selected by default. If <c>ecs.g6.large</c> is out of stock, <c>ecs.g6.xlarge</c> is selected.</para>
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
        /// <para>The name of the image pipeline. It must be 2 to 128 characters long, start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. Allowed characters include letters, digits, Chinese characters, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the value of <c>ImagePipelineId</c> is used as the name.</para>
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
        /// <para>Specifies whether the destination image supports NVMe.</para>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated. Use <c>ImageOptions.ImageFeatures.NvmeSupport</c> instead.</para>
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
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The image repair mode in the image template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: The standard mode.</para>
        /// <para>The check items for Linux systems include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>GUESTOS.CloudInit</para>
        /// </description></item>
        /// <item><description><para>GUESTOS.Dhcp</para>
        /// </description></item>
        /// <item><description><para>GUESTOS.Virtio</para>
        /// </description></item>
        /// <item><description><para>GUESTOS.OnlineResizeFS</para>
        /// </description></item>
        /// <item><description><para>GUESTOS.Grub</para>
        /// </description></item>
        /// <item><description><para>GUESTOS.Fstab</para>
        /// </description></item>
        /// </list>
        /// <para>The check items for Windows systems include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>GUESTOS.Virtio</para>
        /// </description></item>
        /// <item><description><para>GUESTOS.Update</para>
        /// </description></item>
        /// <item><description><para>GUESTOS.Hotfix</para>
        /// </description></item>
        /// <item><description><para>GUESTOS.Server</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The repair items may change as the check and repair capabilities are improved. For more information about each repair item, see <a href="https://help.aliyun.com/document_detail/439819.html">Image check overview</a>.</para>
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
        /// <para>The size of the system disk of the intermediate instance. Unit: GiB. Valid values: 20 to 500.</para>
        /// <para>Default value: 40.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The tags to add to the image pipeline.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImagePipelineRequestTag> Tag { get; set; }
        public class CreateImagePipelineRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N, where N is from 1 to 20. The tag key must be 1 to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N, where N is from 1 to 20. The tag value can be empty or up to 128 characters long. It cannot start with <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The content of the image test template. The content can be up to 16 KB in size. For more information about the supported commands, see <a href="https://help.aliyun.com/document_detail/200206.html">Command reference for Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPONENT ic-bp12dvdzvr9k9*****
        /// COMPONENT acs:ecs:cn-hangzhou:18689161186*****:imagecomponent/ComponentName/1.<em>.</em></para>
        /// </summary>
        [NameInMap("TestContent")]
        [Validation(Required=false)]
        public string TestContent { get; set; }

        /// <summary>
        /// <para>The IDs of destination regions for image distribution. You can specify up to 20 region IDs.</para>
        /// <para>If you do not specify this parameter, the images are created only in the current region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ToRegionId")]
        [Validation(Required=false)]
        public List<string> ToRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the VSwitch in the VPC that is used to launch the intermediate instance.</para>
        /// <para>If you do not specify this parameter, a new VPC and VSwitch are created. Ensure that you have a sufficient quota of VPC resources. For more information, see <a href="https://help.aliyun.com/document_detail/27750.html">Usage limits</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
