// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeEstackImageResponseBody : TeaModel {
        /// <summary>
        /// The array of base images.
        /// </summary>
        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public DescribeEstackImageResponseBodyImageList ImageList { get; set; }
        public class DescribeEstackImageResponseBodyImageList : TeaModel {
            [NameInMap("ImageListInfo")]
            [Validation(Required=false)]
            public List<DescribeEstackImageResponseBodyImageListImageListInfo> ImageListInfo { get; set; }
            public class DescribeEstackImageResponseBodyImageListImageListInfo : TeaModel {
                /// <summary>
                /// The image name.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// The size of the image.
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public int? ImageSize { get; set; }

                /// <summary>
                /// The type of the image.
                /// </summary>
                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// The download URL of the image.
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// The time when the image was last modified.
                /// </summary>
                [NameInMap("RecentUpdateTime")]
                [Validation(Required=false)]
                public string RecentUpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The page number returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of images.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
