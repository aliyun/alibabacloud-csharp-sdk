// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class PriceComponentsValue : TeaModel {
        /// <summary>
        /// <para>The billing composition. Valid values: recurring_only (all time-based fees), usage_only (all usage-based fees, where a totalAmount of 0 indicates no fixed fees rather than free of charge, and actual costs depend on the unit price and actual usage in usageCharges), or mixed (both, which should be displayed separately). This allows the caller to choose the display text without iterating through modules to determine the composition.</para>
        /// </summary>
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
        public List<PriceComponentsValueModules> Modules { get; set; }
        public class PriceComponentsValueModules : TeaModel {
            /// <summary>
            /// <para>The billing dimension of this module, which is always explicitly output. Valid values: \&quot;recurring\&quot; for time-based fees, which are included in moduleSum and totalAmount; \&quot;usage\&quot; for usage-based fees, where costAfterDiscount is the usage unit price (CNY/usageUnit) and is not included in moduleSum, and the unit price is also provided in usageCharges.</para>
            /// </summary>
            [NameInMap("billingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            [NameInMap("costAfterDiscount")]
            [Validation(Required=false)]
            public float? CostAfterDiscount { get; set; }

            /// <summary>
            /// <para>The discount amount for this module. The value is calculated as invoiceDiscount = originalCost - costAfterDiscount and is precisely provided by the upstream BSS. Manual subtraction in tax-inclusive scenarios may cause precision loss.</para>
            /// </summary>
            [NameInMap("invoiceDiscount")]
            [Validation(Required=false)]
            public float? InvoiceDiscount { get; set; }

            [NameInMap("moduleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            [NameInMap("originalCost")]
            [Validation(Required=false)]
            public float? OriginalCost { get; set; }

            /// <summary>
            /// <para>The estimated usage used for pricing this module. This field has a value only when the caller passes a usage greater than 1 through PricingContext. In this case, costAfterDiscount is the total cost for this usage rather than the unit price. Refer to usageCharges[].pricePerUnit for the normalized unit price. This field is empty when no estimated usage is passed.</para>
            /// </summary>
            [NameInMap("quantityUsedForQuote")]
            [Validation(Required=false)]
            public float? QuantityUsedForQuote { get; set; }

            /// <summary>
            /// <para>The unit price of this module per billing unit, such as CNY/hour, CNY/month, or CNY/unit. This is used to explain the composition of costAfterDiscount in multi-quantity or multi-period scenarios.</para>
            /// </summary>
            [NameInMap("unitPrice")]
            [Validation(Required=false)]
            public float? UnitPrice { get; set; }

            /// <summary>
            /// <para>The usage unit, such as GB or CU. This field has a value when billingMode is \&quot;usage\&quot; and indicates the dimension of costAfterDiscount.</para>
            /// </summary>
            [NameInMap("usageUnit")]
            [Validation(Required=false)]
            public string UsageUnit { get; set; }

        }

        /// <summary>
        /// <para>The total original price before discounts for this pricing inquiry. When originalPrice differs from tradePrice or moduleSum, it indicates that a discount was applied, such as a first-purchase discount or a promotional campaign.</para>
        /// </summary>
        [NameInMap("originalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        /// <summary>
        /// <para>The billing cycle unit, such as \&quot;Hour\&quot;, \&quot;1 Month\&quot;, \&quot;12 Month\&quot;, or \&quot;GB·Month\&quot;, which indicates the time dimension of moduleSum. This field is not returned in the BSS response and must be explicitly declared by the mapping maintainer in pricingTarget.pricingUnit. It is optional for subscription scenarios because the CLI infers it from Period and PeriodUnit. However, it is required for pay-as-you-go scenarios in the mapping; otherwise, the amount has no dimension.</para>
        /// </summary>
        [NameInMap("pricingUnit")]
        [Validation(Required=false)]
        public string PricingUnit { get; set; }

        /// <summary>
        /// <para>The pricing quantity from OpenAPI input parameters, such as Amount in ECS RunInstances. The moduleSum is the unit price per instance, and effectiveModuleSum = moduleSum × quantity is the total price. The caller should present the actual total price for N instances to the user based on this value to avoid mistaking the unit price for the total price.</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public float? Quantity { get; set; }

        [NameInMap("tradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

        /// <summary>
        /// <para>The list of unit prices for pay-as-you-go, usage-based modules, such as CNY/GB or CNY/CU. The amounts for these modules are not included in moduleSum or effectiveModuleSum. This field is empty when there are no usage-based modules.</para>
        /// </summary>
        [NameInMap("usageCharges")]
        [Validation(Required=false)]
        public List<PriceComponentsValueUsageCharges> UsageCharges { get; set; }
        public class PriceComponentsValueUsageCharges : TeaModel {
            /// <summary>
            /// <para>The estimated usage passed by the caller through PricingContext. This field has a value only when it is greater than 1. In this case, this entry also provides the assumedQuantityCost calculated based on this assumed usage.</para>
            /// </summary>
            [NameInMap("assumedQuantity")]
            [Validation(Required=false)]
            public float? AssumedQuantity { get; set; }

            /// <summary>
            /// <para>The module cost calculated based on assumedQuantity, which equals pricePerUnit × assumedQuantity. This cost is not included in totalAmount because it is based on the assumed usage reported by the caller and is not a cost necessarily incurred by this call.</para>
            /// </summary>
            [NameInMap("assumedQuantityCost")]
            [Validation(Required=false)]
            public float? AssumedQuantityCost { get; set; }

            /// <summary>
            /// <para>The billing module code, such as TrafficOut or NatCu. This corresponds to the moduleCode in modules.</para>
            /// </summary>
            [NameInMap("moduleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The original unit price before discounts, in CNY/unit, which is also normalized. This field is empty when not provided by the upstream. The difference between this value and pricePerUnit is the unit price discount for this module.</para>
            /// </summary>
            [NameInMap("originalPricePerUnit")]
            [Validation(Required=false)]
            public float? OriginalPricePerUnit { get; set; }

            /// <summary>
            /// <para>The discounted unit price, in CNY/unit. The actual cost equals pricePerUnit × actual usage. Because the usage is unknown during pricing, it is not included in totalAmount. If the caller passed an estimated usage, the total returned by the upstream is normalized back to the unit price based on that usage.</para>
            /// </summary>
            [NameInMap("pricePerUnit")]
            [Validation(Required=false)]
            public float? PricePerUnit { get; set; }

            /// <summary>
            /// <para>The usage unit, such as GB, CU, or 10,000 requests. This comes from the module-level billing.unit annotation in the mapping. The dimension of pricePerUnit is CNY/unit.</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

    }

}
