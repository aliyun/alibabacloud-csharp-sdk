// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDatasetItemInfoResponseBody : TeaModel {
        /// <summary>
        /// The Dataset information.
        /// </summary>
        [NameInMap("DatasetItemInfo")]
        [Validation(Required=false)]
        public DescribeDatasetItemInfoResponseBodyDatasetItemInfo DatasetItemInfo { get; set; }
        public class DescribeDatasetItemInfoResponseBodyDatasetItemInfo : TeaModel {
            /// <summary>
            /// The creation time (UTC) of the data entry.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The ID of the dataset.
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// The ID of the data entry.
            /// </summary>
            [NameInMap("DatasetItemId")]
            [Validation(Required=false)]
            public string DatasetItemId { get; set; }

            /// <summary>
            /// The description of the data entry.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time in UTC when the data entry expires. The time is in the **yyyy-MM-ddTHH:mm:ssZ** format. If this parameter is empty, the data entry does not expire.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The last modification time (UTC) of the data entry.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The value of the data entry.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
