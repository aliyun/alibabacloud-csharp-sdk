// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class RenderOrderWithDesignatedTbUidRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("DeliveryAddress")]
        [Validation(Required=false)]
        public string DeliveryAddress { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<RenderOrderWithDesignatedTbUidRequestItemList> ItemList { get; set; }
        public class RenderOrderWithDesignatedTbUidRequestItemList : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("SkuId")]
            [Validation(Required=false)]
            public long? SkuId { get; set; }

        }

        [NameInMap("TbAccountType")]
        [Validation(Required=false)]
        public string TbAccountType { get; set; }

        [NameInMap("TbUserId")]
        [Validation(Required=false)]
        public long? TbUserId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

    }

}
