// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderCreateCmd : TeaModel {
        [NameInMap("buyerId")]
        [Validation(Required=false)]
        public string BuyerId { get; set; }

        [NameInMap("deliveryAddress")]
        [Validation(Required=false)]
        public AddressInfo DeliveryAddress { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        [NameInMap("outerPurchaseOrderId")]
        [Validation(Required=false)]
        public string OuterPurchaseOrderId { get; set; }

        [NameInMap("productList")]
        [Validation(Required=false)]
        public List<ProductDTO> ProductList { get; set; }

    }

}
