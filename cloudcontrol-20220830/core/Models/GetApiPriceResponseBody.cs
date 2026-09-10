// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetApiPriceResponseBody : TeaModel {
        [NameInMap("price")]
        [Validation(Required=false)]
        public GetApiPriceResponseBodyPrice Price { get; set; }
        public class GetApiPriceResponseBodyPrice : TeaModel {
            [NameInMap("billingUnit")]
            [Validation(Required=false)]
            public string BillingUnit { get; set; }

            [NameInMap("calculatedAmount")]
            [Validation(Required=false)]
            public float? CalculatedAmount { get; set; }

            [NameInMap("chargeComposition")]
            [Validation(Required=false)]
            public string ChargeComposition { get; set; }

            [NameInMap("components")]
            [Validation(Required=false)]
            public Dictionary<string, PriceComponentsValue> Components { get; set; }

            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("discountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("originalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            [NameInMap("priceSummary")]
            [Validation(Required=false)]
            public GetApiPriceResponseBodyPricePriceSummary PriceSummary { get; set; }
            public class GetApiPriceResponseBodyPricePriceSummary : TeaModel {
                [NameInMap("chargeComposition")]
                [Validation(Required=false)]
                public string ChargeComposition { get; set; }

                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("effectiveModuleSum")]
                [Validation(Required=false)]
                public float? EffectiveModuleSum { get; set; }

                [NameInMap("moduleSum")]
                [Validation(Required=false)]
                public float? ModuleSum { get; set; }

                [NameInMap("modules")]
                [Validation(Required=false)]
                public List<GetApiPriceResponseBodyPricePriceSummaryModules> Modules { get; set; }
                public class GetApiPriceResponseBodyPricePriceSummaryModules : TeaModel {
                    [NameInMap("billingMode")]
                    [Validation(Required=false)]
                    public string BillingMode { get; set; }

                    [NameInMap("costAfterDiscount")]
                    [Validation(Required=false)]
                    public float? CostAfterDiscount { get; set; }

                    [NameInMap("invoiceDiscount")]
                    [Validation(Required=false)]
                    public float? InvoiceDiscount { get; set; }

                    [NameInMap("moduleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    [NameInMap("originalCost")]
                    [Validation(Required=false)]
                    public float? OriginalCost { get; set; }

                    [NameInMap("quantityUsedForQuote")]
                    [Validation(Required=false)]
                    public float? QuantityUsedForQuote { get; set; }

                    [NameInMap("unitPrice")]
                    [Validation(Required=false)]
                    public float? UnitPrice { get; set; }

                    [NameInMap("usageUnit")]
                    [Validation(Required=false)]
                    public string UsageUnit { get; set; }

                }

                [NameInMap("originalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("pricingUnit")]
                [Validation(Required=false)]
                public string PricingUnit { get; set; }

                [NameInMap("quantity")]
                [Validation(Required=false)]
                public float? Quantity { get; set; }

                [NameInMap("tradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

                [NameInMap("usageCharges")]
                [Validation(Required=false)]
                public List<GetApiPriceResponseBodyPricePriceSummaryUsageCharges> UsageCharges { get; set; }
                public class GetApiPriceResponseBodyPricePriceSummaryUsageCharges : TeaModel {
                    [NameInMap("assumedQuantity")]
                    [Validation(Required=false)]
                    public float? AssumedQuantity { get; set; }

                    [NameInMap("assumedQuantityCost")]
                    [Validation(Required=false)]
                    public float? AssumedQuantityCost { get; set; }

                    [NameInMap("moduleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    [NameInMap("originalPricePerUnit")]
                    [Validation(Required=false)]
                    public float? OriginalPricePerUnit { get; set; }

                    [NameInMap("pricePerUnit")]
                    [Validation(Required=false)]
                    public float? PricePerUnit { get; set; }

                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                }

            }

            [NameInMap("pricingMode")]
            [Validation(Required=false)]
            public string PricingMode { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public float? TotalAmount { get; set; }

            [NameInMap("upstreamRequestId")]
            [Validation(Required=false)]
            public string UpstreamRequestId { get; set; }

            [NameInMap("usageCharges")]
            [Validation(Required=false)]
            public List<GetApiPriceResponseBodyPriceUsageCharges> UsageCharges { get; set; }
            public class GetApiPriceResponseBodyPriceUsageCharges : TeaModel {
                [NameInMap("assumedQuantity")]
                [Validation(Required=false)]
                public float? AssumedQuantity { get; set; }

                [NameInMap("assumedQuantityCost")]
                [Validation(Required=false)]
                public float? AssumedQuantityCost { get; set; }

                [NameInMap("moduleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("originalPricePerUnit")]
                [Validation(Required=false)]
                public float? OriginalPricePerUnit { get; set; }

                [NameInMap("pricePerUnit")]
                [Validation(Required=false)]
                public float? PricePerUnit { get; set; }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
