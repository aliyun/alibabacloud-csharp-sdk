// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsInformationData : TeaModel {
        [NameInMap("logisticsStatus")]
        [Validation(Required=false)]
        public string LogisticsStatus { get; set; }

        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        [NameInMap("outerPurchaseOrderId")]
        [Validation(Required=false)]
        public string OuterPurchaseOrderId { get; set; }

        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        [NameInMap("trackingCompanyCode")]
        [Validation(Required=false)]
        public string TrackingCompanyCode { get; set; }

        [NameInMap("trackingCompanyName")]
        [Validation(Required=false)]
        public string TrackingCompanyName { get; set; }

        [NameInMap("trackingNumber")]
        [Validation(Required=false)]
        public string TrackingNumber { get; set; }

    }

}
