// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class PriceComponentsValue : TeaModel {
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("tradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

        [NameInMap("originalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        [NameInMap("moduleSum")]
        [Validation(Required=false)]
        public float? ModuleSum { get; set; }

        [NameInMap("effectiveModuleSum")]
        [Validation(Required=false)]
        public float? EffectiveModuleSum { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public float? Quantity { get; set; }

        [NameInMap("pricingUnit")]
        [Validation(Required=false)]
        public string PricingUnit { get; set; }

        [NameInMap("modules")]
        [Validation(Required=false)]
        public List<PriceComponentsValueModules> Modules { get; set; }
        public class PriceComponentsValueModules : TeaModel {
            [NameInMap("moduleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            [NameInMap("costAfterDiscount")]
            [Validation(Required=false)]
            public float? CostAfterDiscount { get; set; }

            [NameInMap("originalCost")]
            [Validation(Required=false)]
            public float? OriginalCost { get; set; }

            [NameInMap("invoiceDiscount")]
            [Validation(Required=false)]
            public float? InvoiceDiscount { get; set; }

            [NameInMap("unitPrice")]
            [Validation(Required=false)]
            public float? UnitPrice { get; set; }

            [NameInMap("billingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            [NameInMap("usageUnit")]
            [Validation(Required=false)]
            public string UsageUnit { get; set; }

            [NameInMap("quantityUsedForQuote")]
            [Validation(Required=false)]
            public float? QuantityUsedForQuote { get; set; }

        }

        [NameInMap("usageCharges")]
        [Validation(Required=false)]
        public List<PriceComponentsValueUsageCharges> UsageCharges { get; set; }
        public class PriceComponentsValueUsageCharges : TeaModel {
            [NameInMap("moduleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("pricePerUnit")]
            [Validation(Required=false)]
            public float? PricePerUnit { get; set; }

            [NameInMap("originalPricePerUnit")]
            [Validation(Required=false)]
            public float? OriginalPricePerUnit { get; set; }

            [NameInMap("assumedQuantity")]
            [Validation(Required=false)]
            public float? AssumedQuantity { get; set; }

            [NameInMap("assumedQuantityCost")]
            [Validation(Required=false)]
            public float? AssumedQuantityCost { get; set; }

        }

        [NameInMap("chargeComposition")]
        [Validation(Required=false)]
        public string ChargeComposition { get; set; }

    }

}
