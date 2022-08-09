// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssStorageAndAccByBucketsResponseBody : TeaModel {
        [NameInMap("BucketList")]
        [Validation(Required=false)]
        public List<GetOssStorageAndAccByBucketsResponseBodyBucketList> BucketList { get; set; }
        public class GetOssStorageAndAccByBucketsResponseBodyBucketList : TeaModel {
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("StorageUsageByte")]
            [Validation(Required=false)]
            public long? StorageUsageByte { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
