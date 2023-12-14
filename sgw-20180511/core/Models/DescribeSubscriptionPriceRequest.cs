// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeSubscriptionPriceRequest : TeaModel {
        [NameInMap("CacheCloudEfficiencySize")]
        [Validation(Required=false)]
        public long? CacheCloudEfficiencySize { get; set; }

        [NameInMap("CacheESSDPl1Size")]
        [Validation(Required=false)]
        public long? CacheESSDPl1Size { get; set; }

        [NameInMap("CacheSSDSize")]
        [Validation(Required=false)]
        public long? CacheSSDSize { get; set; }

        [NameInMap("GatewayClass")]
        [Validation(Required=false)]
        public string GatewayClass { get; set; }

        [NameInMap("PeriodQuantity")]
        [Validation(Required=false)]
        public int? PeriodQuantity { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
