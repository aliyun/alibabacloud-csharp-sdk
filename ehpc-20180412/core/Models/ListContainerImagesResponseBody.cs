// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListContainerImagesResponseBody : TeaModel {
        /// <summary>
        /// The information of the database.
        /// </summary>
        [NameInMap("DBInfo")]
        [Validation(Required=false)]
        public string DBInfo { get; set; }

        /// <summary>
        /// The array of images.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public ListContainerImagesResponseBodyImages Images { get; set; }
        public class ListContainerImagesResponseBodyImages : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<ListContainerImagesResponseBodyImagesImages> Images { get; set; }
            public class ListContainerImagesResponseBodyImagesImages : TeaModel {
                /// <summary>
                /// The image ID.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The name of the certificate application repository.
                /// </summary>
                [NameInMap("Repository")]
                [Validation(Required=false)]
                public string Repository { get; set; }

                /// <summary>
                /// The state of the image.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The container system of the image.
                /// </summary>
                [NameInMap("System")]
                [Validation(Required=false)]
                public string System { get; set; }

                /// <summary>
                /// The tags of the image.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The type of the container. Set the value to singularity.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The time when the image was updated.
                /// </summary>
                [NameInMap("UpdateDateTime")]
                [Validation(Required=false)]
                public string UpdateDateTime { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
