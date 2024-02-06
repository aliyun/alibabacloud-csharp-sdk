// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListBucketsResponseBody : TeaModel {
        /// <summary>
        /// The list of bucket information.
        /// </summary>
        [NameInMap("BucketInfos")]
        [Validation(Required=false)]
        public List<ListBucketsResponseBodyBucketInfos> BucketInfos { get; set; }
        public class ListBucketsResponseBodyBucketInfos : TeaModel {
            /// <summary>
            /// The access control list (ACL) of the bucket.
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
            /// The time when the bucket was created. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the region where the node is located.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// Single-node storage. Set the value to sink.
            /// </summary>
            [NameInMap("LogicalBucketType")]
            [Validation(Required=false)]
            public string LogicalBucketType { get; set; }

            /// <summary>
            /// The time when the bucket was modified. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
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

        /// <summary>
        /// The total number of buckets that match the conditions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
