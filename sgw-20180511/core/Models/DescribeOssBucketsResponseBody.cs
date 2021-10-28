// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeOssBucketsResponseBody : TeaModel {
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public DescribeOssBucketsResponseBodyBuckets Buckets { get; set; }
        public class DescribeOssBucketsResponseBodyBuckets : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public List<DescribeOssBucketsResponseBodyBucketsBucket> Bucket { get; set; }
            public class DescribeOssBucketsResponseBodyBucketsBucket : TeaModel {
                public string Name { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
