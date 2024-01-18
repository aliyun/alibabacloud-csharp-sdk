// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryItemInventoryV2ResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public QueryItemInventoryV2ResponseBodyItemList ItemList { get; set; }
        public class QueryItemInventoryV2ResponseBodyItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryItemInventoryV2ResponseBodyItemListItem> Item { get; set; }
            public class QueryItemInventoryV2ResponseBodyItemListItem : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("SkuList")]
                [Validation(Required=false)]
                public QueryItemInventoryV2ResponseBodyItemListItemSkuList SkuList { get; set; }
                public class QueryItemInventoryV2ResponseBodyItemListItemSkuList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<QueryItemInventoryV2ResponseBodyItemListItemSkuListSku> Sku { get; set; }
                    public class QueryItemInventoryV2ResponseBodyItemListItemSkuListSku : TeaModel {
                        [NameInMap("Inventory")]
                        [Validation(Required=false)]
                        public QueryItemInventoryV2ResponseBodyItemListItemSkuListSkuInventory Inventory { get; set; }
                        public class QueryItemInventoryV2ResponseBodyItemListItemSkuListSkuInventory : TeaModel {
                            [NameInMap("Quantity")]
                            [Validation(Required=false)]
                            public long? Quantity { get; set; }

                        }

                        /// <summary>
                        /// skuid
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
