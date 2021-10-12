// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class GetPolarXPriceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OrderPriceList")]
        [Validation(Required=false)]
        public List<GetPolarXPriceResponseBodyOrderPriceList> OrderPriceList { get; set; }
        public class GetPolarXPriceResponseBodyOrderPriceList : TeaModel {
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public string DiscountAmount { get; set; }

            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("TotalCostAmount")]
            [Validation(Required=false)]
            public string TotalCostAmount { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetPolarXPriceResponseBodyOrderPriceListRules> Rules { get; set; }
            public class GetPolarXPriceResponseBodyOrderPriceListRules : TeaModel {
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
