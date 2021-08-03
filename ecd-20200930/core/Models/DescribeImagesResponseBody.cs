// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImagesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<DescribeImagesResponseBodyImages> Images { get; set; }
        public class DescribeImagesResponseBodyImages : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("GpuCategory")]
            [Validation(Required=false)]
            public bool? GpuCategory { get; set; }

        }

    }

}
