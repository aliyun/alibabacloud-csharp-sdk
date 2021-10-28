// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayBucketCachesResponseBody : TeaModel {
        [NameInMap("BucketCaches")]
        [Validation(Required=false)]
        public DescribeGatewayBucketCachesResponseBodyBucketCaches BucketCaches { get; set; }
        public class DescribeGatewayBucketCachesResponseBodyBucketCaches : TeaModel {
            [NameInMap("BucketCache")]
            [Validation(Required=false)]
            public List<DescribeGatewayBucketCachesResponseBodyBucketCachesBucketCache> BucketCache { get; set; }
            public class DescribeGatewayBucketCachesResponseBodyBucketCachesBucketCache : TeaModel {
                public string BucketName { get; set; }
                public string CacheMode { get; set; }
                public string CacheStats { get; set; }
                public string Category { get; set; }
                public string GatewayId { get; set; }
                public string GatewayName { get; set; }
                public string Location { get; set; }
                public string MountPoint { get; set; }
                public string Protocol { get; set; }
                public string RegionId { get; set; }
                public string ShareName { get; set; }
                public string Type { get; set; }
                public string VpcCidr { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
