// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSaleResponseBody : TeaModel {
        [NameInMap("CheckSale")]
        [Validation(Required=false)]
        public GetCheckSaleResponseBodyCheckSale CheckSale { get; set; }
        public class GetCheckSaleResponseBodyCheckSale : TeaModel {
            [NameInMap("ConsumeCount")]
            [Validation(Required=false)]
            public long? ConsumeCount { get; set; }

            [NameInMap("LoyalUser")]
            [Validation(Required=false)]
            public bool? LoyalUser { get; set; }

            [NameInMap("PurchaseCount")]
            [Validation(Required=false)]
            public long? PurchaseCount { get; set; }

            [NameInMap("SaleUserType")]
            [Validation(Required=false)]
            public int? SaleUserType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
