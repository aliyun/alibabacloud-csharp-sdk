// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeGWSImagesResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeGWSImagesResponseBodyImages Images { get; set; }
        public class DescribeGWSImagesResponseBodyImages : TeaModel {
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public List<DescribeGWSImagesResponseBodyImagesImageInfo> ImageInfo { get; set; }
            public class DescribeGWSImagesResponseBodyImagesImageInfo : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
