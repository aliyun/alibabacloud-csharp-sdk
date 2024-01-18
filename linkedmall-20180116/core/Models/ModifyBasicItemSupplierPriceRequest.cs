// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ModifyBasicItemSupplierPriceRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("LmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        [NameInMap("LmShopId")]
        [Validation(Required=false)]
        public long? LmShopId { get; set; }

        [NameInMap("SkuId")]
        [Validation(Required=false)]
        public long? SkuId { get; set; }

        [NameInMap("SupplierPrice")]
        [Validation(Required=false)]
        public long? SupplierPrice { get; set; }

    }

}
