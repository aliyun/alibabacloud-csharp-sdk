// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeImagesResponseBodyImages Images { get; set; }
        public class DescribeImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeImagesResponseBodyImagesImage> Image { get; set; }
            public class DescribeImagesResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// <para>The architecture of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>i386</description></item>
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
                /// <item><description>BIOS: Basic Input/Output System (BIOS)</description></item>
                /// <item><description>UEFI: Unified Extensible Firmware Interface (UEFI)</description></item>
                /// <item><description>UEFI-Preferred: BIOS and UEFI</description></item>
                /// </list>
                /// <para>For information about the image boot modes, see <a href="~~2244655#b9caa9b8bb1wf~~">Image boot modes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIOS</para>
                /// </summary>
                [NameInMap("BootMode")]
                [Validation(Required=false)]
                public string BootMode { get; set; }

                /// <summary>
                /// <para>The time when the image was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-15T06:07:05Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Archive log for Oracle</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Details about the check performed on the image.</para>
                /// </summary>
                [NameInMap("DetectionOptions")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageDetectionOptions DetectionOptions { get; set; }
                public class DescribeImagesResponseBodyImagesImageDetectionOptions : TeaModel {
                    /// <summary>
                    /// <para>The check items.</para>
                    /// </summary>
                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public DescribeImagesResponseBodyImagesImageDetectionOptionsItems Items { get; set; }
                    public class DescribeImagesResponseBodyImagesImageDetectionOptionsItems : TeaModel {
                        [NameInMap("Item")]
                        [Validation(Required=false)]
                        public List<DescribeImagesResponseBodyImagesImageDetectionOptionsItemsItem> Item { get; set; }
                        public class DescribeImagesResponseBodyImagesImageDetectionOptionsItemsItem : TeaModel {
                            /// <summary>
                            /// <para>The name of the check item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Nvme</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The risk that the check item may have.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>NVMe.NotInstallded</para>
                            /// </summary>
                            [NameInMap("RiskCode")]
                            [Validation(Required=false)]
                            public string RiskCode { get; set; }

                            /// <summary>
                            /// <para>The severity of the risk that the check item of the imported custom image has. If the check item is at risk, this parameter is returned. If the check item is not at risk, this parameter is not returned.</para>
                            /// <para>Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>High: The check item is a high-risk item that may affect the startup of the instance. We recommend that you handle the risk.</description></item>
                            /// <item><description>Medium: The check item is a medium-risk item that may affect the startup performance or configurations of the instance. We recommend that you handle the risk.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>High</para>
                            /// </summary>
                            [NameInMap("RiskLevel")]
                            [Validation(Required=false)]
                            public string RiskLevel { get; set; }

                            /// <summary>
                            /// <para>The result of the check item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Supported</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The state of the image check task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Processing</description></item>
                    /// <item><description>Finished</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Processing</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The mappings between disks and snapshots in the image.</para>
                /// </summary>
                [NameInMap("DiskDeviceMappings")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageDiskDeviceMappings DiskDeviceMappings { get; set; }
                public class DescribeImagesResponseBodyImagesImageDiskDeviceMappings : TeaModel {
                    [NameInMap("DiskDeviceMapping")]
                    [Validation(Required=false)]
                    public List<DescribeImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                    public class DescribeImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                        /// <summary>
                        /// <para>The device name of the disk. Example: /dev/xvdb.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/dev/xvda</para>
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// <para>The format of the image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>qcow2</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The Object Storage Service (OSS) bucket that contains the imported image file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testEcsImport</para>
                        /// </summary>
                        [NameInMap("ImportOSSBucket")]
                        [Validation(Required=false)]
                        public string ImportOSSBucket { get; set; }

                        /// <summary>
                        /// <para>The OSS object that corresponds to the imported image file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>imageImport</para>
                        /// </summary>
                        [NameInMap("ImportOSSObject")]
                        [Validation(Required=false)]
                        public string ImportOSSObject { get; set; }

                        /// <summary>
                        /// <para>The progress of the image copy task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32%</para>
                        /// </summary>
                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public string Progress { get; set; }

                        /// <summary>
                        /// <para>The remaining time of the image copy task. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>233</para>
                        /// </summary>
                        [NameInMap("RemainTime")]
                        [Validation(Required=false)]
                        public int? RemainTime { get; set; }

                        /// <summary>
                        /// <para>The size of the disk. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        /// <summary>
                        /// <para>The ID of the snapshot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-bp17ot2q7x72ggtw****</para>
                        /// </summary>
                        [NameInMap("SnapshotId")]
                        [Validation(Required=false)]
                        public string SnapshotId { get; set; }

                        /// <summary>
                        /// <para>The type of the image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>system</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The attributes of the image.</para>
                /// </summary>
                [NameInMap("Features")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageFeatures Features { get; set; }
                public class DescribeImagesResponseBodyImagesImageFeatures : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the image supports the Non-Volatile Memory Express (NVMe) protocol. Valid values:</para>
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
                /// <para>The name of the image family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangzhou-daily-update</para>
                /// </summary>
                [NameInMap("ImageFamily")]
                [Validation(Required=false)]
                public string ImageFamily { get; set; }

                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp1g7004ksh0oeuc****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testImageName</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The source of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: a public image provided by Alibaba Cloud</description></item>
                /// <item><description>self: a custom image that you created</description></item>
                /// <item><description>others: a shared image from another Alibaba Cloud account or a community image published by another Alibaba Cloud account</description></item>
                /// <item><description>marketplace: an Alibaba Cloud Marketplace image</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>self</para>
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the image belongs. This parameter takes effect only if you query shared images or community images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("ImageOwnerId")]
                [Validation(Required=false)]
                public long? ImageOwnerId { get; set; }

                /// <summary>
                /// <para>The version of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is a copy of another image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsCopied")]
                [Validation(Required=false)]
                public bool? IsCopied { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is publicly available. Publicly available images include public images provided by Alibaba Cloud and custom images published as community images. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The image is publicly available.</description></item>
                /// <item><description>false: The image is publicly unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsPublic")]
                [Validation(Required=false)]
                public bool? IsPublic { get; set; }

                /// <summary>
                /// <para>Indicates whether the custom image was shared to other Alibaba Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSelfShared")]
                [Validation(Required=false)]
                public string IsSelfShared { get; set; }

                /// <summary>
                /// <para>Indicates whether you accepted the Terms of Service of the image service that corresponds to the product code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsSubscribed")]
                [Validation(Required=false)]
                public bool? IsSubscribed { get; set; }

                /// <summary>
                /// <para>Indicates whether the image supports cloud-init.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSupportCloudinit")]
                [Validation(Required=false)]
                public bool? IsSupportCloudinit { get; set; }

                /// <summary>
                /// <para>Indicates whether the image can be used on I/O optimized instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSupportIoOptimized")]
                [Validation(Required=false)]
                public bool? IsSupportIoOptimized { get; set; }

                /// <summary>
                /// <para>Indicates whether the image supports logons of non-root users. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The image supports logons of non-root users.</description></item>
                /// <item><description>false: The image does not support logons of non-root users.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LoginAsNonRootSupported")]
                [Validation(Required=false)]
                public bool? LoginAsNonRootSupported { get; set; }

                /// <summary>
                /// <para>The display name of the operating system in Chinese.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Windows Server 2016 Datacenter Edition 64-bit (Simplified Chinese)</para>
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// <para>The display name of the operating system in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Windows Server  2016 Data Center Edition 64bit Chinese Edition</para>
                /// </summary>
                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                /// <summary>
                /// <para>The type of the operating system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>windows</description></item>
                /// <item><description>linux</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                /// <summary>
                /// <para>The operating system platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Windows Server 2016</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud Marketplace product code of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test000****</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The creation progress of the image. Unit: percent (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the image belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The size of the image. Unit: GiB.</para>
                /// <remarks>
                /// <para> If the image contains data disk snapshots, this parameter indicates only the size of the system disk snapshot contained in the image.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The state of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UnAvailable: The image is unavailable.</description></item>
                /// <item><description>Available: The image is available.</description></item>
                /// <item><description>Creating: The image is being created.</description></item>
                /// <item><description>CreateFailed: The image failed to be created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The name of the supplier that published the community image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestName</para>
                /// </summary>
                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                /// <summary>
                /// <para>The tags of the image.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagesResponseBodyImagesImageTags Tags { get; set; }
                public class DescribeImagesResponseBodyImagesImageTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagesResponseBodyImagesImageTagsTag> Tag { get; set; }
                    public class DescribeImagesResponseBodyImagesImageTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DTS</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Oracle</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the image was used to create ECS instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>instance: The image was used to create one or more ECS instances.</description></item>
                /// <item><description>none: The image was not used to create ECS instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66189103-EDB2-43E2-BB60-BFF2B62F4EB8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
