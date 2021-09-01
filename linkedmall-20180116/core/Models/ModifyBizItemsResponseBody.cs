// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ModifyBizItemsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("FailedItemList")]
        [Validation(Required=false)]
        public ModifyBizItemsResponseBodyFailedItemList FailedItemList { get; set; }
        public class ModifyBizItemsResponseBodyFailedItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ModifyBizItemsResponseBodyFailedItemListItem> Item { get; set; }
            public class ModifyBizItemsResponseBodyFailedItemListItem : TeaModel {
                public string LmItemId { get; set; }
                public long? ItemId { get; set; }
                public ModifyBizItemsResponseBodyFailedItemListItemSkuIdList SkuIdList { get; set; }
                public class ModifyBizItemsResponseBodyFailedItemListItemSkuIdList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<string> Sku { get; set; }

                }
            }
        };

    }

}
