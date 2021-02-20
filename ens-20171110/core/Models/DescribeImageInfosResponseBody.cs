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
                public string Description { get; set; }
                public string ImageId { get; set; }
                public string ImageSize { get; set; }
                public string ImageVersion { get; set; }
                public string OSName { get; set; }
                public string OSType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
