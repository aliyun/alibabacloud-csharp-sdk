// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDatasetInfoResponseBody : TeaModel {
        [NameInMap("DatasetInfo")]
        [Validation(Required=false)]
        public DescribeDatasetInfoResponseBodyDatasetInfo DatasetInfo { get; set; }
        public class DescribeDatasetInfoResponseBodyDatasetInfo : TeaModel {
            /// <summary>
            /// The creation time (UTC) of the dataset.
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
            /// The name of the dataset.
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// The type of the dataset. Valid values:
            /// 
            /// *   JWT_BLOCKING: a JSON Web Token (JWT) blacklist
            /// *   IP_WHITELIST_CIDR : an IP address whitelist
            /// *   PARAMETER_ACCESS : parameter-based access control
            /// </summary>
            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            /// <summary>
            /// The last modification time (UTC) of the dataset.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
