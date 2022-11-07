// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListImagesResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public ListImagesResponseBodyImages Images { get; set; }
        public class ListImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyImagesImage> Image { get; set; }
            public class ListImagesResponseBodyImagesImage : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ImageCategory")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("IsSelfShared")]
                [Validation(Required=false)]
                public bool? IsSelfShared { get; set; }

                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
