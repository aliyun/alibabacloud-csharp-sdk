// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayCachesResponseBody : TeaModel {
        [NameInMap("Caches")]
        [Validation(Required=false)]
        public DescribeGatewayCachesResponseBodyCaches Caches { get; set; }
        public class DescribeGatewayCachesResponseBodyCaches : TeaModel {
            [NameInMap("Cache")]
            [Validation(Required=false)]
            public List<DescribeGatewayCachesResponseBodyCachesCache> Cache { get; set; }
            public class DescribeGatewayCachesResponseBodyCachesCache : TeaModel {
                public string BuyURL { get; set; }
                public string CacheId { get; set; }
                public string CacheType { get; set; }
                public int? ExpireStatus { get; set; }
                public long? ExpiredTime { get; set; }
                public long? Iops { get; set; }
                public bool? IsUsed { get; set; }
                public string LocalFilePath { get; set; }
                public string PerformanceLevel { get; set; }
                public string RenewURL { get; set; }
                public long? SizeInGB { get; set; }
                public string SubscriptionInstanceId { get; set; }
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
