// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeGWSImagesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeGWSImagesResponseBodyImages Images { get; set; }
        public class DescribeGWSImagesResponseBodyImages : TeaModel {
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public List<DescribeGWSImagesResponseBodyImagesImageInfo> ImageInfo { get; set; }
            public class DescribeGWSImagesResponseBodyImagesImageInfo : TeaModel {
                public string Status { get; set; }
                public string ImageType { get; set; }
                public string Progress { get; set; }
                public int? Size { get; set; }
                public string CreateTime { get; set; }
                public string Name { get; set; }
                public string ImageId { get; set; }
            }
        };

    }

}
