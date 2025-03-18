// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSelfImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The image information.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeSelfImagesResponseBodyImages Images { get; set; }
        public class DescribeSelfImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeSelfImagesResponseBodyImagesImage> Image { get; set; }
            public class DescribeSelfImagesResponseBodyImagesImage : TeaModel {
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
                /// <para>Computing type. ens_vm/ens: x86 computing. bare_metal: x86 bare machine or x86 bare metal. arm_vm: ARM computing. arm_bare_metal: ARM bare machine or ARM bare metal. pcfarm: heterogeneous computing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ens_vm</para>
                /// </summary>
                [NameInMap("ComputeType")]
                [Validation(Required=false)]
                public string ComputeType { get; set; }

                /// <summary>
                /// <para>The image creation time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-08T12:10:03Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The mappings between the disk and the snapshot in the image.</para>
                /// </summary>
                [NameInMap("DiskDeviceMappings")]
                [Validation(Required=false)]
                public DescribeSelfImagesResponseBodyImagesImageDiskDeviceMappings DiskDeviceMappings { get; set; }
                public class DescribeSelfImagesResponseBodyImagesImageDiskDeviceMappings : TeaModel {
                    [NameInMap("DiskDeviceMapping")]
                    [Validation(Required=false)]
                    public List<DescribeSelfImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                    public class DescribeSelfImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                        /// <summary>
                        /// <para>The format of the image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The format of the image.
                        /// raw
                        /// qcow2</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The size of the disk. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        /// <summary>
                        /// <para>The type of the disk. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>system: system disk.</description></item>
                        /// <item><description>data: data disk.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Data</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The ID of image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-test</para>
                        /// </summary>
                        [NameInMap("imageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_6_08_64_20G_a****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_6_08_64_20G_a****</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The source of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>others</b>: a custom image that is shared by other Alibaba Cloud accounts.</description></item>
                /// <item><description><b>self</b>: your own custom image.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// <para>The size of the image. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public string ImageSize { get; set; }

                /// <summary>
                /// <para>The size of the image storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("ImageStorageSize")]
                [Validation(Required=false)]
                public string ImageStorageSize { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-5iqczfxps7csjrxeca****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The operating system version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7.2</para>
                /// </summary>
                [NameInMap("OsVersion")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// <para>The platform.</para>
                /// <list type="bullet">
                /// <item><description>centos</description></item>
                /// <item><description>ubuntu</description></item>
                /// <item><description>alios</description></item>
                /// <item><description>debian</description></item>
                /// <item><description>rhel</description></item>
                /// <item><description>windows</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>centos</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The snapshot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-5yt3bdedxzdz6t6uuw****</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// <para>The state of the image.</para>
                /// <list type="bullet">
                /// <item><description>Creating.</description></item>
                /// <item><description>Packing.</description></item>
                /// <item><description>Uploading.</description></item>
                /// <item><description>Pack_failed.</description></item>
                /// <item><description>Upload_failed.</description></item>
                /// <item><description>Available: Only images in the Available state can be used and operated.</description></item>
                /// <item><description>Unavailable.</description></item>
                /// <item><description>Copying.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Creating</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8B8EB73-B4FD-4262-8EF6-680DF39C9BA0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
