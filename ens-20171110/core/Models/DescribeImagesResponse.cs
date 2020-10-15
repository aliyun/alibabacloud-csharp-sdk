// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImagesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Images")]
        [Validation(Required=true)]
        public DescribeImagesResponseImages Images { get; set; }
        public class DescribeImagesResponseImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=true)]
            public List<DescribeImagesResponseImagesImage> Image { get; set; }
            public class DescribeImagesResponseImagesImage : TeaModel {
                public string ImageId { get; set; }
                public string ImageName { get; set; }
                public string ImageOwnerAlias { get; set; }
                public string Platform { get; set; }
                public string Architecture { get; set; }
                public string CreationTime { get; set; }
                public string ImageSize { get; set; }
            }
        };

    }

}
