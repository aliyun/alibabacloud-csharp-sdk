// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImagesResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. 0 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about images.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeImagesResponseBodyImages Images { get; set; }
        public class DescribeImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeImagesResponseBodyImagesImage> Image { get; set; }
            public class DescribeImagesResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// The architecture of the image. Example: **x86_64**.
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// The time when the image was created. The time follows the ISO 8601 standard.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The name of the image.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// The source of the image. Valid values:
                /// 
                /// *   system: Alibaba Cloud public images
                /// *   self: your custom images
                /// *   others: shared images from other Alibaba Cloud accounts, or community images published by other Alibaba Cloud accounts
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// The size of the image. Unit: GiB.
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public string ImageSize { get; set; }

                /// <summary>
                /// The operating system type of the image. Valid values:
                /// 
                /// *   Linux
                /// *   Windows
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The ID of the snapshot.
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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
