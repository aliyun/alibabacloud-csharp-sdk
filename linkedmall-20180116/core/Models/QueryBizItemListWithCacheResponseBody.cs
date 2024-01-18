// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryBizItemListWithCacheResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<QueryBizItemListWithCacheResponseBodyItemList> ItemList { get; set; }
        public class QueryBizItemListWithCacheResponseBodyItemList : TeaModel {
            [NameInMap("CanSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("PointPrice")]
            [Validation(Required=false)]
            public long? PointPrice { get; set; }

            [NameInMap("Points")]
            [Validation(Required=false)]
            public long? Points { get; set; }

            [NameInMap("PointsAmount")]
            [Validation(Required=false)]
            public long? PointsAmount { get; set; }

            [NameInMap("PriceCent")]
            [Validation(Required=false)]
            public long? PriceCent { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public long? ReservePrice { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
