// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTagResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The images.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListRepoTagResponseBodyImages> Images { get; set; }
        public class ListRepoTagResponseBodyImages : TeaModel {
            /// <summary>
            /// The digest of the image.
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// The time when the image was created.
            /// </summary>
            [NameInMap("ImageCreate")]
            [Validation(Required=false)]
            public string ImageCreate { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The size of the image.
            /// </summary>
            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public long? ImageSize { get; set; }

            /// <summary>
            /// The time when the image was last updated.
            /// </summary>
            [NameInMap("ImageUpdate")]
            [Validation(Required=false)]
            public string ImageUpdate { get; set; }

            /// <summary>
            /// The status of the image.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag of the image.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
