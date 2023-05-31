// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedTagsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// An array that consists of the statistics of the asset tags.
        /// </summary>
        [NameInMap("GroupedFileds")]
        [Validation(Required=false)]
        public List<DescribeGroupedTagsResponseBodyGroupedFileds> GroupedFileds { get; set; }
        public class DescribeGroupedTagsResponseBodyGroupedFileds : TeaModel {
            /// <summary>
            /// The number of assets to which the tag is added.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// The name of the tag.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the tag.
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public int? TagId { get; set; }

        }

        /// <summary>
        /// The HTTP status code of the request.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
