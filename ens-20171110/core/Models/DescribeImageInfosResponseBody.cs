// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageInfosResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about images.
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
                /// The computing type of the image. Valid values:
                /// 
                /// *   ens_vm: x86 computing.
                /// *   arm_vm: ARM computing.
                /// *   bare_metal: x86 bare machine.
                /// *   pcfarm: heterogeneous computing.
                /// </summary>
                [NameInMap("ComputeType")]
                [Validation(Required=false)]
                public string ComputeType { get; set; }

                /// <summary>
                /// The description of the image.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The size of the image. Unit: GiB.
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public string ImageSize { get; set; }

                /// <summary>
                /// The version of the image.
                /// </summary>
                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                /// <summary>
                /// The type of the image. Valid values: **centos**, **debian**, **ubuntu**, and **windows**.
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// The type of the operating system.
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
