// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetApiPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The pricing result code. Valid values: Success, PricingNotRequired, PricingNotSupported, or an upstream pricing failure code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The server-side pricing result description. The language is specified by the language parameter in the request body and defaults to Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pricing succeeded</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pricing data. This field is omitted for PricingNotRequired and PricingNotSupported results that do not include pricing.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public GetApiPriceResponseBodyPrice Price { get; set; }
        public class GetApiPriceResponseBodyPrice : TeaModel {
            /// <summary>
            /// <para>The common billing dimension for fixed fees, including totalAmount, originalAmount, and discountAmount. This is a canonical field, such as \&quot;Hour\&quot; or \&quot;1 Month\&quot;, derived from the pricingUnit declared in the mapping. It is empty if not declared. This field describes only the dimension for fixed fees. The pay-as-you-go billing method components each have their own unit (see usageCharges[].unit).</para>
            /// </summary>
            [NameInMap("billingUnit")]
            [Validation(Required=false)]
            public string BillingUnit { get; set; }

            [NameInMap("calculatedAmount")]
            [Validation(Required=false)]
            public float? CalculatedAmount { get; set; }

            /// <summary>
            /// <para>The billing composition. This is a canonical field. Valid values: recurring_only (all time-based fees), usage_only (all usage-based fees, where a totalAmount of 0 indicates no fixed fees rather than free of charge, and actual costs depend on the unit price and actual usage in usageCharges), or mixed (both, which should be displayed separately as \&quot;X CNY/hour + Y CNY/GB\&quot;). This allows the caller to choose the display text without iterating through modules to determine the composition.</para>
            /// </summary>
            [NameInMap("chargeComposition")]
            [Validation(Required=false)]
            public string ChargeComposition { get; set; }

            /// <summary>
            /// <para>The details of each pricing call in composite or delta mode. The key is the priceCall ID, such as prepaid, postpaid, or a custom ID. This field is empty in single mode. The calculatedAmount is the aggregated result of each component based on the priceCalculation expression. The components field exposes the line items so that the caller can view the composition, such as instance fees versus storage fees.</para>
            /// </summary>
            [NameInMap("components")]
            [Validation(Required=false)]
            public Dictionary<string, PriceComponentsValue> Components { get; set; }

            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The total discount amount for fixed fees. This is a canonical field calculated as originalAmount - totalAmount. It includes only discounts for fixed fees and excludes the pay-as-you-go billing method. The value is 0 when there is no discount and empty when the original price is missing.</para>
            /// </summary>
            [NameInMap("discountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <para>The error code when upstream pricing fails, such as InvalidParameter or COMMODITY.INVALID_COMPONENT. This field is empty when success is true.</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error description when upstream pricing fails. This facilitates self-troubleshooting of specific parameter issues by the caller. This field is empty when success is true.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The total original price before discounts for fixed fees. This is a canonical field with the same scope as totalAmount. It includes only fixed fees and excludes the pay-as-you-go billing method. Refer to usageCharges[].originalPricePerUnit for the pre-discount unit price of the pay-as-you-go billing method. The difference between this value and totalAmount is the total discount for this inquiry. This field is empty when the upstream does not provide original price information.</para>
            /// </summary>
            [NameInMap("originalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            [NameInMap("priceSummary")]
            [Validation(Required=false)]
            public GetApiPriceResponseBodyPricePriceSummary PriceSummary { get; set; }
            public class GetApiPriceResponseBodyPricePriceSummary : TeaModel {
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
                public List<GetApiPriceResponseBodyPricePriceSummaryModules> Modules { get; set; }
                public class GetApiPriceResponseBodyPricePriceSummaryModules : TeaModel {
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
                public List<GetApiPriceResponseBodyPricePriceSummaryUsageCharges> UsageCharges { get; set; }
                public class GetApiPriceResponseBodyPricePriceSummaryUsageCharges : TeaModel {
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

            [NameInMap("pricingMode")]
            [Validation(Required=false)]
            public string PricingMode { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The periodic payable amount for fixed fees in this pricing inquiry (canonical field). For the unit of measurement, see billingUnit. <b>This field includes only fixed fees</b>. Usage-based charges (such as traffic in CNY/GB or CUs in CNY/CU) have different units of measurement and cannot be added to this field. For the unit prices of usage-based charges, see usageCharges. To check whether both types of charges exist, see chargeComposition. In single mode, this value is derived from priceSummary.effectiveModuleSum (falling back to tradePrice if missing). In composite or delta mode, this value is derived from calculatedAmount. This field always has a value when success is true.</para>
            /// </summary>
            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public float? TotalAmount { get; set; }

            /// <summary>
            /// <para>The request ID of the upstream pricing API (such as the RequestId of BSS GetSubscriptionPrice). This field is populated regardless of whether the request succeeds or fails, and is used for audit reconciliation and upstream log tracing.</para>
            /// </summary>
            [NameInMap("upstreamRequestId")]
            [Validation(Required=false)]
            public string UpstreamRequestId { get; set; }

            /// <summary>
            /// <para>The list of unit prices for usage-based billing modules (canonical field). Modules billed by actual usage, such as traffic and NAT CUs, have different units of measurement (such as CNY/GB or CNY/CU) from billingUnit and are not included in totalAmount. This field provides the unit price for each item. In single mode, the values are derived from priceSummary. In composite or delta mode, the values are concatenated from each component in the order of priceCall. This field is empty when the mapping contains no usage-based modules.</para>
            /// </summary>
            [NameInMap("usageCharges")]
            [Validation(Required=false)]
            public List<GetApiPriceResponseBodyPriceUsageCharges> UsageCharges { get; set; }
            public class GetApiPriceResponseBodyPriceUsageCharges : TeaModel {
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

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether a valid pricing result is obtained. The value is true for normal pricing and when no pricing inquiry is required, and false when pricing is not supported or the pricing inquiry fails.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
