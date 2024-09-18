// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderResult : TeaModel {
        [NameInMap("createDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        [NameInMap("distributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("logisticsStatus")]
        [Validation(Required=false)]
        public string LogisticsStatus { get; set; }

        [NameInMap("orderAmount")]
        [Validation(Required=false)]
        public long? OrderAmount { get; set; }

        [NameInMap("orderClosedReason")]
        [Validation(Required=false)]
        public string OrderClosedReason { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("orderLineList")]
        [Validation(Required=false)]
        public List<OrderLineResult> OrderLineList { get; set; }

        [NameInMap("orderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
