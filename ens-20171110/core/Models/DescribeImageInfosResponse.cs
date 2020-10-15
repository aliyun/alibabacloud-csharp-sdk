// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageInfosResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("Images")]
        [Validation(Required=true)]
        public DescribeImageInfosResponseImages Images { get; set; }
        public class DescribeImageInfosResponseImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=true)]
            public List<DescribeImageInfosResponseImagesImage> Image { get; set; }
            public class DescribeImageInfosResponseImagesImage : TeaModel {
                public string ImageId { get; set; }
                public string Description { get; set; }
                public string ImageVersion { get; set; }
                public string OSType { get; set; }
                public string OSName { get; set; }
                public string ImageSize { get; set; }
            }
        };

    }

}
