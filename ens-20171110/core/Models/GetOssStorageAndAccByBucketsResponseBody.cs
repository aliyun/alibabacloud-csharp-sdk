// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssStorageAndAccByBucketsResponseBody : TeaModel {
        /// <summary>
        /// The information about the bucket.
        /// </summary>
        [NameInMap("BucketList")]
        [Validation(Required=false)]
        public List<GetOssStorageAndAccByBucketsResponseBodyBucketList> BucketList { get; set; }
        public class GetOssStorageAndAccByBucketsResponseBodyBucketList : TeaModel {
            /// <summary>
            /// The number of times that the bucket is accessed.
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            /// <summary>
            /// The name of the bucket.
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// The storage usage of the bucket. Unit: bytes.
            /// </summary>
            [NameInMap("StorageUsageByte")]
            [Validation(Required=false)]
            public long? StorageUsageByte { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
