// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ModifyBizItemsRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<ModifyBizItemsRequestItemList> ItemList { get; set; }
        public class ModifyBizItemsRequestItemList : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("SkuList")]
            [Validation(Required=false)]
            public List<ModifyBizItemsRequestItemListSkuList> SkuList { get; set; }
            public class ModifyBizItemsRequestItemListSkuList : TeaModel {
                [NameInMap("BenefitId")]
                [Validation(Required=false)]
                public string BenefitId { get; set; }

                [NameInMap("Points")]
                [Validation(Required=false)]
                public long? Points { get; set; }

                [NameInMap("PointsAmount")]
                [Validation(Required=false)]
                public long? PointsAmount { get; set; }

                [NameInMap("PriceCent")]
                [Validation(Required=false)]
                public long? PriceCent { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("StatusAction")]
                [Validation(Required=false)]
                public long? StatusAction { get; set; }

            }

        }

        [NameInMap("SubBizId")]
        [Validation(Required=false)]
        public string SubBizId { get; set; }

    }

}
