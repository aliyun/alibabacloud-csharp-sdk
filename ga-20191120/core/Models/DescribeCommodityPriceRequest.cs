// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityPriceRequest : TeaModel {
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceRequestOrders> Orders { get; set; }
        public class DescribeCommodityPriceRequestOrders : TeaModel {
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceRequestOrdersComponents> Components { get; set; }
            public class DescribeCommodityPriceRequestOrdersComponents : TeaModel {
                [NameInMap("ComponentCode")]
                [Validation(Required=false)]
                public string ComponentCode { get; set; }

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<DescribeCommodityPriceRequestOrdersComponentsProperties> Properties { get; set; }
                public class DescribeCommodityPriceRequestOrdersComponentsProperties : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

        }

        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
