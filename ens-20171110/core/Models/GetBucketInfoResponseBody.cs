// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetBucketInfoResponseBody : TeaModel {
        /// <summary>
        /// The list of bucket information.
        /// </summary>
        [NameInMap("BucketInfo")]
        [Validation(Required=false)]
        public GetBucketInfoResponseBodyBucketInfo BucketInfo { get; set; }
        public class GetBucketInfoResponseBodyBucketInfo : TeaModel {
            /// <summary>
            /// The ACL of the bucket.
            /// 
            /// *   **public-read-write**
            /// *   **public-read**
            /// *   **private** (default)
            /// </summary>
            [NameInMap("BucketAcl")]
            [Validation(Required=false)]
            public string BucketAcl { get; set; }

            /// <summary>
            /// The name of the bucket.
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// The remarks.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The time when the bucket was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Single-node storage. Set the value to sink.
            /// </summary>
            [NameInMap("LogicalBucketType")]
            [Validation(Required=false)]
            public string LogicalBucketType { get; set; }

            /// <summary>
            /// The time when the bucket was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
