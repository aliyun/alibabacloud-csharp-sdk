// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageInfosResponseBody : TeaModel {
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
        /// <para>The information about images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeImageInfosResponseBodyImages Images { get; set; }
        public class DescribeImageInfosResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeImageInfosResponseBodyImagesImage> Image { get; set; }
            public class DescribeImageInfosResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// <para>The computing type of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ens_vm: x86 computing.</description></item>
                /// <item><description>arm_vm: ARM computing.</description></item>
                /// <item><description>bare_metal: x86 bare machine.</description></item>
                /// <item><description>pcfarm: heterogeneous computing.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ens_vm</para>
                /// </summary>
                [NameInMap("ComputeType")]
                [Validation(Required=false)]
                public string ComputeType { get; set; }

                /// <summary>
                /// <para>The description of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_6_08_64_20G_alibase_2017****</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DiskDeviceMappings")]
                [Validation(Required=false)]
                public DescribeImageInfosResponseBodyImagesImageDiskDeviceMappings DiskDeviceMappings { get; set; }
                public class DescribeImageInfosResponseBodyImagesImageDiskDeviceMappings : TeaModel {
                    [NameInMap("DiskDeviceMapping")]
                    [Validation(Required=false)]
                    public List<DescribeImageInfosResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                    public class DescribeImageInfosResponseBodyImagesImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
                /// <para>The size of the image. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public string ImageSize { get; set; }

                /// <summary>
                /// <para>The version of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.8</para>
                /// </summary>
                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                /// <summary>
                /// <para>The type of the image. Valid values: <b>centos</b>, <b>debian</b>, <b>ubuntu</b>, and <b>windows</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos</para>
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// <para>The type of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5568A08C-10A9-47F3-902F-647298B463FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
