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
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("CacheMode")]
                [Validation(Required=false)]
                public string CacheMode { get; set; }

                [NameInMap("CacheStats")]
                [Validation(Required=false)]
                public string CacheStats { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("GatewayName")]
                [Validation(Required=false)]
                public string GatewayName { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("MountPoint")]
                [Validation(Required=false)]
                public string MountPoint { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ShareName")]
                [Validation(Required=false)]
                public string ShareName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VpcCidr")]
                [Validation(Required=false)]
                public string VpcCidr { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

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
