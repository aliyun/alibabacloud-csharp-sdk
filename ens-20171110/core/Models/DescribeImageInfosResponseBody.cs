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

        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeImageInfosResponseBodyImages Images { get; set; }
        public class DescribeImageInfosResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeImageInfosResponseBodyImagesImage> Image { get; set; }
            public class DescribeImageInfosResponseBodyImagesImage : TeaModel {
                [NameInMap("ComputeType")]
                [Validation(Required=false)]
                public string ComputeType { get; set; }

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

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public string ImageSize { get; set; }

                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
