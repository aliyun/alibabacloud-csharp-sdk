// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImageModifiedRecordsResponseBody : TeaModel {
        [NameInMap("ImageModifiedRecords")]
        [Validation(Required=false)]
        public List<DescribeImageModifiedRecordsResponseBodyImageModifiedRecords> ImageModifiedRecords { get; set; }
        public class DescribeImageModifiedRecordsResponseBodyImageModifiedRecords : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("NewImageId")]
            [Validation(Required=false)]
            public string NewImageId { get; set; }

            [NameInMap("NewImageName")]
            [Validation(Required=false)]
            public string NewImageName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
