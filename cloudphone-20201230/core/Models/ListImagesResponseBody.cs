// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// The list of images.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public ListImagesResponseBodyImages Images { get; set; }
        public class ListImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyImagesImage> Image { get; set; }
            public class ListImagesResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// The time when the image was created. The time follows the ISO 8601 standard.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The image description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The image type.
                /// </summary>
                [NameInMap("ImageCategory")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                /// <summary>
                /// The image ID.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The image name.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// Indicates whether the image is shared with other Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("IsSelfShared")]
                [Validation(Required=false)]
                public bool? IsSelfShared { get; set; }

                /// <summary>
                /// The display name of the OS in Chinese.
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// The display name of the OS in English.
                /// </summary>
                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                /// <summary>
                /// The image OS.
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                /// <summary>
                /// The OS distribution.
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The progress of image creation.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The image state.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Indicates whether the image is used by instances. Valid values:
                /// 
                /// *   none: The image is idle.
                /// *   instance: The image is used by instances.
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of entries that is returned on each page. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
