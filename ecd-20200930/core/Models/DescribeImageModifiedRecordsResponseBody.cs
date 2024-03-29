// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImageModifiedRecordsResponseBody : TeaModel {
        /// <summary>
        /// The image modification record collection.
        /// </summary>
        [NameInMap("ImageModifiedRecords")]
        [Validation(Required=false)]
        public List<DescribeImageModifiedRecordsResponseBodyImageModifiedRecords> ImageModifiedRecords { get; set; }
        public class DescribeImageModifiedRecordsResponseBodyImageModifiedRecords : TeaModel {
            /// <summary>
            /// The ID of the image before the change.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The name of the image before the change.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The ID of the new image.
            /// </summary>
            [NameInMap("NewImageId")]
            [Validation(Required=false)]
            public string NewImageId { get; set; }

            /// <summary>
            /// Add the image name.
            /// </summary>
            [NameInMap("NewImageName")]
            [Validation(Required=false)]
            public string NewImageName { get; set; }

            /// <summary>
            /// The status of the workspace.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The last time when the disaster recovery plan was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// If the NextToken parameter is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of image modification records.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
