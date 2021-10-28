// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayImagesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeGatewayImagesResponseBodyImages Images { get; set; }
        public class DescribeGatewayImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeGatewayImagesResponseBodyImagesImage> Image { get; set; }
            public class DescribeGatewayImagesResponseBodyImagesImage : TeaModel {
                public string Description { get; set; }
                public string MD5 { get; set; }
                public string ModifiedDate { get; set; }
                public string Name { get; set; }
                public long? Size { get; set; }
                public string Title { get; set; }
                public string Type { get; set; }
                public string Url { get; set; }
                public string Version { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
