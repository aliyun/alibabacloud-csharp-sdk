// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageInfosResponseBody : TeaModel {
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

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
