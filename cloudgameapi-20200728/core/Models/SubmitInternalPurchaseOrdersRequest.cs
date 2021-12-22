// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class SubmitInternalPurchaseOrdersRequest : TeaModel {
        [NameInMap("OrderList")]
        [Validation(Required=false)]
        public List<SubmitInternalPurchaseOrdersRequestOrderList> OrderList { get; set; }
        public class SubmitInternalPurchaseOrdersRequestOrderList : TeaModel {
            [NameInMap("BatchNumber")]
            [Validation(Required=false)]
            public string BatchNumber { get; set; }

            [NameInMap("FinalPrice")]
            [Validation(Required=false)]
            public long? FinalPrice { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            [NameInMap("GameId")]
            [Validation(Required=false)]
            public string GameId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
