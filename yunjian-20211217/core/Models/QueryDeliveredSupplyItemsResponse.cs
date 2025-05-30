// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class QueryDeliveredSupplyItemsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<QueryDeliveredSupplyItemsResponseBody> Body { get; set; }
        public class QueryDeliveredSupplyItemsResponseBody : TeaModel {
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("commodityTypeCode")]
            [Validation(Required=false)]
            public string CommodityTypeCode { get; set; }

            [NameInMap("demandPlanId")]
            [Validation(Required=false)]
            public long? DemandPlanId { get; set; }

            [NameInMap("planTitle")]
            [Validation(Required=false)]
            public string PlanTitle { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("demandCount")]
            [Validation(Required=false)]
            public int? DemandCount { get; set; }

            [NameInMap("deliveredAmount")]
            [Validation(Required=false)]
            public int? DeliveredAmount { get; set; }

            [NameInMap("openCount")]
            [Validation(Required=false)]
            public int? OpenCount { get; set; }

        }

    }

}
