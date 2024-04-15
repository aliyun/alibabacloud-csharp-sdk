// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImageModifiedRecordsResponseBody : TeaModel {
        /// <summary>
        /// Details about the image modification record.
        /// </summary>
        [NameInMap("ImageModifiedRecords")]
        [Validation(Required=false)]
        public List<DescribeImageModifiedRecordsResponseBodyImageModifiedRecords> ImageModifiedRecords { get; set; }
        public class DescribeImageModifiedRecordsResponseBodyImageModifiedRecords : TeaModel {
            /// <summary>
            /// The ID of the original image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The name of the original image.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The ID of the new image after the image was modified.
            /// </summary>
            [NameInMap("NewImageId")]
            [Validation(Required=false)]
            public string NewImageId { get; set; }

            /// <summary>
            /// The name of the new image after the image was modified.
            /// </summary>
            [NameInMap("NewImageName")]
            [Validation(Required=false)]
            public string NewImageName { get; set; }

            /// <summary>
            /// The status of the image modification.
            /// 
            /// Valid values:
            /// 
            /// *   0: The image is being modified.
            /// 
            /// *   1: The image is successfully modified.
            /// 
            /// *   2: The image fails to be modified.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The time when the image was last modified.
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
