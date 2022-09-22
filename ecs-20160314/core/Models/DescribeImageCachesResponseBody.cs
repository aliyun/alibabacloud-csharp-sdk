// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeImageCachesResponseBody : TeaModel {
        [NameInMap("ImageCaches")]
        [Validation(Required=false)]
        public DescribeImageCachesResponseBodyImageCaches ImageCaches { get; set; }
        public class DescribeImageCachesResponseBodyImageCaches : TeaModel {
            [NameInMap("ImageCache")]
            [Validation(Required=false)]
            public List<DescribeImageCachesResponseBodyImageCachesImageCache> ImageCache { get; set; }
            public class DescribeImageCachesResponseBodyImageCachesImageCache : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
