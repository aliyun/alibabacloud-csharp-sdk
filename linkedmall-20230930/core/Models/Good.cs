// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Good : TeaModel {
        [NameInMap("goodName")]
        [Validation(Required=false)]
        public string GoodName { get; set; }

        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        [NameInMap("skuTitle")]
        [Validation(Required=false)]
        public string SkuTitle { get; set; }

    }

}
