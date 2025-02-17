// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelinesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the image templates.</para>
        /// </summary>
        [NameInMap("ImagePipeline")]
        [Validation(Required=false)]
        public DescribeImagePipelinesResponseBodyImagePipeline ImagePipeline { get; set; }
        public class DescribeImagePipelinesResponseBodyImagePipeline : TeaModel {
            [NameInMap("ImagePipelineSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet> ImagePipelineSet { get; set; }
            public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet : TeaModel {
                /// <summary>
                /// <para>The IDs of Alibaba Cloud accounts to which to share the image that will be created based on the image template.</para>
                /// </summary>
                [NameInMap("AddAccounts")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts AddAccounts { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts : TeaModel {
                    [NameInMap("AddAccount")]
                    [Validation(Required=false)]
                    public List<string> AddAccount { get; set; }

                }

                /// <summary>
                /// <para>The advanced settings.</para>
                /// </summary>
                [NameInMap("AdvancedOptions")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAdvancedOptions AdvancedOptions { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAdvancedOptions : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether to retain Cloud Assistant. During the image building process, the system automatically installs Cloud Assistant in the intermediate instance to run commands. You can choose whether to retain Cloud Assistant in the new image created based on the image template. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: retains Cloud Assistant.</description></item>
                    /// <item><description>false: does not retain Cloud Assistant.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> This parameter does not affect Cloud Assistant that comes with your image.</para>
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
                /// <item><description>When <c>BaseImageType</c> is set to IMAGE, the value of this parameter is the ID of a custom image.</description></item>
                /// <item><description>When <c>BaseImageType</c> is set to IMAGE_FAMILY, the value of this parameter is the name of an image family.</description></item>
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
                /// <item><description>IMAGE: custom image</description></item>
                /// <item><description>IMAGE_FAMILY: image family</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IMAGE</para>
                /// </summary>
                [NameInMap("BaseImageType")]
                [Validation(Required=false)]
                public string BaseImageType { get; set; }

                /// <summary>
                /// <para>The content of the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FROM IMAGE:m-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("BuildContent")]
                [Validation(Required=false)]
                public string BuildContent { get; set; }

                /// <summary>
                /// <para>The time when the image template was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-24T06:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Indicates whether to release the intermediate instance when the image fails to be created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteInstanceOnFailure")]
                [Validation(Required=false)]
                public bool? DeleteInstanceOnFailure { get; set; }

                /// <summary>
                /// <para>The description of the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The image family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ImageFamily")]
                [Validation(Required=false)]
                public string ImageFamily { get; set; }

                /// <summary>
                /// <para>The name prefix of the image to be created based on the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testImageName</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The ID of the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip-2ze5tsl5bp6nf2b3****</para>
                /// </summary>
                [NameInMap("ImagePipelineId")]
                [Validation(Required=false)]
                public string ImagePipelineId { get; set; }

                /// <summary>
                /// <para>The properties and settings of the image template that you import.</para>
                /// </summary>
                [NameInMap("ImportImageOptions")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptions ImportImageOptions { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptions : TeaModel {
                    /// <summary>
                    /// <para>The operating system architecture. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>x86_64</description></item>
                    /// <item><description>arm64</description></item>
                    /// </list>
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
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BIOS</para>
                    /// </summary>
                    [NameInMap("BootMode")]
                    [Validation(Required=false)]
                    public string BootMode { get; set; }

                    /// <summary>
                    /// <para>The information of disk N from which a custom image is created.</para>
                    /// <list type="bullet">
                    /// <item><description>When N is set to 1, a custom image is created from the system disk.</description></item>
                    /// <item><description>When N is set to an integer in the range of 2 to 17, a custom image is created from a data disk.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("DiskDeviceMappings")]
                    [Validation(Required=false)]
                    public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsDiskDeviceMappings DiskDeviceMappings { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsDiskDeviceMappings : TeaModel {
                        [NameInMap("DiskDeviceMapping")]
                        [Validation(Required=false)]
                        public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                        public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                            /// <summary>
                            /// <para>The size of disk N in the custom image after the image is imported.</para>
                            /// <para>You can use this parameter to specify the sizes of the system disk and data disks in the custom image. When you specify the size of the system disk, make sure that the specified size is greater than or equal to the size of the source image file. Unit: GiB. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>When N is set to 1, this parameter indicates the size of the system disk in the custom image. Valid values: 1 to 2048.</description></item>
                            /// <item><description>When N is set to an integer in the range of 2 to 17, this parameter indicates the size of a data disk in the custom image. Valid values: 1 to 2048.</description></item>
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
                            /// <para>The format of the image. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>RAW</description></item>
                            /// <item><description>VHD</description></item>
                            /// <item><description>QCOW2</description></item>
                            /// </list>
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

                    }

                    /// <summary>
                    /// <para>The attributes of the custom image.</para>
                    /// </summary>
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsFeatures Features { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsFeatures : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the image supports the NVMe protocol. Valid values:</para>
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
                    /// <para>The type of the license to use to activate the operating system after the image is imported. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Auto: ECS detects the operating system of the image and allocates a license to the operating system In this mode, the system first checks whether a license allocated by an official Alibaba Cloud channel is specified in the <c>Platform</c>. If a license allocated by an official Alibaba Cloud channel is specified, the system allocates the license to the imported image. If no such license is specified, the Bring Your Own License (BYOL) mode is used.</description></item>
                    /// <item><description>Aliyun: The license allocated through an official Alibaba Cloud channel is used for the operating system distribution specified by <c>Platform</c>.</description></item>
                    /// <item><description>BYOL: The license that comes with the source operating system is used. When you use the BYOL license, make sure that your license key is supported by Alibaba Cloud.</description></item>
                    /// </list>
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
                    /// <item><description>windows: Windows operating systems</description></item>
                    /// <item><description>linux: Linux operating systems</description></item>
                    /// </list>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>Aliyun</para>
                    /// </summary>
                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to retain the imported image. After the image is imported, the system automatically deletes the source image to prevent unnecessary storage costs. You can also choose whether to retain it. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: retains the image. After the image is imported, the source image is not deleted even if the image building task is canceled or fails.</description></item>
                    /// <item><description>false: does not retain the image.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("RetainImportedImage")]
                    [Validation(Required=false)]
                    public bool? RetainImportedImage { get; set; }

                }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The size of the outbound public bandwidth for the intermediate instance. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>The name of the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testImagePipeline</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the image created based on the image template supports Non-Volatile Memory Express (NVMe). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>supported: The image supports the NVMe protocol. Instances created from the image also support the NVMe protocol.</description></item>
                /// <item><description>unsupported: The image does not support the NVMe protocol. Instances created from the image do not support the NVMe protocol.</description></item>
                /// <item><description>auto: The system automatically checks whether the image supports the NVMe protocol. The system automatically checks whether the NVMe driver is installed on your image before the image is built. If you install or uninstall the NVMe driver during the image building task, the check result may be incorrect. We recommend that you set the value to supported or unsupported based on the image building content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("NvmeSupport")]
                [Validation(Required=false)]
                public string NvmeSupport { get; set; }

                /// <summary>
                /// <para>The repair mode of the image template.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: the standard mode</description></item>
                /// </list>
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

                /// <summary>
                /// <para>The system disk size of the intermediate instance. Unit: GiB</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The tags of the image template.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags Tags { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The content of the image test template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("TestContent")]
                [Validation(Required=false)]
                public string TestContent { get; set; }

                /// <summary>
                /// <para>The IDs of regions to which to distribute the image that will be created based on the image template.</para>
                /// </summary>
                [NameInMap("ToRegionIds")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds ToRegionIds { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds : TeaModel {
                    [NameInMap("ToRegionId")]
                    [Validation(Required=false)]
                    public List<string> ToRegionId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the vSwitch in the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. For information about how to use the return value, see the &quot;Usage notes&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of image templates returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
