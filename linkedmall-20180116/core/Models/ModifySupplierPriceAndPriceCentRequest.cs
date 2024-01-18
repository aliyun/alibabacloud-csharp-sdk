// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ModifySupplierPriceAndPriceCentRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("LmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        [NameInMap("LmShopId")]
        [Validation(Required=false)]
        public string LmShopId { get; set; }

        [NameInMap("PriceCent")]
        [Validation(Required=false)]
        public string PriceCent { get; set; }

        [NameInMap("SkuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        [NameInMap("SupplierPrice")]
        [Validation(Required=false)]
        public string SupplierPrice { get; set; }

    }

}
