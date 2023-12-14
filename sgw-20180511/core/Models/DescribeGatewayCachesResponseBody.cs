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
                [NameInMap("BuyURL")]
                [Validation(Required=false)]
                public string BuyURL { get; set; }

                [NameInMap("CacheId")]
                [Validation(Required=false)]
                public string CacheId { get; set; }

                [NameInMap("CacheType")]
                [Validation(Required=false)]
                public string CacheType { get; set; }

                [NameInMap("ExpireStatus")]
                [Validation(Required=false)]
                public int? ExpireStatus { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                /// <summary>
                /// IOPS。
                /// </summary>
                [NameInMap("Iops")]
                [Validation(Required=false)]
                public long? Iops { get; set; }

                [NameInMap("IsDirectExpand")]
                [Validation(Required=false)]
                public string IsDirectExpand { get; set; }

                [NameInMap("IsNoPartition")]
                [Validation(Required=false)]
                public bool? IsNoPartition { get; set; }

                [NameInMap("IsUsed")]
                [Validation(Required=false)]
                public bool? IsUsed { get; set; }

                [NameInMap("LocalFilePath")]
                [Validation(Required=false)]
                public string LocalFilePath { get; set; }

                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                [NameInMap("RenewURL")]
                [Validation(Required=false)]
                public string RenewURL { get; set; }

                [NameInMap("SizeInGB")]
                [Validation(Required=false)]
                public long? SizeInGB { get; set; }

                [NameInMap("SubscriptionInstanceId")]
                [Validation(Required=false)]
                public string SubscriptionInstanceId { get; set; }

            }

        }

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
