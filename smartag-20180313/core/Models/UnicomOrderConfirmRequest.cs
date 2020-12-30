// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class UnicomOrderConfirmRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        [NameInMap("TradeId")]
        [Validation(Required=false)]
        public string TradeId { get; set; }

        [NameInMap("TmsCode")]
        [Validation(Required=false)]
        public string TmsCode { get; set; }

        [NameInMap("TmsOrderCode")]
        [Validation(Required=false)]
        public string TmsOrderCode { get; set; }

        [NameInMap("OrderPostFee")]
        [Validation(Required=false)]
        public long? OrderPostFee { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("OrderItem")]
        [Validation(Required=false)]
        public List<UnicomOrderConfirmRequestOrderItem> OrderItem { get; set; }
        public class UnicomOrderConfirmRequestOrderItem : TeaModel {
            [NameInMap("ItemAmount")]
            [Validation(Required=false)]
            public string ItemAmount { get; set; }

            [NameInMap("ScItemName")]
            [Validation(Required=false)]
            public string ScItemName { get; set; }

            [NameInMap("OrderItemId")]
            [Validation(Required=false)]
            public string OrderItemId { get; set; }

            [NameInMap("TradeItemId")]
            [Validation(Required=false)]
            public string TradeItemId { get; set; }

            [NameInMap("SnList")]
            [Validation(Required=false)]
            public List<string> SnList { get; set; }

            [NameInMap("TradeId")]
            [Validation(Required=false)]
            public string TradeId { get; set; }

            [NameInMap("ItemQuantity")]
            [Validation(Required=false)]
            public int? ItemQuantity { get; set; }

            [NameInMap("ScItemCode")]
            [Validation(Required=false)]
            public string ScItemCode { get; set; }

        }

    }

}
