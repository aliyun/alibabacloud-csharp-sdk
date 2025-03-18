// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned service code. 0 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about images.</para>
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
                /// <para>The architecture of the image. Example: <b>x86_64</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x86_64</para>
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// <para>The time when the image was created. The time follows the ISO 8601 standard.</para>
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
                public DescribeImagesResponseBodyImagesImageDiskDeviceMappings DiskDeviceMappings { get; set; }
                public class DescribeImagesResponseBodyImagesImageDiskDeviceMappings : TeaModel {
                    [NameInMap("DiskDeviceMapping")]
                    [Validation(Required=false)]
                    public List<DescribeImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                    public class DescribeImagesResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
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
                /// <para>centos_6_08_64_20G_alibase_2017****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ubuntu_16.04</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The source of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: Alibaba Cloud public images</description></item>
                /// <item><description>self: your custom images</description></item>
                /// <item><description>others: shared images from other Alibaba Cloud accounts, or community images published by other Alibaba Cloud accounts</description></item>
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
                /// <para>40</para>
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public string ImageSize { get; set; }

                /// <summary>
                /// <para>The operating system type of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Linux</description></item>
                /// <item><description>Windows</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>centos</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The ID of the Edge Node Service (ENS) node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mock-clone_snapshot_id</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8331AA01-C16D-5481-BB47-D19CEBAA811E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
