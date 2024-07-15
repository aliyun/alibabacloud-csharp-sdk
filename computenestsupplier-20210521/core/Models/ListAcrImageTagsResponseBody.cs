// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListAcrImageTagsResponseBody : TeaModel {
        /// <summary>
        /// The list of images.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListAcrImageTagsResponseBodyImages> Images { get; set; }
        public class ListAcrImageTagsResponseBodyImages : TeaModel {
            /// <summary>
            /// The time when the image was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The image size. Unit: bytes.
            /// </summary>
            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public string ImageSize { get; set; }

            /// <summary>
            /// The time when the image was modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The image version.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
