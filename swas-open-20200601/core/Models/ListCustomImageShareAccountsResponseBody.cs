// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListCustomImageShareAccountsResponseBody : TeaModel {
        /// <summary>
        /// The information about the shared custom images.
        /// </summary>
        [NameInMap("ImageShareUsers")]
        [Validation(Required=false)]
        public List<ListCustomImageShareAccountsResponseBodyImageShareUsers> ImageShareUsers { get; set; }
        public class ListCustomImageShareAccountsResponseBodyImageShareUsers : TeaModel {
            /// <summary>
            /// The time when the custom image is shared.
            /// </summary>
            [NameInMap("SharedTime")]
            [Validation(Required=false)]
            public string SharedTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account whose custom image is shared.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

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
