// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class DeliveryItemDetailSynRequest : TeaModel {
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("deliveryItemDetailDTOS")]
        [Validation(Required=false)]
        public List<DeliveryItemDetailSynRequestDeliveryItemDetailDTOS> DeliveryItemDetailDTOS { get; set; }
        public class DeliveryItemDetailSynRequestDeliveryItemDetailDTOS : TeaModel {
            [NameInMap("actualSupplyTime")]
            [Validation(Required=false)]
            public string ActualSupplyTime { get; set; }

            [NameInMap("amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("deliveredAmount")]
            [Validation(Required=false)]
            public long? DeliveredAmount { get; set; }

            [NameInMap("deliveryItemId")]
            [Validation(Required=false)]
            public string DeliveryItemId { get; set; }

            [NameInMap("deliveryPlanId")]
            [Validation(Required=false)]
            public string DeliveryPlanId { get; set; }

            [NameInMap("lastSupplyTime")]
            [Validation(Required=false)]
            public string LastSupplyTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("subDemandSupplyPerformerName")]
            [Validation(Required=false)]
            public string SubDemandSupplyPerformerName { get; set; }

            [NameInMap("subDemandSupplyPerformerUid")]
            [Validation(Required=false)]
            public string SubDemandSupplyPerformerUid { get; set; }

            [NameInMap("subDemandSupplyPmName")]
            [Validation(Required=false)]
            public string SubDemandSupplyPmName { get; set; }

            [NameInMap("subDemandSupplyPmUid")]
            [Validation(Required=false)]
            public string SubDemandSupplyPmUid { get; set; }

            [NameInMap("subOrderId")]
            [Validation(Required=false)]
            public long? SubOrderId { get; set; }

            [NameInMap("supplyStatus")]
            [Validation(Required=false)]
            public string SupplyStatus { get; set; }

            [NameInMap("totalOrderId")]
            [Validation(Required=false)]
            public long? TotalOrderId { get; set; }

        }

        [NameInMap("deliveryItemId")]
        [Validation(Required=false)]
        public string DeliveryItemId { get; set; }

        [NameInMap("deliveryPlanId")]
        [Validation(Required=false)]
        public string DeliveryPlanId { get; set; }

    }

}
