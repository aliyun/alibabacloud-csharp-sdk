// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class AddSupplierNewItemsRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<AddSupplierNewItemsRequestItemList> ItemList { get; set; }
        public class AddSupplierNewItemsRequestItemList : TeaModel {
            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("SkuList")]
            [Validation(Required=false)]
            public List<int?> SkuList { get; set; }

        }

    }

}
