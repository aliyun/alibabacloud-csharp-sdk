// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryInventoryOfItemsInBizItemGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<QueryInventoryOfItemsInBizItemGroupResponseBodyItemList> ItemList { get; set; }
        public class QueryInventoryOfItemsInBizItemGroupResponseBodyItemList : TeaModel {
            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("SkuList")]
            [Validation(Required=false)]
            public List<QueryInventoryOfItemsInBizItemGroupResponseBodyItemListSkuList> SkuList { get; set; }
            public class QueryInventoryOfItemsInBizItemGroupResponseBodyItemListSkuList : TeaModel {
                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

            }

        }

    }

}
