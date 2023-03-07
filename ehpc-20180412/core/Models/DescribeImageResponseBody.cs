// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeImageResponseBody : TeaModel {
        /// <summary>
        /// The information of the image.
        /// </summary>
        [NameInMap("ImageInfo")]
        [Validation(Required=false)]
        public DescribeImageResponseBodyImageInfo ImageInfo { get; set; }
        public class DescribeImageResponseBodyImageInfo : TeaModel {
            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The name of the repository.
            /// </summary>
            [NameInMap("Repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }

            /// <summary>
            /// The status of the image.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The container system.
            /// </summary>
            [NameInMap("System")]
            [Validation(Required=false)]
            public string System { get; set; }

            /// <summary>
            /// The tag of the image.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The type of the image. Valid values:
            /// 
            /// *   shifter
            /// *   docker
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The time when the image was last updated.
            /// </summary>
            [NameInMap("UpdateDateTime")]
            [Validation(Required=false)]
            public string UpdateDateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
