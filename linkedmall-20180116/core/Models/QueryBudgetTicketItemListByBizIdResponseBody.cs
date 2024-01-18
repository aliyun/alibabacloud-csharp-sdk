// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryBudgetTicketItemListByBizIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<QueryBudgetTicketItemListByBizIdResponseBodyModel> Model { get; set; }
        public class QueryBudgetTicketItemListByBizIdResponseBodyModel : TeaModel {
            [NameInMap("Invalid")]
            [Validation(Required=false)]
            public bool? Invalid { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("PoCode")]
            [Validation(Required=false)]
            public string PoCode { get; set; }

            [NameInMap("PromotionId")]
            [Validation(Required=false)]
            public string PromotionId { get; set; }

            [NameInMap("RemnantAmount")]
            [Validation(Required=false)]
            public long? RemnantAmount { get; set; }

            [NameInMap("SecurityCode")]
            [Validation(Required=false)]
            public string SecurityCode { get; set; }

            [NameInMap("SettlementPrice")]
            [Validation(Required=false)]
            public long? SettlementPrice { get; set; }

            [NameInMap("SkuId")]
            [Validation(Required=false)]
            public long? SkuId { get; set; }

            [NameInMap("SubsidyAmount")]
            [Validation(Required=false)]
            public long? SubsidyAmount { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
