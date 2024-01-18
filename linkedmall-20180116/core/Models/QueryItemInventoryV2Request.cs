// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryItemInventoryV2Request : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("DivisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<QueryItemInventoryV2RequestItemList> ItemList { get; set; }
        public class QueryItemInventoryV2RequestItemList : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("SkuIdList")]
            [Validation(Required=false)]
            public List<long?> SkuIdList { get; set; }

        }

    }

}
