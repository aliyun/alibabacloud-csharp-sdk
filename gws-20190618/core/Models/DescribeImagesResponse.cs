// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeImagesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public long PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public long PageSize { get; set; }

        [NameInMap("Images")]
        [Validation(Required=true)]
        public List<DescribeImagesResponseImages> Images { get; set; }
        public class DescribeImagesResponseImages : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=true)]
            public string ImageId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Size")]
            [Validation(Required=true)]
            public long Size { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=true)]
            public string Progress { get; set; }

            [NameInMap("ImageType")]
            [Validation(Required=true)]
            public string ImageType { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=true)]
            public string ProductCode { get; set; }

        }

    }

}
