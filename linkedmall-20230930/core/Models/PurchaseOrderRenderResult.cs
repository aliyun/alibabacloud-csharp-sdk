// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderRenderResult : TeaModel {
        [NameInMap("addressList")]
        [Validation(Required=false)]
        public List<AddressInfo> AddressList { get; set; }

        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("orderList")]
        [Validation(Required=false)]
        public List<OrderRenderResult> OrderList { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("unsellableOrderList")]
        [Validation(Required=false)]
        public List<OrderRenderResult> UnsellableOrderList { get; set; }

    }

}
