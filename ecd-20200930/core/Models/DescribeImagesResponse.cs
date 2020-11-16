// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImagesResponse : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Images")]
        [Validation(Required=true)]
        public List<DescribeImagesResponseImages> Images { get; set; }
        public class DescribeImagesResponseImages : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=true)]
            public string CreationTime { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=true)]
            public string ImageId { get; set; }

            [NameInMap("ImageType")]
            [Validation(Required=true)]
            public string ImageType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=true)]
            public int? Progress { get; set; }

            [NameInMap("Size")]
            [Validation(Required=true)]
            public int? Size { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=true)]
            public string OsType { get; set; }

        }

    }

}
