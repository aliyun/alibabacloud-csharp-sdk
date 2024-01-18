// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ModifyBasicAndBizItemsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FailedItemList")]
        [Validation(Required=false)]
        public ModifyBasicAndBizItemsResponseBodyFailedItemList FailedItemList { get; set; }
        public class ModifyBasicAndBizItemsResponseBodyFailedItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ModifyBasicAndBizItemsResponseBodyFailedItemListItem> Item { get; set; }
            public class ModifyBasicAndBizItemsResponseBodyFailedItemListItem : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("SkuIdList")]
                [Validation(Required=false)]
                public ModifyBasicAndBizItemsResponseBodyFailedItemListItemSkuIdList SkuIdList { get; set; }
                public class ModifyBasicAndBizItemsResponseBodyFailedItemListItemSkuIdList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<string> Sku { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
