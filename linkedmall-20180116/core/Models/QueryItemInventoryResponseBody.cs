// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryItemInventoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public QueryItemInventoryResponseBodyItemList ItemList { get; set; }
        public class QueryItemInventoryResponseBodyItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryItemInventoryResponseBodyItemListItem> Item { get; set; }
            public class QueryItemInventoryResponseBodyItemListItem : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("SkuList")]
                [Validation(Required=false)]
                public QueryItemInventoryResponseBodyItemListItemSkuList SkuList { get; set; }
                public class QueryItemInventoryResponseBodyItemListItemSkuList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<QueryItemInventoryResponseBodyItemListItemSkuListSku> Sku { get; set; }
                    public class QueryItemInventoryResponseBodyItemListItemSkuListSku : TeaModel {
                        [NameInMap("Inventory")]
                        [Validation(Required=false)]
                        public QueryItemInventoryResponseBodyItemListItemSkuListSkuInventory Inventory { get; set; }
                        public class QueryItemInventoryResponseBodyItemListItemSkuListSkuInventory : TeaModel {
                            [NameInMap("Quantity")]
                            [Validation(Required=false)]
                            public long? Quantity { get; set; }

                        }

                        /// <summary>
                        /// skuId
                        /// </summary>
                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                    }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
