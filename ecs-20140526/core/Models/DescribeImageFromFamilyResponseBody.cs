// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageFromFamilyResponseBody : TeaModel {
        /// <summary>
        /// <para>The image information.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public DescribeImageFromFamilyResponseBodyImage Image { get; set; }
        public class DescribeImageFromFamilyResponseBodyImage : TeaModel {
            /// <summary>
            /// <para>The image architecture. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>i386</description></item>
            /// <item><description>x86_64</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>x86_64</para>
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// <para>The time when the image was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-01-10T01:01:10Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mappings between the disks and snapshots under the image.</para>
            /// </summary>
            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public DescribeImageFromFamilyResponseBodyImageDiskDeviceMappings DiskDeviceMappings { get; set; }
            public class DescribeImageFromFamilyResponseBodyImageDiskDeviceMappings : TeaModel {
                [NameInMap("DiskDeviceMapping")]
                [Validation(Required=false)]
                public List<DescribeImageFromFamilyResponseBodyImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                public class DescribeImageFromFamilyResponseBodyImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                    /// <summary>
                    /// <para>The device name of the disk. Example: /dev/xvdb.</para>
                    /// <remarks>
                    /// <para> This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/dev/xvdb</para>
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
                    /// <para>The OSS bucket that contains the imported image file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testEcsImport</para>
                    /// </summary>
                    [NameInMap("ImportOSSBucket")]
                    [Validation(Required=false)]
                    public string ImportOSSBucket { get; set; }

                    /// <summary>
                    /// <para>The OSS object corresponding to the imported image file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>imageImport</para>
                    /// </summary>
                    [NameInMap("ImportOSSObject")]
                    [Validation(Required=false)]
                    public string ImportOSSObject { get; set; }

                    /// <summary>
                    /// <para>The size of the disk. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
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
                    /// <para>custom</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the image family.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testImageFamily</para>
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
            /// <para>The alias of the image owner. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: public images provided by Alibaba Cloud</description></item>
            /// <item><description>self: your custom images</description></item>
            /// <item><description>others: shared images from other Alibaba Cloud accounts</description></item>
            /// <item><description>marketplace: Alibaba Cloud Marketplace images</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>self</para>
            /// </summary>
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

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
            /// <para>Indicates whether the image has been shared to other Alibaba Cloud accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSelfShared")]
            [Validation(Required=false)]
            public string IsSelfShared { get; set; }

            /// <summary>
            /// <para>Indicates whether you have subscribed to the image corresponding to the specified product code.</para>
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
            /// <para>The name of the operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Linux 2.1903</para>
            /// </summary>
            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            /// <summary>
            /// <para>The type of the operating system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows</description></item>
            /// <item><description>linux</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// <para>The platform of the operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The product code of the Alibaba Cloud Marketplace image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jxsc00****</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The image creation progress. Unit: percent (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The size of the image. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The status of the image. Valid values:</para>
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
            /// <para>An array that consists of Tag data.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeImageFromFamilyResponseBodyImageTags Tags { get; set; }
            public class DescribeImageFromFamilyResponseBodyImageTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeImageFromFamilyResponseBodyImageTagsTag> Tag { get; set; }
                public class DescribeImageFromFamilyResponseBodyImageTagsTag : TeaModel {
                    /// <summary>
                    /// <para>The tag key of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The tag value of the image.</para>
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
            /// <para>Indicates whether the image has been used to create ECS instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>instance: The image has been used to create one or more ECS instances.</description></item>
            /// <item><description>none: The image has not been used to create ECS instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
