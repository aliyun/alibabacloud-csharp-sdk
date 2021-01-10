// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ModifyBasicAndBizItemsResponseBody : TeaModel {
        [NameInMap("FailedItemList")]
        [Validation(Required=false)]
        public ModifyBasicAndBizItemsResponseBodyFailedItemList FailedItemList { get; set; }
        public class ModifyBasicAndBizItemsResponseBodyFailedItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ModifyBasicAndBizItemsResponseBodyFailedItemListItem> Item { get; set; }
            public class ModifyBasicAndBizItemsResponseBodyFailedItemListItem : TeaModel {
                public string LmItemId { get; set; }
                public long? ItemId { get; set; }
                public ModifyBasicAndBizItemsResponseBodyFailedItemListItemSkuIdList SkuIdList { get; set; }
                public class ModifyBasicAndBizItemsResponseBodyFailedItemListItemSkuIdList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<string> Sku { get; set; }

                }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
