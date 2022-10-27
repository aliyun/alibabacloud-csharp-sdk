// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeEstackImageResponseBody : TeaModel {
        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public DescribeEstackImageResponseBodyImageList ImageList { get; set; }
        public class DescribeEstackImageResponseBodyImageList : TeaModel {
            [NameInMap("ImageListInfo")]
            [Validation(Required=false)]
            public List<DescribeEstackImageResponseBodyImageListImageListInfo> ImageListInfo { get; set; }
            public class DescribeEstackImageResponseBodyImageListImageListInfo : TeaModel {
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public int? ImageSize { get; set; }

                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("RecentUpdateTime")]
                [Validation(Required=false)]
                public string RecentUpdateTime { get; set; }

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
