// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryItemInventoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public QueryItemInventoryResponseBodyItemList ItemList { get; set; }
        public class QueryItemInventoryResponseBodyItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryItemInventoryResponseBodyItemListItem> Item { get; set; }
            public class QueryItemInventoryResponseBodyItemListItem : TeaModel {
                public string LmItemId { get; set; }
                public long? ItemId { get; set; }
                public QueryItemInventoryResponseBodyItemListItemSkuList SkuList { get; set; }
                public class QueryItemInventoryResponseBodyItemListItemSkuList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<QueryItemInventoryResponseBodyItemListItemSkuListSku> Sku { get; set; }
                    public class QueryItemInventoryResponseBodyItemListItemSkuListSku : TeaModel {
                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("Inventory")]
                        [Validation(Required=false)]
                        public QueryItemInventoryResponseBodyItemListItemSkuListSkuInventory Inventory { get; set; }
                        public class QueryItemInventoryResponseBodyItemListItemSkuListSkuInventory : TeaModel {
                            [NameInMap("Quantity")]
                            [Validation(Required=false)]
                            public long? Quantity { get; set; }
                        };

                    }

                }
            }
        };

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
